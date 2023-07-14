namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class FirstLineSupportAgreementTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<FirstLineSupportAgreement> firstLineSupportAgreements = client.Get(Query.FirstLineSupportAgreement
                .View(FirstLineSupportAgreementView.All)
                .SelectAll()
                .SelectChargesAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectInvoices(new InvoiceQuery()
                    .SelectAll())
                .SelectTargetDetailsAttachments(new AttachmentQuery()
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(firstLineSupportAgreements);
            Console.WriteLine($"Count: {firstLineSupportAgreements.Count}");

            if (firstLineSupportAgreements.Any())
            {
                firstLineSupportAgreements = client.Get(new FirstLineSupportAgreementQuery(firstLineSupportAgreements.First().ID)).Result;
                Assert.IsNotNull(firstLineSupportAgreements);
            }
        }
    }
}
