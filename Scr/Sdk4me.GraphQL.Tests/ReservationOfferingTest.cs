namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class ReservationOfferingTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<ReservationOffering> reservationOfferings = client.Get(Query.ReservationOffering
                .View(ReservationOfferingView.All)
                .SelectAll()
                .SelectConfigurationItems(new ConfigurationItemQuery()
                    .SelectAll())
                .SelectRequestTemplates(new RequestTemplateQuery()
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(reservationOfferings);
            Console.WriteLine($"Count: {reservationOfferings.Count}");
        }
    }
}
