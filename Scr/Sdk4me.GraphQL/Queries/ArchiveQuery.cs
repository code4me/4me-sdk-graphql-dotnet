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
        /// <br>Use this method along with other <c>SelectArchived(IQuery)</c> calls to cast different object types supporting <see cref="IHasLifeCycleState"></see>.</br>
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
        /// <br>Use this method along with other <c>SelectArchived(IQuery)</c> calls to cast different object types supporting <see cref="IHasLifeCycleState"></see>.</br>
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
        /// <br>Use this method along with other <c>SelectArchived(IQuery)</c> calls to cast different object types supporting <see cref="IHasLifeCycleState"></see>.</br>
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
        /// <br>Use this method along with other <c>SelectArchived(IQuery)</c> calls to cast different object types supporting <see cref="IHasLifeCycleState"></see>.</br>
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
        /// <br>Use this method along with other <c>SelectArchived(IQuery)</c> calls to cast different object types supporting <see cref="IHasLifeCycleState"></see>.</br>
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
        /// <br>Use this method along with other <c>SelectArchived(IQuery)</c> calls to cast different object types supporting <see cref="IHasLifeCycleState"></see>.</br>
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
        /// <br>Use this method along with other <c>SelectArchived(IQuery)</c> calls to cast different object types supporting <see cref="IHasLifeCycleState"></see>.</br>
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
        /// <br>Use this method along with other <c>SelectArchived(IQuery)</c> calls to cast different object types supporting <see cref="IHasLifeCycleState"></see>.</br>
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
        /// <br>Use this method along with other <c>SelectArchived(IQuery)</c> calls to cast different object types supporting <see cref="IHasLifeCycleState"></see>.</br>
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
