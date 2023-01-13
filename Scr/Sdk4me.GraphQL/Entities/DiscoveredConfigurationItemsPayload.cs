﻿namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/discoveredconfigurationitemspayload/">DiscoveredConfigurationItemsPayload</see> object.
    /// </summary>
    public class DiscoveredConfigurationItemsPayload : Payload
    {
        /// <summary>
        /// Metadata about asynchronous query execution. The `asyncQuery { resultUrl }` contains an expiring link to the file with the full results.
        /// </summary>
        [JsonProperty("asyncQuery"), Sdk4meField(true)]
        public AsyncQuery? AsyncQuery { get; internal set; }

        /// <summary>
        /// Configuration items will be `null` on initial submission. The `asyncQuery { resultUrl }` contains an expiring link to the file with the full results.
        /// </summary>
        [JsonProperty("configurationItems"), Sdk4meField(true)]
        public List<ConfigurationItem>? ConfigurationItems { get; internal set; }
    }
}
