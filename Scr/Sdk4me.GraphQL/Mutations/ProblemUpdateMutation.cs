namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing problem.
    /// </summary>
    internal class ProblemUpdateMutation : Mutation<ProblemUpdatePayload, ProblemUpdateInput>
    {
        /// <summary>
        /// Initialize an new ProblemUpdate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal ProblemUpdateMutation(ProblemUpdateInput data, ProblemQuery query)
            : base("problemUpdate", "ProblemUpdateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(ProblemQuery query)
        {
            query.FieldName = "problem";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
