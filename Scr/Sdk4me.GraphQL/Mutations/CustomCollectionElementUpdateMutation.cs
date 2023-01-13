namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing custom collection element.
    /// </summary>
    internal class CustomCollectionElementUpdateMutation : Mutation<CustomCollectionElementUpdatePayload, CustomCollectionElementUpdateInput>
    {
        /// <summary>
        /// Initialize an new CustomCollectionElementUpdate mutation instance.
        /// </summary>
        internal CustomCollectionElementUpdateMutation(CustomCollectionElementUpdateInput data)
            : base("customCollectionElementUpdate", "CustomCollectionElementUpdateInput!", data, new HashSet<IQuery>() { new CustomCollectionElementQuery() { FieldName = "customCollectionElement", IsConnection = false }.Select("*") })
        {
        }
    }
}
