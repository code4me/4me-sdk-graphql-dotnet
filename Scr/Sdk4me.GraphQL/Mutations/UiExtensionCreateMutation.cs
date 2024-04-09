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
        /// <param name="data">The input data.</param>
        /// <param name="query">The ui extension response query.</param>
        internal UiExtensionCreateMutation(UiExtensionCreateInput data, UiExtensionQuery query)
            : base("uiExtensionCreate", "UiExtensionCreateInput!", data, GetQuery(query))
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
