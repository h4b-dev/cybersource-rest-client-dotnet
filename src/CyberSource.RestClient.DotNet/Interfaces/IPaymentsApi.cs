using System.Threading.Tasks;
using CyberSource.Client;
using CyberSource.Model;

namespace CyberSource.Interfaces
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPaymentsApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Process a Payment
        /// </summary>
        /// <remarks>
        /// Authorize the payment for the transaction. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createPaymentRequest"></param>
        /// <returns>PtsV2PaymentsPost201Response</returns>
        PtsV2PaymentsPost201Response CreatePayment(CreatePaymentRequest createPaymentRequest);

        /// <summary>
        /// Process a Payment
        /// </summary>
        /// <remarks>
        /// Authorize the payment for the transaction. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createPaymentRequest"></param>
        /// <returns>ApiResponse of PtsV2PaymentsPost201Response</returns>
        ApiResponse<PtsV2PaymentsPost201Response> CreatePaymentWithHttpInfo(CreatePaymentRequest createPaymentRequest);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Process a Payment
        /// </summary>
        /// <remarks>
        /// Authorize the payment for the transaction. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createPaymentRequest"></param>
        /// <returns>Task of PtsV2PaymentsPost201Response</returns>
        Task<PtsV2PaymentsPost201Response> CreatePaymentAsync(CreatePaymentRequest createPaymentRequest);

        /// <summary>
        /// Process a Payment
        /// </summary>
        /// <remarks>
        /// Authorize the payment for the transaction. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createPaymentRequest"></param>
        /// <returns>Task of ApiResponse (PtsV2PaymentsPost201Response)</returns>
        Task<ApiResponse<PtsV2PaymentsPost201Response>> CreatePaymentAsyncWithHttpInfo(CreatePaymentRequest createPaymentRequest);

        #endregion Asynchronous Operations
    }
}