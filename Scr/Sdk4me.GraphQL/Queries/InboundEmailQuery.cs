namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="InboundEmail">InboundEmail</see> query.
    /// </summary>
    public class InboundEmailQuery : Query<InboundEmailQuery, InboundEmailField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new inbound email query instance.
        /// </summary>
        public InboundEmailQuery()
            : base("", typeof(InboundEmail), false)
        {
        }

        /// <summary>
        /// The account that received the inbound email.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public InboundEmailQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The note that was created from the inbound email.
        /// </summary>
        /// <param name="query">The note query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public InboundEmailQuery SelectNote(NoteQuery query)
        {
            query.FieldName = "note";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record that was created or updated from the inbound email.
        /// <para>
        /// <br>Use this method to cast different object types supporting <see cref="IHasNotes"></see>.</br>
        /// <br>If any query parameter is not provided (defaults to null), a new instance of the respective query type is created with the <c>ID</c> field selected.</br>
        /// </para>
        /// </summary>
        /// <param name="problemQuery">The problem query.</param>
        /// <param name="projectQuery">The project query.</param>
        /// <param name="projectTaskQuery">The project task query.</param>
        /// <param name="releaseQuery">The release query.</param>
        /// <param name="requestQuery">The request query.</param>
        /// <param name="riskQuery">The risk query.</param>
        /// <param name="taskQuery">The task query.</param>
        /// <param name="workflowQuery">The workflow query.</param>
        public InboundEmailQuery SelectRecord(
            ProblemQuery? problemQuery = null,
            ProjectQuery? projectQuery = null,
            ProjectTaskQuery? projectTaskQuery = null,
            ReleaseQuery? releaseQuery = null,
            RequestQuery? requestQuery = null,
            RiskQuery? riskQuery = null,
            TaskQuery? taskQuery = null,
            WorkflowQuery? workflowQuery = null)
        {
            problemQuery ??= new ProblemQuery().Select(ProblemField.ID);
            InboundEmailQuery query = SelectRecord(problemQuery);
            query.OnTypesQueries.Add("Problem", problemQuery.Clone());

            projectQuery ??= new ProjectQuery().Select(ProjectField.ID);
            query = SelectRecord(projectQuery);
            query.OnTypesQueries.Add("Project", projectQuery.Clone());

            projectTaskQuery ??= new ProjectTaskQuery().Select(ProjectTaskField.ID);
            query = SelectRecord(projectTaskQuery);
            query.OnTypesQueries.Add("ProjectTask", projectTaskQuery.Clone());

            releaseQuery ??= new ReleaseQuery().Select(ReleaseField.ID);
            query = SelectRecord(releaseQuery);
            query.OnTypesQueries.Add("Release", releaseQuery.Clone());

            requestQuery ??= new RequestQuery().Select(RequestField.ID);
            query = SelectRecord(requestQuery);
            query.OnTypesQueries.Add("Request", requestQuery.Clone());

            riskQuery ??= new RiskQuery().Select(RiskField.ID);
            query = SelectRecord(riskQuery);
            query.OnTypesQueries.Add("Risk", riskQuery.Clone());

            taskQuery ??= new TaskQuery().Select(TaskField.ID);
            query = SelectRecord(taskQuery);
            query.OnTypesQueries.Add("Task", taskQuery.Clone());

            workflowQuery ??= new WorkflowQuery().Select(WorkflowField.ID);
            query = SelectRecord(workflowQuery);
            query.OnTypesQueries.Add("Workflow", workflowQuery.Clone());

            return query;
        }

        /// <summary>
        /// The record that was created or updated from the inbound email.
        /// <para>
        /// <br>Use this method along with other <c>SelectRecord(IQuery)</c> calls to cast different object types supporting <see cref="IHasNotes"></see>.</br>
        /// <br>If a specific type is not queried via <c>SelectRecord(IQuery)</c>, it defaults to a null object.</br>
        /// </para>
        /// </summary>
        /// <param name="query">The problem query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public InboundEmailQuery SelectRecord(ProblemQuery query)
        {
            query.FieldName = "record";
            query.OnTypesQueries.Add("Problem", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record that was created or updated from the inbound email.
        /// <para>
        /// <br>Use this method along with other <c>SelectRecord(IQuery)</c> calls to cast different object types supporting <see cref="IHasNotes"></see>.</br>
        /// <br>If a specific type is not queried via <c>SelectRecord(IQuery)</c>, it defaults to a null object.</br>
        /// </para>
        /// </summary>
        /// <param name="query">The project query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public InboundEmailQuery SelectRecord(ProjectQuery query)
        {
            query.FieldName = "record";
            query.OnTypesQueries.Add("Project", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record that was created or updated from the inbound email.
        /// <para>
        /// <br>Use this method along with other <c>SelectRecord(IQuery)</c> calls to cast different object types supporting <see cref="IHasNotes"></see>.</br>
        /// <br>If a specific type is not queried via <c>SelectRecord(IQuery)</c>, it defaults to a null object.</br>
        /// </para>
        /// </summary>
        /// <param name="query">The project task query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public InboundEmailQuery SelectRecord(ProjectTaskQuery query)
        {
            query.FieldName = "record";
            query.OnTypesQueries.Add("ProjectTask", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record that was created or updated from the inbound email.
        /// <para>
        /// <br>Use this method along with other <c>SelectRecord(IQuery)</c> calls to cast different object types supporting <see cref="IHasNotes"></see>.</br>
        /// <br>If a specific type is not queried via <c>SelectRecord(IQuery)</c>, it defaults to a null object.</br>
        /// </para>
        /// </summary>
        /// <param name="query">The release query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public InboundEmailQuery SelectRecord(ReleaseQuery query)
        {
            query.FieldName = "record";
            query.OnTypesQueries.Add("Release", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record that was created or updated from the inbound email.
        /// <para>
        /// <br>Use this method along with other <c>SelectRecord(IQuery)</c> calls to cast different object types supporting <see cref="IHasNotes"></see>.</br>
        /// <br>If a specific type is not queried via <c>SelectRecord(IQuery)</c>, it defaults to a null object.</br>
        /// </para>
        /// </summary>
        /// <param name="query">The request query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public InboundEmailQuery SelectRecord(RequestQuery query)
        {
            query.FieldName = "record";
            query.OnTypesQueries.Add("Request", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record that was created or updated from the inbound email.
        /// <para>
        /// <br>Use this method along with other <c>SelectRecord(IQuery)</c> calls to cast different object types supporting <see cref="IHasNotes"></see>.</br>
        /// <br>If a specific type is not queried via <c>SelectRecord(IQuery)</c>, it defaults to a null object.</br>
        /// </para>
        /// </summary>
        /// <param name="query">The risk query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public InboundEmailQuery SelectRecord(RiskQuery query)
        {
            query.FieldName = "record";
            query.OnTypesQueries.Add("Risk", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record that was created or updated from the inbound email.
        /// <para>
        /// <br>Use this method along with other <c>SelectRecord(IQuery)</c> calls to cast different object types supporting <see cref="IHasNotes"></see>.</br>
        /// <br>If a specific type is not queried via <c>SelectRecord(IQuery)</c>, it defaults to a null object.</br>
        /// </para>
        /// </summary>
        /// <param name="query">The task query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public InboundEmailQuery SelectRecord(TaskQuery query)
        {
            query.FieldName = "record";
            query.OnTypesQueries.Add("Task", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record that was created or updated from the inbound email.
        /// <para>
        /// <br>Use this method along with other <c>SelectRecord(IQuery)</c> calls to cast different object types supporting <see cref="IHasNotes"></see>.</br>
        /// <br>If a specific type is not queried via <c>SelectRecord(IQuery)</c>, it defaults to a null object.</br>
        /// </para>
        /// </summary>
        /// <param name="query">The workflow query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public InboundEmailQuery SelectRecord(WorkflowQuery query)
        {
            query.FieldName = "record";
            query.OnTypesQueries.Add("Workflow", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }
    }
}
