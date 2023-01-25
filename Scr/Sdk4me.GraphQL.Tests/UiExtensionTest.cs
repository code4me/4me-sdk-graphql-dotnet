namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class UiExtensionTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<UiExtension> uiExtensions = client.Get(Query.UiExtension
                .View(UiExtensionView.All)
                .SelectAll()
                .SelectDescriptionAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectTranslations(new TranslationQuery()
                    .SelectAll())
                .SelectVersions(new UiExtensionVersionQuery()
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(uiExtensions);
            Console.WriteLine($"Count: {uiExtensions.Count}");
        }
    }
}
