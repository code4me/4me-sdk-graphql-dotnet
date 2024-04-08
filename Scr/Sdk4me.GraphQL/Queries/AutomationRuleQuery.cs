namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving AutomationRule records.
    /// </summary>
    public class AutomationRuleQuery : Query<AutomationRuleQuery, AutomationRuleField, AutomationRuleView, AutomationRuleOrderField>
    {
        /// <summary>
        /// Initialize a new automation rule query instance.
        /// </summary>
        public AutomationRuleQuery()
            : base("automationRules", typeof(AutomationRule), true)
        {
        }

        /// <summary>
        /// Initialize a new automation rule query instance.
        /// <br>Additional filters and views will be ignored.</br>
        /// </summary>
        /// <param name="id">The ID of the automation rule.</param>
        public AutomationRuleQuery(string id)
            : base("AutomationRule", id, typeof(AutomationRule), false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        public AutomationRuleQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The Actions field is used to define actions that should be executed when the condition of the automation rule is met.
        /// </summary>
        public AutomationRuleQuery SelectActions(AutomationRuleActionQuery query)
        {
            query.FieldName = "actions";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The Expressions field is used to define expressions that can subsequently be used to define the rule's conditions and the update action(s) that the rule is to perform.
        /// </summary>
        public AutomationRuleQuery SelectExpressions(AutomationRuleExpressionQuery query)
        {
            query.FieldName = "expressions";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record that the automation rule is linked to.
        /// <para>
        /// <br>Use this method to cast different object types supporting <see cref="IHasAutomationRules"></see>.</br>
        /// <br>If any query parameter is not provided (defaults to null), a new instance of the respective query type is created with the <c>ID</c> field selected.</br>
        /// </para>
        /// </summary>
        public AutomationRuleQuery SelectOwner(
            ProjectTaskQuery? projectTaskQuery = null,
            ProjectTaskTemplateQuery? projectTaskTemplateQuery = null,
            ProjectTaskTemplateRelationQuery? projectTaskTemplateRelationQuery = null,
            RequestQuery? requestQuery = null,
            RequestTemplateQuery? requestTemplateQuery = null,
            TaskQuery? taskQuery = null,
            TaskTemplateQuery? taskTemplateQuery = null,
            WorkflowQuery? workflowQuery = null,
            WorkflowTaskTemplateRelationQuery? workflowTaskTemplateRelationQuery = null,
            WorkflowTemplateQuery? workflowTemplateQuery = null)
        {
            projectTaskQuery ??= new ProjectTaskQuery().Select(ProjectTaskField.ID);
            AutomationRuleQuery query = SelectOwner(projectTaskQuery);
            query.OnTypesQueries.Add("ProjectTask", projectTaskQuery.Clone());

            projectTaskTemplateQuery ??= new ProjectTaskTemplateQuery().Select(ProjectTaskTemplateField.ID);
            query = SelectOwner(projectTaskTemplateQuery);
            query.OnTypesQueries.Add("ProjectTaskTemplate", projectTaskTemplateQuery.Clone());

            projectTaskTemplateRelationQuery ??= new ProjectTaskTemplateRelationQuery().Select(ProjectTaskTemplateRelationField.ID);
            query = SelectOwner(projectTaskTemplateRelationQuery);
            query.OnTypesQueries.Add("ProjectTaskTemplateRelation", projectTaskTemplateRelationQuery.Clone());

            requestQuery ??= new RequestQuery().Select(RequestField.ID);
            query = SelectOwner(requestQuery);
            query.OnTypesQueries.Add("Request", requestQuery.Clone());

            requestTemplateQuery ??= new RequestTemplateQuery().Select(RequestTemplateField.ID);
            query = SelectOwner(requestTemplateQuery);
            query.OnTypesQueries.Add("RequestTemplate", requestTemplateQuery.Clone());

            taskQuery ??= new TaskQuery().Select(TaskField.ID);
            query = SelectOwner(taskQuery);
            query.OnTypesQueries.Add("Task", taskQuery.Clone());

            taskTemplateQuery ??= new TaskTemplateQuery().Select(TaskTemplateField.ID);
            query = SelectOwner(taskTemplateQuery);
            query.OnTypesQueries.Add("TaskTemplate", taskTemplateQuery.Clone());

            workflowQuery ??= new WorkflowQuery().Select(WorkflowField.ID);
            query = SelectOwner(workflowQuery);
            query.OnTypesQueries.Add("Workflow", workflowQuery.Clone());

            workflowTaskTemplateRelationQuery ??= new WorkflowTaskTemplateRelationQuery().Select(WorkflowTaskTemplateRelationField.ID);
            query = SelectOwner(workflowTaskTemplateRelationQuery);
            query.OnTypesQueries.Add("WorkflowTaskTemplateRelation", workflowTaskTemplateRelationQuery.Clone());

            workflowTemplateQuery ??= new WorkflowTemplateQuery().Select(WorkflowTemplateField.ID);
            query = SelectOwner(workflowTemplateQuery);
            query.OnTypesQueries.Add("WorkflowTemplate", workflowTemplateQuery.Clone());

            return query;
        }

        /// <summary>
        /// The record that the automation rule is linked to.
        /// <para>
        /// <br>Use this method along with other <c>SelectOwner(IQuery)</c> calls to cast different object types supporting <see cref="IHasAutomationRules"></see>.</br>
        /// <br>If a specific type is not queried via <c>SelectRecord(IQuery)</c>, it defaults to a null object.</br>
        /// </para>
        /// </summary>
        public AutomationRuleQuery SelectOwner(ProjectTaskQuery query)
        {
            query.FieldName = "owner";
            query.OnTypesQueries.Add("ProjectTask", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record that the automation rule is linked to.
        /// <para>
        /// <br>Use this method along with other <c>SelectOwner(IQuery)</c> calls to cast different object types supporting <see cref="IHasAutomationRules"></see>.</br>
        /// <br>If a specific type is not queried via <c>SelectRecord(IQuery)</c>, it defaults to a null object.</br>
        /// </para>
        /// </summary>
        public AutomationRuleQuery SelectOwner(ProjectTaskTemplateQuery query)
        {
            query.FieldName = "owner";
            query.OnTypesQueries.Add("ProjectTaskTemplate", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record that the automation rule is linked to.
        /// <para>
        /// <br>Use this method along with other <c>SelectOwner(IQuery)</c> calls to cast different object types supporting <see cref="IHasAutomationRules"></see>.</br>
        /// <br>If a specific type is not queried via <c>SelectRecord(IQuery)</c>, it defaults to a null object.</br>
        /// </para>
        /// </summary>
        public AutomationRuleQuery SelectOwner(ProjectTaskTemplateRelationQuery query)
        {
            query.FieldName = "owner";
            query.OnTypesQueries.Add("ProjectTaskTemplateRelation", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record that the automation rule is linked to.
        /// <para>
        /// <br>Use this method along with other <c>SelectOwner(IQuery)</c> calls to cast different object types supporting <see cref="IHasAutomationRules"></see>.</br>
        /// <br>If a specific type is not queried via <c>SelectRecord(IQuery)</c>, it defaults to a null object.</br>
        /// </para>
        /// </summary>
        public AutomationRuleQuery SelectOwner(RequestQuery query)
        {
            query.FieldName = "owner";
            query.OnTypesQueries.Add("Request", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record that the automation rule is linked to.
        /// <para>
        /// <br>Use this method along with other <c>SelectOwner(IQuery)</c> calls to cast different object types supporting <see cref="IHasAutomationRules"></see>.</br>
        /// <br>If a specific type is not queried via <c>SelectRecord(IQuery)</c>, it defaults to a null object.</br>
        /// </para>
        /// </summary>
        public AutomationRuleQuery SelectOwner(RequestTemplateQuery query)
        {
            query.FieldName = "owner";
            query.OnTypesQueries.Add("RequestTemplate", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record that the automation rule is linked to.
        /// <para>
        /// <br>Use this method along with other <c>SelectOwner(IQuery)</c> calls to cast different object types supporting <see cref="IHasAutomationRules"></see>.</br>
        /// <br>If a specific type is not queried via <c>SelectRecord(IQuery)</c>, it defaults to a null object.</br>
        /// </para>
        /// </summary>
        public AutomationRuleQuery SelectOwner(TaskQuery query)
        {
            query.FieldName = "owner";
            query.OnTypesQueries.Add("Task", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record that the automation rule is linked to.
        /// <para>
        /// <br>Use this method along with other <c>SelectOwner(IQuery)</c> calls to cast different object types supporting <see cref="IHasAutomationRules"></see>.</br>
        /// <br>If a specific type is not queried via <c>SelectRecord(IQuery)</c>, it defaults to a null object.</br>
        /// </para>
        /// </summary>
        public AutomationRuleQuery SelectOwner(TaskTemplateQuery query)
        {
            query.FieldName = "owner";
            query.OnTypesQueries.Add("TaskTemplate", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record that the automation rule is linked to.
        /// <para>
        /// <br>Use this method along with other <c>SelectOwner(IQuery)</c> calls to cast different object types supporting <see cref="IHasAutomationRules"></see>.</br>
        /// <br>If a specific type is not queried via <c>SelectRecord(IQuery)</c>, it defaults to a null object.</br>
        /// </para>
        /// </summary>
        public AutomationRuleQuery SelectOwner(WorkflowQuery query)
        {
            query.FieldName = "owner";
            query.OnTypesQueries.Add("Workflow", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record that the automation rule is linked to.
        /// <para>
        /// <br>Use this method along with other <c>SelectOwner(IQuery)</c> calls to cast different object types supporting <see cref="IHasAutomationRules"></see>.</br>
        /// <br>If a specific type is not queried via <c>SelectRecord(IQuery)</c>, it defaults to a null object.</br>
        /// </para>
        /// </summary>
        public AutomationRuleQuery SelectOwner(WorkflowTaskTemplateRelationQuery query)
        {
            query.FieldName = "owner";
            query.OnTypesQueries.Add("WorkflowTaskTemplateRelation", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record that the automation rule is linked to.
        /// <para>
        /// <br>Use this method along with other <c>SelectOwner(IQuery)</c> calls to cast different object types supporting <see cref="IHasAutomationRules"></see>.</br>
        /// <br>If a specific type is not queried via <c>SelectRecord(IQuery)</c>, it defaults to a null object.</br>
        /// </para>
        /// </summary>
        public AutomationRuleQuery SelectOwner(WorkflowTemplateQuery query)
        {
            query.FieldName = "owner";
            query.OnTypesQueries.Add("WorkflowTemplate", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }
    }
}
