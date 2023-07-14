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
                ).Result;

            Assert.IsNotNull(trashes);
            Console.WriteLine($"Count: {trashes.Count}");

            if (trashes.Any())
            {
                trashes = client.Get(new TrashQuery(trashes.First().ID)).Result;
                Assert.IsNotNull(trashes);
            }
        }
    }
}
