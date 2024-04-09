﻿namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="AgileBoardItem">AgileBoardItem</see> query.
    /// </summary>
    public class AgileBoardItemQuery : Query<AgileBoardItemQuery, AgileBoardItemField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new agile board item query instance.
        /// </summary>
        public AgileBoardItemQuery()
            : base("", typeof(AgileBoardItem), true)
        {
        }

        /// <summary>
        /// Board this item is placed on.
        /// </summary>
        /// <param name="query">The agile board query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public AgileBoardItemQuery SelectAgileBoard(AgileBoardQuery query)
        {
            query.FieldName = "agileBoard";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Column this item is placed in.
        /// </summary>
        /// <param name="query">The agile board column query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public AgileBoardItemQuery SelectAgileBoardColumn(AgileBoardColumnQuery query)
        {
            query.FieldName = "agileBoardColumn";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
