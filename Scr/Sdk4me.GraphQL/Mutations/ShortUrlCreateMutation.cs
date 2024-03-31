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
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal ShortUrlCreateMutation(ShortUrlCreateInput data, ShortUrlQuery query)
            : base("shortUrlCreate", "ShortUrlCreateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(ShortUrlQuery query)
        {
            query.FieldName = "shortUrl";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
