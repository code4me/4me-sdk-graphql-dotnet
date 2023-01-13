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
        internal SkillPoolUpdateMutation(SkillPoolUpdateInput data)
            : base("skillPoolUpdate", "SkillPoolUpdateInput!", data, new HashSet<IQuery>() { new SkillPoolQuery() { FieldName = "skillPool", IsConnection = false }.Select("*") })
        {
        }
    }
}
