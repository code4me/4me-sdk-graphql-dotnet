namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new service level agreement.
    /// </summary>
    internal class ServiceLevelAgreementCreateMutation : Mutation<ServiceLevelAgreementCreatePayload, ServiceLevelAgreementCreateInput>
    {
        /// <summary>
        /// Initialize an new ServiceLevelAgreementCreate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The service level agreement response query.</param>
        internal ServiceLevelAgreementCreateMutation(ServiceLevelAgreementCreateInput data, ServiceLevelAgreementQuery query)
            : base("serviceLevelAgreementCreate", "ServiceLevelAgreementCreateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The service level agreement response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(ServiceLevelAgreementQuery query)
        {
            query.FieldName = "serviceLevelAgreement";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
