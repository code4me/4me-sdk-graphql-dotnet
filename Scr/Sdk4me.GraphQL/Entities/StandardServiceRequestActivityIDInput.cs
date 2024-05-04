﻿using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/standardservicerequestactivityidinput/">StandardServiceRequestActivityIDInput</see> object.
    /// </summary>
    public class StandardServiceRequestActivityIDInput : PropertyChangeSet
    {
        private string? activityID;
        private string? id;
        private string? standardServiceRequestId;

        /// <summary>
        /// The identifier known in the billing system of the service provider.
        /// </summary>
        [JsonProperty("activityID")]
        public string? ActivityID
        {
            get => activityID;
            set => activityID = Set("activityID", value);
        }

        /// <summary>
        /// Identifier of the object to update using these values. For new objects it should be <c>null</c>.
        /// </summary>
        [JsonProperty("id")]
        public string? ID
        {
            get => id;
            set => id = Set("id", value);
        }

        /// <summary>
        /// The standard service request ID for which a billing identifier is provided.
        /// </summary>
        [JsonProperty("standardServiceRequestId")]
        public string? StandardServiceRequestId
        {
            get => standardServiceRequestId;
            set => standardServiceRequestId = Set("standardServiceRequestId", value);
        }
    }
}
