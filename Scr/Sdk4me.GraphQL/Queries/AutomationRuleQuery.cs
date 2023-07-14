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
        /// Initialize a new automation rule query instance.
        /// <br>Additional filters and views will be ignored.</br>
        /// </summary>
        /// <param name="id">The ID of the automation rule.</param>
        public AutomationRuleQuery(string id)
            : base("AutomationRule", id, typeof(AutomationRule), false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        public AutomationRuleQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The Actions field is used to define actions that should be executed when the condition of the automation rule is met.
        /// </summary>
        public AutomationRuleQuery SelectActions(AutomationRuleActionQuery query)
        {
            query.FieldName = "actions";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The Expressions field is used to define expressions that can subsequently be used to define the rule's conditions and the update action(s) that the rule is to perform.
        /// </summary>
        public AutomationRuleQuery SelectExpressions(AutomationRuleExpressionQuery query)
        {
            query.FieldName = "expressions";
            query.IsConnection = false;
            return Select(query);
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
