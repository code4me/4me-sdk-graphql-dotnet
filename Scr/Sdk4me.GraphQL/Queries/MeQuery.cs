namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The currently authenticated person.
    /// </summary>
    public class MeQuery : Query<MeQuery, PersonField, DefaultView, DefaultFilter, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new person query instance.
        /// </summary>
        public MeQuery()
            : base("me", typeof(Person), false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public MeQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Addresses of the record.
        /// </summary>
        /// <param name="query">The address query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public MeQuery SelectAddresses(AddressQuery query)
        {
            query.FieldName = "addresses";
            return Select(query);
        }

        /// <summary>
        /// The shop order lines related to this person with status in_cart.
        /// </summary>
        /// <param name="query">The shop order line query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public MeQuery SelectCart(ShopOrderLineQuery query)
        {
            query.FieldName = "cart";
            return Select(query);
        }

        /// <summary>
        /// Configuration items this person is related to as a user.
        /// </summary>
        /// <param name="query">The configuration item query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public MeQuery SelectConfigurationItems(ConfigurationItemQuery query)
        {
            query.FieldName = "configurationItems";
            return Select(query);
        }

        /// <summary>
        /// Contact details for this entity.
        /// </summary>
        /// <param name="query">The contact query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public MeQuery SelectContacts(ContactQuery query)
        {
            query.FieldName = "contacts";
            return Select(query);
        }

        /// <summary>
        /// Values of custom fields.
        /// </summary>
        /// <param name="query">The custom field query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public MeQuery SelectCustomFields(CustomFieldQuery query)
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
        public MeQuery SelectCustomFieldsAttachments(AttachmentQuery query)
        {
            query.FieldName = "customFieldsAttachments";
            return Select(query);
        }

        /// <summary>
        /// Files and inline images linked to the Information field.
        /// </summary>
        /// <param name="query">The attachment query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public MeQuery SelectInformationAttachments(AttachmentQuery query)
        {
            query.FieldName = "informationAttachments";
            return Select(query);
        }

        /// <summary>
        /// The manager or supervisor to whom the person reports.
        /// </summary>
        /// <param name="query">The person query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public MeQuery SelectManager(PersonQuery query)
        {
            query.FieldName = "manager";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The organization for which the person works as an employee or long-term contractor.
        /// </summary>
        /// <param name="query">The organization query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public MeQuery SelectOrganization(OrganizationQuery query)
        {
            query.FieldName = "organization";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Out of office periods for this person.
        /// </summary>
        /// <param name="query">The out of office period query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public MeQuery SelectOutOfOfficePeriods(OutOfOfficePeriodQuery query)
        {
            query.FieldName = "outOfOfficePeriods";
            return Select(query);
        }

        /// <summary>
        /// Permissions of this person.
        /// </summary>
        /// <param name="query">The permission query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public MeQuery SelectPermissions(PermissionQuery query)
        {
            query.FieldName = "permissions";
            return Select(query);
        }

        /// <summary>
        /// Where the person is stationed.
        /// </summary>
        /// <param name="query">The site query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public MeQuery SelectSite(SiteQuery query)
        {
            query.FieldName = "site";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Skill pools this person belongs to.
        /// </summary>
        /// <param name="query">The skill pool query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public MeQuery SelectSkillPools(SkillPoolQuery query)
        {
            query.FieldName = "skillPools";
            return Select(query);
        }

        /// <summary>
        /// Teams this person belongs to.
        /// </summary>
        /// <param name="query">The team query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public MeQuery SelectTeams(TeamQuery query)
        {
            query.FieldName = "teams";
            return Select(query);
        }

        /// <summary>
        /// UI extension that is linked to the record.
        /// </summary>
        /// <param name="query">The ui extension query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public MeQuery SelectUiExtension(UiExtensionQuery query)
        {
            query.FieldName = "uiExtension";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Calendar that represents the work hours of the person.
        /// </summary>
        /// <param name="query">The calendar query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public MeQuery SelectWorkHours(CalendarQuery query)
        {
            query.FieldName = "workHours";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
