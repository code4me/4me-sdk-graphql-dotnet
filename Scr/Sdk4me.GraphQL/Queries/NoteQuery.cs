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
        /// Files and inline images linked to the Text field.
        /// </summary>
        public NoteQuery SelectTextAttachments(AttachmentQuery query)
        {
            query.FieldName = "textAttachments";
            return Select(query);
        }
    }
}
