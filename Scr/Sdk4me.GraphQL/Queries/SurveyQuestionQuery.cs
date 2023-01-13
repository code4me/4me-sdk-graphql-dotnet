namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="SurveyQuestion">SurveyQuestion</see> query.
    /// </summary>
    public class SurveyQuestionQuery : Query<SurveyQuestionQuery, SurveyQuestionField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new survey question query instance.
        /// </summary>
        public SurveyQuestionQuery()
            : base("", typeof(SurveyQuestion), true)
        {
        }

        /// <summary>
        /// Files and inline images linked to the Guidance field.
        /// </summary>
        public SurveyQuestionQuery SelectGuidanceAttachments(AttachmentQuery query)
        {
            query.FieldName = "guidanceAttachments";
            return Select(query);
        }
    }
}
