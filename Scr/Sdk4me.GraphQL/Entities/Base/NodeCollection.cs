namespace Sdk4me.GraphQL
{
    /// <summary>
    /// A 4me GraphQL response object.
    /// </summary>
    /// <typeparam name="TEntity">Any type implementing <see cref="Node"/>.</typeparam>
    internal class NodeCollection<TEntity> where TEntity : Node
    {
        /// <summary>
        /// Gets or sets the data response.
        /// </summary>
        [JsonProperty("nodes")]
        internal DataList<TEntity> Data { get; set; } = new();

        /// <summary>
        /// Gets or sets the page info response.
        /// </summary>
        [JsonProperty("pageInfo")]
        internal PageInfo PageInfo { get; set; } = new();

        /// <summary>
        /// Returns the query page information.
        /// </summary>
        /// <param name="fieldName">The current field name.</param>
        /// <param name="depth">The current depth.</param>
        /// <returns>The query cursor information.</returns>
        internal HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();

            foreach (TEntity item in Data)
                retval.AddRange(item.GetQueryPageInfo(fieldName, depth));

            if (PageInfo.HasNextPage && !string.IsNullOrEmpty(PageInfo.EndCursor))
                retval.Add(new(fieldName, depth, PageInfo.EndCursor));

            return retval;
        }
    }
}
