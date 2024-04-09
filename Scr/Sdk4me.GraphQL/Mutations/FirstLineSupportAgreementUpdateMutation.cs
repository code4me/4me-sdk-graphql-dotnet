namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing first line support agreement.
    /// </summary>
    internal class FirstLineSupportAgreementUpdateMutation : Mutation<FirstLineSupportAgreementUpdatePayload, FirstLineSupportAgreementUpdateInput>
    {
        /// <summary>
        /// Initialize an new FirstLineSupportAgreementUpdate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The first line support agreement response query.</param>
        internal FirstLineSupportAgreementUpdateMutation(FirstLineSupportAgreementUpdateInput data, FirstLineSupportAgreementQuery query)
            : base("firstLineSupportAgreementUpdate", "FirstLineSupportAgreementUpdateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The first line support agreement response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(FirstLineSupportAgreementQuery query)
        {
            query.FieldName = "firstLineSupportAgreement";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
