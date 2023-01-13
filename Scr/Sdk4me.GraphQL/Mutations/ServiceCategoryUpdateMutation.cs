namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing service category.
    /// </summary>
    internal class ServiceCategoryUpdateMutation : Mutation<ServiceCategoryUpdatePayload, ServiceCategoryUpdateInput>
    {
        /// <summary>
        /// Initialize an new ServiceCategoryUpdate mutation instance.
        /// </summary>
        internal ServiceCategoryUpdateMutation(ServiceCategoryUpdateInput data)
            : base("serviceCategoryUpdate", "ServiceCategoryUpdateInput!", data, new HashSet<IQuery>() { new ServiceCategoryQuery() { FieldName = "serviceCategory", IsConnection = false }.Select("*") })
        {
        }
    }
}
