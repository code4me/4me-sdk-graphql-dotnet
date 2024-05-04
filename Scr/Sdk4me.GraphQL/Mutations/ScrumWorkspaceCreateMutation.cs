using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new scrum workspace.
    /// </summary>
    internal class ScrumWorkspaceCreateMutation : Mutation<ScrumWorkspaceCreatePayload, ScrumWorkspaceCreateInput>
    {
        /// <summary>
        /// Initialize an new ScrumWorkspaceCreate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The scrum workspace response query.</param>
        internal ScrumWorkspaceCreateMutation(ScrumWorkspaceCreateInput data, ScrumWorkspaceQuery query)
            : base("scrumWorkspaceCreate", "ScrumWorkspaceCreateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The scrum workspace response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(ScrumWorkspaceQuery query)
        {
            query.FieldName = "scrumWorkspace";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
