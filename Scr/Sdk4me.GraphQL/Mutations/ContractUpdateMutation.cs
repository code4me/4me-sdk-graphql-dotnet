namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing contract.
    /// </summary>
    internal class ContractUpdateMutation : Mutation<ContractUpdatePayload, ContractUpdateInput>
    {
        /// <summary>
        /// Initialize an new ContractUpdate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal ContractUpdateMutation(ContractUpdateInput data, ContractQuery query)
            : base("contractUpdate", "ContractUpdateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(ContractQuery query)
        {
            query.FieldName = "contract";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
