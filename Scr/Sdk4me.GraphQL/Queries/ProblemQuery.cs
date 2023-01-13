namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving Problem records.
    /// </summary>
    public class ProblemQuery : Query<ProblemQuery, ProblemField, ProblemView, ProblemOrderField>
    {
        /// <summary>
        /// Initialize a new problem query instance.
        /// </summary>
        public ProblemQuery()
            : base("problems", typeof(Problem), true)
        {
        }

        /// <summary>
        /// Configuration items of this problem.
        /// </summary>
        public ProblemQuery SelectConfigurationItems(ConfigurationItemQuery query)
        {
            query.FieldName = "configurationItems";
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        public ProblemQuery SelectCustomFieldsAttachments(AttachmentQuery query)
        {
            query.FieldName = "customFieldsAttachments";
            return Select(query);
        }

        /// <summary>
        /// Notes of the record.
        /// </summary>
        public ProblemQuery SelectNotes(NoteQuery query)
        {
            query.FieldName = "notes";
            return Select(query);
        }

        /// <summary>
        /// Requests of this problem.
        /// </summary>
        public ProblemQuery SelectRequests(RequestQuery query)
        {
            query.FieldName = "requests";
            return Select(query);
        }

        /// <summary>
        /// Service instances of this problem.
        /// </summary>
        public ProblemQuery SelectServiceInstances(ServiceInstanceQuery query)
        {
            query.FieldName = "serviceInstances";
            return Select(query);
        }

        /// <summary>
        /// Sprint backlog items associated with this object.
        /// </summary>
        public ProblemQuery SelectSprintBacklogItems(SprintBacklogItemQuery query)
        {
            query.FieldName = "sprintBacklogItems";
            return Select(query);
        }

        /// <summary>
        /// Time entries for this record.
        /// </summary>
        public ProblemQuery SelectTimeEntries(TimeEntryQuery query)
        {
            query.FieldName = "timeEntries";
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to the Workaround field.
        /// </summary>
        public ProblemQuery SelectWorkaroundAttachments(AttachmentQuery query)
        {
            query.FieldName = "workaroundAttachments";
            return Select(query);
        }
    }
}
