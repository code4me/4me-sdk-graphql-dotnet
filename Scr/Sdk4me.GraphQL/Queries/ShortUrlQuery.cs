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

        /// <summary>
        /// Initialize a new short url query instance.
        /// <br>Additional filters and views will be ignored.</br>
        /// </summary>
        /// <param name="id">The ID of the short url.</param>
        public ShortUrlQuery(string id)
            : base("ShortUrl", id, typeof(ShortUrl), false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        public ShortUrlQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
