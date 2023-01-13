namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/outofofficeperiodcreatepayload/">OutOfOfficePeriodCreatePayload</see> object.
    /// </summary>
    public class OutOfOfficePeriodCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("outOfOfficePeriod"), Sdk4meField(true)]
        public OutOfOfficePeriod? OutOfOfficePeriod { get; internal set; }
    }
}
