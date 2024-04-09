namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving Trash records.
    /// </summary>
    public class TrashQuery : Query<TrashQuery, TrashField, TrashView, TrashOrderField>
    {
        /// <summary>
        /// Initialize a new trash query instance.
        /// </summary>
        public TrashQuery()
            : base("trash", typeof(Trash), true)
        {
        }

        /// <summary>
        /// Initialize a new trash query instance.
        /// <br>Additional filters and views will be ignored.</br>
        /// </summary>
        /// <param name="id">The ID of the trash.</param>
        public TrashQuery(string id)
            : base("Trash", id, typeof(Trash), false)
        {
        }

        /// <summary>
        /// The account of the trashed record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TrashQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The trashed record, e.g. Request.
        /// <para>
        /// <br>Use this method to cast different object types supporting <see cref="IHasLifeCycleState"></see>.</br>
        /// <br>If any query parameter is not provided (defaults to null), a new instance of the respective query type is created with the <c>ID</c> field selected.</br>
        /// </para>
        /// </summary>
        /// <param name="personQuery">The person query.</param>
        /// <param name="problemQuery">The problem query.</param>
        /// <param name="projectQuery">The project query.</param>
        /// <param name="projectTaskQuery">The project task query.</param>
        /// <param name="releaseQuery">The release query.</param>
        /// <param name="requestQuery">The request query.</param>
        /// <param name="riskQuery">The risk query.</param>
        /// <param name="taskQuery">The task query.</param>
        /// <param name="workflowQuery">The workflow query.</param>
        public TrashQuery SelectTrashed(
            PersonQuery? personQuery = null,
            ProblemQuery? problemQuery = null,
            ProjectQuery? projectQuery = null,
            ProjectTaskQuery? projectTaskQuery = null,
            ReleaseQuery? releaseQuery = null,
            RequestQuery? requestQuery = null,
            RiskQuery? riskQuery = null,
            TaskQuery? taskQuery = null,
            WorkflowQuery? workflowQuery = null)
        {
            personQuery ??= new PersonQuery().Select(PersonField.ID);
            TrashQuery query = SelectTrashed(personQuery);
            query.OnTypesQueries.Add("Person", personQuery.Clone());

            problemQuery ??= new ProblemQuery().Select(ProblemField.ID);
            query = SelectTrashed(problemQuery);
            query.OnTypesQueries.Add("Problem", problemQuery.Clone());

            projectQuery ??= new ProjectQuery().Select(ProjectField.ID);
            query = SelectTrashed(projectQuery);
            query.OnTypesQueries.Add("Project", projectQuery.Clone());

            projectTaskQuery ??= new ProjectTaskQuery().Select(ProjectTaskField.ID);
            query = SelectTrashed(projectTaskQuery);
            query.OnTypesQueries.Add("ProjectTask", projectTaskQuery.Clone());

            releaseQuery ??= new ReleaseQuery().Select(ReleaseField.ID);
            query = SelectTrashed(releaseQuery);
            query.OnTypesQueries.Add("Release", releaseQuery.Clone());

            requestQuery ??= new RequestQuery().Select(RequestField.ID);
            query = SelectTrashed(requestQuery);
            query.OnTypesQueries.Add("Request", requestQuery.Clone());

            riskQuery ??= new RiskQuery().Select(RiskField.ID);
            query = SelectTrashed(riskQuery);
            query.OnTypesQueries.Add("Risk", riskQuery.Clone());

            taskQuery ??= new TaskQuery().Select(TaskField.ID);
            query = SelectTrashed(taskQuery);
            query.OnTypesQueries.Add("Task", taskQuery.Clone());

            workflowQuery ??= new WorkflowQuery().Select(WorkflowField.ID);
            query = SelectTrashed(workflowQuery);
            query.OnTypesQueries.Add("Workflow", workflowQuery.Clone());

            return query;
        }

        /// <summary>
        /// The trashed record, e.g. Request.
        /// <para>
        /// <br>Use this method along with other <c>SelectTrashed(IQuery)</c> calls to cast different object types supporting <see cref="IHasLifeCycleState"></see>.</br>
        /// <br>If a specific type is not queried via <c>SelectRecord(IQuery)</c>, it defaults to a null object.</br>
        /// </para>
        /// </summary>
        /// <param name="query">The person query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TrashQuery SelectTrashed(PersonQuery query)
        {
            query.FieldName = "trashed";
            query.OnTypesQueries.Add("Person", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The trashed record, e.g. Request.
        /// <para>
        /// <br>Use this method along with other <c>SelectTrashed(IQuery)</c> calls to cast different object types supporting <see cref="IHasLifeCycleState"></see>.</br>
        /// <br>If a specific type is not queried via <c>SelectRecord(IQuery)</c>, it defaults to a null object.</br>
        /// </para>
        /// </summary>
        /// <param name="query">The problem query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TrashQuery SelectTrashed(ProblemQuery query)
        {
            query.FieldName = "trashed";
            query.OnTypesQueries.Add("Problem", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The trashed record, e.g. Request.
        /// <para>
        /// <br>Use this method along with other <c>SelectTrashed(IQuery)</c> calls to cast different object types supporting <see cref="IHasLifeCycleState"></see>.</br>
        /// <br>If a specific type is not queried via <c>SelectRecord(IQuery)</c>, it defaults to a null object.</br>
        /// </para>
        /// </summary>
        /// <param name="query">The project query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TrashQuery SelectTrashed(ProjectQuery query)
        {
            query.FieldName = "trashed";
            query.OnTypesQueries.Add("Project", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The trashed record, e.g. Request.
        /// <para>
        /// <br>Use this method along with other <c>SelectTrashed(IQuery)</c> calls to cast different object types supporting <see cref="IHasLifeCycleState"></see>.</br>
        /// <br>If a specific type is not queried via <c>SelectRecord(IQuery)</c>, it defaults to a null object.</br>
        /// </para>
        /// </summary>
        /// <param name="query">The project task query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TrashQuery SelectTrashed(ProjectTaskQuery query)
        {
            query.FieldName = "trashed";
            query.OnTypesQueries.Add("ProjectTask", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The trashed record, e.g. Request.
        /// <para>
        /// <br>Use this method along with other <c>SelectTrashed(IQuery)</c> calls to cast different object types supporting <see cref="IHasLifeCycleState"></see>.</br>
        /// <br>If a specific type is not queried via <c>SelectRecord(IQuery)</c>, it defaults to a null object.</br>
        /// </para>
        /// </summary>
        /// <param name="query">The release query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TrashQuery SelectTrashed(ReleaseQuery query)
        {
            query.FieldName = "trashed";
            query.OnTypesQueries.Add("Release", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The trashed record, e.g. Request.
        /// <para>
        /// <br>Use this method along with other <c>SelectTrashed(IQuery)</c> calls to cast different object types supporting <see cref="IHasLifeCycleState"></see>.</br>
        /// <br>If a specific type is not queried via <c>SelectRecord(IQuery)</c>, it defaults to a null object.</br>
        /// </para>
        /// </summary>
        /// <param name="query">The request query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TrashQuery SelectTrashed(RequestQuery query)
        {
            query.FieldName = "trashed";
            query.OnTypesQueries.Add("Request", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The trashed record, e.g. Request.
        /// <para>
        /// <br>Use this method along with other <c>SelectTrashed(IQuery)</c> calls to cast different object types supporting <see cref="IHasLifeCycleState"></see>.</br>
        /// <br>If a specific type is not queried via <c>SelectRecord(IQuery)</c>, it defaults to a null object.</br>
        /// </para>
        /// </summary>
        /// <param name="query">The risk query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TrashQuery SelectTrashed(RiskQuery query)
        {
            query.FieldName = "trashed";
            query.OnTypesQueries.Add("Risk", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The trashed record, e.g. Request.
        /// <para>
        /// <br>Use this method along with other <c>SelectTrashed(IQuery)</c> calls to cast different object types supporting <see cref="IHasLifeCycleState"></see>.</br>
        /// <br>If a specific type is not queried via <c>SelectRecord(IQuery)</c>, it defaults to a null object.</br>
        /// </para>
        /// </summary>
        /// <param name="query">The task query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TrashQuery SelectTrashed(TaskQuery query)
        {
            query.FieldName = "trashed";
            query.OnTypesQueries.Add("Task", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The trashed record, e.g. Request.
        /// <para>
        /// <br>Use this method along with other <c>SelectTrashed(IQuery)</c> calls to cast different object types supporting <see cref="IHasLifeCycleState"></see>.</br>
        /// <br>If a specific type is not queried via <c>SelectRecord(IQuery)</c>, it defaults to a null object.</br>
        /// </para>
        /// </summary>
        /// <param name="query">The workflow query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TrashQuery SelectTrashed(WorkflowQuery query)
        {
            query.FieldName = "trashed";
            query.OnTypesQueries.Add("Workflow", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The person who trashed the record.
        /// </summary>
        /// <param name="query">The person query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public TrashQuery SelectTrashedBy(PersonQuery query)
        {
            query.FieldName = "trashedBy";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
