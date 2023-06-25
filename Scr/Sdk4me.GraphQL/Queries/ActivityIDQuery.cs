namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="ActivityID">ActivityID</see> query.
    /// </summary>
    public class ActivityIDQuery : Query<ActivityIDQuery, ActivityIDField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new activity id query instance.
        /// </summary>
        public ActivityIDQuery()
            : base("", typeof(ActivityID), false)
        {
        }
    }
}
