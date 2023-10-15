namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new webhook.
    /// </summary>
    internal class WebhookCreateMutation : Mutation<WebhookCreatePayload, WebhookCreateInput>
    {
        /// <summary>
        /// Initialize an new WebhookCreate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The repsonse query.</param>
        internal WebhookCreateMutation(WebhookCreateInput data, WebhookQuery query)
            : base("webhookCreate", "WebhookCreateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(WebhookQuery query)
        {
            query.FieldName = "webhook";
            query.IsConnection = false;
            return new HashSet<IQuery>() {query};
        }
    }
}
