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
        /// <param name="data">The input data.</param>
        /// <param name="query">The app offering automation rule response query.</param>
        internal AppOfferingAutomationRuleUpdateMutation(AppOfferingAutomationRuleUpdateInput data, AppOfferingAutomationRuleQuery query)
            : base("appOfferingAutomationRuleUpdate", "AppOfferingAutomationRuleUpdateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The app offering automation rule response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(AppOfferingAutomationRuleQuery query)
        {
            query.FieldName = "appOfferingAutomationRule";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
