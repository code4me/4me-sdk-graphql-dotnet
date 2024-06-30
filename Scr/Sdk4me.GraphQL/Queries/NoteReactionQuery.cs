namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="NoteReaction">NoteReaction</see> query.
    /// </summary>
    public class NoteReactionQuery : Query<NoteReactionQuery, NoteReactionField, DefaultView, DefaultFilter, DefaultOrderField>
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
        /// <param name="query">The note query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public NoteReactionQuery SelectNote(NoteQuery query)
        {
            query.FieldName = "note";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Person who added this note reaction.
        /// </summary>
        /// <param name="query">The person query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public NoteReactionQuery SelectPerson(PersonQuery query)
        {
            query.FieldName = "person";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
