namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="Account">Account</see> fields.
    /// </summary>
    public enum AccountField
    {
        /// <summary>
        /// The disabled field.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The name field.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// The organization field.
        /// </summary>
        [EnumMember(Value = "organization")]
        Organization,
    }

    /// <summary>
    /// The <see cref="ActivityID">ActivityID</see> fields.
    /// </summary>
    public enum ActivityIDField
    {
        /// <summary>
        /// The case field.
        /// </summary>
        [EnumMember(Value = "case")]
        Case,
        /// <summary>
        /// The high field.
        /// </summary>
        [EnumMember(Value = "high")]
        High,
        /// <summary>
        /// The low field.
        /// </summary>
        [EnumMember(Value = "low")]
        Low,
        /// <summary>
        /// The medium field.
        /// </summary>
        [EnumMember(Value = "medium")]
        Medium,
        /// <summary>
        /// The rfc field.
        /// </summary>
        [EnumMember(Value = "rfc")]
        Rfc,
        /// <summary>
        /// The rfi field.
        /// </summary>
        [EnumMember(Value = "rfi")]
        Rfi,
        /// <summary>
        /// The top field.
        /// </summary>
        [EnumMember(Value = "top")]
        Top,
    }

    /// <summary>
    /// The <see cref="Address">Address</see> fields.
    /// </summary>
    public enum AddressField
    {
        /// <summary>
        /// The city field.
        /// </summary>
        [EnumMember(Value = "city")]
        City,
        /// <summary>
        /// The country field.
        /// </summary>
        [EnumMember(Value = "country")]
        Country,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The integration field.
        /// </summary>
        [EnumMember(Value = "integration")]
        Integration,
        /// <summary>
        /// The label field.
        /// </summary>
        [EnumMember(Value = "label")]
        Label,
        /// <summary>
        /// The state field.
        /// </summary>
        [EnumMember(Value = "state")]
        State,
        /// <summary>
        /// The address field.
        /// </summary>
        [EnumMember(Value = "address")]
        Street,
        /// <summary>
        /// The zip field.
        /// </summary>
        [EnumMember(Value = "zip")]
        Zip,
    }

    /// <summary>
    /// The <see cref="AffectedSla">AffectedSla</see> fields.
    /// </summary>
    public enum AffectedSlaField
    {
        /// <summary>
        /// The accountability field.
        /// </summary>
        [EnumMember(Value = "accountability")]
        Accountability,
        /// <summary>
        /// The actual resolution at field.
        /// </summary>
        [EnumMember(Value = "actualResolutionAt")]
        ActualResolutionAt,
        /// <summary>
        /// The actual resolution duration field.
        /// </summary>
        [EnumMember(Value = "actualResolutionDuration")]
        ActualResolutionDuration,
        /// <summary>
        /// The actual response at field.
        /// </summary>
        [EnumMember(Value = "actualResponseAt")]
        ActualResponseAt,
        /// <summary>
        /// The actual response duration field.
        /// </summary>
        [EnumMember(Value = "actualResponseDuration")]
        ActualResponseDuration,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The desired completion at field.
        /// </summary>
        [EnumMember(Value = "desiredCompletionAt")]
        DesiredCompletionAt,
        /// <summary>
        /// The downtime duration field.
        /// </summary>
        [EnumMember(Value = "downtimeDuration")]
        DowntimeDuration,
        /// <summary>
        /// The downtime end at field.
        /// </summary>
        [EnumMember(Value = "downtimeEndAt")]
        DowntimeEndAt,
        /// <summary>
        /// The downtime start at field.
        /// </summary>
        [EnumMember(Value = "downtimeStartAt")]
        DowntimeStartAt,
        /// <summary>
        /// The first line team field.
        /// </summary>
        [EnumMember(Value = "firstLineTeam")]
        FirstLineTeam,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The impact field.
        /// </summary>
        [EnumMember(Value = "impact")]
        Impact,
        /// <summary>
        /// The maximum resolution duration field.
        /// </summary>
        [EnumMember(Value = "maximumResolutionDuration")]
        MaximumResolutionDuration,
        /// <summary>
        /// The maximum resolution duration in days field.
        /// </summary>
        [EnumMember(Value = "maximumResolutionDurationInDays")]
        MaximumResolutionDurationInDays,
        /// <summary>
        /// The maximum response duration field.
        /// </summary>
        [EnumMember(Value = "maximumResponseDuration")]
        MaximumResponseDuration,
        /// <summary>
        /// The maximum response duration in days field.
        /// </summary>
        [EnumMember(Value = "maximumResponseDurationInDays")]
        MaximumResponseDurationInDays,
        /// <summary>
        /// The next target at field.
        /// </summary>
        [EnumMember(Value = "nextTargetAt")]
        NextTargetAt,
        /// <summary>
        /// The provider not accountable field.
        /// </summary>
        [EnumMember(Value = "providerNotAccountable")]
        ProviderNotAccountable,
        /// <summary>
        /// The provider was not accountable field.
        /// </summary>
        [EnumMember(Value = "providerWasNotAccountable")]
        ProviderWasNotAccountable,
        /// <summary>
        /// The request field.
        /// </summary>
        [EnumMember(Value = "request")]
        Request,
        /// <summary>
        /// The resolution target at field.
        /// </summary>
        [EnumMember(Value = "resolutionTargetAt")]
        ResolutionTargetAt,
        /// <summary>
        /// The response target at field.
        /// </summary>
        [EnumMember(Value = "responseTargetAt")]
        ResponseTargetAt,
        /// <summary>
        /// The service hours field.
        /// </summary>
        [EnumMember(Value = "serviceHours")]
        ServiceHours,
        /// <summary>
        /// The service instance field.
        /// </summary>
        [EnumMember(Value = "serviceInstance")]
        ServiceInstance,
        /// <summary>
        /// The service level agreement field.
        /// </summary>
        [EnumMember(Value = "serviceLevelAgreement")]
        ServiceLevelAgreement,
        /// <summary>
        /// The standard service request field.
        /// </summary>
        [EnumMember(Value = "standardServiceRequest")]
        StandardServiceRequest,
        /// <summary>
        /// The started at field.
        /// </summary>
        [EnumMember(Value = "startedAt")]
        StartedAt,
        /// <summary>
        /// The stopped clock at field.
        /// </summary>
        [EnumMember(Value = "stoppedClockAt")]
        StoppedClockAt,
        /// <summary>
        /// The stopped clock duration field.
        /// </summary>
        [EnumMember(Value = "stoppedClockDuration")]
        StoppedClockDuration,
        /// <summary>
        /// The stopped clock periods field.
        /// </summary>
        [EnumMember(Value = "stoppedClockPeriods")]
        StoppedClockPeriods,
        /// <summary>
        /// The supplier field.
        /// </summary>
        [EnumMember(Value = "supplier")]
        Supplier,
        /// <summary>
        /// The support hours field.
        /// </summary>
        [EnumMember(Value = "supportHours")]
        SupportHours,
        /// <summary>
        /// The support team field.
        /// </summary>
        [EnumMember(Value = "supportTeam")]
        SupportTeam,
        /// <summary>
        /// The time zone field.
        /// </summary>
        [EnumMember(Value = "timeZone")]
        TimeZone,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The <see cref="AgileBoard">AgileBoard</see> fields.
    /// </summary>
    public enum AgileBoardField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The columns field.
        /// </summary>
        [EnumMember(Value = "columns")]
        Columns,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The current sprint field.
        /// </summary>
        [EnumMember(Value = "currentSprint")]
        CurrentSprint,
        /// <summary>
        /// The customer representative slas field.
        /// </summary>
        [EnumMember(Value = "customerRepresentativeSlas")]
        CustomerRepresentativeSlas,
        /// <summary>
        /// The description field.
        /// </summary>
        [EnumMember(Value = "description")]
        Description,
        /// <summary>
        /// The description attachments field.
        /// </summary>
        [EnumMember(Value = "descriptionAttachments")]
        DescriptionAttachments,
        /// <summary>
        /// The disabled field.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The manager field.
        /// </summary>
        [EnumMember(Value = "manager")]
        Manager,
        /// <summary>
        /// The name field.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// The picture uri field.
        /// </summary>
        [EnumMember(Value = "pictureUri")]
        PictureUri,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The <see cref="AgileBoardColumn">AgileBoardColumn</see> fields.
    /// </summary>
    public enum AgileBoardColumnField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The action type field.
        /// </summary>
        [EnumMember(Value = "actionType")]
        ActionType,
        /// <summary>
        /// The agile board field.
        /// </summary>
        [EnumMember(Value = "agileBoard")]
        AgileBoard,
        /// <summary>
        /// The clear member field.
        /// </summary>
        [EnumMember(Value = "clearMember")]
        ClearMember,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The dialog type field.
        /// </summary>
        [EnumMember(Value = "dialogType")]
        DialogType,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The items field.
        /// </summary>
        [EnumMember(Value = "items")]
        Items,
        /// <summary>
        /// The member field.
        /// </summary>
        [EnumMember(Value = "member")]
        Member,
        /// <summary>
        /// The name field.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// The position field.
        /// </summary>
        [EnumMember(Value = "position")]
        Position,
        /// <summary>
        /// The remove after field.
        /// </summary>
        [EnumMember(Value = "removeAfter")]
        RemoveAfter,
        /// <summary>
        /// The team field.
        /// </summary>
        [EnumMember(Value = "team")]
        Team,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// The wip limit field.
        /// </summary>
        [EnumMember(Value = "wipLimit")]
        WipLimit,
    }

    /// <summary>
    /// The <see cref="AgileBoardItem">AgileBoardItem</see> fields.
    /// </summary>
    public enum AgileBoardItemField
    {
        /// <summary>
        /// The agile board field.
        /// </summary>
        [EnumMember(Value = "agileBoard")]
        AgileBoard,
        /// <summary>
        /// The agile board column field.
        /// </summary>
        [EnumMember(Value = "agileBoardColumn")]
        AgileBoardColumn,
        /// <summary>
        /// The agile board column position field.
        /// </summary>
        [EnumMember(Value = "agileBoardColumnPosition")]
        AgileBoardColumnPosition,
    }

    /// <summary>
    /// The <see cref="AppInstance">AppInstance</see> fields.
    /// </summary>
    public enum AppInstanceField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The app offering field.
        /// </summary>
        [EnumMember(Value = "appOffering")]
        AppOffering,
        /// <summary>
        /// The automation rules field.
        /// </summary>
        [EnumMember(Value = "automationRules")]
        AutomationRules,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The customer account field.
        /// </summary>
        [EnumMember(Value = "customerAccount")]
        CustomerAccount,
        /// <summary>
        /// The customer representative field.
        /// </summary>
        [EnumMember(Value = "customerRepresentative")]
        CustomerRepresentative,
        /// <summary>
        /// The custom fields field.
        /// </summary>
        [EnumMember(Value = "customFields")]
        CustomFields,
        /// <summary>
        /// The custom fields attachments field.
        /// </summary>
        [EnumMember(Value = "customFieldsAttachments")]
        CustomFieldsAttachments,
        /// <summary>
        /// The disabled field.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// The enabled by customer field.
        /// </summary>
        [EnumMember(Value = "enabledByCustomer")]
        EnabledByCustomer,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The suspended field.
        /// </summary>
        [EnumMember(Value = "suspended")]
        Suspended,
        /// <summary>
        /// The suspension comment field.
        /// </summary>
        [EnumMember(Value = "suspensionComment")]
        SuspensionComment,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// The webhook field.
        /// </summary>
        [EnumMember(Value = "webhook")]
        Webhook,
        /// <summary>
        /// The webhook policy field.
        /// </summary>
        [EnumMember(Value = "webhookPolicy")]
        WebhookPolicy,
    }

    /// <summary>
    /// The <see cref="AppOffering">AppOffering</see> fields.
    /// </summary>
    public enum AppOfferingField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The app instances field.
        /// </summary>
        [EnumMember(Value = "appInstances")]
        AppInstances,
        /// <summary>
        /// The automation rules field.
        /// </summary>
        [EnumMember(Value = "automationRules")]
        AutomationRules,
        /// <summary>
        /// The card description field.
        /// </summary>
        [EnumMember(Value = "cardDescription")]
        CardDescription,
        /// <summary>
        /// The compliance field.
        /// </summary>
        [EnumMember(Value = "compliance")]
        Compliance,
        /// <summary>
        /// The compliance attachments field.
        /// </summary>
        [EnumMember(Value = "complianceAttachments")]
        ComplianceAttachments,
        /// <summary>
        /// The configuration uri template field.
        /// </summary>
        [EnumMember(Value = "configurationUriTemplate")]
        ConfigurationUriTemplate,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The description field.
        /// </summary>
        [EnumMember(Value = "description")]
        Description,
        /// <summary>
        /// The description attachments field.
        /// </summary>
        [EnumMember(Value = "descriptionAttachments")]
        DescriptionAttachments,
        /// <summary>
        /// The disabled field.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// The features field.
        /// </summary>
        [EnumMember(Value = "features")]
        Features,
        /// <summary>
        /// The features attachments field.
        /// </summary>
        [EnumMember(Value = "featuresAttachments")]
        FeaturesAttachments,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The latest field.
        /// </summary>
        [EnumMember(Value = "latest")]
        Latest,
        /// <summary>
        /// The name field.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// The picture uri field.
        /// </summary>
        [EnumMember(Value = "pictureUri")]
        PictureUri,
        /// <summary>
        /// The policy jwt alg field.
        /// </summary>
        [EnumMember(Value = "policyJwtAlg")]
        PolicyJwtAlg,
        /// <summary>
        /// The policy jwt audience field.
        /// </summary>
        [EnumMember(Value = "policyJwtAudience")]
        PolicyJwtAudience,
        /// <summary>
        /// The policy jwt claim expires in field.
        /// </summary>
        [EnumMember(Value = "policyJwtClaimExpiresIn")]
        PolicyJwtClaimExpiresIn,
        /// <summary>
        /// The published field.
        /// </summary>
        [EnumMember(Value = "published")]
        Published,
        /// <summary>
        /// The reference field.
        /// </summary>
        [EnumMember(Value = "reference")]
        Reference,
        /// <summary>
        /// The requires enabled oauth person field.
        /// </summary>
        [EnumMember(Value = "requiresEnabledOauthPerson")]
        RequiresEnabledOauthPerson,
        /// <summary>
        /// The scopes field.
        /// </summary>
        [EnumMember(Value = "scopes")]
        Scopes,
        /// <summary>
        /// The service instance field.
        /// </summary>
        [EnumMember(Value = "serviceInstance")]
        ServiceInstance,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The ui extension version field.
        /// </summary>
        [EnumMember(Value = "uiExtensionVersion")]
        UiExtensionVersion,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// The webhook uri template field.
        /// </summary>
        [EnumMember(Value = "webhookUriTemplate")]
        WebhookUriTemplate,
    }

    /// <summary>
    /// The <see cref="AppOfferingAutomationRule">AppOfferingAutomationRule</see> fields.
    /// </summary>
    public enum AppOfferingAutomationRuleField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The actions field.
        /// </summary>
        [EnumMember(Value = "actions")]
        Actions,
        /// <summary>
        /// The app offering field.
        /// </summary>
        [EnumMember(Value = "appOffering")]
        AppOffering,
        /// <summary>
        /// The condition field.
        /// </summary>
        [EnumMember(Value = "condition")]
        Condition,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The description field.
        /// </summary>
        [EnumMember(Value = "description")]
        Description,
        /// <summary>
        /// The expressions field.
        /// </summary>
        [EnumMember(Value = "expressions")]
        Expressions,
        /// <summary>
        /// The generic field.
        /// </summary>
        [EnumMember(Value = "generic")]
        Generic,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The name field.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// The position field.
        /// </summary>
        [EnumMember(Value = "position")]
        Position,
        /// <summary>
        /// The trigger field.
        /// </summary>
        [EnumMember(Value = "trigger")]
        Trigger,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The <see cref="AppOfferingScope">AppOfferingScope</see> fields.
    /// </summary>
    public enum AppOfferingScopeField
    {
        /// <summary>
        /// The actions field.
        /// </summary>
        [EnumMember(Value = "actions")]
        Actions,
        /// <summary>
        /// The conditions field.
        /// </summary>
        [EnumMember(Value = "conditions")]
        Conditions,
        /// <summary>
        /// The effect field.
        /// </summary>
        [EnumMember(Value = "effect")]
        Effect,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
    }

    /// <summary>
    /// The <see cref="Archive">Archive</see> fields.
    /// </summary>
    public enum ArchiveField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The archived field.
        /// </summary>
        [EnumMember(Value = "archived")]
        Archived,
        /// <summary>
        /// The archived by field.
        /// </summary>
        [EnumMember(Value = "archivedBy")]
        ArchivedBy,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
    }

    /// <summary>
    /// The <see cref="AsyncQuery">AsyncQuery</see> fields.
    /// </summary>
    public enum AsyncQueryField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The completed at field.
        /// </summary>
        [EnumMember(Value = "completedAt")]
        CompletedAt,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The error count field.
        /// </summary>
        [EnumMember(Value = "errorCount")]
        ErrorCount,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The person field.
        /// </summary>
        [EnumMember(Value = "person")]
        Person,
        /// <summary>
        /// The result count field.
        /// </summary>
        [EnumMember(Value = "resultCount")]
        ResultCount,
        /// <summary>
        /// The result url field.
        /// </summary>
        [EnumMember(Value = "resultUrl")]
        ResultUrl,
        /// <summary>
        /// The started at field.
        /// </summary>
        [EnumMember(Value = "startedAt")]
        StartedAt,
        /// <summary>
        /// The status field.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The <see cref="Attachment">Attachment</see> fields.
    /// </summary>
    public enum AttachmentField
    {
        /// <summary>
        /// The expiring url field.
        /// </summary>
        [EnumMember(Value = "expiringUrl")]
        ExpiringUrl,
        /// <summary>
        /// The filename field.
        /// </summary>
        [EnumMember(Value = "filename")]
        Filename,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The inline field.
        /// </summary>
        [EnumMember(Value = "inline")]
        Inline,
        /// <summary>
        /// The key field.
        /// </summary>
        [EnumMember(Value = "key")]
        Key,
        /// <summary>
        /// The size field.
        /// </summary>
        [EnumMember(Value = "size")]
        Size,
    }

    /// <summary>
    /// The <see cref="AttachmentStorage">AttachmentStorage</see> fields.
    /// </summary>
    public enum AttachmentStorageField
    {
        /// <summary>
        /// The allowed extensions field.
        /// </summary>
        [EnumMember(Value = "allowedExtensions")]
        AllowedExtensions,
        /// <summary>
        /// The provider field.
        /// </summary>
        [EnumMember(Value = "provider")]
        Provider,
        /// <summary>
        /// The provider parameters field.
        /// </summary>
        [EnumMember(Value = "providerParameters")]
        ProviderParameters,
        /// <summary>
        /// The size limit field.
        /// </summary>
        [EnumMember(Value = "sizeLimit")]
        SizeLimit,
        /// <summary>
        /// The upload uri field.
        /// </summary>
        [EnumMember(Value = "uploadUri")]
        UploadUri,
    }

    /// <summary>
    /// The <see cref="AutomationRule">AutomationRule</see> fields.
    /// </summary>
    public enum AutomationRuleField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The actions field.
        /// </summary>
        [EnumMember(Value = "actions")]
        Actions,
        /// <summary>
        /// The condition field.
        /// </summary>
        [EnumMember(Value = "condition")]
        Condition,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The description field.
        /// </summary>
        [EnumMember(Value = "description")]
        Description,
        /// <summary>
        /// The disabled field.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// The expressions field.
        /// </summary>
        [EnumMember(Value = "expressions")]
        Expressions,
        /// <summary>
        /// The generic field.
        /// </summary>
        [EnumMember(Value = "generic")]
        Generic,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The name field.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// The position field.
        /// </summary>
        [EnumMember(Value = "position")]
        Position,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The trigger field.
        /// </summary>
        [EnumMember(Value = "trigger")]
        Trigger,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The <see cref="AutomationRuleAction">AutomationRuleAction</see> fields.
    /// </summary>
    public enum AutomationRuleActionField
    {
        /// <summary>
        /// The name field.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// The value field.
        /// </summary>
        [EnumMember(Value = "value")]
        Value,
    }

    /// <summary>
    /// The <see cref="AutomationRuleExpression">AutomationRuleExpression</see> fields.
    /// </summary>
    public enum AutomationRuleExpressionField
    {
        /// <summary>
        /// The name field.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// The value field.
        /// </summary>
        [EnumMember(Value = "value")]
        Value,
    }

    /// <summary>
    /// The <see cref="Broadcast">Broadcast</see> fields.
    /// </summary>
    public enum BroadcastField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The body field.
        /// </summary>
        [EnumMember(Value = "body")]
        Body,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The customers field.
        /// </summary>
        [EnumMember(Value = "customers")]
        Customers,
        /// <summary>
        /// The disabled field.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// The email template field.
        /// </summary>
        [EnumMember(Value = "emailTemplate")]
        EmailTemplate,
        /// <summary>
        /// The end at field.
        /// </summary>
        [EnumMember(Value = "endAt")]
        EndAt,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The message type field.
        /// </summary>
        [EnumMember(Value = "messageType")]
        MessageType,
        /// <summary>
        /// The remarks field.
        /// </summary>
        [EnumMember(Value = "remarks")]
        Remarks,
        /// <summary>
        /// The remarks attachments field.
        /// </summary>
        [EnumMember(Value = "remarksAttachments")]
        RemarksAttachments,
        /// <summary>
        /// The request field.
        /// </summary>
        [EnumMember(Value = "request")]
        Request,
        /// <summary>
        /// The service instances field.
        /// </summary>
        [EnumMember(Value = "serviceInstances")]
        ServiceInstances,
        /// <summary>
        /// The slas field.
        /// </summary>
        [EnumMember(Value = "slas")]
        Slas,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The start at field.
        /// </summary>
        [EnumMember(Value = "startAt")]
        StartAt,
        /// <summary>
        /// The subject field.
        /// </summary>
        [EnumMember(Value = "subject")]
        Subject,
        /// <summary>
        /// The teams field.
        /// </summary>
        [EnumMember(Value = "teams")]
        Teams,
        /// <summary>
        /// The time zone field.
        /// </summary>
        [EnumMember(Value = "timeZone")]
        TimeZone,
        /// <summary>
        /// The translations field.
        /// </summary>
        [EnumMember(Value = "translations")]
        Translations,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// The visibility field.
        /// </summary>
        [EnumMember(Value = "visibility")]
        Visibility,
    }

    /// <summary>
    /// The <see cref="BroadcastTranslation">BroadcastTranslation</see> fields.
    /// </summary>
    public enum BroadcastTranslationField
    {
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The language field.
        /// </summary>
        [EnumMember(Value = "language")]
        Language,
        /// <summary>
        /// The message field.
        /// </summary>
        [EnumMember(Value = "message")]
        Message,
        /// <summary>
        /// The message attachments field.
        /// </summary>
        [EnumMember(Value = "messageAttachments")]
        MessageAttachments,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The <see cref="Calendar">Calendar</see> fields.
    /// </summary>
    public enum CalendarField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The calendar hours field.
        /// </summary>
        [EnumMember(Value = "calendarHours")]
        CalendarHours,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The disabled field.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// The holidays field.
        /// </summary>
        [EnumMember(Value = "holidays")]
        Holidays,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The name field.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The <see cref="CalendarHour">CalendarHour</see> fields.
    /// </summary>
    public enum CalendarHourField
    {
        /// <summary>
        /// The time from field.
        /// </summary>
        [EnumMember(Value = "timeFrom")]
        TimeFrom,
        /// <summary>
        /// The time until field.
        /// </summary>
        [EnumMember(Value = "timeUntil")]
        TimeUntil,
        /// <summary>
        /// The weekday field.
        /// </summary>
        [EnumMember(Value = "weekday")]
        Weekday,
    }

    /// <summary>
    /// The <see cref="ConfigurationItem">ConfigurationItem</see> fields.
    /// </summary>
    public enum ConfigurationItemField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The alternate names field.
        /// </summary>
        [EnumMember(Value = "alternateNames")]
        AlternateNames,
        /// <summary>
        /// The asset id field.
        /// </summary>
        [EnumMember(Value = "assetID")]
        AssetID,
        /// <summary>
        /// The ci relations field.
        /// </summary>
        [EnumMember(Value = "ciRelations")]
        CiRelations,
        /// <summary>
        /// The contracts field.
        /// </summary>
        [EnumMember(Value = "contracts")]
        Contracts,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The custom fields field.
        /// </summary>
        [EnumMember(Value = "customFields")]
        CustomFields,
        /// <summary>
        /// The custom fields attachments field.
        /// </summary>
        [EnumMember(Value = "customFieldsAttachments")]
        CustomFieldsAttachments,
        /// <summary>
        /// The end of support date field.
        /// </summary>
        [EnumMember(Value = "endOfSupportDate")]
        EndOfSupportDate,
        /// <summary>
        /// The financial owner field.
        /// </summary>
        [EnumMember(Value = "financialOwner")]
        FinancialOwner,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The in use since field.
        /// </summary>
        [EnumMember(Value = "inUseSince")]
        InUseSince,
        /// <summary>
        /// The invoices field.
        /// </summary>
        [EnumMember(Value = "invoices")]
        Invoices,
        /// <summary>
        /// The label field.
        /// </summary>
        [EnumMember(Value = "label")]
        Label,
        /// <summary>
        /// The last seen at field.
        /// </summary>
        [EnumMember(Value = "lastSeenAt")]
        LastSeenAt,
        /// <summary>
        /// The licensed sites field.
        /// </summary>
        [EnumMember(Value = "licensedSites")]
        LicensedSites,
        /// <summary>
        /// The license expiry date field.
        /// </summary>
        [EnumMember(Value = "licenseExpiryDate")]
        LicenseExpiryDate,
        /// <summary>
        /// The license type field.
        /// </summary>
        [EnumMember(Value = "licenseType")]
        LicenseType,
        /// <summary>
        /// The location field.
        /// </summary>
        [EnumMember(Value = "location")]
        Location,
        /// <summary>
        /// The name field.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// The nr of cores field.
        /// </summary>
        [EnumMember(Value = "nrOfCores")]
        NrOfCores,
        /// <summary>
        /// The nr of licenses field.
        /// </summary>
        [EnumMember(Value = "nrOfLicenses")]
        NrOfLicenses,
        /// <summary>
        /// The nr of processors field.
        /// </summary>
        [EnumMember(Value = "nrOfProcessors")]
        NrOfProcessors,
        /// <summary>
        /// The operating system field.
        /// </summary>
        [EnumMember(Value = "operatingSystem")]
        OperatingSystem,
        /// <summary>
        /// The picture uri field.
        /// </summary>
        [EnumMember(Value = "pictureUri")]
        PictureUri,
        /// <summary>
        /// The problems field.
        /// </summary>
        [EnumMember(Value = "problems")]
        Problems,
        /// <summary>
        /// The product field.
        /// </summary>
        [EnumMember(Value = "product")]
        Product,
        /// <summary>
        /// The ram amount field.
        /// </summary>
        [EnumMember(Value = "ramAmount")]
        RamAmount,
        /// <summary>
        /// The recurrence field.
        /// </summary>
        [EnumMember(Value = "recurrence")]
        Recurrence,
        /// <summary>
        /// The remarks field.
        /// </summary>
        [EnumMember(Value = "remarks")]
        Remarks,
        /// <summary>
        /// The remarks attachments field.
        /// </summary>
        [EnumMember(Value = "remarksAttachments")]
        RemarksAttachments,
        /// <summary>
        /// The requests field.
        /// </summary>
        [EnumMember(Value = "requests")]
        Requests,
        /// <summary>
        /// The rule set field.
        /// </summary>
        [EnumMember(Value = "ruleSet")]
        RuleSet,
        /// <summary>
        /// The serial nr field.
        /// </summary>
        [EnumMember(Value = "serialNr")]
        SerialNr,
        /// <summary>
        /// The service field.
        /// </summary>
        [EnumMember(Value = "service")]
        Service,
        /// <summary>
        /// The service instances field.
        /// </summary>
        [EnumMember(Value = "serviceInstances")]
        ServiceInstances,
        /// <summary>
        /// The site field.
        /// </summary>
        [EnumMember(Value = "site")]
        Site,
        /// <summary>
        /// The site license field.
        /// </summary>
        [EnumMember(Value = "siteLicense")]
        SiteLicense,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The status field.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,
        /// <summary>
        /// The supplier field.
        /// </summary>
        [EnumMember(Value = "supplier")]
        Supplier,
        /// <summary>
        /// The support account field.
        /// </summary>
        [EnumMember(Value = "supportAccount")]
        SupportAccount,
        /// <summary>
        /// The support team field.
        /// </summary>
        [EnumMember(Value = "supportTeam")]
        SupportTeam,
        /// <summary>
        /// The system id field.
        /// </summary>
        [EnumMember(Value = "systemID")]
        SystemID,
        /// <summary>
        /// The temporary license field.
        /// </summary>
        [EnumMember(Value = "temporaryLicense")]
        TemporaryLicense,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// The users field.
        /// </summary>
        [EnumMember(Value = "users")]
        Users,
        /// <summary>
        /// The warranty expiry date field.
        /// </summary>
        [EnumMember(Value = "warrantyExpiryDate")]
        WarrantyExpiryDate,
        /// <summary>
        /// The workflow manager field.
        /// </summary>
        [EnumMember(Value = "workflowManager")]
        WorkflowManager,
        /// <summary>
        /// The workflow template field.
        /// </summary>
        [EnumMember(Value = "workflowTemplate")]
        WorkflowTemplate,
    }

    /// <summary>
    /// The <see cref="ConfigurationItemRelation">ConfigurationItemRelation</see> fields.
    /// </summary>
    public enum ConfigurationItemRelationField
    {
        /// <summary>
        /// The configuration item field.
        /// </summary>
        [EnumMember(Value = "configurationItem")]
        ConfigurationItem,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The relation type field.
        /// </summary>
        [EnumMember(Value = "relationType")]
        RelationType,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
    }

    /// <summary>
    /// The <see cref="Contact">Contact</see> fields.
    /// </summary>
    public enum ContactField
    {
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The integration field.
        /// </summary>
        [EnumMember(Value = "integration")]
        Integration,
        /// <summary>
        /// The label field.
        /// </summary>
        [EnumMember(Value = "label")]
        Label,
        /// <summary>
        /// The protocol field.
        /// </summary>
        [EnumMember(Value = "protocol")]
        Protocol,
        /// <summary>
        /// The uri field.
        /// </summary>
        [EnumMember(Value = "uri")]
        Uri,
    }

    /// <summary>
    /// The <see cref="Contract">Contract</see> fields.
    /// </summary>
    public enum ContractField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The category field.
        /// </summary>
        [EnumMember(Value = "category")]
        Category,
        /// <summary>
        /// The configuration items field.
        /// </summary>
        [EnumMember(Value = "configurationItems")]
        ConfigurationItems,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The customer field.
        /// </summary>
        [EnumMember(Value = "customer")]
        Customer,
        /// <summary>
        /// The customer account field.
        /// </summary>
        [EnumMember(Value = "customerAccount")]
        CustomerAccount,
        /// <summary>
        /// The customer representative field.
        /// </summary>
        [EnumMember(Value = "customerRepresentative")]
        CustomerRepresentative,
        /// <summary>
        /// The custom fields field.
        /// </summary>
        [EnumMember(Value = "customFields")]
        CustomFields,
        /// <summary>
        /// The custom fields attachments field.
        /// </summary>
        [EnumMember(Value = "customFieldsAttachments")]
        CustomFieldsAttachments,
        /// <summary>
        /// The expiry date field.
        /// </summary>
        [EnumMember(Value = "expiryDate")]
        ExpiryDate,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The invoices field.
        /// </summary>
        [EnumMember(Value = "invoices")]
        Invoices,
        /// <summary>
        /// The name field.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// The notice date field.
        /// </summary>
        [EnumMember(Value = "noticeDate")]
        NoticeDate,
        /// <summary>
        /// The remarks field.
        /// </summary>
        [EnumMember(Value = "remarks")]
        Remarks,
        /// <summary>
        /// The remarks attachments field.
        /// </summary>
        [EnumMember(Value = "remarksAttachments")]
        RemarksAttachments,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The start date field.
        /// </summary>
        [EnumMember(Value = "startDate")]
        StartDate,
        /// <summary>
        /// The status field.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,
        /// <summary>
        /// The supplier field.
        /// </summary>
        [EnumMember(Value = "supplier")]
        Supplier,
        /// <summary>
        /// The supplier contact field.
        /// </summary>
        [EnumMember(Value = "supplierContact")]
        SupplierContact,
        /// <summary>
        /// The time zone field.
        /// </summary>
        [EnumMember(Value = "timeZone")]
        TimeZone,
        /// <summary>
        /// The ui extension field.
        /// </summary>
        [EnumMember(Value = "uiExtension")]
        UiExtension,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The <see cref="CustomCollection">CustomCollection</see> fields.
    /// </summary>
    public enum CustomCollectionField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The collection elements field.
        /// </summary>
        [EnumMember(Value = "collectionElements")]
        CollectionElements,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The description field.
        /// </summary>
        [EnumMember(Value = "description")]
        Description,
        /// <summary>
        /// The description attachments field.
        /// </summary>
        [EnumMember(Value = "descriptionAttachments")]
        DescriptionAttachments,
        /// <summary>
        /// The disabled field.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The name field.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// The picture uri field.
        /// </summary>
        [EnumMember(Value = "pictureUri")]
        PictureUri,
        /// <summary>
        /// The reference field.
        /// </summary>
        [EnumMember(Value = "reference")]
        Reference,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The ui extension field.
        /// </summary>
        [EnumMember(Value = "uiExtension")]
        UiExtension,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The <see cref="CustomCollectionElement">CustomCollectionElement</see> fields.
    /// </summary>
    public enum CustomCollectionElementField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The custom collection field.
        /// </summary>
        [EnumMember(Value = "customCollection")]
        CustomCollection,
        /// <summary>
        /// The custom fields field.
        /// </summary>
        [EnumMember(Value = "customFields")]
        CustomFields,
        /// <summary>
        /// The custom fields attachments field.
        /// </summary>
        [EnumMember(Value = "customFieldsAttachments")]
        CustomFieldsAttachments,
        /// <summary>
        /// The description field.
        /// </summary>
        [EnumMember(Value = "description")]
        Description,
        /// <summary>
        /// The disabled field.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The information field.
        /// </summary>
        [EnumMember(Value = "information")]
        Information,
        /// <summary>
        /// The information attachments field.
        /// </summary>
        [EnumMember(Value = "informationAttachments")]
        InformationAttachments,
        /// <summary>
        /// The name field.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// The picture uri field.
        /// </summary>
        [EnumMember(Value = "pictureUri")]
        PictureUri,
        /// <summary>
        /// The reference field.
        /// </summary>
        [EnumMember(Value = "reference")]
        Reference,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The translations field.
        /// </summary>
        [EnumMember(Value = "translations")]
        Translations,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The <see cref="CustomField">CustomField</see> fields.
    /// </summary>
    public enum CustomFieldField
    {
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The value field.
        /// </summary>
        [EnumMember(Value = "value")]
        Value,
    }

    /// <summary>
    /// The <see cref="EffortClass">EffortClass</see> fields.
    /// </summary>
    public enum EffortClassField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The cost multiplier field.
        /// </summary>
        [EnumMember(Value = "costMultiplier")]
        CostMultiplier,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The disabled field.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The name field.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// The position field.
        /// </summary>
        [EnumMember(Value = "position")]
        Position,
        /// <summary>
        /// The service offerings field.
        /// </summary>
        [EnumMember(Value = "serviceOfferings")]
        ServiceOfferings,
        /// <summary>
        /// The skill pools field.
        /// </summary>
        [EnumMember(Value = "skillPools")]
        SkillPools,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The timesheet settings field.
        /// </summary>
        [EnumMember(Value = "timesheetSettings")]
        TimesheetSettings,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The <see cref="EffortClassRate">EffortClassRate</see> fields.
    /// </summary>
    public enum EffortClassRateField
    {
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The effort class field.
        /// </summary>
        [EnumMember(Value = "effortClass")]
        EffortClass,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The rate field.
        /// </summary>
        [EnumMember(Value = "rate")]
        Rate,
        /// <summary>
        /// The rate currency field.
        /// </summary>
        [EnumMember(Value = "rateCurrency")]
        RateCurrency,
        /// <summary>
        /// The service offering field.
        /// </summary>
        [EnumMember(Value = "serviceOffering")]
        ServiceOffering,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The <see cref="EffortClassRateID">EffortClassRateID</see> fields.
    /// </summary>
    public enum EffortClassRateIDField
    {
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The effort class field.
        /// </summary>
        [EnumMember(Value = "effortClass")]
        EffortClass,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The rate id field.
        /// </summary>
        [EnumMember(Value = "rateID")]
        RateID,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The <see cref="EmailTemplate">EmailTemplate</see> fields.
    /// </summary>
    public enum EmailTemplateField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The body field.
        /// </summary>
        [EnumMember(Value = "body")]
        Body,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The default template field.
        /// </summary>
        [EnumMember(Value = "defaultTemplate")]
        DefaultTemplate,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The name field.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// The subject field.
        /// </summary>
        [EnumMember(Value = "subject")]
        Subject,
        /// <summary>
        /// The translations field.
        /// </summary>
        [EnumMember(Value = "translations")]
        Translations,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The <see cref="Feedback">Feedback</see> fields.
    /// </summary>
    public enum FeedbackField
    {
        /// <summary>
        /// The requested by field.
        /// </summary>
        [EnumMember(Value = "requestedBy")]
        RequestedBy,
        /// <summary>
        /// The requested for field.
        /// </summary>
        [EnumMember(Value = "requestedFor")]
        RequestedFor,
    }

    /// <summary>
    /// The <see cref="FeedbackUrls">FeedbackUrls</see> fields.
    /// </summary>
    public enum FeedbackUrlsField
    {
        /// <summary>
        /// The dissatisfied url field.
        /// </summary>
        [EnumMember(Value = "dissatisfiedUrl")]
        DissatisfiedUrl,
        /// <summary>
        /// The satisfied url field.
        /// </summary>
        [EnumMember(Value = "satisfiedUrl")]
        SatisfiedUrl,
    }

    /// <summary>
    /// The <see cref="FirstLineSupportAgreement">FirstLineSupportAgreement</see> fields.
    /// </summary>
    public enum FirstLineSupportAgreementField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The charges field.
        /// </summary>
        [EnumMember(Value = "charges")]
        Charges,
        /// <summary>
        /// The charges attachments field.
        /// </summary>
        [EnumMember(Value = "chargesAttachments")]
        ChargesAttachments,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The customer field.
        /// </summary>
        [EnumMember(Value = "customer")]
        Customer,
        /// <summary>
        /// The customer account field.
        /// </summary>
        [EnumMember(Value = "customerAccount")]
        CustomerAccount,
        /// <summary>
        /// The customer representative field.
        /// </summary>
        [EnumMember(Value = "customerRepresentative")]
        CustomerRepresentative,
        /// <summary>
        /// The expiry date field.
        /// </summary>
        [EnumMember(Value = "expiryDate")]
        ExpiryDate,
        /// <summary>
        /// The first call resolutions field.
        /// </summary>
        [EnumMember(Value = "firstCallResolutions")]
        FirstCallResolutions,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The invoices field.
        /// </summary>
        [EnumMember(Value = "invoices")]
        Invoices,
        /// <summary>
        /// The name field.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// The notice date field.
        /// </summary>
        [EnumMember(Value = "noticeDate")]
        NoticeDate,
        /// <summary>
        /// The pickups within target field.
        /// </summary>
        [EnumMember(Value = "pickupsWithinTarget")]
        PickupsWithinTarget,
        /// <summary>
        /// The pickup target field.
        /// </summary>
        [EnumMember(Value = "pickupTarget")]
        PickupTarget,
        /// <summary>
        /// The provider field.
        /// </summary>
        [EnumMember(Value = "provider")]
        Provider,
        /// <summary>
        /// The rejected solutions field.
        /// </summary>
        [EnumMember(Value = "rejectedSolutions")]
        RejectedSolutions,
        /// <summary>
        /// The remarks field.
        /// </summary>
        [EnumMember(Value = "remarks")]
        Remarks,
        /// <summary>
        /// The remarks attachments field.
        /// </summary>
        [EnumMember(Value = "remarksAttachments")]
        RemarksAttachments,
        /// <summary>
        /// The service desk only resolutions field.
        /// </summary>
        [EnumMember(Value = "serviceDeskOnlyResolutions")]
        ServiceDeskOnlyResolutions,
        /// <summary>
        /// The service desk resolutions field.
        /// </summary>
        [EnumMember(Value = "serviceDeskResolutions")]
        ServiceDeskResolutions,
        /// <summary>
        /// The service desk team field.
        /// </summary>
        [EnumMember(Value = "serviceDeskTeam")]
        ServiceDeskTeam,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The start date field.
        /// </summary>
        [EnumMember(Value = "startDate")]
        StartDate,
        /// <summary>
        /// The status field.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,
        /// <summary>
        /// The support chat pickup target field.
        /// </summary>
        [EnumMember(Value = "supportChatPickupTarget")]
        SupportChatPickupTarget,
        /// <summary>
        /// The support hours field.
        /// </summary>
        [EnumMember(Value = "supportHours")]
        SupportHours,
        /// <summary>
        /// The target details field.
        /// </summary>
        [EnumMember(Value = "targetDetails")]
        TargetDetails,
        /// <summary>
        /// The target details attachments field.
        /// </summary>
        [EnumMember(Value = "targetDetailsAttachments")]
        TargetDetailsAttachments,
        /// <summary>
        /// The time zone field.
        /// </summary>
        [EnumMember(Value = "timeZone")]
        TimeZone,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The <see cref="HasAutomationRules">HasAutomationRules</see> fields.
    /// </summary>
    public enum HasAutomationRulesField
    {
        /// <summary>
        /// The automation rules field.
        /// </summary>
        [EnumMember(Value = "automationRules")]
        AutomationRules,
    }

    /// <summary>
    /// The <see cref="HasLifeCycleState">HasLifeCycleState</see> fields.
    /// </summary>
    public enum HasLifeCycleStateField
    {
        /// <summary>
        /// The life cycle state field.
        /// </summary>
        [EnumMember(Value = "lifeCycleState")]
        LifeCycleState,
    }

    /// <summary>
    /// The <see cref="HasSprintBacklogItems">HasSprintBacklogItems</see> fields.
    /// </summary>
    public enum HasSprintBacklogItemsField
    {
        /// <summary>
        /// The sprint backlog items field.
        /// </summary>
        [EnumMember(Value = "sprintBacklogItems")]
        SprintBacklogItems,
    }

    /// <summary>
    /// The <see cref="HasTimeEntries">HasTimeEntries</see> fields.
    /// </summary>
    public enum HasTimeEntriesField
    {
        /// <summary>
        /// The time entries field.
        /// </summary>
        [EnumMember(Value = "timeEntries")]
        TimeEntries,
    }

    /// <summary>
    /// The <see cref="HasTranslations">HasTranslations</see> fields.
    /// </summary>
    public enum HasTranslationsField
    {
        /// <summary>
        /// The translations field.
        /// </summary>
        [EnumMember(Value = "translations")]
        Translations,
    }

    /// <summary>
    /// The <see cref="Holiday">Holiday</see> fields.
    /// </summary>
    public enum HolidayField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The calendars field.
        /// </summary>
        [EnumMember(Value = "calendars")]
        Calendars,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The end at field.
        /// </summary>
        [EnumMember(Value = "endAt")]
        EndAt,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The name field.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// The picture uri field.
        /// </summary>
        [EnumMember(Value = "pictureUri")]
        PictureUri,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The start at field.
        /// </summary>
        [EnumMember(Value = "startAt")]
        StartAt,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The <see cref="Invoice">Invoice</see> fields.
    /// </summary>
    public enum InvoiceField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The amortization end field.
        /// </summary>
        [EnumMember(Value = "amortizationEnd")]
        AmortizationEnd,
        /// <summary>
        /// The amortization start field.
        /// </summary>
        [EnumMember(Value = "amortizationStart")]
        AmortizationStart,
        /// <summary>
        /// The amortize field.
        /// </summary>
        [EnumMember(Value = "amortize")]
        Amortize,
        /// <summary>
        /// The amount field.
        /// </summary>
        [EnumMember(Value = "amount")]
        Amount,
        /// <summary>
        /// The configuration items field.
        /// </summary>
        [EnumMember(Value = "configurationItems")]
        ConfigurationItems,
        /// <summary>
        /// The contract field.
        /// </summary>
        [EnumMember(Value = "contract")]
        Contract,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The currency field.
        /// </summary>
        [EnumMember(Value = "currency")]
        Currency,
        /// <summary>
        /// The depreciation method field.
        /// </summary>
        [EnumMember(Value = "depreciationMethod")]
        DepreciationMethod,
        /// <summary>
        /// The depreciation start field.
        /// </summary>
        [EnumMember(Value = "depreciationStart")]
        DepreciationStart,
        /// <summary>
        /// The description field.
        /// </summary>
        [EnumMember(Value = "description")]
        Description,
        /// <summary>
        /// The financial id field.
        /// </summary>
        [EnumMember(Value = "financialID")]
        FinancialID,
        /// <summary>
        /// The flsa field.
        /// </summary>
        [EnumMember(Value = "flsa")]
        Flsa,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The invoice date field.
        /// </summary>
        [EnumMember(Value = "invoiceDate")]
        InvoiceDate,
        /// <summary>
        /// The invoice nr field.
        /// </summary>
        [EnumMember(Value = "invoiceNr")]
        InvoiceNr,
        /// <summary>
        /// The po nr field.
        /// </summary>
        [EnumMember(Value = "poNr")]
        PoNr,
        /// <summary>
        /// The project field.
        /// </summary>
        [EnumMember(Value = "project")]
        Project,
        /// <summary>
        /// The quantity field.
        /// </summary>
        [EnumMember(Value = "quantity")]
        Quantity,
        /// <summary>
        /// The rate field.
        /// </summary>
        [EnumMember(Value = "rate")]
        Rate,
        /// <summary>
        /// The remarks field.
        /// </summary>
        [EnumMember(Value = "remarks")]
        Remarks,
        /// <summary>
        /// The remarks attachments field.
        /// </summary>
        [EnumMember(Value = "remarksAttachments")]
        RemarksAttachments,
        /// <summary>
        /// The salvage value field.
        /// </summary>
        [EnumMember(Value = "salvageValue")]
        SalvageValue,
        /// <summary>
        /// The salvage value currency field.
        /// </summary>
        [EnumMember(Value = "salvageValueCurrency")]
        SalvageValueCurrency,
        /// <summary>
        /// The service field.
        /// </summary>
        [EnumMember(Value = "service")]
        Service,
        /// <summary>
        /// The sla field.
        /// </summary>
        [EnumMember(Value = "sla")]
        Sla,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The supplier field.
        /// </summary>
        [EnumMember(Value = "supplier")]
        Supplier,
        /// <summary>
        /// The unit price field.
        /// </summary>
        [EnumMember(Value = "unitPrice")]
        UnitPrice,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// The useful life field.
        /// </summary>
        [EnumMember(Value = "usefulLife")]
        UsefulLife,
        /// <summary>
        /// The workflow field.
        /// </summary>
        [EnumMember(Value = "workflow")]
        Workflow,
    }

    /// <summary>
    /// The <see cref="KnowledgeArticle">KnowledgeArticle</see> fields.
    /// </summary>
    public enum KnowledgeArticleField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The archive date field.
        /// </summary>
        [EnumMember(Value = "archiveDate")]
        ArchiveDate,
        /// <summary>
        /// The covered specialists field.
        /// </summary>
        [EnumMember(Value = "coveredSpecialists")]
        CoveredSpecialists,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The created by field.
        /// </summary>
        [EnumMember(Value = "createdBy")]
        CreatedBy,
        /// <summary>
        /// The custom fields field.
        /// </summary>
        [EnumMember(Value = "customFields")]
        CustomFields,
        /// <summary>
        /// The custom fields attachments field.
        /// </summary>
        [EnumMember(Value = "customFieldsAttachments")]
        CustomFieldsAttachments,
        /// <summary>
        /// The description field.
        /// </summary>
        [EnumMember(Value = "description")]
        Description,
        /// <summary>
        /// The description attachments field.
        /// </summary>
        [EnumMember(Value = "descriptionAttachments")]
        DescriptionAttachments,
        /// <summary>
        /// The end users field.
        /// </summary>
        [EnumMember(Value = "endUsers")]
        EndUsers,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The instructions field.
        /// </summary>
        [EnumMember(Value = "instructions")]
        Instructions,
        /// <summary>
        /// The instructions attachments field.
        /// </summary>
        [EnumMember(Value = "instructionsAttachments")]
        InstructionsAttachments,
        /// <summary>
        /// The internal specialists field.
        /// </summary>
        [EnumMember(Value = "internalSpecialists")]
        InternalSpecialists,
        /// <summary>
        /// The key contacts field.
        /// </summary>
        [EnumMember(Value = "keyContacts")]
        KeyContacts,
        /// <summary>
        /// The keywords field.
        /// </summary>
        [EnumMember(Value = "keywords")]
        Keywords,
        /// <summary>
        /// The public field.
        /// </summary>
        [EnumMember(Value = "public")]
        Public,
        /// <summary>
        /// The requests field.
        /// </summary>
        [EnumMember(Value = "requests")]
        Requests,
        /// <summary>
        /// The service field.
        /// </summary>
        [EnumMember(Value = "service")]
        Service,
        /// <summary>
        /// The service instances field.
        /// </summary>
        [EnumMember(Value = "serviceInstances")]
        ServiceInstances,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The status field.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,
        /// <summary>
        /// The subject field.
        /// </summary>
        [EnumMember(Value = "subject")]
        Subject,
        /// <summary>
        /// The template field.
        /// </summary>
        [EnumMember(Value = "template")]
        Template,
        /// <summary>
        /// The translations field.
        /// </summary>
        [EnumMember(Value = "translations")]
        Translations,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// The updated by field.
        /// </summary>
        [EnumMember(Value = "updatedBy")]
        UpdatedBy,
    }

    /// <summary>
    /// The <see cref="KnowledgeArticleTemplate">KnowledgeArticleTemplate</see> fields.
    /// </summary>
    public enum KnowledgeArticleTemplateField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The disabled field.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The service field.
        /// </summary>
        [EnumMember(Value = "service")]
        Service,
        /// <summary>
        /// The service instances field.
        /// </summary>
        [EnumMember(Value = "serviceInstances")]
        ServiceInstances,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The subject field.
        /// </summary>
        [EnumMember(Value = "subject")]
        Subject,
        /// <summary>
        /// The ui extension field.
        /// </summary>
        [EnumMember(Value = "uiExtension")]
        UiExtension,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The <see cref="Note">Note</see> fields.
    /// </summary>
    public enum NoteField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The internal field.
        /// </summary>
        [EnumMember(Value = "internal")]
        Internal,
        /// <summary>
        /// The medium field.
        /// </summary>
        [EnumMember(Value = "medium")]
        Medium,
        /// <summary>
        /// The note reactions field.
        /// </summary>
        [EnumMember(Value = "noteReactions")]
        NoteReactions,
        /// <summary>
        /// The person field.
        /// </summary>
        [EnumMember(Value = "person")]
        Person,
        /// <summary>
        /// The text field.
        /// </summary>
        [EnumMember(Value = "text")]
        Text,
        /// <summary>
        /// The text attachments field.
        /// </summary>
        [EnumMember(Value = "textAttachments")]
        TextAttachments,
        /// <summary>
        /// The visibility field.
        /// </summary>
        [EnumMember(Value = "visibility")]
        Visibility,
    }

    /// <summary>
    /// The <see cref="NoteReaction">NoteReaction</see> fields.
    /// </summary>
    public enum NoteReactionField
    {
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The note field.
        /// </summary>
        [EnumMember(Value = "note")]
        Note,
        /// <summary>
        /// The person field.
        /// </summary>
        [EnumMember(Value = "person")]
        Person,
        /// <summary>
        /// The reaction field.
        /// </summary>
        [EnumMember(Value = "reaction")]
        Reaction,
    }

    /// <summary>
    /// The <see cref="Organization">Organization</see> fields.
    /// </summary>
    public enum OrganizationField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The addresses field.
        /// </summary>
        [EnumMember(Value = "addresses")]
        Addresses,
        /// <summary>
        /// The business unit field.
        /// </summary>
        [EnumMember(Value = "businessUnit")]
        BusinessUnit,
        /// <summary>
        /// The business unit organization field.
        /// </summary>
        [EnumMember(Value = "businessUnitOrganization")]
        BusinessUnitOrganization,
        /// <summary>
        /// The child organizations field.
        /// </summary>
        [EnumMember(Value = "childOrganizations")]
        ChildOrganizations,
        /// <summary>
        /// The contacts field.
        /// </summary>
        [EnumMember(Value = "contacts")]
        Contacts,
        /// <summary>
        /// The contracts field.
        /// </summary>
        [EnumMember(Value = "contracts")]
        Contracts,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The custom fields field.
        /// </summary>
        [EnumMember(Value = "customFields")]
        CustomFields,
        /// <summary>
        /// The custom fields attachments field.
        /// </summary>
        [EnumMember(Value = "customFieldsAttachments")]
        CustomFieldsAttachments,
        /// <summary>
        /// The disabled field.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// The financial id field.
        /// </summary>
        [EnumMember(Value = "financialID")]
        FinancialID,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The manager field.
        /// </summary>
        [EnumMember(Value = "manager")]
        Manager,
        /// <summary>
        /// The name field.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// The order template field.
        /// </summary>
        [EnumMember(Value = "orderTemplate")]
        OrderTemplate,
        /// <summary>
        /// The parent field.
        /// </summary>
        [EnumMember(Value = "parent")]
        Parent,
        /// <summary>
        /// The people field.
        /// </summary>
        [EnumMember(Value = "people")]
        People,
        /// <summary>
        /// The picture uri field.
        /// </summary>
        [EnumMember(Value = "pictureUri")]
        PictureUri,
        /// <summary>
        /// The region field.
        /// </summary>
        [EnumMember(Value = "region")]
        Region,
        /// <summary>
        /// The remarks field.
        /// </summary>
        [EnumMember(Value = "remarks")]
        Remarks,
        /// <summary>
        /// The remarks attachments field.
        /// </summary>
        [EnumMember(Value = "remarksAttachments")]
        RemarksAttachments,
        /// <summary>
        /// The risks field.
        /// </summary>
        [EnumMember(Value = "risks")]
        Risks,
        /// <summary>
        /// The service level agreements field.
        /// </summary>
        [EnumMember(Value = "serviceLevelAgreements")]
        ServiceLevelAgreements,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The substitute field.
        /// </summary>
        [EnumMember(Value = "substitute")]
        Substitute,
        /// <summary>
        /// The time allocations field.
        /// </summary>
        [EnumMember(Value = "timeAllocations")]
        TimeAllocations,
        /// <summary>
        /// The ui extension field.
        /// </summary>
        [EnumMember(Value = "uiExtension")]
        UiExtension,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The <see cref="OutOfOfficePeriod">OutOfOfficePeriod</see> fields.
    /// </summary>
    public enum OutOfOfficePeriodField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The approval delegate field.
        /// </summary>
        [EnumMember(Value = "approvalDelegate")]
        ApprovalDelegate,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The effort class field.
        /// </summary>
        [EnumMember(Value = "effortClass")]
        EffortClass,
        /// <summary>
        /// The end at field.
        /// </summary>
        [EnumMember(Value = "endAt")]
        EndAt,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The person field.
        /// </summary>
        [EnumMember(Value = "person")]
        Person,
        /// <summary>
        /// The reason field.
        /// </summary>
        [EnumMember(Value = "reason")]
        Reason,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The start at field.
        /// </summary>
        [EnumMember(Value = "startAt")]
        StartAt,
        /// <summary>
        /// The time allocation field.
        /// </summary>
        [EnumMember(Value = "timeAllocation")]
        TimeAllocation,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The <see cref="ParentServiceInstance">ParentServiceInstance</see> fields.
    /// </summary>
    public enum ParentServiceInstanceField
    {
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The impact relation field.
        /// </summary>
        [EnumMember(Value = "impactRelation")]
        ImpactRelation,
        /// <summary>
        /// The service instance field.
        /// </summary>
        [EnumMember(Value = "serviceInstance")]
        ServiceInstance,
    }

    /// <summary>
    /// The <see cref="PdfDesign">PdfDesign</see> fields.
    /// </summary>
    public enum PdfDesignField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The category field.
        /// </summary>
        [EnumMember(Value = "category")]
        Category,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The css field.
        /// </summary>
        [EnumMember(Value = "css")]
        Css,
        /// <summary>
        /// The description field.
        /// </summary>
        [EnumMember(Value = "description")]
        Description,
        /// <summary>
        /// The description attachments field.
        /// </summary>
        [EnumMember(Value = "descriptionAttachments")]
        DescriptionAttachments,
        /// <summary>
        /// The disabled field.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// The html field.
        /// </summary>
        [EnumMember(Value = "html")]
        Html,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The name field.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The translations field.
        /// </summary>
        [EnumMember(Value = "translations")]
        Translations,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The <see cref="Period">Period</see> fields.
    /// </summary>
    public enum PeriodField
    {
        /// <summary>
        /// The from field.
        /// </summary>
        [EnumMember(Value = "from")]
        From,
        /// <summary>
        /// The provider not accountable field.
        /// </summary>
        [EnumMember(Value = "providerNotAccountable")]
        ProviderNotAccountable,
        /// <summary>
        /// The to field.
        /// </summary>
        [EnumMember(Value = "to")]
        To,
    }

    /// <summary>
    /// The <see cref="Permission">Permission</see> fields.
    /// </summary>
    public enum PermissionField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The roles field.
        /// </summary>
        [EnumMember(Value = "roles")]
        Roles,
    }

    /// <summary>
    /// The <see cref="Person">Person</see> fields.
    /// </summary>
    public enum PersonField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The addresses field.
        /// </summary>
        [EnumMember(Value = "addresses")]
        Addresses,
        /// <summary>
        /// The authentication id field.
        /// </summary>
        [EnumMember(Value = "authenticationID")]
        AuthenticationID,
        /// <summary>
        /// The auto translation field.
        /// </summary>
        [EnumMember(Value = "autoTranslation")]
        AutoTranslation,
        /// <summary>
        /// The cart field.
        /// </summary>
        [EnumMember(Value = "cart")]
        Cart,
        /// <summary>
        /// The configuration items field.
        /// </summary>
        [EnumMember(Value = "configurationItems")]
        ConfigurationItems,
        /// <summary>
        /// The contacts field.
        /// </summary>
        [EnumMember(Value = "contacts")]
        Contacts,
        /// <summary>
        /// The cost per hour field.
        /// </summary>
        [EnumMember(Value = "costPerHour")]
        CostPerHour,
        /// <summary>
        /// The cost per hour currency field.
        /// </summary>
        [EnumMember(Value = "costPerHourCurrency")]
        CostPerHourCurrency,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The custom fields field.
        /// </summary>
        [EnumMember(Value = "customFields")]
        CustomFields,
        /// <summary>
        /// The custom fields attachments field.
        /// </summary>
        [EnumMember(Value = "customFieldsAttachments")]
        CustomFieldsAttachments,
        /// <summary>
        /// The disabled field.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// The do not translate languages field.
        /// </summary>
        [EnumMember(Value = "doNotTranslateLanguages")]
        DoNotTranslateLanguages,
        /// <summary>
        /// The employee id field.
        /// </summary>
        [EnumMember(Value = "employeeID")]
        EmployeeID,
        /// <summary>
        /// The exclude team notifications field.
        /// </summary>
        [EnumMember(Value = "excludeTeamNotifications")]
        ExcludeTeamNotifications,
        /// <summary>
        /// The guest field.
        /// </summary>
        [EnumMember(Value = "guest")]
        Guest,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The information field.
        /// </summary>
        [EnumMember(Value = "information")]
        Information,
        /// <summary>
        /// The information attachments field.
        /// </summary>
        [EnumMember(Value = "informationAttachments")]
        InformationAttachments,
        /// <summary>
        /// The job title field.
        /// </summary>
        [EnumMember(Value = "jobTitle")]
        JobTitle,
        /// <summary>
        /// The language field.
        /// </summary>
        [EnumMember(Value = "language")]
        Language,
        /// <summary>
        /// The life cycle state field.
        /// </summary>
        [EnumMember(Value = "lifeCycleState")]
        LifeCycleState,
        /// <summary>
        /// The location field.
        /// </summary>
        [EnumMember(Value = "location")]
        Location,
        /// <summary>
        /// The manager field.
        /// </summary>
        [EnumMember(Value = "manager")]
        Manager,
        /// <summary>
        /// The name field.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// The oauth person enablement field.
        /// </summary>
        [EnumMember(Value = "oauthPersonEnablement")]
        OauthPersonEnablement,
        /// <summary>
        /// The organization field.
        /// </summary>
        [EnumMember(Value = "organization")]
        Organization,
        /// <summary>
        /// The out of office periods field.
        /// </summary>
        [EnumMember(Value = "outOfOfficePeriods")]
        OutOfOfficePeriods,
        /// <summary>
        /// The permissions field.
        /// </summary>
        [EnumMember(Value = "permissions")]
        Permissions,
        /// <summary>
        /// The picture uri field.
        /// </summary>
        [EnumMember(Value = "pictureUri")]
        PictureUri,
        /// <summary>
        /// The primary email field.
        /// </summary>
        [EnumMember(Value = "primaryEmail")]
        PrimaryEmail,
        /// <summary>
        /// The send email notifications field.
        /// </summary>
        [EnumMember(Value = "sendEmailNotifications")]
        SendEmailNotifications,
        /// <summary>
        /// The show notification popup field.
        /// </summary>
        [EnumMember(Value = "showNotificationPopup")]
        ShowNotificationPopup,
        /// <summary>
        /// The site field.
        /// </summary>
        [EnumMember(Value = "site")]
        Site,
        /// <summary>
        /// The skill pools field.
        /// </summary>
        [EnumMember(Value = "skillPools")]
        SkillPools,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The support id field.
        /// </summary>
        [EnumMember(Value = "supportID")]
        SupportID,
        /// <summary>
        /// The teams field.
        /// </summary>
        [EnumMember(Value = "teams")]
        Teams,
        /// <summary>
        /// The time format 24 h field.
        /// </summary>
        [EnumMember(Value = "timeFormat24h")]
        TimeFormat24h,
        /// <summary>
        /// The time zone field.
        /// </summary>
        [EnumMember(Value = "timeZone")]
        TimeZone,
        /// <summary>
        /// The ui extension field.
        /// </summary>
        [EnumMember(Value = "uiExtension")]
        UiExtension,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// The vip field.
        /// </summary>
        [EnumMember(Value = "vip")]
        Vip,
        /// <summary>
        /// The work hours field.
        /// </summary>
        [EnumMember(Value = "workHours")]
        WorkHours,
    }

    /// <summary>
    /// The <see cref="Problem">Problem</see> fields.
    /// </summary>
    public enum ProblemField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The agile board field.
        /// </summary>
        [EnumMember(Value = "agileBoard")]
        AgileBoard,
        /// <summary>
        /// The agile board column field.
        /// </summary>
        [EnumMember(Value = "agileBoardColumn")]
        AgileBoardColumn,
        /// <summary>
        /// The agile board column position field.
        /// </summary>
        [EnumMember(Value = "agileBoardColumnPosition")]
        AgileBoardColumnPosition,
        /// <summary>
        /// The analysis target at field.
        /// </summary>
        [EnumMember(Value = "analysisTargetAt")]
        AnalysisTargetAt,
        /// <summary>
        /// The category field.
        /// </summary>
        [EnumMember(Value = "category")]
        Category,
        /// <summary>
        /// The configuration items field.
        /// </summary>
        [EnumMember(Value = "configurationItems")]
        ConfigurationItems,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The custom fields field.
        /// </summary>
        [EnumMember(Value = "customFields")]
        CustomFields,
        /// <summary>
        /// The custom fields attachments field.
        /// </summary>
        [EnumMember(Value = "customFieldsAttachments")]
        CustomFieldsAttachments,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The impact field.
        /// </summary>
        [EnumMember(Value = "impact")]
        Impact,
        /// <summary>
        /// The knowledge article field.
        /// </summary>
        [EnumMember(Value = "knowledgeArticle")]
        KnowledgeArticle,
        /// <summary>
        /// The known error field.
        /// </summary>
        [EnumMember(Value = "knownError")]
        KnownError,
        /// <summary>
        /// The life cycle state field.
        /// </summary>
        [EnumMember(Value = "lifeCycleState")]
        LifeCycleState,
        /// <summary>
        /// The manager field.
        /// </summary>
        [EnumMember(Value = "manager")]
        Manager,
        /// <summary>
        /// The member field.
        /// </summary>
        [EnumMember(Value = "member")]
        Member,
        /// <summary>
        /// The notes field.
        /// </summary>
        [EnumMember(Value = "notes")]
        Notes,
        /// <summary>
        /// The planned effort field.
        /// </summary>
        [EnumMember(Value = "plannedEffort")]
        PlannedEffort,
        /// <summary>
        /// The problem id field.
        /// </summary>
        [EnumMember(Value = "problemId")]
        ProblemId,
        /// <summary>
        /// The product backlog field.
        /// </summary>
        [EnumMember(Value = "productBacklog")]
        ProductBacklog,
        /// <summary>
        /// The product backlog estimate field.
        /// </summary>
        [EnumMember(Value = "productBacklogEstimate")]
        ProductBacklogEstimate,
        /// <summary>
        /// The product backlog position field.
        /// </summary>
        [EnumMember(Value = "productBacklogPosition")]
        ProductBacklogPosition,
        /// <summary>
        /// The project field.
        /// </summary>
        [EnumMember(Value = "project")]
        Project,
        /// <summary>
        /// The requests field.
        /// </summary>
        [EnumMember(Value = "requests")]
        Requests,
        /// <summary>
        /// The resolution duration field.
        /// </summary>
        [EnumMember(Value = "resolutionDuration")]
        ResolutionDuration,
        /// <summary>
        /// The service field.
        /// </summary>
        [EnumMember(Value = "service")]
        Service,
        /// <summary>
        /// The service instances field.
        /// </summary>
        [EnumMember(Value = "serviceInstances")]
        ServiceInstances,
        /// <summary>
        /// The solved at field.
        /// </summary>
        [EnumMember(Value = "solvedAt")]
        SolvedAt,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The sprint backlog items field.
        /// </summary>
        [EnumMember(Value = "sprintBacklogItems")]
        SprintBacklogItems,
        /// <summary>
        /// The status field.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,
        /// <summary>
        /// The subject field.
        /// </summary>
        [EnumMember(Value = "subject")]
        Subject,
        /// <summary>
        /// The supplier field.
        /// </summary>
        [EnumMember(Value = "supplier")]
        Supplier,
        /// <summary>
        /// The supplier request id field.
        /// </summary>
        [EnumMember(Value = "supplierRequestID")]
        SupplierRequestID,
        /// <summary>
        /// The team field.
        /// </summary>
        [EnumMember(Value = "team")]
        Team,
        /// <summary>
        /// The time entries field.
        /// </summary>
        [EnumMember(Value = "timeEntries")]
        TimeEntries,
        /// <summary>
        /// The ui extension field.
        /// </summary>
        [EnumMember(Value = "uiExtension")]
        UiExtension,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// The urgent field.
        /// </summary>
        [EnumMember(Value = "urgent")]
        Urgent,
        /// <summary>
        /// The waiting until field.
        /// </summary>
        [EnumMember(Value = "waitingUntil")]
        WaitingUntil,
        /// <summary>
        /// The workaround field.
        /// </summary>
        [EnumMember(Value = "workaround")]
        Workaround,
        /// <summary>
        /// The workaround attachments field.
        /// </summary>
        [EnumMember(Value = "workaroundAttachments")]
        WorkaroundAttachments,
        /// <summary>
        /// The workflow field.
        /// </summary>
        [EnumMember(Value = "workflow")]
        Workflow,
    }

    /// <summary>
    /// The <see cref="Product">Product</see> fields.
    /// </summary>
    public enum ProductField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The brand field.
        /// </summary>
        [EnumMember(Value = "brand")]
        Brand,
        /// <summary>
        /// The configuration items field.
        /// </summary>
        [EnumMember(Value = "configurationItems")]
        ConfigurationItems,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The custom fields field.
        /// </summary>
        [EnumMember(Value = "customFields")]
        CustomFields,
        /// <summary>
        /// The custom fields attachments field.
        /// </summary>
        [EnumMember(Value = "customFieldsAttachments")]
        CustomFieldsAttachments,
        /// <summary>
        /// The depreciation method field.
        /// </summary>
        [EnumMember(Value = "depreciationMethod")]
        DepreciationMethod,
        /// <summary>
        /// The disabled field.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// The financial owner field.
        /// </summary>
        [EnumMember(Value = "financialOwner")]
        FinancialOwner,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The model field.
        /// </summary>
        [EnumMember(Value = "model")]
        Model,
        /// <summary>
        /// The name field.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// The picture uri field.
        /// </summary>
        [EnumMember(Value = "pictureUri")]
        PictureUri,
        /// <summary>
        /// The product category field.
        /// </summary>
        [EnumMember(Value = "productCategory")]
        ProductCategory,
        /// <summary>
        /// The product id field.
        /// </summary>
        [EnumMember(Value = "productID")]
        ProductID,
        /// <summary>
        /// The rate field.
        /// </summary>
        [EnumMember(Value = "rate")]
        Rate,
        /// <summary>
        /// The recurrence field.
        /// </summary>
        [EnumMember(Value = "recurrence")]
        Recurrence,
        /// <summary>
        /// The remarks field.
        /// </summary>
        [EnumMember(Value = "remarks")]
        Remarks,
        /// <summary>
        /// The remarks attachments field.
        /// </summary>
        [EnumMember(Value = "remarksAttachments")]
        RemarksAttachments,
        /// <summary>
        /// The rule set field.
        /// </summary>
        [EnumMember(Value = "ruleSet")]
        RuleSet,
        /// <summary>
        /// The salvage value field.
        /// </summary>
        [EnumMember(Value = "salvageValue")]
        SalvageValue,
        /// <summary>
        /// The salvage value currency field.
        /// </summary>
        [EnumMember(Value = "salvageValueCurrency")]
        SalvageValueCurrency,
        /// <summary>
        /// The service field.
        /// </summary>
        [EnumMember(Value = "service")]
        Service,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The supplier field.
        /// </summary>
        [EnumMember(Value = "supplier")]
        Supplier,
        /// <summary>
        /// The support team field.
        /// </summary>
        [EnumMember(Value = "supportTeam")]
        SupportTeam,
        /// <summary>
        /// The ui extension field.
        /// </summary>
        [EnumMember(Value = "uiExtension")]
        UiExtension,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// The useful life field.
        /// </summary>
        [EnumMember(Value = "usefulLife")]
        UsefulLife,
        /// <summary>
        /// The workflow manager field.
        /// </summary>
        [EnumMember(Value = "workflowManager")]
        WorkflowManager,
        /// <summary>
        /// The workflow template field.
        /// </summary>
        [EnumMember(Value = "workflowTemplate")]
        WorkflowTemplate,
    }

    /// <summary>
    /// The <see cref="ProductBacklog">ProductBacklog</see> fields.
    /// </summary>
    public enum ProductBacklogField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The description field.
        /// </summary>
        [EnumMember(Value = "description")]
        Description,
        /// <summary>
        /// The description attachments field.
        /// </summary>
        [EnumMember(Value = "descriptionAttachments")]
        DescriptionAttachments,
        /// <summary>
        /// The disabled field.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The items field.
        /// </summary>
        [EnumMember(Value = "items")]
        Items,
        /// <summary>
        /// The name field.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// The picture uri field.
        /// </summary>
        [EnumMember(Value = "pictureUri")]
        PictureUri,
        /// <summary>
        /// The product owner field.
        /// </summary>
        [EnumMember(Value = "productOwner")]
        ProductOwner,
        /// <summary>
        /// The scrum workspaces field.
        /// </summary>
        [EnumMember(Value = "scrumWorkspaces")]
        ScrumWorkspaces,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The <see cref="ProductBacklogItem">ProductBacklogItem</see> fields.
    /// </summary>
    public enum ProductBacklogItemField
    {
        /// <summary>
        /// The product backlog field.
        /// </summary>
        [EnumMember(Value = "productBacklog")]
        ProductBacklog,
        /// <summary>
        /// The product backlog estimate field.
        /// </summary>
        [EnumMember(Value = "productBacklogEstimate")]
        ProductBacklogEstimate,
        /// <summary>
        /// The product backlog position field.
        /// </summary>
        [EnumMember(Value = "productBacklogPosition")]
        ProductBacklogPosition,
    }

    /// <summary>
    /// The <see cref="ProductCategory">ProductCategory</see> fields.
    /// </summary>
    public enum ProductCategoryField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The disabled field.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// The group field.
        /// </summary>
        [EnumMember(Value = "group")]
        Group,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The name field.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// The picture uri field.
        /// </summary>
        [EnumMember(Value = "pictureUri")]
        PictureUri,
        /// <summary>
        /// The products field.
        /// </summary>
        [EnumMember(Value = "products")]
        Products,
        /// <summary>
        /// The reference field.
        /// </summary>
        [EnumMember(Value = "reference")]
        Reference,
        /// <summary>
        /// The rule set field.
        /// </summary>
        [EnumMember(Value = "ruleSet")]
        RuleSet,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The translations field.
        /// </summary>
        [EnumMember(Value = "translations")]
        Translations,
        /// <summary>
        /// The ui extension field.
        /// </summary>
        [EnumMember(Value = "uiExtension")]
        UiExtension,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The <see cref="Project">Project</see> fields.
    /// </summary>
    public enum ProjectField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The budget allocated field.
        /// </summary>
        [EnumMember(Value = "budgetAllocated")]
        BudgetAllocated,
        /// <summary>
        /// The category field.
        /// </summary>
        [EnumMember(Value = "category")]
        Category,
        /// <summary>
        /// The completed at field.
        /// </summary>
        [EnumMember(Value = "completedAt")]
        CompletedAt,
        /// <summary>
        /// The completion reason field.
        /// </summary>
        [EnumMember(Value = "completionReason")]
        CompletionReason,
        /// <summary>
        /// The completion target at field.
        /// </summary>
        [EnumMember(Value = "completionTargetAt")]
        CompletionTargetAt,
        /// <summary>
        /// The cost of effort field.
        /// </summary>
        [EnumMember(Value = "costOfEffort")]
        CostOfEffort,
        /// <summary>
        /// The cost of purchases field.
        /// </summary>
        [EnumMember(Value = "costOfPurchases")]
        CostOfPurchases,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The customer field.
        /// </summary>
        [EnumMember(Value = "customer")]
        Customer,
        /// <summary>
        /// The custom fields field.
        /// </summary>
        [EnumMember(Value = "customFields")]
        CustomFields,
        /// <summary>
        /// The custom fields attachments field.
        /// </summary>
        [EnumMember(Value = "customFieldsAttachments")]
        CustomFieldsAttachments,
        /// <summary>
        /// The effort field.
        /// </summary>
        [EnumMember(Value = "effort")]
        Effort,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The invoices field.
        /// </summary>
        [EnumMember(Value = "invoices")]
        Invoices,
        /// <summary>
        /// The justification field.
        /// </summary>
        [EnumMember(Value = "justification")]
        Justification,
        /// <summary>
        /// The life cycle state field.
        /// </summary>
        [EnumMember(Value = "lifeCycleState")]
        LifeCycleState,
        /// <summary>
        /// The manager field.
        /// </summary>
        [EnumMember(Value = "manager")]
        Manager,
        /// <summary>
        /// The notes field.
        /// </summary>
        [EnumMember(Value = "notes")]
        Notes,
        /// <summary>
        /// The phases field.
        /// </summary>
        [EnumMember(Value = "phases")]
        Phases,
        /// <summary>
        /// The problems field.
        /// </summary>
        [EnumMember(Value = "problems")]
        Problems,
        /// <summary>
        /// The program field.
        /// </summary>
        [EnumMember(Value = "program")]
        Program,
        /// <summary>
        /// The project id field.
        /// </summary>
        [EnumMember(Value = "projectId")]
        ProjectId,
        /// <summary>
        /// The requests field.
        /// </summary>
        [EnumMember(Value = "requests")]
        Requests,
        /// <summary>
        /// The resolution duration field.
        /// </summary>
        [EnumMember(Value = "resolutionDuration")]
        ResolutionDuration,
        /// <summary>
        /// The risk level field.
        /// </summary>
        [EnumMember(Value = "riskLevel")]
        RiskLevel,
        /// <summary>
        /// The risks field.
        /// </summary>
        [EnumMember(Value = "risks")]
        Risks,
        /// <summary>
        /// The roi field.
        /// </summary>
        [EnumMember(Value = "roi")]
        Roi,
        /// <summary>
        /// The service field.
        /// </summary>
        [EnumMember(Value = "service")]
        Service,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The status field.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,
        /// <summary>
        /// The subject field.
        /// </summary>
        [EnumMember(Value = "subject")]
        Subject,
        /// <summary>
        /// The tasks field.
        /// </summary>
        [EnumMember(Value = "tasks")]
        Tasks,
        /// <summary>
        /// The time zone field.
        /// </summary>
        [EnumMember(Value = "timeZone")]
        TimeZone,
        /// <summary>
        /// The total cost field.
        /// </summary>
        [EnumMember(Value = "totalCost")]
        TotalCost,
        /// <summary>
        /// The ui extension field.
        /// </summary>
        [EnumMember(Value = "uiExtension")]
        UiExtension,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// The value field.
        /// </summary>
        [EnumMember(Value = "value")]
        Value,
        /// <summary>
        /// The value currency field.
        /// </summary>
        [EnumMember(Value = "valueCurrency")]
        ValueCurrency,
        /// <summary>
        /// The workflows field.
        /// </summary>
        [EnumMember(Value = "workflows")]
        Workflows,
        /// <summary>
        /// The work hours field.
        /// </summary>
        [EnumMember(Value = "workHours")]
        WorkHours,
    }

    /// <summary>
    /// The <see cref="ProjectCategory">ProjectCategory</see> fields.
    /// </summary>
    public enum ProjectCategoryField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The description field.
        /// </summary>
        [EnumMember(Value = "description")]
        Description,
        /// <summary>
        /// The disabled field.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The information field.
        /// </summary>
        [EnumMember(Value = "information")]
        Information,
        /// <summary>
        /// The information attachments field.
        /// </summary>
        [EnumMember(Value = "informationAttachments")]
        InformationAttachments,
        /// <summary>
        /// The name field.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// The position field.
        /// </summary>
        [EnumMember(Value = "position")]
        Position,
        /// <summary>
        /// The reference field.
        /// </summary>
        [EnumMember(Value = "reference")]
        Reference,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The <see cref="ProjectPhase">ProjectPhase</see> fields.
    /// </summary>
    public enum ProjectPhaseField
    {
        /// <summary>
        /// The completed at field.
        /// </summary>
        [EnumMember(Value = "completedAt")]
        CompletedAt,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The name field.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// The position field.
        /// </summary>
        [EnumMember(Value = "position")]
        Position,
        /// <summary>
        /// The started at field.
        /// </summary>
        [EnumMember(Value = "startedAt")]
        StartedAt,
        /// <summary>
        /// The status field.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The <see cref="ProjectRiskLevel">ProjectRiskLevel</see> fields.
    /// </summary>
    public enum ProjectRiskLevelField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The description field.
        /// </summary>
        [EnumMember(Value = "description")]
        Description,
        /// <summary>
        /// The disabled field.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The information field.
        /// </summary>
        [EnumMember(Value = "information")]
        Information,
        /// <summary>
        /// The information attachments field.
        /// </summary>
        [EnumMember(Value = "informationAttachments")]
        InformationAttachments,
        /// <summary>
        /// The name field.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// The position field.
        /// </summary>
        [EnumMember(Value = "position")]
        Position,
        /// <summary>
        /// The reference field.
        /// </summary>
        [EnumMember(Value = "reference")]
        Reference,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The <see cref="ProjectTask">ProjectTask</see> fields.
    /// </summary>
    public enum ProjectTaskField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The agile board field.
        /// </summary>
        [EnumMember(Value = "agileBoard")]
        AgileBoard,
        /// <summary>
        /// The agile board column field.
        /// </summary>
        [EnumMember(Value = "agileBoardColumn")]
        AgileBoardColumn,
        /// <summary>
        /// The agile board column position field.
        /// </summary>
        [EnumMember(Value = "agileBoardColumnPosition")]
        AgileBoardColumnPosition,
        /// <summary>
        /// The anticipated assignment at field.
        /// </summary>
        [EnumMember(Value = "anticipatedAssignmentAt")]
        AnticipatedAssignmentAt,
        /// <summary>
        /// The assigned at field.
        /// </summary>
        [EnumMember(Value = "assignedAt")]
        AssignedAt,
        /// <summary>
        /// The assignments field.
        /// </summary>
        [EnumMember(Value = "assignments")]
        Assignments,
        /// <summary>
        /// The automation rules field.
        /// </summary>
        [EnumMember(Value = "automationRules")]
        AutomationRules,
        /// <summary>
        /// The category field.
        /// </summary>
        [EnumMember(Value = "category")]
        Category,
        /// <summary>
        /// The checked items field.
        /// </summary>
        [EnumMember(Value = "checkedItems")]
        CheckedItems,
        /// <summary>
        /// The completion target at field.
        /// </summary>
        [EnumMember(Value = "completionTargetAt")]
        CompletionTargetAt,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The custom fields field.
        /// </summary>
        [EnumMember(Value = "customFields")]
        CustomFields,
        /// <summary>
        /// The custom fields attachments field.
        /// </summary>
        [EnumMember(Value = "customFieldsAttachments")]
        CustomFieldsAttachments,
        /// <summary>
        /// The deadline field.
        /// </summary>
        [EnumMember(Value = "deadline")]
        Deadline,
        /// <summary>
        /// The finished at field.
        /// </summary>
        [EnumMember(Value = "finishedAt")]
        FinishedAt,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The instructions field.
        /// </summary>
        [EnumMember(Value = "instructions")]
        Instructions,
        /// <summary>
        /// The instructions attachments field.
        /// </summary>
        [EnumMember(Value = "instructionsAttachments")]
        InstructionsAttachments,
        /// <summary>
        /// The life cycle state field.
        /// </summary>
        [EnumMember(Value = "lifeCycleState")]
        LifeCycleState,
        /// <summary>
        /// The note behavior field.
        /// </summary>
        [EnumMember(Value = "noteBehavior")]
        NoteBehavior,
        /// <summary>
        /// The notes field.
        /// </summary>
        [EnumMember(Value = "notes")]
        Notes,
        /// <summary>
        /// The pdf design field.
        /// </summary>
        [EnumMember(Value = "pdfDesign")]
        PdfDesign,
        /// <summary>
        /// The phase field.
        /// </summary>
        [EnumMember(Value = "phase")]
        Phase,
        /// <summary>
        /// The planned duration field.
        /// </summary>
        [EnumMember(Value = "plannedDuration")]
        PlannedDuration,
        /// <summary>
        /// The planned effort field.
        /// </summary>
        [EnumMember(Value = "plannedEffort")]
        PlannedEffort,
        /// <summary>
        /// The predecessors field.
        /// </summary>
        [EnumMember(Value = "predecessors")]
        Predecessors,
        /// <summary>
        /// The project field.
        /// </summary>
        [EnumMember(Value = "project")]
        Project,
        /// <summary>
        /// The project task id field.
        /// </summary>
        [EnumMember(Value = "projectTaskId")]
        ProjectTaskId,
        /// <summary>
        /// The required approvals field.
        /// </summary>
        [EnumMember(Value = "requiredApprovals")]
        RequiredApprovals,
        /// <summary>
        /// The resolution duration field.
        /// </summary>
        [EnumMember(Value = "resolutionDuration")]
        ResolutionDuration,
        /// <summary>
        /// The skill pool field.
        /// </summary>
        [EnumMember(Value = "skillPool")]
        SkillPool,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The sprint backlog items field.
        /// </summary>
        [EnumMember(Value = "sprintBacklogItems")]
        SprintBacklogItems,
        /// <summary>
        /// The start at field.
        /// </summary>
        [EnumMember(Value = "startAt")]
        StartAt,
        /// <summary>
        /// The status field.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,
        /// <summary>
        /// The subject field.
        /// </summary>
        [EnumMember(Value = "subject")]
        Subject,
        /// <summary>
        /// The successors field.
        /// </summary>
        [EnumMember(Value = "successors")]
        Successors,
        /// <summary>
        /// The supplier field.
        /// </summary>
        [EnumMember(Value = "supplier")]
        Supplier,
        /// <summary>
        /// The supplier request id field.
        /// </summary>
        [EnumMember(Value = "supplierRequestID")]
        SupplierRequestID,
        /// <summary>
        /// The team field.
        /// </summary>
        [EnumMember(Value = "team")]
        Team,
        /// <summary>
        /// The template field.
        /// </summary>
        [EnumMember(Value = "template")]
        Template,
        /// <summary>
        /// The time entries field.
        /// </summary>
        [EnumMember(Value = "timeEntries")]
        TimeEntries,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// The urgent field.
        /// </summary>
        [EnumMember(Value = "urgent")]
        Urgent,
        /// <summary>
        /// The waiting until field.
        /// </summary>
        [EnumMember(Value = "waitingUntil")]
        WaitingUntil,
        /// <summary>
        /// The work hours are 24 x 7 field.
        /// </summary>
        [EnumMember(Value = "workHoursAre24x7")]
        WorkHoursAre24x7,
    }

    /// <summary>
    /// The <see cref="ProjectTaskAssignment">ProjectTaskAssignment</see> fields.
    /// </summary>
    public enum ProjectTaskAssignmentField
    {
        /// <summary>
        /// The assignee field.
        /// </summary>
        [EnumMember(Value = "assignee")]
        Assignee,
        /// <summary>
        /// The attachment field.
        /// </summary>
        [EnumMember(Value = "attachment")]
        Attachment,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The planned effort field.
        /// </summary>
        [EnumMember(Value = "plannedEffort")]
        PlannedEffort,
        /// <summary>
        /// The status field.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// The waiting until field.
        /// </summary>
        [EnumMember(Value = "waitingUntil")]
        WaitingUntil,
    }

    /// <summary>
    /// The <see cref="ProjectTaskTemplate">ProjectTaskTemplate</see> fields.
    /// </summary>
    public enum ProjectTaskTemplateField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The assignments field.
        /// </summary>
        [EnumMember(Value = "assignments")]
        Assignments,
        /// <summary>
        /// The assign to project manager field.
        /// </summary>
        [EnumMember(Value = "assignToProjectManager")]
        AssignToProjectManager,
        /// <summary>
        /// The assign to requester field.
        /// </summary>
        [EnumMember(Value = "assignToRequester")]
        AssignToRequester,
        /// <summary>
        /// The assign to requester business unit manager field.
        /// </summary>
        [EnumMember(Value = "assignToRequesterBusinessUnitManager")]
        AssignToRequesterBusinessUnitManager,
        /// <summary>
        /// The assign to requester manager field.
        /// </summary>
        [EnumMember(Value = "assignToRequesterManager")]
        AssignToRequesterManager,
        /// <summary>
        /// The assign to service owner field.
        /// </summary>
        [EnumMember(Value = "assignToServiceOwner")]
        AssignToServiceOwner,
        /// <summary>
        /// The automation rules field.
        /// </summary>
        [EnumMember(Value = "automationRules")]
        AutomationRules,
        /// <summary>
        /// The category field.
        /// </summary>
        [EnumMember(Value = "category")]
        Category,
        /// <summary>
        /// The copy notes to project field.
        /// </summary>
        [EnumMember(Value = "copyNotesToProject")]
        CopyNotesToProject,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The disabled field.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// The effort class field.
        /// </summary>
        [EnumMember(Value = "effortClass")]
        EffortClass,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The instructions field.
        /// </summary>
        [EnumMember(Value = "instructions")]
        Instructions,
        /// <summary>
        /// The instructions attachments field.
        /// </summary>
        [EnumMember(Value = "instructionsAttachments")]
        InstructionsAttachments,
        /// <summary>
        /// The note field.
        /// </summary>
        [EnumMember(Value = "note")]
        Note,
        /// <summary>
        /// The note attachments field.
        /// </summary>
        [EnumMember(Value = "noteAttachments")]
        NoteAttachments,
        /// <summary>
        /// The note behavior field.
        /// </summary>
        [EnumMember(Value = "noteBehavior")]
        NoteBehavior,
        /// <summary>
        /// The pdf design field.
        /// </summary>
        [EnumMember(Value = "pdfDesign")]
        PdfDesign,
        /// <summary>
        /// The planned duration field.
        /// </summary>
        [EnumMember(Value = "plannedDuration")]
        PlannedDuration,
        /// <summary>
        /// The planned effort field.
        /// </summary>
        [EnumMember(Value = "plannedEffort")]
        PlannedEffort,
        /// <summary>
        /// The planned effort project manager field.
        /// </summary>
        [EnumMember(Value = "plannedEffortProjectManager")]
        PlannedEffortProjectManager,
        /// <summary>
        /// The planned effort requester field.
        /// </summary>
        [EnumMember(Value = "plannedEffortRequester")]
        PlannedEffortRequester,
        /// <summary>
        /// The planned effort requester business unit manager field.
        /// </summary>
        [EnumMember(Value = "plannedEffortRequesterBusinessUnitManager")]
        PlannedEffortRequesterBusinessUnitManager,
        /// <summary>
        /// The planned effort requester manager field.
        /// </summary>
        [EnumMember(Value = "plannedEffortRequesterManager")]
        PlannedEffortRequesterManager,
        /// <summary>
        /// The planned effort service owner field.
        /// </summary>
        [EnumMember(Value = "plannedEffortServiceOwner")]
        PlannedEffortServiceOwner,
        /// <summary>
        /// The project templates field.
        /// </summary>
        [EnumMember(Value = "projectTemplates")]
        ProjectTemplates,
        /// <summary>
        /// The required approvals field.
        /// </summary>
        [EnumMember(Value = "requiredApprovals")]
        RequiredApprovals,
        /// <summary>
        /// The skill pool field.
        /// </summary>
        [EnumMember(Value = "skillPool")]
        SkillPool,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The subject field.
        /// </summary>
        [EnumMember(Value = "subject")]
        Subject,
        /// <summary>
        /// The supplier field.
        /// </summary>
        [EnumMember(Value = "supplier")]
        Supplier,
        /// <summary>
        /// The tasks field.
        /// </summary>
        [EnumMember(Value = "tasks")]
        Tasks,
        /// <summary>
        /// The team field.
        /// </summary>
        [EnumMember(Value = "team")]
        Team,
        /// <summary>
        /// The ui extension field.
        /// </summary>
        [EnumMember(Value = "uiExtension")]
        UiExtension,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// The work hours are 24 x 7 field.
        /// </summary>
        [EnumMember(Value = "workHoursAre24x7")]
        WorkHoursAre24x7,
    }

    /// <summary>
    /// The <see cref="ProjectTaskTemplateAssignment">ProjectTaskTemplateAssignment</see> fields.
    /// </summary>
    public enum ProjectTaskTemplateAssignmentField
    {
        /// <summary>
        /// The assignee field.
        /// </summary>
        [EnumMember(Value = "assignee")]
        Assignee,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The planned effort field.
        /// </summary>
        [EnumMember(Value = "plannedEffort")]
        PlannedEffort,
    }

    /// <summary>
    /// The <see cref="ProjectTaskTemplateRelation">ProjectTaskTemplateRelation</see> fields.
    /// </summary>
    public enum ProjectTaskTemplateRelationField
    {
        /// <summary>
        /// The automation rules field.
        /// </summary>
        [EnumMember(Value = "automationRules")]
        AutomationRules,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The phase field.
        /// </summary>
        [EnumMember(Value = "phase")]
        Phase,
        /// <summary>
        /// The task template field.
        /// </summary>
        [EnumMember(Value = "taskTemplate")]
        TaskTemplate,
    }

    /// <summary>
    /// The <see cref="ProjectTemplate">ProjectTemplate</see> fields.
    /// </summary>
    public enum ProjectTemplateField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The disabled field.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The phases field.
        /// </summary>
        [EnumMember(Value = "phases")]
        Phases,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The subject field.
        /// </summary>
        [EnumMember(Value = "subject")]
        Subject,
        /// <summary>
        /// The task template relations field.
        /// </summary>
        [EnumMember(Value = "taskTemplateRelations")]
        TaskTemplateRelations,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The <see cref="ProjectTemplatePhase">ProjectTemplatePhase</see> fields.
    /// </summary>
    public enum ProjectTemplatePhaseField
    {
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The name field.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// The position field.
        /// </summary>
        [EnumMember(Value = "position")]
        Position,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The <see cref="ProviderShopArticle">ProviderShopArticle</see> fields.
    /// </summary>
    public enum ProviderShopArticleField
    {
        /// <summary>
        /// The disabled field.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// The end at field.
        /// </summary>
        [EnumMember(Value = "endAt")]
        EndAt,
        /// <summary>
        /// The full description field.
        /// </summary>
        [EnumMember(Value = "fullDescription")]
        FullDescription,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The max quantity field.
        /// </summary>
        [EnumMember(Value = "maxQuantity")]
        MaxQuantity,
        /// <summary>
        /// The name field.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// The picture uri field.
        /// </summary>
        [EnumMember(Value = "pictureUri")]
        PictureUri,
        /// <summary>
        /// The price field.
        /// </summary>
        [EnumMember(Value = "price")]
        Price,
        /// <summary>
        /// The price currency field.
        /// </summary>
        [EnumMember(Value = "priceCurrency")]
        PriceCurrency,
        /// <summary>
        /// The recurring period field.
        /// </summary>
        [EnumMember(Value = "recurringPeriod")]
        RecurringPeriod,
        /// <summary>
        /// The recurring price field.
        /// </summary>
        [EnumMember(Value = "recurringPrice")]
        RecurringPrice,
        /// <summary>
        /// The recurring price currency field.
        /// </summary>
        [EnumMember(Value = "recurringPriceCurrency")]
        RecurringPriceCurrency,
        /// <summary>
        /// The short description field.
        /// </summary>
        [EnumMember(Value = "shortDescription")]
        ShortDescription,
        /// <summary>
        /// The start at field.
        /// </summary>
        [EnumMember(Value = "startAt")]
        StartAt,
    }

    /// <summary>
    /// The <see cref="ProviderShopOrderLine">ProviderShopOrderLine</see> fields.
    /// </summary>
    public enum ProviderShopOrderLineField
    {
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The ordered at field.
        /// </summary>
        [EnumMember(Value = "orderedAt")]
        OrderedAt,
        /// <summary>
        /// The price field.
        /// </summary>
        [EnumMember(Value = "price")]
        Price,
        /// <summary>
        /// The price currency field.
        /// </summary>
        [EnumMember(Value = "priceCurrency")]
        PriceCurrency,
        /// <summary>
        /// The recurring period field.
        /// </summary>
        [EnumMember(Value = "recurringPeriod")]
        RecurringPeriod,
        /// <summary>
        /// The recurring price field.
        /// </summary>
        [EnumMember(Value = "recurringPrice")]
        RecurringPrice,
        /// <summary>
        /// The recurring price currency field.
        /// </summary>
        [EnumMember(Value = "recurringPriceCurrency")]
        RecurringPriceCurrency,
        /// <summary>
        /// The total price field.
        /// </summary>
        [EnumMember(Value = "totalPrice")]
        TotalPrice,
        /// <summary>
        /// The total recurring price field.
        /// </summary>
        [EnumMember(Value = "totalRecurringPrice")]
        TotalRecurringPrice,
    }

    /// <summary>
    /// The <see cref="RateLimit">RateLimit</see> fields.
    /// </summary>
    public enum RateLimitField
    {
        /// <summary>
        /// The cost field.
        /// </summary>
        [EnumMember(Value = "cost")]
        Cost,
        /// <summary>
        /// The limit field.
        /// </summary>
        [EnumMember(Value = "limit")]
        Limit,
        /// <summary>
        /// The remaining field.
        /// </summary>
        [EnumMember(Value = "remaining")]
        Remaining,
        /// <summary>
        /// The reset at field.
        /// </summary>
        [EnumMember(Value = "resetAt")]
        ResetAt,
    }

    /// <summary>
    /// The <see cref="Record">Record</see> fields.
    /// </summary>
    public enum RecordField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The <see cref="Recurrence">Recurrence</see> fields.
    /// </summary>
    public enum RecurrenceField
    {
        /// <summary>
        /// The calendar field.
        /// </summary>
        [EnumMember(Value = "calendar")]
        Calendar,
        /// <summary>
        /// The day field.
        /// </summary>
        [EnumMember(Value = "day")]
        Day,
        /// <summary>
        /// The day of month field.
        /// </summary>
        [EnumMember(Value = "dayOfMonth")]
        DayOfMonth,
        /// <summary>
        /// The day of week field.
        /// </summary>
        [EnumMember(Value = "dayOfWeek")]
        DayOfWeek,
        /// <summary>
        /// The day of week day field.
        /// </summary>
        [EnumMember(Value = "dayOfWeekDay")]
        DayOfWeekDay,
        /// <summary>
        /// The day of week index field.
        /// </summary>
        [EnumMember(Value = "dayOfWeekIndex")]
        DayOfWeekIndex,
        /// <summary>
        /// The disabled field.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// The end date field.
        /// </summary>
        [EnumMember(Value = "endDate")]
        EndDate,
        /// <summary>
        /// The frequency field.
        /// </summary>
        [EnumMember(Value = "frequency")]
        Frequency,
        /// <summary>
        /// The ical field.
        /// </summary>
        [EnumMember(Value = "ical")]
        Ical,
        /// <summary>
        /// The interval field.
        /// </summary>
        [EnumMember(Value = "interval")]
        Interval,
        /// <summary>
        /// The last occurrence at field.
        /// </summary>
        [EnumMember(Value = "lastOccurrenceAt")]
        LastOccurrenceAt,
        /// <summary>
        /// The last occurrence errors field.
        /// </summary>
        [EnumMember(Value = "lastOccurrenceErrors")]
        LastOccurrenceErrors,
        /// <summary>
        /// The month of year field.
        /// </summary>
        [EnumMember(Value = "monthOfYear")]
        MonthOfYear,
        /// <summary>
        /// The next occurrence at field.
        /// </summary>
        [EnumMember(Value = "nextOccurrenceAt")]
        NextOccurrenceAt,
        /// <summary>
        /// The start date field.
        /// </summary>
        [EnumMember(Value = "startDate")]
        StartDate,
        /// <summary>
        /// The time of day field.
        /// </summary>
        [EnumMember(Value = "timeOfDay")]
        TimeOfDay,
        /// <summary>
        /// The time zone field.
        /// </summary>
        [EnumMember(Value = "timeZone")]
        TimeZone,
    }

    /// <summary>
    /// The <see cref="RecurrenceTemplate">RecurrenceTemplate</see> fields.
    /// </summary>
    public enum RecurrenceTemplateField
    {
        /// <summary>
        /// The calendar field.
        /// </summary>
        [EnumMember(Value = "calendar")]
        Calendar,
        /// <summary>
        /// The day field.
        /// </summary>
        [EnumMember(Value = "day")]
        Day,
        /// <summary>
        /// The day of month field.
        /// </summary>
        [EnumMember(Value = "dayOfMonth")]
        DayOfMonth,
        /// <summary>
        /// The day of week field.
        /// </summary>
        [EnumMember(Value = "dayOfWeek")]
        DayOfWeek,
        /// <summary>
        /// The day of week day field.
        /// </summary>
        [EnumMember(Value = "dayOfWeekDay")]
        DayOfWeekDay,
        /// <summary>
        /// The day of week index field.
        /// </summary>
        [EnumMember(Value = "dayOfWeekIndex")]
        DayOfWeekIndex,
        /// <summary>
        /// The disabled field.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// The frequency field.
        /// </summary>
        [EnumMember(Value = "frequency")]
        Frequency,
        /// <summary>
        /// The interval field.
        /// </summary>
        [EnumMember(Value = "interval")]
        Interval,
        /// <summary>
        /// The month of year field.
        /// </summary>
        [EnumMember(Value = "monthOfYear")]
        MonthOfYear,
        /// <summary>
        /// The time of day field.
        /// </summary>
        [EnumMember(Value = "timeOfDay")]
        TimeOfDay,
        /// <summary>
        /// The time zone field.
        /// </summary>
        [EnumMember(Value = "timeZone")]
        TimeZone,
    }

    /// <summary>
    /// The <see cref="Release">Release</see> fields.
    /// </summary>
    public enum ReleaseField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The completed at field.
        /// </summary>
        [EnumMember(Value = "completedAt")]
        CompletedAt,
        /// <summary>
        /// The completion reason field.
        /// </summary>
        [EnumMember(Value = "completionReason")]
        CompletionReason,
        /// <summary>
        /// The completion target at field.
        /// </summary>
        [EnumMember(Value = "completionTargetAt")]
        CompletionTargetAt,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The custom fields field.
        /// </summary>
        [EnumMember(Value = "customFields")]
        CustomFields,
        /// <summary>
        /// The custom fields attachments field.
        /// </summary>
        [EnumMember(Value = "customFieldsAttachments")]
        CustomFieldsAttachments,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The impact field.
        /// </summary>
        [EnumMember(Value = "impact")]
        Impact,
        /// <summary>
        /// The life cycle state field.
        /// </summary>
        [EnumMember(Value = "lifeCycleState")]
        LifeCycleState,
        /// <summary>
        /// The manager field.
        /// </summary>
        [EnumMember(Value = "manager")]
        Manager,
        /// <summary>
        /// The notes field.
        /// </summary>
        [EnumMember(Value = "notes")]
        Notes,
        /// <summary>
        /// The release id field.
        /// </summary>
        [EnumMember(Value = "releaseId")]
        ReleaseId,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The status field.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,
        /// <summary>
        /// The subject field.
        /// </summary>
        [EnumMember(Value = "subject")]
        Subject,
        /// <summary>
        /// The ui extension field.
        /// </summary>
        [EnumMember(Value = "uiExtension")]
        UiExtension,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// The workflows field.
        /// </summary>
        [EnumMember(Value = "workflows")]
        Workflows,
    }

    /// <summary>
    /// The <see cref="Request">Request</see> fields.
    /// </summary>
    public enum RequestField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The addressed field.
        /// </summary>
        [EnumMember(Value = "addressed")]
        Addressed,
        /// <summary>
        /// The affected slas field.
        /// </summary>
        [EnumMember(Value = "affectedSlas")]
        AffectedSlas,
        /// <summary>
        /// The agile board field.
        /// </summary>
        [EnumMember(Value = "agileBoard")]
        AgileBoard,
        /// <summary>
        /// The agile board column field.
        /// </summary>
        [EnumMember(Value = "agileBoardColumn")]
        AgileBoardColumn,
        /// <summary>
        /// The agile board column position field.
        /// </summary>
        [EnumMember(Value = "agileBoardColumnPosition")]
        AgileBoardColumnPosition,
        /// <summary>
        /// The assignment count field.
        /// </summary>
        [EnumMember(Value = "assignmentCount")]
        AssignmentCount,
        /// <summary>
        /// The automation rules field.
        /// </summary>
        [EnumMember(Value = "automationRules")]
        AutomationRules,
        /// <summary>
        /// The category field.
        /// </summary>
        [EnumMember(Value = "category")]
        Category,
        /// <summary>
        /// The checked items field.
        /// </summary>
        [EnumMember(Value = "checkedItems")]
        CheckedItems,
        /// <summary>
        /// The completed at field.
        /// </summary>
        [EnumMember(Value = "completedAt")]
        CompletedAt,
        /// <summary>
        /// The completion reason field.
        /// </summary>
        [EnumMember(Value = "completionReason")]
        CompletionReason,
        /// <summary>
        /// The configuration items field.
        /// </summary>
        [EnumMember(Value = "configurationItems")]
        ConfigurationItems,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The created by field.
        /// </summary>
        [EnumMember(Value = "createdBy")]
        CreatedBy,
        /// <summary>
        /// The custom fields field.
        /// </summary>
        [EnumMember(Value = "customFields")]
        CustomFields,
        /// <summary>
        /// The custom fields attachments field.
        /// </summary>
        [EnumMember(Value = "customFieldsAttachments")]
        CustomFieldsAttachments,
        /// <summary>
        /// The desired completion at field.
        /// </summary>
        [EnumMember(Value = "desiredCompletionAt")]
        DesiredCompletionAt,
        /// <summary>
        /// The downtime end at field.
        /// </summary>
        [EnumMember(Value = "downtimeEndAt")]
        DowntimeEndAt,
        /// <summary>
        /// The downtime start at field.
        /// </summary>
        [EnumMember(Value = "downtimeStartAt")]
        DowntimeStartAt,
        /// <summary>
        /// The feedback field.
        /// </summary>
        [EnumMember(Value = "feedback")]
        Feedback,
        /// <summary>
        /// The grouped into field.
        /// </summary>
        [EnumMember(Value = "groupedInto")]
        GroupedInto,
        /// <summary>
        /// The grouped requests field.
        /// </summary>
        [EnumMember(Value = "groupedRequests")]
        GroupedRequests,
        /// <summary>
        /// The grouping field.
        /// </summary>
        [EnumMember(Value = "grouping")]
        Grouping,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The impact field.
        /// </summary>
        [EnumMember(Value = "impact")]
        Impact,
        /// <summary>
        /// The knowledge article field.
        /// </summary>        [Obsolete("Use `knowledgeArticles` instead.")]

        [EnumMember(Value = "knowledgeArticle")]
        KnowledgeArticle,
        /// <summary>
        /// The knowledge articles field.
        /// </summary>
        [EnumMember(Value = "knowledgeArticles")]
        KnowledgeArticles,
        /// <summary>
        /// The life cycle state field.
        /// </summary>
        [EnumMember(Value = "lifeCycleState")]
        LifeCycleState,
        /// <summary>
        /// The major incident status field.
        /// </summary>
        [EnumMember(Value = "majorIncidentStatus")]
        MajorIncidentStatus,
        /// <summary>
        /// The member field.
        /// </summary>
        [EnumMember(Value = "member")]
        Member,
        /// <summary>
        /// The next target at field.
        /// </summary>
        [EnumMember(Value = "nextTargetAt")]
        NextTargetAt,
        /// <summary>
        /// The notes field.
        /// </summary>
        [EnumMember(Value = "notes")]
        Notes,
        /// <summary>
        /// The organization field.
        /// </summary>
        [EnumMember(Value = "organization")]
        Organization,
        /// <summary>
        /// The planned effort field.
        /// </summary>
        [EnumMember(Value = "plannedEffort")]
        PlannedEffort,
        /// <summary>
        /// The problem field.
        /// </summary>
        [EnumMember(Value = "problem")]
        Problem,
        /// <summary>
        /// The product backlog field.
        /// </summary>
        [EnumMember(Value = "productBacklog")]
        ProductBacklog,
        /// <summary>
        /// The product backlog estimate field.
        /// </summary>
        [EnumMember(Value = "productBacklogEstimate")]
        ProductBacklogEstimate,
        /// <summary>
        /// The product backlog position field.
        /// </summary>
        [EnumMember(Value = "productBacklogPosition")]
        ProductBacklogPosition,
        /// <summary>
        /// The project field.
        /// </summary>
        [EnumMember(Value = "project")]
        Project,
        /// <summary>
        /// The provider not accountable field.
        /// </summary>
        [EnumMember(Value = "providerNotAccountable")]
        ProviderNotAccountable,
        /// <summary>
        /// The provider was not accountable field.
        /// </summary>
        [EnumMember(Value = "providerWasNotAccountable")]
        ProviderWasNotAccountable,
        /// <summary>
        /// The reopen count field.
        /// </summary>
        [EnumMember(Value = "reopenCount")]
        ReopenCount,
        /// <summary>
        /// The requested by field.
        /// </summary>
        [EnumMember(Value = "requestedBy")]
        RequestedBy,
        /// <summary>
        /// The requested for field.
        /// </summary>
        [EnumMember(Value = "requestedFor")]
        RequestedFor,
        /// <summary>
        /// The requester resolution target at field.
        /// </summary>
        [EnumMember(Value = "requesterResolutionTargetAt")]
        RequesterResolutionTargetAt,
        /// <summary>
        /// The request id field.
        /// </summary>
        [EnumMember(Value = "requestId")]
        RequestId,
        /// <summary>
        /// The resolution duration field.
        /// </summary>
        [EnumMember(Value = "resolutionDuration")]
        ResolutionDuration,
        /// <summary>
        /// The resolution target at field.
        /// </summary>
        [EnumMember(Value = "resolutionTargetAt")]
        ResolutionTargetAt,
        /// <summary>
        /// The response target at field.
        /// </summary>
        [EnumMember(Value = "responseTargetAt")]
        ResponseTargetAt,
        /// <summary>
        /// The reviewed field.
        /// </summary>
        [EnumMember(Value = "reviewed")]
        Reviewed,
        /// <summary>
        /// The satisfaction field.
        /// </summary>
        [EnumMember(Value = "satisfaction")]
        Satisfaction,
        /// <summary>
        /// The satisfaction at field.
        /// </summary>
        [EnumMember(Value = "satisfactionAt")]
        SatisfactionAt,
        /// <summary>
        /// The service instance field.
        /// </summary>
        [EnumMember(Value = "serviceInstance")]
        ServiceInstance,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The sprint backlog items field.
        /// </summary>
        [EnumMember(Value = "sprintBacklogItems")]
        SprintBacklogItems,
        /// <summary>
        /// The status field.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,
        /// <summary>
        /// The subject field.
        /// </summary>
        [EnumMember(Value = "subject")]
        Subject,
        /// <summary>
        /// The supplier field.
        /// </summary>
        [EnumMember(Value = "supplier")]
        Supplier,
        /// <summary>
        /// The supplier request id field.
        /// </summary>
        [EnumMember(Value = "supplierRequestID")]
        SupplierRequestID,
        /// <summary>
        /// The task field.
        /// </summary>
        [EnumMember(Value = "task")]
        Task,
        /// <summary>
        /// The team field.
        /// </summary>
        [EnumMember(Value = "team")]
        Team,
        /// <summary>
        /// The template field.
        /// </summary>
        [EnumMember(Value = "template")]
        Template,
        /// <summary>
        /// The time entries field.
        /// </summary>
        [EnumMember(Value = "timeEntries")]
        TimeEntries,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// The urgent field.
        /// </summary>
        [EnumMember(Value = "urgent")]
        Urgent,
        /// <summary>
        /// The waiting until field.
        /// </summary>
        [EnumMember(Value = "waitingUntil")]
        WaitingUntil,
        /// <summary>
        /// The watches field.
        /// </summary>
        [EnumMember(Value = "watches")]
        Watches,
        /// <summary>
        /// The workflow field.
        /// </summary>
        [EnumMember(Value = "workflow")]
        Workflow,
    }

    /// <summary>
    /// The <see cref="RequestTemplate">RequestTemplate</see> fields.
    /// </summary>
    public enum RequestTemplateField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The asset selection field.
        /// </summary>
        [EnumMember(Value = "assetSelection")]
        AssetSelection,
        /// <summary>
        /// The assign after workflow completion field.
        /// </summary>
        [EnumMember(Value = "assignAfterWorkflowCompletion")]
        AssignAfterWorkflowCompletion,
        /// <summary>
        /// The assign to self field.
        /// </summary>
        [EnumMember(Value = "assignToSelf")]
        AssignToSelf,
        /// <summary>
        /// The automation rules field.
        /// </summary>
        [EnumMember(Value = "automationRules")]
        AutomationRules,
        /// <summary>
        /// The category field.
        /// </summary>
        [EnumMember(Value = "category")]
        Category,
        /// <summary>
        /// The completion reason field.
        /// </summary>
        [EnumMember(Value = "completionReason")]
        CompletionReason,
        /// <summary>
        /// The configuration item field.
        /// </summary>
        [EnumMember(Value = "configurationItem")]
        ConfigurationItem,
        /// <summary>
        /// The copy subject to requests field.
        /// </summary>
        [EnumMember(Value = "copySubjectToRequests")]
        CopySubjectToRequests,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The desired completion field.
        /// </summary>
        [EnumMember(Value = "desiredCompletion")]
        DesiredCompletion,
        /// <summary>
        /// The disabled field.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// The effort class field.
        /// </summary>
        [EnumMember(Value = "effortClass")]
        EffortClass,
        /// <summary>
        /// The end users field.
        /// </summary>
        [EnumMember(Value = "endUsers")]
        EndUsers,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The impact field.
        /// </summary>
        [EnumMember(Value = "impact")]
        Impact,
        /// <summary>
        /// The instructions field.
        /// </summary>
        [EnumMember(Value = "instructions")]
        Instructions,
        /// <summary>
        /// The instructions attachments field.
        /// </summary>
        [EnumMember(Value = "instructionsAttachments")]
        InstructionsAttachments,
        /// <summary>
        /// The keywords field.
        /// </summary>
        [EnumMember(Value = "keywords")]
        Keywords,
        /// <summary>
        /// The member field.
        /// </summary>
        [EnumMember(Value = "member")]
        Member,
        /// <summary>
        /// The note field.
        /// </summary>
        [EnumMember(Value = "note")]
        Note,
        /// <summary>
        /// The note attachments field.
        /// </summary>
        [EnumMember(Value = "noteAttachments")]
        NoteAttachments,
        /// <summary>
        /// The organizations field.
        /// </summary>
        [EnumMember(Value = "organizations")]
        Organizations,
        /// <summary>
        /// The planned effort field.
        /// </summary>
        [EnumMember(Value = "plannedEffort")]
        PlannedEffort,
        /// <summary>
        /// The registration hints field.
        /// </summary>
        [EnumMember(Value = "registrationHints")]
        RegistrationHints,
        /// <summary>
        /// The registration hints attachments field.
        /// </summary>
        [EnumMember(Value = "registrationHintsAttachments")]
        RegistrationHintsAttachments,
        /// <summary>
        /// The requests field.
        /// </summary>
        [EnumMember(Value = "requests")]
        Requests,
        /// <summary>
        /// The reservation offerings field.
        /// </summary>
        [EnumMember(Value = "reservationOfferings")]
        ReservationOfferings,
        /// <summary>
        /// The service field.
        /// </summary>
        [EnumMember(Value = "service")]
        Service,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The specialists field.
        /// </summary>
        [EnumMember(Value = "specialists")]
        Specialists,
        /// <summary>
        /// The standard service requests field.
        /// </summary>
        [EnumMember(Value = "standardServiceRequests")]
        StandardServiceRequests,
        /// <summary>
        /// The status field.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,
        /// <summary>
        /// The subject field.
        /// </summary>
        [EnumMember(Value = "subject")]
        Subject,
        /// <summary>
        /// The supplier field.
        /// </summary>
        [EnumMember(Value = "supplier")]
        Supplier,
        /// <summary>
        /// The support hours field.
        /// </summary>
        [EnumMember(Value = "supportHours")]
        SupportHours,
        /// <summary>
        /// The team field.
        /// </summary>
        [EnumMember(Value = "team")]
        Team,
        /// <summary>
        /// The time zone field.
        /// </summary>
        [EnumMember(Value = "timeZone")]
        TimeZone,
        /// <summary>
        /// The translations field.
        /// </summary>
        [EnumMember(Value = "translations")]
        Translations,
        /// <summary>
        /// The ui extension field.
        /// </summary>
        [EnumMember(Value = "uiExtension")]
        UiExtension,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// The urgent field.
        /// </summary>
        [EnumMember(Value = "urgent")]
        Urgent,
        /// <summary>
        /// The workflow manager field.
        /// </summary>
        [EnumMember(Value = "workflowManager")]
        WorkflowManager,
        /// <summary>
        /// The workflow template field.
        /// </summary>
        [EnumMember(Value = "workflowTemplate")]
        WorkflowTemplate,
    }

    /// <summary>
    /// The <see cref="Reservation">Reservation</see> fields.
    /// </summary>
    public enum ReservationField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The configuration item field.
        /// </summary>
        [EnumMember(Value = "configurationItem")]
        ConfigurationItem,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The created by field.
        /// </summary>
        [EnumMember(Value = "createdBy")]
        CreatedBy,
        /// <summary>
        /// The description field.
        /// </summary>
        [EnumMember(Value = "description")]
        Description,
        /// <summary>
        /// The description attachments field.
        /// </summary>
        [EnumMember(Value = "descriptionAttachments")]
        DescriptionAttachments,
        /// <summary>
        /// The duration field.
        /// </summary>
        [EnumMember(Value = "duration")]
        Duration,
        /// <summary>
        /// The end at field.
        /// </summary>
        [EnumMember(Value = "endAt")]
        EndAt,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The name field.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// The only this occurrence field.
        /// </summary>
        [EnumMember(Value = "onlyThisOccurrence")]
        OnlyThisOccurrence,
        /// <summary>
        /// The person field.
        /// </summary>
        [EnumMember(Value = "person")]
        Person,
        /// <summary>
        /// The preparation start at field.
        /// </summary>
        [EnumMember(Value = "preparationStartAt")]
        PreparationStartAt,
        /// <summary>
        /// The recurrence field.
        /// </summary>
        [EnumMember(Value = "recurrence")]
        Recurrence,
        /// <summary>
        /// The request field.
        /// </summary>
        [EnumMember(Value = "request")]
        Request,
        /// <summary>
        /// The reservation offering field.
        /// </summary>
        [EnumMember(Value = "reservationOffering")]
        ReservationOffering,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The start at field.
        /// </summary>
        [EnumMember(Value = "startAt")]
        StartAt,
        /// <summary>
        /// The status field.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The <see cref="ReservationOffering">ReservationOffering</see> fields.
    /// </summary>
    public enum ReservationOfferingField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The allow repeat field.
        /// </summary>
        [EnumMember(Value = "allowRepeat")]
        AllowRepeat,
        /// <summary>
        /// The calendar field.
        /// </summary>
        [EnumMember(Value = "calendar")]
        Calendar,
        /// <summary>
        /// The configuration items field.
        /// </summary>
        [EnumMember(Value = "configurationItems")]
        ConfigurationItems,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The disabled field.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// The filters field.
        /// </summary>
        [EnumMember(Value = "filters")]
        Filters,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The initial status field.
        /// </summary>
        [EnumMember(Value = "initialStatus")]
        InitialStatus,
        /// <summary>
        /// The max advance duration field.
        /// </summary>
        [EnumMember(Value = "maxAdvanceDuration")]
        MaxAdvanceDuration,
        /// <summary>
        /// The max duration field.
        /// </summary>
        [EnumMember(Value = "maxDuration")]
        MaxDuration,
        /// <summary>
        /// The min advance duration field.
        /// </summary>
        [EnumMember(Value = "minAdvanceDuration")]
        MinAdvanceDuration,
        /// <summary>
        /// The min duration field.
        /// </summary>
        [EnumMember(Value = "minDuration")]
        MinDuration,
        /// <summary>
        /// The multi day field.
        /// </summary>
        [EnumMember(Value = "multiDay")]
        MultiDay,
        /// <summary>
        /// The name field.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// The preparation duration field.
        /// </summary>
        [EnumMember(Value = "preparationDuration")]
        PreparationDuration,
        /// <summary>
        /// The private reservations field.
        /// </summary>
        [EnumMember(Value = "privateReservations")]
        PrivateReservations,
        /// <summary>
        /// The request templates field.
        /// </summary>
        [EnumMember(Value = "requestTemplates")]
        RequestTemplates,
        /// <summary>
        /// The service instance field.
        /// </summary>
        [EnumMember(Value = "serviceInstance")]
        ServiceInstance,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The step duration field.
        /// </summary>
        [EnumMember(Value = "stepDuration")]
        StepDuration,
        /// <summary>
        /// The time zone field.
        /// </summary>
        [EnumMember(Value = "timeZone")]
        TimeZone,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The <see cref="Risk">Risk</see> fields.
    /// </summary>
    public enum RiskField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The closed at field.
        /// </summary>
        [EnumMember(Value = "closedAt")]
        ClosedAt,
        /// <summary>
        /// The closure reason field.
        /// </summary>
        [EnumMember(Value = "closureReason")]
        ClosureReason,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The custom fields field.
        /// </summary>
        [EnumMember(Value = "customFields")]
        CustomFields,
        /// <summary>
        /// The custom fields attachments field.
        /// </summary>
        [EnumMember(Value = "customFieldsAttachments")]
        CustomFieldsAttachments,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The life cycle state field.
        /// </summary>
        [EnumMember(Value = "lifeCycleState")]
        LifeCycleState,
        /// <summary>
        /// The manager field.
        /// </summary>
        [EnumMember(Value = "manager")]
        Manager,
        /// <summary>
        /// The mitigation target at field.
        /// </summary>
        [EnumMember(Value = "mitigationTargetAt")]
        MitigationTargetAt,
        /// <summary>
        /// The notes field.
        /// </summary>
        [EnumMember(Value = "notes")]
        Notes,
        /// <summary>
        /// The organizations field.
        /// </summary>
        [EnumMember(Value = "organizations")]
        Organizations,
        /// <summary>
        /// The projects field.
        /// </summary>
        [EnumMember(Value = "projects")]
        Projects,
        /// <summary>
        /// The resolution duration field.
        /// </summary>
        [EnumMember(Value = "resolutionDuration")]
        ResolutionDuration,
        /// <summary>
        /// The risk id field.
        /// </summary>
        [EnumMember(Value = "riskId")]
        RiskId,
        /// <summary>
        /// The services field.
        /// </summary>
        [EnumMember(Value = "services")]
        Services,
        /// <summary>
        /// The severity field.
        /// </summary>
        [EnumMember(Value = "severity")]
        Severity,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The status field.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,
        /// <summary>
        /// The subject field.
        /// </summary>
        [EnumMember(Value = "subject")]
        Subject,
        /// <summary>
        /// The ui extension field.
        /// </summary>
        [EnumMember(Value = "uiExtension")]
        UiExtension,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The <see cref="RiskSeverity">RiskSeverity</see> fields.
    /// </summary>
    public enum RiskSeverityField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The description field.
        /// </summary>
        [EnumMember(Value = "description")]
        Description,
        /// <summary>
        /// The disabled field.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The information field.
        /// </summary>
        [EnumMember(Value = "information")]
        Information,
        /// <summary>
        /// The information attachments field.
        /// </summary>
        [EnumMember(Value = "informationAttachments")]
        InformationAttachments,
        /// <summary>
        /// The name field.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// The position field.
        /// </summary>
        [EnumMember(Value = "position")]
        Position,
        /// <summary>
        /// The reference field.
        /// </summary>
        [EnumMember(Value = "reference")]
        Reference,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The translations field.
        /// </summary>
        [EnumMember(Value = "translations")]
        Translations,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The <see cref="ScrumWorkspace">ScrumWorkspace</see> fields.
    /// </summary>
    public enum ScrumWorkspaceField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The agile board field.
        /// </summary>
        [EnumMember(Value = "agileBoard")]
        AgileBoard,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The description field.
        /// </summary>
        [EnumMember(Value = "description")]
        Description,
        /// <summary>
        /// The description attachments field.
        /// </summary>
        [EnumMember(Value = "descriptionAttachments")]
        DescriptionAttachments,
        /// <summary>
        /// The disabled field.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The name field.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// The picture uri field.
        /// </summary>
        [EnumMember(Value = "pictureUri")]
        PictureUri,
        /// <summary>
        /// The product backlog field.
        /// </summary>
        [EnumMember(Value = "productBacklog")]
        ProductBacklog,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The sprint length field.
        /// </summary>
        [EnumMember(Value = "sprintLength")]
        SprintLength,
        /// <summary>
        /// The sprints field.
        /// </summary>
        [EnumMember(Value = "sprints")]
        Sprints,
        /// <summary>
        /// The team field.
        /// </summary>
        [EnumMember(Value = "team")]
        Team,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The <see cref="Service">Service</see> fields.
    /// </summary>
    public enum ServiceField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The availability manager field.
        /// </summary>
        [EnumMember(Value = "availabilityManager")]
        AvailabilityManager,
        /// <summary>
        /// The capacity manager field.
        /// </summary>
        [EnumMember(Value = "capacityManager")]
        CapacityManager,
        /// <summary>
        /// The change manager field.
        /// </summary>
        [EnumMember(Value = "changeManager")]
        ChangeManager,
        /// <summary>
        /// The continuity manager field.
        /// </summary>
        [EnumMember(Value = "continuityManager")]
        ContinuityManager,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The custom fields field.
        /// </summary>
        [EnumMember(Value = "customFields")]
        CustomFields,
        /// <summary>
        /// The custom fields attachments field.
        /// </summary>
        [EnumMember(Value = "customFieldsAttachments")]
        CustomFieldsAttachments,
        /// <summary>
        /// The description field.
        /// </summary>
        [EnumMember(Value = "description")]
        Description,
        /// <summary>
        /// The description attachments field.
        /// </summary>
        [EnumMember(Value = "descriptionAttachments")]
        DescriptionAttachments,
        /// <summary>
        /// The disabled field.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// The first line team field.
        /// </summary>
        [EnumMember(Value = "firstLineTeam")]
        FirstLineTeam,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The keywords field.
        /// </summary>
        [EnumMember(Value = "keywords")]
        Keywords,
        /// <summary>
        /// The knowledge manager field.
        /// </summary>
        [EnumMember(Value = "knowledgeManager")]
        KnowledgeManager,
        /// <summary>
        /// The name field.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// The picture uri field.
        /// </summary>
        [EnumMember(Value = "pictureUri")]
        PictureUri,
        /// <summary>
        /// The problem manager field.
        /// </summary>
        [EnumMember(Value = "problemManager")]
        ProblemManager,
        /// <summary>
        /// The release manager field.
        /// </summary>
        [EnumMember(Value = "releaseManager")]
        ReleaseManager,
        /// <summary>
        /// The service instances field.
        /// </summary>
        [EnumMember(Value = "serviceInstances")]
        ServiceInstances,
        /// <summary>
        /// The service level agreements field.
        /// </summary>
        [EnumMember(Value = "serviceLevelAgreements")]
        ServiceLevelAgreements,
        /// <summary>
        /// The service offerings field.
        /// </summary>
        [EnumMember(Value = "serviceOfferings")]
        ServiceOfferings,
        /// <summary>
        /// The service owner field.
        /// </summary>
        [EnumMember(Value = "serviceOwner")]
        ServiceOwner,
        /// <summary>
        /// The service provider field.
        /// </summary>
        [EnumMember(Value = "serviceProvider")]
        ServiceProvider,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The support team field.
        /// </summary>
        [EnumMember(Value = "supportTeam")]
        SupportTeam,
        /// <summary>
        /// The survey field.
        /// </summary>
        [EnumMember(Value = "survey")]
        Survey,
        /// <summary>
        /// The translations field.
        /// </summary>
        [EnumMember(Value = "translations")]
        Translations,
        /// <summary>
        /// The ui extension field.
        /// </summary>
        [EnumMember(Value = "uiExtension")]
        UiExtension,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The <see cref="ServiceCategory">ServiceCategory</see> fields.
    /// </summary>
    public enum ServiceCategoryField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The description field.
        /// </summary>
        [EnumMember(Value = "description")]
        Description,
        /// <summary>
        /// The description attachments field.
        /// </summary>
        [EnumMember(Value = "descriptionAttachments")]
        DescriptionAttachments,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The name field.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// The picture uri field.
        /// </summary>
        [EnumMember(Value = "pictureUri")]
        PictureUri,
        /// <summary>
        /// The services field.
        /// </summary>
        [EnumMember(Value = "services")]
        Services,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The translations field.
        /// </summary>
        [EnumMember(Value = "translations")]
        Translations,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The <see cref="ServiceInstance">ServiceInstance</see> fields.
    /// </summary>
    public enum ServiceInstanceField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The child service instances field.
        /// </summary>
        [EnumMember(Value = "childServiceInstances")]
        ChildServiceInstances,
        /// <summary>
        /// The configuration items field.
        /// </summary>
        [EnumMember(Value = "configurationItems")]
        ConfigurationItems,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The custom fields field.
        /// </summary>
        [EnumMember(Value = "customFields")]
        CustomFields,
        /// <summary>
        /// The custom fields attachments field.
        /// </summary>
        [EnumMember(Value = "customFieldsAttachments")]
        CustomFieldsAttachments,
        /// <summary>
        /// The first line team field.
        /// </summary>
        [EnumMember(Value = "firstLineTeam")]
        FirstLineTeam,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The name field.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// The parent service instances field.
        /// </summary>
        [EnumMember(Value = "parentServiceInstances")]
        ParentServiceInstances,
        /// <summary>
        /// The picture uri field.
        /// </summary>
        [EnumMember(Value = "pictureUri")]
        PictureUri,
        /// <summary>
        /// The remarks field.
        /// </summary>
        [EnumMember(Value = "remarks")]
        Remarks,
        /// <summary>
        /// The remarks attachments field.
        /// </summary>
        [EnumMember(Value = "remarksAttachments")]
        RemarksAttachments,
        /// <summary>
        /// The service field.
        /// </summary>
        [EnumMember(Value = "service")]
        Service,
        /// <summary>
        /// The service level agreements field.
        /// </summary>
        [EnumMember(Value = "serviceLevelAgreements")]
        ServiceLevelAgreements,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The status field.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,
        /// <summary>
        /// The support team field.
        /// </summary>
        [EnumMember(Value = "supportTeam")]
        SupportTeam,
        /// <summary>
        /// The translations field.
        /// </summary>
        [EnumMember(Value = "translations")]
        Translations,
        /// <summary>
        /// The ui extension field.
        /// </summary>
        [EnumMember(Value = "uiExtension")]
        UiExtension,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The <see cref="ServiceLevelAgreement">ServiceLevelAgreement</see> fields.
    /// </summary>
    public enum ServiceLevelAgreementField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The activity id field.
        /// </summary>
        [EnumMember(Value = "activityID")]
        ActivityID,
        /// <summary>
        /// The agreement id field.
        /// </summary>
        [EnumMember(Value = "agreementID")]
        AgreementID,
        /// <summary>
        /// The coverage field.
        /// </summary>
        [EnumMember(Value = "coverage")]
        Coverage,
        /// <summary>
        /// The coverage groups field.
        /// </summary>
        [EnumMember(Value = "coverageGroups")]
        CoverageGroups,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The customer field.
        /// </summary>
        [EnumMember(Value = "customer")]
        Customer,
        /// <summary>
        /// The customer account field.
        /// </summary>
        [EnumMember(Value = "customerAccount")]
        CustomerAccount,
        /// <summary>
        /// The customer representatives field.
        /// </summary>
        [EnumMember(Value = "customerRepresentatives")]
        CustomerRepresentatives,
        /// <summary>
        /// The effort class rate ids field.
        /// </summary>
        [EnumMember(Value = "effortClassRateIDs")]
        EffortClassRateIDs,
        /// <summary>
        /// The expiry date field.
        /// </summary>
        [EnumMember(Value = "expiryDate")]
        ExpiryDate,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The invoices field.
        /// </summary>
        [EnumMember(Value = "invoices")]
        Invoices,
        /// <summary>
        /// The name field.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// The notice date field.
        /// </summary>
        [EnumMember(Value = "noticeDate")]
        NoticeDate,
        /// <summary>
        /// The organizations field.
        /// </summary>
        [EnumMember(Value = "organizations")]
        Organizations,
        /// <summary>
        /// The people field.
        /// </summary>
        [EnumMember(Value = "people")]
        People,
        /// <summary>
        /// The remarks field.
        /// </summary>
        [EnumMember(Value = "remarks")]
        Remarks,
        /// <summary>
        /// The remarks attachments field.
        /// </summary>
        [EnumMember(Value = "remarksAttachments")]
        RemarksAttachments,
        /// <summary>
        /// The service instance field.
        /// </summary>
        [EnumMember(Value = "serviceInstance")]
        ServiceInstance,
        /// <summary>
        /// The service instances field.
        /// </summary>
        [EnumMember(Value = "serviceInstances")]
        ServiceInstances,
        /// <summary>
        /// The service level manager field.
        /// </summary>
        [EnumMember(Value = "serviceLevelManager")]
        ServiceLevelManager,
        /// <summary>
        /// The service offering field.
        /// </summary>
        [EnumMember(Value = "serviceOffering")]
        ServiceOffering,
        /// <summary>
        /// The sites field.
        /// </summary>
        [EnumMember(Value = "sites")]
        Sites,
        /// <summary>
        /// The skill pools field.
        /// </summary>
        [EnumMember(Value = "skillPools")]
        SkillPools,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The standard service request activity ids field.
        /// </summary>
        [EnumMember(Value = "standardServiceRequestActivityIDs")]
        StandardServiceRequestActivityIDs,
        /// <summary>
        /// The start date field.
        /// </summary>
        [EnumMember(Value = "startDate")]
        StartDate,
        /// <summary>
        /// The status field.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,
        /// <summary>
        /// The support domain field.
        /// </summary>
        [EnumMember(Value = "supportDomain")]
        SupportDomain,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// The use knowledge from service provider field.
        /// </summary>
        [EnumMember(Value = "useKnowledgeFromServiceProvider")]
        UseKnowledgeFromServiceProvider,
    }

    /// <summary>
    /// The <see cref="ServiceOffering">ServiceOffering</see> fields.
    /// </summary>
    public enum ServiceOfferingField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The availability field.
        /// </summary>
        [EnumMember(Value = "availability")]
        Availability,
        /// <summary>
        /// The charges field.
        /// </summary>
        [EnumMember(Value = "charges")]
        Charges,
        /// <summary>
        /// The charges attachments field.
        /// </summary>
        [EnumMember(Value = "chargesAttachments")]
        ChargesAttachments,
        /// <summary>
        /// The charge type case field.
        /// </summary>
        [EnumMember(Value = "chargeTypeCase")]
        ChargeTypeCase,
        /// <summary>
        /// The charge type high field.
        /// </summary>
        [EnumMember(Value = "chargeTypeHigh")]
        ChargeTypeHigh,
        /// <summary>
        /// The charge type low field.
        /// </summary>
        [EnumMember(Value = "chargeTypeLow")]
        ChargeTypeLow,
        /// <summary>
        /// The charge type medium field.
        /// </summary>
        [EnumMember(Value = "chargeTypeMedium")]
        ChargeTypeMedium,
        /// <summary>
        /// The charge type rfc field.
        /// </summary>
        [EnumMember(Value = "chargeTypeRfc")]
        ChargeTypeRfc,
        /// <summary>
        /// The charge type rfi field.
        /// </summary>
        [EnumMember(Value = "chargeTypeRfi")]
        ChargeTypeRfi,
        /// <summary>
        /// The charge type top field.
        /// </summary>
        [EnumMember(Value = "chargeTypeTop")]
        ChargeTypeTop,
        /// <summary>
        /// The continuity field.
        /// </summary>
        [EnumMember(Value = "continuity")]
        Continuity,
        /// <summary>
        /// The continuity attachments field.
        /// </summary>
        [EnumMember(Value = "continuityAttachments")]
        ContinuityAttachments,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The default effort class field.
        /// </summary>
        [EnumMember(Value = "defaultEffortClass")]
        DefaultEffortClass,
        /// <summary>
        /// The effort classes field.
        /// </summary>
        [EnumMember(Value = "effortClasses")]
        EffortClasses,
        /// <summary>
        /// The effort class rates field.
        /// </summary>
        [EnumMember(Value = "effortClassRates")]
        EffortClassRates,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The limitations field.
        /// </summary>
        [EnumMember(Value = "limitations")]
        Limitations,
        /// <summary>
        /// The limitations attachments field.
        /// </summary>
        [EnumMember(Value = "limitationsAttachments")]
        LimitationsAttachments,
        /// <summary>
        /// The name field.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// The penalties field.
        /// </summary>
        [EnumMember(Value = "penalties")]
        Penalties,
        /// <summary>
        /// The penalties attachments field.
        /// </summary>
        [EnumMember(Value = "penaltiesAttachments")]
        PenaltiesAttachments,
        /// <summary>
        /// The performance field.
        /// </summary>
        [EnumMember(Value = "performance")]
        Performance,
        /// <summary>
        /// The performance attachments field.
        /// </summary>
        [EnumMember(Value = "performanceAttachments")]
        PerformanceAttachments,
        /// <summary>
        /// The prerequisites field.
        /// </summary>
        [EnumMember(Value = "prerequisites")]
        Prerequisites,
        /// <summary>
        /// The prerequisites attachments field.
        /// </summary>
        [EnumMember(Value = "prerequisitesAttachments")]
        PrerequisitesAttachments,
        /// <summary>
        /// The rate case field.
        /// </summary>
        [EnumMember(Value = "rateCase")]
        RateCase,
        /// <summary>
        /// The rate case currency field.
        /// </summary>
        [EnumMember(Value = "rateCaseCurrency")]
        RateCaseCurrency,
        /// <summary>
        /// The rate high field.
        /// </summary>
        [EnumMember(Value = "rateHigh")]
        RateHigh,
        /// <summary>
        /// The rate high currency field.
        /// </summary>
        [EnumMember(Value = "rateHighCurrency")]
        RateHighCurrency,
        /// <summary>
        /// The rate low field.
        /// </summary>
        [EnumMember(Value = "rateLow")]
        RateLow,
        /// <summary>
        /// The rate low currency field.
        /// </summary>
        [EnumMember(Value = "rateLowCurrency")]
        RateLowCurrency,
        /// <summary>
        /// The rate medium field.
        /// </summary>
        [EnumMember(Value = "rateMedium")]
        RateMedium,
        /// <summary>
        /// The rate medium currency field.
        /// </summary>
        [EnumMember(Value = "rateMediumCurrency")]
        RateMediumCurrency,
        /// <summary>
        /// The rate rfc field.
        /// </summary>
        [EnumMember(Value = "rateRfc")]
        RateRfc,
        /// <summary>
        /// The rate rfc currency field.
        /// </summary>
        [EnumMember(Value = "rateRfcCurrency")]
        RateRfcCurrency,
        /// <summary>
        /// The rate rfi field.
        /// </summary>
        [EnumMember(Value = "rateRfi")]
        RateRfi,
        /// <summary>
        /// The rate rfi currency field.
        /// </summary>
        [EnumMember(Value = "rateRfiCurrency")]
        RateRfiCurrency,
        /// <summary>
        /// The rate top field.
        /// </summary>
        [EnumMember(Value = "rateTop")]
        RateTop,
        /// <summary>
        /// The rate top currency field.
        /// </summary>
        [EnumMember(Value = "rateTopCurrency")]
        RateTopCurrency,
        /// <summary>
        /// The recovery point objective field.
        /// </summary>
        [EnumMember(Value = "recoveryPointObjective")]
        RecoveryPointObjective,
        /// <summary>
        /// The recovery time objective field.
        /// </summary>
        [EnumMember(Value = "recoveryTimeObjective")]
        RecoveryTimeObjective,
        /// <summary>
        /// The reliability field.
        /// </summary>
        [EnumMember(Value = "reliability")]
        Reliability,
        /// <summary>
        /// The report frequency field.
        /// </summary>
        [EnumMember(Value = "reportFrequency")]
        ReportFrequency,
        /// <summary>
        /// The resolutions within target field.
        /// </summary>
        [EnumMember(Value = "resolutionsWithinTarget")]
        ResolutionsWithinTarget,
        /// <summary>
        /// The resolution target case field.
        /// </summary>
        [EnumMember(Value = "resolutionTargetCase")]
        ResolutionTargetCase,
        /// <summary>
        /// The resolution target case in days field.
        /// </summary>
        [EnumMember(Value = "resolutionTargetCaseInDays")]
        ResolutionTargetCaseInDays,
        /// <summary>
        /// The resolution target high field.
        /// </summary>
        [EnumMember(Value = "resolutionTargetHigh")]
        ResolutionTargetHigh,
        /// <summary>
        /// The resolution target high in days field.
        /// </summary>
        [EnumMember(Value = "resolutionTargetHighInDays")]
        ResolutionTargetHighInDays,
        /// <summary>
        /// The resolution target low field.
        /// </summary>
        [EnumMember(Value = "resolutionTargetLow")]
        ResolutionTargetLow,
        /// <summary>
        /// The resolution target low in days field.
        /// </summary>
        [EnumMember(Value = "resolutionTargetLowInDays")]
        ResolutionTargetLowInDays,
        /// <summary>
        /// The resolution target medium field.
        /// </summary>
        [EnumMember(Value = "resolutionTargetMedium")]
        ResolutionTargetMedium,
        /// <summary>
        /// The resolution target medium in days field.
        /// </summary>
        [EnumMember(Value = "resolutionTargetMediumInDays")]
        ResolutionTargetMediumInDays,
        /// <summary>
        /// The resolution target rfc field.
        /// </summary>
        [EnumMember(Value = "resolutionTargetRfc")]
        ResolutionTargetRfc,
        /// <summary>
        /// The resolution target rfc in days field.
        /// </summary>
        [EnumMember(Value = "resolutionTargetRfcInDays")]
        ResolutionTargetRfcInDays,
        /// <summary>
        /// The resolution target rfi field.
        /// </summary>
        [EnumMember(Value = "resolutionTargetRfi")]
        ResolutionTargetRfi,
        /// <summary>
        /// The resolution target rfi in days field.
        /// </summary>
        [EnumMember(Value = "resolutionTargetRfiInDays")]
        ResolutionTargetRfiInDays,
        /// <summary>
        /// The resolution target top field.
        /// </summary>
        [EnumMember(Value = "resolutionTargetTop")]
        ResolutionTargetTop,
        /// <summary>
        /// The resolution target top in days field.
        /// </summary>
        [EnumMember(Value = "resolutionTargetTopInDays")]
        ResolutionTargetTopInDays,
        /// <summary>
        /// The responses within target field.
        /// </summary>
        [EnumMember(Value = "responsesWithinTarget")]
        ResponsesWithinTarget,
        /// <summary>
        /// The response target case field.
        /// </summary>
        [EnumMember(Value = "responseTargetCase")]
        ResponseTargetCase,
        /// <summary>
        /// The response target case in days field.
        /// </summary>
        [EnumMember(Value = "responseTargetCaseInDays")]
        ResponseTargetCaseInDays,
        /// <summary>
        /// The response target high field.
        /// </summary>
        [EnumMember(Value = "responseTargetHigh")]
        ResponseTargetHigh,
        /// <summary>
        /// The response target high in days field.
        /// </summary>
        [EnumMember(Value = "responseTargetHighInDays")]
        ResponseTargetHighInDays,
        /// <summary>
        /// The response target low field.
        /// </summary>
        [EnumMember(Value = "responseTargetLow")]
        ResponseTargetLow,
        /// <summary>
        /// The response target low in days field.
        /// </summary>
        [EnumMember(Value = "responseTargetLowInDays")]
        ResponseTargetLowInDays,
        /// <summary>
        /// The response target medium field.
        /// </summary>
        [EnumMember(Value = "responseTargetMedium")]
        ResponseTargetMedium,
        /// <summary>
        /// The response target medium in days field.
        /// </summary>
        [EnumMember(Value = "responseTargetMediumInDays")]
        ResponseTargetMediumInDays,
        /// <summary>
        /// The response target rfc field.
        /// </summary>
        [EnumMember(Value = "responseTargetRfc")]
        ResponseTargetRfc,
        /// <summary>
        /// The response target rfc in days field.
        /// </summary>
        [EnumMember(Value = "responseTargetRfcInDays")]
        ResponseTargetRfcInDays,
        /// <summary>
        /// The response target rfi field.
        /// </summary>
        [EnumMember(Value = "responseTargetRfi")]
        ResponseTargetRfi,
        /// <summary>
        /// The response target rfi in days field.
        /// </summary>
        [EnumMember(Value = "responseTargetRfiInDays")]
        ResponseTargetRfiInDays,
        /// <summary>
        /// The response target top field.
        /// </summary>
        [EnumMember(Value = "responseTargetTop")]
        ResponseTargetTop,
        /// <summary>
        /// The response target top in days field.
        /// </summary>
        [EnumMember(Value = "responseTargetTopInDays")]
        ResponseTargetTopInDays,
        /// <summary>
        /// The review frequency field.
        /// </summary>
        [EnumMember(Value = "reviewFrequency")]
        ReviewFrequency,
        /// <summary>
        /// The service field.
        /// </summary>
        [EnumMember(Value = "service")]
        Service,
        /// <summary>
        /// The service hours field.
        /// </summary>
        [EnumMember(Value = "serviceHours")]
        ServiceHours,
        /// <summary>
        /// The service level agreements field.
        /// </summary>
        [EnumMember(Value = "serviceLevelAgreements")]
        ServiceLevelAgreements,
        /// <summary>
        /// The shop articles field.
        /// </summary>
        [EnumMember(Value = "shopArticles")]
        ShopArticles,
        /// <summary>
        /// The sla notification scheme high field.
        /// </summary>
        [EnumMember(Value = "slaNotificationSchemeHigh")]
        SlaNotificationSchemeHigh,
        /// <summary>
        /// The sla notification scheme low field.
        /// </summary>
        [EnumMember(Value = "slaNotificationSchemeLow")]
        SlaNotificationSchemeLow,
        /// <summary>
        /// The sla notification scheme medium field.
        /// </summary>
        [EnumMember(Value = "slaNotificationSchemeMedium")]
        SlaNotificationSchemeMedium,
        /// <summary>
        /// The sla notification scheme top field.
        /// </summary>
        [EnumMember(Value = "slaNotificationSchemeTop")]
        SlaNotificationSchemeTop,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The standard service requests field.
        /// </summary>
        [EnumMember(Value = "standardServiceRequests")]
        StandardServiceRequests,
        /// <summary>
        /// The status field.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,
        /// <summary>
        /// The summary field.
        /// </summary>
        [EnumMember(Value = "summary")]
        Summary,
        /// <summary>
        /// The summary attachments field.
        /// </summary>
        [EnumMember(Value = "summaryAttachments")]
        SummaryAttachments,
        /// <summary>
        /// The support hours case field.
        /// </summary>
        [EnumMember(Value = "supportHoursCase")]
        SupportHoursCase,
        /// <summary>
        /// The support hours high field.
        /// </summary>
        [EnumMember(Value = "supportHoursHigh")]
        SupportHoursHigh,
        /// <summary>
        /// The support hours low field.
        /// </summary>
        [EnumMember(Value = "supportHoursLow")]
        SupportHoursLow,
        /// <summary>
        /// The support hours medium field.
        /// </summary>
        [EnumMember(Value = "supportHoursMedium")]
        SupportHoursMedium,
        /// <summary>
        /// The support hours rfc field.
        /// </summary>
        [EnumMember(Value = "supportHoursRfc")]
        SupportHoursRfc,
        /// <summary>
        /// The support hours rfi field.
        /// </summary>
        [EnumMember(Value = "supportHoursRfi")]
        SupportHoursRfi,
        /// <summary>
        /// The support hours top field.
        /// </summary>
        [EnumMember(Value = "supportHoursTop")]
        SupportHoursTop,
        /// <summary>
        /// The termination field.
        /// </summary>
        [EnumMember(Value = "termination")]
        Termination,
        /// <summary>
        /// The termination attachments field.
        /// </summary>
        [EnumMember(Value = "terminationAttachments")]
        TerminationAttachments,
        /// <summary>
        /// The time zone field.
        /// </summary>
        [EnumMember(Value = "timeZone")]
        TimeZone,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// The waiting for customer follow up field.
        /// </summary>
        [EnumMember(Value = "waitingForCustomerFollowUp")]
        WaitingForCustomerFollowUp,
    }

    /// <summary>
    /// The <see cref="ShopArticle">ShopArticle</see> fields.
    /// </summary>
    public enum ShopArticleField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The calendar field.
        /// </summary>
        [EnumMember(Value = "calendar")]
        Calendar,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The delivery duration field.
        /// </summary>
        [EnumMember(Value = "deliveryDuration")]
        DeliveryDuration,
        /// <summary>
        /// The disabled field.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// The end at field.
        /// </summary>
        [EnumMember(Value = "endAt")]
        EndAt,
        /// <summary>
        /// The fulfillment template field.
        /// </summary>
        [EnumMember(Value = "fulfillmentTemplate")]
        FulfillmentTemplate,
        /// <summary>
        /// The full description field.
        /// </summary>
        [EnumMember(Value = "fullDescription")]
        FullDescription,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The max quantity field.
        /// </summary>
        [EnumMember(Value = "maxQuantity")]
        MaxQuantity,
        /// <summary>
        /// The name field.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// The picture uri field.
        /// </summary>
        [EnumMember(Value = "pictureUri")]
        PictureUri,
        /// <summary>
        /// The price field.
        /// </summary>
        [EnumMember(Value = "price")]
        Price,
        /// <summary>
        /// The price currency field.
        /// </summary>
        [EnumMember(Value = "priceCurrency")]
        PriceCurrency,
        /// <summary>
        /// The product field.
        /// </summary>
        [EnumMember(Value = "product")]
        Product,
        /// <summary>
        /// The provider shop article field.
        /// </summary>
        [EnumMember(Value = "providerShopArticle")]
        ProviderShopArticle,
        /// <summary>
        /// The recurring period field.
        /// </summary>
        [EnumMember(Value = "recurringPeriod")]
        RecurringPeriod,
        /// <summary>
        /// The recurring price field.
        /// </summary>
        [EnumMember(Value = "recurringPrice")]
        RecurringPrice,
        /// <summary>
        /// The recurring price currency field.
        /// </summary>
        [EnumMember(Value = "recurringPriceCurrency")]
        RecurringPriceCurrency,
        /// <summary>
        /// The reference field.
        /// </summary>
        [EnumMember(Value = "reference")]
        Reference,
        /// <summary>
        /// The requires shipping field.
        /// </summary>
        [EnumMember(Value = "requiresShipping")]
        RequiresShipping,
        /// <summary>
        /// The short description field.
        /// </summary>
        [EnumMember(Value = "shortDescription")]
        ShortDescription,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The start at field.
        /// </summary>
        [EnumMember(Value = "startAt")]
        StartAt,
        /// <summary>
        /// The time zone field.
        /// </summary>
        [EnumMember(Value = "timeZone")]
        TimeZone,
        /// <summary>
        /// The ui extension field.
        /// </summary>
        [EnumMember(Value = "uiExtension")]
        UiExtension,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The <see cref="ShopOrderLine">ShopOrderLine</see> fields.
    /// </summary>
    public enum ShopOrderLineField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The addresses field.
        /// </summary>
        [EnumMember(Value = "addresses")]
        Addresses,
        /// <summary>
        /// The completed at field.
        /// </summary>
        [EnumMember(Value = "completedAt")]
        CompletedAt,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The custom fields field.
        /// </summary>
        [EnumMember(Value = "customFields")]
        CustomFields,
        /// <summary>
        /// The custom fields attachments field.
        /// </summary>
        [EnumMember(Value = "customFieldsAttachments")]
        CustomFieldsAttachments,
        /// <summary>
        /// The fulfillment request field.
        /// </summary>
        [EnumMember(Value = "fulfillmentRequest")]
        FulfillmentRequest,
        /// <summary>
        /// The fulfillment task field.
        /// </summary>
        [EnumMember(Value = "fulfillmentTask")]
        FulfillmentTask,
        /// <summary>
        /// The fulfillment template field.
        /// </summary>
        [EnumMember(Value = "fulfillmentTemplate")]
        FulfillmentTemplate,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The name field.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// The order field.
        /// </summary>
        [EnumMember(Value = "order")]
        Order,
        /// <summary>
        /// The ordered at field.
        /// </summary>
        [EnumMember(Value = "orderedAt")]
        OrderedAt,
        /// <summary>
        /// The price field.
        /// </summary>
        [EnumMember(Value = "price")]
        Price,
        /// <summary>
        /// The price currency field.
        /// </summary>
        [EnumMember(Value = "priceCurrency")]
        PriceCurrency,
        /// <summary>
        /// The provider order line field.
        /// </summary>
        [EnumMember(Value = "providerOrderLine")]
        ProviderOrderLine,
        /// <summary>
        /// The quantity field.
        /// </summary>
        [EnumMember(Value = "quantity")]
        Quantity,
        /// <summary>
        /// The recurring period field.
        /// </summary>
        [EnumMember(Value = "recurringPeriod")]
        RecurringPeriod,
        /// <summary>
        /// The recurring price field.
        /// </summary>
        [EnumMember(Value = "recurringPrice")]
        RecurringPrice,
        /// <summary>
        /// The recurring price currency field.
        /// </summary>
        [EnumMember(Value = "recurringPriceCurrency")]
        RecurringPriceCurrency,
        /// <summary>
        /// The requested by field.
        /// </summary>
        [EnumMember(Value = "requestedBy")]
        RequestedBy,
        /// <summary>
        /// The requested for field.
        /// </summary>
        [EnumMember(Value = "requestedFor")]
        RequestedFor,
        /// <summary>
        /// The shop article field.
        /// </summary>
        [EnumMember(Value = "shopArticle")]
        ShopArticle,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The status field.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,
        /// <summary>
        /// The total price field.
        /// </summary>
        [EnumMember(Value = "totalPrice")]
        TotalPrice,
        /// <summary>
        /// The total recurring price field.
        /// </summary>
        [EnumMember(Value = "totalRecurringPrice")]
        TotalRecurringPrice,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The <see cref="ShortUrl">ShortUrl</see> fields.
    /// </summary>
    public enum ShortUrlField
    {
        /// <summary>
        /// The access token field.
        /// </summary>
        [EnumMember(Value = "accessToken")]
        AccessToken,
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The data type field.
        /// </summary>
        [EnumMember(Value = "dataType")]
        DataType,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// The uri field.
        /// </summary>
        [EnumMember(Value = "uri")]
        Uri,
        /// <summary>
        /// The short url field.
        /// </summary>
        [EnumMember(Value = "shortUrl")]
        URL,
    }

    /// <summary>
    /// The <see cref="Site">Site</see> fields.
    /// </summary>
    public enum SiteField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The addresses field.
        /// </summary>
        [EnumMember(Value = "addresses")]
        Addresses,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The custom fields field.
        /// </summary>
        [EnumMember(Value = "customFields")]
        CustomFields,
        /// <summary>
        /// The custom fields attachments field.
        /// </summary>
        [EnumMember(Value = "customFieldsAttachments")]
        CustomFieldsAttachments,
        /// <summary>
        /// The disabled field.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The name field.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// The people field.
        /// </summary>
        [EnumMember(Value = "people")]
        People,
        /// <summary>
        /// The picture uri field.
        /// </summary>
        [EnumMember(Value = "pictureUri")]
        PictureUri,
        /// <summary>
        /// The remarks field.
        /// </summary>
        [EnumMember(Value = "remarks")]
        Remarks,
        /// <summary>
        /// The remarks attachments field.
        /// </summary>
        [EnumMember(Value = "remarksAttachments")]
        RemarksAttachments,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The time zone field.
        /// </summary>
        [EnumMember(Value = "timeZone")]
        TimeZone,
        /// <summary>
        /// The ui extension field.
        /// </summary>
        [EnumMember(Value = "uiExtension")]
        UiExtension,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The <see cref="SkillPool">SkillPool</see> fields.
    /// </summary>
    public enum SkillPoolField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The cost per hour field.
        /// </summary>
        [EnumMember(Value = "costPerHour")]
        CostPerHour,
        /// <summary>
        /// The cost per hour currency field.
        /// </summary>
        [EnumMember(Value = "costPerHourCurrency")]
        CostPerHourCurrency,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The disabled field.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// The effort classes field.
        /// </summary>
        [EnumMember(Value = "effortClasses")]
        EffortClasses,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The manager field.
        /// </summary>
        [EnumMember(Value = "manager")]
        Manager,
        /// <summary>
        /// The members field.
        /// </summary>
        [EnumMember(Value = "members")]
        Members,
        /// <summary>
        /// The name field.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// The picture uri field.
        /// </summary>
        [EnumMember(Value = "pictureUri")]
        PictureUri,
        /// <summary>
        /// The remarks field.
        /// </summary>
        [EnumMember(Value = "remarks")]
        Remarks,
        /// <summary>
        /// The remarks attachments field.
        /// </summary>
        [EnumMember(Value = "remarksAttachments")]
        RemarksAttachments,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The <see cref="SlaCoverageGroup">SlaCoverageGroup</see> fields.
    /// </summary>
    public enum SlaCoverageGroupField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The description field.
        /// </summary>
        [EnumMember(Value = "description")]
        Description,
        /// <summary>
        /// The description attachments field.
        /// </summary>
        [EnumMember(Value = "descriptionAttachments")]
        DescriptionAttachments,
        /// <summary>
        /// The disabled field.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The name field.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// The people field.
        /// </summary>
        [EnumMember(Value = "people")]
        People,
        /// <summary>
        /// The search phrase field.
        /// </summary>
        [EnumMember(Value = "searchPhrase")]
        SearchPhrase,
        /// <summary>
        /// The slas field.
        /// </summary>
        [EnumMember(Value = "slas")]
        Slas,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The <see cref="SlaNotificationRule">SlaNotificationRule</see> fields.
    /// </summary>
    public enum SlaNotificationRuleField
    {
        /// <summary>
        /// The notify current assignee field.
        /// </summary>
        [EnumMember(Value = "notifyCurrentAssignee")]
        NotifyCurrentAssignee,
        /// <summary>
        /// The notify first line team coordinator field.
        /// </summary>
        [EnumMember(Value = "notifyFirstLineTeamCoordinator")]
        NotifyFirstLineTeamCoordinator,
        /// <summary>
        /// The notify first line team manager field.
        /// </summary>
        [EnumMember(Value = "notifyFirstLineTeamManager")]
        NotifyFirstLineTeamManager,
        /// <summary>
        /// The notify service owner field.
        /// </summary>
        [EnumMember(Value = "notifyServiceOwner")]
        NotifyServiceOwner,
        /// <summary>
        /// The notify support team coordinator field.
        /// </summary>
        [EnumMember(Value = "notifySupportTeamCoordinator")]
        NotifySupportTeamCoordinator,
        /// <summary>
        /// The notify support team manager field.
        /// </summary>
        [EnumMember(Value = "notifySupportTeamManager")]
        NotifySupportTeamManager,
        /// <summary>
        /// The threshold percentage field.
        /// </summary>
        [EnumMember(Value = "thresholdPercentage")]
        ThresholdPercentage,
    }

    /// <summary>
    /// The <see cref="SlaNotificationScheme">SlaNotificationScheme</see> fields.
    /// </summary>
    public enum SlaNotificationSchemeField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The disabled field.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The name field.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// The sla notification rules field.
        /// </summary>
        [EnumMember(Value = "slaNotificationRules")]
        SlaNotificationRules,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The <see cref="Snapshot">Snapshot</see> fields.
    /// </summary>
    public enum SnapshotField
    {
        /// <summary>
        /// The download url field.
        /// </summary>
        [EnumMember(Value = "downloadUrl")]
        DownloadUrl,
        /// <summary>
        /// The started at field.
        /// </summary>
        [EnumMember(Value = "startedAt")]
        StartedAt,
    }

    /// <summary>
    /// The <see cref="Sprint">Sprint</see> fields.
    /// </summary>
    public enum SprintField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The description field.
        /// </summary>
        [EnumMember(Value = "description")]
        Description,
        /// <summary>
        /// The description attachments field.
        /// </summary>
        [EnumMember(Value = "descriptionAttachments")]
        DescriptionAttachments,
        /// <summary>
        /// The end at field.
        /// </summary>
        [EnumMember(Value = "endAt")]
        EndAt,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The number field.
        /// </summary>
        [EnumMember(Value = "number")]
        Number,
        /// <summary>
        /// The scrum workspace field.
        /// </summary>
        [EnumMember(Value = "scrumWorkspace")]
        ScrumWorkspace,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The sprint backlog items field.
        /// </summary>
        [EnumMember(Value = "sprintBacklogItems")]
        SprintBacklogItems,
        /// <summary>
        /// The start at field.
        /// </summary>
        [EnumMember(Value = "startAt")]
        StartAt,
        /// <summary>
        /// The status field.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The <see cref="SprintBacklogItem">SprintBacklogItem</see> fields.
    /// </summary>
    public enum SprintBacklogItemField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The done field.
        /// </summary>
        [EnumMember(Value = "done")]
        Done,
        /// <summary>
        /// The estimate field.
        /// </summary>
        [EnumMember(Value = "estimate")]
        Estimate,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The planned field.
        /// </summary>
        [EnumMember(Value = "planned")]
        Planned,
        /// <summary>
        /// The position field.
        /// </summary>
        [EnumMember(Value = "position")]
        Position,
        /// <summary>
        /// The sprint field.
        /// </summary>
        [EnumMember(Value = "sprint")]
        Sprint,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The <see cref="StandardServiceRequest">StandardServiceRequest</see> fields.
    /// </summary>
    public enum StandardServiceRequestField
    {
        /// <summary>
        /// The charge type field.
        /// </summary>
        [EnumMember(Value = "chargeType")]
        ChargeType,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The rate field.
        /// </summary>
        [EnumMember(Value = "rate")]
        Rate,
        /// <summary>
        /// The rate currency field.
        /// </summary>
        [EnumMember(Value = "rateCurrency")]
        RateCurrency,
        /// <summary>
        /// The request template field.
        /// </summary>
        [EnumMember(Value = "requestTemplate")]
        RequestTemplate,
        /// <summary>
        /// The resolution target field.
        /// </summary>
        [EnumMember(Value = "resolutionTarget")]
        ResolutionTarget,
        /// <summary>
        /// The resolution target best effort field.
        /// </summary>
        [EnumMember(Value = "resolutionTargetBestEffort")]
        ResolutionTargetBestEffort,
        /// <summary>
        /// The resolution target in days field.
        /// </summary>
        [EnumMember(Value = "resolutionTargetInDays")]
        ResolutionTargetInDays,
        /// <summary>
        /// The response target field.
        /// </summary>
        [EnumMember(Value = "responseTarget")]
        ResponseTarget,
        /// <summary>
        /// The response target best effort field.
        /// </summary>
        [EnumMember(Value = "responseTargetBestEffort")]
        ResponseTargetBestEffort,
        /// <summary>
        /// The response target in days field.
        /// </summary>
        [EnumMember(Value = "responseTargetInDays")]
        ResponseTargetInDays,
        /// <summary>
        /// The service offering field.
        /// </summary>
        [EnumMember(Value = "serviceOffering")]
        ServiceOffering,
        /// <summary>
        /// The sla notification scheme field.
        /// </summary>
        [EnumMember(Value = "slaNotificationScheme")]
        SlaNotificationScheme,
        /// <summary>
        /// The support hours field.
        /// </summary>
        [EnumMember(Value = "supportHours")]
        SupportHours,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The <see cref="StandardServiceRequestActivityID">StandardServiceRequestActivityID</see> fields.
    /// </summary>
    public enum StandardServiceRequestActivityIDField
    {
        /// <summary>
        /// The activity id field.
        /// </summary>
        [EnumMember(Value = "activityID")]
        ActivityID,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The standard service request field.
        /// </summary>
        [EnumMember(Value = "standardServiceRequest")]
        StandardServiceRequest,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The <see cref="Survey">Survey</see> fields.
    /// </summary>
    public enum SurveyField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The completion field.
        /// </summary>
        [EnumMember(Value = "completion")]
        Completion,
        /// <summary>
        /// The completion attachments field.
        /// </summary>
        [EnumMember(Value = "completionAttachments")]
        CompletionAttachments,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The disabled field.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The introduction field.
        /// </summary>
        [EnumMember(Value = "introduction")]
        Introduction,
        /// <summary>
        /// The introduction attachments field.
        /// </summary>
        [EnumMember(Value = "introductionAttachments")]
        IntroductionAttachments,
        /// <summary>
        /// The name field.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// The picture uri field.
        /// </summary>
        [EnumMember(Value = "pictureUri")]
        PictureUri,
        /// <summary>
        /// The questions field.
        /// </summary>
        [EnumMember(Value = "questions")]
        Questions,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The translations field.
        /// </summary>
        [EnumMember(Value = "translations")]
        Translations,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The <see cref="SurveyAnswer">SurveyAnswer</see> fields.
    /// </summary>
    public enum SurveyAnswerField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The question field.
        /// </summary>
        [EnumMember(Value = "question")]
        Question,
        /// <summary>
        /// The rating field.
        /// </summary>
        [EnumMember(Value = "rating")]
        Rating,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The survey response field.
        /// </summary>
        [EnumMember(Value = "surveyResponse")]
        SurveyResponse,
        /// <summary>
        /// The text field.
        /// </summary>
        [EnumMember(Value = "text")]
        Text,
        /// <summary>
        /// The text attachments field.
        /// </summary>
        [EnumMember(Value = "textAttachments")]
        TextAttachments,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The <see cref="SurveyQuestion">SurveyQuestion</see> fields.
    /// </summary>
    public enum SurveyQuestionField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The disabled field.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// The guidance field.
        /// </summary>
        [EnumMember(Value = "guidance")]
        Guidance,
        /// <summary>
        /// The guidance attachments field.
        /// </summary>
        [EnumMember(Value = "guidanceAttachments")]
        GuidanceAttachments,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The position field.
        /// </summary>
        [EnumMember(Value = "position")]
        Position,
        /// <summary>
        /// The question field.
        /// </summary>
        [EnumMember(Value = "question")]
        Question,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The survey field.
        /// </summary>
        [EnumMember(Value = "survey")]
        Survey,
        /// <summary>
        /// The translations field.
        /// </summary>
        [EnumMember(Value = "translations")]
        Translations,
        /// <summary>
        /// The type field.
        /// </summary>
        [EnumMember(Value = "type")]
        Type,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// The weight field.
        /// </summary>
        [EnumMember(Value = "weight")]
        Weight,
    }

    /// <summary>
    /// The <see cref="SurveyResponse">SurveyResponse</see> fields.
    /// </summary>
    public enum SurveyResponseField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The answers field.
        /// </summary>
        [EnumMember(Value = "answers")]
        Answers,
        /// <summary>
        /// The completed field.
        /// </summary>
        [EnumMember(Value = "completed")]
        Completed,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The rating field.
        /// </summary>
        [EnumMember(Value = "rating")]
        Rating,
        /// <summary>
        /// The rating calculation field.
        /// </summary>
        [EnumMember(Value = "ratingCalculation")]
        RatingCalculation,
        /// <summary>
        /// The responded at field.
        /// </summary>
        [EnumMember(Value = "respondedAt")]
        RespondedAt,
        /// <summary>
        /// The service field.
        /// </summary>
        [EnumMember(Value = "service")]
        Service,
        /// <summary>
        /// The slas field.
        /// </summary>
        [EnumMember(Value = "slas")]
        Slas,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The survey field.
        /// </summary>
        [EnumMember(Value = "survey")]
        Survey,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The <see cref="SyncSet">SyncSet</see> fields.
    /// </summary>
    public enum SyncSetField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The description field.
        /// </summary>
        [EnumMember(Value = "description")]
        Description,
        /// <summary>
        /// The description attachments field.
        /// </summary>
        [EnumMember(Value = "descriptionAttachments")]
        DescriptionAttachments,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The last snapshot field.
        /// </summary>
        [EnumMember(Value = "lastSnapshot")]
        LastSnapshot,
        /// <summary>
        /// The name field.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// The resolved types field.
        /// </summary>
        [EnumMember(Value = "resolvedTypes")]
        ResolvedTypes,
        /// <summary>
        /// The selected records field.
        /// </summary>
        [EnumMember(Value = "selectedRecords")]
        SelectedRecords,
        /// <summary>
        /// The types field.
        /// </summary>
        [EnumMember(Value = "types")]
        Types,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The <see cref="Task">Task</see> fields.
    /// </summary>
    public enum TaskField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The agile board field.
        /// </summary>
        [EnumMember(Value = "agileBoard")]
        AgileBoard,
        /// <summary>
        /// The agile board column field.
        /// </summary>
        [EnumMember(Value = "agileBoardColumn")]
        AgileBoardColumn,
        /// <summary>
        /// The agile board column position field.
        /// </summary>
        [EnumMember(Value = "agileBoardColumnPosition")]
        AgileBoardColumnPosition,
        /// <summary>
        /// The anticipated assignment at field.
        /// </summary>
        [EnumMember(Value = "anticipatedAssignmentAt")]
        AnticipatedAssignmentAt,
        /// <summary>
        /// The approvals field.
        /// </summary>
        [EnumMember(Value = "approvals")]
        Approvals,
        /// <summary>
        /// The assigned at field.
        /// </summary>
        [EnumMember(Value = "assignedAt")]
        AssignedAt,
        /// <summary>
        /// The automation rules field.
        /// </summary>
        [EnumMember(Value = "automationRules")]
        AutomationRules,
        /// <summary>
        /// The category field.
        /// </summary>
        [EnumMember(Value = "category")]
        Category,
        /// <summary>
        /// The checked items field.
        /// </summary>
        [EnumMember(Value = "checkedItems")]
        CheckedItems,
        /// <summary>
        /// The completion target at field.
        /// </summary>
        [EnumMember(Value = "completionTargetAt")]
        CompletionTargetAt,
        /// <summary>
        /// The configuration items field.
        /// </summary>
        [EnumMember(Value = "configurationItems")]
        ConfigurationItems,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The custom fields field.
        /// </summary>
        [EnumMember(Value = "customFields")]
        CustomFields,
        /// <summary>
        /// The custom fields attachments field.
        /// </summary>
        [EnumMember(Value = "customFieldsAttachments")]
        CustomFieldsAttachments,
        /// <summary>
        /// The failure task field.
        /// </summary>
        [EnumMember(Value = "failureTask")]
        FailureTask,
        /// <summary>
        /// The finished at field.
        /// </summary>
        [EnumMember(Value = "finishedAt")]
        FinishedAt,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The impact field.
        /// </summary>
        [EnumMember(Value = "impact")]
        Impact,
        /// <summary>
        /// The instructions field.
        /// </summary>
        [EnumMember(Value = "instructions")]
        Instructions,
        /// <summary>
        /// The instructions attachments field.
        /// </summary>
        [EnumMember(Value = "instructionsAttachments")]
        InstructionsAttachments,
        /// <summary>
        /// The life cycle state field.
        /// </summary>
        [EnumMember(Value = "lifeCycleState")]
        LifeCycleState,
        /// <summary>
        /// The member field.
        /// </summary>
        [EnumMember(Value = "member")]
        Member,
        /// <summary>
        /// The note behavior field.
        /// </summary>
        [EnumMember(Value = "noteBehavior")]
        NoteBehavior,
        /// <summary>
        /// The notes field.
        /// </summary>
        [EnumMember(Value = "notes")]
        Notes,
        /// <summary>
        /// The order line field.
        /// </summary>
        [EnumMember(Value = "orderLine")]
        OrderLine,
        /// <summary>
        /// The pdf design field.
        /// </summary>
        [EnumMember(Value = "pdfDesign")]
        PdfDesign,
        /// <summary>
        /// The phase field.
        /// </summary>
        [EnumMember(Value = "phase")]
        Phase,
        /// <summary>
        /// The planned duration field.
        /// </summary>
        [EnumMember(Value = "plannedDuration")]
        PlannedDuration,
        /// <summary>
        /// The planned effort field.
        /// </summary>
        [EnumMember(Value = "plannedEffort")]
        PlannedEffort,
        /// <summary>
        /// The provider not accountable field.
        /// </summary>
        [EnumMember(Value = "providerNotAccountable")]
        ProviderNotAccountable,
        /// <summary>
        /// The rejection count field.
        /// </summary>
        [EnumMember(Value = "rejectionCount")]
        RejectionCount,
        /// <summary>
        /// The request field.
        /// </summary>
        [EnumMember(Value = "request")]
        Request,
        /// <summary>
        /// The request service instance field.
        /// </summary>
        [EnumMember(Value = "requestServiceInstance")]
        RequestServiceInstance,
        /// <summary>
        /// The request template field.
        /// </summary>
        [EnumMember(Value = "requestTemplate")]
        RequestTemplate,
        /// <summary>
        /// The required approvals field.
        /// </summary>
        [EnumMember(Value = "requiredApprovals")]
        RequiredApprovals,
        /// <summary>
        /// The resolution duration field.
        /// </summary>
        [EnumMember(Value = "resolutionDuration")]
        ResolutionDuration,
        /// <summary>
        /// The service instances field.
        /// </summary>
        [EnumMember(Value = "serviceInstances")]
        ServiceInstances,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The sprint backlog items field.
        /// </summary>
        [EnumMember(Value = "sprintBacklogItems")]
        SprintBacklogItems,
        /// <summary>
        /// The start at field.
        /// </summary>
        [EnumMember(Value = "startAt")]
        StartAt,
        /// <summary>
        /// The status field.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,
        /// <summary>
        /// The subject field.
        /// </summary>
        [EnumMember(Value = "subject")]
        Subject,
        /// <summary>
        /// The supplier field.
        /// </summary>
        [EnumMember(Value = "supplier")]
        Supplier,
        /// <summary>
        /// The supplier request id field.
        /// </summary>
        [EnumMember(Value = "supplierRequestID")]
        SupplierRequestID,
        /// <summary>
        /// The task id field.
        /// </summary>
        [EnumMember(Value = "taskId")]
        TaskId,
        /// <summary>
        /// The team field.
        /// </summary>
        [EnumMember(Value = "team")]
        Team,
        /// <summary>
        /// The template field.
        /// </summary>
        [EnumMember(Value = "template")]
        Template,
        /// <summary>
        /// The time entries field.
        /// </summary>
        [EnumMember(Value = "timeEntries")]
        TimeEntries,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// The urgent field.
        /// </summary>
        [EnumMember(Value = "urgent")]
        Urgent,
        /// <summary>
        /// The waiting until field.
        /// </summary>
        [EnumMember(Value = "waitingUntil")]
        WaitingUntil,
        /// <summary>
        /// The workflow field.
        /// </summary>
        [EnumMember(Value = "workflow")]
        Workflow,
        /// <summary>
        /// The work hours are 24 x 7 field.
        /// </summary>
        [EnumMember(Value = "workHoursAre24x7")]
        WorkHoursAre24x7,
    }

    /// <summary>
    /// The <see cref="TaskApproval">TaskApproval</see> fields.
    /// </summary>
    public enum TaskApprovalField
    {
        /// <summary>
        /// The approver field.
        /// </summary>
        [EnumMember(Value = "approver")]
        Approver,
        /// <summary>
        /// The attachment field.
        /// </summary>
        [EnumMember(Value = "attachment")]
        Attachment,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The planned effort field.
        /// </summary>
        [EnumMember(Value = "plannedEffort")]
        PlannedEffort,
        /// <summary>
        /// The status field.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The <see cref="TaskTemplate">TaskTemplate</see> fields.
    /// </summary>
    public enum TaskTemplateField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The approvals field.
        /// </summary>
        [EnumMember(Value = "approvals")]
        Approvals,
        /// <summary>
        /// The assign to requester field.
        /// </summary>
        [EnumMember(Value = "assignToRequester")]
        AssignToRequester,
        /// <summary>
        /// The assign to requester business unit manager field.
        /// </summary>
        [EnumMember(Value = "assignToRequesterBusinessUnitManager")]
        AssignToRequesterBusinessUnitManager,
        /// <summary>
        /// The assign to requester manager field.
        /// </summary>
        [EnumMember(Value = "assignToRequesterManager")]
        AssignToRequesterManager,
        /// <summary>
        /// The assign to service owner field.
        /// </summary>
        [EnumMember(Value = "assignToServiceOwner")]
        AssignToServiceOwner,
        /// <summary>
        /// The assign to workflow manager field.
        /// </summary>
        [EnumMember(Value = "assignToWorkflowManager")]
        AssignToWorkflowManager,
        /// <summary>
        /// The automation rules field.
        /// </summary>
        [EnumMember(Value = "automationRules")]
        AutomationRules,
        /// <summary>
        /// The category field.
        /// </summary>
        [EnumMember(Value = "category")]
        Category,
        /// <summary>
        /// The configuration items field.
        /// </summary>
        [EnumMember(Value = "configurationItems")]
        ConfigurationItems,
        /// <summary>
        /// The copy notes to workflow field.
        /// </summary>
        [EnumMember(Value = "copyNotesToWorkflow")]
        CopyNotesToWorkflow,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The disabled field.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// The effort class field.
        /// </summary>
        [EnumMember(Value = "effortClass")]
        EffortClass,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The impact field.
        /// </summary>
        [EnumMember(Value = "impact")]
        Impact,
        /// <summary>
        /// The instructions field.
        /// </summary>
        [EnumMember(Value = "instructions")]
        Instructions,
        /// <summary>
        /// The instructions attachments field.
        /// </summary>
        [EnumMember(Value = "instructionsAttachments")]
        InstructionsAttachments,
        /// <summary>
        /// The member field.
        /// </summary>
        [EnumMember(Value = "member")]
        Member,
        /// <summary>
        /// The note field.
        /// </summary>
        [EnumMember(Value = "note")]
        Note,
        /// <summary>
        /// The note attachments field.
        /// </summary>
        [EnumMember(Value = "noteAttachments")]
        NoteAttachments,
        /// <summary>
        /// The note behavior field.
        /// </summary>
        [EnumMember(Value = "noteBehavior")]
        NoteBehavior,
        /// <summary>
        /// The pdf design field.
        /// </summary>
        [EnumMember(Value = "pdfDesign")]
        PdfDesign,
        /// <summary>
        /// The planned duration field.
        /// </summary>
        [EnumMember(Value = "plannedDuration")]
        PlannedDuration,
        /// <summary>
        /// The planned effort field.
        /// </summary>
        [EnumMember(Value = "plannedEffort")]
        PlannedEffort,
        /// <summary>
        /// The planned effort requester field.
        /// </summary>
        [EnumMember(Value = "plannedEffortRequester")]
        PlannedEffortRequester,
        /// <summary>
        /// The planned effort requester business unit manager field.
        /// </summary>
        [EnumMember(Value = "plannedEffortRequesterBusinessUnitManager")]
        PlannedEffortRequesterBusinessUnitManager,
        /// <summary>
        /// The planned effort requester manager field.
        /// </summary>
        [EnumMember(Value = "plannedEffortRequesterManager")]
        PlannedEffortRequesterManager,
        /// <summary>
        /// The planned effort service owner field.
        /// </summary>
        [EnumMember(Value = "plannedEffortServiceOwner")]
        PlannedEffortServiceOwner,
        /// <summary>
        /// The planned effort workflow manager field.
        /// </summary>
        [EnumMember(Value = "plannedEffortWorkflowManager")]
        PlannedEffortWorkflowManager,
        /// <summary>
        /// The provider not accountable field.
        /// </summary>
        [EnumMember(Value = "providerNotAccountable")]
        ProviderNotAccountable,
        /// <summary>
        /// The request service instance field.
        /// </summary>
        [EnumMember(Value = "requestServiceInstance")]
        RequestServiceInstance,
        /// <summary>
        /// The request template field.
        /// </summary>
        [EnumMember(Value = "requestTemplate")]
        RequestTemplate,
        /// <summary>
        /// The required approvals field.
        /// </summary>
        [EnumMember(Value = "requiredApprovals")]
        RequiredApprovals,
        /// <summary>
        /// The service instances field.
        /// </summary>
        [EnumMember(Value = "serviceInstances")]
        ServiceInstances,
        /// <summary>
        /// The skill pool field.
        /// </summary>
        [EnumMember(Value = "skillPool")]
        SkillPool,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The subject field.
        /// </summary>
        [EnumMember(Value = "subject")]
        Subject,
        /// <summary>
        /// The supplier field.
        /// </summary>
        [EnumMember(Value = "supplier")]
        Supplier,
        /// <summary>
        /// The tasks field.
        /// </summary>
        [EnumMember(Value = "tasks")]
        Tasks,
        /// <summary>
        /// The team field.
        /// </summary>
        [EnumMember(Value = "team")]
        Team,
        /// <summary>
        /// The ui extension field.
        /// </summary>
        [EnumMember(Value = "uiExtension")]
        UiExtension,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// The urgent field.
        /// </summary>
        [EnumMember(Value = "urgent")]
        Urgent,
        /// <summary>
        /// The workflow templates field.
        /// </summary>
        [EnumMember(Value = "workflowTemplates")]
        WorkflowTemplates,
        /// <summary>
        /// The work hours are 24 x 7 field.
        /// </summary>
        [EnumMember(Value = "workHoursAre24x7")]
        WorkHoursAre24x7,
    }

    /// <summary>
    /// The <see cref="TaskTemplateApproval">TaskTemplateApproval</see> fields.
    /// </summary>
    public enum TaskTemplateApprovalField
    {
        /// <summary>
        /// The approver field.
        /// </summary>
        [EnumMember(Value = "approver")]
        Approver,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The planned effort field.
        /// </summary>
        [EnumMember(Value = "plannedEffort")]
        PlannedEffort,
    }

    /// <summary>
    /// The <see cref="Team">Team</see> fields.
    /// </summary>
    public enum TeamField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The agile board field.
        /// </summary>
        [EnumMember(Value = "agileBoard")]
        AgileBoard,
        /// <summary>
        /// The auto assign field.
        /// </summary>
        [EnumMember(Value = "autoAssign")]
        AutoAssign,
        /// <summary>
        /// The configuration manager field.
        /// </summary>
        [EnumMember(Value = "configurationManager")]
        ConfigurationManager,
        /// <summary>
        /// The coordinator field.
        /// </summary>
        [EnumMember(Value = "coordinator")]
        Coordinator,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The custom fields field.
        /// </summary>
        [EnumMember(Value = "customFields")]
        CustomFields,
        /// <summary>
        /// The custom fields attachments field.
        /// </summary>
        [EnumMember(Value = "customFieldsAttachments")]
        CustomFieldsAttachments,
        /// <summary>
        /// The disabled field.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The inbound email local part field.
        /// </summary>
        [EnumMember(Value = "inboundEmailLocalPart")]
        InboundEmailLocalPart,
        /// <summary>
        /// The manager field.
        /// </summary>
        [EnumMember(Value = "manager")]
        Manager,
        /// <summary>
        /// The members field.
        /// </summary>
        [EnumMember(Value = "members")]
        Members,
        /// <summary>
        /// The name field.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// The picture uri field.
        /// </summary>
        [EnumMember(Value = "pictureUri")]
        PictureUri,
        /// <summary>
        /// The remarks field.
        /// </summary>
        [EnumMember(Value = "remarks")]
        Remarks,
        /// <summary>
        /// The remarks attachments field.
        /// </summary>
        [EnumMember(Value = "remarksAttachments")]
        RemarksAttachments,
        /// <summary>
        /// The scrum workspace field.
        /// </summary>
        [EnumMember(Value = "scrumWorkspace")]
        ScrumWorkspace,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The time zone field.
        /// </summary>
        [EnumMember(Value = "timeZone")]
        TimeZone,
        /// <summary>
        /// The ui extension field.
        /// </summary>
        [EnumMember(Value = "uiExtension")]
        UiExtension,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// The work hours field.
        /// </summary>
        [EnumMember(Value = "workHours")]
        WorkHours,
    }

    /// <summary>
    /// The <see cref="TimeAllocation">TimeAllocation</see> fields.
    /// </summary>
    public enum TimeAllocationField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The customer category field.
        /// </summary>
        [EnumMember(Value = "customerCategory")]
        CustomerCategory,
        /// <summary>
        /// The customers field.
        /// </summary>
        [EnumMember(Value = "customers")]
        Customers,
        /// <summary>
        /// The description category field.
        /// </summary>
        [EnumMember(Value = "descriptionCategory")]
        DescriptionCategory,
        /// <summary>
        /// The disabled field.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// The effort class field.
        /// </summary>
        [EnumMember(Value = "effortClass")]
        EffortClass,
        /// <summary>
        /// The group field.
        /// </summary>
        [EnumMember(Value = "group")]
        Group,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The name field.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// The organizations field.
        /// </summary>
        [EnumMember(Value = "organizations")]
        Organizations,
        /// <summary>
        /// The service category field.
        /// </summary>
        [EnumMember(Value = "serviceCategory")]
        ServiceCategory,
        /// <summary>
        /// The services field.
        /// </summary>
        [EnumMember(Value = "services")]
        Services,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The translations field.
        /// </summary>
        [EnumMember(Value = "translations")]
        Translations,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The <see cref="TimeEntry">TimeEntry</see> fields.
    /// </summary>
    public enum TimeEntryField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The activity id field.
        /// </summary>
        [EnumMember(Value = "activityID")]
        ActivityID,
        /// <summary>
        /// The agreement id field.
        /// </summary>
        [EnumMember(Value = "agreementID")]
        AgreementID,
        /// <summary>
        /// The charge field.
        /// </summary>
        [EnumMember(Value = "charge")]
        Charge,
        /// <summary>
        /// The charge currency field.
        /// </summary>
        [EnumMember(Value = "chargeCurrency")]
        ChargeCurrency,
        /// <summary>
        /// The charge rate field.
        /// </summary>
        [EnumMember(Value = "chargeRate")]
        ChargeRate,
        /// <summary>
        /// The charge type field.
        /// </summary>
        [EnumMember(Value = "chargeType")]
        ChargeType,
        /// <summary>
        /// The correction field.
        /// </summary>
        [EnumMember(Value = "correction")]
        Correction,
        /// <summary>
        /// The cost field.
        /// </summary>
        [EnumMember(Value = "cost")]
        Cost,
        /// <summary>
        /// The cost currency field.
        /// </summary>
        [EnumMember(Value = "costCurrency")]
        CostCurrency,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The customer field.
        /// </summary>
        [EnumMember(Value = "customer")]
        Customer,
        /// <summary>
        /// The date field.
        /// </summary>
        [EnumMember(Value = "date")]
        Date,
        /// <summary>
        /// The deleted field.
        /// </summary>
        [EnumMember(Value = "deleted")]
        Deleted,
        /// <summary>
        /// The description field.
        /// </summary>
        [EnumMember(Value = "description")]
        Description,
        /// <summary>
        /// The effort class field.
        /// </summary>
        [EnumMember(Value = "effortClass")]
        EffortClass,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The note field.
        /// </summary>
        [EnumMember(Value = "note")]
        Note,
        /// <summary>
        /// The organization field.
        /// </summary>
        [EnumMember(Value = "organization")]
        Organization,
        /// <summary>
        /// The person field.
        /// </summary>
        [EnumMember(Value = "person")]
        Person,
        /// <summary>
        /// The rate id field.
        /// </summary>
        [EnumMember(Value = "rateID")]
        RateID,
        /// <summary>
        /// The service field.
        /// </summary>
        [EnumMember(Value = "service")]
        Service,
        /// <summary>
        /// The service instance field.
        /// </summary>
        [EnumMember(Value = "serviceInstance")]
        ServiceInstance,
        /// <summary>
        /// The service level agreement field.
        /// </summary>
        [EnumMember(Value = "serviceLevelAgreement")]
        ServiceLevelAgreement,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The started at field.
        /// </summary>
        [EnumMember(Value = "startedAt")]
        StartedAt,
        /// <summary>
        /// The team field.
        /// </summary>
        [EnumMember(Value = "team")]
        Team,
        /// <summary>
        /// The time allocation field.
        /// </summary>
        [EnumMember(Value = "timeAllocation")]
        TimeAllocation,
        /// <summary>
        /// The time spent field.
        /// </summary>
        [EnumMember(Value = "timeSpent")]
        TimeSpent,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The <see cref="TimesheetSetting">TimesheetSetting</see> fields.
    /// </summary>
    public enum TimesheetSettingField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The allocation time tracking field.
        /// </summary>
        [EnumMember(Value = "allocationTimeTracking")]
        AllocationTimeTracking,
        /// <summary>
        /// The allow workday overtime field.
        /// </summary>
        [EnumMember(Value = "allowWorkdayOvertime")]
        AllowWorkdayOvertime,
        /// <summary>
        /// The allow workweek overtime field.
        /// </summary>
        [EnumMember(Value = "allowWorkweekOvertime")]
        AllowWorkweekOvertime,
        /// <summary>
        /// The assignment time tracking field.
        /// </summary>
        [EnumMember(Value = "assignmentTimeTracking")]
        AssignmentTimeTracking,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The disabled field.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// The effort classes field.
        /// </summary>
        [EnumMember(Value = "effortClasses")]
        EffortClasses,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The name field.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// The notify on incomplete field.
        /// </summary>
        [EnumMember(Value = "notifyOnIncomplete")]
        NotifyOnIncomplete,
        /// <summary>
        /// The organizations field.
        /// </summary>
        [EnumMember(Value = "organizations")]
        Organizations,
        /// <summary>
        /// The percentage increment field.
        /// </summary>
        [EnumMember(Value = "percentageIncrement")]
        PercentageIncrement,
        /// <summary>
        /// The problem effort class field.
        /// </summary>
        [EnumMember(Value = "problemEffortClass")]
        ProblemEffortClass,
        /// <summary>
        /// The project task effort class field.
        /// </summary>
        [EnumMember(Value = "projectTaskEffortClass")]
        ProjectTaskEffortClass,
        /// <summary>
        /// The request effort class field.
        /// </summary>
        [EnumMember(Value = "requestEffortClass")]
        RequestEffortClass,
        /// <summary>
        /// The require note field.
        /// </summary>
        [EnumMember(Value = "requireNote")]
        RequireNote,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The task effort class field.
        /// </summary>
        [EnumMember(Value = "taskEffortClass")]
        TaskEffortClass,
        /// <summary>
        /// The time allocation effort class field.
        /// </summary>
        [EnumMember(Value = "timeAllocationEffortClass")]
        TimeAllocationEffortClass,
        /// <summary>
        /// The time increment field.
        /// </summary>
        [EnumMember(Value = "timeIncrement")]
        TimeIncrement,
        /// <summary>
        /// The unit field.
        /// </summary>
        [EnumMember(Value = "unit")]
        Unit,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// The workday field.
        /// </summary>
        [EnumMember(Value = "workday")]
        Workday,
        /// <summary>
        /// The workweek field.
        /// </summary>
        [EnumMember(Value = "workweek")]
        Workweek,
    }

    /// <summary>
    /// The <see cref="Translation">Translation</see> fields.
    /// </summary>
    public enum TranslationField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The disabled field.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// The field field.
        /// </summary>
        [EnumMember(Value = "field")]
        Field,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The language field.
        /// </summary>
        [EnumMember(Value = "language")]
        Language,
        /// <summary>
        /// The text field.
        /// </summary>
        [EnumMember(Value = "text")]
        Text,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The <see cref="Trash">Trash</see> fields.
    /// </summary>
    public enum TrashField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The trashed field.
        /// </summary>
        [EnumMember(Value = "trashed")]
        Trashed,
        /// <summary>
        /// The trashed by field.
        /// </summary>
        [EnumMember(Value = "trashedBy")]
        TrashedBy,
    }

    /// <summary>
    /// The <see cref="UiExtension">UiExtension</see> fields.
    /// </summary>
    public enum UiExtensionField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The active version field.
        /// </summary>
        [EnumMember(Value = "activeVersion")]
        ActiveVersion,
        /// <summary>
        /// The category field.
        /// </summary>
        [EnumMember(Value = "category")]
        Category,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The created by field.
        /// </summary>
        [EnumMember(Value = "createdBy")]
        CreatedBy,
        /// <summary>
        /// The description field.
        /// </summary>
        [EnumMember(Value = "description")]
        Description,
        /// <summary>
        /// The description attachments field.
        /// </summary>
        [EnumMember(Value = "descriptionAttachments")]
        DescriptionAttachments,
        /// <summary>
        /// The disabled field.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The name field.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The title field.
        /// </summary>
        [EnumMember(Value = "title")]
        Title,
        /// <summary>
        /// The translations field.
        /// </summary>
        [EnumMember(Value = "translations")]
        Translations,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// The updated by field.
        /// </summary>
        [EnumMember(Value = "updatedBy")]
        UpdatedBy,
        /// <summary>
        /// The versions field.
        /// </summary>
        [EnumMember(Value = "versions")]
        Versions,
    }

    /// <summary>
    /// The <see cref="UiExtensionVersion">UiExtensionVersion</see> fields.
    /// </summary>
    public enum UiExtensionVersionField
    {
        /// <summary>
        /// The activated at field.
        /// </summary>
        [EnumMember(Value = "activatedAt")]
        ActivatedAt,
        /// <summary>
        /// The archived at field.
        /// </summary>
        [EnumMember(Value = "archivedAt")]
        ArchivedAt,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The css field.
        /// </summary>
        [EnumMember(Value = "css")]
        Css,
        /// <summary>
        /// The html field.
        /// </summary>
        [EnumMember(Value = "html")]
        Html,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The javascript field.
        /// </summary>
        [EnumMember(Value = "javascript")]
        Javascript,
        /// <summary>
        /// The status field.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,
        /// <summary>
        /// The ui extension field.
        /// </summary>
        [EnumMember(Value = "uiExtension")]
        UiExtension,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// The version nr field.
        /// </summary>
        [EnumMember(Value = "versionNr")]
        VersionNr,
    }

    /// <summary>
    /// The <see cref="ValidationError">ValidationError</see> fields.
    /// </summary>
    public enum ValidationErrorField
    {
        /// <summary>
        /// The message field.
        /// </summary>
        [EnumMember(Value = "message")]
        Message,
        /// <summary>
        /// The path field.
        /// </summary>
        [EnumMember(Value = "path")]
        Path,
    }

    /// <summary>
    /// The <see cref="WaitingForCustomerFollowUp">WaitingForCustomerFollowUp</see> fields.
    /// </summary>
    public enum WaitingForCustomerFollowUpField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The auto complete field.
        /// </summary>
        [EnumMember(Value = "autoComplete")]
        AutoComplete,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The disabled field.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The name field.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// The waiting for customer rules field.
        /// </summary>
        [EnumMember(Value = "waitingForCustomerRules")]
        WaitingForCustomerRules,
    }

    /// <summary>
    /// The <see cref="WaitingForCustomerRule">WaitingForCustomerRule</see> fields.
    /// </summary>
    public enum WaitingForCustomerRuleField
    {
        /// <summary>
        /// The nr of business days field.
        /// </summary>
        [EnumMember(Value = "nrOfBusinessDays")]
        NrOfBusinessDays,
    }

    /// <summary>
    /// The <see cref="Watch">Watch</see> fields.
    /// </summary>
    public enum WatchField
    {
        /// <summary>
        /// The added by field.
        /// </summary>
        [EnumMember(Value = "addedBy")]
        AddedBy,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The person field.
        /// </summary>
        [EnumMember(Value = "person")]
        Person,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The <see cref="Webhook">Webhook</see> fields.
    /// </summary>
    public enum WebhookField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The description field.
        /// </summary>
        [EnumMember(Value = "description")]
        Description,
        /// <summary>
        /// The description attachments field.
        /// </summary>
        [EnumMember(Value = "descriptionAttachments")]
        DescriptionAttachments,
        /// <summary>
        /// The disabled field.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// The event field.
        /// </summary>
        [EnumMember(Value = "event")]
        Event,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The mail exceptions to field.
        /// </summary>
        [EnumMember(Value = "mailExceptionsTo")]
        MailExceptionsTo,
        /// <summary>
        /// The name field.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// The uri field.
        /// </summary>
        [EnumMember(Value = "uri")]
        Uri,
        /// <summary>
        /// The webhook policy field.
        /// </summary>
        [EnumMember(Value = "webhookPolicy")]
        WebhookPolicy,
    }

    /// <summary>
    /// The <see cref="WebhookPolicy">WebhookPolicy</see> fields.
    /// </summary>
    public enum WebhookPolicyField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The disabled field.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The jwt alg field.
        /// </summary>
        [EnumMember(Value = "jwtAlg")]
        JwtAlg,
        /// <summary>
        /// The jwt audience field.
        /// </summary>
        [EnumMember(Value = "jwtAudience")]
        JwtAudience,
        /// <summary>
        /// The jwt claim expires in field.
        /// </summary>
        [EnumMember(Value = "jwtClaimExpiresIn")]
        JwtClaimExpiresIn,
        /// <summary>
        /// The name field.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The <see cref="WebhookPolicyCreateResponse">WebhookPolicyCreateResponse</see> fields.
    /// </summary>
    public enum WebhookPolicyCreateResponseField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The disabled field.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The jwt alg field.
        /// </summary>
        [EnumMember(Value = "jwtAlg")]
        JwtAlg,
        /// <summary>
        /// The jwt audience field.
        /// </summary>
        [EnumMember(Value = "jwtAudience")]
        JwtAudience,
        /// <summary>
        /// The jwt claim expires in field.
        /// </summary>
        [EnumMember(Value = "jwtClaimExpiresIn")]
        JwtClaimExpiresIn,
        /// <summary>
        /// The name field.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// The public key pem field.
        /// </summary>
        [EnumMember(Value = "publicKeyPem")]
        PublicKeyPem,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The <see cref="Workflow">Workflow</see> fields.
    /// </summary>
    public enum WorkflowField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The actual effort field.
        /// </summary>
        [EnumMember(Value = "actualEffort")]
        ActualEffort,
        /// <summary>
        /// The actual vs planned effort percentage field.
        /// </summary>
        [EnumMember(Value = "actualVsPlannedEffortPercentage")]
        ActualVsPlannedEffortPercentage,
        /// <summary>
        /// The automation rules field.
        /// </summary>
        [EnumMember(Value = "automationRules")]
        AutomationRules,
        /// <summary>
        /// The category field.
        /// </summary>
        [EnumMember(Value = "category")]
        Category,
        /// <summary>
        /// The completed at field.
        /// </summary>
        [EnumMember(Value = "completedAt")]
        CompletedAt,
        /// <summary>
        /// The completion reason field.
        /// </summary>
        [EnumMember(Value = "completionReason")]
        CompletionReason,
        /// <summary>
        /// The completion target at field.
        /// </summary>
        [EnumMember(Value = "completionTargetAt")]
        CompletionTargetAt,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The custom fields field.
        /// </summary>
        [EnumMember(Value = "customFields")]
        CustomFields,
        /// <summary>
        /// The custom fields attachments field.
        /// </summary>
        [EnumMember(Value = "customFieldsAttachments")]
        CustomFieldsAttachments,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The impact field.
        /// </summary>
        [EnumMember(Value = "impact")]
        Impact,
        /// <summary>
        /// The invoices field.
        /// </summary>
        [EnumMember(Value = "invoices")]
        Invoices,
        /// <summary>
        /// The justification field.
        /// </summary>
        [EnumMember(Value = "justification")]
        Justification,
        /// <summary>
        /// The life cycle state field.
        /// </summary>
        [EnumMember(Value = "lifeCycleState")]
        LifeCycleState,
        /// <summary>
        /// The manager field.
        /// </summary>
        [EnumMember(Value = "manager")]
        Manager,
        /// <summary>
        /// The notes field.
        /// </summary>
        [EnumMember(Value = "notes")]
        Notes,
        /// <summary>
        /// The phases field.
        /// </summary>
        [EnumMember(Value = "phases")]
        Phases,
        /// <summary>
        /// The planned effort field.
        /// </summary>
        [EnumMember(Value = "plannedEffort")]
        PlannedEffort,
        /// <summary>
        /// The problems field.
        /// </summary>
        [EnumMember(Value = "problems")]
        Problems,
        /// <summary>
        /// The project field.
        /// </summary>
        [EnumMember(Value = "project")]
        Project,
        /// <summary>
        /// The release field.
        /// </summary>
        [EnumMember(Value = "release")]
        Release,
        /// <summary>
        /// The requests field.
        /// </summary>
        [EnumMember(Value = "requests")]
        Requests,
        /// <summary>
        /// The resolution duration field.
        /// </summary>
        [EnumMember(Value = "resolutionDuration")]
        ResolutionDuration,
        /// <summary>
        /// The service field.
        /// </summary>
        [EnumMember(Value = "service")]
        Service,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The start at field.
        /// </summary>
        [EnumMember(Value = "startAt")]
        StartAt,
        /// <summary>
        /// The status field.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,
        /// <summary>
        /// The subject field.
        /// </summary>
        [EnumMember(Value = "subject")]
        Subject,
        /// <summary>
        /// The tasks field.
        /// </summary>
        [EnumMember(Value = "tasks")]
        Tasks,
        /// <summary>
        /// The template field.
        /// </summary>
        [EnumMember(Value = "template")]
        Template,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// The workflow id field.
        /// </summary>
        [EnumMember(Value = "workflowId")]
        WorkflowId,
        /// <summary>
        /// The workflow type field.
        /// </summary>
        [EnumMember(Value = "workflowType")]
        WorkflowType,
    }

    /// <summary>
    /// The <see cref="WorkflowPhase">WorkflowPhase</see> fields.
    /// </summary>
    public enum WorkflowPhaseField
    {
        /// <summary>
        /// The completed at field.
        /// </summary>
        [EnumMember(Value = "completedAt")]
        CompletedAt,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The name field.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// The position field.
        /// </summary>
        [EnumMember(Value = "position")]
        Position,
        /// <summary>
        /// The started at field.
        /// </summary>
        [EnumMember(Value = "startedAt")]
        StartedAt,
        /// <summary>
        /// The status field.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The <see cref="WorkflowTaskTemplateRelation">WorkflowTaskTemplateRelation</see> fields.
    /// </summary>
    public enum WorkflowTaskTemplateRelationField
    {
        /// <summary>
        /// The automation rules field.
        /// </summary>
        [EnumMember(Value = "automationRules")]
        AutomationRules,
        /// <summary>
        /// The failure task template field.
        /// </summary>
        [EnumMember(Value = "failureTaskTemplate")]
        FailureTaskTemplate,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The phase field.
        /// </summary>
        [EnumMember(Value = "phase")]
        Phase,
        /// <summary>
        /// The task template field.
        /// </summary>
        [EnumMember(Value = "taskTemplate")]
        TaskTemplate,
        /// <summary>
        /// The workflow template field.
        /// </summary>
        [EnumMember(Value = "workflowTemplate")]
        WorkflowTemplate,
    }

    /// <summary>
    /// The <see cref="WorkflowTemplate">WorkflowTemplate</see> fields.
    /// </summary>
    public enum WorkflowTemplateField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The assign relations to workflow manager field.
        /// </summary>
        [EnumMember(Value = "assignRelationsToWorkflowManager")]
        AssignRelationsToWorkflowManager,
        /// <summary>
        /// The automation rules field.
        /// </summary>
        [EnumMember(Value = "automationRules")]
        AutomationRules,
        /// <summary>
        /// The category field.
        /// </summary>
        [EnumMember(Value = "category")]
        Category,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The disabled field.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The impact field.
        /// </summary>
        [EnumMember(Value = "impact")]
        Impact,
        /// <summary>
        /// The instructions field.
        /// </summary>
        [EnumMember(Value = "instructions")]
        Instructions,
        /// <summary>
        /// The instructions attachments field.
        /// </summary>
        [EnumMember(Value = "instructionsAttachments")]
        InstructionsAttachments,
        /// <summary>
        /// The justification field.
        /// </summary>
        [EnumMember(Value = "justification")]
        Justification,
        /// <summary>
        /// The note field.
        /// </summary>
        [EnumMember(Value = "note")]
        Note,
        /// <summary>
        /// The note attachments field.
        /// </summary>
        [EnumMember(Value = "noteAttachments")]
        NoteAttachments,
        /// <summary>
        /// The phases field.
        /// </summary>
        [EnumMember(Value = "phases")]
        Phases,
        /// <summary>
        /// The recurrence field.
        /// </summary>
        [EnumMember(Value = "recurrence")]
        Recurrence,
        /// <summary>
        /// The service field.
        /// </summary>
        [EnumMember(Value = "service")]
        Service,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The subject field.
        /// </summary>
        [EnumMember(Value = "subject")]
        Subject,
        /// <summary>
        /// The task template relations field.
        /// </summary>
        [EnumMember(Value = "taskTemplateRelations")]
        TaskTemplateRelations,
        /// <summary>
        /// The ui extension field.
        /// </summary>
        [EnumMember(Value = "uiExtension")]
        UiExtension,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// The workflow manager field.
        /// </summary>
        [EnumMember(Value = "workflowManager")]
        WorkflowManager,
        /// <summary>
        /// The workflows field.
        /// </summary>
        [EnumMember(Value = "workflows")]
        Workflows,
        /// <summary>
        /// The workflow type field.
        /// </summary>
        [EnumMember(Value = "workflowType")]
        WorkflowType,
    }

    /// <summary>
    /// The <see cref="WorkflowTemplatePhase">WorkflowTemplatePhase</see> fields.
    /// </summary>
    public enum WorkflowTemplatePhaseField
    {
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The name field.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// The position field.
        /// </summary>
        [EnumMember(Value = "position")]
        Position,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The <see cref="WorkflowType">WorkflowType</see> fields.
    /// </summary>
    public enum WorkflowTypeField
    {
        /// <summary>
        /// The account field.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// The created at field.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// The description field.
        /// </summary>
        [EnumMember(Value = "description")]
        Description,
        /// <summary>
        /// The disabled field.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// The id field.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// The information field.
        /// </summary>
        [EnumMember(Value = "information")]
        Information,
        /// <summary>
        /// The information attachments field.
        /// </summary>
        [EnumMember(Value = "informationAttachments")]
        InformationAttachments,
        /// <summary>
        /// The name field.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// The position field.
        /// </summary>
        [EnumMember(Value = "position")]
        Position,
        /// <summary>
        /// The reference field.
        /// </summary>
        [EnumMember(Value = "reference")]
        Reference,
        /// <summary>
        /// The source field.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// The source id field.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// The translations field.
        /// </summary>
        [EnumMember(Value = "translations")]
        Translations,
        /// <summary>
        /// The updated at field.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }
}