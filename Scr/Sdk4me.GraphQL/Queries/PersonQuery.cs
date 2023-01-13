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
    }
}
