namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class TaskTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<Task> tasks = client.Get(Query.Task
                .View(TaskView.All)
                .SelectAll()
                .SelectApprovals(new TaskApprovalQuery()
                    .SelectAll())
                .SelectAutomationRules(new AutomationRuleQuery()
                    .SelectAll())
                .SelectConfigurationItems(new ConfigurationItemQuery()
                    .SelectAll())
                .SelectCustomFieldsAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectInstructionsAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectNotes(new NoteQuery()
                    .SelectAll())
                .SelectServiceInstances(new ServiceInstanceQuery()
                    .SelectAll())
                .SelectSprintBacklogItems(new SprintBacklogItemQuery()
                    .SelectAll())
                .SelectTimeEntries(new TimeEntryQuery()
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(tasks);
            Console.WriteLine($"Count: {tasks.Count}");
        }
    }
}
