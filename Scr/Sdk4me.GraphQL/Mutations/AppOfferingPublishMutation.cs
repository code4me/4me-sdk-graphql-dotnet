using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new, published, app offering based on the current state of a draft app offering.
    /// </summary>
    internal class AppOfferingPublishMutation : Mutation<AppOfferingPublishMutationPayload, AppOfferingPublishMutationInput>
    {
        /// <summary>
        /// Initialize an new AppOfferingPublish mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The app offering response query.</param>
        internal AppOfferingPublishMutation(AppOfferingPublishMutationInput data, AppOfferingQuery query)
            : base("appOfferingPublish", "AppOfferingPublishMutationInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The app offering response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(AppOfferingQuery query)
        {
            query.FieldName = "appOffering";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
