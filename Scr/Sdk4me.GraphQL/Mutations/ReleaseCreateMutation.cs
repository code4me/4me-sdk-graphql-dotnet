namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new release.
    /// </summary>
    internal class ReleaseCreateMutation : Mutation<ReleaseCreatePayload, ReleaseCreateInput>
    {
        /// <summary>
        /// Initialize an new ReleaseCreate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The release response query.</param>
        internal ReleaseCreateMutation(ReleaseCreateInput data, ReleaseQuery query)
            : base("releaseCreate", "ReleaseCreateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The release response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(ReleaseQuery query)
        {
            query.FieldName = "release";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
