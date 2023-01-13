namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing workflow template.
    /// </summary>
    internal class WorkflowTemplateUpdateMutation : Mutation<WorkflowTemplateUpdatePayload, WorkflowTemplateUpdateInput>
    {
        /// <summary>
        /// Initialize an new WorkflowTemplateUpdate mutation instance.
        /// </summary>
        internal WorkflowTemplateUpdateMutation(WorkflowTemplateUpdateInput data)
            : base("workflowTemplateUpdate", "WorkflowTemplateUpdateInput!", data, new HashSet<IQuery>() { new WorkflowTemplateQuery() { FieldName = "workflowTemplate", IsConnection = false }.Select("*") })
        {
        }
    }
}
