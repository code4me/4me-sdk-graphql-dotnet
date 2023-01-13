namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/discoveredcirelationinput/">DiscoveredCiRelationInput</see> object.
    /// </summary>
    public class DiscoveredCiRelationInput : PropertyChangeSet
    {
        private List<string>? childIds;

        /// <summary>
        /// Identifiers of other configuration items that are children of this item.
        /// </summary>
        [JsonProperty("childIds")]
        public List<string>? ChildIds
        {
            get => childIds;
            set => childIds = Set("childIds", value);
        }
    }
}
