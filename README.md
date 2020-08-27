# Fiscaal-Gemak-API

Fiscaal Gemak API based on OpenApi 3.0

- API version: 1.0.0
- SDK version: 1.0.0
- For more information, please visit [http://www.sultancrm.nl](http://www.sultancrm.nl)

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```
NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api-app.fiscaalgemak.nl*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*DefaultApi* | [**AddClient**](docs/DefaultApi.md#addclient) | **POST** /client | adds a new client
*DefaultApi* | [**GetClients**](docs/DefaultApi.md#getclients) | **GET** /client | reads all customer data
*DefaultApi* | [**GetCustomer**](docs/DefaultApi.md#getcustomer) | **GET** /client/{id} | reads customer data by ID

<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.ClientAddresses](docs/ClientAddresses.md)
 - [Model.ClientContactPerson](docs/ClientContactPerson.md)
 - [Model.ModelClient](docs/ModelClient.md)

<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="ApiKeyAuth"></a>
### ApiKeyAuth

- **Type**: API key
- **API key parameter name**: Authorization
- **Location**: HTTP header
