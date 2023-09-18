namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/knowledgearticleupdateinput/">KnowledgeArticleUpdateInput</see> object.
    /// </summary>
    public class KnowledgeArticleUpdateInput : PropertyChangeSet
    {
        private string? source;
        private string? sourceID;
        private CustomFieldCollection? customFields;
        private List<AttachmentInput>? customFieldsAttachments;
        private DateOnly? archiveDate;
        private bool? coveredSpecialists;
        private string? createdById;
        private string? description;
        private List<AttachmentInput>? descriptionAttachments;
        private bool? endUsers;
        private bool? @public;
        private string? instructions;
        private bool? internalSpecialists;
        private bool? keyContacts;
        private string? keywords;
        private string? serviceId;
        private List<string>? serviceInstanceIds;
        private KnowledgeArticleStatus? status;
        private string? subject;
        private string? templateId;
        private string? clientMutationId;
        private string? id;
        private List<string>? translationsToDelete;

        /// <summary>
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [JsonProperty("source")]
        public string? Source
        {
            get => source;
            set => source = Set("source", value);
        }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [JsonProperty("sourceID")]
        public string? SourceID
        {
            get => sourceID;
            set => sourceID = Set("sourceID", value);
        }

        /// <summary>
        /// Values for custom fields to be used by the UI Extension that is linked to the record.
        /// </summary>
        [JsonProperty("customFields")]
        public CustomFieldCollection? CustomFields
        {
            get => customFields;
            set => customFields = Set("customFields", value);
        }

        /// <summary>
        /// The attachments used in the custom fields' values.
        /// </summary>
        [JsonProperty("customFieldsAttachments")]
        public List<AttachmentInput>? CustomFieldsAttachments
        {
            get => customFieldsAttachments;
            set => customFieldsAttachments = Set("customFieldsAttachments", value);
        }

        /// <summary>
        /// The date until which the knowledge article will be active. The knowledge article will be archived at the beginning of this day. When the knowledge article is archived, its status will automatically be set to "Archived".
        /// </summary>
        [JsonProperty("archiveDate")]
        public DateOnly? ArchiveDate
        {
            get => archiveDate;
            set => archiveDate = Set("archiveDate", value);
        }

        /// <summary>
        /// Whether the knowledge article needs to be available to the people who are a member of the support team of one of the service instances that are selected in the Coverage section of an active SLA for the service that is linked to the article.
        /// </summary>
        [JsonProperty("coveredSpecialists")]
        public bool? CoveredSpecialists
        {
            get => coveredSpecialists;
            set => coveredSpecialists = Set("coveredSpecialists", value);
        }

        /// <summary>
        /// Identifier of the person who created the knowledge article.
        /// </summary>
        [JsonProperty("createdById")]
        public string? CreatedById
        {
            get => createdById;
            set => createdById = Set("createdById", value);
        }

        /// <summary>
        /// Describes the situation and/or environment in which the instructions of the knowledge article may be helpful.
        /// </summary>
        [JsonProperty("description")]
        public string? Description
        {
            get => description;
            set => description = Set("description", value);
        }

        /// <summary>
        /// The attachments used in the <c>description</c> field.
        /// </summary>
        [JsonProperty("descriptionAttachments")]
        public List<AttachmentInput>? DescriptionAttachments
        {
            get => descriptionAttachments;
            set => descriptionAttachments = Set("descriptionAttachments", value);
        }

        /// <summary>
        /// Whether the knowledge article needs to be available to anyone who is covered by an active SLA for the service that is linked to the article.
        /// </summary>
        [JsonProperty("endUsers")]
        public bool? EndUsers
        {
            get => endUsers;
            set => endUsers = Set("endUsers", value);
        }

        /// <summary>
        /// Whether the knowledge article needs to be available to anyone, including people without access to 4me.
        /// </summary>
        [JsonProperty("public")]
        public bool? Public
        {
            get => @public;
            set => @public = Set("public", value);
        }

        /// <summary>
        /// Used to enter instructions for the service desk analysts, specialists and/or end users who are likely to look up the knowledge article to help them with their work or to resolve an issue.
        /// </summary>
        [JsonProperty("instructions")]
        public string? Instructions
        {
            get => instructions;
            set => instructions = Set("instructions", value);
        }

        /// <summary>
        /// Whether the knowledge article needs to be available to the people who have the Specialist role of the account in which the article is registered.
        /// </summary>
        [JsonProperty("internalSpecialists")]
        public bool? InternalSpecialists
        {
            get => internalSpecialists;
            set => internalSpecialists = Set("internalSpecialists", value);
        }

        /// <summary>
        /// Whether the knowledge article needs to be available to the people who have the Key Contact role of the customer account of an active SLA for the service that is linked to the article.
        /// </summary>
        [JsonProperty("keyContacts")]
        public bool? KeyContacts
        {
            get => keyContacts;
            set => keyContacts = Set("keyContacts", value);
        }

        /// <summary>
        /// A comma-separated list of words that can be used to find the knowledge article using search.
        /// </summary>
        [JsonProperty("keywords")]
        public string? Keywords
        {
            get => keywords;
            set => keywords = Set("keywords", value);
        }

        /// <summary>
        /// Identifier of the service for which the knowledge article is made available.
        /// </summary>
        [JsonProperty("serviceId")]
        public string? ServiceId
        {
            get => serviceId;
            set => serviceId = Set("serviceId", value);
        }

        /// <summary>
        /// Identifiers of service instances linked to this knowledge article.
        /// </summary>
        [JsonProperty("serviceInstanceIds")]
        public List<string>? ServiceInstanceIds
        {
            get => serviceInstanceIds;
            set => serviceInstanceIds = Set("serviceInstanceIds", value);
        }

        /// <summary>
        /// The current status of the knowledge article.
        /// </summary>
        [JsonProperty("status")]
        public KnowledgeArticleStatus? Status
        {
            get => status;
            set => status = Set("status", value);
        }

        /// <summary>
        /// A short description of the knowledge article.
        /// </summary>
        [JsonProperty("subject")]
        public string? Subject
        {
            get => subject;
            set => subject = Set("subject", value);
        }

        /// <summary>
        /// Identifier of the knowledge article template that this knowledge article is based on.
        /// </summary>
        [JsonProperty("templateId")]
        public string? TemplateId
        {
            get => templateId;
            set => templateId = Set("templateId", value);
        }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        [JsonProperty("clientMutationId")]
        public string? ClientMutationId
        {
            get => clientMutationId;
            set => clientMutationId = Set("clientMutationId", value);
        }

        /// <summary>
        /// The node ID of the record to update.
        /// </summary>
        [JsonProperty("id")]
        public string? ID
        {
            get => id;
            set => id = Set("id", value);
        }

        /// <summary>
        /// Identifiers of translations to remove from this knowledge articles.
        /// </summary>
        [JsonProperty("translationsToDelete")]
        public List<string>? TranslationsToDelete
        {
            get => translationsToDelete;
            set => translationsToDelete = Set("translationsToDelete", value);
        }
    }
}
