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
        public InboundEmailQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The note that was created from the inbound email.
        /// </summary>
        public InboundEmailQuery SelectNote(NoteQuery query)
        {
            query.FieldName = "note";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record that was created or updated from the inbound email.
        /// </summary>
        public InboundEmailQuery SelectRecord(ProblemQuery query)
        {
            query.FieldName = "record";
            query.OnType = "Problem";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record that was created or updated from the inbound email.
        /// </summary>
        public InboundEmailQuery SelectRecord(ProjectQuery query)
        {
            query.FieldName = "record";
            query.OnType = "Project";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record that was created or updated from the inbound email.
        /// </summary>
        public InboundEmailQuery SelectRecord(ProjectTaskQuery query)
        {
            query.FieldName = "record";
            query.OnType = "ProjectTask";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record that was created or updated from the inbound email.
        /// </summary>
        public InboundEmailQuery SelectRecord(ReleaseQuery query)
        {
            query.FieldName = "record";
            query.OnType = "Release";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record that was created or updated from the inbound email.
        /// </summary>
        public InboundEmailQuery SelectRecord(RequestQuery query)
        {
            query.FieldName = "record";
            query.OnType = "Request";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record that was created or updated from the inbound email.
        /// </summary>
        public InboundEmailQuery SelectRecord(RiskQuery query)
        {
            query.FieldName = "record";
            query.OnType = "Risk";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record that was created or updated from the inbound email.
        /// </summary>
        public InboundEmailQuery SelectRecord(TaskQuery query)
        {
            query.FieldName = "record";
            query.OnType = "Task";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record that was created or updated from the inbound email.
        /// </summary>
        public InboundEmailQuery SelectRecord(WorkflowQuery query)
        {
            query.FieldName = "record";
            query.OnType = "Workflow";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
