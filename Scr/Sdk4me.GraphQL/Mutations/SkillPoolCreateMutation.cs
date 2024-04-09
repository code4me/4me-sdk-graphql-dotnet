namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new skill pool.
    /// </summary>
    internal class SkillPoolCreateMutation : Mutation<SkillPoolCreatePayload, SkillPoolCreateInput>
    {
        /// <summary>
        /// Initialize an new SkillPoolCreate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The skill pool response query.</param>
        internal SkillPoolCreateMutation(SkillPoolCreateInput data, SkillPoolQuery query)
            : base("skillPoolCreate", "SkillPoolCreateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The skill pool response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(SkillPoolQuery query)
        {
            query.FieldName = "skillPool";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
