#region Copyright (c) 2000-2020 Sultan CRM BV

// ===========================================================
// 
// MIT License
// 
// Copyright (c) 2020 Sultan CRM B.V. / Jean Paul Teunisse
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
// 
// ===========================================================

#endregion

#region usings

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using FG.Api.Client;
using FG.Api.Model;
using RestSharp;

#endregion

namespace FG.Api.Api {
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDefaultApi : IApiAccessor {
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
        ModelClient AddClient(ModelClient body);

        /// <summary>
        /// adds a new client
        /// </summary>
        /// <remarks>
        /// Add a new client to the system
        /// </remarks>
        /// <exception cref="FG.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">New client data</param>
        /// <returns>ApiResponse of ModelClient</returns>
        ApiResponse<ModelClient> AddClientWithHttpInfo(ModelClient body);

        /// <summary>
        /// delete an existing client
        /// </summary>
        /// <remarks>
        /// Delete an existing client by ID
        /// </remarks>
        /// <exception cref="FG.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Pass client ID for updateing client data.</param>
        /// <returns></returns>
        void DeleteClient(int? id);

        /// <summary>
        /// delete an existing client
        /// </summary>
        /// <remarks>
        /// Delete an existing client by ID
        /// </remarks>
        /// <exception cref="FG.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Pass client ID for updateing client data.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteClientWithHttpInfo(int? id);

        /// <summary>
        /// reads client data by ID
        /// </summary>
        /// <remarks>
        /// This operation retrieves client by its ID. The operation uses the client ID to identify a client in a query string.
        /// </remarks>
        /// <exception cref="FG.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Pass client ID for retrieving client data.</param>
        /// <returns>ModelClient</returns>
        ModelClient GetClient(int? id);

        /// <summary>
        /// reads client data by ID
        /// </summary>
        /// <remarks>
        /// This operation retrieves client by its ID. The operation uses the client ID to identify a client in a query string.
        /// </remarks>
        /// <exception cref="FG.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Pass client ID for retrieving client data.</param>
        /// <returns>ApiResponse of ModelClient</returns>
        ApiResponse<ModelClient> GetClientWithHttpInfo(int? id);

        /// <summary>
        /// reads all customer data
        /// </summary>
        /// <remarks>
        /// This operation retrieves all customer data in JSON
        /// </remarks>
        /// <exception cref="FG.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;ModelClient&gt;</returns>
        List<ModelClient> GetClients();

        /// <summary>
        /// reads all customer data
        /// </summary>
        /// <remarks>
        /// This operation retrieves all customer data in JSON
        /// </remarks>
        /// <exception cref="FG.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;ModelClient&gt;</returns>
        ApiResponse<List<ModelClient>> GetClientsWithHttpInfo();

        /// <summary>
        /// update client data by ID
        /// </summary>
        /// <remarks>
        /// This operation updates client by its ID. The operation uses the client ID to identify a client in a query string.
        /// </remarks>
        /// <exception cref="FG.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">New client data</param>
        /// <param name="id">Pass client ID for updateing client data.</param>
        /// <returns>ModelClient</returns>
        ModelClient UpdateClient(ModelClient body, int? id);

        /// <summary>
        /// update client data by ID
        /// </summary>
        /// <remarks>
        /// This operation updates client by its ID. The operation uses the client ID to identify a client in a query string.
        /// </remarks>
        /// <exception cref="FG.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">New client data</param>
        /// <param name="id">Pass client ID for updateing client data.</param>
        /// <returns>ApiResponse of ModelClient</returns>
        ApiResponse<ModelClient> UpdateClientWithHttpInfo(ModelClient body, int? id);

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
        System.Threading.Tasks.Task<ModelClient> AddClientAsync(ModelClient body);

        /// <summary>
        /// adds a new client
        /// </summary>
        /// <remarks>
        /// Add a new client to the system
        /// </remarks>
        /// <exception cref="FG.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">New client data</param>
        /// <returns>Task of ApiResponse (ModelClient)</returns>
        System.Threading.Tasks.Task<ApiResponse<ModelClient>> AddClientAsyncWithHttpInfo(ModelClient body);

        /// <summary>
        /// delete an existing client
        /// </summary>
        /// <remarks>
        /// Delete an existing client by ID
        /// </remarks>
        /// <exception cref="FG.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Pass client ID for updateing client data.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteClientAsync(int? id);

        /// <summary>
        /// delete an existing client
        /// </summary>
        /// <remarks>
        /// Delete an existing client by ID
        /// </remarks>
        /// <exception cref="FG.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Pass client ID for updateing client data.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteClientAsyncWithHttpInfo(int? id);

        /// <summary>
        /// reads client data by ID
        /// </summary>
        /// <remarks>
        /// This operation retrieves client by its ID. The operation uses the client ID to identify a client in a query string.
        /// </remarks>
        /// <exception cref="FG.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Pass client ID for retrieving client data.</param>
        /// <returns>Task of ModelClient</returns>
        System.Threading.Tasks.Task<ModelClient> GetClientAsync(int? id);

        /// <summary>
        /// reads client data by ID
        /// </summary>
        /// <remarks>
        /// This operation retrieves client by its ID. The operation uses the client ID to identify a client in a query string.
        /// </remarks>
        /// <exception cref="FG.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Pass client ID for retrieving client data.</param>
        /// <returns>Task of ApiResponse (ModelClient)</returns>
        System.Threading.Tasks.Task<ApiResponse<ModelClient>> GetClientAsyncWithHttpInfo(int? id);

        /// <summary>
        /// reads all customer data
        /// </summary>
        /// <remarks>
        /// This operation retrieves all customer data in JSON
        /// </remarks>
        /// <exception cref="FG.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;ModelClient&gt;</returns>
        System.Threading.Tasks.Task<List<ModelClient>> GetClientsAsync();

        /// <summary>
        /// reads all customer data
        /// </summary>
        /// <remarks>
        /// This operation retrieves all customer data in JSON
        /// </remarks>
        /// <exception cref="FG.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;ModelClient&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ModelClient>>> GetClientsAsyncWithHttpInfo();

        /// <summary>
        /// update client data by ID
        /// </summary>
        /// <remarks>
        /// This operation updates client by its ID. The operation uses the client ID to identify a client in a query string.
        /// </remarks>
        /// <exception cref="FG.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">New client data</param>
        /// <param name="id">Pass client ID for updateing client data.</param>
        /// <returns>Task of ModelClient</returns>
        System.Threading.Tasks.Task<ModelClient> UpdateClientAsync(ModelClient body, int? id);

        /// <summary>
        /// update client data by ID
        /// </summary>
        /// <remarks>
        /// This operation updates client by its ID. The operation uses the client ID to identify a client in a query string.
        /// </remarks>
        /// <exception cref="FG.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">New client data</param>
        /// <param name="id">Pass client ID for updateing client data.</param>
        /// <returns>Task of ApiResponse (ModelClient)</returns>
        System.Threading.Tasks.Task<ApiResponse<ModelClient>> UpdateClientAsyncWithHttpInfo(ModelClient body, int? id);

        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DefaultApi : IDefaultApi {
        private FG.Api.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DefaultApi(String basePath) {
            this.Configuration = new FG.Api.Client.Configuration {BasePath = basePath};

            ExceptionFactory = FG.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class
        /// </summary>
        /// <returns></returns>
        public DefaultApi() {
            this.Configuration = FG.Api.Client.Configuration.Default;

            ExceptionFactory = FG.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DefaultApi(FG.Api.Client.Configuration configuration = null) {
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
        public String GetBasePath() {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public FG.Api.Client.Configuration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public FG.Api.Client.ExceptionFactory ExceptionFactory {
            get {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1) {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }

                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// adds a new client Add a new client to the system
        /// </summary>
        /// <exception cref="FG.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">New client data</param>
        /// <returns>ModelClient</returns>
        public ModelClient AddClient(ModelClient body) {
            var localVarResponse = AddClientWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// adds a new client Add a new client to the system
        /// </summary>
        /// <exception cref="FG.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">New client data</param>
        /// <returns>ApiResponse of ModelClient</returns>
        public ApiResponse<ModelClient> AddClientWithHttpInfo(ModelClient body) {
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
            var localVarHttpContentTypes = new String[] {
                "application/json"
            };
            var localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            var localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            var localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[])) {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else {
                localVarPostBody = body; // byte array
            }

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization"))) {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            var localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null) {
                var exception = ExceptionFactory("AddClient", localVarResponse);
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
        public async System.Threading.Tasks.Task<ModelClient> AddClientAsync(ModelClient body) {
            var localVarResponse = await AddClientAsyncWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// adds a new client Add a new client to the system
        /// </summary>
        /// <exception cref="FG.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">New client data</param>
        /// <returns>Task of ApiResponse (ModelClient)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ModelClient>> AddClientAsyncWithHttpInfo(ModelClient body) {
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
            var localVarHttpContentTypes = new String[] {
                "application/json"
            };
            var localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            var localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            var localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[])) {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else {
                localVarPostBody = body; // byte array
            }

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization"))) {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            var localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null) {
                var exception = ExceptionFactory("AddClient", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ModelClient>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ModelClient) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ModelClient)));
        }

        /// <summary>
        /// delete an existing client Delete an existing client by ID
        /// </summary>
        /// <exception cref="FG.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Pass client ID for updateing client data.</param>
        /// <returns></returns>
        public void DeleteClient(int? id) {
            DeleteClientWithHttpInfo(id);
        }

        /// <summary>
        /// delete an existing client Delete an existing client by ID
        /// </summary>
        /// <exception cref="FG.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Pass client ID for updateing client data.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteClientWithHttpInfo(int? id) {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DefaultApi->DeleteClient");

            var localVarPath = "/client/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            var localVarHttpContentTypes = new String[] {
            };
            var localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            var localVarHttpHeaderAccepts = new String[] {
            };
            var localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter
            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization"))) {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            var localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null) {
                var exception = ExceptionFactory("DeleteClient", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// delete an existing client Delete an existing client by ID
        /// </summary>
        /// <exception cref="FG.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Pass client ID for updateing client data.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteClientAsync(int? id) {
            await DeleteClientAsyncWithHttpInfo(id);
        }

        /// <summary>
        /// delete an existing client Delete an existing client by ID
        /// </summary>
        /// <exception cref="FG.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Pass client ID for updateing client data.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteClientAsyncWithHttpInfo(int? id) {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DefaultApi->DeleteClient");

            var localVarPath = "/client/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            var localVarHttpContentTypes = new String[] {
            };
            var localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            var localVarHttpHeaderAccepts = new String[] {
            };
            var localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter
            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization"))) {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            var localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null) {
                var exception = ExceptionFactory("DeleteClient", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// reads client data by ID This operation retrieves client by its ID. The operation uses the client ID to identify a client in a query string.
        /// </summary>
        /// <exception cref="FG.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Pass client ID for retrieving client data.</param>
        /// <returns>ModelClient</returns>
        public ModelClient GetClient(int? id) {
            var localVarResponse = GetClientWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// reads client data by ID This operation retrieves client by its ID. The operation uses the client ID to identify a client in a query string.
        /// </summary>
        /// <exception cref="FG.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Pass client ID for retrieving client data.</param>
        /// <returns>ApiResponse of ModelClient</returns>
        public ApiResponse<ModelClient> GetClientWithHttpInfo(int? id) {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DefaultApi->GetClient");

            var localVarPath = "/client/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            var localVarHttpContentTypes = new String[] {
            };
            var localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            var localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            var localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter
            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization"))) {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            var localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null) {
                var exception = ExceptionFactory("GetClient", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ModelClient>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ModelClient) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ModelClient)));
        }

