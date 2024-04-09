namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Adds a new note reaction to a note.
    /// </summary>
    internal class NoteReactionCreateMutation : Mutation<NoteReactionCreatePayload, NoteReactionCreateInput>
    {
        /// <summary>
        /// Initialize an new NoteReactionCreate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The note reaction response query.</param>
        internal NoteReactionCreateMutation(NoteReactionCreateInput data, NoteReactionQuery query)
            : base("noteReactionCreate", "NoteReactionCreateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The note reaction response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(NoteReactionQuery query)
        {
            query.FieldName = "noteReaction";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
