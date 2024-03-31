namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class ProductCategoryTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<ProductCategory> productCategories = client.Get(Query.ProductCategory
                .View(DefaultView.None)
                .SelectAll()
                .SelectProducts(new ProductQuery()
                    .SelectAll())
                .SelectTranslations(new TranslationQuery()
                    .SelectAll()
                    .SelectOwner(new ProductCategoryQuery()
                        .SelectAll()
                        .ItemsPerRequest(1)))
                ).Result;

            Assert.IsNotNull(productCategories);
            Console.WriteLine($"Count: {productCategories.Count}");

            if (productCategories.Any())
            {
                productCategories = client.Get(new ProductCategoryQuery(productCategories.First().ID)).Result;
                Assert.IsNotNull(productCategories);
            }
        }
    }
}
