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
        /// Initialize a new contract query instance.
        /// <br>Additional filters and views will be ignored.</br>
        /// </summary>
        /// <param name="id">The ID of the contract.</param>
        public ContractQuery(string id)
            : base("Contract", id, typeof(Contract), false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        public ContractQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
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
        /// Values of custom fields.
        /// </summary>
        public ContractQuery SelectCustomFields(CustomFieldQuery query)
        {
            query.FieldName = "customFields";
            query.IsConnection = false;
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
        /// The organization that pays for the agreement.
        /// </summary>
        public ContractQuery SelectCustomer(OrganizationQuery query)
        {
            query.FieldName = "customer";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The customer account this record belongs to.
        /// </summary>
        public ContractQuery SelectCustomerAccount(AccountQuery query)
        {
            query.FieldName = "customerAccount";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The person who represents the customer organization for the contract.
        /// </summary>
        public ContractQuery SelectCustomerRepresentative(PersonQuery query)
        {
            query.FieldName = "customerRepresentative";
            query.IsConnection = false;
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

        /// <summary>
        /// The organization that has provided the contract to the customer.
        /// </summary>
        public ContractQuery SelectSupplier(OrganizationQuery query)
        {
            query.FieldName = "supplier";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The person who represents the supplier of the contract.
        /// </summary>
        public ContractQuery SelectSupplierContact(PersonQuery query)
        {
            query.FieldName = "supplierContact";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// UI extension that is linked to the record.
        /// </summary>
        public ContractQuery SelectUiExtension(UiExtensionQuery query)
        {
            query.FieldName = "uiExtension";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// <br>Filter the 'Contract' by their custom fields that have been marked as 'Filterable' in their UI Extension.</br>
        /// <br>Additional information is available on the <see href="https://developer.4me.com/graphql/input_object/contractcustomfilter/">4me developer site</see>.</br>
        /// </summary>
        /// <param name="name">The name of the custom filter (i.e. value of the data-filterable-name attribute of the field in the UI Extension).</param>
        /// <param name="filterOperator">The filter operator.</param>
        /// <param name="values">The filter values.
        /// <br>Use value <c>null</c> to indicate "None".</br>
        /// <br></br>
        /// <br>For "text" fields:</br>
        /// <br>• One can start the value with <c>~</c> to get partial matches (start with <c>'~</c> to match on a value starting with <c>~</c>).</br>
        /// <br></br>
        /// <br>For "number" and "time" fields:</br>
        /// <br>• One can start the value with <c>&lt;</c>, <c>&gt;</c>, <c>&lt;=</c>, <c>&gt;=</c> to get relative matches.</br>
        /// <br>• Times should be formatted as HH:mm:ss (e.g. <c>16:00:00</c>). The seconds part, <c>:ss</c>, is optional so <c>16:00</c> is also valid.</br>
        /// <br>• <c>&gt;{lower}&lt;{upper}</c> can be used to get matches where the value is more than '{lower}' and less than '{upper}'.</br>
        /// <br>• <c>&gt;={lower}&lt;={upper}</c> can be used to get matches where the value is between '{lower}' and '{upper}'.</br>
        /// <br>• <c>&gt;={lower}&lt;{upper}</c> can be used to get matches where the value is at least '{lower}' and less than '{upper}'.</br>
        /// <br></br>
        /// <br>For "date" and "date-time" fields:</br>
        /// <br>• One must supply a single value (and <c>null</c> is not supported).</br>
        /// <br>• Matches are always relative with an optional upper bound.</br>
        /// <br>• Dates should be formatted as <c>yyyy-MM-dd</c> (e.g. <c>2020-05-20</c>).</br>
        /// <br>• Date and time should be formatted as <c>yyyy-MM-ddTHH:mm:ssZ</c> (e.g. <c>2020-05-20T16:00:00Z</c>).</br>
        /// <br>• <c>&gt;={lower}</c> should be used to get matches where the value is at least '{lower}'.</br>
        /// <br>• <c>&gt;={lower}&lt;{upper}</c> can be used to get matches where the value is at least '{lower}' and before '{upper}'.</br>
        /// <br></br>
        /// <br>For "select" fields:</br>
        /// <br>• One must supply labels to match in the language of the account (i.e. not the value attributes of the HTML options).</br>
        /// <br>• Matches are case-sensitive.</br>
        /// </param>
        /// <exception cref="NullReferenceException"></exception>
        public ContractQuery CustomFilter(string name, FilterOperator filterOperator, params string?[] values)
        {
            return AddCustomFilter(name, filterOperator, values);
        }
    }
}
