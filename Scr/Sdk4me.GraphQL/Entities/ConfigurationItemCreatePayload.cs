namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/configurationitemcreatepayload/">ConfigurationItemCreatePayload</see> object.
    /// </summary>
    public class ConfigurationItemCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("configurationItem"), Sdk4meField(true)]
        public ConfigurationItem? ConfigurationItem { get; internal set; }
    }
}
