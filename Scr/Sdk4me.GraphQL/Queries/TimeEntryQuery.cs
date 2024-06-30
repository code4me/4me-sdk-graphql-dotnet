namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving TimeEntry records.
    /// </summary>
    public class TimeEntryQuery : Query<TimeEntryQuery, TimeEntryField, TimeEntryView, TimeEntryFilter, TimeEntryOrderField>
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
        /// <param name="query">The account query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TimeEntryQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record in which the Time spent field was filled out to cause the time entry to be generated.
        /// <para>
        /// <br>Use this method to cast different object types supporting <see cref="IHasTimeEntries"></see>.</br>
        /// <br>If any query parameter is not provided (defaults to null), a new instance of the respective query type is created with the <c>ID</c> field selected.</br>
        /// </para>
        /// </summary>
        /// <param name="problemQuery">The problem query.</param>
        /// <param name="projectTaskQuery">The project task query.</param>
        /// <param name="requestQuery">The request query.</param>
        /// <param name="taskQuery">The task query.</param>
        public TimeEntryQuery SelectAssignment(
            ProblemQuery? problemQuery = null,
            ProjectTaskQuery? projectTaskQuery = null,
            RequestQuery? requestQuery = null,
            TaskQuery? taskQuery = null)
        {
            problemQuery ??= new ProblemQuery().Select(ProblemField.ID);
            TimeEntryQuery query = SelectAssignment(problemQuery);
            query.OnTypesQueries.Add("Problem", problemQuery.Clone());

            projectTaskQuery ??= new ProjectTaskQuery().Select(ProjectTaskField.ID);
            query = SelectAssignment(projectTaskQuery);
            query.OnTypesQueries.Add("ProjectTask", projectTaskQuery.Clone());

            requestQuery ??= new RequestQuery().Select(RequestField.ID);
            query = SelectAssignment(requestQuery);
            query.OnTypesQueries.Add("Request", requestQuery.Clone());

            taskQuery ??= new TaskQuery().Select(TaskField.ID);
            query = SelectAssignment(taskQuery);
            query.OnTypesQueries.Add("Task", taskQuery.Clone());

            return query;
        }

        /// <summary>
        /// The record in which the Time spent field was filled out to cause the time entry to be generated.
        /// <para>
        /// <br>Use this method along with other <c>SelectAssignment(IQuery)</c> calls to cast different object types supporting <see cref="IHasTimeEntries"></see>.</br>
        /// <br>If a specific type is not queried via <c>SelectRecord(IQuery)</c>, it defaults to a null object.</br>
        /// </para>
        /// </summary>
        /// <param name="query">The problem query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TimeEntryQuery SelectAssignment(ProblemQuery query)
        {
            query.FieldName = "assignment";
            query.OnTypesQueries.Add("Problem", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record in which the Time spent field was filled out to cause the time entry to be generated.
        /// <para>
        /// <br>Use this method along with other <c>SelectAssignment(IQuery)</c> calls to cast different object types supporting <see cref="IHasTimeEntries"></see>.</br>
        /// <br>If a specific type is not queried via <c>SelectRecord(IQuery)</c>, it defaults to a null object.</br>
        /// </para>
        /// </summary>
        /// <param name="query">The project task query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TimeEntryQuery SelectAssignment(ProjectTaskQuery query)
        {
            query.FieldName = "assignment";
            query.OnTypesQueries.Add("ProjectTask", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record in which the Time spent field was filled out to cause the time entry to be generated.
        /// <para>
        /// <br>Use this method along with other <c>SelectAssignment(IQuery)</c> calls to cast different object types supporting <see cref="IHasTimeEntries"></see>.</br>
        /// <br>If a specific type is not queried via <c>SelectRecord(IQuery)</c>, it defaults to a null object.</br>
        /// </para>
        /// </summary>
        /// <param name="query">The request query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TimeEntryQuery SelectAssignment(RequestQuery query)
        {
            query.FieldName = "assignment";
            query.OnTypesQueries.Add("Request", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record in which the Time spent field was filled out to cause the time entry to be generated.
        /// <para>
        /// <br>Use this method along with other <c>SelectAssignment(IQuery)</c> calls to cast different object types supporting <see cref="IHasTimeEntries"></see>.</br>
        /// <br>If a specific type is not queried via <c>SelectRecord(IQuery)</c>, it defaults to a null object.</br>
        /// </para>
        /// </summary>
        /// <param name="query">The task query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TimeEntryQuery SelectAssignment(TaskQuery query)
        {
            query.FieldName = "assignment";
            query.OnTypesQueries.Add("Task", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The organization for which the time was spent.
        /// </summary>
        /// <param name="query">The organization query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TimeEntryQuery SelectCustomer(OrganizationQuery query)
        {
            query.FieldName = "customer";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The effort class that best reflects the type of effort for which time spent is being registered.
        /// </summary>
        /// <param name="query">The effort class query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TimeEntryQuery SelectEffortClass(EffortClassQuery query)
        {
            query.FieldName = "effortClass";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The note the time entry is linked to.
        /// </summary>
        /// <param name="query">The note query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TimeEntryQuery SelectNote(NoteQuery query)
        {
            query.FieldName = "note";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The organization to which the person was linked when the time entry was created.
        /// </summary>
        /// <param name="query">The organization query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TimeEntryQuery SelectOrganization(OrganizationQuery query)
        {
            query.FieldName = "organization";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The person who spent the time.
        /// </summary>
        /// <param name="query">The person query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TimeEntryQuery SelectPerson(PersonQuery query)
        {
            query.FieldName = "person";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The service for which the time was spent.
        /// </summary>
        /// <param name="query">The service query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TimeEntryQuery SelectService(ServiceQuery query)
        {
            query.FieldName = "service";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The service instance for which the time was spent. This field is automatically set when a time entry is created for a request.
        /// </summary>
        /// <param name="query">The service instance query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TimeEntryQuery SelectServiceInstance(ServiceInstanceQuery query)
        {
            query.FieldName = "serviceInstance";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The service level agreement for which the time was spent. This field is automatically set when a time entry is created for a request.
        /// </summary>
        /// <param name="query">The service level agreement query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TimeEntryQuery SelectServiceLevelAgreement(ServiceLevelAgreementQuery query)
        {
            query.FieldName = "serviceLevelAgreement";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Team the person of the time entry was a member of while the work was performed.
        /// </summary>
        /// <param name="query">The team query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TimeEntryQuery SelectTeam(TeamQuery query)
        {
            query.FieldName = "team";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The time allocation on which the time was spent. Only the time allocations that are linked to the person’s organization can be selected.
        /// </summary>
        /// <param name="query">The time allocation query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TimeEntryQuery SelectTimeAllocation(TimeAllocationQuery query)
        {
            query.FieldName = "timeAllocation";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
