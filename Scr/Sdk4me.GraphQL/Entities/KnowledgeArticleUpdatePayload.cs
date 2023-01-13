namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/knowledgearticleupdatepayload/">KnowledgeArticleUpdatePayload</see> object.
    /// </summary>
    public class KnowledgeArticleUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("knowledgeArticle"), Sdk4meField(true)]
        public KnowledgeArticle? KnowledgeArticle { get; internal set; }
    }
}
