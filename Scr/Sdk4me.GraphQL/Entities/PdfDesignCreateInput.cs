namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/pdfdesigncreateinput/">PdfDesignCreateInput</see> object.
    /// </summary>
    public class PdfDesignCreateInput : PropertyChangeSet
    {
        private string? source;
        private string? sourceID;
        private PdfDesignCategory? category;
        private bool? disabled;
        private string? html;
        private string? css;
        private string? clientMutationId;
        private string? name;

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
        /// Category of the design.
        /// </summary>
        [JsonProperty("category")]
        public PdfDesignCategory? Category
        {
            get => category;
            set => category = Set("category", value);
        }

        /// <summary>
        /// Whether the design is to be used.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled
        {
            get => disabled;
            set => disabled = Set("disabled", value);
        }

        /// <summary>
        /// HTML of the design.
        /// </summary>
        [JsonProperty("html")]
        public string? Html
        {
            get => html;
            set => html = Set("html", value);
        }

        /// <summary>
        /// CSS of the design.
        /// </summary>
        [JsonProperty("css")]
        public string? Css
        {
            get => css;
            set => css = Set("css", value);
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
        /// Name of the design.
        /// </summary>
        [JsonProperty("name")]
        public string? Name
        {
            get => name;
            set => name = Set("name", value);
        }
    }
}
