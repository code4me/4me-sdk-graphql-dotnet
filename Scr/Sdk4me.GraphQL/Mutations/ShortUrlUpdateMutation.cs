using System.Collections.Generic;

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
        /// <param name="data">The input data.</param>
        /// <param name="query">The short url response query.</param>
        internal ShortUrlUpdateMutation(ShortUrlUpdateInput data, ShortUrlQuery query)
            : base("shortUrlUpdate", "ShortUrlUpdateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The short url response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(ShortUrlQuery query)
        {
            query.FieldName = "shortUrl";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
