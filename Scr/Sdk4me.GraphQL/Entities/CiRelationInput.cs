namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/cirelationinput/">CiRelationInput</see> object.
    /// </summary>
    public class CiRelationInput : PropertyChangeSet
    {
        private string? id;
        private CiRelationRelationType? relationType;
        private string? configurationItemId;
        private string? source;

        /// <summary>
        /// Identifier of the object to update using these values. For new objects it should be `null`.
        /// </summary>
        [JsonProperty("id")]
        public string? ID
        {
            get => id;
            set => id = Set("id", value);
        }

        /// <summary>
        /// The type of the relation.
        /// </summary>
        [JsonProperty("relationType")]
        public CiRelationRelationType? RelationType
        {
            get => relationType;
            set => relationType = Set("relationType", value);
        }

        /// <summary>
        /// Identifier of related configuration item.
        /// </summary>
        [JsonProperty("configurationItemId")]
        public string? ConfigurationItemId
        {
            get => configurationItemId;
            set => configurationItemId = Set("configurationItemId", value);
        }

        /// <summary>
        /// An identifier for the client application submitting the relation or the name of an external system.
        /// </summary>
        [JsonProperty("source")]
        public string? Source
        {
            get => source;
            set => source = Set("source", value);
        }
    }
}
