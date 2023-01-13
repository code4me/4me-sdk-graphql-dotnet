namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving Team records.
    /// </summary>
    public class TeamQuery : Query<TeamQuery, TeamField, TeamView, TeamOrderField>
    {
        /// <summary>
        /// Initialize a new team query instance.
        /// </summary>
        public TeamQuery()
            : base("teams", typeof(Team), true)
        {
        }

        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        public TeamQuery SelectCustomFieldsAttachments(AttachmentQuery query)
        {
            query.FieldName = "customFieldsAttachments";
            return Select(query);
        }

        /// <summary>
        /// People linked as a member to the team.
        /// </summary>
        public TeamQuery SelectMembers(PersonQuery query)
        {
            query.FieldName = "members";
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to the Remarks field.
        /// </summary>
        public TeamQuery SelectRemarksAttachments(AttachmentQuery query)
        {
            query.FieldName = "remarksAttachments";
            return Select(query);
        }
    }
}
