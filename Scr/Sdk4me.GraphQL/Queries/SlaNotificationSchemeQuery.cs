namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving SlaNotificationScheme records.
    /// </summary>
    public class SlaNotificationSchemeQuery : Query<SlaNotificationSchemeQuery, SlaNotificationSchemeField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new service level agreement notification scheme query instance.
        /// </summary>
        public SlaNotificationSchemeQuery()
            : base("slaNotificationSchemes", typeof(SlaNotificationScheme), true)
        {
        }

        /// <summary>
        /// Rules of the service level agreement notification scheme.
        /// </summary>
        public SlaNotificationSchemeQuery SelectSlaNotificationRules(SlaNotificationRuleQuery query)
        {
            query.FieldName = "slaNotificationRules";
            return Select(query);
        }
    }
}
