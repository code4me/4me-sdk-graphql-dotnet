namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="SurveyAnswer">SurveyAnswer</see> query.
    /// </summary>
    public class SurveyAnswerQuery : Query<SurveyAnswerQuery, SurveyAnswerField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new survey answer query instance.
        /// </summary>
        public SurveyAnswerQuery()
            : base("", typeof(SurveyAnswer), true)
        {
        }

        /// <summary>
        /// Files and inline images linked to the Text field.
        /// </summary>
        public SurveyAnswerQuery SelectTextAttachments(AttachmentQuery query)
        {
            query.FieldName = "textAttachments";
            return Select(query);
        }
    }
}
