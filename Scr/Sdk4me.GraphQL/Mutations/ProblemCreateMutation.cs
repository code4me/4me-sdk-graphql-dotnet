namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new problem.
    /// </summary>
    internal class ProblemCreateMutation : Mutation<ProblemCreatePayload, ProblemCreateInput>
    {
        /// <summary>
        /// Initialize an new ProblemCreate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The problem response query.</param>
        internal ProblemCreateMutation(ProblemCreateInput data, ProblemQuery query)
            : base("problemCreate", "ProblemCreateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The problem response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(ProblemQuery query)
        {
            query.FieldName = "problem";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
