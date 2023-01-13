namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing task template.
    /// </summary>
    internal class TaskTemplateUpdateMutation : Mutation<TaskTemplateUpdatePayload, TaskTemplateUpdateInput>
    {
        /// <summary>
        /// Initialize an new TaskTemplateUpdate mutation instance.
        /// </summary>
        internal TaskTemplateUpdateMutation(TaskTemplateUpdateInput data)
            : base("taskTemplateUpdate", "TaskTemplateUpdateInput!", data, new HashSet<IQuery>() { new TaskTemplateQuery() { FieldName = "taskTemplate", IsConnection = false }.Select("*") })
        {
        }
    }
}
