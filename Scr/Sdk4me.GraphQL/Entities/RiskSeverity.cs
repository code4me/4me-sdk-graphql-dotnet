namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/riskseverity/">RiskSeverity</see> object.
    /// </summary>
    public class RiskSeverity : Node
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
        /// A very short description of the risk severity, for example "Risk is Significant".
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; internal set; }

        /// <summary>
        /// Whether the risk severity may not be related to any more risks.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// Any additional information about the risk severity that might prove useful, especially for risk managers when they need to decide which severity to select for a risk.
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
        /// The name of the risk severity. Ideally the name of a risk severity consists of a single word, such as "High".
        /// </summary>
        [JsonProperty("name"), Sdk4meField(true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// The position that the risk severity takes when it is displayed in a sorted list.
        /// </summary>
        [JsonProperty("position"), Sdk4meField(true)]
        public long? Position { get; internal set; }

        /// <summary>
        /// Automatically set to the Name field value, written in lower case characters and with all spaces replaced by the underscore character. This reference can be used to link the risk severity to a risk using the 4me REST API or the 4me Import functionality.
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
            retval.AddRange(InformationAttachmentsCollection?.GetQueryPageInfo("informationAttachments", depth + 1));
            retval.AddRange(TranslationsCollection?.GetQueryPageInfo("translations", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            InformationAttachments?.AddRange((data as RiskSeverity)?.InformationAttachments);
            Translations?.AddRange((data as RiskSeverity)?.Translations);
        }
    }
}
