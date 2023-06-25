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

        /// <summary>
        /// The person who is selected as the approver for the approval.
        /// </summary>
        public TaskApprovalQuery SelectApprover(PersonQuery query)
        {
            query.FieldName = "approver";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The summary PDF file that was generated for the approver when the approval was last set to the status <c>assigned</c>.
        /// </summary>
        public TaskApprovalQuery SelectAttachment(AttachmentQuery query)
        {
            query.FieldName = "attachment";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
