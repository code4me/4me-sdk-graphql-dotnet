using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/person/">Person</see> object.
    /// </summary>
    public class Person : Node, IHasLifeCycleState
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account"), Sdk4meField(true)]
        public Account? Account { get; internal set; }

        [JsonProperty("addresses")]
        internal NodeCollection<Address>? AddressesCollection { get; set; }

        /// <summary>
        /// Addresses of the record.
        /// </summary>
        public DataList<Address>? Addresses
        {
            get => AddressesCollection?.Data;
        }

        /// <summary>
        /// Uniquely identify the user for Single Sign-On
        /// </summary>
        [JsonProperty("authenticationID"), Sdk4meField(true)]
        public string? AuthenticationID { get; internal set; }

        /// <summary>
        /// Whether the person should be offered translations for texts that are written in languages other than the ones selected in the Language (language) and the Do not translate (do_not_translate_languages) fields. Such texts are translated automatically into the language selected in the Language (language) field.
        /// </summary>
        [JsonProperty("autoTranslation")]
        public bool? AutoTranslation { get; internal set; }

        [JsonProperty("cart")]
        internal NodeCollection<ShopOrderLine>? CartCollection { get; set; }

        /// <summary>
        /// The shop order lines related to this person with status in_cart.
        /// </summary>
        public DataList<ShopOrderLine>? Cart
        {
            get => CartCollection?.Data;
        }

        [JsonProperty("configurationItems")]
        internal NodeCollection<ConfigurationItem>? ConfigurationItemsCollection { get; set; }

        /// <summary>
        /// Configuration items this person is related to as a user.
        /// </summary>
        public DataList<ConfigurationItem>? ConfigurationItems
        {
            get => ConfigurationItemsCollection?.Data;
        }

        [JsonProperty("contacts")]
        internal NodeCollection<Contact>? ContactsCollection { get; set; }

        /// <summary>
        /// Contact details for this entity.
        /// </summary>
        public DataList<Contact>? Contacts
        {
            get => ContactsCollection?.Data;
        }

        /// <summary>
        /// The person's estimated total cost per work hour for the service provider organization. The value in this field should include the costs of the person's salary (or rate in case of a long-term contractor), office space, service subscriptions, training, etc.
        /// </summary>
        [JsonProperty("costPerHour")]
        public decimal? CostPerHour { get; internal set; }

        /// <summary>
        /// <br>The currency of the cost per hour value of this skill pool.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/currency/">4me developer site</see>.</br>
        /// </summary>
        [JsonProperty("costPerHourCurrency")]
        public string? CostPerHourCurrency { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Values of custom fields.
        /// </summary>
        [JsonProperty("customFields")]
        public CustomFieldCollection? CustomFields { get; internal set; }

        [JsonProperty("customFieldsAttachments")]
        internal NodeCollection<Attachment>? CustomFieldsAttachmentsCollection { get; set; }

        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        public DataList<Attachment>? CustomFieldsAttachments
        {
            get => CustomFieldsAttachmentsCollection?.Data;
        }

        /// <summary>
        /// <c>true</c> when the person may no longer be related to other records.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// The languages that should not be translated automatically for the person. Translations will not be offered to the person for texts in any of these languages. This field can contain a comma-separated list of language codes. Supported language codes are: en, nl, de, fr, es, pt, it, da, fi, sv, pl, cs, tr, ru, ar, id, fa, no, zh, ja, ko, he, hi, ms.
        /// </summary>
        [JsonProperty("doNotTranslateLanguages")]
        public List<string>? DoNotTranslateLanguages { get; internal set; }

        /// <summary>
        /// The unique identifier for a person typically based on order of hire or association with an organization.
        /// </summary>
        [JsonProperty("employeeID"), Sdk4meField(true)]
        public string? EmployeeID { get; internal set; }

        /// <summary>
        /// Whether team notifications should be excluded from all notifications.
        /// </summary>
        [JsonProperty("excludeTeamNotifications")]
        public bool? ExcludeTeamNotifications { get; internal set; }

        /// <summary>
        /// <c>true</c> when the person registered as a guest in self service.
        /// </summary>
        [JsonProperty("guest")]
        public bool? Guest { get; internal set; }

        /// <summary>
        /// Any additional information about the person that might prove useful.
        /// </summary>
        [JsonProperty("information")]
        public string? Information { get; internal set; }

        [JsonProperty("informationAttachments")]
        internal NodeCollection<Attachment>? InformationAttachmentsCollection { get; set; }

        /// <summary>
        /// Files and inline images linked to the Information field.
        /// </summary>
        public DataList<Attachment>? InformationAttachments
        {
            get => InformationAttachmentsCollection?.Data;
        }

        /// <summary>
        /// The person's job title.
        /// </summary>
        [JsonProperty("jobTitle")]
        public string? JobTitle { get; internal set; }

        /// <summary>
        /// <br>The language preference of the person.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/language/">4me developer site</see>.</br>
        /// </summary>
        [JsonProperty("language")]
        public string? Language { get; internal set; }

        /// <summary>
        /// Current state of the record.
        /// </summary>
        [JsonProperty("lifeCycleState")]
        public LifeCycleState? LifeCycleState { get; internal set; }

        /// <summary>
        /// The name or number of the room, cubicle or area where the person has his/her primary work space.
        /// </summary>
        [JsonProperty("location")]
        public string? Location { get; internal set; }

        /// <summary>
        /// The manager or supervisor to whom the person reports.
        /// </summary>
        [JsonProperty("manager")]
        public Person? Manager { get; internal set; }

        /// <summary>
        /// The person's name.
        /// </summary>
        [JsonProperty("name"), Sdk4meField(true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// An enabled OAuth person is mentionable and visible in suggest fields, just like a real person.
        /// </summary>
        [JsonProperty("oauthPersonEnablement")]
        public bool? OauthPersonEnablement { get; internal set; }

        /// <summary>
        /// The organization for which the person works as an employee or long-term contractor.
        /// </summary>
        [JsonProperty("organization")]
        public Organization? Organization { get; internal set; }

        [JsonProperty("outOfOfficePeriods")]
        internal NodeCollection<OutOfOfficePeriod>? OutOfOfficePeriodsCollection { get; set; }

        /// <summary>
        /// Out of office periods for this person.
        /// </summary>
        public DataList<OutOfOfficePeriod>? OutOfOfficePeriods
        {
            get => OutOfOfficePeriodsCollection?.Data;
        }

        [JsonProperty("permissions")]
        internal NodeCollection<Permission>? PermissionsCollection { get; set; }

        /// <summary>
        /// Permissions of this person.
        /// </summary>
        public DataList<Permission>? Permissions
        {
            get => PermissionsCollection?.Data;
        }

        /// <summary>
        /// The hyperlink to the image file for the record.
        /// </summary>
        [JsonProperty("pictureUri")]
        public string? PictureUri { get; internal set; }

        /// <summary>
        /// The email address to which email notifications are to be sent. This email address acts as the unique identifier for the person within the 4me account. This primary email address also acts as the person's login name if he/she is a user of the 4me service.
        /// </summary>
        [JsonProperty("primaryEmail"), Sdk4meField(true)]
        public string? PrimaryEmail { get; internal set; }

        /// <summary>
        /// Indicates when to send email notifications to the person.
        /// </summary>
        [JsonProperty("sendEmailNotifications")]
        public PersonSendEmailNotifications? SendEmailNotifications { get; internal set; }

        /// <summary>
        /// Indicates when to show a notification popup to the person.
        /// </summary>
        [JsonProperty("showNotificationPopup")]
        public PersonShowNotificationPopup? ShowNotificationPopup { get; internal set; }

        /// <summary>
        /// Where the person is stationed.
        /// </summary>
        [JsonProperty("site")]
        public Site? Site { get; internal set; }

        [JsonProperty("skillPools")]
        internal NodeCollection<SkillPool>? SkillPoolsCollection { get; set; }

        /// <summary>
        /// Skill pools this person belongs to.
        /// </summary>
        public DataList<SkillPool>? SkillPools
        {
            get => SkillPoolsCollection?.Data;
        }

        /// <summary>
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [JsonProperty("source"), Sdk4meField(true)]
        public string? Source { get; internal set; }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [JsonProperty("sourceID"), Sdk4meField(true)]
        public string? SourceID { get; internal set; }

        /// <summary>
        /// A number or code that a service desk analyst can ask the person for when the person contacts the service desk for support.
        /// </summary>
        [JsonProperty("supportID"), Sdk4meField(true)]
        public string? SupportID { get; internal set; }

        [JsonProperty("teams")]
        internal NodeCollection<Team>? TeamsCollection { get; set; }

        /// <summary>
        /// Teams this person belongs to.
        /// </summary>
        public DataList<Team>? Teams
        {
            get => TeamsCollection?.Data;
        }

        /// <summary>
        /// Whether the person prefers to see times displayed within the 4me service in the 24-hour format or not (in which case the 12-hour format is applied).
        /// </summary>
        [JsonProperty("timeFormat24h")]
        public bool? TimeFormat24h { get; internal set; }

        /// <summary>
        /// <br>The time zone in which the person normally resides.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/timezone/">4me developer site</see>.</br>
        /// </summary>
        [JsonProperty("timeZone")]
        public string? TimeZone { get; internal set; }

        /// <summary>
        /// UI extension that is linked to the record.
        /// </summary>
        [JsonProperty("uiExtension")]
        public UiExtension? UiExtension { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [JsonProperty("updatedAt"), Sdk4meField(true)]
        public DateTime? UpdatedAt { get; internal set; }

        /// <summary>
        /// Whether the person is a very important person.
        /// </summary>
        [JsonProperty("vip"), Sdk4meField(true)]
        public bool? Vip { get; internal set; }

        /// <summary>
        /// Calendar that represents the work hours of the person.
        /// </summary>
        [JsonProperty("workHours")]
        public Calendar? WorkHours { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(AddressesCollection?.GetQueryPageInfo("addresses", depth + 1));
            retval.AddRange(CartCollection?.GetQueryPageInfo("cart", depth + 1));
            retval.AddRange(ConfigurationItemsCollection?.GetQueryPageInfo("configurationItems", depth + 1));
            retval.AddRange(ContactsCollection?.GetQueryPageInfo("contacts", depth + 1));
            retval.AddRange(CustomFieldsAttachmentsCollection?.GetQueryPageInfo("customFieldsAttachments", depth + 1));
            retval.AddRange(InformationAttachmentsCollection?.GetQueryPageInfo("informationAttachments", depth + 1));
            retval.AddRange(OutOfOfficePeriodsCollection?.GetQueryPageInfo("outOfOfficePeriods", depth + 1));
            retval.AddRange(PermissionsCollection?.GetQueryPageInfo("permissions", depth + 1));
            retval.AddRange(SkillPoolsCollection?.GetQueryPageInfo("skillPools", depth + 1));
            retval.AddRange(TeamsCollection?.GetQueryPageInfo("teams", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            Addresses?.AddRange((data as Person)?.Addresses);
            Cart?.AddRange((data as Person)?.Cart);
            ConfigurationItems?.AddRange((data as Person)?.ConfigurationItems);
            Contacts?.AddRange((data as Person)?.Contacts);
            CustomFieldsAttachments?.AddRange((data as Person)?.CustomFieldsAttachments);
            InformationAttachments?.AddRange((data as Person)?.InformationAttachments);
            OutOfOfficePeriods?.AddRange((data as Person)?.OutOfOfficePeriods);
            Permissions?.AddRange((data as Person)?.Permissions);
            SkillPools?.AddRange((data as Person)?.SkillPools);
            Teams?.AddRange((data as Person)?.Teams);
        }
    }
}
