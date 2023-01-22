namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving Organization records.
    /// </summary>
    public class OrganizationQuery : Query<OrganizationQuery, OrganizationField, OrganizationView, OrganizationOrderField>
    {
        /// <summary>
        /// Initialize a new organization query instance.
        /// </summary>
        public OrganizationQuery()
            : base("organizations", typeof(Organization), true)
        {
        }

        /// <summary>
        /// Addresses of the record.
        /// </summary>
        public OrganizationQuery SelectAddresses(AddressQuery query)
        {
            query.FieldName = "addresses";
            return Select(query);
        }

        /// <summary>
        /// Child organizations of this organization, i.e. organizations that have this organization as their parent.
        /// </summary>
        public OrganizationQuery SelectChildOrganizations(OrganizationQuery query)
        {
            query.FieldName = "childOrganizations";
            return Select(query);
        }

        /// <summary>
        /// Contact details for this entity.
        /// </summary>
        public OrganizationQuery SelectContacts(ContactQuery query)
        {
            query.FieldName = "contacts";
            return Select(query);
        }

        /// <summary>
        /// Contracts of this organization.
        /// </summary>
        public OrganizationQuery SelectContracts(ContractQuery query)
        {
            query.FieldName = "contracts";
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        public OrganizationQuery SelectCustomFieldsAttachments(AttachmentQuery query)
        {
            query.FieldName = "customFieldsAttachments";
            return Select(query);
        }

        /// <summary>
        /// People of this organization.
        /// </summary>
        public OrganizationQuery SelectPeople(PersonQuery query)
        {
            query.FieldName = "people";
            return Select(query);
        }

        /// <summary>
        /// Files and inline images linked to the Remarks field.
        /// </summary>
        public OrganizationQuery SelectRemarksAttachments(AttachmentQuery query)
        {
            query.FieldName = "remarksAttachments";
            return Select(query);
        }

        /// <summary>
        /// Risks of this organization.
        /// </summary>
        public OrganizationQuery SelectRisks(RiskQuery query)
        {
            query.FieldName = "risks";
            return Select(query);
        }

        /// <summary>
        /// Service level agreements which coverage field is set to `organizations` and which cover the organization.
        /// </summary>
        public OrganizationQuery SelectServiceLevelAgreements(ServiceLevelAgreementQuery query)
        {
            query.FieldName = "serviceLevelAgreements";
            return Select(query);
        }

        /// <summary>
        /// Time allocations of this organization.
        /// </summary>
        public OrganizationQuery SelectTimeAllocations(TimeAllocationQuery query)
        {
            query.FieldName = "timeAllocations";
            return Select(query);
        }

        /// <summary>
        /// <br>Filter the 'Organization' by their custom fields that have been marked as 'Filterable' in their UI Extension.</br>
        /// <br>Additional information is available on the <see href="https://developer.4me.com/graphql/input_object/organizationcustomfilter/">4me developer site</see>.</br>
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
        public OrganizationQuery CustomFilter(string name, FilterOperator filterOperator, params string[] values)
        {
            return AddCustomFilter(name, filterOperator, values);
        }
    }
}
