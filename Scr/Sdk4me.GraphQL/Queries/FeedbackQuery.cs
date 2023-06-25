namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="Feedback">Feedback</see> query.
    /// </summary>
    public class FeedbackQuery : Query<FeedbackQuery, FeedbackField, DefaultView, DefaultOrderField>
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
        public FeedbackQuery SelectRequestedBy(FeedbackUrlsQuery query)
        {
            query.FieldName = "requestedBy";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// URLs to capture feedback from the person for whom the request was submitted, if that was not the submitter of the request.
        /// </summary>
        public FeedbackQuery SelectRequestedFor(FeedbackUrlsQuery query)
        {
            query.FieldName = "requestedFor";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
