namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing survey.
    /// </summary>
    internal class SurveyUpdateMutation : Mutation<SurveyUpdatePayload, SurveyUpdateInput>
    {
        /// <summary>
        /// Initialize an new SurveyUpdate mutation instance.
        /// </summary>
        internal SurveyUpdateMutation(SurveyUpdateInput data)
            : base("surveyUpdate", "SurveyUpdateInput!", data, new HashSet<IQuery>() { new SurveyQuery() { FieldName = "survey", IsConnection = false }.Select("*") })
        {
        }
    }
}
