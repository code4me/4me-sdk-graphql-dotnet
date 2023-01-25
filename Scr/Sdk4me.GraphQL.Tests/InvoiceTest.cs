namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class InvoiceTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<Invoice> invoices = client.Get(Query.Invoice
                .View(InvoiceView.All)
                .SelectAll()
                .SelectConfigurationItems(new ConfigurationItemQuery()
                    .SelectAll())
                .SelectRemarksAttachments(new AttachmentQuery()
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(invoices);
            Console.WriteLine($"Count: {invoices.Count}");
        }
    }
}
