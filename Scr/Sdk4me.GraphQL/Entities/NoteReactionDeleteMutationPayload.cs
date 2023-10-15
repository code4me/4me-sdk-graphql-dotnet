namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/notereactiondeletemutationpayload/">NoteReactionDeleteMutationPayload</see> object.
    /// </summary>
    public class NoteReactionDeleteMutationPayload : Payload
    {
        /// <summary>
        /// <c>true</c> when the record was successfully deleted, <c>false</c> otherwise.
        /// </summary>
        [JsonProperty("success"), Sdk4meField(true)]
        public bool? Success { get; internal set; }
    }
}
