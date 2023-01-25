namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class WorkflowTemplateTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Get()
        {
            DataList<WorkflowTemplate> workflowTemplates = client.Get(Query.WorkflowTemplate
                .View(WorkflowTemplateView.All)
                .SelectAll()
                .SelectAutomationRules(new AutomationRuleQuery()
                    .SelectAll())
                .SelectInstructionsAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectNoteAttachments(new AttachmentQuery()
                    .SelectAll())
                .SelectTaskTemplateRelations(new WorkflowTaskTemplateRelationQuery()
                    .SelectAll())
                .SelectWorkflows(new WorkflowQuery()
                    .SelectAll())
                ).Result;

            Assert.IsNotNull(workflowTemplates);
            Console.WriteLine($"Count: {workflowTemplates.Count}");
        }
    }
}
