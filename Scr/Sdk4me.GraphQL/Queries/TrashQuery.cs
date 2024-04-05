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
        public TrashQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The trashed record, e.g. Request.
        /// <br>Use this method along with other <c>SelectTrashed(IQuery)</c> calls to cast different object types supporting <see cref="IHasLifeCycleState"></see>.</br>
        /// </summary>
        public TrashQuery SelectTrashed(PersonQuery query)
        {
            query.FieldName = "trashed";
            query.OnTypesQueries.Add("Person", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The trashed record, e.g. Request.
        /// <br>Use this method along with other <c>SelectTrashed(IQuery)</c> calls to cast different object types supporting <see cref="IHasLifeCycleState"></see>.</br>
        /// </summary>
        public TrashQuery SelectTrashed(ProblemQuery query)
        {
            query.FieldName = "trashed";
            query.OnTypesQueries.Add("Problem", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The trashed record, e.g. Request.
        /// <br>Use this method along with other <c>SelectTrashed(IQuery)</c> calls to cast different object types supporting <see cref="IHasLifeCycleState"></see>.</br>
        /// </summary>
        public TrashQuery SelectTrashed(ProjectQuery query)
        {
            query.FieldName = "trashed";
            query.OnTypesQueries.Add("Project", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The trashed record, e.g. Request.
        /// <br>Use this method along with other <c>SelectTrashed(IQuery)</c> calls to cast different object types supporting <see cref="IHasLifeCycleState"></see>.</br>
        /// </summary>
        public TrashQuery SelectTrashed(ProjectTaskQuery query)
        {
            query.FieldName = "trashed";
            query.OnTypesQueries.Add("ProjectTask", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The trashed record, e.g. Request.
        /// <br>Use this method along with other <c>SelectTrashed(IQuery)</c> calls to cast different object types supporting <see cref="IHasLifeCycleState"></see>.</br>
        /// </summary>
        public TrashQuery SelectTrashed(ReleaseQuery query)
        {
            query.FieldName = "trashed";
            query.OnTypesQueries.Add("Release", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The trashed record, e.g. Request.
        /// <br>Use this method along with other <c>SelectTrashed(IQuery)</c> calls to cast different object types supporting <see cref="IHasLifeCycleState"></see>.</br>
        /// </summary>
        public TrashQuery SelectTrashed(RequestQuery query)
        {
            query.FieldName = "trashed";
            query.OnTypesQueries.Add("Request", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The trashed record, e.g. Request.
        /// <br>Use this method along with other <c>SelectTrashed(IQuery)</c> calls to cast different object types supporting <see cref="IHasLifeCycleState"></see>.</br>
        /// </summary>
        public TrashQuery SelectTrashed(RiskQuery query)
        {
            query.FieldName = "trashed";
            query.OnTypesQueries.Add("Risk", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The trashed record, e.g. Request.
        /// <br>Use this method along with other <c>SelectTrashed(IQuery)</c> calls to cast different object types supporting <see cref="IHasLifeCycleState"></see>.</br>
        /// </summary>
        public TrashQuery SelectTrashed(TaskQuery query)
        {
            query.FieldName = "trashed";
            query.OnTypesQueries.Add("Task", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The trashed record, e.g. Request.
        /// <br>Use this method along with other <c>SelectTrashed(IQuery)</c> calls to cast different object types supporting <see cref="IHasLifeCycleState"></see>.</br>
        /// </summary>
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
        public TrashQuery SelectTrashedBy(PersonQuery query)
        {
            query.FieldName = "trashedBy";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
