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
        internal ProblemCreateMutation(ProblemCreateInput data)
            : base("problemCreate", "ProblemCreateInput!", data, new HashSet<IQuery>() { new ProblemQuery() { FieldName = "problem", IsConnection = false }.Select("*") })
        {
        }
    }
}
