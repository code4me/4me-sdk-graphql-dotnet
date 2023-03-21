namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new UI extension.
    /// </summary>
    internal class UiExtensionCreateMutation : Mutation<UiExtensionCreatePayload, UiExtensionCreateInput>
    {
        /// <summary>
        /// Initialize an new UiExtensionCreate mutation instance.
        /// </summary>
        internal UiExtensionCreateMutation(UiExtensionCreateInput data)
            : base("uiExtensionCreate", "UiExtensionCreateInput!", data, new HashSet<IQuery>() { new UiExtensionQuery() { FieldName = "uiExtension", IsConnection = false }.Select("*") })
        {
        }
    }
}
