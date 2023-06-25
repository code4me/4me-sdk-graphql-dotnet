namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving Webhook records.
    /// </summary>
    public class WebhookQuery : Query<WebhookQuery, WebhookField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new webhook query instance.
        /// </summary>
        public WebhookQuery()
            : base("webhooks", typeof(Webhook), true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        public WebhookQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to the Description field.
        /// </summary>
        public WebhookQuery SelectDescriptionAttachments(AttachmentQuery query)
        {
            query.FieldName = "descriptionAttachments";
            return Select(query);
        }

        /// <summary>
        /// The webhook policy to use for cryptographic signing of the messages.
        /// </summary>
        public WebhookQuery SelectWebhookPolicy(WebhookPolicyQuery query)
        {
            query.FieldName = "webhookPolicy";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
