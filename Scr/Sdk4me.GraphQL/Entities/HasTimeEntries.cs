using System.Diagnostics;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/hastimeentries/">HasTimeEntries</see> object.
    /// </summary>
    [Sdk4meEntity(ignoreIdentifier: true)]
    public class HasTimeEntries : Node
    {
        /// <summary>
        /// The display debugger value.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        internal override string? DebuggerValue
        {
            get => ToString();
        }

        /// <summary>
        /// The unique identifier used by <see cref="DataList{T}"/>.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        internal override string UniqueIdentifier
        {
            get => GetHashCode().ToString();
        }

        [JsonProperty("timeEntries")]
        internal NodeCollection<TimeEntry>? TimeEntriesCollection { get; set; }

        /// <summary>
        /// Time entries for this record.
        /// </summary>
        public DataList<TimeEntry>? TimeEntries
        {
            get => TimeEntriesCollection?.Data;
        }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(TimeEntriesCollection?.GetQueryPageInfo("timeEntries", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            TimeEntries?.AddRange((data as HasTimeEntries)?.TimeEntries);
        }
    }
}
