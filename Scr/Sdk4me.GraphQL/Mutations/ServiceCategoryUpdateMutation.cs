using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing service category.
    /// </summary>
    internal class ServiceCategoryUpdateMutation : Mutation<ServiceCategoryUpdatePayload, ServiceCategoryUpdateInput>
    {
        /// <summary>
        /// Initialize an new ServiceCategoryUpdate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The service category response query.</param>
        internal ServiceCategoryUpdateMutation(ServiceCategoryUpdateInput data, ServiceCategoryQuery query)
            : base("serviceCategoryUpdate", "ServiceCategoryUpdateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The service category response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(ServiceCategoryQuery query)
        {
            query.FieldName = "serviceCategory";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
