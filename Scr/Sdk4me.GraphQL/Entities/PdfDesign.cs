namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/pdfdesign/">PdfDesign</see> object.
    /// </summary>
    public class PdfDesign : Node
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account"), Sdk4meField(true)]
        public Account? Account { get; internal set; }

        /// <summary>
        /// Category of the design.
        /// </summary>
        [JsonProperty("category")]
        public PdfDesignCategory? Category { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// CSS of the design.
        /// </summary>
        [JsonProperty("css")]
        public string? Css { get; internal set; }

        /// <summary>
        /// Whether the design is to be used.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// HTML of the design.
        /// </summary>
        [JsonProperty("html")]
        public string? Html { get; internal set; }

        /// <summary>
        /// Name of the design.
        /// </summary>
        [JsonProperty("name"), Sdk4meField(true)]
        public string? Name { get; internal set; }

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
            retval.AddRange(TranslationsCollection?.GetQueryPageInfo("translations", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            Translations?.AddRange((data as PdfDesign)?.Translations);
        }
    }
}
