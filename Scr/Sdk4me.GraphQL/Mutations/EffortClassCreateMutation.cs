namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new effort class.
    /// </summary>
    internal class EffortClassCreateMutation : Mutation<EffortClassCreatePayload, EffortClassCreateInput>
    {
        /// <summary>
        /// Initialize an new EffortClassCreate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal EffortClassCreateMutation(EffortClassCreateInput data, EffortClassQuery query)
            : base("effortClassCreate", "EffortClassCreateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(EffortClassQuery query)
        {
            query.FieldName = "effortClass";
            query.IsConnection = false;
            return new HashSet<IQuery>() {query};
        }
    }
}
