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
        internal ConfigurationItemUpdateMutation(ConfigurationItemUpdateInput data)
            : base("configurationItemUpdate", "ConfigurationItemUpdateInput!", data, new HashSet<IQuery>() { new ConfigurationItemQuery() { FieldName = "configurationItem", IsConnection = false }.Select("*") })
        {
        }
    }
}
