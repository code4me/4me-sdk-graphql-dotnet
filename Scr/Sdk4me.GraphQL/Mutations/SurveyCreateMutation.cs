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
        /// <param name="data">The input data.</param>
        /// <param name="query">The repsonse query.</param>
        internal SurveyCreateMutation(SurveyCreateInput data, SurveyQuery query)
            : base("surveyCreate", "SurveyCreateInput!", data, GetQuery(query))
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
