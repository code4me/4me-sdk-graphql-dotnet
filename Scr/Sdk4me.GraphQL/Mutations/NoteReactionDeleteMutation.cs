namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Deletes a note reaction from a note.
    /// </summary>
    internal class NoteReactionDeleteMutation : Mutation<NoteReactionDeleteMutationPayload, NoteReactionDeleteMutationInput>
    {
        /// <summary>
        /// Initialize an new NoteReactionDelete mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        internal NoteReactionDeleteMutation(NoteReactionDeleteMutationInput data)
            : base("noteReactionDelete", "NoteReactionDeleteMutationInput!", data, new HashSet<IQuery>())
        {
        }
    }
}
