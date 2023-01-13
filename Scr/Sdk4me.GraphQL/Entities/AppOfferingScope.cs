namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/appofferingscope/">AppOfferingScope</see> object.
    /// </summary>
    public class AppOfferingScope : Node
    {
        /// <summary>
        /// Actions this scope applies to.
        /// </summary>
        [JsonProperty("actions"), Sdk4meField(true)]
        public List<string>? Actions { get; internal set; }

        /// <summary>
        /// Conditions for this scope.
        /// </summary>
        [JsonProperty("conditions")]
        public List<string>? Conditions { get; internal set; }

        /// <summary>
        /// Whether this scope allows or prevents access.
        /// </summary>
        [JsonProperty("effect")]
        public ScopeEffect? Effect { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
