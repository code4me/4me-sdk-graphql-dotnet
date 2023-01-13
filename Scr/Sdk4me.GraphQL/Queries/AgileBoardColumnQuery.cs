namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="AgileBoardColumn">AgileBoardColumn</see> query.
    /// </summary>
    public class AgileBoardColumnQuery : Query<AgileBoardColumnQuery, AgileBoardColumnField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new agile board column query instance.
        /// </summary>
        public AgileBoardColumnQuery()
            : base("", typeof(AgileBoardColumn), true)
        {
        }

        /// <summary>
        /// Items in this column.
        /// </summary>
        public AgileBoardColumnQuery SelectItems(AgileBoardItemQuery query)
        {
            query.FieldName = "items";
            return Select(query);
        }
    }
}
