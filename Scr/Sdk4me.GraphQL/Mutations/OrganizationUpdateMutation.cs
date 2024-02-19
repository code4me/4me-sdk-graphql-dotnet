namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing organization.
    /// </summary>
    internal class OrganizationUpdateMutation : Mutation<OrganizationUpdatePayload, OrganizationUpdateInput>
    {
        /// <summary>
        /// Initialize an new OrganizationUpdate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal OrganizationUpdateMutation(OrganizationUpdateInput data, OrganizationQuery query)
            : base("organizationUpdate", "OrganizationUpdateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(OrganizationQuery query)
        {
            query.FieldName = "organization";
            query.IsConnection = false;
            return new HashSet<IQuery>() {query};
        }
    }
}
