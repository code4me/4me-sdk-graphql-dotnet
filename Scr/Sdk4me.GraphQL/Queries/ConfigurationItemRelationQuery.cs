namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="ConfigurationItemRelation">ConfigurationItemRelation</see> query.
    /// </summary>
    public class ConfigurationItemRelationQuery : Query<ConfigurationItemRelationQuery, ConfigurationItemRelationField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new configuration item relation query instance.
        /// </summary>
        public ConfigurationItemRelationQuery()
            : base("", typeof(ConfigurationItemRelation), true)
        {
        }

        /// <summary>
        /// Related configuration item.
        /// </summary>
        public ConfigurationItemRelationQuery SelectConfigurationItem(ConfigurationItemQuery query)
        {
            query.FieldName = "configurationItem";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
