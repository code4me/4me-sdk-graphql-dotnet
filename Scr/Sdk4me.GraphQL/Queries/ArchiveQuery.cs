namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving Archive records.
    /// </summary>
    public class ArchiveQuery : Query<ArchiveQuery, ArchiveField, ArchiveView, ArchiveOrderField>
    {
        /// <summary>
        /// Initialize a new archive query instance.
        /// </summary>
        public ArchiveQuery()
            : base("archive", typeof(Archive), true)
        {
        }

        /// <summary>
        /// Initialize a new archive query instance.
        /// <br>Additional filters and views will be ignored.</br>
        /// </summary>
        /// <param name="id">The ID of the archive.</param>
        public ArchiveQuery(string id)
            : base("Archive", id, typeof(Archive), false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        public ArchiveQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The archived record.
        /// <para>
        /// <br>Use this method to cast different object types supporting <see cref="IHasLifeCycleState"></see>.</br>
        /// <br>If any query parameter is not provided (defaults to null), a new instance of the respective query type is created with the <c>ID</c> field selected.</br>
        /// </para>
        /// </summary>
        public ArchiveQuery SelectArchived(
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
            ArchiveQuery query = SelectArchived(personQuery);
            query.OnTypesQueries.Add("Person", personQuery.Clone());

            problemQuery ??= new ProblemQuery().Select(ProblemField.ID);
            query = SelectArchived(problemQuery);
            query.OnTypesQueries.Add("Problem", problemQuery.Clone());

            projectQuery ??= new ProjectQuery().Select(ProjectField.ID);
            query = SelectArchived(projectQuery);
            query.OnTypesQueries.Add("Project", projectQuery.Clone());

            projectTaskQuery ??= new ProjectTaskQuery().Select(ProjectTaskField.ID);
            query = SelectArchived(projectTaskQuery);
            query.OnTypesQueries.Add("ProjectTask", projectTaskQuery.Clone());

            releaseQuery ??= new ReleaseQuery().Select(ReleaseField.ID);
            query = SelectArchived(releaseQuery);
            query.OnTypesQueries.Add("Release", releaseQuery.Clone());

            requestQuery ??= new RequestQuery().Select(RequestField.ID);
            query = SelectArchived(requestQuery);
            query.OnTypesQueries.Add("Request", requestQuery.Clone());

            riskQuery ??= new RiskQuery().Select(RiskField.ID);
            query = SelectArchived(riskQuery);
            query.OnTypesQueries.Add("Risk", riskQuery.Clone());

            taskQuery ??= new TaskQuery().Select(TaskField.ID);
            query = SelectArchived(taskQuery);
            query.OnTypesQueries.Add("Task", taskQuery.Clone());

            workflowQuery ??= new WorkflowQuery().Select(WorkflowField.ID);
            query = SelectArchived(workflowQuery);
            query.OnTypesQueries.Add("Workflow", workflowQuery.Clone());

            return query;
        }

        /// <summary>
        /// The archived record.
        /// <para>
        /// <br>Use this method along with other <c>SelectArchived(IQuery)</c> calls to cast different object types supporting <see cref="IHasLifeCycleState"></see>.</br>
        /// <br>If a specific type is not queried via <c>SelectRecord(IQuery)</c>, it defaults to a null object.</br>
        /// </para>
        /// </summary>
        public ArchiveQuery SelectArchived(PersonQuery query)
        {
            query.FieldName = "archived";
            query.OnTypesQueries.Add("Person", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The archived record.
        /// <para>
        /// <br>Use this method along with other <c>SelectArchived(IQuery)</c> calls to cast different object types supporting <see cref="IHasLifeCycleState"></see>.</br>
        /// <br>If a specific type is not queried via <c>SelectRecord(IQuery)</c>, it defaults to a null object.</br>
        /// </para>
        /// </summary>
        public ArchiveQuery SelectArchived(ProblemQuery query)
        {
            query.FieldName = "archived";
            query.OnTypesQueries.Add("Problem", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The archived record.
        /// <para>
        /// <br>Use this method along with other <c>SelectArchived(IQuery)</c> calls to cast different object types supporting <see cref="IHasLifeCycleState"></see>.</br>
        /// <br>If a specific type is not queried via <c>SelectRecord(IQuery)</c>, it defaults to a null object.</br>
        /// </para>
        /// </summary>
        public ArchiveQuery SelectArchived(ProjectQuery query)
        {
            query.FieldName = "archived";
            query.OnTypesQueries.Add("Project", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The archived record.
        /// <para>
        /// <br>Use this method along with other <c>SelectArchived(IQuery)</c> calls to cast different object types supporting <see cref="IHasLifeCycleState"></see>.</br>
        /// <br>If a specific type is not queried via <c>SelectRecord(IQuery)</c>, it defaults to a null object.</br>
        /// </para>
        /// </summary>
        public ArchiveQuery SelectArchived(ProjectTaskQuery query)
        {
            query.FieldName = "archived";
            query.OnTypesQueries.Add("ProjectTask", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The archived record.
        /// <para>
        /// <br>Use this method along with other <c>SelectArchived(IQuery)</c> calls to cast different object types supporting <see cref="IHasLifeCycleState"></see>.</br>
        /// <br>If a specific type is not queried via <c>SelectRecord(IQuery)</c>, it defaults to a null object.</br>
        /// </para>
        /// </summary>
        public ArchiveQuery SelectArchived(ReleaseQuery query)
        {
            query.FieldName = "archived";
            query.OnTypesQueries.Add("Release", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The archived record.
        /// <para>
        /// <br>Use this method along with other <c>SelectArchived(IQuery)</c> calls to cast different object types supporting <see cref="IHasLifeCycleState"></see>.</br>
        /// <br>If a specific type is not queried via <c>SelectRecord(IQuery)</c>, it defaults to a null object.</br>
        /// </para>
        /// </summary>
        public ArchiveQuery SelectArchived(RequestQuery query)
        {
            query.FieldName = "archived";
            query.OnTypesQueries.Add("Request", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The archived record.
        /// <para>
        /// <br>Use this method along with other <c>SelectArchived(IQuery)</c> calls to cast different object types supporting <see cref="IHasLifeCycleState"></see>.</br>
        /// <br>If a specific type is not queried via <c>SelectRecord(IQuery)</c>, it defaults to a null object.</br>
        /// </para>
        /// </summary>
        public ArchiveQuery SelectArchived(RiskQuery query)
        {
            query.FieldName = "archived";
            query.OnTypesQueries.Add("Risk", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The archived record.
        /// <para>
        /// <br>Use this method along with other <c>SelectArchived(IQuery)</c> calls to cast different object types supporting <see cref="IHasLifeCycleState"></see>.</br>
        /// <br>If a specific type is not queried via <c>SelectRecord(IQuery)</c>, it defaults to a null object.</br>
        /// </para>
        /// </summary>
        public ArchiveQuery SelectArchived(TaskQuery query)
        {
            query.FieldName = "archived";
            query.OnTypesQueries.Add("Task", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The archived record.
        /// <para>
        /// <br>Use this method along with other <c>SelectArchived(IQuery)</c> calls to cast different object types supporting <see cref="IHasLifeCycleState"></see>.</br>
        /// <br>If a specific type is not queried via <c>SelectRecord(IQuery)</c>, it defaults to a null object.</br>
        /// </para>
        /// </summary>
        public ArchiveQuery SelectArchived(WorkflowQuery query)
        {
            query.FieldName = "archived";
            query.OnTypesQueries.Add("Workflow", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The person who archived the record.
        /// </summary>
        public ArchiveQuery SelectArchivedBy(PersonQuery query)
        {
            query.FieldName = "archivedBy";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
