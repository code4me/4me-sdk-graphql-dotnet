namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new contract.
    /// </summary>
    internal class ContractCreateMutation : Mutation<ContractCreatePayload, ContractCreateInput>
    {
        /// <summary>
        /// Initialize an new ContractCreate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The contract response query.</param>
        internal ContractCreateMutation(ContractCreateInput data, ContractQuery query)
            : base("contractCreate", "ContractCreateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The contract response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(ContractQuery query)
        {
            query.FieldName = "contract";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
