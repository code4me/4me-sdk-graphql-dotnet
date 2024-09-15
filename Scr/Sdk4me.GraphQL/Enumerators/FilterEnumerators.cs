using System.Runtime.Serialization;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The default view.
    /// </summary>
    public enum DefaultFilter
    {
        /// <summary>
        /// No filter.
        /// </summary>
        [EnumMember(Value = "")]
        None,
    }

    /// <summary>
    /// Filter to determine which AffectedSla records are returned.
    /// </summary>
    public enum AffectedSlaFilter
    {
        /// <summary>
        /// Filter on node id.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Filter on service level agreement.
        /// </summary>
        [EnumMember(Value = "serviceLevelAgreement")]
        ServiceLevelAgreement,
        /// <summary>
        /// Filter on accountability.
        /// </summary>
        [EnumMember(Value = "accountability")]
        Accountability,
        /// <summary>
        /// Filter on impact.
        /// </summary>
        [EnumMember(Value = "impact")]
        Impact,
        /// <summary>
        /// Include only if requester covered matches supplied value.
        /// </summary>
        [EnumMember(Value = "requesterCovered")]
        RequesterCovered,
        /// <summary>
        /// Include only if provider not accountable matches supplied value.
        /// </summary>
        [EnumMember(Value = "providerNotAccountable")]
        ProviderNotAccountable,
        /// <summary>
        /// Include only if provider was not accountable matches supplied value.
        /// </summary>
        [EnumMember(Value = "providerWasNotAccountable")]
        ProviderWasNotAccountable,
        /// <summary>
        /// Target indication filter on response target.
        /// </summary>
        [EnumMember(Value = "responseTargetIndication")]
        ResponseTargetIndication,
        /// <summary>
        /// Response target in supplied range.
        /// </summary>
        [EnumMember(Value = "responseTargetAt")]
        ResponseTargetAt,
        /// <summary>
        /// Actual response in supplied range.
        /// </summary>
        [EnumMember(Value = "actualResponseAt")]
        ActualResponseAt,
        /// <summary>
        /// Target indication filter on resolution target.
        /// </summary>
        [EnumMember(Value = "resolutionTargetIndication")]
        ResolutionTargetIndication,
        /// <summary>
        /// Resolution target in supplied range.
        /// </summary>
        [EnumMember(Value = "resolutionTargetAt")]
        ResolutionTargetAt,
        /// <summary>
        /// Actual resolution in supplied range.
        /// </summary>
        [EnumMember(Value = "actualResolutionAt")]
        ActualResolutionAt,
        /// <summary>
        /// Target indication filter on next target.
        /// </summary>
        [EnumMember(Value = "nextTargetIndication")]
        NextTargetIndication,
        /// <summary>
        /// Next target in supplied range.
        /// </summary>
        [EnumMember(Value = "nextTargetAt")]
        NextTargetAt,
        /// <summary>
        /// Include only if best effort resolution target matches supplied value.
        /// </summary>
        [EnumMember(Value = "bestEffortResolutionTarget")]
        BestEffortResolutionTarget,
        /// <summary>
        /// Filter on support team.
        /// </summary>
        [EnumMember(Value = "supportTeam")]
        SupportTeam,
        /// <summary>
        /// Filter on first line team.
        /// </summary>
        [EnumMember(Value = "firstLineTeam")]
        FirstLineTeam,
        /// <summary>
        /// Filter on request.
        /// </summary>
        [EnumMember(Value = "request")]
        Request,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "requestSource")]
        RequestSource,
        /// <summary>
        /// Filter on category.
        /// </summary>
        [EnumMember(Value = "requestCategory")]
        RequestCategory,
        /// <summary>
        /// Filter on requester.
        /// </summary>
        [EnumMember(Value = "requestedFor")]
        RequestedFor,
        /// <summary>
        /// Filter on requester organization.
        /// </summary>
        [EnumMember(Value = "requesterOrganization")]
        RequesterOrganization,
        /// <summary>
        /// Filter on requester organization region.
        /// </summary>
        [EnumMember(Value = "requesterOrganizationRegion")]
        RequesterOrganizationRegion,
        /// <summary>
        /// Filter on business unit.
        /// </summary>
        [EnumMember(Value = "businessUnit")]
        BusinessUnit,
        /// <summary>
        /// Filter on requester site.
        /// </summary>
        [EnumMember(Value = "requesterSite")]
        RequesterSite,
        /// <summary>
        /// Filter on service instance.
        /// </summary>
        [EnumMember(Value = "serviceInstance")]
        ServiceInstance,
        /// <summary>
        /// Filter on service.
        /// </summary>
        [EnumMember(Value = "service")]
        Service,
        /// <summary>
        /// Filter on service owner.
        /// </summary>
        [EnumMember(Value = "serviceOwner")]
        ServiceOwner,
        /// <summary>
        /// Filter on service provider.
        /// </summary>
        [EnumMember(Value = "serviceProvider")]
        ServiceProvider,
        /// <summary>
        /// Filter on provider account.
        /// </summary>
        [EnumMember(Value = "slaAccount")]
        SlaAccount,
        /// <summary>
        /// Filter on customer account.
        /// </summary>
        [EnumMember(Value = "slaCustomerAccount")]
        SlaCustomerAccount,
        /// <summary>
        /// Filter on customer.
        /// </summary>
        [EnumMember(Value = "slaCustomer")]
        SlaCustomer,
        /// <summary>
        /// Filter on customer region.
        /// </summary>
        [EnumMember(Value = "slaCustomerRegion")]
        SlaCustomerRegion,
        /// <summary>
        /// Filter on status.
        /// </summary>
        [EnumMember(Value = "requestStatus")]
        RequestStatus,
        /// <summary>
        /// Filter on completion reason.
        /// </summary>
        [EnumMember(Value = "requestCompletionReason")]
        RequestCompletionReason,
        /// <summary>
        /// Filter on team.
        /// </summary>
        [EnumMember(Value = "requestTeam")]
        RequestTeam,
        /// <summary>
        /// Filter on member.
        /// </summary>
        [EnumMember(Value = "requestMember")]
        RequestMember,
    }

    /// <summary>
    /// Filter to determine which AgileBoard records are returned.
    /// </summary>
    public enum AgileBoardFilter
    {
        /// <summary>
        /// Filter on node id.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Include only if disabled matches supplied value.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// Filter on manager.
        /// </summary>
        [EnumMember(Value = "manager")]
        Manager,
        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// Filter on name.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
    }

    /// <summary>
    /// Filter to determine which AppInstance records are returned.
    /// </summary>
    public enum AppInstanceFilter
    {
        /// <summary>
        /// Filter on node id.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Include only if disabled matches supplied value.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// Include only if enabled by customer matches supplied value.
        /// </summary>
        [EnumMember(Value = "enabledByCustomer")]
        EnabledByCustomer,
        /// <summary>
        /// Include only if suspended matches supplied value.
        /// </summary>
        [EnumMember(Value = "suspended")]
        Suspended,
        /// <summary>
        /// Filter on account.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// Filter on customer account.
        /// </summary>
        [EnumMember(Value = "customerAccount")]
        CustomerAccount,
        /// <summary>
        /// Filter on customer representative.
        /// </summary>
        [EnumMember(Value = "customerRepresentative")]
        CustomerRepresentative,
        /// <summary>
        /// Filter on app offering.
        /// </summary>
        [EnumMember(Value = "appOffering")]
        AppOffering,
        /// <summary>
        /// Filter on app offering reference.
        /// </summary>
        [EnumMember(Value = "appOfferingReference")]
        AppOfferingReference,
        /// <summary>
        /// Filter on service instance.
        /// </summary>
        [EnumMember(Value = "serviceInstance")]
        ServiceInstance,
    }

    /// <summary>
    /// Filter to determine which AppOffering records are returned.
    /// </summary>
    public enum AppOfferingFilter
    {
        /// <summary>
        /// Filter on node id.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Filter on reference.
        /// </summary>
        [EnumMember(Value = "reference")]
        Reference,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// Filter on account.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// Filter on name.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// Include only if published matches supplied value.
        /// </summary>
        [EnumMember(Value = "published")]
        Published,
        /// <summary>
        /// Include only if latest matches supplied value.
        /// </summary>
        [EnumMember(Value = "latest")]
        Latest,
        /// <summary>
        /// Include only if disabled matches supplied value.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// Filter on service.
        /// </summary>
        [EnumMember(Value = "service")]
        Service,
        /// <summary>
        /// Filter on service instance.
        /// </summary>
        [EnumMember(Value = "serviceInstance")]
        ServiceInstance,
    }

    /// <summary>
    /// Filter to determine which Archive records are returned.
    /// </summary>
    public enum ArchiveFilter
    {
        /// <summary>
        /// Filter on node id.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Filter on name.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
    }

    /// <summary>
    /// Filter to determine which AutomationRule records are returned.
    /// </summary>
    public enum AutomationRuleFilter
    {
        /// <summary>
        /// Filter on node id.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// Filter on request template.
        /// </summary>
        [EnumMember(Value = "requestTemplate")]
        RequestTemplate,
        /// <summary>
        /// Filter on workflow template.
        /// </summary>
        [EnumMember(Value = "workflowTemplate")]
        WorkflowTemplate,
        /// <summary>
        /// Filter on task template.
        /// </summary>
        [EnumMember(Value = "taskTemplate")]
        TaskTemplate,
        /// <summary>
        /// Filter on project template.
        /// </summary>
        [EnumMember(Value = "projectTemplate")]
        ProjectTemplate,
        /// <summary>
        /// Filter on project task template.
        /// </summary>
        [EnumMember(Value = "projectTaskTemplate")]
        ProjectTaskTemplate,
        /// <summary>
        /// Filter on name.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
    }

    /// <summary>
    /// Attributes to filter on basic fields.
    /// </summary>
    public enum BroadcastFilter
    {
        /// <summary>
        /// Ids to select.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Created at in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated at in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
    }

    /// <summary>
    /// Attributes to filter calendars.
    /// </summary>
    public enum CalendarFilter
    {
        /// <summary>
        /// Ids to select.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Created at in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated at in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// Name of calendar.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
    }

    /// <summary>
    /// Filter to determine which ConfigurationItem records are returned.
    /// </summary>
    public enum ConfigurationItemFilter
    {
        /// <summary>
        /// Filter on node id.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Filter on account.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// Filter on support account.
        /// </summary>
        [EnumMember(Value = "supportAccount")]
        SupportAccount,
        /// <summary>
        /// Filter on status.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,
        /// <summary>
        /// Include only if status matches supplied value.
        /// </summary>
        [EnumMember(Value = "active")]
        Active,
        /// <summary>
        /// Filter on service.
        /// </summary>
        [EnumMember(Value = "service")]
        Service,
        /// <summary>
        /// Filter on service owner.
        /// </summary>
        [EnumMember(Value = "serviceOwner")]
        ServiceOwner,
        /// <summary>
        /// Filter on service instance.
        /// </summary>
        [EnumMember(Value = "serviceInstance")]
        ServiceInstance,
        /// <summary>
        /// Filter on contract.
        /// </summary>
        [EnumMember(Value = "contract")]
        Contract,
        /// <summary>
        /// Filter on product.
        /// </summary>
        [EnumMember(Value = "product")]
        Product,
        /// <summary>
        /// Filter on product category.
        /// </summary>
        [EnumMember(Value = "productCategory")]
        ProductCategory,
        /// <summary>
        /// Filter on product brand.
        /// </summary>
        [EnumMember(Value = "productBrand")]
        ProductBrand,
        /// <summary>
        /// Filter on product model.
        /// </summary>
        [EnumMember(Value = "productModel")]
        ProductModel,
        /// <summary>
        /// Filter on rule set.
        /// </summary>
        [EnumMember(Value = "ruleSet")]
        RuleSet,
        /// <summary>
        /// Filter on site.
        /// </summary>
        [EnumMember(Value = "site")]
        Site,
        /// <summary>
        /// Filter on location.
        /// </summary>
        [EnumMember(Value = "location")]
        Location,
        /// <summary>
        /// Filter on support team.
        /// </summary>
        [EnumMember(Value = "supportTeam")]
        SupportTeam,
        /// <summary>
        /// Filter on financial owner.
        /// </summary>
        [EnumMember(Value = "financialOwner")]
        FinancialOwner,
        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Last seen in supplied range.
        /// </summary>
        [EnumMember(Value = "lastSeenAt")]
        LastSeenAt,
        /// <summary>
        /// In use since in supplied range.
        /// </summary>
        [EnumMember(Value = "inUseSince")]
        InUseSince,
        /// <summary>
        /// License expiry date in supplied range.
        /// </summary>
        [EnumMember(Value = "licenseExpiryDate")]
        LicenseExpiryDate,
        /// <summary>
        /// Warranty expiry date in supplied range.
        /// </summary>
        [EnumMember(Value = "warrantyExpiryDate")]
        WarrantyExpiryDate,
        /// <summary>
        /// End of support date in supplied range.
        /// </summary>
        [EnumMember(Value = "endOfSupportDate")]
        EndOfSupportDate,
        /// <summary>
        /// Filter on supplier.
        /// </summary>
        [EnumMember(Value = "supplier")]
        Supplier,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// Filter on user.
        /// </summary>
        [EnumMember(Value = "user")]
        User,
        /// <summary>
        /// Filter on user organization.
        /// </summary>
        [EnumMember(Value = "userOrganization")]
        UserOrganization,
        /// <summary>
        /// Filter on name.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// Filter on alternate name.
        /// </summary>
        [EnumMember(Value = "alternateName")]
        AlternateName,
        /// <summary>
        /// Filter on label.
        /// </summary>
        [EnumMember(Value = "label")]
        Label,
        /// <summary>
        /// Filter on serial number.
        /// </summary>
        [EnumMember(Value = "serialNr")]
        SerialNr,
        /// <summary>
        /// Filter on system id.
        /// </summary>
        [EnumMember(Value = "systemID")]
        SystemID,
        /// <summary>
        /// Filter on asset id.
        /// </summary>
        [EnumMember(Value = "assetID")]
        AssetID,
        /// <summary>
        /// Filter on ram amount.
        /// </summary>
        [EnumMember(Value = "ramAmount")]
        RamAmount,
        /// <summary>
        /// Filter on operating system.
        /// </summary>
        [EnumMember(Value = "operatingSystem")]
        OperatingSystem,
    }

    /// <summary>
    /// Filter to determine which Contract records are returned.
    /// </summary>
    public enum ContractFilter
    {
        /// <summary>
        /// Filter on node id.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Filter on account.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// Filter on category.
        /// </summary>
        [EnumMember(Value = "category")]
        Category,
        /// <summary>
        /// Filter on status.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,
        /// <summary>
        /// Include only if status matches supplied value.
        /// </summary>
        [EnumMember(Value = "active")]
        Active,
        /// <summary>
        /// Filter on customer.
        /// </summary>
        [EnumMember(Value = "customer")]
        Customer,
        /// <summary>
        /// Filter on customer representative.
        /// </summary>
        [EnumMember(Value = "customerRep")]
        CustomerRep,
        /// <summary>
        /// Filter on supplier.
        /// </summary>
        [EnumMember(Value = "supplier")]
        Supplier,
        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Start date in supplied range.
        /// </summary>
        [EnumMember(Value = "startDate")]
        StartDate,
        /// <summary>
        /// Notice date in supplied range.
        /// </summary>
        [EnumMember(Value = "noticeDate")]
        NoticeDate,
        /// <summary>
        /// Expiry date in supplied range.
        /// </summary>
        [EnumMember(Value = "expiryDate")]
        ExpiryDate,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// Filter on name.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
    }

    /// <summary>
    /// Filter to determine which CustomCollectionElement records are returned.
    /// </summary>
    public enum CustomCollectionElementFilter
    {
        /// <summary>
        /// Filter on node id.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Include only if disabled matches supplied value.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// Filter on reference.
        /// </summary>
        [EnumMember(Value = "reference")]
        Reference,
        /// <summary>
        /// Filter on custom collection.
        /// </summary>
        [EnumMember(Value = "customCollection")]
        CustomCollection,
        /// <summary>
        /// Filter on name.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
    }

    /// <summary>
    /// Attributes to filter on basic fields.
    /// </summary>
    public enum CustomCollectionFilter
    {
        /// <summary>
        /// Ids to select.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Created at in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated at in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
    }

    /// <summary>
    /// Attributes to filter on basic fields.
    /// </summary>
    public enum EffortClassFilter
    {
        /// <summary>
        /// Ids to select.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Created at in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated at in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
    }

    /// <summary>
    /// Filter to determine which FirstLineSupportAgreement records are returned.
    /// </summary>
    public enum FirstLineSupportAgreementFilter
    {
        /// <summary>
        /// Filter on node id.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Filter on account.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// Filter on customer account.
        /// </summary>
        [EnumMember(Value = "customerAccount")]
        CustomerAccount,
        /// <summary>
        /// Filter on status.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,
        /// <summary>
        /// Filter on customer.
        /// </summary>
        [EnumMember(Value = "customer")]
        Customer,
        /// <summary>
        /// Filter on first line support provider.
        /// </summary>
        [EnumMember(Value = "provider")]
        Provider,
        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Start date in supplied range.
        /// </summary>
        [EnumMember(Value = "startDate")]
        StartDate,
        /// <summary>
        /// Notice date in supplied range.
        /// </summary>
        [EnumMember(Value = "noticeDate")]
        NoticeDate,
        /// <summary>
        /// Expiry date in supplied range.
        /// </summary>
        [EnumMember(Value = "expiryDate")]
        ExpiryDate,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// Filter on name.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
    }

    /// <summary>
    /// Attributes to filter on basic fields.
    /// </summary>
    public enum HolidayFilter
    {
        /// <summary>
        /// Ids to select.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Created at in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated at in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
    }

    /// <summary>
    /// Filter to determine which Invoice records are returned.
    /// </summary>
    public enum InvoiceFilter
    {
        /// <summary>
        /// Filter on node id.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Filter on service.
        /// </summary>
        [EnumMember(Value = "service")]
        Service,
        /// <summary>
        /// Filter on workflow.
        /// </summary>
        [EnumMember(Value = "workflow")]
        Workflow,
        /// <summary>
        /// Filter on project.
        /// </summary>
        [EnumMember(Value = "project")]
        Project,
        /// <summary>
        /// Filter on service level agreement.
        /// </summary>
        [EnumMember(Value = "sla")]
        Sla,
        /// <summary>
        /// Filter on first line support agreement.
        /// </summary>
        [EnumMember(Value = "flsa")]
        Flsa,
        /// <summary>
        /// Filter on contract.
        /// </summary>
        [EnumMember(Value = "contract")]
        Contract,
        /// <summary>
        /// Filter on supplier.
        /// </summary>
        [EnumMember(Value = "supplier")]
        Supplier,
        /// <summary>
        /// Filter on configuration item.
        /// </summary>
        [EnumMember(Value = "ci")]
        Ci,
        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Invoice date in supplied range.
        /// </summary>
        [EnumMember(Value = "invoiceDate")]
        InvoiceDate,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// Filter on financial id.
        /// </summary>
        [EnumMember(Value = "financialID")]
        FinancialID,
        /// <summary>
        /// Filter on description.
        /// </summary>
        [EnumMember(Value = "description")]
        Description,
        /// <summary>
        /// Filter on type.
        /// </summary>
        [EnumMember(Value = "invoiceType")]
        InvoiceType,
        /// <summary>
        /// Include only if amortize matches supplied value.
        /// </summary>
        [EnumMember(Value = "amortize")]
        Amortize,
        /// <summary>
        /// Amortization start in supplied range.
        /// </summary>
        [EnumMember(Value = "amortizationStart")]
        AmortizationStart,
        /// <summary>
        /// Amortization end in supplied range.
        /// </summary>
        [EnumMember(Value = "amortizationEnd")]
        AmortizationEnd,
        /// <summary>
        /// Depreciation start in supplied range.
        /// </summary>
        [EnumMember(Value = "depreciationStart")]
        DepreciationStart,
        /// <summary>
        /// Filter on invoice number.
        /// </summary>
        [EnumMember(Value = "invoiceNr")]
        InvoiceNr,
        /// <summary>
        /// Filter on po number.
        /// </summary>
        [EnumMember(Value = "poNr")]
        PoNr,
        /// <summary>
        /// Filter on useful life.
        /// </summary>
        [EnumMember(Value = "usefulLife")]
        UsefulLife,
    }

    /// <summary>
    /// Filter to determine which KnowledgeArticle records are returned.
    /// </summary>
    public enum KnowledgeArticleFilter
    {
        /// <summary>
        /// Filter on node id.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Filter on account.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// Filter on status.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,
        /// <summary>
        /// Filter on service.
        /// </summary>
        [EnumMember(Value = "service")]
        Service,
        /// <summary>
        /// Filter on knowledge manager.
        /// </summary>
        [EnumMember(Value = "knowledgeManager")]
        KnowledgeManager,
        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Filter on created by.
        /// </summary>
        [EnumMember(Value = "createdBy")]
        CreatedBy,
        /// <summary>
        /// Filter on updated by.
        /// </summary>
        [EnumMember(Value = "updatedBy")]
        UpdatedBy,
        /// <summary>
        /// Filter on service instance.
        /// </summary>
        [EnumMember(Value = "serviceInstance")]
        ServiceInstance,
        /// <summary>
        /// Include only if internal specialists matches supplied value.
        /// </summary>
        [EnumMember(Value = "internalSpecialists")]
        InternalSpecialists,
        /// <summary>
        /// Include only if covered specialists matches supplied value.
        /// </summary>
        [EnumMember(Value = "coveredSpecialists")]
        CoveredSpecialists,
        /// <summary>
        /// Include only if key contacts matches supplied value.
        /// </summary>
        [EnumMember(Value = "keyContacts")]
        KeyContacts,
        /// <summary>
        /// Include only if end users matches supplied value.
        /// </summary>
        [EnumMember(Value = "endUsers")]
        EndUsers,
        /// <summary>
        /// Include only if public matches supplied value.
        /// </summary>
        [EnumMember(Value = "public")]
        Public,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// Filter on subject.
        /// </summary>
        [EnumMember(Value = "subject")]
        Subject,
        /// <summary>
        /// Archive date in supplied range.
        /// </summary>
        [EnumMember(Value = "archiveDate")]
        ArchiveDate,
        /// <summary>
        /// Filter on template.
        /// </summary>
        [EnumMember(Value = "template")]
        Template,
    }

    /// <summary>
    /// Filter to determine which KnowledgeArticleTemplate records are returned.
    /// </summary>
    public enum KnowledgeArticleTemplateFilter
    {
        /// <summary>
        /// Filter on node id.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Filter on service.
        /// </summary>
        [EnumMember(Value = "service")]
        Service,
        /// <summary>
        /// Filter on service instance.
        /// </summary>
        [EnumMember(Value = "serviceInstance")]
        ServiceInstance,
        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Include only if disabled matches supplied value.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// Filter on subject.
        /// </summary>
        [EnumMember(Value = "subject")]
        Subject,
        /// <summary>
        /// Filter on ui extension.
        /// </summary>
        [EnumMember(Value = "uiExtension")]
        UiExtension,
    }

    /// <summary>
    /// Filter to determine which Organization records are returned.
    /// </summary>
    public enum OrganizationFilter
    {
        /// <summary>
        /// Filter on node id.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Filter on account.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// Filter on manager.
        /// </summary>
        [EnumMember(Value = "manager")]
        Manager,
        /// <summary>
        /// Filter on substitute.
        /// </summary>
        [EnumMember(Value = "substitute")]
        Substitute,
        /// <summary>
        /// Filter on region.
        /// </summary>
        [EnumMember(Value = "organizationRegion")]
        OrganizationRegion,
        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Include only if disabled matches supplied value.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// Filter on financial id.
        /// </summary>
        [EnumMember(Value = "financialID")]
        FinancialID,
        /// <summary>
        /// Filter on name.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// Include only if business unit matches supplied value.
        /// </summary>
        [EnumMember(Value = "businessUnit")]
        BusinessUnit,
        /// <summary>
        /// Filter on parent organization.
        /// </summary>
        [EnumMember(Value = "parent")]
        Parent,
        /// <summary>
        /// Filter on business unit organization.
        /// </summary>
        [EnumMember(Value = "businessUnitOrganization")]
        BusinessUnitOrganization,
    }

    /// <summary>
    /// Filter to determine which OutOfOfficePeriod records are returned.
    /// </summary>
    public enum OutOfOfficePeriodFilter
    {
        /// <summary>
        /// Filter on node id.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Filter on person.
        /// </summary>
        [EnumMember(Value = "person")]
        Person,
        /// <summary>
        /// Filter on organization.
        /// </summary>
        [EnumMember(Value = "organization")]
        Organization,
        /// <summary>
        /// Filter on organization region.
        /// </summary>
        [EnumMember(Value = "organizationRegion")]
        OrganizationRegion,
        /// <summary>
        /// Filter on business unit.
        /// </summary>
        [EnumMember(Value = "businessUnitOrganization")]
        BusinessUnitOrganization,
        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Start in supplied range.
        /// </summary>
        [EnumMember(Value = "startAt")]
        StartAt,
        /// <summary>
        /// End in supplied range.
        /// </summary>
        [EnumMember(Value = "endAt")]
        EndAt,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
    }

    /// <summary>
    /// Attributes to filter on basic fields.
    /// </summary>
    public enum PdfDesignFilter
    {
        /// <summary>
        /// Ids to select.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Created at in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated at in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// Filter to determine which Person records are returned.
    /// </summary>
    public enum PersonFilter
    {
        /// <summary>
        /// Filter on node id.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Filter on account.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// Filter on organization.
        /// </summary>
        [EnumMember(Value = "organization")]
        Organization,
        /// <summary>
        /// Filter on business unit.
        /// </summary>
        [EnumMember(Value = "businessUnitOrganization")]
        BusinessUnitOrganization,
        /// <summary>
        /// Filter on site.
        /// </summary>
        [EnumMember(Value = "site")]
        Site,
        /// <summary>
        /// Filter on location.
        /// </summary>
        [EnumMember(Value = "location")]
        Location,
        /// <summary>
        /// Filter on manager.
        /// </summary>
        [EnumMember(Value = "manager")]
        Manager,
        /// <summary>
        /// Filter on team.
        /// </summary>
        [EnumMember(Value = "team")]
        Team,
        /// <summary>
        /// Filter on skill pool.
        /// </summary>
        [EnumMember(Value = "skillPool")]
        SkillPool,
        /// <summary>
        /// Include only if vip matches supplied value.
        /// </summary>
        [EnumMember(Value = "vip")]
        Vip,
        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Filter on role.
        /// </summary>
        [EnumMember(Value = "role")]
        Role,
        /// <summary>
        /// Include only if disabled matches supplied value.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// Include only if billable matches supplied value.
        /// </summary>
        [EnumMember(Value = "billable")]
        Billable,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// Filter on support id.
        /// </summary>
        [EnumMember(Value = "supportID")]
        SupportID,
        /// <summary>
        /// Filter on employee id.
        /// </summary>
        [EnumMember(Value = "employeeID")]
        EmployeeID,
        /// <summary>
        /// Filter on authentication id.
        /// </summary>
        [EnumMember(Value = "authenticationID")]
        AuthenticationID,
        /// <summary>
        /// Filter on primary email.
        /// </summary>
        [EnumMember(Value = "primaryEmail")]
        PrimaryEmail,
        /// <summary>
        /// Filter on name.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// Include only if guest matches supplied value.
        /// </summary>
        [EnumMember(Value = "guest")]
        Guest,
        /// <summary>
        /// Filter on job title.
        /// </summary>
        [EnumMember(Value = "jobTitle")]
        JobTitle,
    }

    /// <summary>
    /// Filter to determine which Problem records are returned.
    /// </summary>
    public enum ProblemFilter
    {
        /// <summary>
        /// Filter on node id.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Filter on account.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// Filter on status.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,
        /// <summary>
        /// Filter on impact.
        /// </summary>
        [EnumMember(Value = "impact")]
        Impact,
        /// <summary>
        /// Filter on category.
        /// </summary>
        [EnumMember(Value = "category")]
        Category,
        /// <summary>
        /// Filter on service.
        /// </summary>
        [EnumMember(Value = "service")]
        Service,
        /// <summary>
        /// Filter on service owner.
        /// </summary>
        [EnumMember(Value = "serviceOwner")]
        ServiceOwner,
        /// <summary>
        /// Filter on supplier.
        /// </summary>
        [EnumMember(Value = "supplier")]
        Supplier,
        /// <summary>
        /// Include only if known error matches supplied value.
        /// </summary>
        [EnumMember(Value = "knownError")]
        KnownError,
        /// <summary>
        /// Filter on manager.
        /// </summary>
        [EnumMember(Value = "manager")]
        Manager,
        /// <summary>
        /// Filter on member.
        /// </summary>
        [EnumMember(Value = "member")]
        Member,
        /// <summary>
        /// Filter on team.
        /// </summary>
        [EnumMember(Value = "team")]
        Team,
        /// <summary>
        /// Solved in supplied range.
        /// </summary>
        [EnumMember(Value = "solvedAt")]
        SolvedAt,
        /// <summary>
        /// Target indication filter on analysis target.
        /// </summary>
        [EnumMember(Value = "analysisTargetIndication")]
        AnalysisTargetIndication,
        /// <summary>
        /// Analysis target in supplied range.
        /// </summary>
        [EnumMember(Value = "analysisTargetAt")]
        AnalysisTargetAt,
        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Include only if urgent matches supplied value.
        /// </summary>
        [EnumMember(Value = "urgent")]
        Urgent,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// Filter on subject.
        /// </summary>
        [EnumMember(Value = "subject")]
        Subject,
        /// <summary>
        /// Filter on agile board.
        /// </summary>
        [EnumMember(Value = "agileBoard")]
        AgileBoard,
        /// <summary>
        /// Filter on agile board column.
        /// </summary>
        [EnumMember(Value = "agileBoardColumn")]
        AgileBoardColumn,
        /// <summary>
        /// Filter on product backlog.
        /// </summary>
        [EnumMember(Value = "productBacklog")]
        ProductBacklog,
        /// <summary>
        /// Include only if mentioning me matches supplied value.
        /// </summary>
        [EnumMember(Value = "mentioningMe")]
        MentioningMe,
        /// <summary>
        /// Filter on record id as displayed in ui.
        /// </summary>
        [EnumMember(Value = "problemId")]
        ProblemId,
    }

    /// <summary>
    /// Filter to determine which ProductBacklog records are returned.
    /// </summary>
    public enum ProductBacklogFilter
    {
        /// <summary>
        /// Filter on node id.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Include only if disabled matches supplied value.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// Filter on product owner.
        /// </summary>
        [EnumMember(Value = "productOwner")]
        ProductOwner,
        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// Filter on name.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
    }

    /// <summary>
    /// Attributes to filter product categories.
    /// </summary>
    public enum ProductCategoryFilter
    {
        /// <summary>
        /// Ids to select.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Created at in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated at in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// References to select.
        /// </summary>
        [EnumMember(Value = "references")]
        References,
        /// <summary>
        /// Groups to select.
        /// </summary>
        [EnumMember(Value = "groups")]
        Groups,
        /// <summary>
        /// Filter on rule set.
        /// </summary>
        [EnumMember(Value = "ruleSet")]
        RuleSet,
    }

    /// <summary>
    /// Filter to determine which Product records are returned.
    /// </summary>
    public enum ProductFilter
    {
        /// <summary>
        /// Filter on node id.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Filter on account.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// Filter on service.
        /// </summary>
        [EnumMember(Value = "service")]
        Service,
        /// <summary>
        /// Filter on category.
        /// </summary>
        [EnumMember(Value = "productCategory")]
        ProductCategory,
        /// <summary>
        /// Filter on category rule set.
        /// </summary>
        [EnumMember(Value = "ruleSet")]
        RuleSet,
        /// <summary>
        /// Filter on financial owner.
        /// </summary>
        [EnumMember(Value = "financialOwner")]
        FinancialOwner,
        /// <summary>
        /// Filter on supplier.
        /// </summary>
        [EnumMember(Value = "supplier")]
        Supplier,
        /// <summary>
        /// Filter on support team.
        /// </summary>
        [EnumMember(Value = "supportTeam")]
        SupportTeam,
        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Filter on brand.
        /// </summary>
        [EnumMember(Value = "productBrand")]
        ProductBrand,
        /// <summary>
        /// Include only if disabled matches supplied value.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// Filter on model.
        /// </summary>
        [EnumMember(Value = "model")]
        Model,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// Filter on name.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// Filter on depreciation method.
        /// </summary>
        [EnumMember(Value = "depreciationMethod")]
        DepreciationMethod,
        /// <summary>
        /// Filter on product id.
        /// </summary>
        [EnumMember(Value = "productID")]
        ProductID,
    }

    /// <summary>
    /// Attributes to filter on basic fields.
    /// </summary>
    public enum ProjectCategoryFilter
    {
        /// <summary>
        /// Ids to select.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Created at in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated at in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
    }

    /// <summary>
    /// Filter to determine which Project records are returned.
    /// </summary>
    public enum ProjectFilter
    {
        /// <summary>
        /// Filter on node id.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Filter on account.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// Filter on justification.
        /// </summary>
        [EnumMember(Value = "justification")]
        Justification,
        /// <summary>
        /// Filter on service.
        /// </summary>
        [EnumMember(Value = "service")]
        Service,
        /// <summary>
        /// Filter on manager.
        /// </summary>
        [EnumMember(Value = "manager")]
        Manager,
        /// <summary>
        /// Filter on category.
        /// </summary>
        [EnumMember(Value = "category")]
        Category,
        /// <summary>
        /// Filter on risk level.
        /// </summary>
        [EnumMember(Value = "riskLevel")]
        RiskLevel,
        /// <summary>
        /// Filter on program.
        /// </summary>
        [EnumMember(Value = "projectProgram")]
        ProjectProgram,
        /// <summary>
        /// Filter on customer.
        /// </summary>
        [EnumMember(Value = "customer")]
        Customer,
        /// <summary>
        /// Filter on status.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,
        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Completed in supplied range.
        /// </summary>
        [EnumMember(Value = "completedAt")]
        CompletedAt,
        /// <summary>
        /// Target indication filter on completion target.
        /// </summary>
        [EnumMember(Value = "completionTargetIndication")]
        CompletionTargetIndication,
        /// <summary>
        /// Completion target in supplied range.
        /// </summary>
        [EnumMember(Value = "completionTargetAt")]
        CompletionTargetAt,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// Filter on subject.
        /// </summary>
        [EnumMember(Value = "subject")]
        Subject,
        /// <summary>
        /// Filter on completion reason.
        /// </summary>
        [EnumMember(Value = "completionReason")]
        CompletionReason,
        /// <summary>
        /// Include only if mentioning me matches supplied value.
        /// </summary>
        [EnumMember(Value = "mentioningMe")]
        MentioningMe,
        /// <summary>
        /// Filter on phase.
        /// </summary>
        [EnumMember(Value = "phase")]
        Phase,
        /// <summary>
        /// Filter on record id as displayed in ui.
        /// </summary>
        [EnumMember(Value = "projectId")]
        ProjectId,
    }

    /// <summary>
    /// Attributes to filter on basic fields.
    /// </summary>
    public enum ProjectRiskLevelFilter
    {
        /// <summary>
        /// Ids to select.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Created at in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated at in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
    }

    /// <summary>
    /// Filter to determine which ProjectTask records are returned.
    /// </summary>
    public enum ProjectTaskFilter
    {
        /// <summary>
        /// Filter on node id.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Filter on account.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// Filter on status.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,
        /// <summary>
        /// Filter on category.
        /// </summary>
        [EnumMember(Value = "category")]
        Category,
        /// <summary>
        /// Filter on template.
        /// </summary>
        [EnumMember(Value = "template")]
        Template,
        /// <summary>
        /// Target indication filter on completion target.
        /// </summary>
        [EnumMember(Value = "completionTargetIndication")]
        CompletionTargetIndication,
        /// <summary>
        /// Completion target in supplied range.
        /// </summary>
        [EnumMember(Value = "completionTargetAt")]
        CompletionTargetAt,
        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Finished in supplied range.
        /// </summary>
        [EnumMember(Value = "finishedAt")]
        FinishedAt,
        /// <summary>
        /// Filter on supplier.
        /// </summary>
        [EnumMember(Value = "supplier")]
        Supplier,
        /// <summary>
        /// Filter on assignee.
        /// </summary>
        [EnumMember(Value = "assignee")]
        Assignee,
        /// <summary>
        /// Filter on manager.
        /// </summary>
        [EnumMember(Value = "manager")]
        Manager,
        /// <summary>
        /// Filter on project.
        /// </summary>
        [EnumMember(Value = "project")]
        Project,
        /// <summary>
        /// Filter on service.
        /// </summary>
        [EnumMember(Value = "service")]
        Service,
        /// <summary>
        /// Filter on program.
        /// </summary>
        [EnumMember(Value = "projectProgram")]
        ProjectProgram,
        /// <summary>
        /// Include only if urgent matches supplied value.
        /// </summary>
        [EnumMember(Value = "urgent")]
        Urgent,
        /// <summary>
        /// Filter on team.
        /// </summary>
        [EnumMember(Value = "team")]
        Team,
        /// <summary>
        /// Filter on skill pool.
        /// </summary>
        [EnumMember(Value = "skillPool")]
        SkillPool,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// Filter on subject.
        /// </summary>
        [EnumMember(Value = "subject")]
        Subject,
        /// <summary>
        /// Filter on agile board.
        /// </summary>
        [EnumMember(Value = "agileBoard")]
        AgileBoard,
        /// <summary>
        /// Filter on agile board column.
        /// </summary>
        [EnumMember(Value = "agileBoardColumn")]
        AgileBoardColumn,
        /// <summary>
        /// Include only if mentioning me matches supplied value.
        /// </summary>
        [EnumMember(Value = "mentioningMe")]
        MentioningMe,
        /// <summary>
        /// Filter on record id as displayed in ui.
        /// </summary>
        [EnumMember(Value = "projectTaskId")]
        ProjectTaskId,
    }

    /// <summary>
    /// Filter to determine which ProjectTaskTemplate records are returned.
    /// </summary>
    public enum ProjectTaskTemplateFilter
    {
        /// <summary>
        /// Filter on node id.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Filter on project template.
        /// </summary>
        [EnumMember(Value = "projectTemplate")]
        ProjectTemplate,
        /// <summary>
        /// Filter on category.
        /// </summary>
        [EnumMember(Value = "category")]
        Category,
        /// <summary>
        /// Filter on team.
        /// </summary>
        [EnumMember(Value = "team")]
        Team,
        /// <summary>
        /// Filter on skill pool.
        /// </summary>
        [EnumMember(Value = "skillPool")]
        SkillPool,
        /// <summary>
        /// Filter on assignee.
        /// </summary>
        [EnumMember(Value = "assignee")]
        Assignee,
        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Include only if disabled matches supplied value.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// Filter on subject.
        /// </summary>
        [EnumMember(Value = "subject")]
        Subject,
    }

    /// <summary>
    /// Filter to determine which ProjectTemplate records are returned.
    /// </summary>
    public enum ProjectTemplateFilter
    {
        /// <summary>
        /// Filter on node id.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Include only if disabled matches supplied value.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// Filter on subject.
        /// </summary>
        [EnumMember(Value = "subject")]
        Subject,
    }

    /// <summary>
    /// Filter to determine which Release records are returned.
    /// </summary>
    public enum ReleaseFilter
    {
        /// <summary>
        /// Filter on node id.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Filter on account.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// Filter on impact.
        /// </summary>
        [EnumMember(Value = "impact")]
        Impact,
        /// <summary>
        /// Filter on status.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,
        /// <summary>
        /// Filter on manager.
        /// </summary>
        [EnumMember(Value = "manager")]
        Manager,
        /// <summary>
        /// Completed in supplied range.
        /// </summary>
        [EnumMember(Value = "completedAt")]
        CompletedAt,
        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Target indication filter on completion target.
        /// </summary>
        [EnumMember(Value = "completionTargetIndication")]
        CompletionTargetIndication,
        /// <summary>
        /// Completion target in supplied range.
        /// </summary>
        [EnumMember(Value = "completionTargetAt")]
        CompletionTargetAt,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// Filter on subject.
        /// </summary>
        [EnumMember(Value = "subject")]
        Subject,
        /// <summary>
        /// Include only if mentioning me matches supplied value.
        /// </summary>
        [EnumMember(Value = "mentioningMe")]
        MentioningMe,
        /// <summary>
        /// Filter on record id as displayed in ui.
        /// </summary>
        [EnumMember(Value = "releaseId")]
        ReleaseId,
    }

    /// <summary>
    /// Filter to determine which Request records are returned.
    /// </summary>
    public enum RequestFilter
    {
        /// <summary>
        /// Filter on node id.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Filter on team.
        /// </summary>
        [EnumMember(Value = "team")]
        Team,
        /// <summary>
        /// Filter on member.
        /// </summary>
        [EnumMember(Value = "member")]
        Member,
        /// <summary>
        /// Filter on status.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,
        /// <summary>
        /// Filter on completion reason.
        /// </summary>
        [EnumMember(Value = "completionReason")]
        CompletionReason,
        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Completed in supplied range.
        /// </summary>
        [EnumMember(Value = "completedAt")]
        CompletedAt,
        /// <summary>
        /// Target indication filter on next target.
        /// </summary>
        [EnumMember(Value = "nextTargetIndication")]
        NextTargetIndication,
        /// <summary>
        /// Next target in supplied range.
        /// </summary>
        [EnumMember(Value = "nextTargetAt")]
        NextTargetAt,
        /// <summary>
        /// Filter on major incident status.
        /// </summary>
        [EnumMember(Value = "majorIncidentStatus")]
        MajorIncidentStatus,
        /// <summary>
        /// Filter on tag.
        /// </summary>
        [EnumMember(Value = "tag")]
        Tag,
        /// <summary>
        /// Filter on account.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// Filter on subject.
        /// </summary>
        [EnumMember(Value = "subject")]
        Subject,
        /// <summary>
        /// Filter on category.
        /// </summary>
        [EnumMember(Value = "category")]
        Category,
        /// <summary>
        /// Filter on impact.
        /// </summary>
        [EnumMember(Value = "impact")]
        Impact,
        /// <summary>
        /// Filter on grouping.
        /// </summary>
        [EnumMember(Value = "grouping")]
        Grouping,
        /// <summary>
        /// Filter on grouped into.
        /// </summary>
        [EnumMember(Value = "groupedInto")]
        GroupedInto,
        /// <summary>
        /// Filter on satisfaction.
        /// </summary>
        [EnumMember(Value = "satisfaction")]
        Satisfaction,
        /// <summary>
        /// Filter on created by.
        /// </summary>
        [EnumMember(Value = "createdBy")]
        CreatedBy,
        /// <summary>
        /// Filter on workflow.
        /// </summary>
        [EnumMember(Value = "workflow")]
        Workflow,
        /// <summary>
        /// Filter on workflow category.
        /// </summary>
        [EnumMember(Value = "workflowCategory")]
        WorkflowCategory,
        /// <summary>
        /// Filter on workflow status.
        /// </summary>
        [EnumMember(Value = "workflowStatus")]
        WorkflowStatus,
        /// <summary>
        /// Filter on workflow template.
        /// </summary>
        [EnumMember(Value = "workflowTemplate")]
        WorkflowTemplate,
        /// <summary>
        /// Filter on workflow type.
        /// </summary>
        [EnumMember(Value = "workflowType")]
        WorkflowType,
        /// <summary>
        /// Filter on service instance.
        /// </summary>
        [EnumMember(Value = "serviceInstance")]
        ServiceInstance,
        /// <summary>
        /// Filter on service.
        /// </summary>
        [EnumMember(Value = "service")]
        Service,
        /// <summary>
        /// Filter on service provider.
        /// </summary>
        [EnumMember(Value = "serviceProvider")]
        ServiceProvider,
        /// <summary>
        /// Filter on service problem manager.
        /// </summary>
        [EnumMember(Value = "serviceProblemManager")]
        ServiceProblemManager,
        /// <summary>
        /// Filter on service owner.
        /// </summary>
        [EnumMember(Value = "serviceOwner")]
        ServiceOwner,
        /// <summary>
        /// Filter on service category.
        /// </summary>
        [EnumMember(Value = "serviceCategory")]
        ServiceCategory,
        /// <summary>
        /// Filter on requested by.
        /// </summary>
        [EnumMember(Value = "requestedBy")]
        RequestedBy,
        /// <summary>
        /// Filter on requester.
        /// </summary>
        [EnumMember(Value = "requestedFor")]
        RequestedFor,
        /// <summary>
        /// Filter on site.
        /// </summary>
        [EnumMember(Value = "requestedForSite")]
        RequestedForSite,
        /// <summary>
        /// Include only if requested for vip matches supplied value.
        /// </summary>
        [EnumMember(Value = "requestedForVip")]
        RequestedForVip,
        /// <summary>
        /// Filter on business unit.
        /// </summary>
        [EnumMember(Value = "businessUnit")]
        BusinessUnit,
        /// <summary>
        /// Filter on requester organization.
        /// </summary>
        [EnumMember(Value = "organization")]
        Organization,
        /// <summary>
        /// Filter on requester organization region.
        /// </summary>
        [EnumMember(Value = "organizationRegion")]
        OrganizationRegion,
        /// <summary>
        /// Filter on knowledge article.
        /// </summary>
        [EnumMember(Value = "knowledgeArticle")]
        KnowledgeArticle,
        /// <summary>
        /// Filter on template.
        /// </summary>
        [EnumMember(Value = "template")]
        Template,
        /// <summary>
        /// Filter on configuration item.
        /// </summary>
        [EnumMember(Value = "ci")]
        Ci,
        /// <summary>
        /// Filter on operating system.
        /// </summary>
        [EnumMember(Value = "operatingSystem")]
        OperatingSystem,
        /// <summary>
        /// Filter on product.
        /// </summary>
        [EnumMember(Value = "product")]
        Product,
        /// <summary>
        /// Filter on product category.
        /// </summary>
        [EnumMember(Value = "productCategory")]
        ProductCategory,
        /// <summary>
        /// Filter on product brand.
        /// </summary>
        [EnumMember(Value = "productBrand")]
        ProductBrand,
        /// <summary>
        /// Filter on project.
        /// </summary>
        [EnumMember(Value = "project")]
        Project,
        /// <summary>
        /// Filter on problem.
        /// </summary>
        [EnumMember(Value = "problem")]
        Problem,
        /// <summary>
        /// Filter on supplier.
        /// </summary>
        [EnumMember(Value = "supplier")]
        Supplier,
        /// <summary>
        /// Filter on supplier request id - **deprecated** please use `supplier request id`.
        /// </summary>
        [EnumMember(Value = "supplierRequestid")]
        SupplierRequestid,
        /// <summary>
        /// Filter on supplier request id.
        /// </summary>
        [EnumMember(Value = "supplierRequestID")]
        SupplierRequestID,
        /// <summary>
        /// Downtime start in supplied range.
        /// </summary>
        [EnumMember(Value = "downtimeStartAt")]
        DowntimeStartAt,
        /// <summary>
        /// Downtime end in supplied range.
        /// </summary>
        [EnumMember(Value = "downtimeEndAt")]
        DowntimeEndAt,
        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Include only if urgent matches supplied value.
        /// </summary>
        [EnumMember(Value = "urgent")]
        Urgent,
        /// <summary>
        /// Include only if provider not accountable matches supplied value.
        /// </summary>
        [EnumMember(Value = "providerNotAccountable")]
        ProviderNotAccountable,
        /// <summary>
        /// Include only if provider was not accountable matches supplied value.
        /// </summary>
        [EnumMember(Value = "providerWasNotAccountable")]
        ProviderWasNotAccountable,
        /// <summary>
        /// Include only if registered by service desk matches supplied value.
        /// </summary>
        [EnumMember(Value = "registeredBySd")]
        RegisteredBySd,
        /// <summary>
        /// Responded in supplied range.
        /// </summary>
        [EnumMember(Value = "satisfactionAt")]
        SatisfactionAt,
        /// <summary>
        /// Include only if addressed matches supplied value.
        /// </summary>
        [EnumMember(Value = "addressed")]
        Addressed,
        /// <summary>
        /// Filter on agile board.
        /// </summary>
        [EnumMember(Value = "agileBoard")]
        AgileBoard,
        /// <summary>
        /// Filter on agile board column.
        /// </summary>
        [EnumMember(Value = "agileBoardColumn")]
        AgileBoardColumn,
        /// <summary>
        /// Filter on product backlog.
        /// </summary>
        [EnumMember(Value = "productBacklog")]
        ProductBacklog,
        /// <summary>
        /// Desired completion in supplied range.
        /// </summary>
        [EnumMember(Value = "desiredCompletionAt")]
        DesiredCompletionAt,
        /// <summary>
        /// Include only if mentioning me matches supplied value.
        /// </summary>
        [EnumMember(Value = "mentioningMe")]
        MentioningMe,
        /// <summary>
        /// Include only if last note by requester matches supplied value.
        /// </summary>
        [EnumMember(Value = "lastNoteByRequester")]
        LastNoteByRequester,
        /// <summary>
        /// Filter on feedback on knowledge article.
        /// </summary>
        [EnumMember(Value = "feedbackOnKnowledgeArticle")]
        FeedbackOnKnowledgeArticle,
        /// <summary>
        /// Filter on customer account.
        /// </summary>
        [EnumMember(Value = "slaCustomerAccount")]
        SlaCustomerAccount,
        /// <summary>
        /// Filter on id.
        /// </summary>
        [EnumMember(Value = "slaServiceProvider")]
        SlaServiceProvider,
        /// <summary>
        /// Filter on provider account.
        /// </summary>
        [EnumMember(Value = "slaProviderAccount")]
        SlaProviderAccount,
        /// <summary>
        /// Filter on customer.
        /// </summary>
        [EnumMember(Value = "slaCustomer")]
        SlaCustomer,
        /// <summary>
        /// Filter on customer region.
        /// </summary>
        [EnumMember(Value = "slaCustomerRegion")]
        SlaCustomerRegion,
        /// <summary>
        /// Filter on person.
        /// </summary>
        [EnumMember(Value = "respondent")]
        Respondent,
        /// <summary>
        /// Filter on response.
        /// </summary>
        [EnumMember(Value = "response")]
        Response,
        /// <summary>
        /// Responded in supplied range.
        /// </summary>
        [EnumMember(Value = "respondedAt")]
        RespondedAt,
        /// <summary>
        /// Filter on affected service level agreement.
        /// </summary>
        [EnumMember(Value = "affectedSla")]
        AffectedSla,
        /// <summary>
        /// Filter on affected service.
        /// </summary>
        [EnumMember(Value = "affectedService")]
        AffectedService,
        /// <summary>
        /// Filter on affected service instance.
        /// </summary>
        [EnumMember(Value = "affectedServiceInstance")]
        AffectedServiceInstance,
        /// <summary>
        /// Filter on affected service provider.
        /// </summary>
        [EnumMember(Value = "affectedServiceProvider")]
        AffectedServiceProvider,
        /// <summary>
        /// Filter on record id as displayed in ui.
        /// </summary>
        [EnumMember(Value = "requestId")]
        RequestId,
    }

    /// <summary>
    /// Filter to determine which RequestTemplate records are returned.
    /// </summary>
    public enum RequestTemplateFilter
    {
        /// <summary>
        /// Filter on node id.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Filter on category.
        /// </summary>
        [EnumMember(Value = "category")]
        Category,
        /// <summary>
        /// Filter on impact.
        /// </summary>
        [EnumMember(Value = "impact")]
        Impact,
        /// <summary>
        /// Filter on service.
        /// </summary>
        [EnumMember(Value = "service")]
        Service,
        /// <summary>
        /// Include only if end users matches supplied value.
        /// </summary>
        [EnumMember(Value = "endUsers")]
        EndUsers,
        /// <summary>
        /// Include only if specialists matches supplied value.
        /// </summary>
        [EnumMember(Value = "specialists")]
        Specialists,
        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Include only if disabled matches supplied value.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// Filter on subject.
        /// </summary>
        [EnumMember(Value = "subject")]
        Subject,
        /// <summary>
        /// Filter on member.
        /// </summary>
        [EnumMember(Value = "member")]
        Member,
        /// <summary>
        /// Filter on team.
        /// </summary>
        [EnumMember(Value = "team")]
        Team,
        /// <summary>
        /// Filter on workflow manager.
        /// </summary>
        [EnumMember(Value = "workflowManager")]
        WorkflowManager,
        /// <summary>
        /// Filter on workflow template.
        /// </summary>
        [EnumMember(Value = "workflowTemplate")]
        WorkflowTemplate,
        /// <summary>
        /// Filter on ui extension.
        /// </summary>
        [EnumMember(Value = "uiExtension")]
        UiExtension,
    }

    /// <summary>
    /// Filter to determine which Reservation records are returned.
    /// </summary>
    public enum ReservationFilter
    {
        /// <summary>
        /// Filter on node id.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Filter on account.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// Filter on reservation offering.
        /// </summary>
        [EnumMember(Value = "reservationOffering")]
        ReservationOffering,
        /// <summary>
        /// Filter on person.
        /// </summary>
        [EnumMember(Value = "person")]
        Person,
        /// <summary>
        /// Filter on asset.
        /// </summary>
        [EnumMember(Value = "ci")]
        Ci,
        /// <summary>
        /// Preparation start in supplied range.
        /// </summary>
        [EnumMember(Value = "preparationStartAt")]
        PreparationStartAt,
        /// <summary>
        /// Start in supplied range.
        /// </summary>
        [EnumMember(Value = "startAt")]
        StartAt,
        /// <summary>
        /// End in supplied range.
        /// </summary>
        [EnumMember(Value = "endAt")]
        EndAt,
        /// <summary>
        /// Filter on status.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,
        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// Filter on name.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// Filter on service.
        /// </summary>
        [EnumMember(Value = "service")]
        Service,
        /// <summary>
        /// Filter on service instance.
        /// </summary>
        [EnumMember(Value = "serviceInstance")]
        ServiceInstance,
        /// <summary>
        /// Include only if recurrent matches supplied value.
        /// </summary>
        [EnumMember(Value = "recurrent")]
        Recurrent,
    }

    /// <summary>
    /// Filter to determine which ReservationOffering records are returned.
    /// </summary>
    public enum ReservationOfferingFilter
    {
        /// <summary>
        /// Filter on node id.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Filter on service.
        /// </summary>
        [EnumMember(Value = "service")]
        Service,
        /// <summary>
        /// Filter on service instance.
        /// </summary>
        [EnumMember(Value = "serviceInstance")]
        ServiceInstance,
        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// Include only if disabled matches supplied value.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// Filter on name.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// Include only if allow repeat matches supplied value.
        /// </summary>
        [EnumMember(Value = "allowRepeat")]
        AllowRepeat,
    }

    /// <summary>
    /// Filter to determine which Risk records are returned.
    /// </summary>
    public enum RiskFilter
    {
        /// <summary>
        /// Filter on node id.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Filter on account.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// Filter on manager.
        /// </summary>
        [EnumMember(Value = "manager")]
        Manager,
        /// <summary>
        /// Filter on severity.
        /// </summary>
        [EnumMember(Value = "severity")]
        Severity,
        /// <summary>
        /// Filter on status.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,
        /// <summary>
        /// Target indication filter on mitigation target.
        /// </summary>
        [EnumMember(Value = "mitigationTargetIndication")]
        MitigationTargetIndication,
        /// <summary>
        /// Mitigation target in supplied range.
        /// </summary>
        [EnumMember(Value = "mitigationTargetAt")]
        MitigationTargetAt,
        /// <summary>
        /// Closed in supplied range.
        /// </summary>
        [EnumMember(Value = "closedAt")]
        ClosedAt,
        /// <summary>
        /// Filter on closure reason.
        /// </summary>
        [EnumMember(Value = "closureReason")]
        ClosureReason,
        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Filter on project.
        /// </summary>
        [EnumMember(Value = "project")]
        Project,
        /// <summary>
        /// Filter on service.
        /// </summary>
        [EnumMember(Value = "service")]
        Service,
        /// <summary>
        /// Filter on organization.
        /// </summary>
        [EnumMember(Value = "organization")]
        Organization,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// Filter on subject.
        /// </summary>
        [EnumMember(Value = "subject")]
        Subject,
        /// <summary>
        /// Include only if mentioning me matches supplied value.
        /// </summary>
        [EnumMember(Value = "mentioningMe")]
        MentioningMe,
        /// <summary>
        /// Filter on record id as displayed in ui.
        /// </summary>
        [EnumMember(Value = "riskId")]
        RiskId,
    }

    /// <summary>
    /// Attributes to filter on basic fields.
    /// </summary>
    public enum RiskSeverityFilter
    {
        /// <summary>
        /// Ids to select.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Created at in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated at in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
    }

    /// <summary>
    /// Filter to determine which ScrumWorkspace records are returned.
    /// </summary>
    public enum ScrumWorkspaceFilter
    {
        /// <summary>
        /// Filter on node id.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Include only if disabled matches supplied value.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// Filter on name.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// Filter on team.
        /// </summary>
        [EnumMember(Value = "team")]
        Team,
        /// <summary>
        /// Filter on product backlog.
        /// </summary>
        [EnumMember(Value = "productBacklog")]
        ProductBacklog,
    }

    /// <summary>
    /// Attributes to filter service categories.
    /// </summary>
    public enum ServiceCategoryFilter
    {
        /// <summary>
        /// Ids to select.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Created at in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated at in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// Name of service category.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
    }

    /// <summary>
    /// Filter to determine which Service records are returned.
    /// </summary>
    public enum ServiceFilter
    {
        /// <summary>
        /// Filter on node id.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Filter on account.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// Filter on service provider.
        /// </summary>
        [EnumMember(Value = "provider")]
        Provider,
        /// <summary>
        /// Filter on first line team.
        /// </summary>
        [EnumMember(Value = "firstLineTeam")]
        FirstLineTeam,
        /// <summary>
        /// Filter on support team.
        /// </summary>
        [EnumMember(Value = "supportTeam")]
        SupportTeam,
        /// <summary>
        /// Filter on service owner.
        /// </summary>
        [EnumMember(Value = "serviceOwner")]
        ServiceOwner,
        /// <summary>
        /// Filter on release manager.
        /// </summary>
        [EnumMember(Value = "releaseManager")]
        ReleaseManager,
        /// <summary>
        /// Filter on change manager.
        /// </summary>
        [EnumMember(Value = "changeManager")]
        ChangeManager,
        /// <summary>
        /// Filter on knowledge manager.
        /// </summary>
        [EnumMember(Value = "knowledgeManager")]
        KnowledgeManager,
        /// <summary>
        /// Filter on problem manager.
        /// </summary>
        [EnumMember(Value = "problemManager")]
        ProblemManager,
        /// <summary>
        /// Filter on availability manager.
        /// </summary>
        [EnumMember(Value = "availabilityManager")]
        AvailabilityManager,
        /// <summary>
        /// Filter on capacity manager.
        /// </summary>
        [EnumMember(Value = "capacityManager")]
        CapacityManager,
        /// <summary>
        /// Filter on continuity manager.
        /// </summary>
        [EnumMember(Value = "continuityManager")]
        ContinuityManager,
        /// <summary>
        /// Filter on survey.
        /// </summary>
        [EnumMember(Value = "survey")]
        Survey,
        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Include only if disabled matches supplied value.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// Filter on name.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
    }

    /// <summary>
    /// Filter to determine which ServiceInstance records are returned.
    /// </summary>
    public enum ServiceInstanceFilter
    {
        /// <summary>
        /// Filter on node id.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Filter on account.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// Filter on status.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,
        /// <summary>
        /// Filter on service.
        /// </summary>
        [EnumMember(Value = "service")]
        Service,
        /// <summary>
        /// Filter on service owner.
        /// </summary>
        [EnumMember(Value = "serviceOwner")]
        ServiceOwner,
        /// <summary>
        /// Filter on service provider.
        /// </summary>
        [EnumMember(Value = "serviceProvider")]
        ServiceProvider,
        /// <summary>
        /// Filter on first line team.
        /// </summary>
        [EnumMember(Value = "firstLineTeam")]
        FirstLineTeam,
        /// <summary>
        /// Filter on support team.
        /// </summary>
        [EnumMember(Value = "supportTeam")]
        SupportTeam,
        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// Filter on service level agreement.
        /// </summary>
        [EnumMember(Value = "sla")]
        Sla,
        /// <summary>
        /// Filter on name.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
    }

    /// <summary>
    /// Filter to determine which ServiceLevelAgreement records are returned.
    /// </summary>
    public enum ServiceLevelAgreementFilter
    {
        /// <summary>
        /// Filter on node id.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Filter on account.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// Filter on customer account.
        /// </summary>
        [EnumMember(Value = "customerAccount")]
        CustomerAccount,
        /// <summary>
        /// Filter on support domain.
        /// </summary>
        [EnumMember(Value = "supportDomain")]
        SupportDomain,
        /// <summary>
        /// Filter on status.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,
        /// <summary>
        /// Filter on coverage.
        /// </summary>
        [EnumMember(Value = "coverage")]
        Coverage,
        /// <summary>
        /// Filter on customer.
        /// </summary>
        [EnumMember(Value = "customer")]
        Customer,
        /// <summary>
        /// Filter on service.
        /// </summary>
        [EnumMember(Value = "service")]
        Service,
        /// <summary>
        /// Filter on service instance.
        /// </summary>
        [EnumMember(Value = "serviceInstance")]
        ServiceInstance,
        /// <summary>
        /// Filter on service offering.
        /// </summary>
        [EnumMember(Value = "serviceOffering")]
        ServiceOffering,
        /// <summary>
        /// Filter on service provider.
        /// </summary>
        [EnumMember(Value = "serviceProvider")]
        ServiceProvider,
        /// <summary>
        /// Filter on service owner.
        /// </summary>
        [EnumMember(Value = "serviceOwner")]
        ServiceOwner,
        /// <summary>
        /// Filter on service level manager.
        /// </summary>
        [EnumMember(Value = "serviceLevelManager")]
        ServiceLevelManager,
        /// <summary>
        /// Filter on customer representative.
        /// </summary>
        [EnumMember(Value = "customerRep")]
        CustomerRep,
        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Start date in supplied range.
        /// </summary>
        [EnumMember(Value = "startDate")]
        StartDate,
        /// <summary>
        /// Notice date in supplied range.
        /// </summary>
        [EnumMember(Value = "noticeDate")]
        NoticeDate,
        /// <summary>
        /// Expiry date in supplied range.
        /// </summary>
        [EnumMember(Value = "expiryDate")]
        ExpiryDate,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// Filter on name.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
    }

    /// <summary>
    /// Filter to determine which ServiceOffering records are returned.
    /// </summary>
    public enum ServiceOfferingFilter
    {
        /// <summary>
        /// Filter on node id.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Filter on service.
        /// </summary>
        [EnumMember(Value = "service")]
        Service,
        /// <summary>
        /// Filter on status.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,
        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// Filter on service level agreement.
        /// </summary>
        [EnumMember(Value = "sla")]
        Sla,
        /// <summary>
        /// Filter on name.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
    }

    /// <summary>
    /// Filter to determine which ShopArticleCategory records are returned.
    /// </summary>
    public enum ShopArticleCategoryFilter
    {
        /// <summary>
        /// Filter on node id.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Filter on account.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// Filter on name.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
    }

    /// <summary>
    /// Filter to determine which ShopArticle records are returned.
    /// </summary>
    public enum ShopArticleFilter
    {
        /// <summary>
        /// Filter on node id.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Filter on provider account.
        /// </summary>
        [EnumMember(Value = "providerAccount")]
        ProviderAccount,
        /// <summary>
        /// Filter on fulfillment template.
        /// </summary>
        [EnumMember(Value = "fulfillmentTemplate")]
        FulfillmentTemplate,
        /// <summary>
        /// Filter on product.
        /// </summary>
        [EnumMember(Value = "product")]
        Product,
        /// <summary>
        /// Filter on category.
        /// </summary>
        [EnumMember(Value = "category")]
        Category,
        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Include only if disabled matches supplied value.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// Filter on name.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// Filter on reference.
        /// </summary>
        [EnumMember(Value = "reference")]
        Reference,
        /// <summary>
        /// Start in supplied range.
        /// </summary>
        [EnumMember(Value = "startAt")]
        StartAt,
        /// <summary>
        /// End in supplied range.
        /// </summary>
        [EnumMember(Value = "endAt")]
        EndAt,
        /// <summary>
        /// Filter on min. quantity.
        /// </summary>
        [EnumMember(Value = "minQuantity")]
        MinQuantity,
        /// <summary>
        /// Filter on max. quantity.
        /// </summary>
        [EnumMember(Value = "maxQuantity")]
        MaxQuantity,
        /// <summary>
        /// Filter on price.
        /// </summary>
        [EnumMember(Value = "price")]
        Price,
        /// <summary>
        /// Filter on recurring period.
        /// </summary>
        [EnumMember(Value = "recurringPeriod")]
        RecurringPeriod,
        /// <summary>
        /// Filter on recurring price.
        /// </summary>
        [EnumMember(Value = "recurringPrice")]
        RecurringPrice,
        /// <summary>
        /// Filter on delivery duration.
        /// </summary>
        [EnumMember(Value = "deliveryDuration")]
        DeliveryDuration,
    }

    /// <summary>
    /// Filter to determine which ShopOrderLine records are returned.
    /// </summary>
    public enum ShopOrderLineFilter
    {
        /// <summary>
        /// Filter on node id.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// Filter on status.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,
        /// <summary>
        /// Filter on name.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// Filter on reference.
        /// </summary>
        [EnumMember(Value = "reference")]
        Reference,
        /// <summary>
        /// Filter on quantity.
        /// </summary>
        [EnumMember(Value = "quantity")]
        Quantity,
        /// <summary>
        /// Filter on price.
        /// </summary>
        [EnumMember(Value = "price")]
        Price,
        /// <summary>
        /// Filter on order account.
        /// </summary>
        [EnumMember(Value = "orderAccount")]
        OrderAccount,
        /// <summary>
        /// Filter on recurring period.
        /// </summary>
        [EnumMember(Value = "recurringPeriod")]
        RecurringPeriod,
        /// <summary>
        /// Filter on recurring price.
        /// </summary>
        [EnumMember(Value = "recurringPrice")]
        RecurringPrice,
        /// <summary>
        /// Filter on requester account.
        /// </summary>
        [EnumMember(Value = "requesterAccount")]
        RequesterAccount,
        /// <summary>
        /// Filter on provider account.
        /// </summary>
        [EnumMember(Value = "providerAccount")]
        ProviderAccount,
        /// <summary>
        /// Filter on provider price.
        /// </summary>
        [EnumMember(Value = "providerPrice")]
        ProviderPrice,
        /// <summary>
        /// Filter on provider recurring period.
        /// </summary>
        [EnumMember(Value = "providerRecurringPeriod")]
        ProviderRecurringPeriod,
        /// <summary>
        /// Filter on provider recurring price.
        /// </summary>
        [EnumMember(Value = "providerRecurringPrice")]
        ProviderRecurringPrice,
        /// <summary>
        /// Filter on requester.
        /// </summary>
        [EnumMember(Value = "requestedFor")]
        RequestedFor,
        /// <summary>
        /// Ordered in supplied range.
        /// </summary>
        [EnumMember(Value = "orderedAt")]
        OrderedAt,
        /// <summary>
        /// Completed in supplied range.
        /// </summary>
        [EnumMember(Value = "completedAt")]
        CompletedAt,
        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// Filter to determine which ShortUrl records are returned.
    /// </summary>
    public enum ShortUrlFilter
    {
        /// <summary>
        /// Filter on node id.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Filter on created by.
        /// </summary>
        [EnumMember(Value = "createdBy")]
        CreatedBy,
        /// <summary>
        /// Filter on type.
        /// </summary>
        [EnumMember(Value = "dataType")]
        DataType,
    }

    /// <summary>
    /// Filter to determine which Site records are returned.
    /// </summary>
    public enum SiteFilter
    {
        /// <summary>
        /// Filter on node id.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Filter on account.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Include only if disabled matches supplied value.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// Filter on name.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
    }

    /// <summary>
    /// Filter to determine which SkillPool records are returned.
    /// </summary>
    public enum SkillPoolFilter
    {
        /// <summary>
        /// Filter on node id.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Include only if disabled matches supplied value.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// Filter on manager.
        /// </summary>
        [EnumMember(Value = "manager")]
        Manager,
        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// Filter on name.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
    }

    /// <summary>
    /// Attributes to filter on basic fields.
    /// </summary>
    public enum SlaNotificationSchemeFilter
    {
        /// <summary>
        /// Ids to select.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Created at in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated at in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
    }

    /// <summary>
    /// Filter to determine which Sprint records are returned.
    /// </summary>
    public enum SprintFilter
    {
        /// <summary>
        /// Filter on node id.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Filter on scrum workspace.
        /// </summary>
        [EnumMember(Value = "scrumWorkspace")]
        ScrumWorkspace,
        /// <summary>
        /// Filter on status.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,
        /// <summary>
        /// Start at in supplied range.
        /// </summary>
        [EnumMember(Value = "startAt")]
        StartAt,
        /// <summary>
        /// End at in supplied range.
        /// </summary>
        [EnumMember(Value = "endAt")]
        EndAt,
        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
    }

    /// <summary>
    /// Filter to determine which Survey records are returned.
    /// </summary>
    public enum SurveyFilter
    {
        /// <summary>
        /// Filter on node id.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// Filter on name.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// Include only if disabled matches supplied value.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// Filter on service.
        /// </summary>
        [EnumMember(Value = "service")]
        Service,
    }

    /// <summary>
    /// Filter to determine which SurveyResponse records are returned.
    /// </summary>
    public enum SurveyResponseFilter
    {
        /// <summary>
        /// Filter on node id.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Filter on survey.
        /// </summary>
        [EnumMember(Value = "survey")]
        Survey,
        /// <summary>
        /// Filter on service.
        /// </summary>
        [EnumMember(Value = "service")]
        Service,
        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Responded in supplied range.
        /// </summary>
        [EnumMember(Value = "respondedAt")]
        RespondedAt,
        /// <summary>
        /// Filter on rating.
        /// </summary>
        [EnumMember(Value = "rating")]
        Rating,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// Include only if completed matches supplied value.
        /// </summary>
        [EnumMember(Value = "completed")]
        Completed,
        /// <summary>
        /// Filter on service level agreement.
        /// </summary>
        [EnumMember(Value = "sla")]
        Sla,
        /// <summary>
        /// Filter on account.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// Filter on customer account.
        /// </summary>
        [EnumMember(Value = "customerAccount")]
        CustomerAccount,
    }

    /// <summary>
    /// Attributes to filter on basic fields.
    /// </summary>
    public enum SyncSetFilter
    {
        /// <summary>
        /// Ids to select.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Created at in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated at in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// Filter to determine which Task records are returned.
    /// </summary>
    public enum TaskFilter
    {
        /// <summary>
        /// Filter on node id.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Filter on account.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// Filter on status.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,
        /// <summary>
        /// Filter on category.
        /// </summary>
        [EnumMember(Value = "category")]
        Category,
        /// <summary>
        /// Filter on impact.
        /// </summary>
        [EnumMember(Value = "impact")]
        Impact,
        /// <summary>
        /// Filter on template.
        /// </summary>
        [EnumMember(Value = "template")]
        Template,
        /// <summary>
        /// Filter on team.
        /// </summary>
        [EnumMember(Value = "team")]
        Team,
        /// <summary>
        /// Filter on template team.
        /// </summary>
        [EnumMember(Value = "templateTeam")]
        TemplateTeam,
        /// <summary>
        /// Filter on assignee.
        /// </summary>
        [EnumMember(Value = "assignee")]
        Assignee,
        /// <summary>
        /// Filter on manager.
        /// </summary>
        [EnumMember(Value = "manager")]
        Manager,
        /// <summary>
        /// Filter on service.
        /// </summary>
        [EnumMember(Value = "service")]
        Service,
        /// <summary>
        /// Filter on service instance.
        /// </summary>
        [EnumMember(Value = "serviceInstance")]
        ServiceInstance,
        /// <summary>
        /// Filter on supplier.
        /// </summary>
        [EnumMember(Value = "supplier")]
        Supplier,
        /// <summary>
        /// Filter on supplier request id.
        /// </summary>
        [EnumMember(Value = "supplierRequestID")]
        SupplierRequestID,
        /// <summary>
        /// Filter on release.
        /// </summary>
        [EnumMember(Value = "release")]
        Release,
        /// <summary>
        /// Filter on workflow.
        /// </summary>
        [EnumMember(Value = "workflow")]
        Workflow,
        /// <summary>
        /// Filter on workflow type.
        /// </summary>
        [EnumMember(Value = "workflowType")]
        WorkflowType,
        /// <summary>
        /// Filter on workflow category.
        /// </summary>
        [EnumMember(Value = "workflowCategory")]
        WorkflowCategory,
        /// <summary>
        /// Filter on justification.
        /// </summary>
        [EnumMember(Value = "workflowJustification")]
        WorkflowJustification,
        /// <summary>
        /// Include only if created from request matches supplied value.
        /// </summary>
        [EnumMember(Value = "createdFromRequest")]
        CreatedFromRequest,
        /// <summary>
        /// Filter on requester organization.
        /// </summary>
        [EnumMember(Value = "requesterOrganization")]
        RequesterOrganization,
        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Finished in supplied range.
        /// </summary>
        [EnumMember(Value = "finishedAt")]
        FinishedAt,
        /// <summary>
        /// Target indication filter on completion target.
        /// </summary>
        [EnumMember(Value = "completionTargetIndication")]
        CompletionTargetIndication,
        /// <summary>
        /// Completion target in supplied range.
        /// </summary>
        [EnumMember(Value = "completionTargetAt")]
        CompletionTargetAt,
        /// <summary>
        /// Include only if urgent matches supplied value.
        /// </summary>
        [EnumMember(Value = "urgent")]
        Urgent,
        /// <summary>
        /// Include only if provider not accountable matches supplied value.
        /// </summary>
        [EnumMember(Value = "providerNotAccountable")]
        ProviderNotAccountable,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// Filter on subject.
        /// </summary>
        [EnumMember(Value = "subject")]
        Subject,
        /// <summary>
        /// Filter on agile board.
        /// </summary>
        [EnumMember(Value = "agileBoard")]
        AgileBoard,
        /// <summary>
        /// Filter on agile board column.
        /// </summary>
        [EnumMember(Value = "agileBoardColumn")]
        AgileBoardColumn,
        /// <summary>
        /// Include only if mentioning me matches supplied value.
        /// </summary>
        [EnumMember(Value = "mentioningMe")]
        MentioningMe,
        /// <summary>
        /// Filter on skill pool.
        /// </summary>
        [EnumMember(Value = "skillPool")]
        SkillPool,
        /// <summary>
        /// Filter on record id as displayed in ui.
        /// </summary>
        [EnumMember(Value = "taskId")]
        TaskId,
    }

    /// <summary>
    /// Filter to determine which TaskTemplate records are returned.
    /// </summary>
    public enum TaskTemplateFilter
    {
        /// <summary>
        /// Filter on node id.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Filter on workflow template.
        /// </summary>
        [EnumMember(Value = "workflowTemplate")]
        WorkflowTemplate,
        /// <summary>
        /// Filter on team.
        /// </summary>
        [EnumMember(Value = "team")]
        Team,
        /// <summary>
        /// Filter on skill pool.
        /// </summary>
        [EnumMember(Value = "skillPool")]
        SkillPool,
        /// <summary>
        /// Filter on assignee.
        /// </summary>
        [EnumMember(Value = "assignee")]
        Assignee,
        /// <summary>
        /// Filter on category.
        /// </summary>
        [EnumMember(Value = "category")]
        Category,
        /// <summary>
        /// Filter on impact.
        /// </summary>
        [EnumMember(Value = "impact")]
        Impact,
        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Include only if disabled matches supplied value.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// Filter on subject.
        /// </summary>
        [EnumMember(Value = "subject")]
        Subject,
        /// <summary>
        /// Include only if provider not accountable matches supplied value.
        /// </summary>
        [EnumMember(Value = "providerNotAccountable")]
        ProviderNotAccountable,
    }

    /// <summary>
    /// Filter to determine which Team records are returned.
    /// </summary>
    public enum TeamFilter
    {
        /// <summary>
        /// Filter on node id.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Include only if disabled matches supplied value.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// Filter on coordinator.
        /// </summary>
        [EnumMember(Value = "coordinator")]
        Coordinator,
        /// <summary>
        /// Filter on manager.
        /// </summary>
        [EnumMember(Value = "manager")]
        Manager,
        /// <summary>
        /// Filter on name.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
    }

    /// <summary>
    /// Filter to determine which TimeAllocation records are returned.
    /// </summary>
    public enum TimeAllocationFilter
    {
        /// <summary>
        /// Filter on node id.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// Filter on name.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// Include only if disabled matches supplied value.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
    }

    /// <summary>
    /// Filter to determine which TimeEntry records are returned.
    /// </summary>
    public enum TimeEntryFilter
    {
        /// <summary>
        /// Filter on node id.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Filter on account.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Date in supplied range.
        /// </summary>
        [EnumMember(Value = "date")]
        Date,
        /// <summary>
        /// Start in supplied range.
        /// </summary>
        [EnumMember(Value = "startedAt")]
        StartedAt,
        /// <summary>
        /// Filter on customer.
        /// </summary>
        [EnumMember(Value = "customer")]
        Customer,
        /// <summary>
        /// Filter on effort class.
        /// </summary>
        [EnumMember(Value = "effortClass")]
        EffortClass,
        /// <summary>
        /// Filter on organization.
        /// </summary>
        [EnumMember(Value = "organization")]
        Organization,
        /// <summary>
        /// Filter on workflow.
        /// </summary>
        [EnumMember(Value = "workflow")]
        Workflow,
        /// <summary>
        /// Filter on project.
        /// </summary>
        [EnumMember(Value = "project")]
        Project,
        /// <summary>
        /// Filter on person.
        /// </summary>
        [EnumMember(Value = "person")]
        Person,
        /// <summary>
        /// Filter on service.
        /// </summary>
        [EnumMember(Value = "service")]
        Service,
        /// <summary>
        /// Filter on service instance.
        /// </summary>
        [EnumMember(Value = "serviceInstance")]
        ServiceInstance,
        /// <summary>
        /// Filter on service level agreement.
        /// </summary>
        [EnumMember(Value = "sla")]
        Sla,
        /// <summary>
        /// Filter on team.
        /// </summary>
        [EnumMember(Value = "team")]
        Team,
        /// <summary>
        /// Filter on time allocation group.
        /// </summary>
        [EnumMember(Value = "timeAllocationGroup")]
        TimeAllocationGroup,
        /// <summary>
        /// Filter on time allocation.
        /// </summary>
        [EnumMember(Value = "timeAllocation")]
        TimeAllocation,
        /// <summary>
        /// Filter on request category.
        /// </summary>
        [EnumMember(Value = "requestCategory")]
        RequestCategory,
        /// <summary>
        /// Filter on project manager.
        /// </summary>
        [EnumMember(Value = "projectManager")]
        ProjectManager,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// Include only if deleted matches supplied value.
        /// </summary>
        [EnumMember(Value = "deleted")]
        Deleted,
    }

    /// <summary>
    /// Attributes to filter on basic fields.
    /// </summary>
    public enum TimesheetSettingFilter
    {
        /// <summary>
        /// Ids to select.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Created at in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated at in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
    }

    /// <summary>
    /// Filter to determine which Translation records are returned.
    /// </summary>
    public enum TranslationFilter
    {
        /// <summary>
        /// Filter on node id.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Filter on type.
        /// </summary>
        [EnumMember(Value = "type")]
        Type,
        /// <summary>
        /// Filter on record.
        /// </summary>
        [EnumMember(Value = "owner")]
        Owner,
        /// <summary>
        /// Include only if disabled matches supplied value.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// Filter on field.
        /// </summary>
        [EnumMember(Value = "field")]
        Field,
        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Filter on language.
        /// </summary>
        [EnumMember(Value = "language")]
        Language,
    }

    /// <summary>
    /// Filter to determine which Trash records are returned.
    /// </summary>
    public enum TrashFilter
    {
        /// <summary>
        /// Filter on node id.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Filter on name.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
    }

    /// <summary>
    /// Filter to determine which UiExtension records are returned.
    /// </summary>
    public enum UiExtensionFilter
    {
        /// <summary>
        /// Filter on node id.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Filter on category.
        /// </summary>
        [EnumMember(Value = "category")]
        Category,
        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Include only if disabled matches supplied value.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// Filter on name.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// Filter on created by.
        /// </summary>
        [EnumMember(Value = "createdBy")]
        CreatedBy,
        /// <summary>
        /// Filter on updated by.
        /// </summary>
        [EnumMember(Value = "updatedBy")]
        UpdatedBy,
    }

    /// <summary>
    /// Attributes to filter on basic fields.
    /// </summary>
    public enum WaitingForCustomerFollowUpFilter
    {
        /// <summary>
        /// Ids to select.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Created at in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated at in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
    }

    /// <summary>
    /// Attributes to filter on basic fields.
    /// </summary>
    public enum WebhookFilter
    {
        /// <summary>
        /// Ids to select.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Created at in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated at in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
    }

    /// <summary>
    /// Attributes to filter on basic fields.
    /// </summary>
    public enum WebhookPolicyFilter
    {
        /// <summary>
        /// Ids to select.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Created at in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated at in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// Filter to determine which Workflow records are returned.
    /// </summary>
    public enum WorkflowFilter
    {
        /// <summary>
        /// Filter on node id.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Filter on account.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>
        /// Filter on status.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,
        /// <summary>
        /// Filter on category.
        /// </summary>
        [EnumMember(Value = "category")]
        Category,
        /// <summary>
        /// Filter on impact.
        /// </summary>
        [EnumMember(Value = "impact")]
        Impact,
        /// <summary>
        /// Filter on justification.
        /// </summary>
        [EnumMember(Value = "justification")]
        Justification,
        /// <summary>
        /// Filter on type.
        /// </summary>
        [EnumMember(Value = "workflowType")]
        WorkflowType,
        /// <summary>
        /// Filter on service.
        /// </summary>
        [EnumMember(Value = "service")]
        Service,
        /// <summary>
        /// Filter on service owner.
        /// </summary>
        [EnumMember(Value = "serviceOwner")]
        ServiceOwner,
        /// <summary>
        /// Filter on service support team.
        /// </summary>
        [EnumMember(Value = "serviceSupportTeam")]
        ServiceSupportTeam,
        /// <summary>
        /// Filter on service provider.
        /// </summary>
        [EnumMember(Value = "serviceProvider")]
        ServiceProvider,
        /// <summary>
        /// Filter on manager.
        /// </summary>
        [EnumMember(Value = "manager")]
        Manager,
        /// <summary>
        /// Filter on manager organization.
        /// </summary>
        [EnumMember(Value = "managerOrganization")]
        ManagerOrganization,
        /// <summary>
        /// Filter on phase.
        /// </summary>
        [EnumMember(Value = "phase")]
        Phase,
        /// <summary>
        /// Target indication filter on completion target.
        /// </summary>
        [EnumMember(Value = "completionTargetIndication")]
        CompletionTargetIndication,
        /// <summary>
        /// Completion target in supplied range.
        /// </summary>
        [EnumMember(Value = "completionTargetAt")]
        CompletionTargetAt,
        /// <summary>
        /// Start in supplied range.
        /// </summary>
        [EnumMember(Value = "startAt")]
        StartAt,
        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Completed in supplied range.
        /// </summary>
        [EnumMember(Value = "completedAt")]
        CompletedAt,
        /// <summary>
        /// Filter on completion reason.
        /// </summary>
        [EnumMember(Value = "completionReason")]
        CompletionReason,
        /// <summary>
        /// Filter on project.
        /// </summary>
        [EnumMember(Value = "project")]
        Project,
        /// <summary>
        /// Filter on release.
        /// </summary>
        [EnumMember(Value = "release")]
        Release,
        /// <summary>
        /// Filter on template.
        /// </summary>
        [EnumMember(Value = "template")]
        Template,
        /// <summary>
        /// Include only if created from request matches supplied value.
        /// </summary>
        [EnumMember(Value = "createdFromRequest")]
        CreatedFromRequest,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// Filter on subject.
        /// </summary>
        [EnumMember(Value = "subject")]
        Subject,
        /// <summary>
        /// Filter on requester organization.
        /// </summary>
        [EnumMember(Value = "requesterOrganization")]
        RequesterOrganization,
        /// <summary>
        /// Include only if mentioning me matches supplied value.
        /// </summary>
        [EnumMember(Value = "mentioningMe")]
        MentioningMe,
        /// <summary>
        /// Filter on record id as displayed in ui.
        /// </summary>
        [EnumMember(Value = "workflowId")]
        WorkflowId,
    }

    /// <summary>
    /// Filter to determine which WorkflowTemplate records are returned.
    /// </summary>
    public enum WorkflowTemplateFilter
    {
        /// <summary>
        /// Filter on node id.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Filter on category.
        /// </summary>
        [EnumMember(Value = "category")]
        Category,
        /// <summary>
        /// Filter on impact.
        /// </summary>
        [EnumMember(Value = "impact")]
        Impact,
        /// <summary>
        /// Filter on justification.
        /// </summary>
        [EnumMember(Value = "justification")]
        Justification,
        /// <summary>
        /// Filter on type.
        /// </summary>
        [EnumMember(Value = "workflowType")]
        WorkflowType,
        /// <summary>
        /// Filter on service.
        /// </summary>
        [EnumMember(Value = "service")]
        Service,
        /// <summary>
        /// Created in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Include only if disabled matches supplied value.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// Filter on subject.
        /// </summary>
        [EnumMember(Value = "subject")]
        Subject,
    }

    /// <summary>
    /// Attributes to filter on basic fields.
    /// </summary>
    public enum WorkflowTypeFilter
    {
        /// <summary>
        /// Ids to select.
        /// </summary>
        [EnumMember(Value = "id")]
        ID,
        /// <summary>
        /// Created at in supplied range.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Updated at in supplied range.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Filter on source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Filter on source id.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
    }
}