namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class PdfDesignTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<PdfDesign> pdfDesigns = client.Get(Query.PdfDesign
                .View(DefaultView.None)
                .SelectAll()
                .SelectTranslations(new TranslationQuery()
                    .SelectAll()
                    .ItemsPerRequest(10)
                    .SelectOwner(new HasTranslationsQuery()
                        .ItemsPerRequest(1)
                        .SelectTranslations(new TranslationQuery())))
                ).Result;

            Assert.IsNotNull(pdfDesigns);
            Console.WriteLine($"Count: {pdfDesigns.Count}");
        }
    }
}
