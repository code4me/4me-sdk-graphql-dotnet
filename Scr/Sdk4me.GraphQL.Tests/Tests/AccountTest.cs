namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class AccountTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            Account account = client.Account().Result;
            Assert.IsNotNull(account);
            Assert.IsTrue(account.GetIdentifier() == 0);
        }
    }
}
