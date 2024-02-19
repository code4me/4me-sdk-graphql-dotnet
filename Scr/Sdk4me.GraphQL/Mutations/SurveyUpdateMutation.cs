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
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal SurveyUpdateMutation(SurveyUpdateInput data, SurveyQuery query)
            : base("surveyUpdate", "SurveyUpdateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(SurveyQuery query)
        {
            query.FieldName = "survey";
            query.IsConnection = false;
            return new HashSet<IQuery>() {query};
        }
    }
}
