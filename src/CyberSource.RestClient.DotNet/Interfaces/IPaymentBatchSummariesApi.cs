using System;
using CyberSource.Client;
using CyberSource.Model;

namespace CyberSource.Interfaces
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPaymentBatchSummariesApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Get payment batch summary data
        /// </summary>
        /// <remarks>
        /// Scope can be either account/merchant or reseller.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) </param>
        /// <param name="endTime">Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) </param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <param name="rollUp">Conditional - RollUp for data for day/week/month. Required while getting breakdown data for a Merchant (optional)</param>
        /// <param name="breakdown">Conditional - Breakdown on account_rollup/all_merchant/selected_merchant. Required while getting breakdown data for a Merchant. (optional)</param>
        /// <param name="startDayOfWeek">Optional - Start day of week to breakdown data for weeks in a month (optional)</param>
        /// <returns>ReportingV3PaymentBatchSummariesGet200Response</returns>
        ReportingV3PaymentBatchSummariesGet200Response GetPaymentBatchSummary(DateTime? startTime, DateTime? endTime, string organizationId = null,
            string rollUp = null, string breakdown = null, int? startDayOfWeek = null);

        /// <summary>
        /// Get payment batch summary data
        /// </summary>
        /// <remarks>
        /// Scope can be either account/merchant or reseller.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) </param>
        /// <param name="endTime">Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) </param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <param name="rollUp">Conditional - RollUp for data for day/week/month. Required while getting breakdown data for a Merchant (optional)</param>
        /// <param name="breakdown">Conditional - Breakdown on account_rollup/all_merchant/selected_merchant. Required while getting breakdown data for a Merchant. (optional)</param>
        /// <param name="startDayOfWeek">Optional - Start day of week to breakdown data for weeks in a month (optional)</param>
        /// <returns>ApiResponse of ReportingV3PaymentBatchSummariesGet200Response</returns>
        ApiResponse<ReportingV3PaymentBatchSummariesGet200Response> GetPaymentBatchSummaryWithHttpInfo(DateTime? startTime, DateTime? endTime,
            string organizationId = null, string rollUp = null, string breakdown = null, int? startDayOfWeek = null);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Get payment batch summary data
        /// </summary>
        /// <remarks>
        /// Scope can be either account/merchant or reseller.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) </param>
        /// <param name="endTime">Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) </param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <param name="rollUp">Conditional - RollUp for data for day/week/month. Required while getting breakdown data for a Merchant (optional)</param>
        /// <param name="breakdown">Conditional - Breakdown on account_rollup/all_merchant/selected_merchant. Required while getting breakdown data for a Merchant. (optional)</param>
        /// <param name="startDayOfWeek">Optional - Start day of week to breakdown data for weeks in a month (optional)</param>
        /// <returns>Task of ReportingV3PaymentBatchSummariesGet200Response</returns>
        System.Threading.Tasks.Task<ReportingV3PaymentBatchSummariesGet200Response> GetPaymentBatchSummaryAsync(DateTime? startTime,
            DateTime? endTime, string organizationId = null, string rollUp = null, string breakdown = null, int? startDayOfWeek = null);

        /// <summary>
        /// Get payment batch summary data
        /// </summary>
        /// <remarks>
        /// Scope can be either account/merchant or reseller.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) </param>
        /// <param name="endTime">Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ (e.g. 2018-01-01T00:00:00.000Z) </param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <param name="rollUp">Conditional - RollUp for data for day/week/month. Required while getting breakdown data for a Merchant (optional)</param>
        /// <param name="breakdown">Conditional - Breakdown on account_rollup/all_merchant/selected_merchant. Required while getting breakdown data for a Merchant. (optional)</param>
        /// <param name="startDayOfWeek">Optional - Start day of week to breakdown data for weeks in a month (optional)</param>
        /// <returns>Task of ApiResponse (ReportingV3PaymentBatchSummariesGet200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReportingV3PaymentBatchSummariesGet200Response>> GetPaymentBatchSummaryAsyncWithHttpInfo(
            DateTime? startTime, DateTime? endTime, string organizationId = null, string rollUp = null, string breakdown = null,
            int? startDayOfWeek = null);

        #endregion Asynchronous Operations
    }
}