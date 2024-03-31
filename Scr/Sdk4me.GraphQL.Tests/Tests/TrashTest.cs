namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class TrashTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<Trash> trashes = client.Get(Query.Trash
                .View(TrashView.All)
                .SelectAll()
                .SelectTrashed(new PersonQuery()
                    .Select(PersonField.ID)
                    )
                ).Result;

            Assert.IsNotNull(trashes);
            Console.WriteLine($"Count: {trashes.Count}");

            if (trashes.Any())
            {
                Trash? trash = client.Get(new TrashQuery(trashes.First().ID)).Result.FirstOrDefault();
                Assert.IsNotNull(trash);
                Assert.IsNotNull(trash.ID);
                Assert.IsNotNull(trash.CreatedAt);
            }
        }
    }
}