        /// <summary>
        /// reads client data by ID This operation retrieves client by its ID. The operation uses the client ID to identify a client in a query string.
        /// </summary>
        /// <exception cref="FG.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Pass client ID for retrieving client data.</param>
        /// <returns>Task of ModelClient</returns>
        public async System.Threading.Tasks.Task<ModelClient> GetClientAsync(int? id) {
            var localVarResponse = await GetClientAsyncWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// reads client data by ID This operation retrieves client by its ID. The operation uses the client ID to identify a client in a query string.
        /// </summary>
        /// <exception cref="FG.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Pass client ID for retrieving client data.</param>
        /// <returns>Task of ApiResponse (ModelClient)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ModelClient>> GetClientAsyncWithHttpInfo(int? id) {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DefaultApi->GetClient");

            var localVarPath = "/client/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            var localVarHttpContentTypes = new String[] {
            };
            var localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            var localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            var localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter
            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization"))) {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            var localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null) {
                var exception = ExceptionFactory("GetClient", localVarResponse);
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
        public List<ModelClient> GetClients() {
            var localVarResponse = GetClientsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// reads all customer data This operation retrieves all customer data in JSON
        /// </summary>
        /// <exception cref="FG.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;ModelClient&gt;</returns>
        public ApiResponse<List<ModelClient>> GetClientsWithHttpInfo() {
            var localVarPath = "/client";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            var localVarHttpContentTypes = new String[] {
            };
            var localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            var localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            var localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization"))) {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            var localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null) {
                var exception = ExceptionFactory("GetClients", localVarResponse);
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
        public async System.Threading.Tasks.Task<List<ModelClient>> GetClientsAsync() {
            var localVarResponse = await GetClientsAsyncWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// reads all customer data This operation retrieves all customer data in JSON
        /// </summary>
        /// <exception cref="FG.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;ModelClient&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<ModelClient>>> GetClientsAsyncWithHttpInfo() {
            var localVarPath = "/client";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            var localVarHttpContentTypes = new String[] {
            };
            var localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            var localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            var localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization"))) {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            var localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null) {
                var exception = ExceptionFactory("GetClients", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<ModelClient>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<ModelClient>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ModelClient>)));
        }

