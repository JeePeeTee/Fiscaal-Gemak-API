# FG.Api.Api.DefaultApi

All URIs are relative to *https://api-app.fiscaalgemak.nl*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddClient**](DefaultApi.md#addclient) | **POST** /client | adds a new client
[**GetClients**](DefaultApi.md#getclients) | **GET** /client | reads all customer data
[**GetCustomer**](DefaultApi.md#getcustomer) | **GET** /client/{id} | reads customer data by ID

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
<a name="getcustomer"></a>
# **GetCustomer**
> ModelClient GetCustomer (int? id)

reads customer data by ID

This operation retrieves customer by its ID. The operation uses the customer ID to identify a customer in a query string.

### Example
```csharp
using System;
using System.Diagnostics;
using FG.Api.Api;
using FG.Api.Client;
using FG.Api.Model;

namespace Example
{
    public class GetCustomerExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var id = 56;  // int? | Pass customer ID for retrieving customer data.

            try
            {
                // reads customer data by ID
                ModelClient result = apiInstance.GetCustomer(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetCustomer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Pass customer ID for retrieving customer data. | 

### Return type

[**ModelClient**](ModelClient.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
