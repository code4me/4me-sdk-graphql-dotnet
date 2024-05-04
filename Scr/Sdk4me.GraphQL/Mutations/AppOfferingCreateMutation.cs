using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new app offering.
    /// </summary>
    internal class AppOfferingCreateMutation : Mutation<AppOfferingCreatePayload, AppOfferingCreateInput>
    {
        /// <summary>
        /// Initialize an new AppOfferingCreate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The app offering response query.</param>
        internal AppOfferingCreateMutation(AppOfferingCreateInput data, AppOfferingQuery query)
            : base("appOfferingCreate", "AppOfferingCreateInput!", data, GetQuery(query))
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
