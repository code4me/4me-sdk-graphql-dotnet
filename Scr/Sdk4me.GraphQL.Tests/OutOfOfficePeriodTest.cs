namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class OutOfOfficePeriodTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<OutOfOfficePeriod> outOfOfficePeriods = client.Get(Query.OutOfOfficePeriod
                .View(OutOfOfficePeriodView.All)
                .SelectAll()
                ).Result;

            Assert.IsNotNull(outOfOfficePeriods);
            Console.WriteLine($"Count: {outOfOfficePeriods.Count}");

            if (outOfOfficePeriods.Any())
            {
                outOfOfficePeriods = client.Get(new OutOfOfficePeriodQuery(outOfOfficePeriods.First().ID)).Result;
                Assert.IsNotNull(outOfOfficePeriods);
            }
        }
    }
}
