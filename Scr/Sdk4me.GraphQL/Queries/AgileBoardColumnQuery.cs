namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="AgileBoardColumn">AgileBoardColumn</see> query.
    /// </summary>
    public class AgileBoardColumnQuery : Query<AgileBoardColumnQuery, AgileBoardColumnField, DefaultView, DefaultFilter, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new agile board column query instance.
        /// </summary>
        public AgileBoardColumnQuery()
            : base("", typeof(AgileBoardColumn), true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public AgileBoardColumnQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Agile board the column is part of.
        /// </summary>
        /// <param name="query">The agile board query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public AgileBoardColumnQuery SelectAgileBoard(AgileBoardQuery query)
        {
            query.FieldName = "agileBoard";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Items in this column.
        /// </summary>
        /// <param name="query">The agile board item query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public AgileBoardColumnQuery SelectItems(AgileBoardItemQuery query)
        {
            query.FieldName = "items";
            return Select(query);
        }

        /// <summary>
        /// Person to assign the item to when action type is <c>assign</c> and an item is added to this column.
        /// </summary>
        /// <param name="query">The person query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public AgileBoardColumnQuery SelectMember(PersonQuery query)
        {
            query.FieldName = "member";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Team to assign the item to when action type is <c>assign</c> and an item is added to this column.
        /// </summary>
        /// <param name="query">The team query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public AgileBoardColumnQuery SelectTeam(TeamQuery query)
        {
            query.FieldName = "team";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
