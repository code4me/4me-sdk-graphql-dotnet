using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class CalendarTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<Calendar> calendars = client.Get(Query.Calendar
                .View(DefaultView.None)
                .SelectAll()
                .SelectCalendarHours(new CalendarHourQuery()
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(calendars);
            Console.WriteLine($"Count: {calendars.Count}");

            Calendar? calendar = calendars.FirstOrDefault();
            Assert.IsNotNull(calendar);
            Assert.IsNotNull(calendar.CalendarHours);
            Assert.IsTrue(calendar.CalendarHours.Count > 1);

            if (calendars.Any())
            {
                calendars = client.Get(new CalendarQuery(calendars.First().ID)).Result;
                Assert.IsNotNull(calendars);
            }
        }
    }
}
