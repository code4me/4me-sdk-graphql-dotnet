using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/discoveredreferencearraystrategyinput/">DiscoveredReferenceArrayStrategyInput</see> object.
    /// </summary>
    public class DiscoveredReferenceArrayStrategyInput : PropertyChangeSet
    {
        private DiscoveredReferenceArrayStrategy? strategy;

        /// <summary>
        /// How to handle existing references, to other objects, for discovered items already present in 4me.
        /// </summary>
        [JsonProperty("strategy")]
        public DiscoveredReferenceArrayStrategy? Strategy
        {
            get => strategy;
            set => strategy = Set("strategy", value);
        }
    }
}
