namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving SlaNotificationScheme records.
    /// </summary>
    public class SlaNotificationSchemeQuery : Query<SlaNotificationSchemeQuery, SlaNotificationSchemeField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new sla notification scheme query instance.
        /// </summary>
        public SlaNotificationSchemeQuery()
            : base("slaNotificationSchemes", typeof(SlaNotificationScheme), true)
        {
        }

        /// <summary>
        /// Rules of the SLA notification scheme.
        /// </summary>
        public SlaNotificationSchemeQuery SelectSlaNotificationRules(SlaNotificationRuleQuery query)
        {
            query.FieldName = "slaNotificationRules";
            return Select(query);
        }
    }
}
