namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="AutomationRuleExpression">AutomationRuleExpression</see> query.
    /// </summary>
    public class AutomationRuleExpressionQuery : Query<AutomationRuleExpressionQuery, AutomationRuleExpressionField, DefaultView, DefaultFilter, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new automation rule expression query instance.
        /// </summary>
        public AutomationRuleExpressionQuery()
            : base("", typeof(AutomationRuleExpression), false)
        {
        }
    }
}
