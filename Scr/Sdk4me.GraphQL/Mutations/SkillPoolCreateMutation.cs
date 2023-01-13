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
        internal SkillPoolCreateMutation(SkillPoolCreateInput data)
            : base("skillPoolCreate", "SkillPoolCreateInput!", data, new HashSet<IQuery>() { new SkillPoolQuery() { FieldName = "skillPool", IsConnection = false }.Select("*") })
        {
        }
    }
}
