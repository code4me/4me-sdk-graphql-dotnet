namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing service level agreement notification scheme.
    /// </summary>
    internal class SlaNotificationSchemeUpdateMutation : Mutation<SlaNotificationSchemeUpdatePayload, SlaNotificationSchemeUpdateInput>
    {
        /// <summary>
        /// Initialize an new SlaNotificationSchemeUpdate mutation instance.
        /// </summary>
        internal SlaNotificationSchemeUpdateMutation(SlaNotificationSchemeUpdateInput data)
            : base("slaNotificationSchemeUpdate", "SlaNotificationSchemeUpdateInput!", data, new HashSet<IQuery>() { new SlaNotificationSchemeQuery() { FieldName = "slaNotificationScheme", IsConnection = false }.Select("*") })
        {
        }
    }
}
