using Newtonsoft.Json;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/uiextensionupdateinput/">UiExtensionUpdateInput</see> object.
    /// </summary>
    public class UiExtensionUpdateInput : PropertyChangeSet
    {
        private bool? activate;
        private string? clientMutationId;
        private string? css;
        private string? description;
        private List<AttachmentInput>? descriptionAttachments;
        private bool? disabled;
        private string? html;
        private string id;
        private string? javascript;
        private string? name;
        private string? source;
        private string? sourceID;
        private string? title;

        /// <summary>
        /// Set to <c>true</c> to promote the Prepared Version to the Active Version. If the was an Active Version, it will be Archived.
        /// </summary>
        [JsonProperty("activate")]
        public bool? Activate
        {
            get => activate;
            set => activate = Set("activate", value);
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
        /// Sets the CSS stylesheet of the Prepared Version if updated.
        /// </summary>
        [JsonProperty("css")]
        public string? Css
        {
            get => css;
            set => css = Set("css", value);
        }

        /// <summary>
        /// Description of the UI extension.
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
        /// Whether the UI extension is inactive.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled
        {
            get => disabled;
            set => disabled = Set("disabled", value);
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
        /// The node ID of the record to update.
        /// </summary>
        [JsonProperty("id"), Sdk4meField(IsRequiredForMutation = true)]
        public string ID
        {
            get => id;
            set => id = Set("id", value);
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
        /// The name of the UI extension.
        /// </summary>
        [JsonProperty("name")]
        public string? Name
        {
            get => name;
            set => name = Set("name", value);
        }

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
        /// The text that is to be displayed as the section header above the UI extension when the UI extension is presented within a form.
        /// </summary>
        [JsonProperty("title")]
        public string? Title
        {
            get => title;
            set => title = Set("title", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UiExtensionUpdateInput"/> class without providing the required values.
        /// </summary>
        public UiExtensionUpdateInput()
        {
            id = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UiExtensionUpdateInput"/> class.
        /// </summary>
        /// <param name="id">The node ID of the record to update.</param>
        public UiExtensionUpdateInput(string id)
        {
            this.id = Set("id", id);
        }
    }
}
