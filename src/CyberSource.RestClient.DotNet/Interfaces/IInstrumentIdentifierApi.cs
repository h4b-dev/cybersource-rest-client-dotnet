using System;
using CyberSource.Client;
using CyberSource.Interfaces;
using CyberSource.Model;

namespace CyberSource.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IInstrumentIdentifierApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Create an Instrument Identifier
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="createInstrumentIdentifierRequest">Please specify either a Card, Bank Account or Enrollable Card</param>
        /// <returns>TmsV1InstrumentIdentifiersPost200Response</returns>
        TmsV1InstrumentIdentifiersPost200Response CreateInstrumentIdentifier(string profileId,
            CreateInstrumentIdentifierRequest createInstrumentIdentifierRequest);

        /// <summary>
        /// Create an Instrument Identifier
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="createInstrumentIdentifierRequest">Please specify either a Card, Bank Account or Enrollable Card</param>
        /// <returns>ApiResponse of TmsV1InstrumentIdentifiersPost200Response</returns>
        ApiResponse<TmsV1InstrumentIdentifiersPost200Response> CreateInstrumentIdentifierWithHttpInfo(string profileId,
            CreateInstrumentIdentifierRequest createInstrumentIdentifierRequest);

        /// <summary>
        /// Delete an Instrument Identifier
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="tokenId">The TokenId of an Instrument Identifier.</param>
        /// <returns></returns>
        void DeleteInstrumentIdentifier(string profileId, string tokenId);

        /// <summary>
        /// Delete an Instrument Identifier
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="tokenId">The TokenId of an Instrument Identifier.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteInstrumentIdentifierWithHttpInfo(string profileId, string tokenId);

        /// <summary>
        /// Retrieve all Payment Instruments
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="tokenId">The TokenId of an Instrument Identifier.</param>
        /// <param name="offset">Starting Payment Instrument record in zero-based dataset that should be returned as the first object in the array. Default is 0. (optional, default to 0)</param>
        /// <param name="limit">The maximum number of Payment Instruments that can be returned in the array starting from the offset record in zero-based dataset. Default is 20, maximum is 100. (optional, default to 20)</param>
        /// <returns>TmsV1InstrumentIdentifiersPaymentInstrumentsGet200Response</returns>
        TmsV1InstrumentIdentifiersPaymentInstrumentsGet200Response GetAllPaymentInstruments(string profileId, string tokenId, long? offset = null,
            long? limit = null);

        /// <summary>
        /// Retrieve all Payment Instruments
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="tokenId">The TokenId of an Instrument Identifier.</param>
        /// <param name="offset">Starting Payment Instrument record in zero-based dataset that should be returned as the first object in the array. Default is 0. (optional, default to 0)</param>
        /// <param name="limit">The maximum number of Payment Instruments that can be returned in the array starting from the offset record in zero-based dataset. Default is 20, maximum is 100. (optional, default to 20)</param>
        /// <returns>ApiResponse of TmsV1InstrumentIdentifiersPaymentInstrumentsGet200Response</returns>
        ApiResponse<TmsV1InstrumentIdentifiersPaymentInstrumentsGet200Response> GetAllPaymentInstrumentsWithHttpInfo(string profileId, string tokenId,
            long? offset = null, long? limit = null);

        /// <summary>
        /// Retrieve an Instrument Identifier
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="tokenId">The TokenId of an Instrument Identifier.</param>
        /// <returns>TmsV1InstrumentIdentifiersPost200Response</returns>
        TmsV1InstrumentIdentifiersPost200Response GetInstrumentIdentifier(string profileId, string tokenId);

        /// <summary>
        /// Retrieve an Instrument Identifier
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="tokenId">The TokenId of an Instrument Identifier.</param>
        /// <returns>ApiResponse of TmsV1InstrumentIdentifiersPost200Response</returns>
        ApiResponse<TmsV1InstrumentIdentifiersPost200Response> GetInstrumentIdentifierWithHttpInfo(string profileId, string tokenId);

        /// <summary>
        /// Update a Instrument Identifier
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="tokenId">The TokenId of an Instrument Identifier.</param>
        /// <param name="updateInstrumentIdentifierRequest">Specify the previous transaction ID to update.</param>
        /// <returns>TmsV1InstrumentIdentifiersPost200Response</returns>
        TmsV1InstrumentIdentifiersPost200Response UpdateInstrumentIdentifier(string profileId, string tokenId,
            UpdateInstrumentIdentifierRequest updateInstrumentIdentifierRequest);

        /// <summary>
        /// Update a Instrument Identifier
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="tokenId">The TokenId of an Instrument Identifier.</param>
        /// <param name="updateInstrumentIdentifierRequest">Specify the previous transaction ID to update.</param>
        /// <returns>ApiResponse of TmsV1InstrumentIdentifiersPost200Response</returns>
        ApiResponse<TmsV1InstrumentIdentifiersPost200Response> UpdateInstrumentIdentifierWithHttpInfo(string profileId, string tokenId,
            UpdateInstrumentIdentifierRequest updateInstrumentIdentifierRequest);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Create an Instrument Identifier
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="createInstrumentIdentifierRequest">Please specify either a Card, Bank Account or Enrollable Card</param>
        /// <returns>Task of TmsV1InstrumentIdentifiersPost200Response</returns>
        System.Threading.Tasks.Task<TmsV1InstrumentIdentifiersPost200Response> CreateInstrumentIdentifierAsync(string profileId,
            CreateInstrumentIdentifierRequest createInstrumentIdentifierRequest);

        /// <summary>
        /// Create an Instrument Identifier
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="createInstrumentIdentifierRequest">Please specify either a Card, Bank Account or Enrollable Card</param>
        /// <returns>Task of ApiResponse (TmsV1InstrumentIdentifiersPost200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<TmsV1InstrumentIdentifiersPost200Response>> CreateInstrumentIdentifierAsyncWithHttpInfo(
            string profileId, CreateInstrumentIdentifierRequest createInstrumentIdentifierRequest);

        /// <summary>
        /// Delete an Instrument Identifier
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="tokenId">The TokenId of an Instrument Identifier.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteInstrumentIdentifierAsync(string profileId, string tokenId);

        /// <summary>
        /// Delete an Instrument Identifier
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="tokenId">The TokenId of an Instrument Identifier.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteInstrumentIdentifierAsyncWithHttpInfo(string profileId, string tokenId);

        /// <summary>
        /// Retrieve all Payment Instruments
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="tokenId">The TokenId of an Instrument Identifier.</param>
        /// <param name="offset">Starting Payment Instrument record in zero-based dataset that should be returned as the first object in the array. Default is 0. (optional, default to 0)</param>
        /// <param name="limit">The maximum number of Payment Instruments that can be returned in the array starting from the offset record in zero-based dataset. Default is 20, maximum is 100. (optional, default to 20)</param>
        /// <returns>Task of TmsV1InstrumentIdentifiersPaymentInstrumentsGet200Response</returns>
        System.Threading.Tasks.Task<TmsV1InstrumentIdentifiersPaymentInstrumentsGet200Response> GetAllPaymentInstrumentsAsync(string profileId,
            string tokenId, long? offset = null, long? limit = null);

        /// <summary>
        /// Retrieve all Payment Instruments
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="tokenId">The TokenId of an Instrument Identifier.</param>
        /// <param name="offset">Starting Payment Instrument record in zero-based dataset that should be returned as the first object in the array. Default is 0. (optional, default to 0)</param>
        /// <param name="limit">The maximum number of Payment Instruments that can be returned in the array starting from the offset record in zero-based dataset. Default is 20, maximum is 100. (optional, default to 20)</param>
        /// <returns>Task of ApiResponse (TmsV1InstrumentIdentifiersPaymentInstrumentsGet200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<TmsV1InstrumentIdentifiersPaymentInstrumentsGet200Response>>
            GetAllPaymentInstrumentsAsyncWithHttpInfo(string profileId, string tokenId, long? offset = null, long? limit = null);

        /// <summary>
        /// Retrieve an Instrument Identifier
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="tokenId">The TokenId of an Instrument Identifier.</param>
        /// <returns>Task of TmsV1InstrumentIdentifiersPost200Response</returns>
        System.Threading.Tasks.Task<TmsV1InstrumentIdentifiersPost200Response> GetInstrumentIdentifierAsync(string profileId, string tokenId);

        /// <summary>
        /// Retrieve an Instrument Identifier
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="tokenId">The TokenId of an Instrument Identifier.</param>
        /// <returns>Task of ApiResponse (TmsV1InstrumentIdentifiersPost200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<TmsV1InstrumentIdentifiersPost200Response>> GetInstrumentIdentifierAsyncWithHttpInfo(string profileId,
            string tokenId);

        /// <summary>
        /// Update a Instrument Identifier
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="tokenId">The TokenId of an Instrument Identifier.</param>
        /// <param name="updateInstrumentIdentifierRequest">Specify the previous transaction ID to update.</param>
        /// <returns>Task of TmsV1InstrumentIdentifiersPost200Response</returns>
        System.Threading.Tasks.Task<TmsV1InstrumentIdentifiersPost200Response> UpdateInstrumentIdentifierAsync(string profileId, string tokenId,
            UpdateInstrumentIdentifierRequest updateInstrumentIdentifierRequest);

        /// <summary>
        /// Update a Instrument Identifier
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="tokenId">The TokenId of an Instrument Identifier.</param>
        /// <param name="updateInstrumentIdentifierRequest">Specify the previous transaction ID to update.</param>
        /// <returns>Task of ApiResponse (TmsV1InstrumentIdentifiersPost200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<TmsV1InstrumentIdentifiersPost200Response>> UpdateInstrumentIdentifierAsyncWithHttpInfo(
            string profileId, string tokenId, UpdateInstrumentIdentifierRequest updateInstrumentIdentifierRequest);

        #endregion Asynchronous Operations
    }
}