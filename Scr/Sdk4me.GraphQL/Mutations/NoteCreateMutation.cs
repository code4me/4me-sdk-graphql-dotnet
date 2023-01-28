namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Adds a new note to a record.
    /// </summary>
    internal class NoteCreateMutation : Mutation<NoteCreatePayload, NoteCreateInput>
    {
        /// <summary>
        /// Initialize an new NoteCreate mutation instance.
        /// </summary>
        internal NoteCreateMutation(NoteCreateInput data)
            : base("noteCreate", "NoteCreateInput!", data, new HashSet<IQuery>() { new NoteQuery() { FieldName = "note", IsConnection = false }.Select("*") })
        {
        }
    }
}
