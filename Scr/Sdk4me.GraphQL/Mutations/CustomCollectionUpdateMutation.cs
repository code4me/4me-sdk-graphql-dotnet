namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing custom collection.
    /// </summary>
    internal class CustomCollectionUpdateMutation : Mutation<CustomCollectionUpdatePayload, CustomCollectionUpdateInput>
    {
        /// <summary>
        /// Initialize an new CustomCollectionUpdate mutation instance.
        /// </summary>
        internal CustomCollectionUpdateMutation(CustomCollectionUpdateInput data)
            : base("customCollectionUpdate", "CustomCollectionUpdateInput!", data, new HashSet<IQuery>() { new CustomCollectionQuery() { FieldName = "customCollection", IsConnection = false }.Select("*") })
        {
        }
    }
}
