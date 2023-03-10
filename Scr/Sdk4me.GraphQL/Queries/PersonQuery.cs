namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving Person records.
    /// </summary>
    public class PersonQuery : Query<PersonQuery, PersonField, PersonView, PersonOrderField>
    {
        /// <summary>
        /// Initialize a new person query instance.
        /// </summary>
        public PersonQuery()
            : base("people", typeof(Person), true)
        {
        }

        /// <summary>
        /// Addresses of the record.
        /// </summary>
        public PersonQuery SelectAddresses(AddressQuery query)
        {
            query.FieldName = "addresses";
            return Select(query);
        }

        /// <summary>
        /// The shop order lines related to this person with status in_cart.
        /// </summary>
        public PersonQuery SelectCart(ShopOrderLineQuery query)
        {
            query.FieldName = "cart";
            return Select(query);
        }

        /// <summary>
        /// Configuration items this person is related to as a user.
        /// </summary>
        public PersonQuery SelectConfigurationItems(ConfigurationItemQuery query)
        {
            query.FieldName = "configurationItems";
            return Select(query);
        }

        /// <summary>
        /// Contact details for this entity.
        /// </summary>
        public PersonQuery SelectContacts(ContactQuery query)
        {
            query.FieldName = "contacts";
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        public PersonQuery SelectCustomFieldsAttachments(AttachmentQuery query)
        {
            query.FieldName = "customFieldsAttachments";
            return Select(query);
        }

        /// <summary>
        /// Files and inline images linked to the Information field.
        /// </summary>
        public PersonQuery SelectInformationAttachments(AttachmentQuery query)
        {
            query.FieldName = "informationAttachments";
            return Select(query);
        }

        /// <summary>
        /// Out of office periods for this person.
        /// </summary>
        public PersonQuery SelectOutOfOfficePeriods(OutOfOfficePeriodQuery query)
        {
            query.FieldName = "outOfOfficePeriods";
            return Select(query);
        }

        /// <summary>
        /// Permissions of this person.
        /// </summary>
        public PersonQuery SelectPermissions(PermissionQuery query)
        {
            query.FieldName = "permissions";
            return Select(query);
        }

        /// <summary>
        /// Skill pools this person belongs to.
        /// </summary>
        public PersonQuery SelectSkillPools(SkillPoolQuery query)
        {
            query.FieldName = "skillPools";
            return Select(query);
        }

        /// <summary>
        /// Teams this person belongs to.
        /// </summary>
        public PersonQuery SelectTeams(TeamQuery query)
        {
            query.FieldName = "teams";
            return Select(query);
        }

        /// <summary>
        /// <br>Filter the 'Person' by their custom fields that have been marked as 'Filterable' in their UI Extension.</br>
        /// <br>Additional information is available on the <see href="https://developer.4me.com/graphql/input_object/personcustomfilter/">4me developer site</see>.</br>
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
        public PersonQuery CustomFilter(string name, FilterOperator filterOperator, params string[] values)
        {
            return AddCustomFilter(name, filterOperator, values);
        }
    }
}
