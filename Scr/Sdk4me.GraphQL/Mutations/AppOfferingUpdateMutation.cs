namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing application offering.
    /// </summary>
    internal class AppOfferingUpdateMutation : Mutation<AppOfferingUpdatePayload, AppOfferingUpdateInput>
    {
        /// <summary>
        /// Initialize an new AppOfferingUpdate mutation instance.
        /// </summary>
        internal AppOfferingUpdateMutation(AppOfferingUpdateInput data)
            : base("appOfferingUpdate", "AppOfferingUpdateInput!", data, new HashSet<IQuery>() { new AppOfferingQuery() { FieldName = "appOffering", IsConnection = false }.Select("*") })
        {
        }
    }
}
