/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using CyberSource.Client;
using CyberSource.Model;

namespace CyberSource.Api
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
        /// A payment authorizes the amount for the transaction. There are a number of supported payment feature, such as E-commerce and Card Present - Credit Card/Debit Card, Echeck, e-Wallets, Level II/III Data, etc..  A payment response includes the status of the request. It also includes processor-specific information when the request is successful and errors if unsuccessful. See the [Payments Developer Guides Page](https://developer.cybersource.com/api/developer-guides/dita-payments/GettingStarted.html).  Authorization can be requested with Capture, Decision Manager, Payer Authentication(3ds), and Token Creation. Find more on [Authorization with Add-On Features page.] (https://developer.cybersource.com/api/authorization-add-ons.html)  Possible [RESPONSE CODES](https://developer.cybersource.com/api/reference/response-codes.html) .  Processor specific [Testing Triggers](https://developer.cybersource.com/hello-world/testing-guide.html). 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createPaymentRequest"></param>
        /// <returns>PtsV2PaymentsPost201Response</returns>
        PtsV2PaymentsPost201Response CreatePayment (CreatePaymentRequest createPaymentRequest);

        /// <summary>
        /// Process a Payment
        /// </summary>
        /// <remarks>
        /// A payment authorizes the amount for the transaction. There are a number of supported payment feature, such as E-commerce and Card Present - Credit Card/Debit Card, Echeck, e-Wallets, Level II/III Data, etc..  A payment response includes the status of the request. It also includes processor-specific information when the request is successful and errors if unsuccessful. See the [Payments Developer Guides Page](https://developer.cybersource.com/api/developer-guides/dita-payments/GettingStarted.html).  Authorization can be requested with Capture, Decision Manager, Payer Authentication(3ds), and Token Creation. Find more on [Authorization with Add-On Features page.] (https://developer.cybersource.com/api/authorization-add-ons.html)  Possible [RESPONSE CODES](https://developer.cybersource.com/api/reference/response-codes.html) .  Processor specific [Testing Triggers](https://developer.cybersource.com/hello-world/testing-guide.html). 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createPaymentRequest"></param>
        /// <returns>ApiResponse of PtsV2PaymentsPost201Response</returns>
        ApiResponse<PtsV2PaymentsPost201Response> CreatePaymentWithHttpInfo (CreatePaymentRequest createPaymentRequest);
        /// <summary>
        /// Increment an Authorization
        /// </summary>
        /// <remarks>
        /// Use this service to authorize additional charges in a lodging or autorental transaction. Include the ID returned from the original authorization in the PATCH request to add additional charges to that authorization. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID returned from the original authorization request.</param>
        /// <param name="incrementAuthRequest"></param>
        /// <returns>PtsV2IncrementalAuthorizationPatch201Response</returns>
        PtsV2IncrementalAuthorizationPatch201Response IncrementAuth (string id, IncrementAuthRequest incrementAuthRequest);

        /// <summary>
        /// Increment an Authorization
        /// </summary>
        /// <remarks>
        /// Use this service to authorize additional charges in a lodging or autorental transaction. Include the ID returned from the original authorization in the PATCH request to add additional charges to that authorization. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID returned from the original authorization request.</param>
        /// <param name="incrementAuthRequest"></param>
        /// <returns>ApiResponse of PtsV2IncrementalAuthorizationPatch201Response</returns>
        ApiResponse<PtsV2IncrementalAuthorizationPatch201Response> IncrementAuthWithHttpInfo (string id, IncrementAuthRequest incrementAuthRequest);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Process a Payment
        /// </summary>
        /// <remarks>
        /// A payment authorizes the amount for the transaction. There are a number of supported payment feature, such as E-commerce and Card Present - Credit Card/Debit Card, Echeck, e-Wallets, Level II/III Data, etc..  A payment response includes the status of the request. It also includes processor-specific information when the request is successful and errors if unsuccessful. See the [Payments Developer Guides Page](https://developer.cybersource.com/api/developer-guides/dita-payments/GettingStarted.html).  Authorization can be requested with Capture, Decision Manager, Payer Authentication(3ds), and Token Creation. Find more on [Authorization with Add-On Features page.] (https://developer.cybersource.com/api/authorization-add-ons.html)  Possible [RESPONSE CODES](https://developer.cybersource.com/api/reference/response-codes.html) .  Processor specific [Testing Triggers](https://developer.cybersource.com/hello-world/testing-guide.html). 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createPaymentRequest"></param>
        /// <returns>Task of PtsV2PaymentsPost201Response</returns>
        System.Threading.Tasks.Task<PtsV2PaymentsPost201Response> CreatePaymentAsync (CreatePaymentRequest createPaymentRequest);

        /// <summary>
        /// Process a Payment
        /// </summary>
        /// <remarks>
        /// A payment authorizes the amount for the transaction. There are a number of supported payment feature, such as E-commerce and Card Present - Credit Card/Debit Card, Echeck, e-Wallets, Level II/III Data, etc..  A payment response includes the status of the request. It also includes processor-specific information when the request is successful and errors if unsuccessful. See the [Payments Developer Guides Page](https://developer.cybersource.com/api/developer-guides/dita-payments/GettingStarted.html).  Authorization can be requested with Capture, Decision Manager, Payer Authentication(3ds), and Token Creation. Find more on [Authorization with Add-On Features page.] (https://developer.cybersource.com/api/authorization-add-ons.html)  Possible [RESPONSE CODES](https://developer.cybersource.com/api/reference/response-codes.html) .  Processor specific [Testing Triggers](https://developer.cybersource.com/hello-world/testing-guide.html). 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createPaymentRequest"></param>
        /// <returns>Task of ApiResponse (PtsV2PaymentsPost201Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<PtsV2PaymentsPost201Response>> CreatePaymentAsyncWithHttpInfo (CreatePaymentRequest createPaymentRequest);
        /// <summary>
        /// Increment an Authorization
        /// </summary>
        /// <remarks>
        /// Use this service to authorize additional charges in a lodging or autorental transaction. Include the ID returned from the original authorization in the PATCH request to add additional charges to that authorization. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID returned from the original authorization request.</param>
        /// <param name="incrementAuthRequest"></param>
        /// <returns>Task of PtsV2IncrementalAuthorizationPatch201Response</returns>
        System.Threading.Tasks.Task<PtsV2IncrementalAuthorizationPatch201Response> IncrementAuthAsync (string id, IncrementAuthRequest incrementAuthRequest);

        /// <summary>
        /// Increment an Authorization
        /// </summary>
        /// <remarks>
        /// Use this service to authorize additional charges in a lodging or autorental transaction. Include the ID returned from the original authorization in the PATCH request to add additional charges to that authorization. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID returned from the original authorization request.</param>
        /// <param name="incrementAuthRequest"></param>
        /// <returns>Task of ApiResponse (PtsV2IncrementalAuthorizationPatch201Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<PtsV2IncrementalAuthorizationPatch201Response>> IncrementAuthAsyncWithHttpInfo (string id, IncrementAuthRequest incrementAuthRequest);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PaymentsApi : IPaymentsApi
    {
        private CyberSource.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PaymentsApi(String basePath)
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
        /// Initializes a new instance of the <see cref="PaymentsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PaymentsApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = CyberSource.Client.Configuration.DefaultExceptionFactory;

            this.Configuration.ApiClient.Configuration = this.Configuration;
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
        /// Process a Payment A payment authorizes the amount for the transaction. There are a number of supported payment feature, such as E-commerce and Card Present - Credit Card/Debit Card, Echeck, e-Wallets, Level II/III Data, etc..  A payment response includes the status of the request. It also includes processor-specific information when the request is successful and errors if unsuccessful. See the [Payments Developer Guides Page](https://developer.cybersource.com/api/developer-guides/dita-payments/GettingStarted.html).  Authorization can be requested with Capture, Decision Manager, Payer Authentication(3ds), and Token Creation. Find more on [Authorization with Add-On Features page.] (https://developer.cybersource.com/api/authorization-add-ons.html)  Possible [RESPONSE CODES](https://developer.cybersource.com/api/reference/response-codes.html) .  Processor specific [Testing Triggers](https://developer.cybersource.com/hello-world/testing-guide.html). 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createPaymentRequest"></param>
        /// <returns>PtsV2PaymentsPost201Response</returns>
        public PtsV2PaymentsPost201Response CreatePayment (CreatePaymentRequest createPaymentRequest)
        {
             ApiResponse<PtsV2PaymentsPost201Response> localVarResponse = CreatePaymentWithHttpInfo(createPaymentRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Process a Payment A payment authorizes the amount for the transaction. There are a number of supported payment feature, such as E-commerce and Card Present - Credit Card/Debit Card, Echeck, e-Wallets, Level II/III Data, etc..  A payment response includes the status of the request. It also includes processor-specific information when the request is successful and errors if unsuccessful. See the [Payments Developer Guides Page](https://developer.cybersource.com/api/developer-guides/dita-payments/GettingStarted.html).  Authorization can be requested with Capture, Decision Manager, Payer Authentication(3ds), and Token Creation. Find more on [Authorization with Add-On Features page.] (https://developer.cybersource.com/api/authorization-add-ons.html)  Possible [RESPONSE CODES](https://developer.cybersource.com/api/reference/response-codes.html) .  Processor specific [Testing Triggers](https://developer.cybersource.com/hello-world/testing-guide.html). 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createPaymentRequest"></param>
        /// <returns>ApiResponse of PtsV2PaymentsPost201Response</returns>
        public ApiResponse< PtsV2PaymentsPost201Response > CreatePaymentWithHttpInfo (CreatePaymentRequest createPaymentRequest)
        {
            // verify the required parameter 'createPaymentRequest' is set
            if (createPaymentRequest == null)
                throw new ApiException(400, "Missing required parameter 'createPaymentRequest' when calling PaymentsApi->CreatePayment");

            var localVarPath = $"/pts/v2/payments";
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
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/hal+json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (createPaymentRequest != null && createPaymentRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(createPaymentRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = createPaymentRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreatePayment", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PtsV2PaymentsPost201Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PtsV2PaymentsPost201Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PtsV2PaymentsPost201Response))); // Return statement
        }

        /// <summary>
        /// Process a Payment A payment authorizes the amount for the transaction. There are a number of supported payment feature, such as E-commerce and Card Present - Credit Card/Debit Card, Echeck, e-Wallets, Level II/III Data, etc..  A payment response includes the status of the request. It also includes processor-specific information when the request is successful and errors if unsuccessful. See the [Payments Developer Guides Page](https://developer.cybersource.com/api/developer-guides/dita-payments/GettingStarted.html).  Authorization can be requested with Capture, Decision Manager, Payer Authentication(3ds), and Token Creation. Find more on [Authorization with Add-On Features page.] (https://developer.cybersource.com/api/authorization-add-ons.html)  Possible [RESPONSE CODES](https://developer.cybersource.com/api/reference/response-codes.html) .  Processor specific [Testing Triggers](https://developer.cybersource.com/hello-world/testing-guide.html). 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createPaymentRequest"></param>
        /// <returns>Task of PtsV2PaymentsPost201Response</returns>
        public async System.Threading.Tasks.Task<PtsV2PaymentsPost201Response> CreatePaymentAsync (CreatePaymentRequest createPaymentRequest)
        {
             ApiResponse<PtsV2PaymentsPost201Response> localVarResponse = await CreatePaymentAsyncWithHttpInfo(createPaymentRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Process a Payment A payment authorizes the amount for the transaction. There are a number of supported payment feature, such as E-commerce and Card Present - Credit Card/Debit Card, Echeck, e-Wallets, Level II/III Data, etc..  A payment response includes the status of the request. It also includes processor-specific information when the request is successful and errors if unsuccessful. See the [Payments Developer Guides Page](https://developer.cybersource.com/api/developer-guides/dita-payments/GettingStarted.html).  Authorization can be requested with Capture, Decision Manager, Payer Authentication(3ds), and Token Creation. Find more on [Authorization with Add-On Features page.] (https://developer.cybersource.com/api/authorization-add-ons.html)  Possible [RESPONSE CODES](https://developer.cybersource.com/api/reference/response-codes.html) .  Processor specific [Testing Triggers](https://developer.cybersource.com/hello-world/testing-guide.html). 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createPaymentRequest"></param>
        /// <returns>Task of ApiResponse (PtsV2PaymentsPost201Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PtsV2PaymentsPost201Response>> CreatePaymentAsyncWithHttpInfo (CreatePaymentRequest createPaymentRequest)
        {
            // verify the required parameter 'createPaymentRequest' is set
            if (createPaymentRequest == null)
                throw new ApiException(400, "Missing required parameter 'createPaymentRequest' when calling PaymentsApi->CreatePayment");

            var localVarPath = $"/pts/v2/payments";
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
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/hal+json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (createPaymentRequest != null && createPaymentRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(createPaymentRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = createPaymentRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreatePayment", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PtsV2PaymentsPost201Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PtsV2PaymentsPost201Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PtsV2PaymentsPost201Response))); // Return statement
        }

        /// <summary>
        /// Increment an Authorization Use this service to authorize additional charges in a lodging or autorental transaction. Include the ID returned from the original authorization in the PATCH request to add additional charges to that authorization. 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID returned from the original authorization request.</param>
        /// <param name="incrementAuthRequest"></param>
        /// <returns>PtsV2IncrementalAuthorizationPatch201Response</returns>
        public PtsV2IncrementalAuthorizationPatch201Response IncrementAuth (string id, IncrementAuthRequest incrementAuthRequest)
        {
             ApiResponse<PtsV2IncrementalAuthorizationPatch201Response> localVarResponse = IncrementAuthWithHttpInfo(id, incrementAuthRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Increment an Authorization Use this service to authorize additional charges in a lodging or autorental transaction. Include the ID returned from the original authorization in the PATCH request to add additional charges to that authorization. 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID returned from the original authorization request.</param>
        /// <param name="incrementAuthRequest"></param>
        /// <returns>ApiResponse of PtsV2IncrementalAuthorizationPatch201Response</returns>
        public ApiResponse< PtsV2IncrementalAuthorizationPatch201Response > IncrementAuthWithHttpInfo (string id, IncrementAuthRequest incrementAuthRequest)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling PaymentsApi->IncrementAuth");
            // verify the required parameter 'incrementAuthRequest' is set
            if (incrementAuthRequest == null)
                throw new ApiException(400, "Missing required parameter 'incrementAuthRequest' when calling PaymentsApi->IncrementAuth");

            var localVarPath = $"/pts/v2/payments/{id}";
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
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/hal+json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (incrementAuthRequest != null && incrementAuthRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(incrementAuthRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = incrementAuthRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("IncrementAuth", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PtsV2IncrementalAuthorizationPatch201Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PtsV2IncrementalAuthorizationPatch201Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PtsV2IncrementalAuthorizationPatch201Response))); // Return statement
        }

        /// <summary>
        /// Increment an Authorization Use this service to authorize additional charges in a lodging or autorental transaction. Include the ID returned from the original authorization in the PATCH request to add additional charges to that authorization. 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID returned from the original authorization request.</param>
        /// <param name="incrementAuthRequest"></param>
        /// <returns>Task of PtsV2IncrementalAuthorizationPatch201Response</returns>
        public async System.Threading.Tasks.Task<PtsV2IncrementalAuthorizationPatch201Response> IncrementAuthAsync (string id, IncrementAuthRequest incrementAuthRequest)
        {
             ApiResponse<PtsV2IncrementalAuthorizationPatch201Response> localVarResponse = await IncrementAuthAsyncWithHttpInfo(id, incrementAuthRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Increment an Authorization Use this service to authorize additional charges in a lodging or autorental transaction. Include the ID returned from the original authorization in the PATCH request to add additional charges to that authorization. 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID returned from the original authorization request.</param>
        /// <param name="incrementAuthRequest"></param>
        /// <returns>Task of ApiResponse (PtsV2IncrementalAuthorizationPatch201Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PtsV2IncrementalAuthorizationPatch201Response>> IncrementAuthAsyncWithHttpInfo (string id, IncrementAuthRequest incrementAuthRequest)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling PaymentsApi->IncrementAuth");
            // verify the required parameter 'incrementAuthRequest' is set
            if (incrementAuthRequest == null)
                throw new ApiException(400, "Missing required parameter 'incrementAuthRequest' when calling PaymentsApi->IncrementAuth");

            var localVarPath = $"/pts/v2/payments/{id}";
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
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/hal+json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (incrementAuthRequest != null && incrementAuthRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(incrementAuthRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = incrementAuthRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("IncrementAuth", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PtsV2IncrementalAuthorizationPatch201Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PtsV2IncrementalAuthorizationPatch201Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PtsV2IncrementalAuthorizationPatch201Response))); // Return statement
        }

    }
}
