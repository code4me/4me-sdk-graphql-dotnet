namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class PersonTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<Person> people = client.Get(Query.Person
                .View(PersonView.All)
                .SelectAll()
                .SelectAddresses(new AddressQuery()
                    .SelectAll())
                .SelectCart(new ShopOrderLineQuery()
                    .SelectAll())
                .SelectConfigurationItems(new ConfigurationItemQuery()
                    .SelectAll())
                .SelectContacts(new ContactQuery()
                    .SelectAll())
                .SelectCustomFieldsAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectInformationAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectOutOfOfficePeriods(new OutOfOfficePeriodQuery()
                    .SelectAll())
                .SelectPermissions(new PermissionQuery()
                    .SelectAll())
                .SelectSkillPools(new SkillPoolQuery()
                    .SelectAll())
                .SelectTeams(new TeamQuery()
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(people);
            Console.WriteLine($"Count: {people.Count}");
        }
    }
}
