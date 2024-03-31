namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing service.
    /// </summary>
    internal class ServiceUpdateMutation : Mutation<ServiceUpdatePayload, ServiceUpdateInput>
    {
        /// <summary>
        /// Initialize an new ServiceUpdate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal ServiceUpdateMutation(ServiceUpdateInput data, ServiceQuery query)
            : base("serviceUpdate", "ServiceUpdateInput!", data, GetQuery(query))
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
            return new HashSet<IQuery>() { query };
        }
    }
}
