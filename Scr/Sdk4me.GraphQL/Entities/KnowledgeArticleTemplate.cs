namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/knowledgearticletemplate/">KnowledgeArticleTemplate</see> object.
    /// </summary>
    public class KnowledgeArticleTemplate : Node
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account"), Sdk4meField(true)]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Whether the knowledge article template may no longer be used to create knowledge articles.
        /// </summary>
        [JsonProperty("disabled"), Sdk4meField(true)]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// Service that is applied to knowledge articles using this template.
        /// </summary>
        [JsonProperty("service"), Sdk4meField(true)]
        public Service? Service { get; internal set; }

        [JsonProperty("serviceInstances")]
        internal NodeCollection<ServiceInstance>? ServiceInstancesCollection { get; set; }

        /// <summary>
        /// Service instances that are applied to knowledge articles using this template.
        /// </summary>
        public DataList<ServiceInstance>? ServiceInstances
        {
            get => ServiceInstancesCollection?.Data;
        }

        /// <summary>
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [JsonProperty("source"), Sdk4meField(true)]
        public string? Source { get; internal set; }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [JsonProperty("sourceID"), Sdk4meField(true)]
        public string? SourceID { get; internal set; }

        /// <summary>
        /// A short description of the knowledge article template.
        /// </summary>
        [JsonProperty("subject"), Sdk4meField(true)]
        public string? Subject { get; internal set; }

        /// <summary>
        /// The UI extension that is applied to knowledge articles using this template.
        /// </summary>
        [JsonProperty("uiExtension")]
        public UiExtension? UiExtension { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [JsonProperty("updatedAt"), Sdk4meField(true)]
        public DateTime? UpdatedAt { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(ServiceInstancesCollection?.GetQueryPageInfo("serviceInstances", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            ServiceInstances?.AddRange((data as KnowledgeArticleTemplate)?.ServiceInstances);
        }
    }
}
