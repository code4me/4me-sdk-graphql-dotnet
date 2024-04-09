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
        /// Initialize a new webhook query instance.
        /// <br>Additional filters and views will be ignored.</br>
        /// </summary>
        /// <param name="id">The ID of the webhook.</param>
        public WebhookQuery(string id)
            : base("Webhook", id, typeof(Webhook), false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public WebhookQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to the Description field.
        /// </summary>
        /// <param name="query">The attachment query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public WebhookQuery SelectDescriptionAttachments(AttachmentQuery query)
        {
            query.FieldName = "descriptionAttachments";
            return Select(query);
        }

        /// <summary>
        /// The webhook policy to use for cryptographic signing of the messages.
        /// </summary>
        /// <param name="query">The webhook policy query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public WebhookQuery SelectWebhookPolicy(WebhookPolicyQuery query)
        {
            query.FieldName = "webhookPolicy";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
