using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/shoparticlecategorycreatepayload/">ShopArticleCategoryCreatePayload</see> object.
    /// </summary>
    public class ShopArticleCategoryCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("shopArticleCategory"), Sdk4meField(true)]
        public ShopArticleCategory? ShopArticleCategory { get; internal set; }
    }
}
