namespace Sdk4me.GraphQL
{
    /// <summary>
    /// A 4me GraphQL response page info object.
    /// </summary>
    internal class PageInfo
    {
        /// <summary>
        /// Gets or sets the response end cursor of this page.
        /// </summary>
        [JsonProperty("endCursor")]
        internal string EndCursor { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets if the response has a next page.
        /// </summary>
        [JsonProperty("hasNextPage")]
        internal bool HasNextPage { get; set; } = false;
    }
}
