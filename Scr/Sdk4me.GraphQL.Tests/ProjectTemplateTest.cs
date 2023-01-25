namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class ProjectTemplateTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<ProjectTemplate> projectTemplates = client.Get(Query.ProjectTemplate
                .View(ProjectTemplateView.All)
                .SelectAll()
                .SelectPhases(new ProjectTemplatePhaseQuery()
                    .SelectAll())
                .SelectTaskTemplateRelations(new ProjectTaskTemplateRelationQuery()
                    .SelectAll()
                    .ItemsPerRequest(50)
                    .SelectAutomationRules(new AutomationRuleQuery()
                        .SelectAll()
                        .ItemsPerRequest(10)))
                ).Result;

            Assert.IsNotNull(projectTemplates);
            Console.WriteLine($"Count: {projectTemplates.Count}");
        }
    }
}
