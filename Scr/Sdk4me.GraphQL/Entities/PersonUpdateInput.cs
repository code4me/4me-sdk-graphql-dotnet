namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/personupdateinput/">PersonUpdateInput</see> object.
    /// </summary>
    public class PersonUpdateInput : PropertyChangeSet
    {
        private List<string>? accountPermissionsToDelete;
        private List<string>? addressesToDelete;
        private string? authenticationID;
        private bool? autoTranslation;
        private string? clientMutationId;
        private List<string>? configurationItemIds;
        private List<string>? contactsToDelete;
        private decimal? costPerHour;
        private string? costPerHourCurrency;
        private CustomFieldCollection? customFields;
        private List<AttachmentInput>? customFieldsAttachments;
        private bool? disabled;
        private List<string>? doNotTranslateLanguages;
        private string? employeeID;
        private bool? excludeTeamNotifications;
        private string? id;
        private string? information;
        private string? jobTitle;
        private string? language;
        private string? location;
        private string? managerId;
        private string? name;
        private List<PermissionInput>? newAccountPermissions;
        private List<AddressInput>? newAddresses;
        private List<ContactInput>? newContacts;
        private bool? oauthPersonEnablement;
        private string? organizationId;
        private List<PermissionInput>? permissions;
        private string? pictureUri;
        private string? primaryEmail;
        private PersonSendEmailNotifications? sendEmailNotifications;
        private PersonShowNotificationPopup? showNotificationPopup;
        private string? siteId;
        private List<string>? skillPoolIds;
        private string? source;
        private string? sourceID;
        private string? supportID;
        private List<string>? teamIds;
        private bool? timeFormat24h;
        private string? timeZone;
        private string? uiExtensionId;
        private bool? vip;
        private string? workHoursId;

        /// <summary>
        /// Identifiers of accounts this person's permissions will be deleted for. Permissions for other accounts will not be altered.
        /// </summary>
        [JsonProperty("accountPermissionsToDelete")]
        public List<string>? AccountPermissionsToDelete
        {
            get => accountPermissionsToDelete;
            set => accountPermissionsToDelete = Set("accountPermissionsToDelete", value);
        }

        /// <summary>
        /// Identifiers of addresses to remove from this person.
        /// </summary>
        [JsonProperty("addressesToDelete")]
        public List<string>? AddressesToDelete
        {
            get => addressesToDelete;
            set => addressesToDelete = Set("addressesToDelete", value);
        }

        /// <summary>
        /// Uniquely identify the user for Single Sign-On
        /// </summary>
        [JsonProperty("authenticationID")]
        public string? AuthenticationID
        {
            get => authenticationID;
            set => authenticationID = Set("authenticationID", value);
        }

        /// <summary>
        /// Whether the person should be offered translations for texts that are written in languages other than the ones selected in the Language (language) and the Do not translate (do_not_translate_languages) arguments. Such texts are translated automatically into the language selected in the Language (language) argument.
        /// </summary>
        [JsonProperty("autoTranslation")]
        public bool? AutoTranslation
        {
            get => autoTranslation;
            set => autoTranslation = Set("autoTranslation", value);
        }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        [JsonProperty("clientMutationId")]
        public string? ClientMutationId
        {
            get => clientMutationId;
            set => clientMutationId = Set("clientMutationId", value);
        }

        /// <summary>
        /// Configuration items this person is related to as a user.
        /// </summary>
        [JsonProperty("configurationItemIds")]
        public List<string>? ConfigurationItemIds
        {
            get => configurationItemIds;
            set => configurationItemIds = Set("configurationItemIds", value);
        }

        /// <summary>
        /// Identifiers of contacts to remove from this person.
        /// </summary>
        [JsonProperty("contactsToDelete")]
        public List<string>? ContactsToDelete
        {
            get => contactsToDelete;
            set => contactsToDelete = Set("contactsToDelete", value);
        }

        /// <summary>
        /// The person's estimated total cost per work hour for the service provider organization. The value in this argument should include the costs of the person's salary (or rate in case of a long-term contractor), office space, service subscriptions, training, etc.
        /// </summary>
        [JsonProperty("costPerHour")]
        public decimal? CostPerHour
        {
            get => costPerHour;
            set => costPerHour = Set("costPerHour", value);
        }

        /// <summary>
        /// <br>The currency of the cost per hour value attributed to this person.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/currency/">4me developer site</see>.</br>
        /// </summary>
        [JsonProperty("costPerHourCurrency")]
        public string? CostPerHourCurrency
        {
            get => costPerHourCurrency;
            set => costPerHourCurrency = Set("costPerHourCurrency", value);
        }

        /// <summary>
        /// Values for custom fields to be used by the UI Extension that is linked to the record.
        /// </summary>
        [JsonProperty("customFields")]
        public CustomFieldCollection? CustomFields
        {
            get => customFields;
            set => customFields = Set("customFields", value);
        }

        /// <summary>
        /// The attachments used in the custom fields' values.
        /// </summary>
        [JsonProperty("customFieldsAttachments")]
        public List<AttachmentInput>? CustomFieldsAttachments
        {
            get => customFieldsAttachments;
            set => customFieldsAttachments = Set("customFieldsAttachments", value);
        }

        /// <summary>
        /// <c>true</c> when the person may no longer be related to other records.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled
        {
            get => disabled;
            set => disabled = Set("disabled", value);
        }

        /// <summary>
        /// The languages that should not be translated automatically for the person. Translations will not be offered to the person for texts in any of these languages. Supported language codes are: <c>en</c>, <c>nl</c>, <c>de</c>, <c>fr</c>, <c>es</c>, <c>pt</c>, <c>it</c>, <c>da</c>, <c>fi</c>, <c>sv</c>, <c>pl</c>, <c>cs</c>, <c>tr</c>, <c>ru</c>, <c>ar</c>, <c>id</c>, <c>fa</c>, <c>no</c>, <c>zh</c>, <c>ja</c>, <c>ko</c>, <c>he</c>, <c>hi</c>, <c>ms</c>.
        /// </summary>
        [JsonProperty("doNotTranslateLanguages")]
        public List<string>? DoNotTranslateLanguages
        {
            get => doNotTranslateLanguages;
            set => doNotTranslateLanguages = Set("doNotTranslateLanguages", value);
        }

        /// <summary>
        /// The unique identifier for a person typically based on order of hire or association with an organization.
        /// </summary>
        [JsonProperty("employeeID")]
        public string? EmployeeID
        {
            get => employeeID;
            set => employeeID = Set("employeeID", value);
        }

        /// <summary>
        /// Whether team notifications should be excluded from all notifications.
        /// </summary>
        [JsonProperty("excludeTeamNotifications")]
        public bool? ExcludeTeamNotifications
        {
            get => excludeTeamNotifications;
            set => excludeTeamNotifications = Set("excludeTeamNotifications", value);
        }

        /// <summary>
        /// The node ID of the record to update.
        /// </summary>
        [JsonProperty("id")]
        public string? ID
        {
            get => id;
            set => id = Set("id", value);
        }

        /// <summary>
        /// Any additional information about the person that might prove useful.
        /// </summary>
        [JsonProperty("information")]
        public string? Information
        {
            get => information;
            set => information = Set("information", value);
        }

        /// <summary>
        /// The person's job title.
        /// </summary>
        [JsonProperty("jobTitle")]
        public string? JobTitle
        {
            get => jobTitle;
            set => jobTitle = Set("jobTitle", value);
        }

        /// <summary>
        /// The language preference of the person.
        /// </summary>
        [JsonProperty("language")]
        public string? Language
        {
            get => language;
            set => language = Set("language", value);
        }

        /// <summary>
        /// The name or number of the room, cubicle or area where the person has his/her primary work space.
        /// </summary>
        [JsonProperty("location")]
        public string? Location
        {
            get => location;
            set => location = Set("location", value);
        }

        /// <summary>
        /// The manager or supervisor to whom the person reports.
        /// </summary>
        [JsonProperty("managerId")]
        public string? ManagerId
        {
            get => managerId;
            set => managerId = Set("managerId", value);
        }

        /// <summary>
        /// The name of the person.
        /// </summary>
        [JsonProperty("name")]
        public string? Name
        {
            get => name;
            set => name = Set("name", value);
        }

        /// <summary>
        /// Permissions for specific accounts of this person to add or update. Permissions for other accounts will not be altered.
        /// </summary>
        [JsonProperty("newAccountPermissions")]
        public List<PermissionInput>? NewAccountPermissions
        {
            get => newAccountPermissions;
            set => newAccountPermissions = Set("newAccountPermissions", value);
        }

        /// <summary>
        /// New or updated addresses of this person.
        /// </summary>
        [JsonProperty("newAddresses")]
        public List<AddressInput>? NewAddresses
        {
            get => newAddresses;
            set => newAddresses = Set("newAddresses", value);
        }

        /// <summary>
        /// New or updated contacts of this person.
        /// </summary>
        [JsonProperty("newContacts")]
        public List<ContactInput>? NewContacts
        {
            get => newContacts;
            set => newContacts = Set("newContacts", value);
        }

        /// <summary>
        /// An enabled OAuth person is mentionable and visible in suggest fields, just like a real person.
        /// </summary>
        [JsonProperty("oauthPersonEnablement")]
        public bool? OauthPersonEnablement
        {
            get => oauthPersonEnablement;
            set => oauthPersonEnablement = Set("oauthPersonEnablement", value);
        }

        /// <summary>
        /// The organization for which the person works as an employee or long-term contractor.
        /// </summary>
        [JsonProperty("organizationId")]
        public string? OrganizationId
        {
            get => organizationId;
            set => organizationId = Set("organizationId", value);
        }

        /// <summary>
        /// Permissions of this person. These will overwrite all existing permissions of this person.
        /// </summary>
        [JsonProperty("permissions")]
        public List<PermissionInput>? Permissions
        {
            get => permissions;
            set => permissions = Set("permissions", value);
        }

        /// <summary>
        /// The hyperlink to the image file for the record.
        /// </summary>
        [JsonProperty("pictureUri")]
        public string? PictureUri
        {
            get => pictureUri;
            set => pictureUri = Set("pictureUri", value);
        }

        /// <summary>
        /// The email address to which email notifications are to be sent. This email address acts as the unique identifier for the person within the 4me account. This primary email address also acts as the person's login name if he/she is a user of the 4me service.
        /// </summary>
        [JsonProperty("primaryEmail")]
        public string? PrimaryEmail
        {
            get => primaryEmail;
            set => primaryEmail = Set("primaryEmail", value);
        }

        /// <summary>
        /// Indicates when to send email notifications to the person.
        /// </summary>
        [JsonProperty("sendEmailNotifications")]
        public PersonSendEmailNotifications? SendEmailNotifications
        {
            get => sendEmailNotifications;
            set => sendEmailNotifications = Set("sendEmailNotifications", value);
        }

        /// <summary>
        /// Indicates when to show a notification popup to the person.
        /// </summary>
        [JsonProperty("showNotificationPopup")]
        public PersonShowNotificationPopup? ShowNotificationPopup
        {
            get => showNotificationPopup;
            set => showNotificationPopup = Set("showNotificationPopup", value);
        }

        /// <summary>
        /// Where the person is stationed.
        /// </summary>
        [JsonProperty("siteId")]
        public string? SiteId
        {
            get => siteId;
            set => siteId = Set("siteId", value);
        }

        /// <summary>
        /// Skill pools this person belongs to.
        /// </summary>
        [JsonProperty("skillPoolIds")]
        public List<string>? SkillPoolIds
        {
            get => skillPoolIds;
            set => skillPoolIds = Set("skillPoolIds", value);
        }

        /// <summary>
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [JsonProperty("source")]
        public string? Source
        {
            get => source;
            set => source = Set("source", value);
        }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [JsonProperty("sourceID")]
        public string? SourceID
        {
            get => sourceID;
            set => sourceID = Set("sourceID", value);
        }

        /// <summary>
        /// A number or code that a service desk analyst can ask the person for when the person contacts the service desk for support.
        /// </summary>
        [JsonProperty("supportID")]
        public string? SupportID
        {
            get => supportID;
            set => supportID = Set("supportID", value);
        }

        /// <summary>
        /// Teams this person belongs to.
        /// </summary>
        [JsonProperty("teamIds")]
        public List<string>? TeamIds
        {
            get => teamIds;
            set => teamIds = Set("teamIds", value);
        }

        /// <summary>
        /// Whether the person prefers to see times displayed within the 4me service in the 24-hour format or not (in which case the 12-hour format is applied).
        /// </summary>
        [JsonProperty("timeFormat24h")]
        public bool? TimeFormat24h
        {
            get => timeFormat24h;
            set => timeFormat24h = Set("timeFormat24h", value);
        }

        /// <summary>
        /// <br>The time zone in which the person normally resides.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/timezone/">4me developer site</see>.</br>
        /// </summary>
        [JsonProperty("timeZone")]
        public string? TimeZone
        {
            get => timeZone;
            set => timeZone = Set("timeZone", value);
        }

        /// <summary>
        /// UI extension that is to be applied to the record.
        /// </summary>
        [JsonProperty("uiExtensionId")]
        public string? UiExtensionId
        {
            get => uiExtensionId;
            set => uiExtensionId = Set("uiExtensionId", value);
        }

        /// <summary>
        /// Whether the person is a very important person.
        /// </summary>
        [JsonProperty("vip")]
        public bool? Vip
        {
            get => vip;
            set => vip = Set("vip", value);
        }

        /// <summary>
        /// Calendar that represents the work hours of the person.
        /// </summary>
        [JsonProperty("workHoursId")]
        public string? WorkHoursId
        {
            get => workHoursId;
            set => workHoursId = Set("workHoursId", value);
        }
    }
}
