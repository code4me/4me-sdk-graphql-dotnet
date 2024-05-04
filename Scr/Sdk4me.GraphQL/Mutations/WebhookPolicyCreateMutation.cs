using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new webhook policy.
    /// </summary>
    internal class WebhookPolicyCreateMutation : Mutation<WebhookPolicyCreatePayload, WebhookPolicyCreateInput>
    {
        /// <summary>
        /// Initialize an new WebhookPolicyCreate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The webhook policy create response response query.</param>
        internal WebhookPolicyCreateMutation(WebhookPolicyCreateInput data, WebhookPolicyCreateResponseQuery query)
            : base("webhookPolicyCreate", "WebhookPolicyCreateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The webhook policy create response response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(WebhookPolicyCreateResponseQuery query)
        {
            query.FieldName = "webhookPolicy";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
