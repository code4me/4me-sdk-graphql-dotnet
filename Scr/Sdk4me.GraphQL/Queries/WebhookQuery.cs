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
        /// Inline images linked to the Description field.
        /// </summary>
        public WebhookQuery SelectDescriptionAttachments(AttachmentQuery query)
        {
            query.FieldName = "descriptionAttachments";
            return Select(query);
        }
    }
}
