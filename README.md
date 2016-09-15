# Getting Started
## How to Build

The generated code uses a few NuGet Packages e.g., Newtonsoft.Json, UniRest,
and Microsoft Base Class Library. The reference to these packages is already
added as in the packages.config file. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.
     
1. Open the solution (Tester.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](http://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=Tester-CSharp&workspaceName=Tester&projectName=Tester.PCL)

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
 Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the following link. 
http://msdn.microsoft.com/en-us/library/vstudio/gg597391(v=vs.100).aspx

The following section explains how to use the Tester library in a new console project.     
    
#### 1. Starting a new project
For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

![Add a new project in the existing solution using Visual Studio](http://apidocs.io/illustration/cs?step=addProject&workspaceFolder=Tester-CSharp&workspaceName=Tester&projectName=Tester.PCL)

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

![Create a new console project using Visual Studio](http://apidocs.io/illustration/cs?step=createProject&workspaceFolder=Tester-CSharp&workspaceName=Tester&projectName=Tester.PCL)


#### 2. Set as startup project
The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

![Set the new cosole project as the start up project](http://apidocs.io/illustration/cs?step=setStartup&workspaceFolder=Tester-CSharp&workspaceName=Tester&projectName=Tester.PCL)


#### 3. Add reference of the library project
In order to use the Tester library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

![Open references of the TestConsoleProject](http://apidocs.io/illustration/cs?step=addReference&workspaceFolder=Tester-CSharp&workspaceName=Tester&projectName=Tester.PCL)

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` Tester.PCL ``` and click ``` OK ```. By doing this, we have added a reference of the ```Tester.PCL``` project into the new ``` TestConsoleProject ```.

![Add a reference to the TestConsoleProject](http://apidocs.io/illustration/cs?step=createReference&workspaceFolder=Tester-CSharp&workspaceName=Tester&projectName=Tester.PCL)


#### 4. Write sample code
Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Add a reference to the TestConsoleProject](http://apidocs.io/illustration/cs?step=addCode&workspaceFolder=Tester-CSharp&workspaceName=Tester&projectName=Tester.PCL)

## How to Test

The generated SDK also contain one or more Tests, which are contained in the Tests project.
In order to invoke these test cases, you will need *NUnit 3.0 Test Adapter Extension for Visual Studio*.
Once the SDK is complied, the test cases should appear in the Test Explorer window.
Here, you can click *Run All* to execute these test cases.

## Initialization

#### Initialization

API client can be initialized as following.

```csharp

TesterClient client = new TesterClient();
```

# Class Reference
## <a name="list_of_controllers"></a>List of Controllers

* [ResponseTypesController](#response_types_controller)
* [TemplateParamsController](#template_params_controller)
* [QueryParamController](#query_param_controller)
* [FormParamsController](#form_params_controller)
* [BodyParamsController](#body_params_controller)
* [EchoController](#echo_controller)
* [HeaderController](#header_controller)
* [ErrorCodesController](#error_codes_controller)

## <a name="response_types_controller"></a>![Class: ](http://apidocs.io/img/class.png "Tester.PCL.Controllers.ResponseTypesController") ResponseTypesController

#### Get singleton instance
The singleton instance of the ``` ResponseTypesController ``` class can be accessed from the API Client.
```csharp
IResponseTypesController responseTypes = client.ResponseTypes;
```

### <a name="get_string_enum_array"></a>![Method: ](http://apidocs.io/img/method.png "Tester.PCL.Controllers.ResponseTypesController.GetStringEnumArray") GetStringEnumArray

> TODO: Add a method description

```csharp
Task<List<Days>> GetStringEnumArray()
```

#### Example Usage:
```csharp

List<Days> result = await responseTypes.GetStringEnumArray();

```





### <a name="get_boolean_array"></a>![Method: ](http://apidocs.io/img/method.png "Tester.PCL.Controllers.ResponseTypesController.GetBooleanArray") GetBooleanArray

> TODO: Add a method description

```csharp
Task<List<bool>> GetBooleanArray()
```

#### Example Usage:
```csharp

List<bool> result = await responseTypes.GetBooleanArray();

```





### <a name="get_headers"></a>![Method: ](http://apidocs.io/img/method.png "Tester.PCL.Controllers.ResponseTypesController.GetHeaders") GetHeaders

> TODO: Add a method description

```csharp
Task GetHeaders()
```

#### Example Usage:
```csharp

await responseTypes.GetHeaders();

```





### <a name="get_boolean"></a>![Method: ](http://apidocs.io/img/method.png "Tester.PCL.Controllers.ResponseTypesController.GetBoolean") GetBoolean

> TODO: Add a method description

```csharp
Task<bool?> GetBoolean()
```

#### Example Usage:
```csharp

bool? result = await responseTypes.GetBoolean();

```





### <a name="get_datetime"></a>![Method: ](http://apidocs.io/img/method.png "Tester.PCL.Controllers.ResponseTypesController.GetDatetime") GetDatetime

> TODO: Add a method description

```csharp
Task<DateTime?> GetDatetime()
```

#### Example Usage:
```csharp

DateTime? result = await responseTypes.GetDatetime();

```





### <a name="get_datetime_array"></a>![Method: ](http://apidocs.io/img/method.png "Tester.PCL.Controllers.ResponseTypesController.GetDatetimeArray") GetDatetimeArray

> TODO: Add a method description

```csharp
Task<List<DateTime>> GetDatetimeArray()
```

#### Example Usage:
```csharp

List<DateTime> result = await responseTypes.GetDatetimeArray();

```





### <a name="get_dynamic"></a>![Method: ](http://apidocs.io/img/method.png "Tester.PCL.Controllers.ResponseTypesController.GetDynamic") GetDynamic

> TODO: Add a method description

```csharp
Task<dynamic> GetDynamic()
```

#### Example Usage:
```csharp

dynamic result = await responseTypes.GetDynamic();

```





### <a name="get_dynamic_array"></a>![Method: ](http://apidocs.io/img/method.png "Tester.PCL.Controllers.ResponseTypesController.GetDynamicArray") GetDynamicArray

> TODO: Add a method description

```csharp
Task<dynamic> GetDynamicArray()
```

#### Example Usage:
```csharp

dynamic result = await responseTypes.GetDynamicArray();

```





### <a name="get_integer_array"></a>![Method: ](http://apidocs.io/img/method.png "Tester.PCL.Controllers.ResponseTypesController.GetIntegerArray") GetIntegerArray

> Get an array of integers.

```csharp
Task<List<int>> GetIntegerArray()
```

#### Example Usage:
```csharp

List<int> result = await responseTypes.GetIntegerArray();

```





### <a name="get_integer"></a>![Method: ](http://apidocs.io/img/method.png "Tester.PCL.Controllers.ResponseTypesController.GetInteger") GetInteger

> Gets a integer response

```csharp
Task<int?> GetInteger()
```

#### Example Usage:
```csharp

int? result = await responseTypes.GetInteger();

```





### <a name="get_binary"></a>![Method: ](http://apidocs.io/img/method.png "Tester.PCL.Controllers.ResponseTypesController.GetBinary") GetBinary

> gets a binary object

```csharp
Task<Stream> GetBinary()
```

#### Example Usage:
```csharp

Stream result = await responseTypes.GetBinary();

```





### <a name="get_precision"></a>![Method: ](http://apidocs.io/img/method.png "Tester.PCL.Controllers.ResponseTypesController.GetPrecision") GetPrecision

> TODO: Add a method description

```csharp
Task<double?> GetPrecision()
```

#### Example Usage:
```csharp

double? result = await responseTypes.GetPrecision();

```





### <a name="get_int_enum_array"></a>![Method: ](http://apidocs.io/img/method.png "Tester.PCL.Controllers.ResponseTypesController.GetIntEnumArray") GetIntEnumArray

> TODO: Add a method description

```csharp
Task<List<SuiteCode>> GetIntEnumArray()
```

#### Example Usage:
```csharp

List<SuiteCode> result = await responseTypes.GetIntEnumArray();

```





### <a name="get_int_enum"></a>![Method: ](http://apidocs.io/img/method.png "Tester.PCL.Controllers.ResponseTypesController.GetIntEnum") GetIntEnum

> TODO: Add a method description

```csharp
Task<SuiteCode?> GetIntEnum()
```

#### Example Usage:
```csharp

SuiteCode? result = await responseTypes.GetIntEnum();

```





### <a name="get_model_array"></a>![Method: ](http://apidocs.io/img/method.png "Tester.PCL.Controllers.ResponseTypesController.GetModelArray") GetModelArray

> TODO: Add a method description

```csharp
Task<List<Employee>> GetModelArray()
```

#### Example Usage:
```csharp

List<Employee> result = await responseTypes.GetModelArray();

```





### <a name="get_model"></a>![Method: ](http://apidocs.io/img/method.png "Tester.PCL.Controllers.ResponseTypesController.GetModel") GetModel

> TODO: Add a method description

```csharp
Task<Employee> GetModel()
```

#### Example Usage:
```csharp

Employee result = await responseTypes.GetModel();

```





### <a name="get_long"></a>![Method: ](http://apidocs.io/img/method.png "Tester.PCL.Controllers.ResponseTypesController.GetLong") GetLong

> TODO: Add a method description

```csharp
Task<long?> GetLong()
```

#### Example Usage:
```csharp

long? result = await responseTypes.GetLong();

```





### <a name="get_string_enum"></a>![Method: ](http://apidocs.io/img/method.png "Tester.PCL.Controllers.ResponseTypesController.GetStringEnum") GetStringEnum

> TODO: Add a method description

```csharp
Task<Days?> GetStringEnum()
```

#### Example Usage:
```csharp

Days? result = await responseTypes.GetStringEnum();

```





[Back to List of Controllers](#list_of_controllers)
## <a name="template_params_controller"></a>![Class: ](http://apidocs.io/img/class.png "Tester.PCL.Controllers.TemplateParamsController") TemplateParamsController

#### Get singleton instance
The singleton instance of the ``` TemplateParamsController ``` class can be accessed from the API Client.
```csharp
ITemplateParamsController templateParams = client.TemplateParams;
```

### <a name="send_integer_array"></a>![Method: ](http://apidocs.io/img/method.png "Tester.PCL.Controllers.TemplateParamsController.SendIntegerArray") SendIntegerArray

> TODO: Add a method description

```csharp
Task<EchoResponse> SendIntegerArray(List<int> integers)
```

#### Parameters: 

| Parameter | Tags | Description |
|-----------|------|-------------|
| integers |  ``` Required ```  ``` Collection ```  | TODO: Add a parameter description |



#### Example Usage:
```csharp
string integersValue = "[1,2,3,4,5]";
var integers = Newtonsoft.Json.JsonConvert.DeserializeObject<List<int>>(integersValue);

EchoResponse result = await templateParams.SendIntegerArray(integers);

```





### <a name="send_string_array"></a>![Method: ](http://apidocs.io/img/method.png "Tester.PCL.Controllers.TemplateParamsController.SendStringArray") SendStringArray

> TODO: Add a method description

```csharp
Task<EchoResponse> SendStringArray(List<string> strings)
```

#### Parameters: 

| Parameter | Tags | Description |
|-----------|------|-------------|
| strings |  ``` Required ```  ``` Collection ```  | TODO: Add a parameter description |



#### Example Usage:
```csharp
string stringsValue = "[\"abc\", \"def\"]";
var strings = Newtonsoft.Json.JsonConvert.DeserializeObject<List<string>>(stringsValue);

EchoResponse result = await templateParams.SendStringArray(strings);

```





[Back to List of Controllers](#list_of_controllers)
## <a name="query_param_controller"></a>![Class: ](http://apidocs.io/img/class.png "Tester.PCL.Controllers.QueryParamController") QueryParamController

#### Get singleton instance
The singleton instance of the ``` QueryParamController ``` class can be accessed from the API Client.
```csharp
IQueryParamController queryParam = client.QueryParam;
```

### <a name="integer_enum_array"></a>![Method: ](http://apidocs.io/img/method.png "Tester.PCL.Controllers.QueryParamController.IntegerEnumArray") IntegerEnumArray

> TODO: Add a method description

```csharp
Task<ServerResponse> IntegerEnumArray(List<SuiteCode> suites)
```

#### Parameters: 

| Parameter | Tags | Description |
|-----------|------|-------------|
| suites |  ``` Required ```  ``` Collection ```  | TODO: Add a parameter description |



#### Example Usage:
```csharp
string suitesValue = "[1, 3, 4, 2, 3]";
var suites = Newtonsoft.Json.JsonConvert.DeserializeObject<List<SuiteCode>>(suitesValue);

ServerResponse result = await queryParam.IntegerEnumArray(suites);

```





### <a name="string_enum_array"></a>![Method: ](http://apidocs.io/img/method.png "Tester.PCL.Controllers.QueryParamController.StringEnumArray") StringEnumArray

> TODO: Add a method description

```csharp
Task<ServerResponse> StringEnumArray(List<Days> days)
```

#### Parameters: 

| Parameter | Tags | Description |
|-----------|------|-------------|
| days |  ``` Required ```  ``` Collection ```  | TODO: Add a parameter description |



#### Example Usage:
```csharp
string daysValue = "[\"Tuesday\", \"Saturday\", \"Wednesday\", \"Monday\", \"Sunday\"]";
var days = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Days>>(daysValue);

ServerResponse result = await queryParam.StringEnumArray(days);

```





### <a name="string_array"></a>![Method: ](http://apidocs.io/img/method.png "Tester.PCL.Controllers.QueryParamController.StringArray") StringArray

> TODO: Add a method description

```csharp
Task<ServerResponse> StringArray(List<string> strings)
```

#### Parameters: 

| Parameter | Tags | Description |
|-----------|------|-------------|
| strings |  ``` Required ```  ``` Collection ```  | TODO: Add a parameter description |



#### Example Usage:
```csharp
string stringsValue = "[\"abc\", \"def\"]";
var strings = Newtonsoft.Json.JsonConvert.DeserializeObject<List<string>>(stringsValue);

ServerResponse result = await queryParam.StringArray(strings);

```





### <a name="number_array"></a>![Method: ](http://apidocs.io/img/method.png "Tester.PCL.Controllers.QueryParamController.NumberArray") NumberArray

> TODO: Add a method description

```csharp
Task<ServerResponse> NumberArray(List<int> integers)
```

#### Parameters: 

| Parameter | Tags | Description |
|-----------|------|-------------|
| integers |  ``` Required ```  ``` Collection ```  | TODO: Add a parameter description |



#### Example Usage:
```csharp
string integersValue = "[1,2,3,4,5]";
var integers = Newtonsoft.Json.JsonConvert.DeserializeObject<List<int>>(integersValue);

ServerResponse result = await queryParam.NumberArray(integers);

```





### <a name="multiple_params"></a>![Method: ](http://apidocs.io/img/method.png "Tester.PCL.Controllers.QueryParamController.MultipleParams") MultipleParams

> TODO: Add a method description

```csharp
Task<ServerResponse> MultipleParams(MultipleParamsInput input)
```

#### Parameters: 

| Parameter | Tags | Description |
|-----------|------|-------------|
| number |  ``` Required ```  | TODO: Add a parameter description |
| precision |  ``` Required ```  | TODO: Add a parameter description |
| mstring |  ``` Required ```  | TODO: Add a parameter description |
| url |  ``` Required ```  | TODO: Add a parameter description |



#### Example Usage:
```csharp
MultipleParamsInput collect = new MultipleParamsInput();

int number = 123412312;
collect.Number = number;

double precision = 1112.34;
collect.Precision = precision;

string mstring = "\"\"test./;\";12&&3asl\"\";\"qw1&34\"///..//.";
collect.Mstring = mstring;

string url = "http://www.abc.com/test?a=b&c=\"http://lolol.com?param=no&another=lol\"";
collect.Url = url;


ServerResponse result = await queryParam.MultipleParams(collect);

```





### <a name="url_param"></a>![Method: ](http://apidocs.io/img/method.png "Tester.PCL.Controllers.QueryParamController.UrlParam") UrlParam

> TODO: Add a method description

```csharp
Task<ServerResponse> UrlParam(string url)
```

#### Parameters: 

| Parameter | Tags | Description |
|-----------|------|-------------|
| url |  ``` Required ```  | TODO: Add a parameter description |



#### Example Usage:
```csharp
string url = "https://www.shahidisawesome.com/and/also/a/narcissist?thisis=aparameter&another=one";

ServerResponse result = await queryParam.UrlParam(url);

```





### <a name="no_params"></a>![Method: ](http://apidocs.io/img/method.png "Tester.PCL.Controllers.QueryParamController.NoParams") NoParams

> TODO: Add a method description

```csharp
Task<ServerResponse> NoParams()
```

#### Example Usage:
```csharp

ServerResponse result = await queryParam.NoParams();

```





### <a name="simple_query"></a>![Method: ](http://apidocs.io/img/method.png "Tester.PCL.Controllers.QueryParamController.SimpleQuery") SimpleQuery

> TODO: Add a method description

```csharp
Task<ServerResponse> SimpleQuery(SimpleQueryInput input, Dictionary<string, object> queryParameters = null)
```

#### Parameters: 

| Parameter | Tags | Description |
|-----------|------|-------------|
| boolean |  ``` Required ```  | TODO: Add a parameter description |
| number |  ``` Required ```  | TODO: Add a parameter description |
| mstring |  ``` Required ```  | TODO: Add a parameter description |
| queryParameters | ``` Optional ``` | Additional optional query parameters are supported by this method |



#### Example Usage:
```csharp
SimpleQueryInput collect = new SimpleQueryInput();

bool boolean = true;
collect.Boolean = boolean;

int number = 4;
collect.Number = number;

string mstring = "TestString";
collect.Mstring = mstring;

// key-value map for optional query parameters
var queryParams = new Dictionary<string, object>();


ServerResponse result = await queryParam.SimpleQuery(collect, queryParams, );

```





### <a name="string_param"></a>![Method: ](http://apidocs.io/img/method.png "Tester.PCL.Controllers.QueryParamController.StringParam") StringParam

> TODO: Add a method description

```csharp
Task<ServerResponse> StringParam(string mstring)
```

#### Parameters: 

| Parameter | Tags | Description |
|-----------|------|-------------|
| mstring |  ``` Required ```  | TODO: Add a parameter description |



#### Example Usage:
```csharp
string mstring = "l;asd;asdwe[2304&&;'.d??\\a\\\\\\;sd//";

ServerResponse result = await queryParam.StringParam(mstring);

```





[Back to List of Controllers](#list_of_controllers)
## <a name="form_params_controller"></a>![Class: ](http://apidocs.io/img/class.png "Tester.PCL.Controllers.FormParamsController") FormParamsController

#### Get singleton instance
The singleton instance of the ``` FormParamsController ``` class can be accessed from the API Client.
```csharp
IFormParamsController formParams = client.FormParams;
```

### <a name="send_string_enum_array"></a>![Method: ](http://apidocs.io/img/method.png "Tester.PCL.Controllers.FormParamsController.SendStringEnumArray") SendStringEnumArray

> TODO: Add a method description

```csharp
Task<ServerResponse> SendStringEnumArray(List<Days> days)
```

#### Parameters: 

| Parameter | Tags | Description |
|-----------|------|-------------|
| days |  ``` Required ```  ``` Collection ```  | TODO: Add a parameter description |



#### Example Usage:
```csharp
string daysValue = "[\"Tuesday\", \"Saturday\", \"Wednesday\", \"Monday\", \"Sunday\"]";
var days = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Days>>(daysValue);

ServerResponse result = await formParams.SendStringEnumArray(days);

```





### <a name="send_integer_enum_array"></a>![Method: ](http://apidocs.io/img/method.png "Tester.PCL.Controllers.FormParamsController.SendIntegerEnumArray") SendIntegerEnumArray

> TODO: Add a method description

```csharp
Task<ServerResponse> SendIntegerEnumArray(List<SuiteCode> suites)
```

#### Parameters: 

| Parameter | Tags | Description |
|-----------|------|-------------|
| suites |  ``` Required ```  ``` Collection ```  | TODO: Add a parameter description |



#### Example Usage:
```csharp
string suitesValue = "[1, 3, 4, 2, 3]";
var suites = Newtonsoft.Json.JsonConvert.DeserializeObject<List<SuiteCode>>(suitesValue);

ServerResponse result = await formParams.SendIntegerEnumArray(suites);

```





### <a name="send_mixed_array"></a>![Method: ](http://apidocs.io/img/method.png "Tester.PCL.Controllers.FormParamsController.SendMixedArray") SendMixedArray

> Send a variety for form params. Returns file count and body params

```csharp
Task<ServerResponse> SendMixedArray(SendMixedArrayInput input)
```

#### Parameters: 

| Parameter | Tags | Description |
|-----------|------|-------------|
| file |  ``` Required ```  | TODO: Add a parameter description |
| integers |  ``` Required ```  ``` Collection ```  | TODO: Add a parameter description |
| models |  ``` Required ```  ``` Collection ```  | TODO: Add a parameter description |
| strings |  ``` Required ```  ``` Collection ```  | TODO: Add a parameter description |



#### Example Usage:
```csharp
SendMixedArrayInput collect = new SendMixedArrayInput();

FileStreamInfo file = new FileStreamInfo(new FileStream(@"pathToFile",FileMode.Open));
collect.File = file;

string integersValue = "[1,2,3,4,5]";
var integers = Newtonsoft.Json.JsonConvert.DeserializeObject<List<int>>(integersValue);
collect.Integers = integers;

string modelsValue = "[{\"name\":\"Shahid Khaliq\",\"age\":5147483645,\"address\":\"H # 531, S # 20\",\"uid\":\"123321\",\"salary\":20000,\"department\":\"Software Development\",\"joiningDay\":\"Saturday\",\"workingDays\":[\"Monday\",\"Tuesday\",\"Friday\"],\"boss\":{\"name\":\"Zeeshan Ejaz\",\"age\":5147483647,\"address\":\"I-9/1\",\"uid\":\"241123\"},\"dependents\":[{\"name\":\"Future Wife\",\"age\":5147483649,\"address\":\"H # 531, S # 20\",\"uid\":\"123412\"},{\"name\":\"Future Kid\",\"age\":5147483648,\"address\":\"H # 531, S # 20\",\"uid\":\"312341\"}]}, {\"name\":\"Shahid Khaliq\",\"age\":5147483645,\"address\":\"H # 531, S # 20\",\"uid\":\"123321\",\"salary\":20000,\"department\":\"Software Development\",\"joiningDay\":\"Saturday\",\"workingDays\":[\"Monday\",\"Tuesday\",\"Friday\"],\"boss\":{\"name\":\"Zeeshan Ejaz\",\"age\":5147483647,\"address\":\"I-9/1\",\"uid\":\"241123\"},\"dependents\":[{\"name\":\"Future Wife\",\"age\":5147483649,\"address\":\"H # 531, S # 20\",\"uid\":\"123412\"},{\"name\":\"Future Kid\",\"age\":5147483648,\"address\":\"H # 531, S # 20\",\"uid\":\"312341\"}]}]";
var models = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Employee>>(modelsValue);
collect.Models = models;

string stringsValue = "[\"abc\", \"def\"]";
var strings = Newtonsoft.Json.JsonConvert.DeserializeObject<List<string>>(stringsValue);
collect.Strings = strings;


ServerResponse result = await formParams.SendMixedArray(collect);

```





### <a name="send_string"></a>![Method: ](http://apidocs.io/img/method.png "Tester.PCL.Controllers.FormParamsController.SendString") SendString

> TODO: Add a method description

```csharp
Task<ServerResponse> SendString(string mvalue)
```

#### Parameters: 

| Parameter | Tags | Description |
|-----------|------|-------------|
| mvalue |  ``` Required ```  | TODO: Add a parameter description |



#### Example Usage:
```csharp
string mvalue = "TestString";

ServerResponse result = await formParams.SendString(mvalue);

```





### <a name="send_file"></a>![Method: ](http://apidocs.io/img/method.png "Tester.PCL.Controllers.FormParamsController.SendFile") SendFile

> TODO: Add a method description

```csharp
Task<ServerResponse> SendFile(FileStreamInfo file)
```

#### Parameters: 

| Parameter | Tags | Description |
|-----------|------|-------------|
| file |  ``` Required ```  | TODO: Add a parameter description |



#### Example Usage:
```csharp
FileStreamInfo file = new FileStreamInfo(new FileStream(@"pathToFile",FileMode.Open));

ServerResponse result = await formParams.SendFile(file);

```





### <a name="send_model_array"></a>![Method: ](http://apidocs.io/img/method.png "Tester.PCL.Controllers.FormParamsController.SendModelArray") SendModelArray

> TODO: Add a method description

```csharp
Task<ServerResponse> SendModelArray(List<Employee> models)
```

#### Parameters: 

| Parameter | Tags | Description |
|-----------|------|-------------|
| models |  ``` Required ```  ``` Collection ```  | TODO: Add a parameter description |



#### Example Usage:
```csharp
string modelsValue = "[{\"name\":\"Shahid Khaliq\",\"age\":5147483645,\"address\":\"H # 531, S # 20\",\"uid\":\"123321\",\"salary\":20000,\"department\":\"Software Development\",\"joiningDay\":\"Saturday\",\"workingDays\":[\"Monday\",\"Tuesday\",\"Friday\"],\"boss\":{\"name\":\"Zeeshan Ejaz\",\"age\":5147483647,\"address\":\"I-9/1\",\"uid\":\"241123\"},\"dependents\":[{\"name\":\"Future Wife\",\"age\":5147483649,\"address\":\"H # 531, S # 20\",\"uid\":\"123412\"},{\"name\":\"Future Kid\",\"age\":5147483648,\"address\":\"H # 531, S # 20\",\"uid\":\"312341\"}]}, {\"name\":\"Shahid Khaliq\",\"age\":5147483645,\"address\":\"H # 531, S # 20\",\"uid\":\"123321\",\"salary\":20000,\"department\":\"Software Development\",\"joiningDay\":\"Saturday\",\"workingDays\":[\"Monday\",\"Tuesday\",\"Friday\"],\"boss\":{\"name\":\"Zeeshan Ejaz\",\"age\":5147483647,\"address\":\"I-9/1\",\"uid\":\"241123\"},\"dependents\":[{\"name\":\"Future Wife\",\"age\":5147483649,\"address\":\"H # 531, S # 20\",\"uid\":\"123412\"},{\"name\":\"Future Kid\",\"age\":5147483648,\"address\":\"H # 531, S # 20\",\"uid\":\"312341\"}]}]";
var models = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Employee>>(modelsValue);

ServerResponse result = await formParams.SendModelArray(models);

```





### <a name="send_model"></a>![Method: ](http://apidocs.io/img/method.png "Tester.PCL.Controllers.FormParamsController.SendModel") SendModel

> TODO: Add a method description

```csharp
Task<ServerResponse> SendModel(Employee model)
```

#### Parameters: 

| Parameter | Tags | Description |
|-----------|------|-------------|
| model |  ``` Required ```  | TODO: Add a parameter description |



#### Example Usage:
```csharp
string modelValue = "{\"name\":\"Shahid Khaliq\",\"age\":5147483645,\"address\":\"H # 531, S # 20\",\"uid\":\"123321\",\"salary\":20000,\"department\":\"Software Development\",\"joiningDay\":\"Saturday\",\"workingDays\":[\"Monday\",\"Tuesday\",\"Friday\"],\"boss\":{\"name\":\"Zeeshan Ejaz\",\"age\":5147483647,\"address\":\"I-9/1\",\"uid\":\"241123\"},\"dependents\":[{\"name\":\"Future Wife\",\"age\":5147483649,\"address\":\"H # 531, S # 20\",\"uid\":\"123412\"},{\"name\":\"Future Kid\",\"age\":5147483648,\"address\":\"H # 531, S # 20\",\"uid\":\"312341\"}]}";
var model = Newtonsoft.Json.JsonConvert.DeserializeObject<Employee>(modelValue);

ServerResponse result = await formParams.SendModel(model);

```





### <a name="send_string_array"></a>![Method: ](http://apidocs.io/img/method.png "Tester.PCL.Controllers.FormParamsController.SendStringArray") SendStringArray

> TODO: Add a method description

```csharp
Task<ServerResponse> SendStringArray(List<string> strings)
```

#### Parameters: 

| Parameter | Tags | Description |
|-----------|------|-------------|
| strings |  ``` Required ```  ``` Collection ```  | TODO: Add a parameter description |



#### Example Usage:
```csharp
string stringsValue = "[\"abc\", \"def\"]";
var strings = Newtonsoft.Json.JsonConvert.DeserializeObject<List<string>>(stringsValue);

ServerResponse result = await formParams.SendStringArray(strings);

```





### <a name="send_integer_array"></a>![Method: ](http://apidocs.io/img/method.png "Tester.PCL.Controllers.FormParamsController.SendIntegerArray") SendIntegerArray

> TODO: Add a method description

```csharp
Task<ServerResponse> SendIntegerArray(List<int> integers)
```

#### Parameters: 

| Parameter | Tags | Description |
|-----------|------|-------------|
| integers |  ``` Required ```  ``` Collection ```  | TODO: Add a parameter description |



#### Example Usage:
```csharp
string integersValue = "[1,2,3,4,5]";
var integers = Newtonsoft.Json.JsonConvert.DeserializeObject<List<int>>(integersValue);

ServerResponse result = await formParams.SendIntegerArray(integers);

```





### <a name="send_long"></a>![Method: ](http://apidocs.io/img/method.png "Tester.PCL.Controllers.FormParamsController.SendLong") SendLong

> TODO: Add a method description

```csharp
Task<ServerResponse> SendLong(long mvalue)
```

#### Parameters: 

| Parameter | Tags | Description |
|-----------|------|-------------|
| mvalue |  ``` Required ```  | TODO: Add a parameter description |



#### Example Usage:
```csharp
long mvalue = 5147483647L;

ServerResponse result = await formParams.SendLong(mvalue);

```





[Back to List of Controllers](#list_of_controllers)
## <a name="body_params_controller"></a>![Class: ](http://apidocs.io/img/class.png "Tester.PCL.Controllers.BodyParamsController") BodyParamsController

#### Get singleton instance
The singleton instance of the ``` BodyParamsController ``` class can be accessed from the API Client.
```csharp
IBodyParamsController bodyParams = client.BodyParams;
```

### <a name="send_integer_enum_array"></a>![Method: ](http://apidocs.io/img/method.png "Tester.PCL.Controllers.BodyParamsController.SendIntegerEnumArray") SendIntegerEnumArray

> TODO: Add a method description

```csharp
Task<ServerResponse> SendIntegerEnumArray(List<SuiteCode> suites)
```

#### Parameters: 

| Parameter | Tags | Description |
|-----------|------|-------------|
| suites |  ``` Required ```  ``` Collection ```  | TODO: Add a parameter description |



#### Example Usage:
```csharp
string suitesValue = "[1, 3, 4, 2, 3]";
var suites = Newtonsoft.Json.JsonConvert.DeserializeObject<List<SuiteCode>>(suitesValue);

ServerResponse result = await bodyParams.SendIntegerEnumArray(suites);

```





### <a name="send_string_enum_array"></a>![Method: ](http://apidocs.io/img/method.png "Tester.PCL.Controllers.BodyParamsController.SendStringEnumArray") SendStringEnumArray

> TODO: Add a method description

```csharp
Task<ServerResponse> SendStringEnumArray(List<Days> days)
```

#### Parameters: 

| Parameter | Tags | Description |
|-----------|------|-------------|
| days |  ``` Required ```  ``` Collection ```  | TODO: Add a parameter description |



#### Example Usage:
```csharp
string daysValue = "[\"Tuesday\", \"Saturday\", \"Wednesday\", \"Monday\", \"Sunday\"]";
var days = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Days>>(daysValue);

ServerResponse result = await bodyParams.SendStringEnumArray(days);

```





### <a name="send_string"></a>![Method: ](http://apidocs.io/img/method.png "Tester.PCL.Controllers.BodyParamsController.SendString") SendString

> TODO: Add a method description

```csharp
Task<ServerResponse> SendString(string mvalue)
```

#### Parameters: 

| Parameter | Tags | Description |
|-----------|------|-------------|
| mvalue |  ``` Required ```  | TODO: Add a parameter description |



#### Example Usage:
```csharp
string mvalue = "TestString";

ServerResponse result = await bodyParams.SendString(mvalue);

```





### <a name="send_dynamic"></a>![Method: ](http://apidocs.io/img/method.png "Tester.PCL.Controllers.BodyParamsController.SendDynamic") SendDynamic

> TODO: Add a method description

```csharp
Task<ServerResponse> SendDynamic(object mdynamic)
```

#### Parameters: 

| Parameter | Tags | Description |
|-----------|------|-------------|
| mdynamic |  ``` Required ```  | TODO: Add a parameter description |



#### Example Usage:
```csharp
string mdynamicValue = "{\"uid\": \"1123213\", \"name\": \"Shahid\"}";
var mdynamic = Newtonsoft.Json.JsonConvert.DeserializeObject(mdynamicValue);

ServerResponse result = await bodyParams.SendDynamic(mdynamic);

```





### <a name="send_model_array"></a>![Method: ](http://apidocs.io/img/method.png "Tester.PCL.Controllers.BodyParamsController.SendModelArray") SendModelArray

> TODO: Add a method description

```csharp
Task<ServerResponse> SendModelArray(List<Employee> models)
```

#### Parameters: 

| Parameter | Tags | Description |
|-----------|------|-------------|
| models |  ``` Required ```  ``` Collection ```  | TODO: Add a parameter description |



#### Example Usage:
```csharp
string modelsValue = "[{\"name\":\"Shahid Khaliq\",\"age\":5147483645,\"address\":\"H # 531, S # 20\",\"uid\":\"123321\",\"salary\":20000,\"department\":\"Software Development\",\"joiningDay\":\"Saturday\",\"workingDays\":[\"Monday\",\"Tuesday\",\"Friday\"],\"boss\":{\"name\":\"Zeeshan Ejaz\",\"age\":5147483647,\"address\":\"I-9/1\",\"uid\":\"241123\"},\"dependents\":[{\"name\":\"Future Wife\",\"age\":5147483649,\"address\":\"H # 531, S # 20\",\"uid\":\"123412\"},{\"name\":\"Future Kid\",\"age\":5147483648,\"address\":\"H # 531, S # 20\",\"uid\":\"312341\"}]}, {\"name\":\"Shahid Khaliq\",\"age\":5147483645,\"address\":\"H # 531, S # 20\",\"uid\":\"123321\",\"salary\":20000,\"department\":\"Software Development\",\"joiningDay\":\"Saturday\",\"workingDays\":[\"Monday\",\"Tuesday\",\"Friday\"],\"boss\":{\"name\":\"Zeeshan Ejaz\",\"age\":5147483647,\"address\":\"I-9/1\",\"uid\":\"241123\"},\"dependents\":[{\"name\":\"Future Wife\",\"age\":5147483649,\"address\":\"H # 531, S # 20\",\"uid\":\"123412\"},{\"name\":\"Future Kid\",\"age\":5147483648,\"address\":\"H # 531, S # 20\",\"uid\":\"312341\"}]}]";
var models = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Employee>>(modelsValue);

ServerResponse result = await bodyParams.SendModelArray(models);

```





### <a name="send_model"></a>![Method: ](http://apidocs.io/img/method.png "Tester.PCL.Controllers.BodyParamsController.SendModel") SendModel

> TODO: Add a method description

```csharp
Task<ServerResponse> SendModel(Employee model)
```

#### Parameters: 

| Parameter | Tags | Description |
|-----------|------|-------------|
| model |  ``` Required ```  | TODO: Add a parameter description |



#### Example Usage:
```csharp
string modelValue = "{\"name\":\"Shahid Khaliq\",\"age\":5147483645,\"address\":\"H # 531, S # 20\",\"uid\":\"123321\",\"salary\":20000,\"department\":\"Software Development\",\"joiningDay\":\"Saturday\",\"workingDays\":[\"Monday\",\"Tuesday\",\"Friday\"],\"boss\":{\"name\":\"Zeeshan Ejaz\",\"age\":5147483647,\"address\":\"I-9/1\",\"uid\":\"241123\"},\"dependents\":[{\"name\":\"Future Wife\",\"age\":5147483649,\"address\":\"H # 531, S # 20\",\"uid\":\"123412\"},{\"name\":\"Future Kid\",\"age\":5147483648,\"address\":\"H # 531, S # 20\",\"uid\":\"312341\"}]}";
var model = Newtonsoft.Json.JsonConvert.DeserializeObject<Employee>(modelValue);

ServerResponse result = await bodyParams.SendModel(model);

```





### <a name="send_integer_array"></a>![Method: ](http://apidocs.io/img/method.png "Tester.PCL.Controllers.BodyParamsController.SendIntegerArray") SendIntegerArray

> TODO: Add a method description

```csharp
Task<ServerResponse> SendIntegerArray(List<int> integers)
```

#### Parameters: 

| Parameter | Tags | Description |
|-----------|------|-------------|
| integers |  ``` Required ```  ``` Collection ```  | TODO: Add a parameter description |



#### Example Usage:
```csharp
string integersValue = "[1,2,3,4,5]";
var integers = Newtonsoft.Json.JsonConvert.DeserializeObject<List<int>>(integersValue);

ServerResponse result = await bodyParams.SendIntegerArray(integers);

```





### <a name="send_string_array"></a>![Method: ](http://apidocs.io/img/method.png "Tester.PCL.Controllers.BodyParamsController.SendStringArray") SendStringArray

> sends a string body param

```csharp
Task<ServerResponse> SendStringArray(List<string> sarray)
```

#### Parameters: 

| Parameter | Tags | Description |
|-----------|------|-------------|
| sarray |  ``` Required ```  ``` Collection ```  | TODO: Add a parameter description |



#### Example Usage:
```csharp
string sarrayValue = "[\"abc\", \"def\"]";
var sarray = Newtonsoft.Json.JsonConvert.DeserializeObject<List<string>>(sarrayValue);

ServerResponse result = await bodyParams.SendStringArray(sarray);

```





[Back to List of Controllers](#list_of_controllers)
## <a name="echo_controller"></a>![Class: ](http://apidocs.io/img/class.png "Tester.PCL.Controllers.EchoController") EchoController

#### Get singleton instance
The singleton instance of the ``` EchoController ``` class can be accessed from the API Client.
```csharp
IEchoController echo = client.Echo;
```

### <a name="query_echo"></a>![Method: ](http://apidocs.io/img/method.png "Tester.PCL.Controllers.EchoController.QueryEcho") QueryEcho

> TODO: Add a method description

```csharp
Task<EchoResponse> QueryEcho(Dictionary<string, object> queryParameters = null)
```

#### Parameters: 

| Parameter | Tags | Description |
|-----------|------|-------------|
| queryParameters | ``` Optional ``` | Additional optional query parameters are supported by this method |



#### Example Usage:
```csharp
// key-value map for optional query parameters
var queryParams = new Dictionary<string, object>();


EchoResponse result = await echo.QueryEcho(queryParams);

```





### <a name="form_echo"></a>![Method: ](http://apidocs.io/img/method.png "Tester.PCL.Controllers.EchoController.FormEcho") FormEcho

> Sends the request including any form params as JSON

```csharp
Task<dynamic> FormEcho(object input)
```

#### Parameters: 

| Parameter | Tags | Description |
|-----------|------|-------------|
| input |  ``` Required ```  | TODO: Add a parameter description |



#### Example Usage:
```csharp
string inputValue = "{\"uid\": \"1123213\", \"name\": \"Shahid\"}";
var input = Newtonsoft.Json.JsonConvert.DeserializeObject(inputValue);

dynamic result = await echo.FormEcho(input);

```





### <a name="json_echo"></a>![Method: ](http://apidocs.io/img/method.png "Tester.PCL.Controllers.EchoController.JsonEcho") JsonEcho

> Echo's back the request

```csharp
Task<dynamic> JsonEcho(object input)
```

#### Parameters: 

| Parameter | Tags | Description |
|-----------|------|-------------|
| input |  ``` Required ```  | TODO: Add a parameter description |



#### Example Usage:
```csharp
string inputValue = "{\"uid\": \"1123213\", \"name\": \"Shahid\"}";
var input = Newtonsoft.Json.JsonConvert.DeserializeObject(inputValue);

dynamic result = await echo.JsonEcho(input);

```





[Back to List of Controllers](#list_of_controllers)
## <a name="header_controller"></a>![Class: ](http://apidocs.io/img/class.png "Tester.PCL.Controllers.HeaderController") HeaderController

#### Get singleton instance
The singleton instance of the ``` HeaderController ``` class can be accessed from the API Client.
```csharp
IHeaderController header = client.Header;
```

### <a name="send_headers"></a>![Method: ](http://apidocs.io/img/method.png "Tester.PCL.Controllers.HeaderController.SendHeaders") SendHeaders

> Sends a single header params

```csharp
Task<ServerResponse> SendHeaders(SendHeadersInput input)
```

#### Parameters: 

| Parameter | Tags | Description |
|-----------|------|-------------|
| customHeader |  ``` Required ```  | TODO: Add a parameter description |
| mvalue |  ``` Required ```  | Represents the value of the custom header |



#### Example Usage:
```csharp
SendHeadersInput collect = new SendHeadersInput();

string customHeader = "TestString";
collect.CustomHeader = customHeader;

string mvalue = "TestString";
collect.Mvalue = mvalue;


ServerResponse result = await header.SendHeaders(collect);

```





[Back to List of Controllers](#list_of_controllers)
## <a name="error_codes_controller"></a>![Class: ](http://apidocs.io/img/class.png "Tester.PCL.Controllers.ErrorCodesController") ErrorCodesController

#### Get singleton instance
The singleton instance of the ``` ErrorCodesController ``` class can be accessed from the API Client.
```csharp
IErrorCodesController errorCodes = client.ErrorCodes;
```

### <a name="get500"></a>![Method: ](http://apidocs.io/img/method.png "Tester.PCL.Controllers.ErrorCodesController.Get500") Get500

> TODO: Add a method description

```csharp
Task<dynamic> Get500()
```

#### Example Usage:
```csharp

dynamic result = await errorCodes.Get500();

```





### <a name="get400"></a>![Method: ](http://apidocs.io/img/method.png "Tester.PCL.Controllers.ErrorCodesController.Get400") Get400

> TODO: Add a method description

```csharp
Task<dynamic> Get400()
```

#### Example Usage:
```csharp

dynamic result = await errorCodes.Get400();

```





[Back to List of Controllers](#list_of_controllers)


