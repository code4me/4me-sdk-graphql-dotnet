namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/knowledgearticle/">KnowledgeArticle</see> object.
    /// </summary>
    public class KnowledgeArticle : Node
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account"), Sdk4meField(true)]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The date until which the knowledge article will be active. The knowledge article will be archived at the beginning of this day. When the knowledge article is archived, its status will automatically be set to "Archived".
        /// </summary>
        [JsonProperty("archiveDate")]
        public DateOnly? ArchiveDate { get; internal set; }

        /// <summary>
        /// Whether the knowledge article needs to be available to the people who are a member of the support team of one of the service instances that are selected in the Coverage section of an active SLA for the service that is linked to the article.
        /// </summary>
        [JsonProperty("coveredSpecialists")]
        public bool? CoveredSpecialists { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// The person who created the knowledge article.
        /// </summary>
        [JsonProperty("createdBy")]
        public Person? CreatedBy { get; internal set; }

        /// <summary>
        /// Values of custom fields.
        /// </summary>
        [JsonProperty("customFields")]
        public CustomFieldCollection? CustomFields { get; internal set; }

        [JsonProperty("customFieldsAttachments")]
        internal NodeCollection<Attachment>? CustomFieldsAttachmentsCollection { get; set; }

        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        public DataList<Attachment>? CustomFieldsAttachments
        {
            get => CustomFieldsAttachmentsCollection?.Data;
        }

        /// <summary>
        /// Describes the situation and/or environment in which the instructions of the knowledge article may be helpful.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; internal set; }

        [JsonProperty("descriptionAttachments")]
        internal NodeCollection<Attachment>? DescriptionAttachmentsCollection { get; set; }

        /// <summary>
        /// Inline images linked to the Description field.
        /// </summary>
        public DataList<Attachment>? DescriptionAttachments
        {
            get => DescriptionAttachmentsCollection?.Data;
        }

        /// <summary>
        /// Whether the knowledge article needs to be available to anyone who is covered by an active SLA for the service that is linked to the article.
        /// </summary>
        [JsonProperty("endUsers")]
        public bool? EndUsers { get; internal set; }

        /// <summary>
        /// Used to enter instructions for the service desk analysts, specialists and/or end users who are likely to look up the knowledge article to help them with their work or to resolve an issue.
        /// </summary>
        [JsonProperty("instructions")]
        public string? Instructions { get; internal set; }

        [JsonProperty("instructionsAttachments")]
        internal NodeCollection<Attachment>? InstructionsAttachmentsCollection { get; set; }

        /// <summary>
        /// Inline images linked to the Instructions field.
        /// </summary>
        public DataList<Attachment>? InstructionsAttachments
        {
            get => InstructionsAttachmentsCollection?.Data;
        }

        /// <summary>
        /// Whether the knowledge article needs to be available to the people who have the Specialist role of the account in which the article is registered.
        /// </summary>
        [JsonProperty("internalSpecialists")]
        public bool? InternalSpecialists { get; internal set; }

        /// <summary>
        /// Whether the knowledge article needs to be available to the people who have the Key Contact role of the customer account of an active SLA for the service that is linked to the article.
        /// </summary>
        [JsonProperty("keyContacts")]
        public bool? KeyContacts { get; internal set; }

        /// <summary>
        /// A comma-separated list of words that can be used to find the knowledge article using search.
        /// </summary>
        [JsonProperty("keywords")]
        public string? Keywords { get; internal set; }

        /// <summary>
        /// Whether the knowledge article needs to be available to anyone, including people without access to 4me.
        /// </summary>
        [JsonProperty("public")]
        public bool? Public { get; internal set; }

        [JsonProperty("requests")]
        internal NodeCollection<Request>? RequestsCollection { get; set; }

        /// <summary>
        /// Requests linked to this knowledge article.
        /// </summary>
        public DataList<Request>? Requests
        {
            get => RequestsCollection?.Data;
        }

        /// <summary>
        /// Service for which the knowledge article is made available.
        /// </summary>
        [JsonProperty("service"), Sdk4meField(true)]
        public Service? Service { get; internal set; }

        [JsonProperty("serviceInstances")]
        internal NodeCollection<ServiceInstance>? ServiceInstancesCollection { get; set; }

        /// <summary>
        /// Service instances linked to this knowledge article.
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
        /// The current status of the knowledge article.
        /// </summary>
        [JsonProperty("status"), Sdk4meField(true)]
        public KnowledgeArticleStatus? Status { get; internal set; }

        /// <summary>
        /// A short description of the knowledge article.
        /// </summary>
        [JsonProperty("subject"), Sdk4meField(true)]
        public string? Subject { get; internal set; }

        /// <summary>
        /// The knowledge article template that this knowledge article is based on.
        /// </summary>
        [JsonProperty("template")]
        public KnowledgeArticleTemplate? Template { get; internal set; }

        [JsonProperty("translations")]
        internal NodeCollection<Translation>? TranslationsCollection { get; set; }

        /// <summary>
        /// Translations associated with this object.
        /// </summary>
        public DataList<Translation>? Translations
        {
            get => TranslationsCollection?.Data;
        }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [JsonProperty("updatedAt"), Sdk4meField(true)]
        public DateTime? UpdatedAt { get; internal set; }

        /// <summary>
        /// The person who last updated the knowledge article.
        /// </summary>
        [JsonProperty("updatedBy")]
        public Person? UpdatedBy { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(CustomFieldsAttachmentsCollection?.GetQueryPageInfo("customFieldsAttachments", depth + 1));
            retval.AddRange(DescriptionAttachmentsCollection?.GetQueryPageInfo("descriptionAttachments", depth + 1));
            retval.AddRange(InstructionsAttachmentsCollection?.GetQueryPageInfo("instructionsAttachments", depth + 1));
            retval.AddRange(RequestsCollection?.GetQueryPageInfo("requests", depth + 1));
            retval.AddRange(ServiceInstancesCollection?.GetQueryPageInfo("serviceInstances", depth + 1));
            retval.AddRange(TranslationsCollection?.GetQueryPageInfo("translations", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            CustomFieldsAttachments?.AddRange((data as KnowledgeArticle)?.CustomFieldsAttachments);
            DescriptionAttachments?.AddRange((data as KnowledgeArticle)?.DescriptionAttachments);
            InstructionsAttachments?.AddRange((data as KnowledgeArticle)?.InstructionsAttachments);
            Requests?.AddRange((data as KnowledgeArticle)?.Requests);
            ServiceInstances?.AddRange((data as KnowledgeArticle)?.ServiceInstances);
            Translations?.AddRange((data as KnowledgeArticle)?.Translations);
        }
    }
}
