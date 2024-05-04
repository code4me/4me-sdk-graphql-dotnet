﻿using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing webhook policy.
    /// </summary>
    internal class WebhookPolicyUpdateMutation : Mutation<WebhookPolicyUpdatePayload, WebhookPolicyUpdateInput>
    {
        /// <summary>
        /// Initialize an new WebhookPolicyUpdate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The webhook policy response query.</param>
        internal WebhookPolicyUpdateMutation(WebhookPolicyUpdateInput data, WebhookPolicyQuery query)
            : base("webhookPolicyUpdate", "WebhookPolicyUpdateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The webhook policy response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(WebhookPolicyQuery query)
        {
            query.FieldName = "webhookPolicy";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
