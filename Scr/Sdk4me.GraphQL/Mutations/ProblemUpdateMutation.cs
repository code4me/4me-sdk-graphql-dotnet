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
        internal ProblemUpdateMutation(ProblemUpdateInput data)
            : base("problemUpdate", "ProblemUpdateInput!", data, new HashSet<IQuery>() { new ProblemQuery() { FieldName = "problem", IsConnection = false }.Select("*") })
        {
        }
    }
}
