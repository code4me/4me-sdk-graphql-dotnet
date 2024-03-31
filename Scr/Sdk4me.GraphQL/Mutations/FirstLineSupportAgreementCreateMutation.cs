namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new first line support agreement.
    /// </summary>
    internal class FirstLineSupportAgreementCreateMutation : Mutation<FirstLineSupportAgreementCreatePayload, FirstLineSupportAgreementCreateInput>
    {
        /// <summary>
        /// Initialize an new FirstLineSupportAgreementCreate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal FirstLineSupportAgreementCreateMutation(FirstLineSupportAgreementCreateInput data, FirstLineSupportAgreementQuery query)
            : base("firstLineSupportAgreementCreate", "FirstLineSupportAgreementCreateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(FirstLineSupportAgreementQuery query)
        {
            query.FieldName = "firstLineSupportAgreement";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
