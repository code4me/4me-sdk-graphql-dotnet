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
        /// Initialize a new sla notification scheme query instance.
        /// <br>Additional filters and views will be ignored.</br>
        /// </summary>
        /// <param name="id">The ID of the sla notification scheme.</param>
        public SlaNotificationSchemeQuery(string id)
            : base("SlaNotificationScheme", id, typeof(SlaNotificationScheme), false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public SlaNotificationSchemeQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Rules of the SLA notification scheme.
        /// </summary>
        /// <param name="query">The sla notification rule query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public SlaNotificationSchemeQuery SelectSlaNotificationRules(SlaNotificationRuleQuery query)
        {
            query.FieldName = "slaNotificationRules";
            return Select(query);
        }
    }
}
