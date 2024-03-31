namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new organization.
    /// </summary>
    internal class OrganizationCreateMutation : Mutation<OrganizationCreatePayload, OrganizationCreateInput>
    {
        /// <summary>
        /// Initialize an new OrganizationCreate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal OrganizationCreateMutation(OrganizationCreateInput data, OrganizationQuery query)
            : base("organizationCreate", "OrganizationCreateInput!", data, GetQuery(query))
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
            return new HashSet<IQuery>() { query };
        }
    }
}
