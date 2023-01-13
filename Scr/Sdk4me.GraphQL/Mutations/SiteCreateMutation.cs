namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new site.
    /// </summary>
    internal class SiteCreateMutation : Mutation<SiteCreatePayload, SiteCreateInput>
    {
        /// <summary>
        /// Initialize an new SiteCreate mutation instance.
        /// </summary>
        internal SiteCreateMutation(SiteCreateInput data)
            : base("siteCreate", "SiteCreateInput!", data, new HashSet<IQuery>() { new SiteQuery() { FieldName = "site", IsConnection = false }.Select("*") })
        {
        }
    }
}
