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
        internal ServiceOfferingUpdateMutation(ServiceOfferingUpdateInput data)
            : base("serviceOfferingUpdate", "ServiceOfferingUpdateInput!", data, new HashSet<IQuery>() { new ServiceOfferingQuery() { FieldName = "serviceOffering", IsConnection = false }.Select("*") })
        {
        }
    }
}
