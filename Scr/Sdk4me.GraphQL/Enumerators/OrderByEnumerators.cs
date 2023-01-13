namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The default sort order.
    /// </summary>
    public enum DefaultOrderField
    {
        /// <summary>
        /// Sorting or ordering is not possible.
        /// </summary>
        [EnumMember(Value = "")]
        None,
    }

    /// <summary>
    /// The affected service level agreement order.
    /// </summary>
    public enum AffectedSlaOrderField
    {
        /// <summary>
        /// Order by accountability.
        /// </summary>
        [EnumMember(Value = "accountability")]
        Accountability,
        /// <summary>
        /// Order by actual resolution at.
        /// </summary>
        [EnumMember(Value = "actualResolutionAt")]
        ActualResolutionAt,
        /// <summary>
        /// Order by actual resolution duration.
        /// </summary>
        [EnumMember(Value = "actualResolutionDuration")]
        ActualResolutionDuration,
        /// <summary>
        /// Order by actual response at.
        /// </summary>
        [EnumMember(Value = "actualResponseAt")]
        ActualResponseAt,
        /// <summary>
        /// Order by actual response duration.
        /// </summary>
        [EnumMember(Value = "actualResponseDuration")]
        ActualResponseDuration,
        /// <summary>
        /// Order by created at.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Order by impact.
        /// </summary>
        [EnumMember(Value = "impact")]
        Impact,
        /// <summary>
        /// Order by request identifier.
        /// </summary>
        [EnumMember(Value = "requestId")]
        RequestId,
        /// <summary>
        /// Order by request subject.
        /// </summary>
        [EnumMember(Value = "requestSubject")]
        RequestSubject,
        /// <summary>
        /// Order by resolution target at.
        /// </summary>
        [EnumMember(Value = "resolutionTargetAt")]
        ResolutionTargetAt,
        /// <summary>
        /// Order by response target at.
        /// </summary>
        [EnumMember(Value = "responseTargetAt")]
        ResponseTargetAt,
    }

    /// <summary>
    /// The agile board order.
    /// </summary>
    public enum AgileBoardOrderField
    {
        /// <summary>
        /// Order by name.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
    }

    /// <summary>
    /// The application instance order.
    /// </summary>
    public enum AppInstanceOrderField
    {
        /// <summary>
        /// Order by account name.
        /// </summary>
        [EnumMember(Value = "accountName")]
        AccountName,
        /// <summary>
        /// Order by application offering reference.
        /// </summary>
        [EnumMember(Value = "appOfferingReference")]
        AppOfferingReference,
        /// <summary>
        /// Order by created at.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Order by customer account name.
        /// </summary>
        [EnumMember(Value = "customerAccountName")]
        CustomerAccountName,
        /// <summary>
        /// Order by updated at.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The application offering order.
    /// </summary>
    public enum AppOfferingOrderField
    {
        /// <summary>
        /// Order by created at.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Order by name.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// Order by reference.
        /// </summary>
        [EnumMember(Value = "reference")]
        Reference,
        /// <summary>
        /// Order by updated at.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The archive order.
    /// </summary>
    public enum ArchiveOrderField
    {
        /// <summary>
        /// Order by archived by name.
        /// </summary>
        [EnumMember(Value = "archivedByName")]
        ArchivedByName,
        /// <summary>
        /// Order by created at.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Order by name.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
    }

    /// <summary>
    /// The automation rule order.
    /// </summary>
    public enum AutomationRuleOrderField
    {
        /// <summary>
        /// Order by created at.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Order by disabled.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// Order by name.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// Order by position.
        /// </summary>
        [EnumMember(Value = "position")]
        Position,
        /// <summary>
        /// Order by updated at.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The configuration item order.
    /// </summary>
    public enum ConfigurationItemOrderField
    {
        /// <summary>
        /// Order by created at.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Order by label.
        /// </summary>
        [EnumMember(Value = "label")]
        Label,
        /// <summary>
        /// Order by license expiry date.
        /// </summary>
        [EnumMember(Value = "licenseExpiryDate")]
        LicenseExpiryDate,
        /// <summary>
        /// Order by name.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// Order by rule set.
        /// </summary>
        [EnumMember(Value = "ruleSet")]
        RuleSet,
        /// <summary>
        /// Order by site name.
        /// </summary>
        [EnumMember(Value = "siteName")]
        SiteName,
        /// <summary>
        /// Order by software.
        /// </summary>
        [EnumMember(Value = "software")]
        Software,
        /// <summary>
        /// Order by status.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,
        /// <summary>
        /// Order by support team name.
        /// </summary>
        [EnumMember(Value = "supportTeamName")]
        SupportTeamName,
        /// <summary>
        /// Order by updated at.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Order by warranty expiry date.
        /// </summary>
        [EnumMember(Value = "warrantyExpiryDate")]
        WarrantyExpiryDate,
    }

    /// <summary>
    /// The contract order.
    /// </summary>
    public enum ContractOrderField
    {
        /// <summary>
        /// Order by created at.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Order by expiry date.
        /// </summary>
        [EnumMember(Value = "expiryDate")]
        ExpiryDate,
        /// <summary>
        /// Order by name.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// Order by notice date.
        /// </summary>
        [EnumMember(Value = "noticeDate")]
        NoticeDate,
        /// <summary>
        /// Order by start date.
        /// </summary>
        [EnumMember(Value = "startDate")]
        StartDate,
        /// <summary>
        /// Order by status.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,
        /// <summary>
        /// Order by supplier name.
        /// </summary>
        [EnumMember(Value = "supplierName")]
        SupplierName,
        /// <summary>
        /// Order by updated at.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The custom collection element order.
    /// </summary>
    public enum CustomCollectionElementOrderField
    {
        /// <summary>
        /// Order by created at.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Order by name.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// Order by updated at.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The first line support agreement order.
    /// </summary>
    public enum FirstLineSupportAgreementOrderField
    {
        /// <summary>
        /// Order by created at.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Order by expiry date.
        /// </summary>
        [EnumMember(Value = "expiryDate")]
        ExpiryDate,
        /// <summary>
        /// Order by name.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// Order by notice date.
        /// </summary>
        [EnumMember(Value = "noticeDate")]
        NoticeDate,
        /// <summary>
        /// Order by provider name.
        /// </summary>
        [EnumMember(Value = "providerName")]
        ProviderName,
        /// <summary>
        /// Order by start date.
        /// </summary>
        [EnumMember(Value = "startDate")]
        StartDate,
        /// <summary>
        /// Order by status.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,
        /// <summary>
        /// Order by updated at.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The invoice order.
    /// </summary>
    public enum InvoiceOrderField
    {
        /// <summary>
        /// Order by amortization end.
        /// </summary>
        [EnumMember(Value = "amortizationEnd")]
        AmortizationEnd,
        /// <summary>
        /// Order by amortization start.
        /// </summary>
        [EnumMember(Value = "amortizationStart")]
        AmortizationStart,
        /// <summary>
        /// Order by amount.
        /// </summary>
        [EnumMember(Value = "amount")]
        Amount,
        /// <summary>
        /// Order by created at.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Order by invoice date.
        /// </summary>
        [EnumMember(Value = "invoiceDate")]
        InvoiceDate,
        /// <summary>
        /// Order by invoice number.
        /// </summary>
        [EnumMember(Value = "invoiceNr")]
        InvoiceNr,
        /// <summary>
        /// Order by service name.
        /// </summary>
        [EnumMember(Value = "serviceName")]
        ServiceName,
        /// <summary>
        /// Order by supplier name.
        /// </summary>
        [EnumMember(Value = "supplierName")]
        SupplierName,
        /// <summary>
        /// Order by updated at.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The knowledge article order.
    /// </summary>
    public enum KnowledgeArticleOrderField
    {
        /// <summary>
        /// Order by covered specialists.
        /// </summary>
        [EnumMember(Value = "coveredSpecialists")]
        CoveredSpecialists,
        /// <summary>
        /// Order by created at.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Order by created by name.
        /// </summary>
        [EnumMember(Value = "createdByName")]
        CreatedByName,
        /// <summary>
        /// Order by end users.
        /// </summary>
        [EnumMember(Value = "endUsers")]
        EndUsers,
        /// <summary>
        /// Order by internal specialists.
        /// </summary>
        [EnumMember(Value = "internalSpecialists")]
        InternalSpecialists,
        /// <summary>
        /// Order by key contacts.
        /// </summary>
        [EnumMember(Value = "keyContacts")]
        KeyContacts,
        /// <summary>
        /// Order by service name.
        /// </summary>
        [EnumMember(Value = "serviceName")]
        ServiceName,
        /// <summary>
        /// Order by status.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,
        /// <summary>
        /// Order by subject.
        /// </summary>
        [EnumMember(Value = "subject")]
        Subject,
        /// <summary>
        /// Order by updated at.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The organization order.
    /// </summary>
    public enum OrganizationOrderField
    {
        /// <summary>
        /// Order by created at.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Order by disabled.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// Order by name.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// Order by updated at.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The out of office period order.
    /// </summary>
    public enum OutOfOfficePeriodOrderField
    {
        /// <summary>
        /// Order by created at.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Order by end at.
        /// </summary>
        [EnumMember(Value = "endAt")]
        EndAt,
        /// <summary>
        /// Order by person name.
        /// </summary>
        [EnumMember(Value = "personName")]
        PersonName,
        /// <summary>
        /// Order by start at.
        /// </summary>
        [EnumMember(Value = "startAt")]
        StartAt,
        /// <summary>
        /// Order by updated at.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The person order.
    /// </summary>
    public enum PersonOrderField
    {
        /// <summary>
        /// Order by authentication identifier.
        /// </summary>
        [EnumMember(Value = "authenticationID")]
        AuthenticationID,
        /// <summary>
        /// Order by created at.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Order by disabled.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// Order by employee identifier.
        /// </summary>
        [EnumMember(Value = "employeeID")]
        EmployeeID,
        /// <summary>
        /// Order by life cycle state.
        /// </summary>
        [EnumMember(Value = "lifeCycleState")]
        LifeCycleState,
        /// <summary>
        /// Order by name.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// Order by organization name.
        /// </summary>
        [EnumMember(Value = "organizationName")]
        OrganizationName,
        /// <summary>
        /// Order by site name.
        /// </summary>
        [EnumMember(Value = "siteName")]
        SiteName,
        /// <summary>
        /// Order by support identifier.
        /// </summary>
        [EnumMember(Value = "supportID")]
        SupportID,
        /// <summary>
        /// Order by updated at.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Order by vip.
        /// </summary>
        [EnumMember(Value = "vip")]
        Vip,
    }

    /// <summary>
    /// The problem order.
    /// </summary>
    public enum ProblemOrderField
    {
        /// <summary>
        /// Order by analysis target at.
        /// </summary>
        [EnumMember(Value = "analysisTargetAt")]
        AnalysisTargetAt,
        /// <summary>
        /// Order by category.
        /// </summary>
        [EnumMember(Value = "category")]
        Category,
        /// <summary>
        /// Order by change identifier.
        /// </summary>
        [EnumMember(Value = "changeId")]
        ChangeId,
        /// <summary>
        /// Order by created at.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Order by impact.
        /// </summary>
        [EnumMember(Value = "impact")]
        Impact,
        /// <summary>
        /// Order by known error.
        /// </summary>
        [EnumMember(Value = "knownError")]
        KnownError,
        /// <summary>
        /// Order by life cycle state.
        /// </summary>
        [EnumMember(Value = "lifeCycleState")]
        LifeCycleState,
        /// <summary>
        /// Order by member name.
        /// </summary>
        [EnumMember(Value = "memberName")]
        MemberName,
        /// <summary>
        /// Order by problem identifier.
        /// </summary>
        [EnumMember(Value = "problemId")]
        ProblemId,
        /// <summary>
        /// Order by project identifier.
        /// </summary>
        [EnumMember(Value = "projectId")]
        ProjectId,
        /// <summary>
        /// Order by solved at.
        /// </summary>
        [EnumMember(Value = "solvedAt")]
        SolvedAt,
        /// <summary>
        /// Order by status.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,
        /// <summary>
        /// Order by subject.
        /// </summary>
        [EnumMember(Value = "subject")]
        Subject,
        /// <summary>
        /// Order by supplier name.
        /// </summary>
        [EnumMember(Value = "supplierName")]
        SupplierName,
        /// <summary>
        /// Order by team name.
        /// </summary>
        [EnumMember(Value = "teamName")]
        TeamName,
        /// <summary>
        /// Order by updated at.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Order by urgent.
        /// </summary>
        [EnumMember(Value = "urgent")]
        Urgent,
        /// <summary>
        /// Order by workflow identifier.
        /// </summary>
        [EnumMember(Value = "workflowId")]
        WorkflowId,
    }

    /// <summary>
    /// The product backlog order.
    /// </summary>
    public enum ProductBacklogOrderField
    {
        /// <summary>
        /// Order by name.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
    }

    /// <summary>
    /// The product order.
    /// </summary>
    public enum ProductOrderField
    {
        /// <summary>
        /// Order by created at.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Order by disabled.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// Order by name.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// Order by rule set.
        /// </summary>
        [EnumMember(Value = "ruleSet")]
        RuleSet,
        /// <summary>
        /// Order by support team name.
        /// </summary>
        [EnumMember(Value = "supportTeamName")]
        SupportTeamName,
        /// <summary>
        /// Order by updated at.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The project order.
    /// </summary>
    public enum ProjectOrderField
    {
        /// <summary>
        /// Order by completed at.
        /// </summary>
        [EnumMember(Value = "completedAt")]
        CompletedAt,
        /// <summary>
        /// Order by completion target at.
        /// </summary>
        [EnumMember(Value = "completionTargetAt")]
        CompletionTargetAt,
        /// <summary>
        /// Order by created at.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Order by justification.
        /// </summary>
        [EnumMember(Value = "justification")]
        Justification,
        /// <summary>
        /// Order by life cycle state.
        /// </summary>
        [EnumMember(Value = "lifeCycleState")]
        LifeCycleState,
        /// <summary>
        /// Order by manager name.
        /// </summary>
        [EnumMember(Value = "managerName")]
        ManagerName,
        /// <summary>
        /// Order by program.
        /// </summary>
        [EnumMember(Value = "program")]
        Program,
        /// <summary>
        /// Order by project identifier.
        /// </summary>
        [EnumMember(Value = "projectId")]
        ProjectId,
        /// <summary>
        /// Order by service name.
        /// </summary>
        [EnumMember(Value = "serviceName")]
        ServiceName,
        /// <summary>
        /// Order by status.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,
        /// <summary>
        /// Order by subject.
        /// </summary>
        [EnumMember(Value = "subject")]
        Subject,
        /// <summary>
        /// Order by updated at.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The project task order.
    /// </summary>
    public enum ProjectTaskOrderField
    {
        /// <summary>
        /// Order by category.
        /// </summary>
        [EnumMember(Value = "category")]
        Category,
        /// <summary>
        /// Order by completion target at.
        /// </summary>
        [EnumMember(Value = "completionTargetAt")]
        CompletionTargetAt,
        /// <summary>
        /// Order by created at.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Order by finished at.
        /// </summary>
        [EnumMember(Value = "finishedAt")]
        FinishedAt,
        /// <summary>
        /// Order by life cycle state.
        /// </summary>
        [EnumMember(Value = "lifeCycleState")]
        LifeCycleState,
        /// <summary>
        /// Order by project task identifier.
        /// </summary>
        [EnumMember(Value = "projectTaskId")]
        ProjectTaskId,
        /// <summary>
        /// Order by status.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,
        /// <summary>
        /// Order by subject.
        /// </summary>
        [EnumMember(Value = "subject")]
        Subject,
        /// <summary>
        /// Order by supplier name.
        /// </summary>
        [EnumMember(Value = "supplierName")]
        SupplierName,
        /// <summary>
        /// Order by updated at.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Order by urgent.
        /// </summary>
        [EnumMember(Value = "urgent")]
        Urgent,
    }

    /// <summary>
    /// The project task template order.
    /// </summary>
    public enum ProjectTaskTemplateOrderField
    {
        /// <summary>
        /// Order by category.
        /// </summary>
        [EnumMember(Value = "category")]
        Category,
        /// <summary>
        /// Order by created at.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Order by disabled.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// Order by subject.
        /// </summary>
        [EnumMember(Value = "subject")]
        Subject,
        /// <summary>
        /// Order by updated at.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The project template order.
    /// </summary>
    public enum ProjectTemplateOrderField
    {
        /// <summary>
        /// Order by created at.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Order by disabled.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// Order by subject.
        /// </summary>
        [EnumMember(Value = "subject")]
        Subject,
        /// <summary>
        /// Order by updated at.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The release order.
    /// </summary>
    public enum ReleaseOrderField
    {
        /// <summary>
        /// Order by completed at.
        /// </summary>
        [EnumMember(Value = "completedAt")]
        CompletedAt,
        /// <summary>
        /// Order by completion target at.
        /// </summary>
        [EnumMember(Value = "completionTargetAt")]
        CompletionTargetAt,
        /// <summary>
        /// Order by created at.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Order by impact.
        /// </summary>
        [EnumMember(Value = "impact")]
        Impact,
        /// <summary>
        /// Order by life cycle state.
        /// </summary>
        [EnumMember(Value = "lifeCycleState")]
        LifeCycleState,
        /// <summary>
        /// Order by release identifier.
        /// </summary>
        [EnumMember(Value = "releaseId")]
        ReleaseId,
        /// <summary>
        /// Order by status.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,
        /// <summary>
        /// Order by subject.
        /// </summary>
        [EnumMember(Value = "subject")]
        Subject,
        /// <summary>
        /// Order by updated at.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The request order.
    /// </summary>
    public enum RequestOrderField
    {
        /// <summary>
        /// Order by addressed.
        /// </summary>
        [EnumMember(Value = "addressed")]
        Addressed,
        /// <summary>
        /// Order by category.
        /// </summary>
        [EnumMember(Value = "category")]
        Category,
        /// <summary>
        /// Order by change identifier.
        /// </summary>
        [EnumMember(Value = "changeId")]
        ChangeId,
        /// <summary>
        /// Order by completed at.
        /// </summary>
        [EnumMember(Value = "completedAt")]
        CompletedAt,
        /// <summary>
        /// Order by completion reason.
        /// </summary>
        [EnumMember(Value = "completionReason")]
        CompletionReason,
        /// <summary>
        /// Order by created at.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Order by downtime end at.
        /// </summary>
        [EnumMember(Value = "downtimeEndAt")]
        DowntimeEndAt,
        /// <summary>
        /// Order by downtime start at.
        /// </summary>
        [EnumMember(Value = "downtimeStartAt")]
        DowntimeStartAt,
        /// <summary>
        /// Order by impact.
        /// </summary>
        [EnumMember(Value = "impact")]
        Impact,
        /// <summary>
        /// Order by life cycle state.
        /// </summary>
        [EnumMember(Value = "lifeCycleState")]
        LifeCycleState,
        /// <summary>
        /// Order by major incident status.
        /// </summary>
        [EnumMember(Value = "majorIncidentStatus")]
        MajorIncidentStatus,
        /// <summary>
        /// Order by member name.
        /// </summary>
        [EnumMember(Value = "memberName")]
        MemberName,
        /// <summary>
        /// Order by next target at.
        /// </summary>
        [EnumMember(Value = "nextTargetAt")]
        NextTargetAt,
        /// <summary>
        /// Order by problem identifier.
        /// </summary>
        [EnumMember(Value = "problemId")]
        ProblemId,
        /// <summary>
        /// Order by project identifier.
        /// </summary>
        [EnumMember(Value = "projectId")]
        ProjectId,
        /// <summary>
        /// Order by request identifier.
        /// </summary>
        [EnumMember(Value = "requestId")]
        RequestId,
        /// <summary>
        /// Order by requested for name.
        /// </summary>
        [EnumMember(Value = "requestedForName")]
        RequestedForName,
        /// <summary>
        /// Order by reviewed.
        /// </summary>
        [EnumMember(Value = "reviewed")]
        Reviewed,
        /// <summary>
        /// Order by service instance name.
        /// </summary>
        [EnumMember(Value = "serviceInstanceName")]
        ServiceInstanceName,
        /// <summary>
        /// Order by source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Order by status.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,
        /// <summary>
        /// Order by subject.
        /// </summary>
        [EnumMember(Value = "subject")]
        Subject,
        /// <summary>
        /// Order by team name.
        /// </summary>
        [EnumMember(Value = "teamName")]
        TeamName,
        /// <summary>
        /// Order by time spent on request.
        /// </summary>
        [EnumMember(Value = "timeSpentOnRequest")]
        TimeSpentOnRequest,
        /// <summary>
        /// Order by time spent on request and workflow.
        /// </summary>
        [EnumMember(Value = "timeSpentOnRequestAndWorkflow")]
        TimeSpentOnRequestAndWorkflow,
        /// <summary>
        /// Order by updated at.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Order by urgent.
        /// </summary>
        [EnumMember(Value = "urgent")]
        Urgent,
        /// <summary>
        /// Order by workflow identifier.
        /// </summary>
        [EnumMember(Value = "workflowId")]
        WorkflowId,
    }

    /// <summary>
    /// The request template order.
    /// </summary>
    public enum RequestTemplateOrderField
    {
        /// <summary>
        /// Order by category.
        /// </summary>
        [EnumMember(Value = "category")]
        Category,
        /// <summary>
        /// Order by created at.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Order by disabled.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// Order by end users.
        /// </summary>
        [EnumMember(Value = "endUsers")]
        EndUsers,
        /// <summary>
        /// Order by impact.
        /// </summary>
        [EnumMember(Value = "impact")]
        Impact,
        /// <summary>
        /// Order by service name.
        /// </summary>
        [EnumMember(Value = "serviceName")]
        ServiceName,
        /// <summary>
        /// Order by specialists.
        /// </summary>
        [EnumMember(Value = "specialists")]
        Specialists,
        /// <summary>
        /// Order by subject.
        /// </summary>
        [EnumMember(Value = "subject")]
        Subject,
        /// <summary>
        /// Order by updated at.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The reservation offering order.
    /// </summary>
    public enum ReservationOfferingOrderField
    {
        /// <summary>
        /// Order by created at.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Order by name.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// Order by service instance name.
        /// </summary>
        [EnumMember(Value = "serviceInstanceName")]
        ServiceInstanceName,
        /// <summary>
        /// Order by updated at.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The reservation order.
    /// </summary>
    public enum ReservationOrderField
    {
        /// <summary>
        /// Order by configuration item name.
        /// </summary>
        [EnumMember(Value = "ciName")]
        CiName,
        /// <summary>
        /// Order by created at.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Order by end at.
        /// </summary>
        [EnumMember(Value = "endAt")]
        EndAt,
        /// <summary>
        /// Order by name.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// Order by person name.
        /// </summary>
        [EnumMember(Value = "personName")]
        PersonName,
        /// <summary>
        /// Order by start at.
        /// </summary>
        [EnumMember(Value = "startAt")]
        StartAt,
        /// <summary>
        /// Order by status.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,
        /// <summary>
        /// Order by updated at.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The risk order.
    /// </summary>
    public enum RiskOrderField
    {
        /// <summary>
        /// Order by closed at.
        /// </summary>
        [EnumMember(Value = "closedAt")]
        ClosedAt,
        /// <summary>
        /// Order by closure reason.
        /// </summary>
        [EnumMember(Value = "closureReason")]
        ClosureReason,
        /// <summary>
        /// Order by created at.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Order by life cycle state.
        /// </summary>
        [EnumMember(Value = "lifeCycleState")]
        LifeCycleState,
        /// <summary>
        /// Order by manager name.
        /// </summary>
        [EnumMember(Value = "managerName")]
        ManagerName,
        /// <summary>
        /// Order by mitigation target at.
        /// </summary>
        [EnumMember(Value = "mitigationTargetAt")]
        MitigationTargetAt,
        /// <summary>
        /// Order by severity.
        /// </summary>
        [EnumMember(Value = "severity")]
        Severity,
        /// <summary>
        /// Order by status.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,
        /// <summary>
        /// Order by subject.
        /// </summary>
        [EnumMember(Value = "subject")]
        Subject,
        /// <summary>
        /// Order by updated at.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The scrum workspace order.
    /// </summary>
    public enum ScrumWorkspaceOrderField
    {
        /// <summary>
        /// Order by created at.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Order by name.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// Order by sprint length.
        /// </summary>
        [EnumMember(Value = "sprintLength")]
        SprintLength,
        /// <summary>
        /// Order by updated at.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The service instance order.
    /// </summary>
    public enum ServiceInstanceOrderField
    {
        /// <summary>
        /// Order by created at.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Order by name.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// Order by outdated.
        /// </summary>
        [EnumMember(Value = "outdated")]
        Outdated,
        /// <summary>
        /// Order by service name.
        /// </summary>
        [EnumMember(Value = "serviceName")]
        ServiceName,
        /// <summary>
        /// Order by service provider name.
        /// </summary>
        [EnumMember(Value = "serviceProviderName")]
        ServiceProviderName,
        /// <summary>
        /// Order by status.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,
        /// <summary>
        /// Order by support team name.
        /// </summary>
        [EnumMember(Value = "supportTeamName")]
        SupportTeamName,
        /// <summary>
        /// Order by updated at.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The service level agreement order.
    /// </summary>
    public enum ServiceLevelAgreementOrderField
    {
        /// <summary>
        /// Order by coverage.
        /// </summary>
        [EnumMember(Value = "coverage")]
        Coverage,
        /// <summary>
        /// Order by created at.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Order by expiry date.
        /// </summary>
        [EnumMember(Value = "expiryDate")]
        ExpiryDate,
        /// <summary>
        /// Order by name.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// Order by notice date.
        /// </summary>
        [EnumMember(Value = "noticeDate")]
        NoticeDate,
        /// <summary>
        /// Order by start date.
        /// </summary>
        [EnumMember(Value = "startDate")]
        StartDate,
        /// <summary>
        /// Order by status.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,
        /// <summary>
        /// Order by updated at.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The service offering order.
    /// </summary>
    public enum ServiceOfferingOrderField
    {
        /// <summary>
        /// Order by created at.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Order by name.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// Order by service name.
        /// </summary>
        [EnumMember(Value = "serviceName")]
        ServiceName,
        /// <summary>
        /// Order by status.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,
        /// <summary>
        /// Order by updated at.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The service order.
    /// </summary>
    public enum ServiceOrderField
    {
        /// <summary>
        /// Order by created at.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Order by disabled.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// Order by keywords.
        /// </summary>
        [EnumMember(Value = "keywords")]
        Keywords,
        /// <summary>
        /// Order by name.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// Order by provider name.
        /// </summary>
        [EnumMember(Value = "providerName")]
        ProviderName,
        /// <summary>
        /// Order by support team name.
        /// </summary>
        [EnumMember(Value = "supportTeamName")]
        SupportTeamName,
        /// <summary>
        /// Order by updated at.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The shop article order.
    /// </summary>
    public enum ShopArticleOrderField
    {
        /// <summary>
        /// Order by created at.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Order by delivery duration.
        /// </summary>
        [EnumMember(Value = "deliveryDuration")]
        DeliveryDuration,
        /// <summary>
        /// Order by price.
        /// </summary>
        [EnumMember(Value = "price")]
        Price,
        /// <summary>
        /// Order by recurring price.
        /// </summary>
        [EnumMember(Value = "recurringPrice")]
        RecurringPrice,
        /// <summary>
        /// Order by reference.
        /// </summary>
        [EnumMember(Value = "reference")]
        Reference,
        /// <summary>
        /// Order by shop article identifier.
        /// </summary>
        [EnumMember(Value = "shopArticleId")]
        ShopArticleId,
        /// <summary>
        /// Order by source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Order by source identifier.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// Order by updated at.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The shop order line order.
    /// </summary>
    public enum ShopOrderLineOrderField
    {
        /// <summary>
        /// Order by completed at.
        /// </summary>
        [EnumMember(Value = "completedAt")]
        CompletedAt,
        /// <summary>
        /// Order by created at.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Order by name.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// Order by ordered at.
        /// </summary>
        [EnumMember(Value = "orderedAt")]
        OrderedAt,
        /// <summary>
        /// Order by price.
        /// </summary>
        [EnumMember(Value = "price")]
        Price,
        /// <summary>
        /// Order by quantity.
        /// </summary>
        [EnumMember(Value = "quantity")]
        Quantity,
        /// <summary>
        /// Order by recurring price.
        /// </summary>
        [EnumMember(Value = "recurringPrice")]
        RecurringPrice,
        /// <summary>
        /// Order by shop order line identifier.
        /// </summary>
        [EnumMember(Value = "shopOrderLineId")]
        ShopOrderLineId,
        /// <summary>
        /// Order by source.
        /// </summary>
        [EnumMember(Value = "source")]
        Source,
        /// <summary>
        /// Order by source identifier.
        /// </summary>
        [EnumMember(Value = "sourceID")]
        SourceID,
        /// <summary>
        /// Order by status.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,
        /// <summary>
        /// Order by updated at.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The short url order.
    /// </summary>
    public enum ShortUrlOrderField
    {
        /// <summary>
        /// Order by created at.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Order by created by name.
        /// </summary>
        [EnumMember(Value = "createdByName")]
        CreatedByName,
        /// <summary>
        /// Order by data type.
        /// </summary>
        [EnumMember(Value = "dataType")]
        DataType,
        /// <summary>
        /// Order by uniform resource identifier.
        /// </summary>
        [EnumMember(Value = "uri")]
        Uri,
    }

    /// <summary>
    /// The site order.
    /// </summary>
    public enum SiteOrderField
    {
        /// <summary>
        /// Order by created at.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Order by disabled.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// Order by name.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// Order by updated at.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The skill pool order.
    /// </summary>
    public enum SkillPoolOrderField
    {
        /// <summary>
        /// Order by created at.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Order by disabled.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// Order by manager name.
        /// </summary>
        [EnumMember(Value = "managerName")]
        ManagerName,
        /// <summary>
        /// Order by name.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// Order by updated at.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The sprint order.
    /// </summary>
    public enum SprintOrderField
    {
        /// <summary>
        /// Order by created at.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Order by end at.
        /// </summary>
        [EnumMember(Value = "endAt")]
        EndAt,
        /// <summary>
        /// Order by number.
        /// </summary>
        [EnumMember(Value = "number")]
        Number,
        /// <summary>
        /// Order by scrum workspace name.
        /// </summary>
        [EnumMember(Value = "scrumWorkspaceName")]
        ScrumWorkspaceName,
        /// <summary>
        /// Order by start at.
        /// </summary>
        [EnumMember(Value = "startAt")]
        StartAt,
        /// <summary>
        /// Order by status.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,
        /// <summary>
        /// Order by updated at.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The survey order.
    /// </summary>
    public enum SurveyOrderField
    {
        /// <summary>
        /// Order by name.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
    }

    /// <summary>
    /// The survey response order.
    /// </summary>
    public enum SurveyResponseOrderField
    {
        /// <summary>
        /// Order by responded at.
        /// </summary>
        [EnumMember(Value = "respondedAt")]
        RespondedAt,
    }

    /// <summary>
    /// The task order.
    /// </summary>
    public enum TaskOrderField
    {
        /// <summary>
        /// Order by anticipated assignment at.
        /// </summary>
        [EnumMember(Value = "anticipatedAssignmentAt")]
        AnticipatedAssignmentAt,
        /// <summary>
        /// Order by assigned at.
        /// </summary>
        [EnumMember(Value = "assignedAt")]
        AssignedAt,
        /// <summary>
        /// Order by category.
        /// </summary>
        [EnumMember(Value = "category")]
        Category,
        /// <summary>
        /// Order by completion target at.
        /// </summary>
        [EnumMember(Value = "completionTargetAt")]
        CompletionTargetAt,
        /// <summary>
        /// Order by created at.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Order by finished at.
        /// </summary>
        [EnumMember(Value = "finishedAt")]
        FinishedAt,
        /// <summary>
        /// Order by impact.
        /// </summary>
        [EnumMember(Value = "impact")]
        Impact,
        /// <summary>
        /// Order by life cycle state.
        /// </summary>
        [EnumMember(Value = "lifeCycleState")]
        LifeCycleState,
        /// <summary>
        /// Order by member name.
        /// </summary>
        [EnumMember(Value = "memberName")]
        MemberName,
        /// <summary>
        /// Order by status.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,
        /// <summary>
        /// Order by subject.
        /// </summary>
        [EnumMember(Value = "subject")]
        Subject,
        /// <summary>
        /// Order by supplier name.
        /// </summary>
        [EnumMember(Value = "supplierName")]
        SupplierName,
        /// <summary>
        /// Order by task identifier.
        /// </summary>
        [EnumMember(Value = "taskId")]
        TaskId,
        /// <summary>
        /// Order by team name.
        /// </summary>
        [EnumMember(Value = "teamName")]
        TeamName,
        /// <summary>
        /// Order by updated at.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Order by urgent.
        /// </summary>
        [EnumMember(Value = "urgent")]
        Urgent,
    }

    /// <summary>
    /// The task template order.
    /// </summary>
    public enum TaskTemplateOrderField
    {
        /// <summary>
        /// Order by category.
        /// </summary>
        [EnumMember(Value = "category")]
        Category,
        /// <summary>
        /// Order by created at.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Order by disabled.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// Order by impact.
        /// </summary>
        [EnumMember(Value = "impact")]
        Impact,
        /// <summary>
        /// Order by subject.
        /// </summary>
        [EnumMember(Value = "subject")]
        Subject,
        /// <summary>
        /// Order by team name.
        /// </summary>
        [EnumMember(Value = "teamName")]
        TeamName,
        /// <summary>
        /// Order by updated at.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The team order.
    /// </summary>
    public enum TeamOrderField
    {
        /// <summary>
        /// Order by created at.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Order by disabled.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// Order by name.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// Order by updated at.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The time allocation order.
    /// </summary>
    public enum TimeAllocationOrderField
    {
        /// <summary>
        /// Order by created at.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Order by customer category identifier.
        /// </summary>
        [EnumMember(Value = "customerCategoryId")]
        CustomerCategoryId,
        /// <summary>
        /// Order by disabled.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// Order by group name.
        /// </summary>
        [EnumMember(Value = "groupName")]
        GroupName,
        /// <summary>
        /// Order by name.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// Order by service category identifier.
        /// </summary>
        [EnumMember(Value = "serviceCategoryId")]
        ServiceCategoryId,
        /// <summary>
        /// Order by updated at.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The time entry order.
    /// </summary>
    public enum TimeEntryOrderField
    {
        /// <summary>
        /// Order by assignment subject.
        /// </summary>
        [EnumMember(Value = "assignmentSubject")]
        AssignmentSubject,
        /// <summary>
        /// Order by created at.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Order by date.
        /// </summary>
        [EnumMember(Value = "date")]
        Date,
        /// <summary>
        /// Order by person name.
        /// </summary>
        [EnumMember(Value = "personName")]
        PersonName,
        /// <summary>
        /// Order by started at.
        /// </summary>
        [EnumMember(Value = "startedAt")]
        StartedAt,
        /// <summary>
        /// Order by time allocation name.
        /// </summary>
        [EnumMember(Value = "timeAllocationName")]
        TimeAllocationName,
        /// <summary>
        /// Order by time spent.
        /// </summary>
        [EnumMember(Value = "timeSpent")]
        TimeSpent,
        /// <summary>
        /// Order by updated at.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The translation order.
    /// </summary>
    public enum TranslationOrderField
    {
        /// <summary>
        /// Order by created at.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Order by field.
        /// </summary>
        [EnumMember(Value = "field")]
        Field,
        /// <summary>
        /// Order by language.
        /// </summary>
        [EnumMember(Value = "language")]
        Language,
        /// <summary>
        /// Order by text.
        /// </summary>
        [EnumMember(Value = "text")]
        Text,
        /// <summary>
        /// Order by type.
        /// </summary>
        [EnumMember(Value = "type")]
        Type,
        /// <summary>
        /// Order by updated at.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The trash order.
    /// </summary>
    public enum TrashOrderField
    {
        /// <summary>
        /// Order by created at.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Order by name.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// Order by trashed by name.
        /// </summary>
        [EnumMember(Value = "trashedByName")]
        TrashedByName,
    }

    /// <summary>
    /// The user interface extension order.
    /// </summary>
    public enum UiExtensionOrderField
    {
        /// <summary>
        /// Order by category.
        /// </summary>
        [EnumMember(Value = "category")]
        Category,
        /// <summary>
        /// Order by created at.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Order by name.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,
        /// <summary>
        /// Order by updated at.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }

    /// <summary>
    /// The workflow order.
    /// </summary>
    public enum WorkflowOrderField
    {
        /// <summary>
        /// Order by actual effort.
        /// </summary>
        [EnumMember(Value = "actualEffort")]
        ActualEffort,
        /// <summary>
        /// Order by actual vs planned effort percentage.
        /// </summary>
        [EnumMember(Value = "actualVsPlannedEffortPercentage")]
        ActualVsPlannedEffortPercentage,
        /// <summary>
        /// Order by category.
        /// </summary>
        [EnumMember(Value = "category")]
        Category,
        /// <summary>
        /// Order by change identifier.
        /// </summary>
        [EnumMember(Value = "changeId")]
        ChangeId,
        /// <summary>
        /// Order by completed at.
        /// </summary>
        [EnumMember(Value = "completedAt")]
        CompletedAt,
        /// <summary>
        /// Order by completion reason.
        /// </summary>
        [EnumMember(Value = "completionReason")]
        CompletionReason,
        /// <summary>
        /// Order by completion target at.
        /// </summary>
        [EnumMember(Value = "completionTargetAt")]
        CompletionTargetAt,
        /// <summary>
        /// Order by created at.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Order by impact.
        /// </summary>
        [EnumMember(Value = "impact")]
        Impact,
        /// <summary>
        /// Order by justification.
        /// </summary>
        [EnumMember(Value = "justification")]
        Justification,
        /// <summary>
        /// Order by life cycle state.
        /// </summary>
        [EnumMember(Value = "lifeCycleState")]
        LifeCycleState,
        /// <summary>
        /// Order by manager name.
        /// </summary>
        [EnumMember(Value = "managerName")]
        ManagerName,
        /// <summary>
        /// Order by planned effort.
        /// </summary>
        [EnumMember(Value = "plannedEffort")]
        PlannedEffort,
        /// <summary>
        /// Order by service name.
        /// </summary>
        [EnumMember(Value = "serviceName")]
        ServiceName,
        /// <summary>
        /// Order by subject.
        /// </summary>
        [EnumMember(Value = "subject")]
        Subject,
        /// <summary>
        /// Order by updated at.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
        /// <summary>
        /// Order by workflow identifier.
        /// </summary>
        [EnumMember(Value = "workflowId")]
        WorkflowId,
    }

    /// <summary>
    /// The workflow template order.
    /// </summary>
    public enum WorkflowTemplateOrderField
    {
        /// <summary>
        /// Order by category.
        /// </summary>
        [EnumMember(Value = "category")]
        Category,
        /// <summary>
        /// Order by created at.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,
        /// <summary>
        /// Order by disabled.
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>
        /// Order by impact.
        /// </summary>
        [EnumMember(Value = "impact")]
        Impact,
        /// <summary>
        /// Order by justification.
        /// </summary>
        [EnumMember(Value = "justification")]
        Justification,
        /// <summary>
        /// Order by service name.
        /// </summary>
        [EnumMember(Value = "serviceName")]
        ServiceName,
        /// <summary>
        /// Order by subject.
        /// </summary>
        [EnumMember(Value = "subject")]
        Subject,
        /// <summary>
        /// Order by updated at.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,
    }
}