namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/slacoveragegroup/">SlaCoverageGroup</see> object.
    /// </summary>
    public class SlaCoverageGroup : Node
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account")]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Any additional information about the SLA coverage group.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; internal set; }

        [JsonProperty("descriptionAttachments")]
        internal NodeCollection<Attachment>? DescriptionAttachmentsCollection { get; set; }

        /// <summary>
        /// The attachments used in the <c>description</c> field.
        /// </summary>
        public DataList<Attachment>? DescriptionAttachments
        {
            get => DescriptionAttachmentsCollection?.Data;
        }

        /// <summary>
        /// Whether the SLA coverage group may no longer be related to other records.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// The name of the SLA coverage group.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; internal set; }

        [JsonProperty("people")]
        internal NodeCollection<Person>? PeopleCollection { get; set; }

        /// <summary>
        /// People of the SLA coverage group.
        /// </summary>
        public DataList<Person>? People
        {
            get => PeopleCollection?.Data;
        }

        /// <summary>
        /// The phrase used to filter the people.
        /// </summary>
        [JsonProperty("searchPhrase")]
        public string? SearchPhrase { get; internal set; }

        [JsonProperty("slas")]
        internal NodeCollection<ServiceLevelAgreement>? SlasCollection { get; set; }

        /// <summary>
        /// Service level agreements linked to the SLA coverage group.
        /// </summary>
        public DataList<ServiceLevelAgreement>? Slas
        {
            get => SlasCollection?.Data;
        }

        /// <summary>
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [JsonProperty("source")]
        public string? Source { get; internal set; }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [JsonProperty("sourceID")]
        public string? SourceID { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [JsonProperty("updatedAt")]
        public DateTime? UpdatedAt { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(DescriptionAttachmentsCollection?.GetQueryPageInfo("descriptionAttachments", depth + 1));
            retval.AddRange(PeopleCollection?.GetQueryPageInfo("people", depth + 1));
            retval.AddRange(SlasCollection?.GetQueryPageInfo("slas", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            DescriptionAttachments?.AddRange((data as SlaCoverageGroup)?.DescriptionAttachments);
            People?.AddRange((data as SlaCoverageGroup)?.People);
            Slas?.AddRange((data as SlaCoverageGroup)?.Slas);
        }
    }
}
