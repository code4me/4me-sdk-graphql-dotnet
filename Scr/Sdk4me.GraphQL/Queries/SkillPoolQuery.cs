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
        /// The account this record belongs to.
        /// </summary>
        public SkillPoolQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Effort classes linked to the skill pool.
        /// </summary>
        public SkillPoolQuery SelectEffortClasses(EffortClassQuery query)
        {
            query.FieldName = "effortClasses";
            return Select(query);
        }

        /// <summary>
        /// The manager or supervisor of the skill pool. This person is able to maintain the information about the skill pool. The manager of a skill pool does not need to be a member of the skill pool.
        /// </summary>
        public SkillPoolQuery SelectManager(PersonQuery query)
        {
            query.FieldName = "manager";
            query.IsConnection = false;
            return Select(query);
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
