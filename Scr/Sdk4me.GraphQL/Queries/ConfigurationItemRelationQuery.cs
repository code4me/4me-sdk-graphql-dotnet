namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="ConfigurationItemRelation">ConfigurationItemRelation</see> query.
    /// </summary>
    public class ConfigurationItemRelationQuery : Query<ConfigurationItemRelationQuery, ConfigurationItemRelationField, DefaultView, DefaultFilter, DefaultOrderField>
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
        /// <param name="query">The configuration item query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ConfigurationItemRelationQuery SelectConfigurationItem(ConfigurationItemQuery query)
        {
            query.FieldName = "configurationItem";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
