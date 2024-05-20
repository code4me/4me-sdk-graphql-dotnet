﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/period/">Period</see> object.
    /// </summary>
    [Sdk4meEntity(ignoreIdentifier: true)]
    public class Period : Node
    {
        /// <summary>
        /// The display debugger value.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        internal override string? DebuggerValue
        {
            get => (From is not null && To is not null) ? $"{From:yyyy=MM-dd HH:mm:ss} - {To:yyyy=MM-dd HH:mm:ss}" : ToString();
        }

        /// <summary>
        /// The unique identifier used by <see cref="DataList{T}"/>.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        internal override string UniqueIdentifier
        {
            get => GetHashCode().ToString();
        }

        /// <summary>
        /// Start of the period
        /// </summary>
        [JsonProperty("from"), Sdk4meField(IsDefaultQueryProperty = true)]
        public DateTime? From { get; internal set; }

        /// <summary>
        /// Provider Not Accountable
        /// </summary>
        [JsonProperty("providerNotAccountable"), Sdk4meField(IsDefaultQueryProperty = true)]
        public bool? ProviderNotAccountable { get; internal set; }

        /// <summary>
        /// End of the period
        /// </summary>
        [JsonProperty("to"), Sdk4meField(IsDefaultQueryProperty = true)]
        public DateTime? To { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
