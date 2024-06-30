namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving WebhookPolicy records.
    /// </summary>
    public class WebhookPolicyQuery : Query<WebhookPolicyQuery, WebhookPolicyField, DefaultView, WebhookPolicyFilter, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new webhook policy query instance.
        /// </summary>
        public WebhookPolicyQuery()
            : base("webhookPolicies", typeof(WebhookPolicy), true)
        {
        }

        /// <summary>
        /// Initialize a new webhook policy query instance.
        /// <br>Additional filters and views will be ignored.</br>
        /// </summary>
        /// <param name="id">The ID of the webhook policy.</param>
        public WebhookPolicyQuery(string id)
            : base("WebhookPolicy", id, typeof(WebhookPolicy), false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public WebhookPolicyQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
