namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing service level agreement.
    /// </summary>
    internal class ServiceLevelAgreementUpdateMutation : Mutation<ServiceLevelAgreementUpdatePayload, ServiceLevelAgreementUpdateInput>
    {
        /// <summary>
        /// Initialize an new ServiceLevelAgreementUpdate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The repsonse query.</param>
        internal ServiceLevelAgreementUpdateMutation(ServiceLevelAgreementUpdateInput data, ServiceLevelAgreementQuery query)
            : base("serviceLevelAgreementUpdate", "ServiceLevelAgreementUpdateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(ServiceLevelAgreementQuery query)
        {
            query.FieldName = "serviceLevelAgreement";
            query.IsConnection = false;
            return new HashSet<IQuery>() {query};
        }
    }
}
