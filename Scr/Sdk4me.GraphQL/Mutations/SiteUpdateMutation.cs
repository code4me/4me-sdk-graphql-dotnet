namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing site.
    /// </summary>
    internal class SiteUpdateMutation : Mutation<SiteUpdatePayload, SiteUpdateInput>
    {
        /// <summary>
        /// Initialize an new SiteUpdate mutation instance.
        /// </summary>
        internal SiteUpdateMutation(SiteUpdateInput data)
            : base("siteUpdate", "SiteUpdateInput!", data, new HashSet<IQuery>() { new SiteQuery() { FieldName = "site", IsConnection = false }.Select("*") })
        {
        }
    }
}
