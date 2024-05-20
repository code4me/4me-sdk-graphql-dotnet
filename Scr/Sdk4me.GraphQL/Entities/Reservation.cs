using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/reservation/">Reservation</see> object.
    /// </summary>
    public class Reservation : Node
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account"), Sdk4meField(IsDefaultQueryProperty = true)]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The asset that is being reserved.
        /// </summary>
        [JsonProperty("configurationItem")]
        public ConfigurationItem? ConfigurationItem { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(IsDefaultQueryProperty = true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// The person who created this reservation.
        /// </summary>
        [JsonProperty("createdBy")]
        public Person? CreatedBy { get; internal set; }

        /// <summary>
        /// Full description of the reservation.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; internal set; }

        [JsonProperty("descriptionAttachments")]
        internal NodeCollection<Attachment>? DescriptionAttachmentsCollection { get; set; }

        /// <summary>
        /// Inline images linked to the Description field.
        /// </summary>
        public DataList<Attachment>? DescriptionAttachments
        {
            get => DescriptionAttachmentsCollection?.Data;
        }

        /// <summary>
        /// The Duration field is used to specify the length of time for which the configuration item has been reserved.
        /// </summary>
        [JsonProperty("duration")]
        public long? Duration { get; internal set; }

        /// <summary>
        /// The End field is used to specify the moment at which the reservation ends.
        /// </summary>
        [JsonProperty("endAt"), Sdk4meField(IsDefaultQueryProperty = true)]
        public DateTime? EndAt { get; internal set; }

        /// <summary>
        /// A short description of the reservation.
        /// </summary>
        [JsonProperty("name"), Sdk4meField(IsDefaultQueryProperty = true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// <c>true</c> when this single occurrence of a recurrent reservation is altered.
        /// </summary>
        [JsonProperty("onlyThisOccurrence")]
        public bool? OnlyThisOccurrence { get; internal set; }

        /// <summary>
        /// The person for whom this reservation was created.
        /// </summary>
        [JsonProperty("person"), Sdk4meField(IsDefaultQueryProperty = true)]
        public Person? Person { get; internal set; }

        /// <summary>
        /// The start date and time of the preparation of the asset for the reservation. Only present in case the reservation offering specifies a preparation duration.
        /// </summary>
        [JsonProperty("preparationStartAt")]
        public DateTime? PreparationStartAt { get; internal set; }

        /// <summary>
        /// Recurrency for the reservation.
        /// </summary>
        [JsonProperty("recurrence")]
        public Recurrence? Recurrence { get; internal set; }

        /// <summary>
        /// The link to the request for reservation.
        /// </summary>
        [JsonProperty("request")]
        public Request? Request { get; internal set; }

        /// <summary>
        /// The link to the reservation offering that was related to the request template used to request the reservation.
        /// </summary>
        [JsonProperty("reservationOffering")]
        public ReservationOffering? ReservationOffering { get; internal set; }

        /// <summary>
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [JsonProperty("source"), Sdk4meField(IsDefaultQueryProperty = true)]
        public string? Source { get; internal set; }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [JsonProperty("sourceID"), Sdk4meField(IsDefaultQueryProperty = true)]
        public string? SourceID { get; internal set; }

        /// <summary>
        /// The Start field is used to specify the moment at which the reservation begins.
        /// </summary>
        [JsonProperty("startAt"), Sdk4meField(IsDefaultQueryProperty = true)]
        public DateTime? StartAt { get; internal set; }

        /// <summary>
        /// The status of the reservation.
        /// </summary>
        [JsonProperty("status"), Sdk4meField(IsDefaultQueryProperty = true)]
        public ReservationStatus? Status { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [JsonProperty("updatedAt"), Sdk4meField(IsDefaultQueryProperty = true)]
        public DateTime? UpdatedAt { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(DescriptionAttachmentsCollection?.GetQueryPageInfo("descriptionAttachments", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            DescriptionAttachments?.AddRange((data as Reservation)?.DescriptionAttachments);
        }
    }
}
