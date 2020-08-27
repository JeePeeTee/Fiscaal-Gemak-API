# FG.Api.Api.DefaultApi

All URIs are relative to *https://api-app.fiscaalgemak.nl*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddClient**](DefaultApi.md#addclient) | **POST** /client | adds a new client
[**DeleteClient**](DefaultApi.md#deleteclient) | **DELETE** /client/{id} | delete an existing client
[**GetClient**](DefaultApi.md#getclient) | **GET** /client/{id} | reads client data by ID
[**GetClients**](DefaultApi.md#getclients) | **GET** /client | reads all customer data
[**UpdateClient**](DefaultApi.md#updateclient) | **PUT** /client/{id} | update client data by ID

<a name="addclient"></a>
# **AddClient**
> ModelClient AddClient (ModelClient body)

adds a new client

Add a new client to the system

### Example
```csharp
using System;
using System.Diagnostics;
using FG.Api.Api;
using FG.Api.Client;
using FG.Api.Model;

namespace Example
{
    public class AddClientExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var body = new ModelClient(); // ModelClient | New client data

            try
            {
                // adds a new client
                ModelClient result = apiInstance.AddClient(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.AddClient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ModelClient**](ModelClient.md)| New client data | 

### Return type

[**ModelClient**](ModelClient.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteclient"></a>
# **DeleteClient**
> void DeleteClient (int? id)

delete an existing client

Delete an existing client by ID

### Example
```csharp
using System;
using System.Diagnostics;
using FG.Api.Api;
using FG.Api.Client;
using FG.Api.Model;

namespace Example
{
    public class DeleteClientExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var id = 56;  // int? | Pass client ID for updateing client data.

            try
            {
                // delete an existing client
                apiInstance.DeleteClient(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteClient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Pass client ID for updateing client data. | 

### Return type

void (empty response body)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getclient"></a>
# **GetClient**
> ModelClient GetClient (int? id)

reads client data by ID

This operation retrieves client by its ID. The operation uses the client ID to identify a client in a query string.

### Example
```csharp
using System;
using System.Diagnostics;
using FG.Api.Api;
using FG.Api.Client;
using FG.Api.Model;

namespace Example
{
    public class GetClientExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var id = 56;  // int? | Pass client ID for retrieving client data.

            try
            {
                // reads client data by ID
                ModelClient result = apiInstance.GetClient(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetClient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Pass client ID for retrieving client data. | 

### Return type

[**ModelClient**](ModelClient.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getclients"></a>
# **GetClients**
> List<ModelClient> GetClients ()

reads all customer data

This operation retrieves all customer data in JSON

### Example
```csharp
using System;
using System.Diagnostics;
using FG.Api.Api;
using FG.Api.Client;
using FG.Api.Model;

namespace Example
{
    public class GetClientsExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi();

            try
            {
                // reads all customer data
                List&lt;ModelClient&gt; result = apiInstance.GetClients();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetClients: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<ModelClient>**](ModelClient.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateclient"></a>
# **UpdateClient**
> ModelClient UpdateClient (ModelClient body, int? id)

update client data by ID

This operation updates client by its ID. The operation uses the client ID to identify a client in a query string.

### Example
```csharp
using System;
using System.Diagnostics;
using FG.Api.Api;
using FG.Api.Client;
using FG.Api.Model;

namespace Example
{
    public class UpdateClientExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var body = new ModelClient(); // ModelClient | New client data
            var id = 56;  // int? | Pass client ID for updateing client data.

            try
            {
                // update client data by ID
                ModelClient result = apiInstance.UpdateClient(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateClient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ModelClient**](ModelClient.md)| New client data | 
 **id** | **int?**| Pass client ID for updateing client data. | 

### Return type

[**ModelClient**](ModelClient.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
