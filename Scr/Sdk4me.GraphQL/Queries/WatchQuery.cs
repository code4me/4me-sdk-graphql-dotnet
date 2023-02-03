namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="Watch">Watch</see> query.
    /// </summary>
    public class WatchQuery : Query<WatchQuery, WatchField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new watch query instance.
        /// </summary>
        public WatchQuery()
            : base("", typeof(Watch), true)
        {
        }
    }
}
