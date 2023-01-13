namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new survey.
    /// </summary>
    internal class SurveyCreateMutation : Mutation<SurveyCreatePayload, SurveyCreateInput>
    {
        /// <summary>
        /// Initialize an new SurveyCreate mutation instance.
        /// </summary>
        internal SurveyCreateMutation(SurveyCreateInput data)
            : base("surveyCreate", "SurveyCreateInput!", data, new HashSet<IQuery>() { new SurveyQuery() { FieldName = "survey", IsConnection = false }.Select("*") })
        {
        }
    }
}
