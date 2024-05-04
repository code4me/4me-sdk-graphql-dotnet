using System.Collections.Generic;

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
        /// <param name="data">The input data.</param>
        /// <param name="query">The automation rule response query.</param>
        internal AutomationRuleCreateMutation(AutomationRuleCreateInput data, AutomationRuleQuery query)
            : base("automationRuleCreate", "AutomationRuleCreateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The automation rule response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(AutomationRuleQuery query)
        {
            query.FieldName = "automationRule";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
