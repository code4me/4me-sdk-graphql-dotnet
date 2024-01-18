namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class BroadcastTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<Broadcast> broadcasts = client.Get(Query.Broadcast
                .View(DefaultView.None)
                .SelectAll()
                .SelectCustomers(new OrganizationQuery()
                    .ItemsPerRequest(10)
                    .SelectAll()
                    .SelectAddresses(new AddressQuery()
                        .ItemsPerRequest(10)
                        .SelectAll())
                    .SelectChildOrganizations(new OrganizationQuery()
                    .ItemsPerRequest(10)
                        .SelectAll())
                    .SelectContacts(new ContactQuery()
                        .ItemsPerRequest(10)
                        .SelectAll())
                    .SelectCustomFieldsAttachments(new AttachmentQuery()
                        .ItemsPerRequest(10)
                        .SelectAll()))
                    .SelectRemarksAttachments(new AttachmentQuery()
                        .ItemsPerRequest(10)
                        .SelectAll())
                    .SelectTranslations(new BroadcastTranslationQuery()
                        .ItemsPerRequest(1))
                ).Result;

            Assert.IsNotNull(broadcasts);
            Console.WriteLine($"Count: {broadcasts.Count}");

            if (broadcasts.Any())
            {
                broadcasts = client.Get(new BroadcastQuery(broadcasts.First().ID)).Result;
                Assert.IsNotNull(broadcasts);
            }
        }
    }
}
