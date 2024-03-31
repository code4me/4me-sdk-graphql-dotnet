namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class ArchiveTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<Archive> archives = client.Get(Query.Archive
                .View(ArchiveView.All)
                .SelectAll()
                .SelectArchived(new PersonQuery().Select(PersonField.ID))
                ).Result;

            Assert.IsNotNull(archives);
            Console.WriteLine($"Count: {archives.Count}");

            if (archives.Any())
            {
                archives = client.Get(new ArchiveQuery(archives.First().ID)).Result;
                Assert.IsNotNull(archives);
            }
        }
    }
}
