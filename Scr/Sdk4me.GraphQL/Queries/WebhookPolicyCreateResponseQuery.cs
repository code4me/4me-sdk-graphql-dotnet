namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="WebhookPolicyCreateResponse">WebhookPolicyCreateResponse</see> query.
    /// </summary>
    public class WebhookPolicyCreateResponseQuery : Query<WebhookPolicyCreateResponseQuery, WebhookPolicyCreateResponseField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new webhook policy create response query instance.
        /// </summary>
        public WebhookPolicyCreateResponseQuery()
            : base("", typeof(WebhookPolicyCreateResponse), false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public WebhookPolicyCreateResponseQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
