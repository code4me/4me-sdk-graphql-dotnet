namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class ProjectRiskLevelTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<ProjectRiskLevel> projectRiskLevels = client.Get(Query.ProjectRiskLevel
                .View(DefaultView.None)
                .SelectAll()
                .SelectInformationAttachments(new AttachmentQuery()
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(projectRiskLevels);
            Console.WriteLine($"Count: {projectRiskLevels.Count}");

            if (projectRiskLevels.Any())
            {
                projectRiskLevels = client.Get(new ProjectRiskLevelQuery(projectRiskLevels.First().ID)).Result;
                Assert.IsNotNull(projectRiskLevels);
            }
        }
    }
}
