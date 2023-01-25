namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class ShopArticleTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<ShopArticle> shopArticles = client.Get(Query.ShopArticle
                .View(ShopArticleView.All)
                .SelectAll()
                ).Result;

            Assert.IsNotNull(shopArticles);
            Console.WriteLine($"Count: {shopArticles.Count}");
        }
    }
}
