namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving SkillPool records.
    /// </summary>
    public class SkillPoolQuery : Query<SkillPoolQuery, SkillPoolField, SkillPoolView, SkillPoolOrderField>
    {
        /// <summary>
        /// Initialize a new skill pool query instance.
        /// </summary>
        public SkillPoolQuery()
            : base("skillPools", typeof(SkillPool), true)
        {
        }

        /// <summary>
        /// People linked as a member to the skill pool.
        /// </summary>
        public SkillPoolQuery SelectMembers(PersonQuery query)
        {
            query.FieldName = "members";
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to the Remarks field.
        /// </summary>
        public SkillPoolQuery SelectRemarksAttachments(AttachmentQuery query)
        {
            query.FieldName = "remarksAttachments";
            return Select(query);
        }
    }
}
