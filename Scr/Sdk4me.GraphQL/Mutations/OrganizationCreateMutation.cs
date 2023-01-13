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
        internal OrganizationCreateMutation(OrganizationCreateInput data)
            : base("organizationCreate", "OrganizationCreateInput!", data, new HashSet<IQuery>() { new OrganizationQuery() { FieldName = "organization", IsConnection = false }.Select("*") })
        {
        }
    }
}
