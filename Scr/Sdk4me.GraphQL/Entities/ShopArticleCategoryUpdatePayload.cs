using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/shoparticlecategoryupdatepayload/">ShopArticleCategoryUpdatePayload</see> object.
    /// </summary>
    public class ShopArticleCategoryUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("shopArticleCategory"), Sdk4meField(IsDefaultQueryProperty = true)]
        public ShopArticleCategory? ShopArticleCategory { get; internal set; }
    }
}
