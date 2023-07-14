namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class SiteTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<Site> sites = client.Get(Query.Site
                .View(SiteView.All)
                .SelectAll()
                .SelectAddresses(new AddressQuery()
                    .SelectAll())
                .SelectCustomFieldsAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectPeople(new PersonQuery()
                    .SelectAll())
                .SelectRemarksAttachments(new AttachmentQuery()
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(sites);
            Console.WriteLine($"Count: {sites.Count}");

            if (sites.Any())
            {
                sites = client.Get(new SiteQuery(sites.First().ID)).Result;
                Assert.IsNotNull(sites);
            }
        }
    }
}
