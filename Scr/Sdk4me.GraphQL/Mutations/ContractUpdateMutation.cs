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
        internal ContractUpdateMutation(ContractUpdateInput data)
            : base("contractUpdate", "ContractUpdateInput!", data, new HashSet<IQuery>() { new ContractQuery() { FieldName = "contract", IsConnection = false }.Select("*") })
        {
        }
    }
}
