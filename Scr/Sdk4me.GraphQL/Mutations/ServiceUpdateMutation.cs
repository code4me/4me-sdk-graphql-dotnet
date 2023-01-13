namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing service.
    /// </summary>
    internal class ServiceUpdateMutation : Mutation<ServiceUpdatePayload, ServiceUpdateInput>
    {
        /// <summary>
        /// Initialize an new ServiceUpdate mutation instance.
        /// </summary>
        internal ServiceUpdateMutation(ServiceUpdateInput data)
            : base("serviceUpdate", "ServiceUpdateInput!", data, new HashSet<IQuery>() { new ServiceQuery() { FieldName = "service", IsConnection = false }.Select("*") })
        {
        }
    }
}
