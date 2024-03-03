﻿namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/slacoveragegroupupdatepayload/">SlaCoverageGroupUpdatePayload</see> object.
    /// </summary>
    public class SlaCoverageGroupUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("slaCoverageGroup"), Sdk4meField(true)]
        public SlaCoverageGroup? SlaCoverageGroup { get; internal set; }
    }
}