namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="Watch">Watch</see> query.
    /// </summary>
    public class WatchQuery : Query<WatchQuery, WatchField, DefaultView, DefaultFilter, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new watch query instance.
        /// </summary>
        public WatchQuery()
            : base("", typeof(Watch), true)
        {
        }

        /// <summary>
        /// The person who added this watch.
        /// </summary>
        /// <param name="query">The person query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public WatchQuery SelectAddedBy(PersonQuery query)
        {
            query.FieldName = "addedBy";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The person who is watching the record.
        /// </summary>
        /// <param name="query">The person query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public WatchQuery SelectPerson(PersonQuery query)
        {
            query.FieldName = "person";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
