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
        internal ReleaseCreateMutation(ReleaseCreateInput data)
            : base("releaseCreate", "ReleaseCreateInput!", data, new HashSet<IQuery>() { new ReleaseQuery() { FieldName = "release", IsConnection = false }.Select("*") })
        {
        }
    }
}
