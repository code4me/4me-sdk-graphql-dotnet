namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/shoparticlecreatepayload/">ShopArticleCreatePayload</see> object.
    /// </summary>
    public class ShopArticleCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("shopArticle"), Sdk4meField(true)]
        public ShopArticle? ShopArticle { get; internal set; }
    }
}
