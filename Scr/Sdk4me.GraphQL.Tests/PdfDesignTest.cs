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
                    .SelectDescriptionAttachments(new AttachmentQuery()
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(pdfDesigns);
            Console.WriteLine($"Count: {pdfDesigns.Count}");

            if (pdfDesigns.Any())
            {
                pdfDesigns = client.Get(new PdfDesignQuery(pdfDesigns.First().ID)).Result;
                Assert.IsNotNull(pdfDesigns);
            }
        }
    }
}