        /// <summary>
        /// update client data by ID This operation updates client by its ID. The operation uses the client ID to identify a client in a query string.
        /// </summary>
        /// <exception cref="FG.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">New client data</param>
        /// <param name="id">Pass client ID for updateing client data.</param>
        /// <returns>ModelClient</returns>
        public ModelClient UpdateClient(ModelClient body, int? id) {
            var localVarResponse = UpdateClientWithHttpInfo(body, id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// update client data by ID This operation updates client by its ID. The operation uses the client ID to identify a client in a query string.
        /// </summary>
        /// <exception cref="FG.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">New client data</param>
        /// <param name="id">Pass client ID for updateing client data.</param>
        /// <returns>ApiResponse of ModelClient</returns>
        public ApiResponse<ModelClient> UpdateClientWithHttpInfo(ModelClient body, int? id) {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling DefaultApi->UpdateClient");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DefaultApi->UpdateClient");

            var localVarPath = "/client/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            var localVarHttpContentTypes = new String[] {
                "application/json"
            };
            var localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            var localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            var localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (body != null && body.GetType() != typeof(byte[])) {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else {
                localVarPostBody = body; // byte array
            }

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization"))) {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            var localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null) {
                var exception = ExceptionFactory("UpdateClient", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ModelClient>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ModelClient) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ModelClient)));
        }

        /// <summary>
        /// update client data by ID This operation updates client by its ID. The operation uses the client ID to identify a client in a query string.
        /// </summary>
        /// <exception cref="FG.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">New client data</param>
        /// <param name="id">Pass client ID for updateing client data.</param>
        /// <returns>Task of ModelClient</returns>
        public async System.Threading.Tasks.Task<ModelClient> UpdateClientAsync(ModelClient body, int? id) {
            var localVarResponse = await UpdateClientAsyncWithHttpInfo(body, id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// update client data by ID This operation updates client by its ID. The operation uses the client ID to identify a client in a query string.
        /// </summary>
        /// <exception cref="FG.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">New client data</param>
        /// <param name="id">Pass client ID for updateing client data.</param>
        /// <returns>Task of ApiResponse (ModelClient)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ModelClient>> UpdateClientAsyncWithHttpInfo(ModelClient body, int? id) {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling DefaultApi->UpdateClient");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DefaultApi->UpdateClient");

            var localVarPath = "/client/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            var localVarHttpContentTypes = new String[] {
                "application/json"
            };
            var localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            var localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            var localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (body != null && body.GetType() != typeof(byte[])) {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else {
                localVarPostBody = body; // byte array
            }

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization"))) {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            var localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null) {
                var exception = ExceptionFactory("UpdateClient", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ModelClient>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ModelClient) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ModelClient)));
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath) {
            // do nothing
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader() {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value) {
            this.Configuration.AddDefaultHeader(key, value);
        }
    }
}