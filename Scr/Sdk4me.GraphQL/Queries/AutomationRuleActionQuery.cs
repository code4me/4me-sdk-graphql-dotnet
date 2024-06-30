namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="AutomationRuleAction">AutomationRuleAction</see> query.
    /// </summary>
    public class AutomationRuleActionQuery : Query<AutomationRuleActionQuery, AutomationRuleActionField, DefaultView, DefaultFilter, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new automation rule action query instance.
        /// </summary>
        public AutomationRuleActionQuery()
            : base("", typeof(AutomationRuleAction), false)
        {
        }
    }
}
