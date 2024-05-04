using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new project template.
    /// </summary>
    internal class ProjectTemplateCreateMutation : Mutation<ProjectTemplateCreatePayload, ProjectTemplateCreateInput>
    {
        /// <summary>
        /// Initialize an new ProjectTemplateCreate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The project template response query.</param>
        internal ProjectTemplateCreateMutation(ProjectTemplateCreateInput data, ProjectTemplateQuery query)
            : base("projectTemplateCreate", "ProjectTemplateCreateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The project template response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(ProjectTemplateQuery query)
        {
            query.FieldName = "projectTemplate";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
