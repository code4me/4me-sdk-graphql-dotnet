using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/shorturl/">ShortUrl</see> object.
    /// </summary>
    public class ShortUrl : Node
    {
        /// <summary>
        /// Unique token that someone who uses the short URL for a dashboard is asked to enter.
        /// </summary>
        [JsonProperty("accessToken")]
        public string? AccessToken { get; internal set; }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account"), Sdk4meField(IsDefaultQueryProperty = true)]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(IsDefaultQueryProperty = true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Kind of URI the short URL forwards to.
        /// </summary>
        [JsonProperty("dataType"), Sdk4meField(IsDefaultQueryProperty = true)]
        public ShortUrlDataType? DataType { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [JsonProperty("updatedAt"), Sdk4meField(IsDefaultQueryProperty = true)]
        public DateTime? UpdatedAt { get; internal set; }

        /// <summary>
        /// The uniform resource identifier (URI) to which the short URL is forwarded.
        /// </summary>
        [JsonProperty("uri")]
        public string? Uri { get; internal set; }

        /// <summary>
        /// The automatically generated website address that is forwarded to URI.
        /// </summary>
        [JsonProperty("shortUrl"), Sdk4meField(IsDefaultQueryProperty = true)]
        public string? URL { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
