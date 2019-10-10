using CyberSource.Client;
using CyberSource.Model;

namespace CyberSource.Interfaces
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDecisionManagerApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Create Decision Manager Case
        /// </summary>
        /// <remarks>
        /// This is the combined request to the Decision Manager Service for a transaction sent to Cybersource. Decision Manager will return a decision based on the request values. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createDecisionManagerCaseRequest"></param>
        /// <returns>RiskV1DecisionsPost201Response</returns>
        RiskV1DecisionsPost201Response CreateDecisionManagerCase(CreateDecisionManagerCaseRequest createDecisionManagerCaseRequest);

        /// <summary>
        /// Create Decision Manager Case
        /// </summary>
        /// <remarks>
        /// This is the combined request to the Decision Manager Service for a transaction sent to Cybersource. Decision Manager will return a decision based on the request values. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createDecisionManagerCaseRequest"></param>
        /// <returns>ApiResponse of RiskV1DecisionsPost201Response</returns>
        ApiResponse<RiskV1DecisionsPost201Response> CreateDecisionManagerCaseWithHttpInfo(
            CreateDecisionManagerCaseRequest createDecisionManagerCaseRequest);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Create Decision Manager Case
        /// </summary>
        /// <remarks>
        /// This is the combined request to the Decision Manager Service for a transaction sent to Cybersource. Decision Manager will return a decision based on the request values. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createDecisionManagerCaseRequest"></param>
        /// <returns>Task of RiskV1DecisionsPost201Response</returns>
        System.Threading.Tasks.Task<RiskV1DecisionsPost201Response> CreateDecisionManagerCaseAsync(
            CreateDecisionManagerCaseRequest createDecisionManagerCaseRequest);

        /// <summary>
        /// Create Decision Manager Case
        /// </summary>
        /// <remarks>
        /// This is the combined request to the Decision Manager Service for a transaction sent to Cybersource. Decision Manager will return a decision based on the request values. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createDecisionManagerCaseRequest"></param>
        /// <returns>Task of ApiResponse (RiskV1DecisionsPost201Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<RiskV1DecisionsPost201Response>> CreateDecisionManagerCaseAsyncWithHttpInfo(
            CreateDecisionManagerCaseRequest createDecisionManagerCaseRequest);

        #endregion Asynchronous Operations
    }
}