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
        /// Initialize a new invoice query instance.
        /// <br>Additional filters and views will be ignored.</br>
        /// </summary>
        /// <param name="id">The ID of the invoice.</param>
        public InvoiceQuery(string id)
            : base("Invoice", id, typeof(Invoice), false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public InvoiceQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The configuration items linked to this invoice.
        /// </summary>
        /// <param name="query">The configuration item query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public InvoiceQuery SelectConfigurationItems(ConfigurationItemQuery query)
        {
            query.FieldName = "configurationItems";
            return Select(query);
        }

        /// <summary>
        /// The contract linked to this invoice.
        /// </summary>
        /// <param name="query">The contract query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public InvoiceQuery SelectContract(ContractQuery query)
        {
            query.FieldName = "contract";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The first line support agreement linked to this invoice.
        /// </summary>
        /// <param name="query">The first line support agreement query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public InvoiceQuery SelectFlsa(FirstLineSupportAgreementQuery query)
        {
            query.FieldName = "flsa";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The project linked to this invoice.
        /// </summary>
        /// <param name="query">The project query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public InvoiceQuery SelectProject(ProjectQuery query)
        {
            query.FieldName = "project";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Files and inline images linked to the Remarks field.
        /// </summary>
        /// <param name="query">The attachment query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public InvoiceQuery SelectRemarksAttachments(AttachmentQuery query)
        {
            query.FieldName = "remarksAttachments";
            return Select(query);
        }

        /// <summary>
        /// The service that covers this invoice.
        /// </summary>
        /// <param name="query">The service query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public InvoiceQuery SelectService(ServiceQuery query)
        {
            query.FieldName = "service";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The service level agreement linked to this invoice.
        /// </summary>
        /// <param name="query">The service level agreement query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public InvoiceQuery SelectSla(ServiceLevelAgreementQuery query)
        {
            query.FieldName = "sla";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The organization from which the invoice was received.
        /// </summary>
        /// <param name="query">The organization query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public InvoiceQuery SelectSupplier(OrganizationQuery query)
        {
            query.FieldName = "supplier";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The workflow linked to this invoice.
        /// </summary>
        /// <param name="query">The workflow query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public InvoiceQuery SelectWorkflow(WorkflowQuery query)
        {
            query.FieldName = "workflow";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
