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
        public InboundEmailQuery SelectRecord(HasNotesQuery query)
        {
            query.FieldName = "record";
            return Select(query);
        }
    }
}
