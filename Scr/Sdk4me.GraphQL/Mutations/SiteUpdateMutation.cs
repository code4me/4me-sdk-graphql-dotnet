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
        /// <param name="data">The input data.</param>
        /// <param name="query">The repsonse query.</param>
        internal SiteUpdateMutation(SiteUpdateInput data, SiteQuery query)
            : base("siteUpdate", "SiteUpdateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(SiteQuery query)
        {
            query.FieldName = "site";
            query.IsConnection = false;
            return new HashSet<IQuery>() {query};
        }
    }
}
