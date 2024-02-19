namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new service category.
    /// </summary>
    internal class ServiceCategoryCreateMutation : Mutation<ServiceCategoryCreatePayload, ServiceCategoryCreateInput>
    {
        /// <summary>
        /// Initialize an new ServiceCategoryCreate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal ServiceCategoryCreateMutation(ServiceCategoryCreateInput data, ServiceCategoryQuery query)
            : base("serviceCategoryCreate", "ServiceCategoryCreateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(ServiceCategoryQuery query)
        {
            query.FieldName = "serviceCategory";
            query.IsConnection = false;
            return new HashSet<IQuery>() {query};
        }
    }
}
