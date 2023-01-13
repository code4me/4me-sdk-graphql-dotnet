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
        internal ServiceLevelAgreementCreateMutation(ServiceLevelAgreementCreateInput data)
            : base("serviceLevelAgreementCreate", "ServiceLevelAgreementCreateInput!", data, new HashSet<IQuery>() { new ServiceLevelAgreementQuery() { FieldName = "serviceLevelAgreement", IsConnection = false }.Select("*") })
        {
        }
    }
}
