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
        internal ServiceOfferingCreateMutation(ServiceOfferingCreateInput data)
            : base("serviceOfferingCreate", "ServiceOfferingCreateInput!", data, new HashSet<IQuery>() { new ServiceOfferingQuery() { FieldName = "serviceOffering", IsConnection = false }.Select("*") })
        {
        }
    }
}
