namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving ServiceInstance records.
    /// </summary>
    public class ServiceInstanceQuery : Query<ServiceInstanceQuery, ServiceInstanceField, ServiceInstanceView, ServiceInstanceOrderField>
    {
        /// <summary>
        /// Initialize a new service instance query instance.
        /// </summary>
        public ServiceInstanceQuery()
            : base("serviceInstances", typeof(ServiceInstance), true)
        {
        }

        /// <summary>
        /// Children of the service instance.
        /// </summary>
        public ServiceInstanceQuery SelectChildServiceInstances(ServiceInstanceQuery query)
        {
            query.FieldName = "childServiceInstances";
            return Select(query);
        }

        /// <summary>
        /// Configuration items of the service instance.
        /// </summary>
        public ServiceInstanceQuery SelectConfigurationItems(ConfigurationItemQuery query)
        {
            query.FieldName = "configurationItems";
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        public ServiceInstanceQuery SelectCustomFieldsAttachments(AttachmentQuery query)
        {
            query.FieldName = "customFieldsAttachments";
            return Select(query);
        }

        /// <summary>
        /// Parents of the service instance.
        /// </summary>
        public ServiceInstanceQuery SelectParentServiceInstances(ServiceInstanceQuery query)
        {
            query.FieldName = "parentServiceInstances";
            return Select(query);
        }

        /// <summary>
        /// Files and inline images linked to the Remarks field.
        /// </summary>
        public ServiceInstanceQuery SelectRemarksAttachments(AttachmentQuery query)
        {
            query.FieldName = "remarksAttachments";
            return Select(query);
        }

        /// <summary>
        /// Service level agreements of the service instance.
        /// </summary>
        public ServiceInstanceQuery SelectServiceLevelAgreements(ServiceLevelAgreementQuery query)
        {
            query.FieldName = "serviceLevelAgreements";
            return Select(query);
        }

        /// <summary>
        /// Translations associated with this object.
        /// </summary>
        public ServiceInstanceQuery SelectTranslations(TranslationQuery query)
        {
            query.FieldName = "translations";
            return Select(query);
        }

        /// <summary>
        /// <br>Filter the 'ServiceInstance' by their custom fields that have been marked as 'Filterable' in their UI Extension.</br>
        /// <br>Additional information is available on the <see href="https://developer.4me.com/graphql/input_object/serviceinstancecustomfilter/">4me developer site</see>.</br>
        /// </summary>
        /// <param name="name">The name of the custom filter (i.e. value of the data-filterable-name attribute of the field in the UI Extension).</param>
        /// <param name="filterOperator">The filter operator.</param>
        /// <param name="values">The filter values.
        /// <br>Use value null to indicate "None".</br>
        /// <br></br>
        /// <br>For "text" fields:</br>
        /// <br>- One can start the value with ~ to get partial matches (start with '~ to match on a value starting with ~).</br>
        /// <br></br>
        /// <br>For "number" and "time" fields:</br>
        /// <br>- One can start the value with &lt;, &gt;, &lt;=, &gt;= to get relative matches.</br>
        /// <br>- Times should be formatted as HH:mm:ss (e.g. 16:00:00). The seconds part, :ss, is optional so 16:00 is also valid.</br>
        /// <br>- &gt;{lower}&lt;{upper} can be used to get matches where the value is more than '{lower}' and less than '{upper}'.</br>
        /// <br>- &gt;={lower}&lt;={upper} can be used to get matches where the value is between '{lower}' and '{upper}'.</br>
        /// <br>- &gt;={lower}&lt;{upper} can be used to get matches where the value is at least '{lower}' and less than '{upper}'.</br>
        /// <br></br>
        /// <br>For "date" and "date-time" fields:</br>
        /// <br>- One must supply a single value (and null is not supported).</br>
        /// <br>- Matches are always relative with an optional upper bound.</br>
        /// <br>- Dates should be formatted as yyyy-MM-dd (e.g. 2020-05-20).</br>
        /// <br>- Date and time should be formatted as yyyy-MM-ddTHH:mm:ssZ (e.g. 2020-05-20T16:00:00Z).</br>
        /// <br>- &gt;={lower} should be used to get matches where the value is at least '{lower}'.</br>
        /// <br>- &gt;={lower}&lt;{upper} can be used to get matches where the value is at least '{lower}' and before '{upper}'.</br>
        /// <br></br>
        /// <br>Matches are case-sensitive.</br>
        /// </param>
        /// <exception cref="NullReferenceException"></exception>
        public ServiceInstanceQuery CustomFilter(string name, FilterOperator filterOperator, params string[] values)
        {
            return AddCustomFilter(name, filterOperator, values);
        }
    }
}
