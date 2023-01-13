namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="HasAutomationRules">HasAutomationRules</see> query.
    /// </summary>
    public class HasAutomationRulesQuery : Query<HasAutomationRulesQuery, HasAutomationRulesField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new has automation rules query instance.
        /// </summary>
        public HasAutomationRulesQuery()
            : base("", typeof(HasAutomationRules), false)
        {
        }

        /// <summary>
        /// Automation rules associated with this record.
        /// </summary>
        public HasAutomationRulesQuery SelectAutomationRules(AutomationRuleQuery query)
        {
            query.FieldName = "automationRules";
            return Select(query);
        }
    }
}
