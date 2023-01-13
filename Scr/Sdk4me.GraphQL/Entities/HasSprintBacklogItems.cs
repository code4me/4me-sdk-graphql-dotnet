using System.Diagnostics;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/hassprintbacklogitems/">HasSprintBacklogItems</see> object.
    /// </summary>
    [Sdk4meEntity(ignoreIdentifier: true)]
    public class HasSprintBacklogItems : Node
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

        [JsonProperty("sprintBacklogItems")]
        internal NodeCollection<SprintBacklogItem>? SprintBacklogItemsCollection { get; set; }

        /// <summary>
        /// Sprint backlog items associated with this object.
        /// </summary>
        public DataList<SprintBacklogItem>? SprintBacklogItems
        {
            get => SprintBacklogItemsCollection?.Data;
        }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(SprintBacklogItemsCollection?.GetQueryPageInfo("sprintBacklogItems", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            SprintBacklogItems?.AddRange((data as HasSprintBacklogItems)?.SprintBacklogItems);
        }
    }
}
