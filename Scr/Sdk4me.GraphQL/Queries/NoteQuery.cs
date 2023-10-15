namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="Note">Note</see> query.
    /// </summary>
    public class NoteQuery : Query<NoteQuery, NoteField, DefaultView, DefaultOrderField>
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
        public NoteQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The note reactions belonging to this note.
        /// </summary>
        public NoteQuery SelectNoteReactions(NoteReactionQuery query)
        {
            query.FieldName = "noteReactions";
            return Select(query);
        }

        /// <summary>
        /// Person who added this note.
        /// </summary>
        public NoteQuery SelectPerson(PersonQuery query)
        {
            query.FieldName = "person";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Files and inline images linked to the Text field.
        /// </summary>
        public NoteQuery SelectTextAttachments(AttachmentQuery query)
        {
            query.FieldName = "textAttachments";
            return Select(query);
        }
    }
}
