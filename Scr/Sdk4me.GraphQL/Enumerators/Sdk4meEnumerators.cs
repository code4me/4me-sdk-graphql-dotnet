﻿using System.Runtime.Serialization;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// A 4me environment type.
    /// </summary>
    public enum EnvironmentType
    {
        /// <summary>
        /// The 4me production environment.
        /// </summary>
        Production,
        /// <summary>
        /// The 4me quality environment.
        /// </summary>
        Quality,
        /// <summary>
        /// The 4me demo environment.
        /// </summary>
        Demo
    }

    /// <summary>
    /// A 4me environment region.
    /// </summary>
    public enum EnvironmentRegion
    {
        /// <summary>
        /// The European region.
        /// </summary>
        EU,
        /// <summary>
        /// The Australia region.
        /// </summary>
        AU,
        /// <summary>
        /// The United Kingdom region.
        /// </summary>
        UK,
        /// <summary>
        /// The United States region.
        /// </summary>
        US,
        /// <summary>
        /// The switzerland region.
        /// </summary>
        CH
    }

    /// <summary>
    /// Sort order for the web request.
    /// </summary>
    public enum OrderBySortOrder
    {
        /// <summary>
        /// The items are not sorted.
        /// </summary>
        None,

        /// <summary>
        /// The items are sorted in ascending order.
        /// </summary>
        Ascending,

        /// <summary>
        /// The items are sorted in descending order.
        /// </summary>
        Descending
    }

    /// <summary>
    /// Operators for web request filtering.
    /// </summary>
    public enum FilterOperator
    {
        /// <summary>
        /// Equal to one of the given values 
        /// </summary>
        Equals,

        /// <summary>
        /// Not equal to one of the given values
        /// </summary>
        NotEquals,

        /// <summary>
        /// Equal to one of the given values 
        /// </summary>
        In,

        /// <summary>
        /// Not equal to one of the given values
        /// </summary>
        NotIn,

        /// <summary>
        /// Less than given value (not for enumerable values, strings and booleans) 
        /// </summary>
        LessThan,

        /// <summary>
        /// Less than or equal to given value (not for enumerable values, strings and booleans) 
        /// </summary>
        LessThanOrEqualsTo,

        /// <summary>
        /// Greater than given value (not for enumerable values, strings and booleans) 
        /// </summary>
        GreaterThan,

        /// <summary>
        /// Greater than or equal to given value (not for enumerable values, strings and booleans)
        /// </summary>
        GreaterThanOrEqualsTo,

        /// <summary>
        /// Contains a value (not null)
        /// </summary>
        Present,

        /// <summary>
        /// Has no value 
        /// </summary>
        Empty,

        /// <summary>
        /// Greater than given value and less than the other given value (numeric and date/time types only)
        /// </summary>
        GreaterThanAndLessThan,

        /// <summary>
        /// Greater than or equal to given value and less than or equal to the other given value (numeric and date / time types only)
        /// </summary>
        GreaterThanOrEqualToAndLessThanOrEqualTo
    }

    /// <summary>
    /// The 4me export line separators.
    /// </summary>
    public enum ExportLineSeparator
    {
        /// <summary>
        /// Line Feed (ASCII 10, \n)
        /// </summary>
        [EnumMember(Value = "lf")]
        LineFeed,
        /// <summary>
        /// Carriage Return (ASCII 13, \r) Line Feed (ASCII 10, \n)
        /// </summary>
        [EnumMember(Value = "crlf")]
        CarriageReturnLineFeed
    }

    /// <summary>
    /// The 4me import and export states.
    /// </summary>
    public enum ImportExportStatus
    {
        /// <summary>
        /// The import or export job is done.
        /// </summary>
        [EnumMember(Value = "done")]
        Done,
        /// <summary>
        /// The import or export job failed due to an error.
        /// </summary>
        [EnumMember(Value = "error")]
        Error,
        /// <summary>
        /// The import or export job failed.
        /// </summary>
        [EnumMember(Value = "failed")]
        Failed,
        /// <summary>
        /// The import or export job is being processed.
        /// </summary>
        [EnumMember(Value = "processing")]
        Processing,
        /// <summary>
        /// The import or export job is queued.
        /// </summary>
        [EnumMember(Value = "queued")]
        Queued,
        /// <summary>
        /// The import or export job is scheduled.
        /// </summary>
        [EnumMember(Value = "scheduled")]
        Scheduled
    }
}
