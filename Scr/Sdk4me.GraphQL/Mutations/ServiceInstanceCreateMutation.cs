namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new service instance.
    /// </summary>
    internal class ServiceInstanceCreateMutation : Mutation<ServiceInstanceCreatePayload, ServiceInstanceCreateInput>
    {
        /// <summary>
        /// Initialize an new ServiceInstanceCreate mutation instance.
        /// </summary>
        internal ServiceInstanceCreateMutation(ServiceInstanceCreateInput data)
            : base("serviceInstanceCreate", "ServiceInstanceCreateInput!", data, new HashSet<IQuery>() { new ServiceInstanceQuery() { FieldName = "serviceInstance", IsConnection = false }.Select("*") })
        {
        }
    }
}
