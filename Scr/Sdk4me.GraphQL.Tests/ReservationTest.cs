namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class ReservationTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<Reservation> reservations = client.Get(Query.Reservation
                .View(ReservationView.All)
                .SelectAll()
                .SelectDescriptionAttachments(new AttachmentQuery()
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(reservations);
            Console.WriteLine($"Count: {reservations.Count}");

            if (reservations.Any())
            {
                reservations = client.Get(new ReservationQuery(reservations.First().ID)).Result;
                Assert.IsNotNull(reservations);
            }
        }
    }
}
