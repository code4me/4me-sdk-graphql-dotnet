namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing task.
    /// </summary>
    internal class TaskUpdateMutation : Mutation<TaskUpdatePayload, TaskUpdateInput>
    {
        /// <summary>
        /// Initialize an new TaskUpdate mutation instance.
        /// </summary>
        internal TaskUpdateMutation(TaskUpdateInput data)
            : base("taskUpdate", "TaskUpdateInput!", data, new HashSet<IQuery>() { new TaskQuery() { FieldName = "task", IsConnection = false }.Select("*") })
        {
        }
    }
}
