namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="SurveyAnswer">SurveyAnswer</see> query.
    /// </summary>
    public class SurveyAnswerQuery : Query<SurveyAnswerQuery, SurveyAnswerField, DefaultView, DefaultFilter, DefaultOrderField>
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
        /// <param name="query">The account query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public SurveyAnswerQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Question this answer is for.
        /// </summary>
        /// <param name="query">The survey question query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public SurveyAnswerQuery SelectQuestion(SurveyQuestionQuery query)
        {
            query.FieldName = "question";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Survey response the answer is part of.
        /// </summary>
        /// <param name="query">The survey response query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public SurveyAnswerQuery SelectSurveyResponse(SurveyResponseQuery query)
        {
            query.FieldName = "surveyResponse";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Files and inline images linked to the Text field.
        /// </summary>
        /// <param name="query">The attachment query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public SurveyAnswerQuery SelectTextAttachments(AttachmentQuery query)
        {
            query.FieldName = "textAttachments";
            return Select(query);
        }
    }
}
