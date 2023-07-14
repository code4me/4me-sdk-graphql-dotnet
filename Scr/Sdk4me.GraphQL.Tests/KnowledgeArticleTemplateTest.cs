namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class KnowledgeArticleTemplateTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<KnowledgeArticleTemplate> knowledgeArticleTemplates = client.Get(Query.KnowledgeArticleTemplate
                .View(KnowledgeArticleTemplateView.All)
                .SelectAll()
                .SelectServiceInstances(new ServiceInstanceQuery()
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(knowledgeArticleTemplates);
            Console.WriteLine($"Count: {knowledgeArticleTemplates.Count}");

            if (knowledgeArticleTemplates.Any())
            {
                knowledgeArticleTemplates = client.Get(new KnowledgeArticleTemplateQuery(knowledgeArticleTemplates.First().ID)).Result;
                Assert.IsNotNull(knowledgeArticleTemplates);
            }
        }
    }
}
