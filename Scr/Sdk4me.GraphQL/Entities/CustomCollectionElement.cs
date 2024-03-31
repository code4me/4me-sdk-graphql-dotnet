namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/customcollectionelement/">CustomCollectionElement</see> object.
    /// </summary>
    public class CustomCollectionElement : Node, IHasTranslations
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
        /// Collection of this element.
        /// </summary>
        [JsonProperty("customCollection")]
        public CustomCollection? CustomCollection { get; internal set; }

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
        /// Description of the collection element.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; internal set; }

        /// <summary>
        /// Whether the collection element may not be referenced from custom fields of other records.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// Any additional information about the element that might prove useful.
        /// </summary>
        [JsonProperty("information")]
        public string? Information { get; internal set; }

        [JsonProperty("informationAttachments")]
        internal NodeCollection<Attachment>? InformationAttachmentsCollection { get; set; }

        /// <summary>
        /// Files and inline images linked to the Information field.
        /// </summary>
        public DataList<Attachment>? InformationAttachments
        {
            get => InformationAttachmentsCollection?.Data;
        }

        /// <summary>
        /// Name of the collection element.
        /// </summary>
        [JsonProperty("name"), Sdk4meField(true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// The hyperlink to the image file for the record.
        /// </summary>
        [JsonProperty("pictureUri")]
        public string? PictureUri { get; internal set; }

        /// <summary>
        /// The Reference field is automatically set to the Name field value, written in lower case characters and with all spaces replaced by the underscore character.
        /// </summary>
        [JsonProperty("reference"), Sdk4meField(true)]
        public string? Reference { get; internal set; }

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

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(CustomFieldsAttachmentsCollection?.GetQueryPageInfo("customFieldsAttachments", depth + 1));
            retval.AddRange(InformationAttachmentsCollection?.GetQueryPageInfo("informationAttachments", depth + 1));
            retval.AddRange(TranslationsCollection?.GetQueryPageInfo("translations", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            CustomFieldsAttachments?.AddRange((data as CustomCollectionElement)?.CustomFieldsAttachments);
            InformationAttachments?.AddRange((data as CustomCollectionElement)?.InformationAttachments);
            Translations?.AddRange((data as CustomCollectionElement)?.Translations);
        }
    }
}
