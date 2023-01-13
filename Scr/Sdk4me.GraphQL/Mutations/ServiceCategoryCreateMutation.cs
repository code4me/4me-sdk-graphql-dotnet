namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new service category.
    /// </summary>
    internal class ServiceCategoryCreateMutation : Mutation<ServiceCategoryCreatePayload, ServiceCategoryCreateInput>
    {
        /// <summary>
        /// Initialize an new ServiceCategoryCreate mutation instance.
        /// </summary>
        internal ServiceCategoryCreateMutation(ServiceCategoryCreateInput data)
            : base("serviceCategoryCreate", "ServiceCategoryCreateInput!", data, new HashSet<IQuery>() { new ServiceCategoryQuery() { FieldName = "serviceCategory", IsConnection = false }.Select("*") })
        {
        }
    }
}
