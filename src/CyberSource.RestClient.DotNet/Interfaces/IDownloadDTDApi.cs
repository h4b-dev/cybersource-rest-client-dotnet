using System;
using CyberSource.Client;

namespace CyberSource.Interfaces
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDownloadDTDApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Download DTD for report
        /// </summary>
        /// <remarks>
        /// Used to download DTDs for reports on no-auth.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportDefinitionNameVersion">Name and version of DTD file to download. Some DTDs only have one version. In that case version name is not needed. Some example values are ctdr-1.0, tdr, pbdr-1.1</param>
        /// <returns></returns>
        void GetDTDV2(string reportDefinitionNameVersion);

        /// <summary>
        /// Download DTD for report
        /// </summary>
        /// <remarks>
        /// Used to download DTDs for reports on no-auth.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportDefinitionNameVersion">Name and version of DTD file to download. Some DTDs only have one version. In that case version name is not needed. Some example values are ctdr-1.0, tdr, pbdr-1.1</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetDTDV2WithHttpInfo(string reportDefinitionNameVersion);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Download DTD for report
        /// </summary>
        /// <remarks>
        /// Used to download DTDs for reports on no-auth.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportDefinitionNameVersion">Name and version of DTD file to download. Some DTDs only have one version. In that case version name is not needed. Some example values are ctdr-1.0, tdr, pbdr-1.1</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetDTDV2Async(string reportDefinitionNameVersion);

        /// <summary>
        /// Download DTD for report
        /// </summary>
        /// <remarks>
        /// Used to download DTDs for reports on no-auth.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportDefinitionNameVersion">Name and version of DTD file to download. Some DTDs only have one version. In that case version name is not needed. Some example values are ctdr-1.0, tdr, pbdr-1.1</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetDTDV2AsyncWithHttpInfo(string reportDefinitionNameVersion);

        #endregion Asynchronous Operations
    }
}