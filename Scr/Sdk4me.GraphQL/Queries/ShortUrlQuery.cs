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
