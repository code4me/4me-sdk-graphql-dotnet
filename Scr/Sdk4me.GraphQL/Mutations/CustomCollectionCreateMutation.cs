namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new custom collection.
    /// </summary>
    internal class CustomCollectionCreateMutation : Mutation<CustomCollectionCreatePayload, CustomCollectionCreateInput>
    {
        /// <summary>
        /// Initialize an new CustomCollectionCreate mutation instance.
        /// </summary>
        internal CustomCollectionCreateMutation(CustomCollectionCreateInput data)
            : base("customCollectionCreate", "CustomCollectionCreateInput!", data, new HashSet<IQuery>() { new CustomCollectionQuery() { FieldName = "customCollection", IsConnection = false }.Select("*") })
        {
        }
    }
}
