using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing workflow type.
    /// </summary>
    internal class WorkflowTypeUpdateMutation : Mutation<WorkflowTypeUpdatePayload, WorkflowTypeUpdateInput>
    {
        /// <summary>
        /// Initialize an new WorkflowTypeUpdate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The workflow type response query.</param>
        internal WorkflowTypeUpdateMutation(WorkflowTypeUpdateInput data, WorkflowTypeQuery query)
            : base("workflowTypeUpdate", "WorkflowTypeUpdateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The workflow type response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(WorkflowTypeQuery query)
        {
            query.FieldName = "workflowType";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
