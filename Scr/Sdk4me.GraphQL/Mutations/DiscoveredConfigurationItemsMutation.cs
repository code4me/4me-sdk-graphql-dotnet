namespace Sdk4me.GraphQL
{
    /// <summary>
    /// <br>This mutation can be used to push at most 100 discovered configuration items to 4me at once.</br>
    /// <br>A more extensive description of this functionality can be found on the</br>
    /// <br><see href="https://developer.4me.com/v1/import/discovery_tools/#using-graphql">Discovery Tools page of the developer documentation</see>.</br>
    /// <br></br>
    /// <br>The query will be executed in the background. Typically the following fields should be queried:</br>
    /// <code>
    /// asyncQuery { resultUrl errorCount }
    /// configurationItems { id sourceID }
    /// </code>
    /// <br>On initial submission the <c>configurationItems</c> field will be <c>null</c>.</br>
    /// <br>The <c>resultUrl</c> contains an expiring link to the location where the resulting JSON is available</br>
    /// <br>once the query has been executed.</br>
    /// <br>It is possible to poll the link every couple of seconds to check whether the query is completed.</br>
    /// <br>Initially the link will point to an empty JSON document (<c>{}</c>), once the query is completed it will contain</br>
    /// <br>the JSON result of this mutation.</br>
    /// <br>In the result both the <c>asyncQuery</c> and <c>configurationItems</c> fields as requested on submission are present.</br>
    /// <br>The <c>errorCount</c> can for example be used to see whether processing was successful (then it is <c>0</c>).</br>
    /// </summary>
    internal class DiscoveredConfigurationItemsMutation : Mutation<DiscoveredConfigurationItemsPayload, DiscoveredConfigurationItemsInput>
    {
        /// <summary>
        /// Initialize an new DiscoveredConfigurationItems mutation instance.
        /// </summary>
        internal DiscoveredConfigurationItemsMutation(DiscoveredConfigurationItemsInput data)
            : base("discoveredConfigurationItems", "DiscoveredConfigurationItemsInput!", data, new HashSet<IQuery>() { new ConfigurationItemQuery() { FieldName = "configurationItems", IsConnection = false }.Select("*") })
        {
        }
    }
}
