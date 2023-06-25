namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="FeedbackUrls">FeedbackUrls</see> query.
    /// </summary>
    public class FeedbackUrlsQuery : Query<FeedbackUrlsQuery, FeedbackUrlsField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new feedback urls query instance.
        /// </summary>
        public FeedbackUrlsQuery()
            : base("", typeof(FeedbackUrls), false)
        {
        }
    }
}
