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
        internal ContractCreateMutation(ContractCreateInput data)
            : base("contractCreate", "ContractCreateInput!", data, new HashSet<IQuery>() { new ContractQuery() { FieldName = "contract", IsConnection = false }.Select("*") })
        {
        }
    }
}
