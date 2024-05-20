﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/holidaycreateinput/">HolidayCreateInput</see> object.
    /// </summary>
    public class HolidayCreateInput : PropertyChangeSet
    {
        private List<string>? calendarIds;
        private string? clientMutationId;
        private DateTime endAt;
        private string name;
        private string? pictureUri;
        private string? source;
        private string? sourceID;
        private DateTime startAt;

        /// <summary>
        /// Identifiers of calendars of the holiday.
        /// </summary>
        [JsonProperty("calendarIds")]
        public List<string>? CalendarIds
        {
            get => calendarIds;
            set => calendarIds = Set("calendarIds", value);
        }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        [JsonProperty("clientMutationId")]
        public string? ClientMutationId
        {
            get => clientMutationId;
            set => clientMutationId = Set("clientMutationId", value);
        }

        /// <summary>
        /// End of the holiday.
        /// </summary>
        [JsonProperty("endAt"), Sdk4meField(IsRequiredForMutation = true)]
        public DateTime EndAt
        {
            get => endAt;
            set => endAt = Set("endAt", value);
        }

        /// <summary>
        /// Name of the holiday.
        /// </summary>
        [JsonProperty("name"), Sdk4meField(IsRequiredForMutation = true)]
        public string Name
        {
            get => name;
            set => name = Set("name", value);
        }

        /// <summary>
        /// The hyperlink to the image file for the record.
        /// </summary>
        [JsonProperty("pictureUri")]
        public string? PictureUri
        {
            get => pictureUri;
            set => pictureUri = Set("pictureUri", value);
        }

        /// <summary>
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [JsonProperty("source")]
        public string? Source
        {
            get => source;
            set => source = Set("source", value);
        }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [JsonProperty("sourceID")]
        public string? SourceID
        {
            get => sourceID;
            set => sourceID = Set("sourceID", value);
        }

        /// <summary>
        /// Start of the holiday.
        /// </summary>
        [JsonProperty("startAt"), Sdk4meField(IsRequiredForMutation = true)]
        public DateTime StartAt
        {
            get => startAt;
            set => startAt = Set("startAt", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HolidayCreateInput"/> class without providing the required values.
        /// </summary>
        public HolidayCreateInput()
        {
            endAt = default(DateTime);
            name = string.Empty;
            startAt = default(DateTime);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HolidayCreateInput"/> class.
        /// </summary>
        /// <param name="endAt">End of the holiday.</param>
        /// <param name="name">Name of the holiday.</param>
        /// <param name="startAt">Start of the holiday.</param>
        public HolidayCreateInput(DateTime endAt, string name, DateTime startAt)
        {
            this.endAt = Set("endAt", endAt);
            this.name = Set("name", name);
            this.startAt = Set("startAt", startAt);
        }
    }
}
