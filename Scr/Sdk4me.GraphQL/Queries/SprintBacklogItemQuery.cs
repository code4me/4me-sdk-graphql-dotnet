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
        /// <br>Use this method along with other <c>SelectRecord(IQuery)</c> calls to cast different object types supporting <see cref="IHasSprintBacklogItems"></see>.</br>
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
        /// <br>Use this method along with other <c>SelectRecord(IQuery)</c> calls to cast different object types supporting <see cref="IHasSprintBacklogItems"></see>.</br>
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
        /// <br>Use this method along with other <c>SelectRecord(IQuery)</c> calls to cast different object types supporting <see cref="IHasSprintBacklogItems"></see>.</br>
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
        /// <br>Use this method along with other <c>SelectRecord(IQuery)</c> calls to cast different object types supporting <see cref="IHasSprintBacklogItems"></see>.</br>
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
