namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing invoice.
    /// </summary>
    internal class InvoiceUpdateMutation : Mutation<InvoiceUpdatePayload, InvoiceUpdateInput>
    {
        /// <summary>
        /// Initialize an new InvoiceUpdate mutation instance.
        /// </summary>
        internal InvoiceUpdateMutation(InvoiceUpdateInput data)
            : base("invoiceUpdate", "InvoiceUpdateInput!", data, new HashSet<IQuery>() { new InvoiceQuery() { FieldName = "invoice", IsConnection = false }.Select("*") })
        {
        }
    }
}
