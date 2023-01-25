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
                ).Result;

            Assert.IsNotNull(archives);
            Console.WriteLine($"Count: {archives.Count}");
        }
    }
}
