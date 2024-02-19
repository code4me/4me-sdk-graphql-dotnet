namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing configuration item.
    /// </summary>
    internal class ConfigurationItemUpdateMutation : Mutation<ConfigurationItemUpdatePayload, ConfigurationItemUpdateInput>
    {
        /// <summary>
        /// Initialize an new ConfigurationItemUpdate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal ConfigurationItemUpdateMutation(ConfigurationItemUpdateInput data, ConfigurationItemQuery query)
            : base("configurationItemUpdate", "ConfigurationItemUpdateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(ConfigurationItemQuery query)
        {
            query.FieldName = "configurationItem";
            query.IsConnection = false;
            return new HashSet<IQuery>() {query};
        }
    }
}
