namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing webhook.
    /// </summary>
    internal class WebhookUpdateMutation : Mutation<WebhookUpdatePayload, WebhookUpdateInput>
    {
        /// <summary>
        /// Initialize an new WebhookUpdate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal WebhookUpdateMutation(WebhookUpdateInput data, WebhookQuery query)
            : base("webhookUpdate", "WebhookUpdateInput!", data, GetQuery(query))
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
