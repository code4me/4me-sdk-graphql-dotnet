namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The default view.
    /// </summary>
    public enum DefaultView
    {
        /// <summary>
        /// No view.
        /// </summary>
        [EnumMember(Value = "")]
        None,
    }

    /// <summary>
    /// The affected sla view.
    /// </summary>
    public enum AffectedSlaView
    {
        /// <summary>
        /// All affected slas which account equals the value supplied via the `x-4me-account` header.
        /// </summary>
        [EnumMember(Value = "current_account")]
        CurrentAccount,
        /// <summary>
        /// Affected slas.
        /// </summary>
        [EnumMember(Value = "all")]
        All,
    }

    /// <summary>
    /// The agile board view.
    /// </summary>
    public enum AgileBoardView
    {
        /// <summary>
        /// All agile boards which account equals the value supplied via the `x-4me-account` header.
        /// </summary>
        [EnumMember(Value = "current_account")]
        CurrentAccount,
        /// <summary>
        /// Agile boards.
        /// </summary>
        [EnumMember(Value = "all")]
        All,
    }

    /// <summary>
    /// The app instance view.
    /// </summary>
    public enum AppInstanceView
    {
        /// <summary>
        /// All app instances which account equals the value supplied via the `x-4me-account` header.
        /// </summary>
        [EnumMember(Value = "current_account")]
        CurrentAccount,
        /// <summary>
        /// App instances.
        /// </summary>
        [EnumMember(Value = "all")]
        All,
    }

    /// <summary>
    /// The app offering view.
    /// </summary>
    public enum AppOfferingView
    {
        /// <summary>
        /// All app offerings which account equals the value supplied via the `x-4me-account` header.
        /// </summary>
        [EnumMember(Value = "current_account")]
        CurrentAccount,
        /// <summary>
        /// App offerings.
        /// </summary>
        [EnumMember(Value = "all")]
        All,
    }

    /// <summary>
    /// The archive view.
    /// </summary>
    public enum ArchiveView
    {
        /// <summary>
        /// All archives which account equals the value supplied via the `x-4me-account` header.
        /// </summary>
        [EnumMember(Value = "current_account")]
        CurrentAccount,
        /// <summary>
        /// Archive.
        /// </summary>
        [EnumMember(Value = "all")]
        All,
    }

    /// <summary>
    /// The automation rule view.
    /// </summary>
    public enum AutomationRuleView
    {
        /// <summary>
        /// All automation rules which account equals the value supplied via the `x-4me-account` header.
        /// </summary>
        [EnumMember(Value = "current_account")]
        CurrentAccount,
        /// <summary>
        /// Automation rules.
        /// </summary>
        [EnumMember(Value = "all")]
        All,
        /// <summary>
        /// Scim user automation rules.
        /// </summary>
        [EnumMember(Value = "scim_user")]
        ScimUser,
        /// <summary>
        /// Scim group automation rules.
        /// </summary>
        [EnumMember(Value = "scim_group")]
        ScimGroup,
    }

    /// <summary>
    /// The configuration item view.
    /// </summary>
    public enum ConfigurationItemView
    {
        /// <summary>
        /// All configuration items which account equals the value supplied via the `x-4me-account` header.
        /// </summary>
        [EnumMember(Value = "current_account")]
        CurrentAccount,
        /// <summary>
        /// All configuration items.
        /// </summary>
        [EnumMember(Value = "all")]
        All,
        /// <summary>
        /// Cis supported by my teams.
        /// </summary>
        [EnumMember(Value = "supported_by_my_teams")]
        SupportedByMyTeams,
        /// <summary>
        /// Spare cis.
        /// </summary>
        [EnumMember(Value = "spare_cis")]
        SpareCis,
    }

    /// <summary>
    /// The contract view.
    /// </summary>
    public enum ContractView
    {
        /// <summary>
        /// All contracts which account equals the value supplied via the `x-4me-account` header.
        /// </summary>
        [EnumMember(Value = "current_account")]
        CurrentAccount,
        /// <summary>
        /// Contracts.
        /// </summary>
        [EnumMember(Value = "all")]
        All,
    }

    /// <summary>
    /// The custom collection element view.
    /// </summary>
    public enum CustomCollectionElementView
    {
        /// <summary>
        /// All custom collection elements which account equals the value supplied via the `x-4me-account` header.
        /// </summary>
        [EnumMember(Value = "current_account")]
        CurrentAccount,
        /// <summary>
        /// Custom collection elements.
        /// </summary>
        [EnumMember(Value = "all")]
        All,
    }

    /// <summary>
    /// The first line support agreement view.
    /// </summary>
    public enum FirstLineSupportAgreementView
    {
        /// <summary>
        /// All first line support agreements which account equals the value supplied via the `x-4me-account` header.
        /// </summary>
        [EnumMember(Value = "current_account")]
        CurrentAccount,
        /// <summary>
        /// First line support agreements.
        /// </summary>
        [EnumMember(Value = "all")]
        All,
    }

    /// <summary>
    /// The invoice view.
    /// </summary>
    public enum InvoiceView
    {
        /// <summary>
        /// All invoices which account equals the value supplied via the `x-4me-account` header.
        /// </summary>
        [EnumMember(Value = "current_account")]
        CurrentAccount,
        /// <summary>
        /// Invoices.
        /// </summary>
        [EnumMember(Value = "all")]
        All,
    }

    /// <summary>
    /// The knowledge article template view.
    /// </summary>
    public enum KnowledgeArticleTemplateView
    {
        /// <summary>
        /// All knowledge article templates which account equals the value supplied via the `x-4me-account` header.
        /// </summary>
        [EnumMember(Value = "current_account")]
        CurrentAccount,
        /// <summary>
        /// Knowledge article templates.
        /// </summary>
        [EnumMember(Value = "all")]
        All,
    }

    /// <summary>
    /// The knowledge article view.
    /// </summary>
    public enum KnowledgeArticleView
    {
        /// <summary>
        /// All knowledge articles which account equals the value supplied via the `x-4me-account` header.
        /// </summary>
        [EnumMember(Value = "current_account")]
        CurrentAccount,
        /// <summary>
        /// All knowledge articles.
        /// </summary>
        [EnumMember(Value = "all")]
        All,
        /// <summary>
        /// Knowledge articles managed in this account.
        /// </summary>
        [EnumMember(Value = "managed_in_this_account")]
        ManagedInThisAccount,
        /// <summary>
        /// Knowledge articles managed by me.
        /// </summary>
        [EnumMember(Value = "managed_by_me")]
        ManagedByMe,
        /// <summary>
        /// Knowledge articles for my team's services.
        /// </summary>
        [EnumMember(Value = "my_teams_services")]
        MyTeamsServices,
        /// <summary>
        /// Deprecated: use `all` instead.
        /// </summary>
        [Obsolete("use `all` instead")]
        [EnumMember(Value = "provided_to_me")]
        ProvidedToMe,
    }

    /// <summary>
    /// The organization view.
    /// </summary>
    public enum OrganizationView
    {
        /// <summary>
        /// All organizations which account equals the value supplied via the `x-4me-account` header.
        /// </summary>
        [EnumMember(Value = "current_account")]
        CurrentAccount,
        /// <summary>
        /// All organizations.
        /// </summary>
        [EnumMember(Value = "all")]
        All,
        /// <summary>
        /// My organizations.
        /// </summary>
        [EnumMember(Value = "managed_by_me")]
        ManagedByMe,
    }

    /// <summary>
    /// The out of office period view.
    /// </summary>
    public enum OutOfOfficePeriodView
    {
        /// <summary>
        /// All out of office periods which account equals the value supplied via the `x-4me-account` header.
        /// </summary>
        [EnumMember(Value = "current_account")]
        CurrentAccount,
        /// <summary>
        /// All out of office periods.
        /// </summary>
        [EnumMember(Value = "all")]
        All,
        /// <summary>
        /// My out of office periods.
        /// </summary>
        [EnumMember(Value = "personal")]
        Personal,
    }

    /// <summary>
    /// The person view.
    /// </summary>
    public enum PersonView
    {
        /// <summary>
        /// All people which account equals the value supplied via the `x-4me-account` header.
        /// </summary>
        [EnumMember(Value = "current_account")]
        CurrentAccount,
        /// <summary>
        /// All people.
        /// </summary>
        [EnumMember(Value = "all")]
        All,
        /// <summary>
        /// All people with roles.
        /// </summary>
        [EnumMember(Value = "all_with_roles")]
        AllWithRoles,
        /// <summary>
        /// Archived people.
        /// </summary>
        [EnumMember(Value = "archive")]
        Archive,
        /// <summary>
        /// Trashed people.
        /// </summary>
        [EnumMember(Value = "trash")]
        Trash,
    }

    /// <summary>
    /// The problem view.
    /// </summary>
    public enum ProblemView
    {
        /// <summary>
        /// All problems which account equals the value supplied via the `x-4me-account` header.
        /// </summary>
        [EnumMember(Value = "current_account")]
        CurrentAccount,
        /// <summary>
        /// All problems.
        /// </summary>
        [EnumMember(Value = "all")]
        All,
        /// <summary>
        /// Problems assigned to my team.
        /// </summary>
        [EnumMember(Value = "assigned_to_my_team")]
        AssignedToMyTeam,
        /// <summary>
        /// Problems assigned to me.
        /// </summary>
        [EnumMember(Value = "assigned_to_me")]
        AssignedToMe,
        /// <summary>
        /// Problems managed by me.
        /// </summary>
        [EnumMember(Value = "managed_by_me")]
        ManagedByMe,
        /// <summary>
        /// Archived problems.
        /// </summary>
        [EnumMember(Value = "archive")]
        Archive,
        /// <summary>
        /// Trashed problems.
        /// </summary>
        [EnumMember(Value = "trash")]
        Trash,
    }

    /// <summary>
    /// The product backlog view.
    /// </summary>
    public enum ProductBacklogView
    {
        /// <summary>
        /// All product backlogs which account equals the value supplied via the `x-4me-account` header.
        /// </summary>
        [EnumMember(Value = "current_account")]
        CurrentAccount,
        /// <summary>
        /// Product backlogs.
        /// </summary>
        [EnumMember(Value = "all")]
        All,
    }

    /// <summary>
    /// The product view.
    /// </summary>
    public enum ProductView
    {
        /// <summary>
        /// All products which account equals the value supplied via the `x-4me-account` header.
        /// </summary>
        [EnumMember(Value = "current_account")]
        CurrentAccount,
        /// <summary>
        /// All products.
        /// </summary>
        [EnumMember(Value = "all")]
        All,
        /// <summary>
        /// Products supported by my teams.
        /// </summary>
        [EnumMember(Value = "supported_by_my_teams")]
        SupportedByMyTeams,
    }

    /// <summary>
    /// The project task template view.
    /// </summary>
    public enum ProjectTaskTemplateView
    {
        /// <summary>
        /// All project task templates which account equals the value supplied via the `x-4me-account` header.
        /// </summary>
        [EnumMember(Value = "current_account")]
        CurrentAccount,
        /// <summary>
        /// Project task templates.
        /// </summary>
        [EnumMember(Value = "all")]
        All,
    }

    /// <summary>
    /// The project task view.
    /// </summary>
    public enum ProjectTaskView
    {
        /// <summary>
        /// All project tasks which account equals the value supplied via the `x-4me-account` header.
        /// </summary>
        [EnumMember(Value = "current_account")]
        CurrentAccount,
        /// <summary>
        /// All project tasks.
        /// </summary>
        [EnumMember(Value = "all")]
        All,
        /// <summary>
        /// Project tasks assigned to me.
        /// </summary>
        [EnumMember(Value = "assigned_to_me")]
        AssignedToMe,
        /// <summary>
        /// Project tasks managed by me.
        /// </summary>
        [EnumMember(Value = "managed_by_me")]
        ManagedByMe,
        /// <summary>
        /// Archived project tasks.
        /// </summary>
        [EnumMember(Value = "archive")]
        Archive,
        /// <summary>
        /// Trashed project tasks.
        /// </summary>
        [EnumMember(Value = "trash")]
        Trash,
    }

    /// <summary>
    /// The project template view.
    /// </summary>
    public enum ProjectTemplateView
    {
        /// <summary>
        /// All project templates which account equals the value supplied via the `x-4me-account` header.
        /// </summary>
        [EnumMember(Value = "current_account")]
        CurrentAccount,
        /// <summary>
        /// Project templates.
        /// </summary>
        [EnumMember(Value = "all")]
        All,
    }

    /// <summary>
    /// The project view.
    /// </summary>
    public enum ProjectView
    {
        /// <summary>
        /// All projects which account equals the value supplied via the `x-4me-account` header.
        /// </summary>
        [EnumMember(Value = "current_account")]
        CurrentAccount,
        /// <summary>
        /// All projects.
        /// </summary>
        [EnumMember(Value = "all")]
        All,
        /// <summary>
        /// Projects managed by me.
        /// </summary>
        [EnumMember(Value = "managed_by_me")]
        ManagedByMe,
        /// <summary>
        /// Projects for my team's services.
        /// </summary>
        [EnumMember(Value = "my_teams_services")]
        MyTeamsServices,
        /// <summary>
        /// Archived projects.
        /// </summary>
        [EnumMember(Value = "archive")]
        Archive,
        /// <summary>
        /// Trashed projects.
        /// </summary>
        [EnumMember(Value = "trash")]
        Trash,
    }

    /// <summary>
    /// The release view.
    /// </summary>
    public enum ReleaseView
    {
        /// <summary>
        /// All releases which account equals the value supplied via the `x-4me-account` header.
        /// </summary>
        [EnumMember(Value = "current_account")]
        CurrentAccount,
        /// <summary>
        /// All releases.
        /// </summary>
        [EnumMember(Value = "all")]
        All,
        /// <summary>
        /// Releases managed by me.
        /// </summary>
        [EnumMember(Value = "managed_by_me")]
        ManagedByMe,
        /// <summary>
        /// Archived releases.
        /// </summary>
        [EnumMember(Value = "archive")]
        Archive,
        /// <summary>
        /// Trashed releases.
        /// </summary>
        [EnumMember(Value = "trash")]
        Trash,
    }

    /// <summary>
    /// The request template view.
    /// </summary>
    public enum RequestTemplateView
    {
        /// <summary>
        /// All request templates which account equals the value supplied via the `x-4me-account` header.
        /// </summary>
        [EnumMember(Value = "current_account")]
        CurrentAccount,
        /// <summary>
        /// Request templates.
        /// </summary>
        [EnumMember(Value = "all")]
        All,
    }

    /// <summary>
    /// The request view.
    /// </summary>
    public enum RequestView
    {
        /// <summary>
        /// All requests which account equals the value supplied via the `x-4me-account` header.
        /// </summary>
        [EnumMember(Value = "current_account")]
        CurrentAccount,
        /// <summary>
        /// All requests.
        /// </summary>
        [EnumMember(Value = "all")]
        All,
        /// <summary>
        /// Requests assigned to my team.
        /// </summary>
        [EnumMember(Value = "assigned_to_my_team")]
        AssignedToMyTeam,
        /// <summary>
        /// Requests assigned to me.
        /// </summary>
        [EnumMember(Value = "assigned_to_me")]
        AssignedToMe,
        /// <summary>
        /// Requests my team is accountable for.
        /// </summary>
        [EnumMember(Value = "sla_accountability")]
        SlaAccountability,
        /// <summary>
        /// Requests assigned to our providers.
        /// </summary>
        [EnumMember(Value = "assigned_to_our_providers")]
        AssignedToOurProviders,
        /// <summary>
        /// Requests requested by or for me.
        /// </summary>
        [EnumMember(Value = "requested_by_or_for_me")]
        RequestedByOrForMe,
        /// <summary>
        /// Requests created by me.
        /// </summary>
        [EnumMember(Value = "created_by_me")]
        CreatedByMe,
        /// <summary>
        /// Requests with dissatisfied requester.
        /// </summary>
        [EnumMember(Value = "requester_dissatisfied")]
        RequesterDissatisfied,
        /// <summary>
        /// Requests for problem identification.
        /// </summary>
        [EnumMember(Value = "problem_management_review")]
        ProblemManagementReview,
        /// <summary>
        /// Archived requests.
        /// </summary>
        [EnumMember(Value = "archive")]
        Archive,
        /// <summary>
        /// Trashed requests.
        /// </summary>
        [EnumMember(Value = "trash")]
        Trash,
    }

    /// <summary>
    /// The reservation offering view.
    /// </summary>
    public enum ReservationOfferingView
    {
        /// <summary>
        /// All reservation offerings which account equals the value supplied via the `x-4me-account` header.
        /// </summary>
        [EnumMember(Value = "current_account")]
        CurrentAccount,
        /// <summary>
        /// Reservation offerings.
        /// </summary>
        [EnumMember(Value = "all")]
        All,
    }

    /// <summary>
    /// The reservation view.
    /// </summary>
    public enum ReservationView
    {
        /// <summary>
        /// All reservations which account equals the value supplied via the `x-4me-account` header.
        /// </summary>
        [EnumMember(Value = "current_account")]
        CurrentAccount,
        /// <summary>
        /// All reservations.
        /// </summary>
        [EnumMember(Value = "all")]
        All,
        /// <summary>
        /// My reservations.
        /// </summary>
        [EnumMember(Value = "personal")]
        Personal,
    }

    /// <summary>
    /// The risk view.
    /// </summary>
    public enum RiskView
    {
        /// <summary>
        /// All risks which account equals the value supplied via the `x-4me-account` header.
        /// </summary>
        [EnumMember(Value = "current_account")]
        CurrentAccount,
        /// <summary>
        /// Risks.
        /// </summary>
        [EnumMember(Value = "all")]
        All,
        /// <summary>
        /// Archived risks.
        /// </summary>
        [EnumMember(Value = "archive")]
        Archive,
        /// <summary>
        /// Trashed risks.
        /// </summary>
        [EnumMember(Value = "trash")]
        Trash,
    }

    /// <summary>
    /// The scrum workspace view.
    /// </summary>
    public enum ScrumWorkspaceView
    {
        /// <summary>
        /// All scrum workspaces which account equals the value supplied via the `x-4me-account` header.
        /// </summary>
        [EnumMember(Value = "current_account")]
        CurrentAccount,
        /// <summary>
        /// Scrum workspaces.
        /// </summary>
        [EnumMember(Value = "all")]
        All,
    }

    /// <summary>
    /// The service instance view.
    /// </summary>
    public enum ServiceInstanceView
    {
        /// <summary>
        /// All service instances which account equals the value supplied via the `x-4me-account` header.
        /// </summary>
        [EnumMember(Value = "current_account")]
        CurrentAccount,
        /// <summary>
        /// Service instances.
        /// </summary>
        [EnumMember(Value = "all")]
        All,
    }

    /// <summary>
    /// The service level agreement view.
    /// </summary>
    public enum ServiceLevelAgreementView
    {
        /// <summary>
        /// All service level agreements which account equals the value supplied via the `x-4me-account` header.
        /// </summary>
        [EnumMember(Value = "current_account")]
        CurrentAccount,
        /// <summary>
        /// Service level agreements.
        /// </summary>
        [EnumMember(Value = "all")]
        All,
    }

    /// <summary>
    /// The service offering view.
    /// </summary>
    public enum ServiceOfferingView
    {
        /// <summary>
        /// All service offerings which account equals the value supplied via the `x-4me-account` header.
        /// </summary>
        [EnumMember(Value = "current_account")]
        CurrentAccount,
        /// <summary>
        /// Service offerings.
        /// </summary>
        [EnumMember(Value = "all")]
        All,
    }

    /// <summary>
    /// The service view.
    /// </summary>
    public enum ServiceView
    {
        /// <summary>
        /// All services which account equals the value supplied via the `x-4me-account` header.
        /// </summary>
        [EnumMember(Value = "current_account")]
        CurrentAccount,
        /// <summary>
        /// Services.
        /// </summary>
        [EnumMember(Value = "all")]
        All,
    }

    /// <summary>
    /// The shop article view.
    /// </summary>
    public enum ShopArticleView
    {
        /// <summary>
        /// All shop articles which account equals the value supplied via the `x-4me-account` header.
        /// </summary>
        [EnumMember(Value = "current_account")]
        CurrentAccount,
        /// <summary>
        /// Shop articles.
        /// </summary>
        [EnumMember(Value = "all")]
        All,
    }

    /// <summary>
    /// The shop order line view.
    /// </summary>
    public enum ShopOrderLineView
    {
        /// <summary>
        /// All shop order lines which account equals the value supplied via the `x-4me-account` header.
        /// </summary>
        [EnumMember(Value = "current_account")]
        CurrentAccount,
        /// <summary>
        /// All shop order lines.
        /// </summary>
        [EnumMember(Value = "all")]
        All,
        /// <summary>
        /// My shop order lines.
        /// </summary>
        [EnumMember(Value = "personal")]
        Personal,
        /// <summary>
        /// Archived shop order lines.
        /// </summary>
        [EnumMember(Value = "archive")]
        Archive,
        /// <summary>
        /// Trashed shop order lines.
        /// </summary>
        [EnumMember(Value = "trash")]
        Trash,
    }

    /// <summary>
    /// The short url view.
    /// </summary>
    public enum ShortUrlView
    {
        /// <summary>
        /// All short urls which account equals the value supplied via the `x-4me-account` header.
        /// </summary>
        [EnumMember(Value = "current_account")]
        CurrentAccount,
        /// <summary>
        /// Short urls.
        /// </summary>
        [EnumMember(Value = "all")]
        All,
    }

    /// <summary>
    /// The site view.
    /// </summary>
    public enum SiteView
    {
        /// <summary>
        /// All sites which account equals the value supplied via the `x-4me-account` header.
        /// </summary>
        [EnumMember(Value = "current_account")]
        CurrentAccount,
        /// <summary>
        /// Sites.
        /// </summary>
        [EnumMember(Value = "all")]
        All,
    }

    /// <summary>
    /// The skill pool view.
    /// </summary>
    public enum SkillPoolView
    {
        /// <summary>
        /// All skill pools which account equals the value supplied via the `x-4me-account` header.
        /// </summary>
        [EnumMember(Value = "current_account")]
        CurrentAccount,
        /// <summary>
        /// Skill pools.
        /// </summary>
        [EnumMember(Value = "all")]
        All,
    }

    /// <summary>
    /// The sprint view.
    /// </summary>
    public enum SprintView
    {
        /// <summary>
        /// All sprints which account equals the value supplied via the `x-4me-account` header.
        /// </summary>
        [EnumMember(Value = "current_account")]
        CurrentAccount,
        /// <summary>
        /// Sprints.
        /// </summary>
        [EnumMember(Value = "all")]
        All,
    }

    /// <summary>
    /// The survey response view.
    /// </summary>
    public enum SurveyResponseView
    {
        /// <summary>
        /// All survey responses which account equals the value supplied via the `x-4me-account` header.
        /// </summary>
        [EnumMember(Value = "current_account")]
        CurrentAccount,
        /// <summary>
        /// Survey responses.
        /// </summary>
        [EnumMember(Value = "all")]
        All,
    }

    /// <summary>
    /// The survey view.
    /// </summary>
    public enum SurveyView
    {
        /// <summary>
        /// All surveys which account equals the value supplied via the `x-4me-account` header.
        /// </summary>
        [EnumMember(Value = "current_account")]
        CurrentAccount,
        /// <summary>
        /// Surveys.
        /// </summary>
        [EnumMember(Value = "all")]
        All,
    }

    /// <summary>
    /// The task template view.
    /// </summary>
    public enum TaskTemplateView
    {
        /// <summary>
        /// All task templates which account equals the value supplied via the `x-4me-account` header.
        /// </summary>
        [EnumMember(Value = "current_account")]
        CurrentAccount,
        /// <summary>
        /// Task templates.
        /// </summary>
        [EnumMember(Value = "all")]
        All,
    }

    /// <summary>
    /// The task view.
    /// </summary>
    public enum TaskView
    {
        /// <summary>
        /// All tasks which account equals the value supplied via the `x-4me-account` header.
        /// </summary>
        [EnumMember(Value = "current_account")]
        CurrentAccount,
        /// <summary>
        /// All tasks.
        /// </summary>
        [EnumMember(Value = "all")]
        All,
        /// <summary>
        /// Tasks assigned to my team.
        /// </summary>
        [EnumMember(Value = "assigned_to_my_team")]
        AssignedToMyTeam,
        /// <summary>
        /// Tasks assigned to me.
        /// </summary>
        [EnumMember(Value = "assigned_to_me")]
        AssignedToMe,
        /// <summary>
        /// Tasks managed by me.
        /// </summary>
        [EnumMember(Value = "managed_by_me")]
        ManagedByMe,
        /// <summary>
        /// Archived tasks.
        /// </summary>
        [EnumMember(Value = "archive")]
        Archive,
        /// <summary>
        /// Trashed tasks.
        /// </summary>
        [EnumMember(Value = "trash")]
        Trash,
    }

    /// <summary>
    /// The team view.
    /// </summary>
    public enum TeamView
    {
        /// <summary>
        /// All teams which account equals the value supplied via the `x-4me-account` header.
        /// </summary>
        [EnumMember(Value = "current_account")]
        CurrentAccount,
        /// <summary>
        /// All teams.
        /// </summary>
        [EnumMember(Value = "all")]
        All,
        /// <summary>
        /// Teams coordinated by me.
        /// </summary>
        [EnumMember(Value = "coordinated_by_me")]
        CoordinatedByMe,
        /// <summary>
        /// Teams managed by me.
        /// </summary>
        [EnumMember(Value = "managed_by_me")]
        ManagedByMe,
    }

    /// <summary>
    /// The time allocation view.
    /// </summary>
    public enum TimeAllocationView
    {
        /// <summary>
        /// All time allocations which account equals the value supplied via the `x-4me-account` header.
        /// </summary>
        [EnumMember(Value = "current_account")]
        CurrentAccount,
        /// <summary>
        /// Time allocations.
        /// </summary>
        [EnumMember(Value = "all")]
        All,
    }

    /// <summary>
    /// The time entry view.
    /// </summary>
    public enum TimeEntryView
    {
        /// <summary>
        /// All time entries which account equals the value supplied via the `x-4me-account` header.
        /// </summary>
        [EnumMember(Value = "current_account")]
        CurrentAccount,
        /// <summary>
        /// Time entries.
        /// </summary>
        [EnumMember(Value = "all")]
        All,
    }

    /// <summary>
    /// The translation view.
    /// </summary>
    public enum TranslationView
    {
        /// <summary>
        /// Translations.
        /// </summary>
        [EnumMember(Value = "current_account")]
        CurrentAccount,
    }

    /// <summary>
    /// The trash view.
    /// </summary>
    public enum TrashView
    {
        /// <summary>
        /// All trashes which account equals the value supplied via the `x-4me-account` header.
        /// </summary>
        [EnumMember(Value = "current_account")]
        CurrentAccount,
        /// <summary>
        /// Trash.
        /// </summary>
        [EnumMember(Value = "all")]
        All,
    }

    /// <summary>
    /// The ui extension view.
    /// </summary>
    public enum UiExtensionView
    {
        /// <summary>
        /// All ui extensions which account equals the value supplied via the `x-4me-account` header.
        /// </summary>
        [EnumMember(Value = "current_account")]
        CurrentAccount,
        /// <summary>
        /// Ui extensions.
        /// </summary>
        [EnumMember(Value = "all")]
        All,
    }

    /// <summary>
    /// The workflow template view.
    /// </summary>
    public enum WorkflowTemplateView
    {
        /// <summary>
        /// All workflow templates which account equals the value supplied via the `x-4me-account` header.
        /// </summary>
        [EnumMember(Value = "current_account")]
        CurrentAccount,
        /// <summary>
        /// Workflow templates.
        /// </summary>
        [EnumMember(Value = "all")]
        All,
    }

    /// <summary>
    /// The workflow view.
    /// </summary>
    public enum WorkflowView
    {
        /// <summary>
        /// All workflows which account equals the value supplied via the `x-4me-account` header.
        /// </summary>
        [EnumMember(Value = "current_account")]
        CurrentAccount,
        /// <summary>
        /// All workflows.
        /// </summary>
        [EnumMember(Value = "all")]
        All,
        /// <summary>
        /// Workflows managed by me.
        /// </summary>
        [EnumMember(Value = "managed_by_me")]
        ManagedByMe,
        /// <summary>
        /// Workflows for my team's services.
        /// </summary>
        [EnumMember(Value = "my_teams_services")]
        MyTeamsServices,
        /// <summary>
        /// Archived workflows.
        /// </summary>
        [EnumMember(Value = "archive")]
        Archive,
        /// <summary>
        /// Trashed workflows.
        /// </summary>
        [EnumMember(Value = "trash")]
        Trash,
    }
}