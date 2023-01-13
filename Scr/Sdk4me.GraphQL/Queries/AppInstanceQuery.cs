namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving AppInstance records.
    /// </summary>
    public class AppInstanceQuery : Query<AppInstanceQuery, AppInstanceField, AppInstanceView, AppInstanceOrderField>
    {
        /// <summary>
        /// Initialize a new application instance query instance.
        /// </summary>
        public AppInstanceQuery()
            : base("appInstances", typeof(AppInstance), true)
        {
        }

        /// <summary>
        /// Automation rules of this instance.
        /// </summary>
        public AppInstanceQuery SelectAutomationRules(AutomationRuleQuery query)
        {
            query.FieldName = "automationRules";
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        public AppInstanceQuery SelectCustomFieldsAttachments(AttachmentQuery query)
        {
            query.FieldName = "customFieldsAttachments";
            return Select(query);
        }
    }
}
