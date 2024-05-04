using System.Collections.Generic;

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
        /// <param name="data">The input data.</param>
        /// <param name="query">The survey response response query.</param>
        internal SurveyResponseUpdateMutation(SurveyResponseUpdateInput data, SurveyResponseQuery query)
            : base("surveyResponseUpdate", "SurveyResponseUpdateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The survey response response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(SurveyResponseQuery query)
        {
            query.FieldName = "surveyResponse";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
