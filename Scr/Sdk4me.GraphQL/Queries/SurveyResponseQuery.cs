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
        /// Answers of this survey response.
        /// </summary>
        public SurveyResponseQuery SelectAnswers(SurveyAnswerQuery query)
        {
            query.FieldName = "answers";
            return Select(query);
        }

        /// <summary>
        /// Service level agreements of this survey response.
        /// </summary>
        public SurveyResponseQuery SelectSlas(ServiceLevelAgreementQuery query)
        {
            query.FieldName = "slas";
            return Select(query);
        }
    }
}
