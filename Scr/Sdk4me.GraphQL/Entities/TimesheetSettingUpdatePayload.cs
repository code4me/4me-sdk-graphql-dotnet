﻿namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/timesheetsettingupdatepayload/">TimesheetSettingUpdatePayload</see> object.
    /// </summary>
    public class TimesheetSettingUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("timesheetSetting"), Sdk4meField(true)]
        public TimesheetSetting? TimesheetSetting { get; internal set; }
    }
}
