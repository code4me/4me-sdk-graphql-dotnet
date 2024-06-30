namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving Survey records.
    /// </summary>
    public class SurveyQuery : Query<SurveyQuery, SurveyField, SurveyView, SurveyFilter, SurveyOrderField>
    {
        /// <summary>
        /// Initialize a new survey query instance.
        /// </summary>
        public SurveyQuery()
            : base("surveys", typeof(Survey), true)
        {
        }

        /// <summary>
        /// Initialize a new survey query instance.
        /// <br>Additional filters and views will be ignored.</br>
        /// </summary>
        /// <param name="id">The ID of the survey.</param>
        public SurveyQuery(string id)
            : base("Survey", id, typeof(Survey), false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public SurveyQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Files and inline images linked to the Completion field.
        /// </summary>
        /// <param name="query">The attachment query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public SurveyQuery SelectCompletionAttachments(AttachmentQuery query)
        {
            query.FieldName = "completionAttachments";
            return Select(query);
        }

        /// <summary>
        /// Files and inline images linked to the Introduction field.
        /// </summary>
        /// <param name="query">The attachment query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public SurveyQuery SelectIntroductionAttachments(AttachmentQuery query)
        {
            query.FieldName = "introductionAttachments";
            return Select(query);
        }

        /// <summary>
        /// Questions of this survey.
        /// </summary>
        /// <param name="query">The survey question query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public SurveyQuery SelectQuestions(SurveyQuestionQuery query)
        {
            query.FieldName = "questions";
            return Select(query);
        }

        /// <summary>
        /// Translations associated with this object.
        /// </summary>
        /// <param name="query">The translation query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public SurveyQuery SelectTranslations(TranslationQuery query)
        {
            query.FieldName = "translations";
            return Select(query);
        }
    }
}
