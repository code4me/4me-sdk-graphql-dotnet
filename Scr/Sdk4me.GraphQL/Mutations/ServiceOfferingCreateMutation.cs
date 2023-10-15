namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new service offering.
    /// </summary>
    internal class ServiceOfferingCreateMutation : Mutation<ServiceOfferingCreatePayload, ServiceOfferingCreateInput>
    {
        /// <summary>
        /// Initialize an new ServiceOfferingCreate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The repsonse query.</param>
        internal ServiceOfferingCreateMutation(ServiceOfferingCreateInput data, ServiceOfferingQuery query)
            : base("serviceOfferingCreate", "ServiceOfferingCreateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(ServiceOfferingQuery query)
        {
            query.FieldName = "serviceOffering";
            query.IsConnection = false;
            return new HashSet<IQuery>() {query};
        }
    }
}
