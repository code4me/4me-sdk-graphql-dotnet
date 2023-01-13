namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The 4me GraphQL Mutation response.
    /// </summary>
    public abstract class Payload
    {
        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        [JsonProperty("clientMutationId"), Sdk4meField(true)]
        public string? ClientMutationId { get; internal set; }

        /// <summary>
        /// Errors encountered during the mutation.
        /// </summary>
        [JsonProperty("errors"), Sdk4meField(true)]
        public List<ValidationError>? Errors { get; internal set; }

        /// <summary>
        /// Determines if the response contains an error message.
        /// </summary>
        /// <returns>True if the response contains an error; otherwise false.</returns>
        public bool IsError()
        {
            return Errors != null && Errors.Any();
        }
    }
}
