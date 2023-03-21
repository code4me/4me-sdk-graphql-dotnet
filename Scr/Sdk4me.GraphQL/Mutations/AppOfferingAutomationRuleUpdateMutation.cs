namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing app offering automation rule.
    /// </summary>
    internal class AppOfferingAutomationRuleUpdateMutation : Mutation<AppOfferingAutomationRuleUpdatePayload, AppOfferingAutomationRuleUpdateInput>
    {
        /// <summary>
        /// Initialize an new AppOfferingAutomationRuleUpdate mutation instance.
        /// </summary>
        internal AppOfferingAutomationRuleUpdateMutation(AppOfferingAutomationRuleUpdateInput data)
            : base("appOfferingAutomationRuleUpdate", "AppOfferingAutomationRuleUpdateInput!", data, new HashSet<IQuery>() { new AppOfferingAutomationRuleQuery() { FieldName = "appOfferingAutomationRule", IsConnection = false }.Select("*") })
        {
        }
    }
}
