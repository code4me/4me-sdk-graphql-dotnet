namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new configuration item. **Important**: To facilitate integrations with discovery tools, the create is treated as an update in case the provided <c>name</c> or <c>label</c> is already used by an inactive CI in the same account.
    /// </summary>
    internal class ConfigurationItemCreateMutation : Mutation<ConfigurationItemCreatePayload, ConfigurationItemCreateInput>
    {
        /// <summary>
        /// Initialize an new ConfigurationItemCreate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The repsonse query.</param>
        internal ConfigurationItemCreateMutation(ConfigurationItemCreateInput data, ConfigurationItemQuery query)
            : base("configurationItemCreate", "ConfigurationItemCreateInput!", data, GetQuery(query))
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
