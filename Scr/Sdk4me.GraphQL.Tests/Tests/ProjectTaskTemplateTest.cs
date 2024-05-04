using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class ProjectTaskTemplateTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<ProjectTaskTemplate> projectTaskTemplates = client.Get(Query.ProjectTaskTemplate
                .View(ProjectTaskTemplateView.All)
                .SelectAll()
                .SelectAssignments(new ProjectTaskTemplateAssignmentQuery()
                    .SelectAll())
                .SelectAutomationRules(new AutomationRuleQuery()
                    .SelectAll())
                .SelectInstructionsAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectNoteAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectProjectTemplates(new ProjectTemplateQuery()
                    .SelectAll())
                .SelectTasks(new ProjectTaskQuery()
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(projectTaskTemplates);
            Console.WriteLine($"Count: {projectTaskTemplates.Count}");

            if (projectTaskTemplates.Any())
            {
                projectTaskTemplates = client.Get(new ProjectTaskTemplateQuery(projectTaskTemplates.First().ID)).Result;
                Assert.IsNotNull(projectTaskTemplates);
            }
        }
    }
}
