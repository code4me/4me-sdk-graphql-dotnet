namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing release.
    /// </summary>
    internal class ReleaseUpdateMutation : Mutation<ReleaseUpdatePayload, ReleaseUpdateInput>
    {
        /// <summary>
        /// Initialize an new ReleaseUpdate mutation instance.
        /// </summary>
        internal ReleaseUpdateMutation(ReleaseUpdateInput data)
            : base("releaseUpdate", "ReleaseUpdateInput!", data, new HashSet<IQuery>() { new ReleaseQuery() { FieldName = "release", IsConnection = false }.Select("*") })
        {
        }
    }
}
