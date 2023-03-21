namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing app instance.
    /// </summary>
    internal class AppInstanceUpdateMutation : Mutation<AppInstanceUpdatePayload, AppInstanceUpdateInput>
    {
        /// <summary>
        /// Initialize an new AppInstanceUpdate mutation instance.
        /// </summary>
        internal AppInstanceUpdateMutation(AppInstanceUpdateInput data)
            : base("appInstanceUpdate", "AppInstanceUpdateInput!", data, new HashSet<IQuery>() { new AppInstanceQuery() { FieldName = "appInstance", IsConnection = false }.Select("*") })
        {
        }
    }
}
