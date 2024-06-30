using System;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving ServiceInstance records.
    /// </summary>
    public class ServiceInstanceQuery : Query<ServiceInstanceQuery, ServiceInstanceField, ServiceInstanceView, ServiceInstanceFilter, ServiceInstanceOrderField>
    {
        /// <summary>
        /// Initialize a new service instance query instance.
        /// </summary>
        public ServiceInstanceQuery()
            : base("serviceInstances", typeof(ServiceInstance), true)
        {
        }

        /// <summary>
        /// Initialize a new service instance query instance.
        /// <br>Additional filters and views will be ignored.</br>
        /// </summary>
        /// <param name="id">The ID of the service instance.</param>
        public ServiceInstanceQuery(string id)
            : base("ServiceInstance", id, typeof(ServiceInstance), false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceInstanceQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Children of the service instance.
        /// </summary>
        /// <param name="query">The service instance query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceInstanceQuery SelectChildServiceInstances(ServiceInstanceQuery query)
        {
            query.FieldName = "childServiceInstances";
            return Select(query);
        }

        /// <summary>
        /// Configuration items of the service instance.
        /// </summary>
        /// <param name="query">The configuration item query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceInstanceQuery SelectConfigurationItems(ConfigurationItemQuery query)
        {
            query.FieldName = "configurationItems";
            return Select(query);
        }

        /// <summary>
        /// Values of custom fields.
        /// </summary>
        /// <param name="query">The custom field query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceInstanceQuery SelectCustomFields(CustomFieldQuery query)
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
        public ServiceInstanceQuery SelectCustomFieldsAttachments(AttachmentQuery query)
        {
            query.FieldName = "customFieldsAttachments";
            return Select(query);
        }

        /// <summary>
        /// Used to select the team that will automatically be selected in the Team field of requests to which the service instance is linked after they have been submitted using Self Service or when they are generated using the Requests API, Mail API or Events API.
        /// </summary>
        /// <param name="query">The team query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceInstanceQuery SelectFirstLineTeam(TeamQuery query)
        {
            query.FieldName = "firstLineTeam";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The maintenance window defines the periods in which workflow tasks with an impact related to this service instance may be implemented.
        /// </summary>
        /// <param name="query">The calendar query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceInstanceQuery SelectMaintenanceWindow(CalendarQuery query)
        {
            query.FieldName = "maintenanceWindow";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Parents of the service instance.
        /// </summary>
        /// <param name="query">The service instance query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceInstanceQuery SelectParentServiceInstances(ServiceInstanceQuery query)
        {
            query.FieldName = "parentServiceInstances";
            return Select(query);
        }

        /// <summary>
        /// Files and inline images linked to the Remarks field.
        /// </summary>
        /// <param name="query">The attachment query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceInstanceQuery SelectRemarksAttachments(AttachmentQuery query)
        {
            query.FieldName = "remarksAttachments";
            return Select(query);
        }

        /// <summary>
        /// The service which functionality the service instance provides.
        /// </summary>
        /// <param name="query">The service query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceInstanceQuery SelectService(ServiceQuery query)
        {
            query.FieldName = "service";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Service level agreements of the service instance.
        /// </summary>
        /// <param name="query">The service level agreement query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceInstanceQuery SelectServiceLevelAgreements(ServiceLevelAgreementQuery query)
        {
            query.FieldName = "serviceLevelAgreements";
            return Select(query);
        }

        /// <summary>
        /// The team that will, by default, be selected in the Team field of a request when the service instance is manually selected in the Service instance field of the request, or when the service instance is applied from the Service Hierarchy Browser.
        /// </summary>
        /// <param name="query">The team query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceInstanceQuery SelectSupportTeam(TeamQuery query)
        {
            query.FieldName = "supportTeam";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Translations associated with this object.
        /// </summary>
        /// <param name="query">The translation query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceInstanceQuery SelectTranslations(TranslationQuery query)
        {
            query.FieldName = "translations";
            return Select(query);
        }

        /// <summary>
        /// UI extension that is linked to the record.
        /// </summary>
        /// <param name="query">The ui extension query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceInstanceQuery SelectUiExtension(UiExtensionQuery query)
        {
            query.FieldName = "uiExtension";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// <br>Filter the 'ServiceInstance' by their custom fields that have been marked as 'Filterable' in their UI Extension.</br>
        /// <br>Additional information is available on the <see href="https://developer.4me.com/graphql/input_object/serviceinstancecustomfilter/">4me developer site</see>.</br>
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
        public ServiceInstanceQuery CustomFilter(string name, FilterOperator filterOperator, params string?[] values)
        {
            return AddCustomFilter(name, filterOperator, values);
        }
    }
}
