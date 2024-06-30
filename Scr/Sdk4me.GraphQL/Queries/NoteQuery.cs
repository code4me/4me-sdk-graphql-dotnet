namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="Note">Note</see> query.
    /// </summary>
    public class NoteQuery : Query<NoteQuery, NoteField, DefaultView, DefaultFilter, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new note query instance.
        /// </summary>
        public NoteQuery()
            : base("", typeof(Note), true)
        {
        }

        /// <summary>
        /// The account.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public NoteQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The inbound email from which the note was created.
        /// </summary>
        /// <param name="query">The inbound email query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public NoteQuery SelectInboundEmail(InboundEmailQuery query)
        {
            query.FieldName = "inboundEmail";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The note reactions belonging to this note.
        /// </summary>
        /// <param name="query">The note reaction query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public NoteQuery SelectNoteReactions(NoteReactionQuery query)
        {
            query.FieldName = "noteReactions";
            return Select(query);
        }

        /// <summary>
        /// Person who added this note.
        /// </summary>
        /// <param name="query">The person query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public NoteQuery SelectPerson(PersonQuery query)
        {
            query.FieldName = "person";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Files and inline images linked to the Text field.
        /// </summary>
        /// <param name="query">The attachment query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public NoteQuery SelectTextAttachments(AttachmentQuery query)
        {
            query.FieldName = "textAttachments";
            return Select(query);
        }
    }
}
