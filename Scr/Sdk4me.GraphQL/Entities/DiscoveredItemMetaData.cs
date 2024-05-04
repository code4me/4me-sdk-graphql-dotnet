using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/discovereditemmetadata/">DiscoveredItemMetaData</see> object.
    /// </summary>
    public class DiscoveredItemMetaData : PropertyChangeSet
    {
        private DiscoveredItemStrategy? strategy;

        /// <summary>
        /// How to handle records already present in 4me.
        /// </summary>
        [JsonProperty("strategy")]
        public DiscoveredItemStrategy? Strategy
        {
            get => strategy;
            set => strategy = Set("strategy", value);
        }
    }
}
