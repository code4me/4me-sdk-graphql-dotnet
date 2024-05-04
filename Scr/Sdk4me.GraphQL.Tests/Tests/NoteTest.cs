using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class NoteTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void AddNoteAndNoteReaction()
        {
            NoteCreatePayload noteCreatePayload = client.Mutation(new()
            {
                Text = $"{DateTime.Now:HH:mm:ss.fff} - Hello World !!!",
                Internal = true,
                OwnerId = "NG1lMjQuMjMwNDEwMDAyODU3QDRtZS1kZW1vLmNvbS9SZXEvNzA1MzE"
            }, new NoteQuery().Select(NoteField.ID).SelectNoteReactions(new NoteReactionQuery())).Result;

            Assert.IsNotNull(noteCreatePayload);
            Assert.IsNotNull(noteCreatePayload.Note);
            Assert.IsNotNull(noteCreatePayload.Note.NoteReactions);
            Assert.IsFalse(noteCreatePayload.IsError());

            NoteReactionCreatePayload noteReactionCreatePayload = client.Mutation(new NoteReactionCreateInput() { NoteId = noteCreatePayload.Note.ID, Reaction = "👍" }, new NoteReactionQuery().SelectAll()).Result;
            Assert.IsNotNull(noteReactionCreatePayload);
            Assert.IsNotNull(noteReactionCreatePayload.NoteReaction);
            Assert.IsNotNull(noteReactionCreatePayload.NoteReaction.Note);

            NoteReactionDeleteMutationPayload noteReactionDeleteMutationPayload = client.Mutation(new NoteReactionDeleteMutationInput() { ID = noteReactionCreatePayload.NoteReaction.ID }).Result;
            Assert.IsNotNull(noteReactionDeleteMutationPayload);
        }
    }
}
