# Aida.Sdk.Api.PersoProcessConfigurationApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AidaV1WorkflowsPersoProcessJobTemplateIdGet**](PersoProcessConfigurationApi.md#aidav1workflowspersoprocessjobtemplateidget) | **GET** /aida/v1/workflows/perso-process/{jobTemplateId} |  |
| [**GetJobInstance**](PersoProcessConfigurationApi.md#getjobinstance) | **GET** /aida/v1/workflows/job-instance/{jobInstanceId} |  |
| [**GetJobInstances**](PersoProcessConfigurationApi.md#getjobinstances) | **GET** /aida/v1/workflows/job-instances |  |
| [**GetPersoProcessConfiguration**](PersoProcessConfigurationApi.md#getpersoprocessconfiguration) | **GET** /aida/v1/workflows/{jobTemplateId}/configuration |  |
| [**GetPersoSteps**](PersoProcessConfigurationApi.md#getpersosteps) | **GET** /aida/v1/workflows/{jobTemplateId}/perso-process-steps |  |
| [**GetTestPersoProcessStatus**](PersoProcessConfigurationApi.md#gettestpersoprocessstatus) | **GET** /aida/v1/workflows/get-test-perso-process-status |  |
| [**SetPersoProcessConfiguration**](PersoProcessConfigurationApi.md#setpersoprocessconfiguration) | **POST** /aida/v1/workflows/{jobTemplateId}/configuration |  |
| [**StartTestPersoProcess**](PersoProcessConfigurationApi.md#starttestpersoprocess) | **GET** /aida/v1/workflows/start-test-perso-process |  |
| [**StopTestPersoProcess**](PersoProcessConfigurationApi.md#stoptestpersoprocess) | **GET** /aida/v1/workflows/stop-test-perso-process |  |

<a id="aidav1workflowspersoprocessjobtemplateidget"></a>
# **AidaV1WorkflowsPersoProcessJobTemplateIdGet**
> PersoOperation AidaV1WorkflowsPersoProcessJobTemplateIdGet (int jobTemplateId)



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
    public class AidaV1WorkflowsPersoProcessJobTemplateIdGetExample
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
            var apiInstance = new PersoProcessConfigurationApi(httpClient, config, httpClientHandler);
            var jobTemplateId = 56;  // int | 

            try
            {
                PersoOperation result = apiInstance.AidaV1WorkflowsPersoProcessJobTemplateIdGet(jobTemplateId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersoProcessConfigurationApi.AidaV1WorkflowsPersoProcessJobTemplateIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AidaV1WorkflowsPersoProcessJobTemplateIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PersoOperation> response = apiInstance.AidaV1WorkflowsPersoProcessJobTemplateIdGetWithHttpInfo(jobTemplateId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersoProcessConfigurationApi.AidaV1WorkflowsPersoProcessJobTemplateIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **jobTemplateId** | **int** |  |  |

### Return type

[**PersoOperation**](PersoOperation.md)

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

<a id="getjobinstance"></a>
# **GetJobInstance**
> JobInstance GetJobInstance (string jobInstanceId)



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
    public class GetJobInstanceExample
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
            var apiInstance = new PersoProcessConfigurationApi(httpClient, config, httpClientHandler);
            var jobInstanceId = "jobInstanceId_example";  // string | 

            try
            {
                JobInstance result = apiInstance.GetJobInstance(jobInstanceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersoProcessConfigurationApi.GetJobInstance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetJobInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<JobInstance> response = apiInstance.GetJobInstanceWithHttpInfo(jobInstanceId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersoProcessConfigurationApi.GetJobInstanceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **jobInstanceId** | **string** |  |  |

### Return type

[**JobInstance**](JobInstance.md)

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

<a id="getjobinstances"></a>
# **GetJobInstances**
> List&lt;JobInstance&gt; GetJobInstances (int? page = null, int? pageSize = null, string query = null, string sortCriteriaPropertyName = null, SortDirection? sortCriteriaDirection = null)



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
    public class GetJobInstancesExample
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
            var apiInstance = new PersoProcessConfigurationApi(httpClient, config, httpClientHandler);
            var page = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 
            var query = "query_example";  // string |  (optional) 
            var sortCriteriaPropertyName = "sortCriteriaPropertyName_example";  // string |  (optional) 
            var sortCriteriaDirection = (SortDirection) "Ascending";  // SortDirection? |  (optional) 

            try
            {
                List<JobInstance> result = apiInstance.GetJobInstances(page, pageSize, query, sortCriteriaPropertyName, sortCriteriaDirection);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersoProcessConfigurationApi.GetJobInstances: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetJobInstancesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<JobInstance>> response = apiInstance.GetJobInstancesWithHttpInfo(page, pageSize, query, sortCriteriaPropertyName, sortCriteriaDirection);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersoProcessConfigurationApi.GetJobInstancesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** |  | [optional]  |
| **pageSize** | **int?** |  | [optional]  |
| **query** | **string** |  | [optional]  |
| **sortCriteriaPropertyName** | **string** |  | [optional]  |
| **sortCriteriaDirection** | **SortDirection?** |  | [optional]  |

### Return type

[**List&lt;JobInstance&gt;**](JobInstance.md)

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

<a id="getpersoprocessconfiguration"></a>
# **GetPersoProcessConfiguration**
> PersoProcessConfigurationDto GetPersoProcessConfiguration (int jobTemplateId)



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
    public class GetPersoProcessConfigurationExample
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
            var apiInstance = new PersoProcessConfigurationApi(httpClient, config, httpClientHandler);
            var jobTemplateId = 56;  // int | 

            try
            {
                PersoProcessConfigurationDto result = apiInstance.GetPersoProcessConfiguration(jobTemplateId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersoProcessConfigurationApi.GetPersoProcessConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPersoProcessConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PersoProcessConfigurationDto> response = apiInstance.GetPersoProcessConfigurationWithHttpInfo(jobTemplateId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersoProcessConfigurationApi.GetPersoProcessConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **jobTemplateId** | **int** |  |  |

### Return type

[**PersoProcessConfigurationDto**](PersoProcessConfigurationDto.md)

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

<a id="getpersosteps"></a>
# **GetPersoSteps**
> List&lt;PersoOperationDto&gt; GetPersoSteps (int jobTemplateId)



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
    public class GetPersoStepsExample
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
            var apiInstance = new PersoProcessConfigurationApi(httpClient, config, httpClientHandler);
            var jobTemplateId = 56;  // int | 

            try
            {
                List<PersoOperationDto> result = apiInstance.GetPersoSteps(jobTemplateId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersoProcessConfigurationApi.GetPersoSteps: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPersoStepsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<PersoOperationDto>> response = apiInstance.GetPersoStepsWithHttpInfo(jobTemplateId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersoProcessConfigurationApi.GetPersoStepsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **jobTemplateId** | **int** |  |  |

### Return type

[**List&lt;PersoOperationDto&gt;**](PersoOperationDto.md)

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

<a id="gettestpersoprocessstatus"></a>
# **GetTestPersoProcessStatus**
> List&lt;PersoOperationDto&gt; GetTestPersoProcessStatus ()



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
    public class GetTestPersoProcessStatusExample
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
            var apiInstance = new PersoProcessConfigurationApi(httpClient, config, httpClientHandler);

            try
            {
                List<PersoOperationDto> result = apiInstance.GetTestPersoProcessStatus();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersoProcessConfigurationApi.GetTestPersoProcessStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTestPersoProcessStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<PersoOperationDto>> response = apiInstance.GetTestPersoProcessStatusWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersoProcessConfigurationApi.GetTestPersoProcessStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;PersoOperationDto&gt;**](PersoOperationDto.md)

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

<a id="setpersoprocessconfiguration"></a>
# **SetPersoProcessConfiguration**
> void SetPersoProcessConfiguration (int jobTemplateId, PersoProcessConfigurationDto persoProcessConfigurationDto = null)



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
    public class SetPersoProcessConfigurationExample
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
            var apiInstance = new PersoProcessConfigurationApi(httpClient, config, httpClientHandler);
            var jobTemplateId = 56;  // int | 
            var persoProcessConfigurationDto = new PersoProcessConfigurationDto(); // PersoProcessConfigurationDto |  (optional) 

            try
            {
                apiInstance.SetPersoProcessConfiguration(jobTemplateId, persoProcessConfigurationDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersoProcessConfigurationApi.SetPersoProcessConfiguration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetPersoProcessConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.SetPersoProcessConfigurationWithHttpInfo(jobTemplateId, persoProcessConfigurationDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersoProcessConfigurationApi.SetPersoProcessConfigurationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **jobTemplateId** | **int** |  |  |
| **persoProcessConfigurationDto** | [**PersoProcessConfigurationDto**](PersoProcessConfigurationDto.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="starttestpersoprocess"></a>
# **StartTestPersoProcess**
> JobInstance StartTestPersoProcess (int? jobTemplateId = null, bool? disableLaserSource = null)



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
    public class StartTestPersoProcessExample
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
            var apiInstance = new PersoProcessConfigurationApi(httpClient, config, httpClientHandler);
            var jobTemplateId = 56;  // int? |  (optional) 
            var disableLaserSource = false;  // bool? |  (optional)  (default to false)

            try
            {
                JobInstance result = apiInstance.StartTestPersoProcess(jobTemplateId, disableLaserSource);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersoProcessConfigurationApi.StartTestPersoProcess: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StartTestPersoProcessWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<JobInstance> response = apiInstance.StartTestPersoProcessWithHttpInfo(jobTemplateId, disableLaserSource);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersoProcessConfigurationApi.StartTestPersoProcessWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **jobTemplateId** | **int?** |  | [optional]  |
| **disableLaserSource** | **bool?** |  | [optional] [default to false] |

### Return type

[**JobInstance**](JobInstance.md)

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

<a id="stoptestpersoprocess"></a>
# **StopTestPersoProcess**
> List&lt;PersoOperationDto&gt; StopTestPersoProcess ()



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
    public class StopTestPersoProcessExample
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
            var apiInstance = new PersoProcessConfigurationApi(httpClient, config, httpClientHandler);

            try
            {
                List<PersoOperationDto> result = apiInstance.StopTestPersoProcess();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersoProcessConfigurationApi.StopTestPersoProcess: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StopTestPersoProcessWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<PersoOperationDto>> response = apiInstance.StopTestPersoProcessWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersoProcessConfigurationApi.StopTestPersoProcessWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;PersoOperationDto&gt;**](PersoOperationDto.md)

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

