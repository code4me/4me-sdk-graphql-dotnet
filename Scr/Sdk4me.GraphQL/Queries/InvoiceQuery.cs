namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving Invoice records.
    /// </summary>
    public class InvoiceQuery : Query<InvoiceQuery, InvoiceField, InvoiceView, InvoiceOrderField>
    {
        /// <summary>
        /// Initialize a new invoice query instance.
        /// </summary>
        public InvoiceQuery()
            : base("invoices", typeof(Invoice), true)
        {
        }

        /// <summary>
        /// The configuration items linked to this invoice.
        /// </summary>
        public InvoiceQuery SelectConfigurationItems(ConfigurationItemQuery query)
        {
            query.FieldName = "configurationItems";
            return Select(query);
        }

        /// <summary>
        /// Files and inline images linked to the Remarks field.
        /// </summary>
        public InvoiceQuery SelectRemarksAttachments(AttachmentQuery query)
        {
            query.FieldName = "remarksAttachments";
            return Select(query);
        }
    }
}
