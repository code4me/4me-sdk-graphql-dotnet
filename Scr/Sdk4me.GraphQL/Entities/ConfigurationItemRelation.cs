namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/configurationitemrelation/">ConfigurationItemRelation</see> object.
    /// </summary>
    public class ConfigurationItemRelation : Node
    {
        /// <summary>
        /// Related configuration item.
        /// </summary>
        [JsonProperty("configurationItem"), Sdk4meField(true)]
        public ConfigurationItem? ConfigurationItem { get; internal set; }

        /// <summary>
        /// The type of the relation.
        /// </summary>
        [JsonProperty("relationType"), Sdk4meField(true)]
        public CiRelationRelationType? RelationType { get; internal set; }

        /// <summary>
        /// An identifier for the client application submitting the relation or the name of an external system.
        /// </summary>
        [JsonProperty("source")]
        public string? Source { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
