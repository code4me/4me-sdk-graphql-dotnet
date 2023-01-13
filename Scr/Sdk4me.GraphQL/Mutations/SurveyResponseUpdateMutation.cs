namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing survey response.
    /// </summary>
    internal class SurveyResponseUpdateMutation : Mutation<SurveyResponseUpdatePayload, SurveyResponseUpdateInput>
    {
        /// <summary>
        /// Initialize an new SurveyResponseUpdate mutation instance.
        /// </summary>
        internal SurveyResponseUpdateMutation(SurveyResponseUpdateInput data)
            : base("surveyResponseUpdate", "SurveyResponseUpdateInput!", data, new HashSet<IQuery>() { new SurveyResponseQuery() { FieldName = "surveyResponse", IsConnection = false }.Select("*") })
        {
        }
    }
}
