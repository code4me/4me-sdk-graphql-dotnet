namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="AppOfferingAutomationRule">AppOfferingAutomationRule</see> query.
    /// </summary>
    public class AppOfferingAutomationRuleQuery : Query<AppOfferingAutomationRuleQuery, AppOfferingAutomationRuleField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new application offering automation rule query instance.
        /// </summary>
        public AppOfferingAutomationRuleQuery()
            : base("", typeof(AppOfferingAutomationRule), true)
        {
        }
    }
}
