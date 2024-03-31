namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class KnowledgeArticleTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<KnowledgeArticle> knowledgeArticles = client.Get(Query.KnowledgeArticle
                .View(KnowledgeArticleView.All)
                .SelectAll()
                .SelectCustomFieldsAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectDescriptionAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectInstructionsAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectRequests(new RequestQuery()
                    .SelectAll())
                .SelectServiceInstances(new ServiceInstanceQuery()
                    .SelectAll())
                .SelectTranslations(new TranslationQuery()
                    .SelectAll()
                    .SelectOwner(new KnowledgeArticleQuery()
                        .ItemsPerRequest(1)
                        .SelectAll()))
                ).Result;

            Assert.IsNotNull(knowledgeArticles);
            Console.WriteLine($"Count: {knowledgeArticles.Count}");

            if (knowledgeArticles.Any())
            {
                knowledgeArticles = client.Get(new KnowledgeArticleQuery(knowledgeArticles.First().ID)).Result;
                Assert.IsNotNull(knowledgeArticles);
            }
        }
    }
}
