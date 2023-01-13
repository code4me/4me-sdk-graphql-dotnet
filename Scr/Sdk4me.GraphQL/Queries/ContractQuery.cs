namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving Contract records.
    /// </summary>
    public class ContractQuery : Query<ContractQuery, ContractField, ContractView, ContractOrderField>
    {
        /// <summary>
        /// Initialize a new contract query instance.
        /// </summary>
        public ContractQuery()
            : base("contracts", typeof(Contract), true)
        {
        }

        /// <summary>
        /// All configuration items of the contract.
        /// </summary>
        public ContractQuery SelectConfigurationItems(ConfigurationItemQuery query)
        {
            query.FieldName = "configurationItems";
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        public ContractQuery SelectCustomFieldsAttachments(AttachmentQuery query)
        {
            query.FieldName = "customFieldsAttachments";
            return Select(query);
        }

        /// <summary>
        /// Invoices associated with this object.
        /// </summary>
        public ContractQuery SelectInvoices(InvoiceQuery query)
        {
            query.FieldName = "invoices";
            return Select(query);
        }

        /// <summary>
        /// Files and inline images linked to the Remarks field.
        /// </summary>
        public ContractQuery SelectRemarksAttachments(AttachmentQuery query)
        {
            query.FieldName = "remarksAttachments";
            return Select(query);
        }
    }
}
