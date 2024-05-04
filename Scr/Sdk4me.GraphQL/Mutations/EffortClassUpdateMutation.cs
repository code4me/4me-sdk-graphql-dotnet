using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing effort class.
    /// </summary>
    internal class EffortClassUpdateMutation : Mutation<EffortClassUpdatePayload, EffortClassUpdateInput>
    {
        /// <summary>
        /// Initialize an new EffortClassUpdate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The effort class response query.</param>
        internal EffortClassUpdateMutation(EffortClassUpdateInput data, EffortClassQuery query)
            : base("effortClassUpdate", "EffortClassUpdateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The effort class response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(EffortClassQuery query)
        {
            query.FieldName = "effortClass";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
