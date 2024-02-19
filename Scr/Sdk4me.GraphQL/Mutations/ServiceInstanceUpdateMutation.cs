namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing service instance.
    /// </summary>
    internal class ServiceInstanceUpdateMutation : Mutation<ServiceInstanceUpdatePayload, ServiceInstanceUpdateInput>
    {
        /// <summary>
        /// Initialize an new ServiceInstanceUpdate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal ServiceInstanceUpdateMutation(ServiceInstanceUpdateInput data, ServiceInstanceQuery query)
            : base("serviceInstanceUpdate", "ServiceInstanceUpdateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(ServiceInstanceQuery query)
        {
            query.FieldName = "serviceInstance";
            query.IsConnection = false;
            return new HashSet<IQuery>() {query};
        }
    }
}
