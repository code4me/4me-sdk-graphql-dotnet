namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing UI extension.
    /// </summary>
    internal class UiExtensionUpdateMutation : Mutation<UiExtensionUpdatePayload, UiExtensionUpdateInput>
    {
        /// <summary>
        /// Initialize an new UiExtensionUpdate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The ui extension response query.</param>
        internal UiExtensionUpdateMutation(UiExtensionUpdateInput data, UiExtensionQuery query)
            : base("uiExtensionUpdate", "UiExtensionUpdateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The ui extension response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(UiExtensionQuery query)
        {
            query.FieldName = "uiExtension";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
