namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/uiextension/">UiExtension</see> object.
    /// </summary>
    public class UiExtension : Node
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account"), Sdk4meField(true)]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The version with Status <c>active</c>.
        /// </summary>
        [JsonProperty("activeVersion"), Sdk4meField(true)]
        public UiExtensionVersion? ActiveVersion { get; internal set; }

        /// <summary>
        /// The type of record in which the UI extension can be selected.
        /// </summary>
        [JsonProperty("category")]
        public UiExtensionCategory? Category { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// The person who created the UI extension.
        /// </summary>
        [JsonProperty("createdBy")]
        public Person? CreatedBy { get; internal set; }

        /// <summary>
        /// Description of the UI Extension.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; internal set; }

        [JsonProperty("descriptionAttachments")]
        internal NodeCollection<Attachment>? DescriptionAttachmentsCollection { get; set; }

        /// <summary>
        /// Files and inline images linked to the Description field.
        /// </summary>
        public DataList<Attachment>? DescriptionAttachments
        {
            get => DescriptionAttachmentsCollection?.Data;
        }

        /// <summary>
        /// Whether the UI extension is inactive.
        /// </summary>
        [JsonProperty("disabled"), Sdk4meField(true)]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// The name of the UI extension.
        /// </summary>
        [JsonProperty("name"), Sdk4meField(true)]
        public string? Name { get; internal set; }

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
        /// The text that is to be displayed as the section header above the UI extension when the UI extension is presented within a form.
        /// </summary>
        [JsonProperty("title")]
        public string? Title { get; internal set; }

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
        /// The person who last updated the UI extension.
        /// </summary>
        [JsonProperty("updatedBy")]
        public Person? UpdatedBy { get; internal set; }

        [JsonProperty("versions")]
        internal NodeCollection<UiExtensionVersion>? VersionsCollection { get; set; }

        /// <summary>
        /// Versions of the UI extension.
        /// </summary>
        public DataList<UiExtensionVersion>? Versions
        {
            get => VersionsCollection?.Data;
        }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(DescriptionAttachmentsCollection?.GetQueryPageInfo("descriptionAttachments", depth + 1));
            retval.AddRange(TranslationsCollection?.GetQueryPageInfo("translations", depth + 1));
            retval.AddRange(VersionsCollection?.GetQueryPageInfo("versions", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            DescriptionAttachments?.AddRange((data as UiExtension)?.DescriptionAttachments);
            Translations?.AddRange((data as UiExtension)?.Translations);
            Versions?.AddRange((data as UiExtension)?.Versions);
        }
    }
}
