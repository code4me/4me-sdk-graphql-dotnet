namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new service.
    /// </summary>
    internal class ServiceCreateMutation : Mutation<ServiceCreatePayload, ServiceCreateInput>
    {
        /// <summary>
        /// Initialize an new ServiceCreate mutation instance.
        /// </summary>
        internal ServiceCreateMutation(ServiceCreateInput data)
            : base("serviceCreate", "ServiceCreateInput!", data, new HashSet<IQuery>() { new ServiceQuery() { FieldName = "service", IsConnection = false }.Select("*") })
        {
        }
    }
}
