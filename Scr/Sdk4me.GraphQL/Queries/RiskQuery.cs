namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving Risk records.
    /// </summary>
    public class RiskQuery : Query<RiskQuery, RiskField, RiskView, RiskOrderField>
    {
        /// <summary>
        /// Initialize a new risk query instance.
        /// </summary>
        public RiskQuery()
            : base("risks", typeof(Risk), true)
        {
        }

        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        public RiskQuery SelectCustomFieldsAttachments(AttachmentQuery query)
        {
            query.FieldName = "customFieldsAttachments";
            return Select(query);
        }

        /// <summary>
        /// Notes of the record.
        /// </summary>
        public RiskQuery SelectNotes(NoteQuery query)
        {
            query.FieldName = "notes";
            return Select(query);
        }

        /// <summary>
        /// Organizations linked to the risk.
        /// </summary>
        public RiskQuery SelectOrganizations(OrganizationQuery query)
        {
            query.FieldName = "organizations";
            return Select(query);
        }

        /// <summary>
        /// Projects linked to the risk.
        /// </summary>
        public RiskQuery SelectProjects(ProjectQuery query)
        {
            query.FieldName = "projects";
            return Select(query);
        }

        /// <summary>
        /// Services linked to the risk.
        /// </summary>
        public RiskQuery SelectServices(ServiceQuery query)
        {
            query.FieldName = "services";
            return Select(query);
        }
    }
}
