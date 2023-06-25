namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving Survey records.
    /// </summary>
    public class SurveyQuery : Query<SurveyQuery, SurveyField, SurveyView, SurveyOrderField>
    {
        /// <summary>
        /// Initialize a new survey query instance.
        /// </summary>
        public SurveyQuery()
            : base("surveys", typeof(Survey), true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        public SurveyQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Files and inline images linked to the Completion field.
        /// </summary>
        public SurveyQuery SelectCompletionAttachments(AttachmentQuery query)
        {
            query.FieldName = "completionAttachments";
            return Select(query);
        }

        /// <summary>
        /// Files and inline images linked to the Introduction field.
        /// </summary>
        public SurveyQuery SelectIntroductionAttachments(AttachmentQuery query)
        {
            query.FieldName = "introductionAttachments";
            return Select(query);
        }

        /// <summary>
        /// Questions of this survey.
        /// </summary>
        public SurveyQuery SelectQuestions(SurveyQuestionQuery query)
        {
            query.FieldName = "questions";
            return Select(query);
        }
    }
}
