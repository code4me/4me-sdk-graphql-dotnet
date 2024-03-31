namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving TimeEntry records.
    /// </summary>
    public class TimeEntryQuery : Query<TimeEntryQuery, TimeEntryField, TimeEntryView, TimeEntryOrderField>
    {
        /// <summary>
        /// Initialize a new time entry query instance.
        /// </summary>
        public TimeEntryQuery()
            : base("timeEntries", typeof(TimeEntry), true)
        {
        }

        /// <summary>
        /// Initialize a new time entry query instance.
        /// <br>Additional filters and views will be ignored.</br>
        /// </summary>
        /// <param name="id">The ID of the time entry.</param>
        public TimeEntryQuery(string id)
            : base("TimeEntry", id, typeof(TimeEntry), false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        public TimeEntryQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record in which the Time spent field was filled out to cause the time entry to be generated.
        /// </summary>
        public TimeEntryQuery SelectAssignment(ProblemQuery query)
        {
            query.FieldName = "assignment";
            query.OnType = "Problem";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record in which the Time spent field was filled out to cause the time entry to be generated.
        /// </summary>
        public TimeEntryQuery SelectAssignment(ProjectTaskQuery query)
        {
            query.FieldName = "assignment";
            query.OnType = "ProjectTask";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record in which the Time spent field was filled out to cause the time entry to be generated.
        /// </summary>
        public TimeEntryQuery SelectAssignment(RequestQuery query)
        {
            query.FieldName = "assignment";
            query.OnType = "Request";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record in which the Time spent field was filled out to cause the time entry to be generated.
        /// </summary>
        public TimeEntryQuery SelectAssignment(TaskQuery query)
        {
            query.FieldName = "assignment";
            query.OnType = "Task";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The organization for which the time was spent.
        /// </summary>
        public TimeEntryQuery SelectCustomer(OrganizationQuery query)
        {
            query.FieldName = "customer";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The effort class that best reflects the type of effort for which time spent is being registered.
        /// </summary>
        public TimeEntryQuery SelectEffortClass(EffortClassQuery query)
        {
            query.FieldName = "effortClass";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The note the time entry is linked to.
        /// </summary>
        public TimeEntryQuery SelectNote(NoteQuery query)
        {
            query.FieldName = "note";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The organization to which the person was linked when the time entry was created.
        /// </summary>
        public TimeEntryQuery SelectOrganization(OrganizationQuery query)
        {
            query.FieldName = "organization";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The person who spent the time.
        /// </summary>
        public TimeEntryQuery SelectPerson(PersonQuery query)
        {
            query.FieldName = "person";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The service for which the time was spent.
        /// </summary>
        public TimeEntryQuery SelectService(ServiceQuery query)
        {
            query.FieldName = "service";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The service instance for which the time was spent. This field is automatically set when a time entry is created for a request.
        /// </summary>
        public TimeEntryQuery SelectServiceInstance(ServiceInstanceQuery query)
        {
            query.FieldName = "serviceInstance";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The service level agreement for which the time was spent. This field is automatically set when a time entry is created for a request.
        /// </summary>
        public TimeEntryQuery SelectServiceLevelAgreement(ServiceLevelAgreementQuery query)
        {
            query.FieldName = "serviceLevelAgreement";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Team the person of the time entry was a member of while the work was performed.
        /// </summary>
        public TimeEntryQuery SelectTeam(TeamQuery query)
        {
            query.FieldName = "team";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The time allocation on which the time was spent. Only the time allocations that are linked to the person’s organization can be selected.
        /// </summary>
        public TimeEntryQuery SelectTimeAllocation(TimeAllocationQuery query)
        {
            query.FieldName = "timeAllocation";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
