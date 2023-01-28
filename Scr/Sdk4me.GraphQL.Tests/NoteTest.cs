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
                OwnerId = "NG1lMjQuMjIxMjExMDAxMzIzQDRtZS1kZW1vLmNvbS9SZXEvNzAyMjk" }
            ).Result;

            Assert.IsNotNull(noteCreatePayload);
            Assert.IsFalse(noteCreatePayload.IsError());
        }
    }
}
