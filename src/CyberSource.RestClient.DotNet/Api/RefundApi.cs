/* 
 * CyberSource Flex API
 *
 * Simple PAN tokenization service
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using CyberSource.Client;
using CyberSource.Interfaces;
using CyberSource.Model;

namespace CyberSource.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class RefundApi : IRefundApi
    {
        private CyberSource.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="RefundApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RefundApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = CyberSource.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RefundApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public RefundApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = CyberSource.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public CyberSource.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Refund a Capture Include the capture ID in the POST request to refund the captured amount. 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refundCaptureRequest"></param>
        /// <param name="id">The capture ID. This ID is returned from a previous capture request.</param>
        /// <returns>PtsV2PaymentsRefundPost201Response</returns>
        public PtsV2PaymentsRefundPost201Response RefundCapture (RefundCaptureRequest refundCaptureRequest, string id)
        {
             ApiResponse<PtsV2PaymentsRefundPost201Response> localVarResponse = RefundCaptureWithHttpInfo(refundCaptureRequest, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Refund a Capture Include the capture ID in the POST request to refund the captured amount. 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refundCaptureRequest"></param>
        /// <param name="id">The capture ID. This ID is returned from a previous capture request.</param>
        /// <returns>ApiResponse of PtsV2PaymentsRefundPost201Response</returns>
        public ApiResponse< PtsV2PaymentsRefundPost201Response > RefundCaptureWithHttpInfo (RefundCaptureRequest refundCaptureRequest, string id)
        {
            // verify the required parameter 'refundCaptureRequest' is set
            if (refundCaptureRequest == null)
                throw new ApiException(400, "Missing required parameter 'refundCaptureRequest' when calling RefundApi->RefundCapture");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RefundApi->RefundCapture");

            var localVarPath = $"/pts/v2/captures/{id}/refunds";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
String[] localVarHttpHeaderAccepts = new String[] {"application/hal+json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (refundCaptureRequest != null && refundCaptureRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(refundCaptureRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = refundCaptureRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RefundCapture", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PtsV2PaymentsRefundPost201Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PtsV2PaymentsRefundPost201Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PtsV2PaymentsRefundPost201Response)));
        }

        /// <summary>
        /// Refund a Capture Include the capture ID in the POST request to refund the captured amount. 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refundCaptureRequest"></param>
        /// <param name="id">The capture ID. This ID is returned from a previous capture request.</param>
        /// <returns>Task of PtsV2PaymentsRefundPost201Response</returns>
        public async System.Threading.Tasks.Task<PtsV2PaymentsRefundPost201Response> RefundCaptureAsync (RefundCaptureRequest refundCaptureRequest, string id)
        {
             ApiResponse<PtsV2PaymentsRefundPost201Response> localVarResponse = await RefundCaptureAsyncWithHttpInfo(refundCaptureRequest, id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Refund a Capture Include the capture ID in the POST request to refund the captured amount. 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refundCaptureRequest"></param>
        /// <param name="id">The capture ID. This ID is returned from a previous capture request.</param>
        /// <returns>Task of ApiResponse (PtsV2PaymentsRefundPost201Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PtsV2PaymentsRefundPost201Response>> RefundCaptureAsyncWithHttpInfo (RefundCaptureRequest refundCaptureRequest, string id)
        {
            // verify the required parameter 'refundCaptureRequest' is set
            if (refundCaptureRequest == null)
                throw new ApiException(400, "Missing required parameter 'refundCaptureRequest' when calling RefundApi->RefundCapture");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RefundApi->RefundCapture");

            var localVarPath = $"/pts/v2/captures/{id}/refunds";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
String[] localVarHttpHeaderAccepts = new String[] {"application/hal+json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (refundCaptureRequest != null && refundCaptureRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(refundCaptureRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = refundCaptureRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RefundCapture", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PtsV2PaymentsRefundPost201Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PtsV2PaymentsRefundPost201Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PtsV2PaymentsRefundPost201Response)));
        }

        /// <summary>
        /// Refund a Payment Include the payment ID in the POST request to refund the payment amount. 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refundPaymentRequest"></param>
        /// <param name="id">The payment ID. This ID is returned from a previous payment request.</param>
        /// <returns>PtsV2PaymentsRefundPost201Response</returns>
        public PtsV2PaymentsRefundPost201Response RefundPayment (RefundPaymentRequest refundPaymentRequest, string id)
        {
             ApiResponse<PtsV2PaymentsRefundPost201Response> localVarResponse = RefundPaymentWithHttpInfo(refundPaymentRequest, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Refund a Payment Include the payment ID in the POST request to refund the payment amount. 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refundPaymentRequest"></param>
        /// <param name="id">The payment ID. This ID is returned from a previous payment request.</param>
        /// <returns>ApiResponse of PtsV2PaymentsRefundPost201Response</returns>
        public ApiResponse< PtsV2PaymentsRefundPost201Response > RefundPaymentWithHttpInfo (RefundPaymentRequest refundPaymentRequest, string id)
        {
            // verify the required parameter 'refundPaymentRequest' is set
            if (refundPaymentRequest == null)
                throw new ApiException(400, "Missing required parameter 'refundPaymentRequest' when calling RefundApi->RefundPayment");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RefundApi->RefundPayment");

            var localVarPath = $"/pts/v2/payments/{id}/refunds";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
String[] localVarHttpHeaderAccepts = new String[] {"application/hal+json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (refundPaymentRequest != null && refundPaymentRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(refundPaymentRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = refundPaymentRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RefundPayment", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PtsV2PaymentsRefundPost201Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PtsV2PaymentsRefundPost201Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PtsV2PaymentsRefundPost201Response)));
        }

        /// <summary>
        /// Refund a Payment Include the payment ID in the POST request to refund the payment amount. 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refundPaymentRequest"></param>
        /// <param name="id">The payment ID. This ID is returned from a previous payment request.</param>
        /// <returns>Task of PtsV2PaymentsRefundPost201Response</returns>
        public async System.Threading.Tasks.Task<PtsV2PaymentsRefundPost201Response> RefundPaymentAsync (RefundPaymentRequest refundPaymentRequest, string id)
        {
             ApiResponse<PtsV2PaymentsRefundPost201Response> localVarResponse = await RefundPaymentAsyncWithHttpInfo(refundPaymentRequest, id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Refund a Payment Include the payment ID in the POST request to refund the payment amount. 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refundPaymentRequest"></param>
        /// <param name="id">The payment ID. This ID is returned from a previous payment request.</param>
        /// <returns>Task of ApiResponse (PtsV2PaymentsRefundPost201Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PtsV2PaymentsRefundPost201Response>> RefundPaymentAsyncWithHttpInfo (RefundPaymentRequest refundPaymentRequest, string id)
        {
            // verify the required parameter 'refundPaymentRequest' is set
            if (refundPaymentRequest == null)
                throw new ApiException(400, "Missing required parameter 'refundPaymentRequest' when calling RefundApi->RefundPayment");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RefundApi->RefundPayment");

            var localVarPath = $"/pts/v2/payments/{id}/refunds";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
String[] localVarHttpHeaderAccepts = new String[] {"application/hal+json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (refundPaymentRequest != null && refundPaymentRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(refundPaymentRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = refundPaymentRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RefundPayment", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PtsV2PaymentsRefundPost201Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PtsV2PaymentsRefundPost201Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PtsV2PaymentsRefundPost201Response)));
        }

    }
}
