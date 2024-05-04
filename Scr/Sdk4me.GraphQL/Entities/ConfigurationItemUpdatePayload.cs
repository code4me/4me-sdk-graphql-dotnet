using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/configurationitemupdatepayload/">ConfigurationItemUpdatePayload</see> object.
    /// </summary>
    public class ConfigurationItemUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("configurationItem"), Sdk4meField(true)]
        public ConfigurationItem? ConfigurationItem { get; internal set; }
    }
}
