namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new survey response.
    /// </summary>
    internal class SurveyResponseCreateMutation : Mutation<SurveyResponseCreatePayload, SurveyResponseCreateInput>
    {
        /// <summary>
        /// Initialize an new SurveyResponseCreate mutation instance.
        /// </summary>
        internal SurveyResponseCreateMutation(SurveyResponseCreateInput data)
            : base("surveyResponseCreate", "SurveyResponseCreateInput!", data, new HashSet<IQuery>() { new SurveyResponseQuery() { FieldName = "surveyResponse", IsConnection = false }.Select("*") })
        {
        }
    }
}
