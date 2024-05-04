using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing service offering.
    /// </summary>
    internal class ServiceOfferingUpdateMutation : Mutation<ServiceOfferingUpdatePayload, ServiceOfferingUpdateInput>
    {
        /// <summary>
        /// Initialize an new ServiceOfferingUpdate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The service offering response query.</param>
        internal ServiceOfferingUpdateMutation(ServiceOfferingUpdateInput data, ServiceOfferingQuery query)
            : base("serviceOfferingUpdate", "ServiceOfferingUpdateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The service offering response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(ServiceOfferingQuery query)
        {
            query.FieldName = "serviceOffering";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
