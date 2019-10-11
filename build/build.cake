#tool "nuget:?package=GitVersion.CommandLine"

//////////////////////////////////////////////////////////////////////
// ARGUMENTS
//////////////////////////////////////////////////////////////////////

// base arguments
var target = Argument("target", "PublishPackage");
var configuration = Argument("configuration", "Release");

// solutions
var solution = Argument("solution", "../CyberSource.RestClient.DotNet.sln");

// project files
var packageLibrary = Argument("projectPath", "../src/CyberSource.RestClient.DotNet/CyberSource.RestClient.DotNet.csproj");

// projects path
var packageProjectPath = Argument("packageProjectPath", "../src/CyberSource.RestClient.DotNet");

// nuspec file for package
var packageLibrarySpec = Argument("packageLibrarySpec", "../src/CyberSource.RestClient.DotNet/CyberSource.RestClient.DotNet.nuspec");
if (configuration == "Debug") {
    packageLibrarySpec = Argument("packageLibrarySpec", "../src/CyberSource.RestClient.DotNet/CyberSource.RestClient.DotNet.Debug.nuspec");
}

// version - Default 
var packageVersion = Argument("packageVersion", "1.0.3"); // need to be updated manually!

//////////////////////////////////////////////////////////////////////
// PREPARATION
//////////////////////////////////////////////////////////////////////

var packagePublishPath = Directory("../artifacts/packages/");

// local on working laptop
var nuGetFeedPath = "http://localhost/v3/index.json";
var nuGetApiKey = "";

var packagesPattern = "../artifacts/packages/*.nupkg";

// .NET core framework - not in use!
var frameworkVersion = "netcoreapp2.2";

//////////////////////////////////////////////////////////////////////
// Shared functions for tasks.
//////////////////////////////////////////////////////////////////////


// configuration for MsBuild with dotnet CLI to set version of the assemblies
public DotNetCoreMSBuildSettings CreateSettings() {
    var settings = new DotNetCoreMSBuildSettings();
    settings.SetVersion(packageVersion);
    settings.SetFileVersion(packageVersion);
    
    return settings;
}

//----------------------------------------------------------------------
// Common tasks.
//----------------------------------------------------------------------

Task("Info")
    .Does(() => {
        Information("Configuration: " + configuration);
    });

Task("Version")
    .Does(() => {
        // initialize version for Build server
        GitVersion(new GitVersionSettings{
            UpdateAssemblyInfo = true,
            OutputType = GitVersionOutput.BuildServer
        });

        // initialize version for local usage
        var versionInfo = GitVersion(new GitVersionSettings{ 
            OutputType = GitVersionOutput.Json
        });

        Information("SemVersion: " + versionInfo.SemVer);

        // update version to set as File and Assembly version during build
        packageVersion = versionInfo.SemVer;

        // custom logic to build server to update Build number based on version of the application comes from GitVersion
        // need to be update to use TFBuild.IsRunningOnAzurePipelines!
        if (TFBuild.IsRunningOnAzurePipelines) {
            TFBuild.Commands.UpdateBuildNumber(packageVersion);
        }
    })
    .OnError(exception => Error(exception));

//----------------------------------------------------------------------
// Tasks for build and prepare NuGet package for library.
//----------------------------------------------------------------------

Task("CleanPackage")
    .IsDependentOn("Info")
    .Does(() => {
        CleanDirectory(packagePublishPath);

        var settings = new DotNetCoreCleanSettings
        {
            //Framework = frameworkVersion,
            Configuration = configuration
        };

        DotNetCoreClean(solution, settings);
    })
    .OnError(exception => Error(exception));

Task("RestorePackage")
    .IsDependentOn("CleanPackage")
    .Does(() => {
        var settings = new DotNetCoreRestoreSettings
        {
        };

        // restore for .NET Core and Standard projects
        DotNetCoreRestore(solution, settings);
        
        // restore for .NET Framework
        NuGetRestore(solution);
    })
    .OnError(exception => Error(exception));

Task("BuildPackage")
    .IsDependentOn("RestorePackage")
    .IsDependentOn("Version")
    .Does(() => {
        var settings = new DotNetCoreBuildSettings
        {
            //Framework = frameworkVersion,
            Configuration = configuration,
            MSBuildSettings = CreateSettings()
        };

        DotNetCoreBuild(solution, settings);
    })
    .OnError(exception => Error(exception));

Task("CreatePackage")
    .IsDependentOn("BuildPackage")
    .Does(() => {
        var settings = new DotNetCorePackSettings
        {
            Configuration = configuration,
            OutputDirectory = packagePublishPath
        };

        DotNetCorePack(packageLibrary, settings);
    })
    .OnError(exception => Error(exception));

Task("CreatePackageFromSpec")
    .IsDependentOn("BuildPackage")
    .Does(() => {
        var settings = new NuGetPackSettings 
        {
            OutputDirectory = packagePublishPath
        };

        NuGetPack(packageLibrarySpec, settings);
    })
    .OnError(exception => Error(exception));

// Special task to create a package and push to NuGet feed.
Task("PublishPackage")
    .IsDependentOn("CreatePackageFromSpec")
    .Does(() => {
        var files = GetFiles(packagesPattern);

        foreach (var file in files)
        {
            Information("Package file: {0}", file);

            var settings = new NuGetPushSettings {
                Source = nuGetFeedPath,
                ApiKey = nuGetApiKey
            };

            NuGetPush(file, settings);
        }
    })
    .OnError(exception => Error(exception));

//////////////////////////////////////////////////////////////////////
// EXECUTION
//////////////////////////////////////////////////////////////////////

RunTarget(target);
