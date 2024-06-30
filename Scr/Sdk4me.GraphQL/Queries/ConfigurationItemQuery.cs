using System;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving ConfigurationItem records.
    /// </summary>
    public class ConfigurationItemQuery : Query<ConfigurationItemQuery, ConfigurationItemField, ConfigurationItemView, ConfigurationItemFilter, ConfigurationItemOrderField>
    {
        /// <summary>
        /// Initialize a new configuration item query instance.
        /// </summary>
        public ConfigurationItemQuery()
            : base("configurationItems", typeof(ConfigurationItem), true)
        {
        }

        /// <summary>
        /// Initialize a new configuration item query instance.
        /// <br>Additional filters and views will be ignored.</br>
        /// </summary>
        /// <param name="id">The ID of the configuration item.</param>
        public ConfigurationItemQuery(string id)
            : base("ConfigurationItem", id, typeof(ConfigurationItem), false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ConfigurationItemQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Relations to other configuration items.
        /// </summary>
        /// <param name="query">The configuration item relation query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ConfigurationItemQuery SelectCiRelations(ConfigurationItemRelationQuery query)
        {
            query.FieldName = "ciRelations";
            return Select(query);
        }

        /// <summary>
        /// All contracts of this configuration item.
        /// </summary>
        /// <param name="query">The contract query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ConfigurationItemQuery SelectContracts(ContractQuery query)
        {
            query.FieldName = "contracts";
            return Select(query);
        }

        /// <summary>
        /// Values of custom fields.
        /// </summary>
        /// <param name="query">The custom field query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ConfigurationItemQuery SelectCustomFields(CustomFieldQuery query)
        {
            query.FieldName = "customFields";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        /// <param name="query">The attachment query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ConfigurationItemQuery SelectCustomFieldsAttachments(AttachmentQuery query)
        {
            query.FieldName = "customFieldsAttachments";
            return Select(query);
        }

        /// <summary>
        /// The internal organization which budget is used to pay for the configuration item. If the CI is leased or rented, the organization that pays the lease or rent is selected in this field. When creating a new CI and a value is not specified for this field, it is set to the financial owner of the CI's product.
        /// </summary>
        /// <param name="query">The organization query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ConfigurationItemQuery SelectFinancialOwner(OrganizationQuery query)
        {
            query.FieldName = "financialOwner";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Invoices associated with this object.
        /// </summary>
        /// <param name="query">The invoice query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ConfigurationItemQuery SelectInvoices(InvoiceQuery query)
        {
            query.FieldName = "invoices";
            return Select(query);
        }

        /// <summary>
        /// Sites at which the software that is covered by the license certificate may be used.
        /// </summary>
        /// <param name="query">The site query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ConfigurationItemQuery SelectLicensedSites(SiteQuery query)
        {
            query.FieldName = "licensedSites";
            return Select(query);
        }

        /// <summary>
        /// The (software) configuration item representing the operating system of this configuration item.
        /// </summary>
        /// <param name="query">The configuration item query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ConfigurationItemQuery SelectOperatingSystem(ConfigurationItemQuery query)
        {
            query.FieldName = "operatingSystem";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// All problems of this configuration item.
        /// </summary>
        /// <param name="query">The problem query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ConfigurationItemQuery SelectProblems(ProblemQuery query)
        {
            query.FieldName = "problems";
            return Select(query);
        }

        /// <summary>
        /// Related product.
        /// </summary>
        /// <param name="query">The product query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ConfigurationItemQuery SelectProduct(ProductQuery query)
        {
            query.FieldName = "product";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Recurrence for maintenance of the configuration item.
        /// </summary>
        /// <param name="query">The recurrence query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ConfigurationItemQuery SelectRecurrence(RecurrenceQuery query)
        {
            query.FieldName = "recurrence";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Files and inline images linked to the Remarks field.
        /// </summary>
        /// <param name="query">The attachment query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ConfigurationItemQuery SelectRemarksAttachments(AttachmentQuery query)
        {
            query.FieldName = "remarksAttachments";
            return Select(query);
        }

        /// <summary>
        /// All requests of this configuration item.
        /// </summary>
        /// <param name="query">The request query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ConfigurationItemQuery SelectRequests(RequestQuery query)
        {
            query.FieldName = "requests";
            return Select(query);
        }

        /// <summary>
        /// Which service instance(s) the configuration item is, or will be, a part of. When creating a new CI and a value is not specified for this field, it is set to the service of the CI's product.
        /// </summary>
        /// <param name="query">The service query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ConfigurationItemQuery SelectService(ServiceQuery query)
        {
            query.FieldName = "service";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// All service instances of this configuration item.
        /// </summary>
        /// <param name="query">The service instance query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ConfigurationItemQuery SelectServiceInstances(ServiceInstanceQuery query)
        {
            query.FieldName = "serviceInstances";
            return Select(query);
        }

        /// <summary>
        /// Where the CI is located, if it concerns a hardware CI.
        /// </summary>
        /// <param name="query">The site query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ConfigurationItemQuery SelectSite(SiteQuery query)
        {
            query.FieldName = "site";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The supplier from which the configuration item (CI) has been obtained. When creating a new CI and a value is not specified for this field, it is set to the supplier of the CI's product.
        /// </summary>
        /// <param name="query">The organization query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ConfigurationItemQuery SelectSupplier(OrganizationQuery query)
        {
            query.FieldName = "supplier";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The account of the team that supports this configuration item.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ConfigurationItemQuery SelectSupportAccount(AccountQuery query)
        {
            query.FieldName = "supportAccount";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The team responsible for supporting the configuration item and maintaining its information in the configuration management database (CMDB). When creating a new CI and a value is not specified for this field, it is set to the support team of the CI's product. Optional when status of CI equals "Removed", required otherwise.
        /// </summary>
        /// <param name="query">The team query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ConfigurationItemQuery SelectSupportTeam(TeamQuery query)
        {
            query.FieldName = "supportTeam";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// All users of this configuration item.
        /// </summary>
        /// <param name="query">The person query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ConfigurationItemQuery SelectUsers(PersonQuery query)
        {
            query.FieldName = "users";
            return Select(query);
        }

        /// <summary>
        /// The person who will be responsible for coordinating the workflows that will be generated automatically in accordance with the recurrence schedule.
        /// </summary>
        /// <param name="query">The person query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ConfigurationItemQuery SelectWorkflowManager(PersonQuery query)
        {
            query.FieldName = "workflowManager";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The workflow template that is used to periodically maintain the configuration item.
        /// </summary>
        /// <param name="query">The workflow template query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ConfigurationItemQuery SelectWorkflowTemplate(WorkflowTemplateQuery query)
        {
            query.FieldName = "workflowTemplate";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// <br>Filter the 'ConfigurationItem' by their custom fields that have been marked as 'Filterable' in their UI Extension.</br>
        /// <br>Additional information is available on the <see href="https://developer.4me.com/graphql/input_object/configurationitemcustomfilter/">4me developer site</see>.</br>
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
        public ConfigurationItemQuery CustomFilter(string name, FilterOperator filterOperator, params string?[] values)
        {
            return AddCustomFilter(name, filterOperator, values);
        }
    }
}
