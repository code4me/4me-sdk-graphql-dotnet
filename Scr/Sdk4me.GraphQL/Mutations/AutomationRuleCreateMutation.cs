namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new automation rule.
    /// </summary>
    internal class AutomationRuleCreateMutation : Mutation<AutomationRuleCreatePayload, AutomationRuleCreateInput>
    {
        /// <summary>
        /// Initialize an new AutomationRuleCreate mutation instance.
        /// </summary>
        internal AutomationRuleCreateMutation(AutomationRuleCreateInput data)
            : base("automationRuleCreate", "AutomationRuleCreateInput!", data, new HashSet<IQuery>() { new AutomationRuleQuery() { FieldName = "automationRule", IsConnection = false }.Select("*") })
        {
        }
    }
}
