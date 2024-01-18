using System.Threading.Tasks;

namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class TeamTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<Team> teams = client.Get(Query.Team
                .View(TeamView.All)
                .SelectAll()
                .SelectCustomFieldsAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectMembers(new PersonQuery()
                    .SelectAll())
                .SelectRemarksAttachments(new AttachmentQuery()
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(teams);
            Console.WriteLine($"Count: {teams.Count}");

            if (teams.Any())
            {
                teams = client.Get(new TeamQuery(teams.First().ID)).Result;
                Assert.IsNotNull(teams);
            }
        }
    }
}
