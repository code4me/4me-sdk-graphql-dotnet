namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class NoteTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void AddNote()
        {
            NoteCreatePayload noteCreatePayload = client.Mutation(new NoteCreateInput() 
            {
                Text = "Hello World !!!",
                Internal = true,
                OwnerId = "NG1lMjQuMjMwNDEwMDAyODU3QDRtZS1kZW1vLmNvbS9SZXEvNzA1MzE"
            }
            ).Result;

            Assert.IsNotNull(noteCreatePayload);
            Assert.IsFalse(noteCreatePayload.IsError());
        }
    }
}
