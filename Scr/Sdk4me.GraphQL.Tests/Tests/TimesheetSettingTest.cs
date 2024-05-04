using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class TimesheetSettingTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<TimesheetSetting> timesheetSettings = client.Get(Query.TimesheetSetting
                .View(DefaultView.None)
                .SelectAll()
                .SelectEffortClasses(new EffortClassQuery()
                    .SelectAll())
                .SelectOrganizations(new OrganizationQuery()
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(timesheetSettings);
            Console.WriteLine($"Count: {timesheetSettings.Count}");

            if (timesheetSettings.Any())
            {
                timesheetSettings = client.Get(new TimesheetSettingQuery(timesheetSettings.First().ID)).Result;
                Assert.IsNotNull(timesheetSettings);
            }
        }
    }
}
