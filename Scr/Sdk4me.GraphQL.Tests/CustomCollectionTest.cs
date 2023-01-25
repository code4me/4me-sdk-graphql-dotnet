namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class CustomCollectionTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<CustomCollection> customCollections = client.Get(Query.CustomCollection
                .View(DefaultView.None)
                .SelectAll()
                .SelectCollectionElements(new CustomCollectionElementQuery()
                    .SelectAll())
                .SelectDescriptionAttachments(new AttachmentQuery()
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(customCollections);
            Console.WriteLine($"Count: {customCollections.Count}");

        }
    }
}
