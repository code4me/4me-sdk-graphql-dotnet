namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class AgileBoardTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<AgileBoard> agileBoards = client.Get(Query.AgileBoard
                .View(AgileBoardView.All)
                .SelectAll()
                .SelectColumns(new AgileBoardColumnQuery()
                    .SelectAll())
                .SelectDescriptionAttachments(new AttachmentQuery()
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(agileBoards);
            Console.WriteLine($"Count: {agileBoards.Count}");

            if (agileBoards.Any())
            {
                agileBoards = client.Get(new AgileBoardQuery(agileBoards.First().ID)).Result;
                Assert.IsNotNull(agileBoards);
            }
        }
    }
}
