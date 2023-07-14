namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving Service records.
    /// </summary>
    public class ServiceQuery : Query<ServiceQuery, ServiceField, ServiceView, ServiceOrderField>
    {
        /// <summary>
        /// Initialize a new service query instance.
        /// </summary>
        public ServiceQuery()
            : base("services", typeof(Service), true)
        {
        }

        /// <summary>
        /// Initialize a new service query instance.
        /// <br>Additional filters and views will be ignored.</br>
        /// </summary>
        /// <param name="id">The ID of the service.</param>
        public ServiceQuery(string id)
            : base("Service", id, typeof(Service), false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        public ServiceQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The person who is responsible for ensuring that the availability targets specified in the active SLAs for the service are met.
        /// </summary>
        public ServiceQuery SelectAvailabilityManager(PersonQuery query)
        {
            query.FieldName = "availabilityManager";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The person who is responsible for ensuring that the service is not affected by incidents that are caused by capacity shortages.
        /// </summary>
        public ServiceQuery SelectCapacityManager(PersonQuery query)
        {
            query.FieldName = "capacityManager";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The person who is responsible for coordinating the changes of the service.
        /// </summary>
        public ServiceQuery SelectChangeManager(PersonQuery query)
        {
            query.FieldName = "changeManager";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The person who is responsible for creating and maintaining the continuity plans for the service's instances that have an active SLA with a continuity target.
        /// </summary>
        public ServiceQuery SelectContinuityManager(PersonQuery query)
        {
            query.FieldName = "continuityManager";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Values of custom fields.
        /// </summary>
        public ServiceQuery SelectCustomFields(CustomFieldQuery query)
        {
            query.FieldName = "customFields";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        public ServiceQuery SelectCustomFieldsAttachments(AttachmentQuery query)
        {
            query.FieldName = "customFieldsAttachments";
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to the Description field.
        /// </summary>
        public ServiceQuery SelectDescriptionAttachments(AttachmentQuery query)
        {
            query.FieldName = "descriptionAttachments";
            return Select(query);
        }

        /// <summary>
        /// The team that will, by default, be selected in the First line team field of a new service instance when it is being registered for the service.
        /// </summary>
        public ServiceQuery SelectFirstLineTeam(TeamQuery query)
        {
            query.FieldName = "firstLineTeam";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The person who is responsible for the quality of the knowledge articles for the service.
        /// </summary>
        public ServiceQuery SelectKnowledgeManager(PersonQuery query)
        {
            query.FieldName = "knowledgeManager";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The person who is responsible for coordinating the problems that directly affect the service.
        /// </summary>
        public ServiceQuery SelectProblemManager(PersonQuery query)
        {
            query.FieldName = "problemManager";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The person who is responsible for coordinating the releases of the service.
        /// </summary>
        public ServiceQuery SelectReleaseManager(PersonQuery query)
        {
            query.FieldName = "releaseManager";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Service instances related to this service.
        /// </summary>
        public ServiceQuery SelectServiceInstances(ServiceInstanceQuery query)
        {
            query.FieldName = "serviceInstances";
            return Select(query);
        }

        /// <summary>
        /// Service level agreements related to this service through the service offering.
        /// </summary>
        public ServiceQuery SelectServiceLevelAgreements(ServiceLevelAgreementQuery query)
        {
            query.FieldName = "serviceLevelAgreements";
            return Select(query);
        }

        /// <summary>
        /// Service offerings related to this service.
        /// </summary>
        public ServiceQuery SelectServiceOfferings(ServiceOfferingQuery query)
        {
            query.FieldName = "serviceOfferings";
            return Select(query);
        }

        /// <summary>
        /// The person who is responsible for ensuring that the service level targets specified in the SLAs for the service are met.
        /// </summary>
        public ServiceQuery SelectServiceOwner(PersonQuery query)
        {
            query.FieldName = "serviceOwner";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The organization that provides the service.
        /// </summary>
        public ServiceQuery SelectServiceProvider(OrganizationQuery query)
        {
            query.FieldName = "serviceProvider";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The team  that will, by default, be selected in the Support team field of a service instance when one is registered for the service. Similarly, this team will be selected in the Team field of a problem when the service is related to it.
        /// </summary>
        public ServiceQuery SelectSupportTeam(TeamQuery query)
        {
            query.FieldName = "supportTeam";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Survey used to measure customer rating of this service.
        /// </summary>
        public ServiceQuery SelectSurvey(SurveyQuery query)
        {
            query.FieldName = "survey";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Translations associated with this object.
        /// </summary>
        public ServiceQuery SelectTranslations(TranslationQuery query)
        {
            query.FieldName = "translations";
            return Select(query);
        }

        /// <summary>
        /// UI extension that is linked to the record.
        /// </summary>
        public ServiceQuery SelectUiExtension(UiExtensionQuery query)
        {
            query.FieldName = "uiExtension";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// <br>Filter the 'Service' by their custom fields that have been marked as 'Filterable' in their UI Extension.</br>
        /// <br>Additional information is available on the <see href="https://developer.4me.com/graphql/input_object/servicecustomfilter/">4me developer site</see>.</br>
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
        public ServiceQuery CustomFilter(string name, FilterOperator filterOperator, params string?[] values)
        {
            return AddCustomFilter(name, filterOperator, values);
        }
    }
}
