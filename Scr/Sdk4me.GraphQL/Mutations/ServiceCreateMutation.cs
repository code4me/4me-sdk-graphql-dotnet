namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new service.
    /// </summary>
    internal class ServiceCreateMutation : Mutation<ServiceCreatePayload, ServiceCreateInput>
    {
        /// <summary>
        /// Initialize an new ServiceCreate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal ServiceCreateMutation(ServiceCreateInput data, ServiceQuery query)
            : base("serviceCreate", "ServiceCreateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(ServiceQuery query)
        {
            query.FieldName = "service";
            query.IsConnection = false;
            return new HashSet<IQuery>() {query};
        }
    }
}
