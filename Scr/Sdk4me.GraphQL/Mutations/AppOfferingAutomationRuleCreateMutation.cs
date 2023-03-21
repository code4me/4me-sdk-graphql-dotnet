namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new app offering automation rule.
    /// </summary>
    internal class AppOfferingAutomationRuleCreateMutation : Mutation<AppOfferingAutomationRuleCreatePayload, AppOfferingAutomationRuleCreateInput>
    {
        /// <summary>
        /// Initialize an new AppOfferingAutomationRuleCreate mutation instance.
        /// </summary>
        internal AppOfferingAutomationRuleCreateMutation(AppOfferingAutomationRuleCreateInput data)
            : base("appOfferingAutomationRuleCreate", "AppOfferingAutomationRuleCreateInput!", data, new HashSet<IQuery>() { new AppOfferingAutomationRuleQuery() { FieldName = "appOfferingAutomationRule", IsConnection = false }.Select("*") })
        {
        }
    }
}
