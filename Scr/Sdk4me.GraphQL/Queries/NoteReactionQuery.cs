namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="NoteReaction">NoteReaction</see> query.
    /// </summary>
    public class NoteReactionQuery : Query<NoteReactionQuery, NoteReactionField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new note reaction query instance.
        /// </summary>
        public NoteReactionQuery()
            : base("", typeof(NoteReaction), true)
        {
        }

        /// <summary>
        /// Note this note reaction belongs to.
        /// </summary>
        public NoteReactionQuery SelectNote(NoteQuery query)
        {
            query.FieldName = "note";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Person who added this note reaction.
        /// </summary>
        public NoteReactionQuery SelectPerson(PersonQuery query)
        {
            query.FieldName = "person";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
