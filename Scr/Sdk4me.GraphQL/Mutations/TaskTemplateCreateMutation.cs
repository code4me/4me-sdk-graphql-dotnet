namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new task template.
    /// </summary>
    internal class TaskTemplateCreateMutation : Mutation<TaskTemplateCreatePayload, TaskTemplateCreateInput>
    {
        /// <summary>
        /// Initialize an new TaskTemplateCreate mutation instance.
        /// </summary>
        internal TaskTemplateCreateMutation(TaskTemplateCreateInput data)
            : base("taskTemplateCreate", "TaskTemplateCreateInput!", data, new HashSet<IQuery>() { new TaskTemplateQuery() { FieldName = "taskTemplate", IsConnection = false }.Select("*") })
        {
        }
    }
}
