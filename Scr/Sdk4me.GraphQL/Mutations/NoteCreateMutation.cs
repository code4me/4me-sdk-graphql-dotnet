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
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal NoteCreateMutation(NoteCreateInput data, NoteQuery query)
            : base("noteCreate", "NoteCreateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(NoteQuery query)
        {
            query.FieldName = "note";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
