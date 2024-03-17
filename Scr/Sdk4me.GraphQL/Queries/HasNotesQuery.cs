namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="HasNotes">HasNotes</see> query.
    /// </summary>
    public class HasNotesQuery : Query<HasNotesQuery, HasNotesField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new has notes query instance.
        /// </summary>
        public HasNotesQuery()
            : base("", typeof(HasNotes), false)
        {
        }

        /// <summary>
        /// Notes of the record.
        /// </summary>
        public HasNotesQuery SelectNotes(NoteQuery query)
        {
            query.FieldName = "notes";
            return Select(query);
        }
    }
}
