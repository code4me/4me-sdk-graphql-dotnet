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
        /// <br>Use this method along with other <c>SelectRecord(IQuery)</c> calls to cast different object types supporting <see cref="IHasNotes"></see>.</br>
        /// </summary>
        public InboundEmailQuery SelectRecord(ProblemQuery query)
        {
            query.FieldName = "record";
            query.OnTypesQueries.Add("Problem", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record that was created or updated from the inbound email.
        /// <br>Use this method along with other <c>SelectRecord(IQuery)</c> calls to cast different object types supporting <see cref="IHasNotes"></see>.</br>
        /// </summary>
        public InboundEmailQuery SelectRecord(ProjectQuery query)
        {
            query.FieldName = "record";
            query.OnTypesQueries.Add("Project", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record that was created or updated from the inbound email.
        /// <br>Use this method along with other <c>SelectRecord(IQuery)</c> calls to cast different object types supporting <see cref="IHasNotes"></see>.</br>
        /// </summary>
        public InboundEmailQuery SelectRecord(ProjectTaskQuery query)
        {
            query.FieldName = "record";
            query.OnTypesQueries.Add("ProjectTask", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record that was created or updated from the inbound email.
        /// <br>Use this method along with other <c>SelectRecord(IQuery)</c> calls to cast different object types supporting <see cref="IHasNotes"></see>.</br>
        /// </summary>
        public InboundEmailQuery SelectRecord(ReleaseQuery query)
        {
            query.FieldName = "record";
            query.OnTypesQueries.Add("Release", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record that was created or updated from the inbound email.
        /// <br>Use this method along with other <c>SelectRecord(IQuery)</c> calls to cast different object types supporting <see cref="IHasNotes"></see>.</br>
        /// </summary>
        public InboundEmailQuery SelectRecord(RequestQuery query)
        {
            query.FieldName = "record";
            query.OnTypesQueries.Add("Request", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record that was created or updated from the inbound email.
        /// <br>Use this method along with other <c>SelectRecord(IQuery)</c> calls to cast different object types supporting <see cref="IHasNotes"></see>.</br>
        /// </summary>
        public InboundEmailQuery SelectRecord(RiskQuery query)
        {
            query.FieldName = "record";
            query.OnTypesQueries.Add("Risk", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record that was created or updated from the inbound email.
        /// <br>Use this method along with other <c>SelectRecord(IQuery)</c> calls to cast different object types supporting <see cref="IHasNotes"></see>.</br>
        /// </summary>
        public InboundEmailQuery SelectRecord(TaskQuery query)
        {
            query.FieldName = "record";
            query.OnTypesQueries.Add("Task", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record that was created or updated from the inbound email.
        /// <br>Use this method along with other <c>SelectRecord(IQuery)</c> calls to cast different object types supporting <see cref="IHasNotes"></see>.</br>
        /// </summary>
        public InboundEmailQuery SelectRecord(WorkflowQuery query)
        {
            query.FieldName = "record";
            query.OnTypesQueries.Add("Workflow", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }
    }
}
