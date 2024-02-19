namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing skill pool.
    /// </summary>
    internal class SkillPoolUpdateMutation : Mutation<SkillPoolUpdatePayload, SkillPoolUpdateInput>
    {
        /// <summary>
        /// Initialize an new SkillPoolUpdate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal SkillPoolUpdateMutation(SkillPoolUpdateInput data, SkillPoolQuery query)
            : base("skillPoolUpdate", "SkillPoolUpdateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(SkillPoolQuery query)
        {
            query.FieldName = "skillPool";
            query.IsConnection = false;
            return new HashSet<IQuery>() {query};
        }
    }
}
