namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new invoice.
    /// </summary>
    internal class InvoiceCreateMutation : Mutation<InvoiceCreatePayload, InvoiceCreateInput>
    {
        /// <summary>
        /// Initialize an new InvoiceCreate mutation instance.
        /// </summary>
        internal InvoiceCreateMutation(InvoiceCreateInput data)
            : base("invoiceCreate", "InvoiceCreateInput!", data, new HashSet<IQuery>() { new InvoiceQuery() { FieldName = "invoice", IsConnection = false }.Select("*") })
        {
        }
    }
}
