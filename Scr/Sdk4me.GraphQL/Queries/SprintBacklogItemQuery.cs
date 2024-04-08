namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="SprintBacklogItem">SprintBacklogItem</see> query.
    /// </summary>
    public class SprintBacklogItemQuery : Query<SprintBacklogItemQuery, SprintBacklogItemField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new sprint backlog item query instance.
        /// </summary>
        public SprintBacklogItemQuery()
            : base("", typeof(SprintBacklogItem), true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        public SprintBacklogItemQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Record on the sprint backlog.
        /// <para>
        /// <br>Use this method to cast different object types supporting <see cref="IHasSprintBacklogItems"></see>.</br>
        /// <br>If any query parameter is not provided (defaults to null), a new instance of the respective query type is created with the <c>ID</c> field selected.</br>
        /// </para>
        /// </summary>
        public SprintBacklogItemQuery SelectRecord(
            ProblemQuery? problemQuery = null,
            ProjectTaskQuery? projectTaskQuery = null,
            RequestQuery? requestQuery = null,
            TaskQuery? taskQuery = null)
        {
            problemQuery ??= new ProblemQuery().Select(ProblemField.ID);
            SprintBacklogItemQuery query = SelectRecord(problemQuery);
            query.OnTypesQueries.Add("Problem", problemQuery.Clone());

            projectTaskQuery ??= new ProjectTaskQuery().Select(ProjectTaskField.ID);
            query = SelectRecord(projectTaskQuery);
            query.OnTypesQueries.Add("ProjectTask", projectTaskQuery.Clone());

            requestQuery ??= new RequestQuery().Select(RequestField.ID);
            query = SelectRecord(requestQuery);
            query.OnTypesQueries.Add("Request", requestQuery.Clone());

            taskQuery ??= new TaskQuery().Select(TaskField.ID);
            query = SelectRecord(taskQuery);
            query.OnTypesQueries.Add("Task", taskQuery.Clone());

            return query;
        }

        /// <summary>
        /// Record on the sprint backlog.
        /// <para>
        /// <br>Use this method along with other <c>SelectRecord(IQuery)</c> calls to cast different object types supporting <see cref="IHasSprintBacklogItems"></see>.</br>
        /// <br>If a specific type is not queried via <c>SelectRecord(IQuery)</c>, it defaults to a null object.</br>
        /// </para>
        /// </summary>
        public SprintBacklogItemQuery SelectRecord(ProblemQuery query)
        {
            query.FieldName = "record";
            query.OnTypesQueries.Add("Problem", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Record on the sprint backlog.
        /// <para>
        /// <br>Use this method along with other <c>SelectRecord(IQuery)</c> calls to cast different object types supporting <see cref="IHasSprintBacklogItems"></see>.</br>
        /// <br>If a specific type is not queried via <c>SelectRecord(IQuery)</c>, it defaults to a null object.</br>
        /// </para>
        /// </summary>
        public SprintBacklogItemQuery SelectRecord(ProjectTaskQuery query)
        {
            query.FieldName = "record";
            query.OnTypesQueries.Add("ProjectTask", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Record on the sprint backlog.
        /// <para>
        /// <br>Use this method along with other <c>SelectRecord(IQuery)</c> calls to cast different object types supporting <see cref="IHasSprintBacklogItems"></see>.</br>
        /// <br>If a specific type is not queried via <c>SelectRecord(IQuery)</c>, it defaults to a null object.</br>
        /// </para>
        /// </summary>
        public SprintBacklogItemQuery SelectRecord(RequestQuery query)
        {
            query.FieldName = "record";
            query.OnTypesQueries.Add("Request", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Record on the sprint backlog.
        /// <para>
        /// <br>Use this method along with other <c>SelectRecord(IQuery)</c> calls to cast different object types supporting <see cref="IHasSprintBacklogItems"></see>.</br>
        /// <br>If a specific type is not queried via <c>SelectRecord(IQuery)</c>, it defaults to a null object.</br>
        /// </para>
        /// </summary>
        public SprintBacklogItemQuery SelectRecord(TaskQuery query)
        {
            query.FieldName = "record";
            query.OnTypesQueries.Add("Task", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Sprint this record is part of.
        /// </summary>
        public SprintBacklogItemQuery SelectSprint(SprintQuery query)
        {
            query.FieldName = "sprint";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
