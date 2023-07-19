# Aida.Sdk.Api.EtlApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AidaV1EtlJobIdGetDataExchangeTableDdlGet**](EtlApi.md#aidav1etljobidgetdataexchangetableddlget) | **GET** /aida/v1/etl/{jobId}/get-data-exchange-table-ddl |  |
| [**CreateDataExchangeTable**](EtlApi.md#createdataexchangetable) | **POST** /aida/v1/etl/{jobId}/create-data-exchange-table |  |
| [**DataSourceConfigurationIsValid**](EtlApi.md#datasourceconfigurationisvalid) | **GET** /aida/v1/etl/{jobId}/data-source/is-valid |  |
| [**GenerateDataSource**](EtlApi.md#generatedatasource) | **POST** /aida/v1/etl/{jobId}/generate-datasource |  |
| [**GenerateMockDataset**](EtlApi.md#generatemockdataset) | **POST** /aida/v1/etl/{jobId}/generate-mock-dataset |  |
| [**GetDataBindings**](EtlApi.md#getdatabindings) | **GET** /aida/v1/etl/{jobId}/data-bindings |  |
| [**GetDataExchangeTableDefinition**](EtlApi.md#getdataexchangetabledefinition) | **GET** /aida/v1/etl/{jobId}/exchange-table-ddl |  |
| [**GetEntityDescriptorsByJobTemplateId**](EtlApi.md#getentitydescriptorsbyjobtemplateid) | **GET** /aida/v1/etl/{jobId}/entities |  |

<a id="aidav1etljobidgetdataexchangetableddlget"></a>
# **AidaV1EtlJobIdGetDataExchangeTableDdlGet**
> string AidaV1EtlJobIdGetDataExchangeTableDdlGet (int jobId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Api;
using Aida.Sdk.Client;
using Aida.Sdk.Model;

namespace Example
{
    public class AidaV1EtlJobIdGetDataExchangeTableDdlGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new EtlApi(httpClient, config, httpClientHandler);
            var jobId = 56;  // int | 

            try
            {
                string result = apiInstance.AidaV1EtlJobIdGetDataExchangeTableDdlGet(jobId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EtlApi.AidaV1EtlJobIdGetDataExchangeTableDdlGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AidaV1EtlJobIdGetDataExchangeTableDdlGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<string> response = apiInstance.AidaV1EtlJobIdGetDataExchangeTableDdlGetWithHttpInfo(jobId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EtlApi.AidaV1EtlJobIdGetDataExchangeTableDdlGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **jobId** | **int** |  |  |

### Return type

**string**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createdataexchangetable"></a>
# **CreateDataExchangeTable**
> AddDataSourceConfiguration200Response CreateDataExchangeTable (int jobId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Api;
using Aida.Sdk.Client;
using Aida.Sdk.Model;

namespace Example
{
    public class CreateDataExchangeTableExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new EtlApi(httpClient, config, httpClientHandler);
            var jobId = 56;  // int | 

            try
            {
                AddDataSourceConfiguration200Response result = apiInstance.CreateDataExchangeTable(jobId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EtlApi.CreateDataExchangeTable: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateDataExchangeTableWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AddDataSourceConfiguration200Response> response = apiInstance.CreateDataExchangeTableWithHttpInfo(jobId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EtlApi.CreateDataExchangeTableWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **jobId** | **int** |  |  |

### Return type

[**AddDataSourceConfiguration200Response**](AddDataSourceConfiguration200Response.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datasourceconfigurationisvalid"></a>
# **DataSourceConfigurationIsValid**
> bool DataSourceConfigurationIsValid (int jobId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Api;
using Aida.Sdk.Client;
using Aida.Sdk.Model;

namespace Example
{
    public class DataSourceConfigurationIsValidExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new EtlApi(httpClient, config, httpClientHandler);
            var jobId = 56;  // int | 

            try
            {
                bool result = apiInstance.DataSourceConfigurationIsValid(jobId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EtlApi.DataSourceConfigurationIsValid: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DataSourceConfigurationIsValidWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<bool> response = apiInstance.DataSourceConfigurationIsValidWithHttpInfo(jobId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EtlApi.DataSourceConfigurationIsValidWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **jobId** | **int** |  |  |

### Return type

**bool**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="generatedatasource"></a>
# **GenerateDataSource**
> AddDataSourceConfiguration200Response GenerateDataSource (int jobId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Api;
using Aida.Sdk.Client;
using Aida.Sdk.Model;

namespace Example
{
    public class GenerateDataSourceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new EtlApi(httpClient, config, httpClientHandler);
            var jobId = 56;  // int | 

            try
            {
                AddDataSourceConfiguration200Response result = apiInstance.GenerateDataSource(jobId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EtlApi.GenerateDataSource: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GenerateDataSourceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AddDataSourceConfiguration200Response> response = apiInstance.GenerateDataSourceWithHttpInfo(jobId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EtlApi.GenerateDataSourceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **jobId** | **int** |  |  |

### Return type

[**AddDataSourceConfiguration200Response**](AddDataSourceConfiguration200Response.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="generatemockdataset"></a>
# **GenerateMockDataset**
> void GenerateMockDataset (int jobId, List<DataRecord> dataRecord = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Api;
using Aida.Sdk.Client;
using Aida.Sdk.Model;

namespace Example
{
    public class GenerateMockDatasetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new EtlApi(httpClient, config, httpClientHandler);
            var jobId = 56;  // int | 
            var dataRecord = new List<DataRecord>(); // List<DataRecord> |  (optional) 

            try
            {
                apiInstance.GenerateMockDataset(jobId, dataRecord);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EtlApi.GenerateMockDataset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GenerateMockDatasetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.GenerateMockDatasetWithHttpInfo(jobId, dataRecord);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EtlApi.GenerateMockDatasetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **jobId** | **int** |  |  |
| **dataRecord** | [**List&lt;DataRecord&gt;**](DataRecord.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getdatabindings"></a>
# **GetDataBindings**
> Dictionary&lt;string, List&lt;DataBindingDto&gt;&gt; GetDataBindings (int jobId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Api;
using Aida.Sdk.Client;
using Aida.Sdk.Model;

namespace Example
{
    public class GetDataBindingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new EtlApi(httpClient, config, httpClientHandler);
            var jobId = 56;  // int | 

            try
            {
                Dictionary<string, List<DataBindingDto>> result = apiInstance.GetDataBindings(jobId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EtlApi.GetDataBindings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDataBindingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Dictionary<string, List<DataBindingDto>>> response = apiInstance.GetDataBindingsWithHttpInfo(jobId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EtlApi.GetDataBindingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **jobId** | **int** |  |  |

### Return type

**Dictionary<string, List<DataBindingDto>>**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getdataexchangetabledefinition"></a>
# **GetDataExchangeTableDefinition**
> DataExchangeTableDefinition GetDataExchangeTableDefinition (int jobId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Api;
using Aida.Sdk.Client;
using Aida.Sdk.Model;

namespace Example
{
    public class GetDataExchangeTableDefinitionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new EtlApi(httpClient, config, httpClientHandler);
            var jobId = 56;  // int | 

            try
            {
                DataExchangeTableDefinition result = apiInstance.GetDataExchangeTableDefinition(jobId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EtlApi.GetDataExchangeTableDefinition: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDataExchangeTableDefinitionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DataExchangeTableDefinition> response = apiInstance.GetDataExchangeTableDefinitionWithHttpInfo(jobId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EtlApi.GetDataExchangeTableDefinitionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **jobId** | **int** |  |  |

### Return type

[**DataExchangeTableDefinition**](DataExchangeTableDefinition.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getentitydescriptorsbyjobtemplateid"></a>
# **GetEntityDescriptorsByJobTemplateId**
> List&lt;EntityDescriptor&gt; GetEntityDescriptorsByJobTemplateId (int jobId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Aida.Sdk.Api;
using Aida.Sdk.Client;
using Aida.Sdk.Model;

namespace Example
{
    public class GetEntityDescriptorsByJobTemplateIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new EtlApi(httpClient, config, httpClientHandler);
            var jobId = 56;  // int | 

            try
            {
                List<EntityDescriptor> result = apiInstance.GetEntityDescriptorsByJobTemplateId(jobId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EtlApi.GetEntityDescriptorsByJobTemplateId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEntityDescriptorsByJobTemplateIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<EntityDescriptor>> response = apiInstance.GetEntityDescriptorsByJobTemplateIdWithHttpInfo(jobId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EtlApi.GetEntityDescriptorsByJobTemplateIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **jobId** | **int** |  |  |

### Return type

[**List&lt;EntityDescriptor&gt;**](EntityDescriptor.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

