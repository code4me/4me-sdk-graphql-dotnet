namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving ConfigurationItem records.
    /// </summary>
    public class ConfigurationItemQuery : Query<ConfigurationItemQuery, ConfigurationItemField, ConfigurationItemView, ConfigurationItemOrderField>
    {
        /// <summary>
        /// Initialize a new configuration item query instance.
        /// </summary>
        public ConfigurationItemQuery()
            : base("configurationItems", typeof(ConfigurationItem), true)
        {
        }

        /// <summary>
        /// Relations to other configuration items.
        /// </summary>
        public ConfigurationItemQuery SelectCiRelations(ConfigurationItemRelationQuery query)
        {
            query.FieldName = "ciRelations";
            return Select(query);
        }

        /// <summary>
        /// All contracts of this configuration item.
        /// </summary>
        public ConfigurationItemQuery SelectContracts(ContractQuery query)
        {
            query.FieldName = "contracts";
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        public ConfigurationItemQuery SelectCustomFieldsAttachments(AttachmentQuery query)
        {
            query.FieldName = "customFieldsAttachments";
            return Select(query);
        }

        /// <summary>
        /// Invoices associated with this object.
        /// </summary>
        public ConfigurationItemQuery SelectInvoices(InvoiceQuery query)
        {
            query.FieldName = "invoices";
            return Select(query);
        }

        /// <summary>
        /// Sites at which the software that is covered by the license certificate may be used.
        /// </summary>
        public ConfigurationItemQuery SelectLicensedSites(SiteQuery query)
        {
            query.FieldName = "licensedSites";
            return Select(query);
        }

        /// <summary>
        /// All problems of this configuration item.
        /// </summary>
        public ConfigurationItemQuery SelectProblems(ProblemQuery query)
        {
            query.FieldName = "problems";
            return Select(query);
        }

        /// <summary>
        /// Files and inline images linked to the Remarks field.
        /// </summary>
        public ConfigurationItemQuery SelectRemarksAttachments(AttachmentQuery query)
        {
            query.FieldName = "remarksAttachments";
            return Select(query);
        }

        /// <summary>
        /// All requests of this configuration item.
        /// </summary>
        public ConfigurationItemQuery SelectRequests(RequestQuery query)
        {
            query.FieldName = "requests";
            return Select(query);
        }

        /// <summary>
        /// All service instances of this configuration item.
        /// </summary>
        public ConfigurationItemQuery SelectServiceInstances(ServiceInstanceQuery query)
        {
            query.FieldName = "serviceInstances";
            return Select(query);
        }

        /// <summary>
        /// All users of this configuration item.
        /// </summary>
        public ConfigurationItemQuery SelectUsers(PersonQuery query)
        {
            query.FieldName = "users";
            return Select(query);
        }

        /// <summary>
        /// <br>Filter the 'ConfigurationItem' by their custom fields that have been marked as 'Filterable' in their UI Extension.</br>
        /// <br>Additional information is available on the <see href="https://developer.4me.com/graphql/input_object/configurationitemcustomfilter/">4me developer site</see>.</br>
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
        public ConfigurationItemQuery CustomFilter(string name, FilterOperator filterOperator, params string[] values)
        {
            return AddCustomFilter(name, filterOperator, values);
        }
    }
}
