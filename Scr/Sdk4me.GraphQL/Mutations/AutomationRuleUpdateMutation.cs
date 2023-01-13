namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing automation rule.
    /// </summary>
    internal class AutomationRuleUpdateMutation : Mutation<AutomationRuleUpdatePayload, AutomationRuleUpdateInput>
    {
        /// <summary>
        /// Initialize an new AutomationRuleUpdate mutation instance.
        /// </summary>
        internal AutomationRuleUpdateMutation(AutomationRuleUpdateInput data)
            : base("automationRuleUpdate", "AutomationRuleUpdateInput!", data, new HashSet<IQuery>() { new AutomationRuleQuery() { FieldName = "automationRule", IsConnection = false }.Select("*") })
        {
        }
    }
}
