using System;
using System.Collections.Generic;
using System.Linq;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// An execution query.
    /// </summary>
    internal sealed class ExecutionQuery
    {
        private Type dataType;
        private string fieldName;
        private List<ExecutionQueryField> fields = new();
        private bool isConnection;
        private Dictionary<string, ExecutionQuery> onTypeQueries = new();
        private string view = string.Empty;
        private string orderByOrder = string.Empty;
        private string orderByField = string.Empty;
        private int itemsPerRequest = 100;
        private int depth = 0;
        private List<ExecutionQuery> queries = new();
        private HashSet<string> filters = new();
        private HashSet<string> customFilters = new();
        private string filterByID = string.Empty;
        private string queryFilter = string.Empty;
        private string endCursor = string.Empty;
        private bool onlyQueryID = false;

        /// <summary>
        /// Get or set the query data type.
        /// </summary>
        internal Type DataType
        {
            get => dataType;
            set => dataType = value;
        }

        /// <summary>
        /// Gets or set the field name.
        /// </summary>
        internal string FieldName
        {
            get => fieldName;
            set => fieldName = value;
        }

        /// <summary>
        /// Get or set all selected fields.
        /// </summary>
        internal List<ExecutionQueryField> Fields
        {
            get => fields;
            set => fields = value;
        }

        /// <summary>
        /// Get or set the selected view.
        /// <br>Returns <see cref="string.Empty"/> when no view is selected.</br>
        /// </summary>
        internal string View
        {
            get => view;
            set => view = value;
        }

        /// <summary>
        /// Get or set the selected order by field.
        /// <br>Returns <see cref="string.Empty"/> when no field is selected.</br>
        /// </summary>
        internal string OrderByField
        {
            get => orderByField;
            set => orderByField = value;
        }

        /// <summary>
        /// Get or set the selected order by order.
        /// <br>Returns <see cref="string.Empty"/> when no sort order is selected.</br>
        /// </summary>
        internal string OrderByOrder
        {
            get => orderByOrder;
            set => orderByOrder = value;
        }

        /// <summary>
        /// Get or set the number of objects returned per API call.
        /// </summary>
        internal int ItemsPerRequest
        {
            get => itemsPerRequest;
            set => itemsPerRequest = value;
        }

        /// <summary>
        /// Get or set if the field is an collection.
        /// </summary>
        internal bool IsConnection
        {
            get => isConnection;
            set => isConnection = value;
        }

        /// <summary>
        /// Gets or sets the interface type of the exposed properties.
        /// </summary>
        internal Dictionary<string, ExecutionQuery> OnTypeQueries
        {
            get => onTypeQueries;
            set => onTypeQueries = value;
        }

        /// <summary>
        /// Get or set the query depth level.
        /// </summary>
        internal int Depth
        {
            get => depth;
            set => depth = value;
        }

        /// <summary>
        ///  Get the pagination end cursor.
        /// </summary>
        internal string EndCursor
        {
            get => endCursor;
        }

        /// <summary>
        /// Returns true when the fields selection should only be the identifier.
        /// </summary>
        internal bool OnlyQueryIdentifier
        {
            get => onlyQueryID;
        }

        /// <summary>
        /// Get or set all selected non-primitive data type fields.
        /// </summary>
        internal List<ExecutionQuery> Queries
        {
            get => queries;
            set => queries = value;
        }

        /// <summary>
        /// Get or set all filters.
        /// </summary>
        internal HashSet<string> Filters
        {
            get => filters;
            set => filters = value;
        }

        /// <summary>
        /// Get or set the query filter.
        /// </summary>
        internal string QueryFilter
        {
            get => queryFilter;
            set => queryFilter = value;
        }

        /// <summary>
        /// Get or set the filter by ID value.
        /// </summary>
        internal string FilterByID
        {
            get => filterByID;
            set => filterByID = value;
        }

        /// <summary>
        /// Get or set all custom filters.
        /// </summary>
        internal HashSet<string> CustomFilters
        {
            get => customFilters;
            set => customFilters = value;
        }

        /// <summary>
        /// Return true if the current object contains an identifier fields.
        /// </summary>
        internal bool HasIdentifier
        {
            get => fields.Any(x => x.Name == "id" && x.IsSelected);
        }

        /// <summary>
        /// Create a new instance of the <see cref="ExecutionQuery"/>.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        /// <param name="dataType">The data type.</param>
        internal ExecutionQuery(string fieldName, Type dataType)
        {
            this.fieldName = fieldName;
            this.dataType = dataType;
        }

        /// <summary>
        /// Get the highest depth value of the query.
        /// </summary>
        /// <returns>Return the highest depth value of all queries.</returns>
        internal int GetHighestDepthValue()
        {
            int retval = depth;
            foreach (ExecutionQuery query in queries)
            {
                if (query.IsConnection)
                {
                    retval = Math.Max(retval, query.GetHighestDepthValue());
                }
            }
            return retval;
        }

        /// <summary>
        /// Return the root expected root object name of the JSON response.
        /// </summary>
        /// <returns></returns>
        internal string GetResponseObjectName()
        {
            return !string.IsNullOrWhiteSpace(filterByID) ? "node" : fieldName;
        }

        /// <summary>
        /// Return a list of interface property types.
        /// </summary>
        /// <returns></returns>
        internal Dictionary<string, Type> GetOnTypeQueries()
        {
            Dictionary<string, Type> retval = new();
            foreach (ExecutionQuery query in queries)
            {
                foreach (string key in query.OnTypeQueries.Keys)
                    retval[key] = query.OnTypeQueries[key].dataType;

                Dictionary<string, Type> subQueries = query.GetOnTypeQueries();
                foreach (KeyValuePair<string, Type> item in subQueries)
                    retval.TryAdd(item.Key, item.Value);
            }
            return retval;
        }

        /// <summary>
        /// Update the pagination cursor for all applicable queries.
        /// </summary>
        /// <param name="queryPagesInfo">The response query pagination response details.</param>
        /// <returns>The highest depth value of an updated query; or -1 when there is no pagination.</returns>
        internal int UpdateCursors(HashSet<QueryPageInfo> queryPagesInfo)
        {
            if (queryPagesInfo.MaxBy(x => x.Depth) is QueryPageInfo highestQueryPageInfo && queryPagesInfo.Where(x => x.Depth == highestQueryPageInfo.Depth) is IEnumerable<QueryPageInfo> highestQueriesPageInfo && highestQueriesPageInfo.Any())
            {
                SetEndCursors(highestQueriesPageInfo);
                return highestQueryPageInfo.Depth;
            }
            return -1;
        }

        /// <summary>
        /// Set the end cursors.
        /// </summary>
        /// <param name="highestQueriesPageInfo">A collection of highest query page info items.</param>
        private void SetEndCursors(IEnumerable<QueryPageInfo> highestQueriesPageInfo)
        {
            int queryDepth = highestQueriesPageInfo.First().Depth;

            if (depth > queryDepth)
            {
                endCursor = string.Empty;
                onlyQueryID = false;
            }
            else
            {
                onlyQueryID = true;
            }

            if (highestQueriesPageInfo.Where(x => x.Depth == depth && x.FieldName == fieldName).FirstOrDefault() is QueryPageInfo currentQuery)
            {
                endCursor = currentQuery.EndCursor;
                onlyQueryID = false;
            }

            foreach (ExecutionQuery query in queries)
                query.SetEndCursors(highestQueriesPageInfo);
        }
    }
}
