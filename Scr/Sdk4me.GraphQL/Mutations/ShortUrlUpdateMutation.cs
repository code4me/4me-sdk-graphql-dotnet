namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing short URL.
    /// </summary>
    internal class ShortUrlUpdateMutation : Mutation<ShortUrlUpdatePayload, ShortUrlUpdateInput>
    {
        /// <summary>
        /// Initialize an new ShortUrlUpdate mutation instance.
        /// </summary>
        internal ShortUrlUpdateMutation(ShortUrlUpdateInput data)
            : base("shortUrlUpdate", "ShortUrlUpdateInput!", data, new HashSet<IQuery>() { new ShortUrlQuery() { FieldName = "shortUrl", IsConnection = false }.Select("*") })
        {
        }
    }
}
