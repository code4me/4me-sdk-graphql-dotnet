namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class TaskTemplateTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<TaskTemplate> taskTemplates = client.Get(Query.TaskTemplate
                .View(TaskTemplateView.All)
                .SelectAll()
                .SelectApprovals(new TaskTemplateApprovalQuery()
                    .SelectAll())
                .SelectAutomationRules(new AutomationRuleQuery()
                    .SelectAll())
                .SelectConfigurationItems(new ConfigurationItemQuery()
                    .SelectAll())
                .SelectInstructionsAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectNoteAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectServiceInstances(new ServiceInstanceQuery()
                    .SelectAll())
                .SelectTasks(new TaskQuery()
                    .SelectAll())
                .SelectWorkflowTemplates(new WorkflowTemplateQuery()
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(taskTemplates);
            Console.WriteLine($"Count: {taskTemplates.Count}");
        }
    }
}
