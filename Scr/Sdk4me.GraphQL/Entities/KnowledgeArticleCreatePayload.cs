using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/knowledgearticlecreatepayload/">KnowledgeArticleCreatePayload</see> object.
    /// </summary>
    public class KnowledgeArticleCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("knowledgeArticle"), Sdk4meField(IsDefaultQueryProperty = true)]
        public KnowledgeArticle? KnowledgeArticle { get; internal set; }
    }
}
