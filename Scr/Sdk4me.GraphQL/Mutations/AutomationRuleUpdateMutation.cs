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
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal AutomationRuleUpdateMutation(AutomationRuleUpdateInput data, AutomationRuleQuery query)
            : base("automationRuleUpdate", "AutomationRuleUpdateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(AutomationRuleQuery query)
        {
            query.FieldName = "automationRule";
            query.IsConnection = false;
            return new HashSet<IQuery>() {query};
        }
    }
}
