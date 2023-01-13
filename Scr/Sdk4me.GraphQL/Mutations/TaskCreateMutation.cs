namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new task.
    /// </summary>
    internal class TaskCreateMutation : Mutation<TaskCreatePayload, TaskCreateInput>
    {
        /// <summary>
        /// Initialize an new TaskCreate mutation instance.
        /// </summary>
        internal TaskCreateMutation(TaskCreateInput data)
            : base("taskCreate", "TaskCreateInput!", data, new HashSet<IQuery>() { new TaskQuery() { FieldName = "task", IsConnection = false }.Select("*") })
        {
        }
    }
}
