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
        internal OrganizationUpdateMutation(OrganizationUpdateInput data)
            : base("organizationUpdate", "OrganizationUpdateInput!", data, new HashSet<IQuery>() { new OrganizationQuery() { FieldName = "organization", IsConnection = false }.Select("*") })
        {
        }
    }
}
