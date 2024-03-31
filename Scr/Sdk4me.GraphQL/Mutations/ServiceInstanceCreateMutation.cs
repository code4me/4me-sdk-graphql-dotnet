namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new service instance.
    /// </summary>
    internal class ServiceInstanceCreateMutation : Mutation<ServiceInstanceCreatePayload, ServiceInstanceCreateInput>
    {
        /// <summary>
        /// Initialize an new ServiceInstanceCreate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal ServiceInstanceCreateMutation(ServiceInstanceCreateInput data, ServiceInstanceQuery query)
            : base("serviceInstanceCreate", "ServiceInstanceCreateInput!", data, GetQuery(query))
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
            return new HashSet<IQuery>() { query };
        }
    }
}
