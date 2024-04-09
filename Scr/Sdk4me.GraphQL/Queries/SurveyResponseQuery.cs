namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving SurveyResponse records.
    /// </summary>
    public class SurveyResponseQuery : Query<SurveyResponseQuery, SurveyResponseField, SurveyResponseView, SurveyResponseOrderField>
    {
        /// <summary>
        /// Initialize a new survey response query instance.
        /// </summary>
        public SurveyResponseQuery()
            : base("surveyResponses", typeof(SurveyResponse), true)
        {
        }

        /// <summary>
        /// Initialize a new survey response query instance.
        /// <br>Additional filters and views will be ignored.</br>
        /// </summary>
        /// <param name="id">The ID of the survey response.</param>
        public SurveyResponseQuery(string id)
            : base("SurveyResponse", id, typeof(SurveyResponse), false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public SurveyResponseQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Answers of this survey response.
        /// </summary>
        /// <param name="query">The survey answer query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public SurveyResponseQuery SelectAnswers(SurveyAnswerQuery query)
        {
            query.FieldName = "answers";
            return Select(query);
        }

        /// <summary>
        /// Service this response is about.
        /// </summary>
        /// <param name="query">The service query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public SurveyResponseQuery SelectService(ServiceQuery query)
        {
            query.FieldName = "service";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// SLAs of this survey response.
        /// </summary>
        /// <param name="query">The service level agreement query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public SurveyResponseQuery SelectSlas(ServiceLevelAgreementQuery query)
        {
            query.FieldName = "slas";
            return Select(query);
        }

        /// <summary>
        /// Survey this response is for.
        /// </summary>
        /// <param name="query">The survey query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public SurveyResponseQuery SelectSurvey(SurveyQuery query)
        {
            query.FieldName = "survey";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
