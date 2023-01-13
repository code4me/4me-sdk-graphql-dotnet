namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="TaskTemplateApproval">TaskTemplateApproval</see> query.
    /// </summary>
    public class TaskTemplateApprovalQuery : Query<TaskTemplateApprovalQuery, TaskTemplateApprovalField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new task template approval query instance.
        /// </summary>
        public TaskTemplateApprovalQuery()
            : base("", typeof(TaskTemplateApproval), true)
        {
        }
    }
}
