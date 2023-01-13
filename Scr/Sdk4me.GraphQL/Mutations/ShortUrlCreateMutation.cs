namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new short URL.
    /// </summary>
    internal class ShortUrlCreateMutation : Mutation<ShortUrlCreatePayload, ShortUrlCreateInput>
    {
        /// <summary>
        /// Initialize an new ShortUrlCreate mutation instance.
        /// </summary>
        internal ShortUrlCreateMutation(ShortUrlCreateInput data)
            : base("shortUrlCreate", "ShortUrlCreateInput!", data, new HashSet<IQuery>() { new ShortUrlQuery() { FieldName = "shortUrl", IsConnection = false }.Select("*") })
        {
        }
    }
}
