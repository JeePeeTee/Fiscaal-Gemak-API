/* 
 * Fiscaal Gemak API
 *
 * Fiscaal Gemak API
 *
 * OpenAPI spec version: 1.0.0
 * Contact: jpt@sultancrm.nl
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using FG.Api.Client;
using FG.Api.Model;

namespace FG.Api.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public interface IDefaultApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// adds a new client
        /// </summary>
        /// <remarks>
        /// Add a new client to the system
        /// </remarks>
        /// <exception cref="FG.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">New client data</param>
        /// <returns>ModelClient</returns>
        ModelClient AddClient (ModelClient body);

        /// <summary>
        /// adds a new client
        /// </summary>
        /// <remarks>
        /// Add a new client to the system
        /// </remarks>
        /// <exception cref="FG.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">New client data</param>
        /// <returns>ApiResponse of ModelClient</returns>
        ApiResponse<ModelClient> AddClientWithHttpInfo (ModelClient body);
        /// <summary>
        /// reads all customer data
        /// </summary>
        /// <remarks>
        /// This operation retrieves all customer data in JSON
        /// </remarks>
        /// <exception cref="FG.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;ModelClient&gt;</returns>
        List<ModelClient> GetClients ();

        /// <summary>
        /// reads all customer data
        /// </summary>
        /// <remarks>
        /// This operation retrieves all customer data in JSON
        /// </remarks>
        /// <exception cref="FG.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;ModelClient&gt;</returns>
        ApiResponse<List<ModelClient>> GetClientsWithHttpInfo ();
        /// <summary>
        /// reads customer data by ID
        /// </summary>
        /// <remarks>
        /// This operation retrieves customer by its ID. The operation uses the customer ID to identify a customer in a query string.
        /// </remarks>
        /// <exception cref="FG.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Pass customer ID for retrieving customer data.</param>
        /// <returns>ModelClient</returns>
        ModelClient GetCustomer (int? id);

        /// <summary>
        /// reads customer data by ID
        /// </summary>
        /// <remarks>
        /// This operation retrieves customer by its ID. The operation uses the customer ID to identify a customer in a query string.
        /// </remarks>
        /// <exception cref="FG.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Pass customer ID for retrieving customer data.</param>
        /// <returns>ApiResponse of ModelClient</returns>
        ApiResponse<ModelClient> GetCustomerWithHttpInfo (int? id);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// adds a new client
        /// </summary>
        /// <remarks>
        /// Add a new client to the system
        /// </remarks>
        /// <exception cref="FG.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">New client data</param>
        /// <returns>Task of ModelClient</returns>
        System.Threading.Tasks.Task<ModelClient> AddClientAsync (ModelClient body);

        /// <summary>
        /// adds a new client
        /// </summary>
        /// <remarks>
        /// Add a new client to the system
        /// </remarks>
        /// <exception cref="FG.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">New client data</param>
        /// <returns>Task of ApiResponse (ModelClient)</returns>
        System.Threading.Tasks.Task<ApiResponse<ModelClient>> AddClientAsyncWithHttpInfo (ModelClient body);
        /// <summary>
        /// reads all customer data
        /// </summary>
        /// <remarks>
        /// This operation retrieves all customer data in JSON
        /// </remarks>
        /// <exception cref="FG.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;ModelClient&gt;</returns>
        System.Threading.Tasks.Task<List<ModelClient>> GetClientsAsync ();

        /// <summary>
        /// reads all customer data
        /// </summary>
        /// <remarks>
        /// This operation retrieves all customer data in JSON
        /// </remarks>
        /// <exception cref="FG.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;ModelClient&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ModelClient>>> GetClientsAsyncWithHttpInfo ();
        /// <summary>
        /// reads customer data by ID
        /// </summary>
        /// <remarks>
        /// This operation retrieves customer by its ID. The operation uses the customer ID to identify a customer in a query string.
        /// </remarks>
        /// <exception cref="FG.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Pass customer ID for retrieving customer data.</param>
        /// <returns>Task of ModelClient</returns>
        System.Threading.Tasks.Task<ModelClient> GetCustomerAsync (int? id);

        /// <summary>
        /// reads customer data by ID
        /// </summary>
        /// <remarks>
        /// This operation retrieves customer by its ID. The operation uses the customer ID to identify a customer in a query string.
        /// </remarks>
        /// <exception cref="FG.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Pass customer ID for retrieving customer data.</param>
        /// <returns>Task of ApiResponse (ModelClient)</returns>
        System.Threading.Tasks.Task<ApiResponse<ModelClient>> GetCustomerAsyncWithHttpInfo (int? id);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class DefaultApi : IDefaultApi
    {
        private FG.Api.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DefaultApi(String basePath)
        {
            this.Configuration = new FG.Api.Client.Configuration { BasePath = basePath };

            ExceptionFactory = FG.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class
        /// </summary>
        /// <returns></returns>
        public DefaultApi()
        {
            this.Configuration = FG.Api.Client.Configuration.Default;

            ExceptionFactory = FG.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DefaultApi(FG.Api.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = FG.Api.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = FG.Api.Client.Configuration.DefaultExceptionFactory;
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
        public FG.Api.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public FG.Api.Client.ExceptionFactory ExceptionFactory
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
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
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
        /// adds a new client Add a new client to the system
        /// </summary>
        /// <exception cref="FG.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">New client data</param>
        /// <returns>ModelClient</returns>
        public ModelClient AddClient (ModelClient body)
        {
             ApiResponse<ModelClient> localVarResponse = AddClientWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// adds a new client Add a new client to the system
        /// </summary>
        /// <exception cref="FG.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">New client data</param>
        /// <returns>ApiResponse of ModelClient</returns>
        public ApiResponse< ModelClient > AddClientWithHttpInfo (ModelClient body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling DefaultApi->AddClient");

            var localVarPath = "/client";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AddClient", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ModelClient>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ModelClient) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ModelClient)));
        }

        /// <summary>
        /// adds a new client Add a new client to the system
        /// </summary>
        /// <exception cref="FG.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">New client data</param>
        /// <returns>Task of ModelClient</returns>
        public async System.Threading.Tasks.Task<ModelClient> AddClientAsync (ModelClient body)
        {
             ApiResponse<ModelClient> localVarResponse = await AddClientAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// adds a new client Add a new client to the system
        /// </summary>
        /// <exception cref="FG.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">New client data</param>
        /// <returns>Task of ApiResponse (ModelClient)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ModelClient>> AddClientAsyncWithHttpInfo (ModelClient body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling DefaultApi->AddClient");

            var localVarPath = "/client";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AddClient", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ModelClient>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ModelClient) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ModelClient)));
        }

        /// <summary>
        /// reads all customer data This operation retrieves all customer data in JSON
        /// </summary>
        /// <exception cref="FG.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;ModelClient&gt;</returns>
        public List<ModelClient> GetClients ()
        {
             ApiResponse<List<ModelClient>> localVarResponse = GetClientsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// reads all customer data This operation retrieves all customer data in JSON
        /// </summary>
        /// <exception cref="FG.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;ModelClient&gt;</returns>
        public ApiResponse< List<ModelClient> > GetClientsWithHttpInfo ()
        {

            var localVarPath = "/client";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetClients", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<ModelClient>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<ModelClient>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ModelClient>)));
        }

        /// <summary>
        /// reads all customer data This operation retrieves all customer data in JSON
        /// </summary>
        /// <exception cref="FG.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;ModelClient&gt;</returns>
        public async System.Threading.Tasks.Task<List<ModelClient>> GetClientsAsync ()
        {
             ApiResponse<List<ModelClient>> localVarResponse = await GetClientsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// reads all customer data This operation retrieves all customer data in JSON
        /// </summary>
        /// <exception cref="FG.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;ModelClient&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<ModelClient>>> GetClientsAsyncWithHttpInfo ()
        {

            var localVarPath = "/client";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetClients", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<ModelClient>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<ModelClient>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ModelClient>)));
        }

        /// <summary>
        /// reads customer data by ID This operation retrieves customer by its ID. The operation uses the customer ID to identify a customer in a query string.
        /// </summary>
        /// <exception cref="FG.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Pass customer ID for retrieving customer data.</param>
        /// <returns>ModelClient</returns>
        public ModelClient GetCustomer (int? id)
        {
             ApiResponse<ModelClient> localVarResponse = GetCustomerWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// reads customer data by ID This operation retrieves customer by its ID. The operation uses the customer ID to identify a customer in a query string.
        /// </summary>
        /// <exception cref="FG.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Pass customer ID for retrieving customer data.</param>
        /// <returns>ApiResponse of ModelClient</returns>
        public ApiResponse< ModelClient > GetCustomerWithHttpInfo (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DefaultApi->GetCustomer");

            var localVarPath = "/client/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter
            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetCustomer", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ModelClient>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ModelClient) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ModelClient)));
        }

        /// <summary>
        /// reads customer data by ID This operation retrieves customer by its ID. The operation uses the customer ID to identify a customer in a query string.
        /// </summary>
        /// <exception cref="FG.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Pass customer ID for retrieving customer data.</param>
        /// <returns>Task of ModelClient</returns>
        public async System.Threading.Tasks.Task<ModelClient> GetCustomerAsync (int? id)
        {
             ApiResponse<ModelClient> localVarResponse = await GetCustomerAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// reads customer data by ID This operation retrieves customer by its ID. The operation uses the customer ID to identify a customer in a query string.
        /// </summary>
        /// <exception cref="FG.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Pass customer ID for retrieving customer data.</param>
        /// <returns>Task of ApiResponse (ModelClient)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ModelClient>> GetCustomerAsyncWithHttpInfo (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DefaultApi->GetCustomer");

            var localVarPath = "/client/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter
            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetCustomer", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ModelClient>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ModelClient) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ModelClient)));
        }

    }
}