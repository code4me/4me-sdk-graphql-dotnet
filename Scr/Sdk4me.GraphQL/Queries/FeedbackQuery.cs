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
    }
}
