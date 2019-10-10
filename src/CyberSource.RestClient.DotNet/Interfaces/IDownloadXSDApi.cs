using System;
using CyberSource.Client;

namespace CyberSource.Interfaces
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDownloadXSDApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Download XSD for report
        /// </summary>
        /// <remarks>
        /// Used to download XSDs for reports on no-auth.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportDefinitionNameVersion">Name and version of XSD file to download. Some XSDs only have one version. In that case version name is not needed. Some example values are DecisionManagerDetailReport, DecisionManagerTypes</param>
        /// <returns></returns>
        void GetXSDV2(string reportDefinitionNameVersion);

        /// <summary>
        /// Download XSD for report
        /// </summary>
        /// <remarks>
        /// Used to download XSDs for reports on no-auth.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportDefinitionNameVersion">Name and version of XSD file to download. Some XSDs only have one version. In that case version name is not needed. Some example values are DecisionManagerDetailReport, DecisionManagerTypes</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetXSDV2WithHttpInfo(string reportDefinitionNameVersion);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Download XSD for report
        /// </summary>
        /// <remarks>
        /// Used to download XSDs for reports on no-auth.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportDefinitionNameVersion">Name and version of XSD file to download. Some XSDs only have one version. In that case version name is not needed. Some example values are DecisionManagerDetailReport, DecisionManagerTypes</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetXSDV2Async(string reportDefinitionNameVersion);

        /// <summary>
        /// Download XSD for report
        /// </summary>
        /// <remarks>
        /// Used to download XSDs for reports on no-auth.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportDefinitionNameVersion">Name and version of XSD file to download. Some XSDs only have one version. In that case version name is not needed. Some example values are DecisionManagerDetailReport, DecisionManagerTypes</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetXSDV2AsyncWithHttpInfo(string reportDefinitionNameVersion);

        #endregion Asynchronous Operations
    }
}