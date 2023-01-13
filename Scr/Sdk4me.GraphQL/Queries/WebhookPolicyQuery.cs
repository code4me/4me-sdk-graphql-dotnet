namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving WebhookPolicy records.
    /// </summary>
    public class WebhookPolicyQuery : Query<WebhookPolicyQuery, WebhookPolicyField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new webhook policy query instance.
        /// </summary>
        public WebhookPolicyQuery()
            : base("webhookPolicies", typeof(WebhookPolicy), true)
        {
        }
    }
}
