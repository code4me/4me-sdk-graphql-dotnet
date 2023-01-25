namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class TranslationTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<Translation> translations = client.Get(Query.Translation
                .View(TranslationView.CurrentAccount)
                .SelectAll()
                .SelectOwner(new HasTranslationsQuery()
                    .ItemsPerRequest(1)
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(translations);
            Console.WriteLine($"Count: {translations.Count}");
        }
    }
}
