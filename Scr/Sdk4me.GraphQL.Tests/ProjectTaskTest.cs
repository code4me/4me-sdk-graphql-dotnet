namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class ProjectTaskTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<ProjectTask> projects = client.Get(Query.ProjectTask
                .View(ProjectTaskView.All)
                .SelectAll()
                .SelectAssignments(new ProjectTaskAssignmentQuery()
                    .SelectAll())
                .SelectAutomationRules(new AutomationRuleQuery()
                    .SelectAll())
                .SelectCustomFieldsAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectInstructionsAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectNotes(new NoteQuery()
                    .SelectAll())
                .SelectPredecessors(new ProjectTaskQuery()
                    .SelectAll())
                .SelectSprintBacklogItems(new SprintBacklogItemQuery()
                    .SelectAll())
                .SelectSuccessors(new ProjectTaskQuery()
                    .SelectAll())
                .SelectTimeEntries(new TimeEntryQuery()
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(projects);
            Console.WriteLine($"Count: {projects.Count}");
        }
    }
}
