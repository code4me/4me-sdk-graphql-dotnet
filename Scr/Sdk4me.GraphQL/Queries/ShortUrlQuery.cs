namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving ShortUrl records.
    /// </summary>
    public class ShortUrlQuery : Query<ShortUrlQuery, ShortUrlField, ShortUrlView, ShortUrlOrderField>
    {
        /// <summary>
        /// Initialize a new short url query instance.
        /// </summary>
        public ShortUrlQuery()
            : base("shortUrls", typeof(ShortUrl), true)
        {
        }
    }
}
