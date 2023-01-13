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
        internal ServiceLevelAgreementUpdateMutation(ServiceLevelAgreementUpdateInput data)
            : base("serviceLevelAgreementUpdate", "ServiceLevelAgreementUpdateInput!", data, new HashSet<IQuery>() { new ServiceLevelAgreementQuery() { FieldName = "serviceLevelAgreement", IsConnection = false }.Select("*") })
        {
        }
    }
}
