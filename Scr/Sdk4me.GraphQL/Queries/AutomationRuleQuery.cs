namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving AutomationRule records.
    /// </summary>
    public class AutomationRuleQuery : Query<AutomationRuleQuery, AutomationRuleField, AutomationRuleView, AutomationRuleOrderField>
    {
        /// <summary>
        /// Initialize a new automation rule query instance.
        /// </summary>
        public AutomationRuleQuery()
            : base("automationRules", typeof(AutomationRule), true)
        {
        }

        /// <summary>
        /// The record that the automation rule is linked to.
        /// </summary>
        public AutomationRuleQuery SelectOwner(HasAutomationRulesQuery query)
        {
            query.FieldName = "owner";
            return Select(query);
        }
    }
}
