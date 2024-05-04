using System.Collections.Generic;

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
        /// <param name="data">The input data.</param>
        /// <param name="query">The app offering automation rule response query.</param>
        internal AppOfferingAutomationRuleCreateMutation(AppOfferingAutomationRuleCreateInput data, AppOfferingAutomationRuleQuery query)
            : base("appOfferingAutomationRuleCreate", "AppOfferingAutomationRuleCreateInput!", data, GetQuery(query))
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
