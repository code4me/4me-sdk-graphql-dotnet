namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new custom collection element.
    /// </summary>
    internal class CustomCollectionElementCreateMutation : Mutation<CustomCollectionElementCreatePayload, CustomCollectionElementCreateInput>
    {
        /// <summary>
        /// Initialize an new CustomCollectionElementCreate mutation instance.
        /// </summary>
        internal CustomCollectionElementCreateMutation(CustomCollectionElementCreateInput data)
            : base("customCollectionElementCreate", "CustomCollectionElementCreateInput!", data, new HashSet<IQuery>() { new CustomCollectionElementQuery() { FieldName = "customCollectionElement", IsConnection = false }.Select("*") })
        {
        }
    }
}
