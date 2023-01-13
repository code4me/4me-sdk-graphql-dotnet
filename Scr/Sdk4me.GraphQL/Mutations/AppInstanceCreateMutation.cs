namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new application instance.
    /// </summary>
    internal class AppInstanceCreateMutation : Mutation<AppInstanceCreatePayload, AppInstanceCreateInput>
    {
        /// <summary>
        /// Initialize an new AppInstanceCreate mutation instance.
        /// </summary>
        internal AppInstanceCreateMutation(AppInstanceCreateInput data)
            : base("appInstanceCreate", "AppInstanceCreateInput!", data, new HashSet<IQuery>() { new AppInstanceQuery() { FieldName = "appInstance", IsConnection = false }.Select("*") })
        {
        }
    }
}
