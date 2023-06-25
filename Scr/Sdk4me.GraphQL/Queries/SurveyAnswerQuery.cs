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
        /// The account this record belongs to.
        /// </summary>
        public SurveyAnswerQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Question this answer is for.
        /// </summary>
        public SurveyAnswerQuery SelectQuestion(SurveyQuestionQuery query)
        {
            query.FieldName = "question";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Survey response the answer is part of.
        /// </summary>
        public SurveyAnswerQuery SelectSurveyResponse(SurveyResponseQuery query)
        {
            query.FieldName = "surveyResponse";
            query.IsConnection = false;
            return Select(query);
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
