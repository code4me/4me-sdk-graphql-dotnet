namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/uiextensioncreateinput/">UiExtensionCreateInput</see> object.
    /// </summary>
    public class UiExtensionCreateInput : PropertyChangeSet
    {
        private string? source;
        private string? sourceID;
        private UiExtensionCategory? category;
        private bool? disabled;
        private string? name;
        private string? title;
        private bool? activate;
        private string? css;
        private string? html;
        private string? javascript;
        private string? clientMutationId;

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
        /// The type of record in which the user interface extension can be selected.
        /// </summary>
        [JsonProperty("category")]
        public UiExtensionCategory? Category
        {
            get => category;
            set => category = Set("category", value);
        }

        /// <summary>
        /// Whether the user interface extension is inactive.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled
        {
            get => disabled;
            set => disabled = Set("disabled", value);
        }

        /// <summary>
        /// The name of the user interface extension.
        /// </summary>
        [JsonProperty("name")]
        public string? Name
        {
            get => name;
            set => name = Set("name", value);
        }

        /// <summary>
        /// The text that is to be displayed as the section header above the user interface extension when the user interface extension is presented within a form.
        /// </summary>
        [JsonProperty("title")]
        public string? Title
        {
            get => title;
            set => title = Set("title", value);
        }

        /// <summary>
        /// Set to `true` to promote the Prepared Version to the Active Version. If the was an Active Version, it will be Archived.
        /// </summary>
        [JsonProperty("activate")]
        public bool? Activate
        {
            get => activate;
            set => activate = Set("activate", value);
        }

        /// <summary>
        /// Sets the CSS stylesheet of the Prepared Version if updated.
        /// </summary>
        [JsonProperty("css")]
        public string? Css
        {
            get => css;
            set => css = Set("css", value);
        }

        /// <summary>
        /// Sets the HTML code of the Prepared Version if updated.
        /// </summary>
        [JsonProperty("html")]
        public string? Html
        {
            get => html;
            set => html = Set("html", value);
        }

        /// <summary>
        /// Sets the Javascript code of the Prepared Version if updated.
        /// </summary>
        [JsonProperty("javascript")]
        public string? Javascript
        {
            get => javascript;
            set => javascript = Set("javascript", value);
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
    }
}
