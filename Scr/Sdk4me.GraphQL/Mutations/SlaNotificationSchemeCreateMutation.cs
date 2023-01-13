namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new service level agreement notification scheme.
    /// </summary>
    internal class SlaNotificationSchemeCreateMutation : Mutation<SlaNotificationSchemeCreatePayload, SlaNotificationSchemeCreateInput>
    {
        /// <summary>
        /// Initialize an new SlaNotificationSchemeCreate mutation instance.
        /// </summary>
        internal SlaNotificationSchemeCreateMutation(SlaNotificationSchemeCreateInput data)
            : base("slaNotificationSchemeCreate", "SlaNotificationSchemeCreateInput!", data, new HashSet<IQuery>() { new SlaNotificationSchemeQuery() { FieldName = "slaNotificationScheme", IsConnection = false }.Select("*") })
        {
        }
    }
}
