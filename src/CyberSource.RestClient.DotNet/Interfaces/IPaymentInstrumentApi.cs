using System;
using CyberSource.Client;
using CyberSource.Model;

namespace CyberSource.Interfaces
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPaymentInstrumentApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Create a Payment Instrument
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="createPaymentInstrumentRequest">Specify the customer&#39;s payment details for card or bank account.</param>
        /// <returns>TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseEmbeddedPaymentInstruments</returns>
        TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseEmbeddedPaymentInstruments CreatePaymentInstrument(string profileId,
            CreatePaymentInstrumentRequest createPaymentInstrumentRequest);

        /// <summary>
        /// Create a Payment Instrument
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="createPaymentInstrumentRequest">Specify the customer&#39;s payment details for card or bank account.</param>
        /// <returns>ApiResponse of TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseEmbeddedPaymentInstruments</returns>
        ApiResponse<TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseEmbeddedPaymentInstruments> CreatePaymentInstrumentWithHttpInfo(
            string profileId, CreatePaymentInstrumentRequest createPaymentInstrumentRequest);

        /// <summary>
        /// Delete a Payment Instrument
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="tokenId">The TokenId of a Payment Instrument.</param>
        /// <returns></returns>
        void DeletePaymentInstrument(string profileId, string tokenId);

        /// <summary>
        /// Delete a Payment Instrument
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="tokenId">The TokenId of a Payment Instrument.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeletePaymentInstrumentWithHttpInfo(string profileId, string tokenId);

        /// <summary>
        /// Retrieve a Payment Instrument
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="tokenId">The TokenId of a Payment Instrument.</param>
        /// <returns>TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseEmbeddedPaymentInstruments</returns>
        TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseEmbeddedPaymentInstruments GetPaymentInstrument(string profileId, string tokenId);

        /// <summary>
        /// Retrieve a Payment Instrument
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="tokenId">The TokenId of a Payment Instrument.</param>
        /// <returns>ApiResponse of TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseEmbeddedPaymentInstruments</returns>
        ApiResponse<TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseEmbeddedPaymentInstruments> GetPaymentInstrumentWithHttpInfo(
            string profileId, string tokenId);

        /// <summary>
        /// Update a Payment Instrument
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="tokenId">The TokenId of a Payment Instrument.</param>
        /// <param name="updatePaymentInstrumentRequest">Specify the customer&#39;s payment details.</param>
        /// <returns>TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseEmbeddedPaymentInstruments</returns>
        TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseEmbeddedPaymentInstruments UpdatePaymentInstrument(string profileId, string tokenId,
            UpdatePaymentInstrumentRequest updatePaymentInstrumentRequest);

        /// <summary>
        /// Update a Payment Instrument
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="tokenId">The TokenId of a Payment Instrument.</param>
        /// <param name="updatePaymentInstrumentRequest">Specify the customer&#39;s payment details.</param>
        /// <returns>ApiResponse of TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseEmbeddedPaymentInstruments</returns>
        ApiResponse<TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseEmbeddedPaymentInstruments> UpdatePaymentInstrumentWithHttpInfo(
            string profileId, string tokenId, UpdatePaymentInstrumentRequest updatePaymentInstrumentRequest);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Create a Payment Instrument
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="createPaymentInstrumentRequest">Specify the customer&#39;s payment details for card or bank account.</param>
        /// <returns>Task of TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseEmbeddedPaymentInstruments</returns>
        System.Threading.Tasks.Task<TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseEmbeddedPaymentInstruments>
            CreatePaymentInstrumentAsync(string profileId, CreatePaymentInstrumentRequest createPaymentInstrumentRequest);

        /// <summary>
        /// Create a Payment Instrument
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="createPaymentInstrumentRequest">Specify the customer&#39;s payment details for card or bank account.</param>
        /// <returns>Task of ApiResponse (TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseEmbeddedPaymentInstruments)</returns>
        System.Threading.Tasks.Task<ApiResponse<TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseEmbeddedPaymentInstruments>>
            CreatePaymentInstrumentAsyncWithHttpInfo(string profileId, CreatePaymentInstrumentRequest createPaymentInstrumentRequest);

        /// <summary>
        /// Delete a Payment Instrument
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="tokenId">The TokenId of a Payment Instrument.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeletePaymentInstrumentAsync(string profileId, string tokenId);

        /// <summary>
        /// Delete a Payment Instrument
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="tokenId">The TokenId of a Payment Instrument.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeletePaymentInstrumentAsyncWithHttpInfo(string profileId, string tokenId);

        /// <summary>
        /// Retrieve a Payment Instrument
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="tokenId">The TokenId of a Payment Instrument.</param>
        /// <returns>Task of TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseEmbeddedPaymentInstruments</returns>
        System.Threading.Tasks.Task<TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseEmbeddedPaymentInstruments> GetPaymentInstrumentAsync(
            string profileId, string tokenId);

        /// <summary>
        /// Retrieve a Payment Instrument
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="tokenId">The TokenId of a Payment Instrument.</param>
        /// <returns>Task of ApiResponse (TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseEmbeddedPaymentInstruments)</returns>
        System.Threading.Tasks.Task<ApiResponse<TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseEmbeddedPaymentInstruments>>
            GetPaymentInstrumentAsyncWithHttpInfo(string profileId, string tokenId);

        /// <summary>
        /// Update a Payment Instrument
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="tokenId">The TokenId of a Payment Instrument.</param>
        /// <param name="updatePaymentInstrumentRequest">Specify the customer&#39;s payment details.</param>
        /// <returns>Task of TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseEmbeddedPaymentInstruments</returns>
        System.Threading.Tasks.Task<TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseEmbeddedPaymentInstruments>
            UpdatePaymentInstrumentAsync(string profileId, string tokenId, UpdatePaymentInstrumentRequest updatePaymentInstrumentRequest);

        /// <summary>
        /// Update a Payment Instrument
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">The id of a profile containing user specific TMS configuration.</param>
        /// <param name="tokenId">The TokenId of a Payment Instrument.</param>
        /// <param name="updatePaymentInstrumentRequest">Specify the customer&#39;s payment details.</param>
        /// <returns>Task of ApiResponse (TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseEmbeddedPaymentInstruments)</returns>
        System.Threading.Tasks.Task<ApiResponse<TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseEmbeddedPaymentInstruments>>
            UpdatePaymentInstrumentAsyncWithHttpInfo(string profileId, string tokenId, UpdatePaymentInstrumentRequest updatePaymentInstrumentRequest);

        #endregion Asynchronous Operations
    }
}