﻿namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/webhookcreateinput/">WebhookCreateInput</see> object.
    /// </summary>
    public class WebhookCreateInput : PropertyChangeSet
    {
        private bool? disabled;
        private string? description;
        private List<AttachmentInput>? descriptionAttachments;
        private string? mailExceptionsTo;
        private string? name;
        private string? webhookPolicyId;
        private string? clientMutationId;
        private WebhookEvent? @event;
        private string? uri;

        /// <summary>
        /// Whether the webhook will be triggered when the event occurs.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled
        {
            get => disabled;
            set => disabled = Set("disabled", value);
        }

        /// <summary>
        /// Description of the webhook's purpose.
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
        /// Comma separated list of email addresses who will be informed when the webhook execution fails.
        /// </summary>
        [JsonProperty("mailExceptionsTo")]
        public string? MailExceptionsTo
        {
            get => mailExceptionsTo;
            set => mailExceptionsTo = Set("mailExceptionsTo", value);
        }

        /// <summary>
        /// Name of this webhook. Defaults to the event name.
        /// </summary>
        [JsonProperty("name")]
        public string? Name
        {
            get => name;
            set => name = Set("name", value);
        }

        /// <summary>
        /// The webhook policy to use for cryptographic signing of the messages.
        /// </summary>
        [JsonProperty("webhookPolicyId")]
        public string? WebhookPolicyId
        {
            get => webhookPolicyId;
            set => webhookPolicyId = Set("webhookPolicyId", value);
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
        /// Event that will trigger this webhook.
        /// </summary>
        [JsonProperty("event")]
        public WebhookEvent? Event
        {
            get => @event;
            set => @event = Set("event", value);
        }

        /// <summary>
        /// Publicly accessible URI that 4me can use to POST http messages to.
        /// </summary>
        [JsonProperty("uri")]
        public string? Uri
        {
            get => uri;
            set => uri = Set("uri", value);
        }
    }
}
