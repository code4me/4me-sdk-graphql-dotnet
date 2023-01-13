namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing service instance.
    /// </summary>
    internal class ServiceInstanceUpdateMutation : Mutation<ServiceInstanceUpdatePayload, ServiceInstanceUpdateInput>
    {
        /// <summary>
        /// Initialize an new ServiceInstanceUpdate mutation instance.
        /// </summary>
        internal ServiceInstanceUpdateMutation(ServiceInstanceUpdateInput data)
            : base("serviceInstanceUpdate", "ServiceInstanceUpdateInput!", data, new HashSet<IQuery>() { new ServiceInstanceQuery() { FieldName = "serviceInstance", IsConnection = false }.Select("*") })
        {
        }
    }
}
