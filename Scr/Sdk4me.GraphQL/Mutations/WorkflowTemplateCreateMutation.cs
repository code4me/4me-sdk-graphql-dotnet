namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new workflow template.
    /// </summary>
    internal class WorkflowTemplateCreateMutation : Mutation<WorkflowTemplateCreatePayload, WorkflowTemplateCreateInput>
    {
        /// <summary>
        /// Initialize an new WorkflowTemplateCreate mutation instance.
        /// </summary>
        internal WorkflowTemplateCreateMutation(WorkflowTemplateCreateInput data)
            : base("workflowTemplateCreate", "WorkflowTemplateCreateInput!", data, new HashSet<IQuery>() { new WorkflowTemplateQuery() { FieldName = "workflowTemplate", IsConnection = false }.Select("*") })
        {
        }
    }
}
