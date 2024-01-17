namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class MeTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<Person> me = client.Get(Query.Me
                .View(DefaultView.None)
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

            Assert.IsNotNull(me);
            Console.WriteLine($"Count: {me.Count}");
            Assert.IsTrue(me.Count == 1);
        }

        [TestMethod]
        public void RateLimit()
        {
            DataList<Person> me = client.Get(Query.Me
                .View(DefaultView.None)
                .SelectAll()).Result;
            Assert.IsNotNull(me);

            AuthenticationToken token = Client.AuthenticationTokens.First();
            int requestLimit = token.RequestLimit;
            int requestRemaining = token.RequestsRemaining;
            int costLimit = token.CostLimit;
            int costRemaining = token.CostLimitRemaining;

            me = client.Get(Query.Me
                .View(DefaultView.None)
                .SelectAll()).Result;
            Assert.IsNotNull(me);

            Assert.IsTrue(token.RequestLimit == requestLimit);
            Assert.IsTrue(token.RequestsRemaining == requestRemaining - 1);
            Assert.IsTrue(token.CostLimit == costLimit);
            Assert.IsTrue(token.CostLimitRemaining == costRemaining - 1);
        }
    }
}
