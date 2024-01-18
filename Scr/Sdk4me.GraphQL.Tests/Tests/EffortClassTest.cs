namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class EffortClassTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<EffortClass> effortClasses = client.Get(Query.EffortClass
                .View(DefaultView.None)
                .SelectAll()
                .SelectServiceOfferings(new ServiceOfferingQuery()
                    .SelectAll())
                .SelectSkillPools(new SkillPoolQuery()
                    .SelectAll())
                .SelectTimesheetSettings(new TimesheetSettingQuery()
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(effortClasses);
            Console.WriteLine($"Count: {effortClasses.Count}");

            if (effortClasses.Any())
            {
                effortClasses = client.Get(new EffortClassQuery(effortClasses.First().ID)).Result;
                Assert.IsNotNull(effortClasses);
            }
        }
    }
}
