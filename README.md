# .NET SDK for 4me GraphQL
A .NET client for accessing the [4me GraphQL API](https://developer.4me.com/graphql/).

## Licensing
The SDK uses the [Newtonsoft.Json framework](https://github.com/JamesNK/Newtonsoft.Json) NuGet Package, which is a high-performance JSON framework for .NET and available under [MIT licensing](https://github.com/JamesNK/Newtonsoft.Json/blob/master/LICENSE.md).

# Introduction
The .NET SDK simplifies the process of interacting with the 4me GraphQL API, allowing you to take full advantage of its query and mutation capabilities with ease.
It abstracts away the complex task of managing low-level details such as sending requests, parsing responses, filtering and pagination, making it simple to integrate 4me GraphQL API into your .NET applications and fully leverage its functionalities.

For a general introduction to the GraphQL query language please see [graphql.org](https://graphql.org/), and for a 4me specific introduction see [4me GraphQL Training](https://learning.4me.com/integrations_graphql/).

## Client
The `Sdk4meClient` class provides access to all the necessary methods for querying and modifying data. With the `Get` and `Mutation` methods, there are four properties that allow for default behavior customization.
- The `EnumeratorTolerantSerializer` property, when set to true, allows for ignoring unmappable enumerator values and instead returns null or a default value.
- The `DefaultItemsPerRequest` property sets the number of items per connection request, with a default and maximum value of 100.
- The `MaximumRecursiveRequests` property controls the number of recursive requests that the client can make when pagination occurs in the top level query. The default value is 10.
- The `MaximumQueryDepthLevelConnections` property controls the depth of nested queries. While it is possible to increase this limit, it can negatively affect performance. The default value is 2.

## Authentication
The SDK supports both Personal Access Token and OAuth 2.0 Client Credential Grant authentication methods. It automatically renews the token 1 minute before it expires when using OAuth 2.0 Client Credential Grant.

## Querying
The SDK provides a simple and intuitive way to write queries, allowing you to easily retrieve the data you need.
The query interface also enables you to write nested queries, which can generate GraphQL connections, making it simple to work with related data.
You can easily execute complex queries and retrieve data with minimal effort, making it simple to build efficient and performant applications that leverage the full capabilities of the 4me GraphQL API.

### Filtering
You can easily apply filters on root connections when creating a query, making it simple to retrieve specific data.
This feature allows you to limit the results returned by the query by adding conditions to the fields you are querying.
This way you can filter the results based on specific values or ranges, making it easy to find the data you need.   

### Views
In addition to the filtering capabilities, the SDK also allows you to specify the scope of your query by using the view argument on the root connections.
The view argument allows you to target a specific set of data. By default, it is set to the current account, but it can also be used to query all accounts or another predefined subset of data for that specific data entity. 

### Pagination
The SDK takes care of pagination for you. The maximum number of items returned per connection is 100.
If your query returns more than 100 items on a connection, it will automatically retrieve the next 100 items without the need to write a new query, thus making it easy to work with large datasets.

### Date and time exceptions
The 4me GraphQL API has a data type called `ISO8601Timestamp` which includes three non-datetime values: `best_effort`, `no_target`, and `clock_stopped` that cannot be converted to a standard date and time format. To handle these values, the API's SDK includes a custom `JsonConverter` that converts the exception values to specific date and time values:
- `best_effort` is converted to the date and time value of 0001-01-01 01:01:01.111
- `no_target` is converted to 0002-02-02 02:02:02.222
- `clock_stopped` is converted to 0003-03-03 03:03:03.333

These specific values can be accessed through the `DateTimeValue` class.

## Mutations
Mutations are used to create, update, or delete data. Like queries, the SDK provides a simple and intuitive way to perform mutations.

## Attachments
The SDK features an `UploadAttachment` method for easily uploading attachments, which can later be associated with any create or update mutation.
The response from this request includes information necessary for linking these attachments.

## Multi-token support
The client allows for the use of multiple authentication tokens. A single token is limited to 3600 API requests per hour or 5000 points per hour for Query Cost. In some situations, this may not be sufficient.
When there are multiple tokens in use, the client will always select the token with the most remaining requests to use. More information about [Rate Limiting](https://developer.4me.com/graphql/#request-rate-limits) and [Query Cost Limits](https://developer.4me.com/graphql/#query-cost-limit) can be found on the [4me developer website](https://developer.4me.com/graphql).

## Response timing
The 4me GraphQL API limits the number of requests to 20 per 2 seconds. The SDK will keep track of the response time and lock the process to make sure it takes at least 100 milliseconds per request.

## Trace capabilities
The [Trace class](https://learn.microsoft.com/en-us/dotnet/api/system.diagnostics.trace) is used to produce detailed information about the GraphQL query or mutation.
The detailed information includes the HTTP verb, the URL and the content. [Trace Listeners](https://learn.microsoft.com/en-us/dotnet/framework/debug-trace-profile/trace-listeners) can be used to gather detailed information that can be helpful for debugging during release or for auditing purposes.

# Examples

### Minimum example
```csharp
using Sdk4me.GraphQL;

AuthenticationToken token = new AuthenticationToken("clientID", "clientSecret");
Sdk4meClient client = new(token, "account-name", EnvironmentType.Production, EnvironmentRegion.EU);
Person me = client.Me().Result;
Console.WriteLine($"{me.Name} ({me.PrimaryEmail})");
```

### Queries

#### Get people
```csharp
DataList<Person> people = await client.Get(Query.Person);
foreach (Person person in people)
{   
}
```

##### Specific fields
```csharp
DataList<Person> people = await client.Get(Query.Person
    .Select(PersonField.ID, PersonField.Name, PersonField.CustomFields));
```

##### All fields
```csharp
DataList<Person> people = await client.Get(Query.Person.SelectAll());
```

`SelectAll()` should only be used for debugging purposes as it may include fields that are not yet available in production and can negatively impact performance.
It's recommended to only select the necessary fields.

#### Get all people in the Directory and Support Domain accounts
```csharp
DataList<Person> people = await client.Get(Query.Person.View(PeronsView.All));
```
A views can only be used on the top level query.

#### Nested queries and items per request
```csharp
IQuery query = Query.Person
    .Select(PersonField.ID, PersonField.Name)
    .ItemsPerRequest(10)
    .SelectTeams(Query.Team)
    .SelectSkillPools(Query.SkillPool
        .SelectMembers(Query.Person
            .SelectConfigurationItems(Query.ConfigurationItem
                .Select(ConfigurationItemField.ID, ConfigurationItemField.Label, ConfigurationItemField.Name))));

client.MaximumQueryDepthLevelConnections = 4;
DataList<Person> people = await client.Get(query);
```

The default, and maximum, number of items per connection is 100, the maximum number of items that can be returned in a single request with multiple connections is limited to 500,000.
When querying nested data, such as 100 people with 100 skill pools and 100 members each, the total number of items (100 x 100 x 100) exceeds the maximum of 500,000.
Therefore, specifying the number of items per request is important to avoid exceeding this limit.

The default maximum depth for nested queries is 2. While it is possible to increase this limit, doing so can affect performance when pagination applies on the `Members` their `ConfigurationItems`.

```csharp
client.MaximumQueryDepthLevelConnections = 5;
```

#### Filtering
```csharp
IQuery query = Query.Person.Filter(PersonField.Name, FilterOperator.Equals, "Howard");
```
Filters can only be used on the top level query.

#### Sorting
```csharp
IQuery query = Query.Person.OrderBy(PersonOrderField.Name, OrderBySortOrder.Ascending);
```
Sorting can only be used on the top level query.

### Example

```csharp
PersonQuery query = new PersonQuery()
    .View(PersonView.All)
    .OrderBy(PersonOrderField.Vip, OrderBySortOrder.Descending)
    .Filter(PersonField.CreatedAt, FilterOperator.GreaterThanOrEqualsTo, new DateTime(2020, 1, 1))
    .SelectContacts(new ContactQuery()
        .SelectAll())
    .SelectPermissions(new PermissionQuery()
        .ItemsPerRequest(10)
        .Select(PermissionField.Account, PermissionField.Roles))
    .SelectTeams(new TeamQuery()
        .ItemsPerRequest(10)
        .SelectMembers(new PersonQuery()
            .ItemsPerRequest(50)
            .Select(PersonField.Name)))
    .SelectConfigurationItems(new ConfigurationItemQuery()
        .Select(ConfigurationItemField.Label)
        .ItemsPerRequest(10)
        .SelectRequests(new RequestQuery()
            .ItemsPerRequest(10)
            .Select(RequestField.Subject, RequestField.Supplier)));

DataList<Person> people = client.Get(query).Result;
```

### Mutations

#### Create a new person
```csharp
CustomFieldCollection customFields = new();
customFields.AddOrUpdate("internal_reference", "an internal reference");

PersonCreateInput input = new() {
    Name = "James",
    PrimaryEmail = "james@company.com",
    Disabled= true,
    CustomFields = customFields,
    EmployeeID = "123",
    TeamIds = new() { "NG1lLnFhL1RlYW0vMjA1MTQ", "NG1lLnFhL1RlYW0vMjA1MGv" },
    Source = "Sdk4me",
    TimeFormat24h = true,
    TimeZone = "Brussels",
    DoNotTranslateLanguages = new() { "en", "nl" }
};

PersonCreatePayload result = await client.Mutation(input, false);
if (result.IsError())
{
    Debug.WriteLine(result.Errors.ToString());
    return;
}

Person newPerson = result.Person;
```

#### Updating an existing person
```csharp
try
{
    PersonUpdatePayload result = await client.Mutation(new PersonUpdateInput
    {
        ID = "NG1lLnFhL1blcnNvbi8yMjMxSjIx",
        Name = "Jimmy",
        PrimaryEmail = "jimmy@company.com",
    }, true);

    Person updatedPerson = result.Person;
}
catch (Sdk4meException ex)
{
    Debug.WriteLine(ex.Message);
}
```

#### Updating the custom fields of an existing person
```csharp
Person person = client.Get(
    new PersonQuery()
        .Select(PersonField.CustomFields)
        .Filter(PersonField.ID, FilterOperator.Equals, "NG1lLnFhL1blcnNvbi8yMjMxSjIx")
    ).Result.First();

person.CustomFields.AddOrUpdate("internal_reference", "none");

PersonUpdatePayload result = client.Mutation(new PersonUpdateInput()
{
    ID = person.ID,
    CustomFields = person.CustomFields
}).Result;
```

### Attachments

#### Upload an attachment
```csharp
var request = client.Get(new RequestQuery()
    .Select(RequestField.ID)
    .Filter("requestId", FilterOperator.Equals, "123")
    ).Result.First();

var response = client.UploadAttachment(@".\HelloWorld.txt", "text/plain").Result;
var updatedRequest = client.Mutation(new RequestUpdateInput()
{
    ID = request.ID,
    Note = "Please review the attached document",
    NoteAttachments = new List<AttachmentInput>
    {
        new AttachmentInput
        {
            Key = response.Key, 
            Size = response.Size,
            Inline = false
        } 
    }
}).Result;
```

#### Upload an inline attachment
```csharp
var request = client.Get(new RequestQuery()
    .Select(RequestField.ID)
    .Filter("requestId", FilterOperator.Equals, "123")
    ).Result.First();

var attachment = client.UploadAttachment(@".\image.png", "image/png").Result;
var updatedRequest = client.Mutation(new RequestUpdateInput()
{
    ID = request.ID,
    Note = $"This is an embedded image.\n![]({attachment.Key})",
    NoteAttachments = new List<AttachmentInput>
    {
        new AttachmentInput
        {
            Key = attachment.Key, 
            Size = attachment.Size,
            Inline = true
        } 
    }
}).Result;
```

### Exception handling
```csharp
try
{
    var result = client.Mutation(new PersonUpdateInput()
    {
        ID = person.ID,
        CustomFields = person.CustomFields
    }, false).Result;

    Console.WriteLine(result.Errors.First());
}
catch (Sdk4meException ex)
{
    Console.WriteLine(ex.Message);
}
```
By default the SDK will throw an new exception. The mutation method has one additional argument `throwOnError`, when false the `result` property will contain the error messages.

### Multi-token, accounts, environment usage and environment regions
```csharp
AuthenticationTokenCollection tokens = new AuthenticationTokenCollection()
{
    new AuthenticationToken("OAuth 2.0 Client Credential Client ID", "OAuth 2.0 Client Credential Client Secret"),
    new AuthenticationToken("A personal access token")
};

Sdk4meClient client = new(token, "account-name", EnvironmentType.Demo, EnvironmentRegion.EU);
client.AccountID = "new-account-name";
```