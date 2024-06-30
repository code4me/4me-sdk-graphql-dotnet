namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="Feedback">Feedback</see> query.
    /// </summary>
    public class FeedbackQuery : Query<FeedbackQuery, FeedbackField, DefaultView, DefaultFilter, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new feedback query instance.
        /// </summary>
        public FeedbackQuery()
            : base("", typeof(Feedback), false)
        {
        }

        /// <summary>
        /// URLs to capture feedback from the person who submitted the request.
        /// </summary>
        /// <param name="query">The feedback urls query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public FeedbackQuery SelectRequestedBy(FeedbackUrlsQuery query)
        {
            query.FieldName = "requestedBy";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// URLs to capture feedback from the person for whom the request was submitted, if that was not the submitter of the request.
        /// </summary>
        /// <param name="query">The feedback urls query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public FeedbackQuery SelectRequestedFor(FeedbackUrlsQuery query)
        {
            query.FieldName = "requestedFor";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
