namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="AppOfferingAutomationRule">AppOfferingAutomationRule</see> query.
    /// </summary>
    public class AppOfferingAutomationRuleQuery : Query<AppOfferingAutomationRuleQuery, AppOfferingAutomationRuleField, DefaultView, DefaultFilter, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new app offering automation rule query instance.
        /// </summary>
        public AppOfferingAutomationRuleQuery()
            : base("", typeof(AppOfferingAutomationRule), true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public AppOfferingAutomationRuleQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The Actions field is used to define actions that should be executed when the condition of the automation rule is met.
        /// </summary>
        /// <param name="query">The automation rule action query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public AppOfferingAutomationRuleQuery SelectActions(AutomationRuleActionQuery query)
        {
            query.FieldName = "actions";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// AppOffering this rule belongs to.
        /// </summary>
        /// <param name="query">The app offering query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public AppOfferingAutomationRuleQuery SelectAppOffering(AppOfferingQuery query)
        {
            query.FieldName = "appOffering";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The Expressions field is used to define expressions that can subsequently be used to define the rule's conditions and the update action(s) that the rule is to perform.
        /// </summary>
        /// <param name="query">The automation rule expression query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public AppOfferingAutomationRuleQuery SelectExpressions(AutomationRuleExpressionQuery query)
        {
            query.FieldName = "expressions";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
