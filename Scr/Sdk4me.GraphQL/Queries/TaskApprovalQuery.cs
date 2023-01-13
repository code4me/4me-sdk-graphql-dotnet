namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="TaskApproval">TaskApproval</see> query.
    /// </summary>
    public class TaskApprovalQuery : Query<TaskApprovalQuery, TaskApprovalField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new task approval query instance.
        /// </summary>
        public TaskApprovalQuery()
            : base("", typeof(TaskApproval), true)
        {
        }
    }
}
