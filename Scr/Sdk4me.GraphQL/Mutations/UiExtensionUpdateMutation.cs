namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing user interface extension.
    /// </summary>
    internal class UiExtensionUpdateMutation : Mutation<UiExtensionUpdatePayload, UiExtensionUpdateInput>
    {
        /// <summary>
        /// Initialize an new UiExtensionUpdate mutation instance.
        /// </summary>
        internal UiExtensionUpdateMutation(UiExtensionUpdateInput data)
            : base("uiExtensionUpdate", "UiExtensionUpdateInput!", data, new HashSet<IQuery>() { new UiExtensionQuery() { FieldName = "uiExtension", IsConnection = false }.Select("*") })
        {
        }
    }
}
