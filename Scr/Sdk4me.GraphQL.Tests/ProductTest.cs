namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class ProductTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<Product> products = client.Get(Query.Product
                .View(ProductView.All)
                .SelectAll()
                .SelectConfigurationItems(new ConfigurationItemQuery()
                    .SelectAll())
                .SelectCustomFieldsAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectRemarksAttachments(new AttachmentQuery()
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(products);
            Console.WriteLine($"Count: {products.Count}");

            if (products.Any())
            {
                products = client.Get(new ProductQuery(products.First().ID)).Result;
                Assert.IsNotNull(products);
            }
        }
    }
}
