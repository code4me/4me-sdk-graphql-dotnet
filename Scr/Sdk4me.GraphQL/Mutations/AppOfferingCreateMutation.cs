namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new app offering.
    /// </summary>
    internal class AppOfferingCreateMutation : Mutation<AppOfferingCreatePayload, AppOfferingCreateInput>
    {
        /// <summary>
        /// Initialize an new AppOfferingCreate mutation instance.
        /// </summary>
        internal AppOfferingCreateMutation(AppOfferingCreateInput data)
            : base("appOfferingCreate", "AppOfferingCreateInput!", data, new HashSet<IQuery>() { new AppOfferingQuery() { FieldName = "appOffering", IsConnection = false }.Select("*") })
        {
        }
    }
}
