using System;
using System.Runtime.Serialization;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The address label.
    /// </summary>
    public enum AddressLabel
    {
        /// <summary>
        /// Billing.
        /// </summary>
        [EnumMember(Value = "billing")]
        Billing = 1,
        /// <summary>
        /// Home.
        /// </summary>
        [EnumMember(Value = "home")]
        Home,
        /// <summary>
        /// Mailing.
        /// </summary>
        [EnumMember(Value = "mailing")]
        Mailing,
        /// <summary>
        /// Shipping.
        /// </summary>
        [EnumMember(Value = "shipping")]
        Shipping,
        /// <summary>
        /// Street.
        /// </summary>
        [EnumMember(Value = "street")]
        Street,
    }

    /// <summary>
    /// The affected sla accountability.
    /// </summary>
    public enum AffectedSlaAccountability
    {
        /// <summary>
        /// Provider.
        /// </summary>
        [EnumMember(Value = "provider")]
        Provider = 1,
        /// <summary>
        /// SLA Not Affected.
        /// </summary>
        [EnumMember(Value = "sla_not_affected")]
        SlaNotAffected,
        /// <summary>
        /// Supplier.
        /// </summary>
        [EnumMember(Value = "supplier")]
        Supplier,
    }

    /// <summary>
    /// The agile board column action type.
    /// </summary>
    public enum AgileBoardColumnActionType
    {
        /// <summary>
        /// Accept.
        /// </summary>
        [EnumMember(Value = "accept")]
        Accept = 1,
        /// <summary>
        /// Assign.
        /// </summary>
        [EnumMember(Value = "assign")]
        Assign,
        /// <summary>
        /// Complete.
        /// </summary>
        [EnumMember(Value = "complete")]
        Complete,
        /// <summary>
        /// None.
        /// </summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>
        /// Start.
        /// </summary>
        [EnumMember(Value = "start")]
        Start,
    }

    /// <summary>
    /// The agile board column dialog type.
    /// </summary>
    public enum AgileBoardColumnDialogType
    {
        /// <summary>
        /// Full.
        /// </summary>
        [EnumMember(Value = "full")]
        Full = 1,
        /// <summary>
        /// Minimal.
        /// </summary>
        [EnumMember(Value = "minimal")]
        Minimal,
        /// <summary>
        /// None.
        /// </summary>
        [EnumMember(Value = "none")]
        None,
    }

    /// <summary>
    /// The agreement status.
    /// </summary>
    public enum AgreementStatus
    {
        /// <summary>
        /// Active.
        /// </summary>
        [EnumMember(Value = "active")]
        Active = 1,
        /// <summary>
        /// Being Prepared.
        /// </summary>
        [EnumMember(Value = "being_prepared")]
        BeingPrepared,
        /// <summary>
        /// Expired.
        /// </summary>
        [EnumMember(Value = "expired")]
        Expired,
        /// <summary>
        /// Scheduled for Activation.
        /// </summary>
        [EnumMember(Value = "scheduled_for_activation")]
        ScheduledForActivation,
    }

    /// <summary>
    /// The async query status.
    /// </summary>
    public enum AsyncQueryStatus
    {
        /// <summary>
        /// Completed.
        /// </summary>
        [EnumMember(Value = "completed")]
        Completed = 1,
        /// <summary>
        /// In Progress.
        /// </summary>
        [EnumMember(Value = "in_progress")]
        InProgress,
        /// <summary>
        /// Queued.
        /// </summary>
        [EnumMember(Value = "queued")]
        Queued,
    }

    /// <summary>
    /// The broadcast message type.
    /// </summary>
    public enum BroadcastMessageType
    {
        /// <summary>
        /// Available.
        /// </summary>
        [EnumMember(Value = "available")]
        Available = 1,
        /// <summary>
        /// Email.
        /// </summary>
        [EnumMember(Value = "email")]
        Email,
        /// <summary>
        /// Information.
        /// </summary>
        [EnumMember(Value = "info")]
        Info,
        /// <summary>
        /// Outage.
        /// </summary>
        [EnumMember(Value = "outage")]
        Outage,
        /// <summary>
        /// Warning.
        /// </summary>
        [EnumMember(Value = "warning")]
        Warning,
    }

    /// <summary>
    /// The broadcast visibility.
    /// </summary>
    public enum BroadcastVisibility
    {
        /// <summary>
        /// Account specialists.
        /// </summary>
        [EnumMember(Value = "account_specialists")]
        AccountSpecialists = 1,
        /// <summary>
        /// All people registered in the account.
        /// </summary>
        [EnumMember(Value = "all_of_account")]
        AllOfAccount,
        /// <summary>
        /// People covered for any of our service instances.
        /// </summary>
        [EnumMember(Value = "covered_for_any")]
        CoveredForAny,
        /// <summary>
        /// People covered for the following service instance(s).
        /// </summary>
        [EnumMember(Value = "covered_for")]
        CoveredFor,
        /// <summary>
        /// Customer representatives of the following service level agreement(s).
        /// </summary>
        [EnumMember(Value = "customer_representatives_of_slas")]
        CustomerRepresentativesOfSlas,
        /// <summary>
        /// Specialists in requests from the following customers.
        /// </summary>
        [EnumMember(Value = "customers")]
        Customers,
        /// <summary>
        /// Members of the following skill pool(s).
        /// </summary>
        [EnumMember(Value = "members_of_skill_pools")]
        MembersOfSkillPools,
        /// <summary>
        /// Members of the following team(s).
        /// </summary>
        [EnumMember(Value = "members_of_teams")]
        MembersOfTeams,
        /// <summary>
        /// People of the following organization(s) and their descendants.
        /// </summary>
        [EnumMember(Value = "organizations_and_descendants")]
        OrganizationsAndDescendants,
        /// <summary>
        /// People of the following organization(s).
        /// </summary>
        [EnumMember(Value = "organizations")]
        Organizations,
        /// <summary>
        /// People of the following site(s).
        /// </summary>
        [EnumMember(Value = "sites")]
        Sites,
    }

    /// <summary>
    /// The ci license type.
    /// </summary>
    public enum CiLicenseType
    {
        /// <summary>
        /// Concurrent User License.
        /// </summary>
        [EnumMember(Value = "concurrent_user_license")]
        ConcurrentUserLicense = 1,
        /// <summary>
        /// CPU License.
        /// </summary>
        [EnumMember(Value = "cpu_license")]
        CpuLicense,
        /// <summary>
        /// Installed User License.
        /// </summary>
        [EnumMember(Value = "installed_user_license")]
        InstalledUserLicense,
        /// <summary>
        /// Named User License.
        /// </summary>
        [EnumMember(Value = "named_user_license")]
        NamedUserLicense,
        /// <summary>
        /// Other Type of License.
        /// </summary>
        [EnumMember(Value = "other_type_of_license")]
        OtherTypeOfLicense,
        /// <summary>
        /// Unlimited User License.
        /// </summary>
        [EnumMember(Value = "unlimited_user_license")]
        UnlimitedUserLicense,
    }

    /// <summary>
    /// The ci relation relation type.
    /// </summary>
    public enum CiRelationRelationType
    {
        /// <summary>
        /// Child.
        /// </summary>
        [EnumMember(Value = "child")]
        Child = 1,
        /// <summary>
        /// Continuity.
        /// </summary>
        [EnumMember(Value = "continuity")]
        Continuity,
        /// <summary>
        /// Network Connection.
        /// </summary>
        [EnumMember(Value = "network_connection")]
        NetworkConnection,
        /// <summary>
        /// Parent.
        /// </summary>
        [EnumMember(Value = "parent")]
        Parent,
        /// <summary>
        /// Redundancy.
        /// </summary>
        [EnumMember(Value = "redundancy")]
        Redundancy,
        /// <summary>
        /// Software Dependency.
        /// </summary>
        [EnumMember(Value = "software_dependency")]
        SoftwareDependency,
    }

    /// <summary>
    /// The ci status.
    /// </summary>
    public enum CiStatus
    {
        /// <summary>
        /// Archived.
        /// </summary>
        [EnumMember(Value = "archived")]
        Archived = 1,
        /// <summary>
        /// Being Built.
        /// </summary>
        [EnumMember(Value = "being_built")]
        BeingBuilt,
        /// <summary>
        /// Being Repaired.
        /// </summary>
        [EnumMember(Value = "being_repaired")]
        BeingRepaired,
        /// <summary>
        /// Being Tested.
        /// </summary>
        [EnumMember(Value = "being_tested")]
        BeingTested,
        /// <summary>
        /// Broken Down.
        /// </summary>
        [EnumMember(Value = "broken_down")]
        BrokenDown,
        /// <summary>
        /// In Production.
        /// </summary>
        [EnumMember(Value = "in_production")]
        InProduction,
        /// <summary>
        /// In Stock.
        /// </summary>
        [EnumMember(Value = "in_stock")]
        InStock,
        /// <summary>
        /// In Transit.
        /// </summary>
        [EnumMember(Value = "in_transit")]
        InTransit,
        /// <summary>
        /// Installed.
        /// </summary>
        [EnumMember(Value = "installed")]
        Installed,
        /// <summary>
        /// Lent Out.
        /// </summary>
        [EnumMember(Value = "lent_out")]
        LentOut,
        /// <summary>
        /// Lost or Stolen.
        /// </summary>
        [EnumMember(Value = "lost_or_stolen")]
        LostOrStolen,
        /// <summary>
        /// Ordered.
        /// </summary>
        [EnumMember(Value = "ordered")]
        Ordered,
        /// <summary>
        /// Removed.
        /// </summary>
        [EnumMember(Value = "removed")]
        Removed,
        /// <summary>
        /// Reserved.
        /// </summary>
        [EnumMember(Value = "reserved")]
        Reserved,
        /// <summary>
        /// Standby for Continuity.
        /// </summary>
        [EnumMember(Value = "standby_for_continuity")]
        StandbyForContinuity,
        /// <summary>
        /// To Be Removed.
        /// </summary>
        [EnumMember(Value = "to_be_removed")]
        ToBeRemoved,
        /// <summary>
        /// Undergoing Maintenance.
        /// </summary>
        [EnumMember(Value = "undergoing_maintenance")]
        UndergoingMaintenance,
    }

    /// <summary>
    /// The contact label.
    /// </summary>
    public enum ContactLabel
    {
        /// <summary>
        /// Skype.
        /// </summary>
        [EnumMember(Value = "chat_skype")]
        ChatSkype = 1,
        /// <summary>
        /// Slack.
        /// </summary>
        [EnumMember(Value = "chat_slack")]
        ChatSlack,
        /// <summary>
        /// Teams.
        /// </summary>
        [EnumMember(Value = "chat_teams")]
        ChatTeams,
        /// <summary>
        /// Work Chat.
        /// </summary>
        [EnumMember(Value = "chat_workchat")]
        ChatWorkchat,
        /// <summary>
        /// Emergency.
        /// </summary>
        [EnumMember(Value = "emergency")]
        Emergency,
        /// <summary>
        /// Fax.
        /// </summary>
        [EnumMember(Value = "fax")]
        Fax,
        /// <summary>
        /// General.
        /// </summary>
        [EnumMember(Value = "general")]
        General,
        /// <summary>
        /// Home.
        /// </summary>
        [EnumMember(Value = "home")]
        Home,
        /// <summary>
        /// Mobile.
        /// </summary>
        [EnumMember(Value = "mobile")]
        Mobile,
        /// <summary>
        /// Personal.
        /// </summary>
        [EnumMember(Value = "personal")]
        Personal,
        /// <summary>
        /// Service Desk Fax.
        /// </summary>
        [EnumMember(Value = "service_desk_fax")]
        ServiceDeskFax,
        /// <summary>
        /// Service Desk.
        /// </summary>
        [EnumMember(Value = "service_desk")]
        ServiceDesk,
        /// <summary>
        /// Work.
        /// </summary>
        [EnumMember(Value = "work")]
        Work,
    }

    /// <summary>
    /// The contact protocol.
    /// </summary>
    public enum ContactProtocol
    {
        /// <summary>
        /// Chat.
        /// </summary>
        [EnumMember(Value = "chat")]
        Chat = 1,
        /// <summary>
        /// Email.
        /// </summary>
        [EnumMember(Value = "email")]
        Email,
        /// <summary>
        /// Telephone.
        /// </summary>
        [EnumMember(Value = "telephone")]
        Telephone,
        /// <summary>
        /// Website.
        /// </summary>
        [EnumMember(Value = "website")]
        Website,
    }

    /// <summary>
    /// The contract category.
    /// </summary>
    public enum ContractCategory
    {
        /// <summary>
        /// Lease Contract.
        /// </summary>
        [EnumMember(Value = "lease_contract")]
        LeaseContract = 1,
        /// <summary>
        /// Maintenance Contract.
        /// </summary>
        [EnumMember(Value = "maintenance_contract")]
        MaintenanceContract,
        /// <summary>
        /// Other Type of Contract.
        /// </summary>
        [EnumMember(Value = "other_type_of_contract")]
        OtherTypeOfContract,
        /// <summary>
        /// Support &amp; Maintenance Contract.
        /// </summary>
        [EnumMember(Value = "support_and_maintenance_contract")]
        SupportAndMaintenanceContract,
        /// <summary>
        /// Support Contract.
        /// </summary>
        [EnumMember(Value = "support_contract")]
        SupportContract,
    }

    /// <summary>
    /// The day names.
    /// </summary>
    public enum DayNames
    {
        /// <summary>
        /// Friday.
        /// </summary>
        [EnumMember(Value = "friday")]
        Friday = 1,
        /// <summary>
        /// Monday.
        /// </summary>
        [EnumMember(Value = "monday")]
        Monday,
        /// <summary>
        /// Saturday.
        /// </summary>
        [EnumMember(Value = "saturday")]
        Saturday,
        /// <summary>
        /// Sunday.
        /// </summary>
        [EnumMember(Value = "sunday")]
        Sunday,
        /// <summary>
        /// Thursday.
        /// </summary>
        [EnumMember(Value = "thursday")]
        Thursday,
        /// <summary>
        /// Tuesday.
        /// </summary>
        [EnumMember(Value = "tuesday")]
        Tuesday,
        /// <summary>
        /// Wednesday.
        /// </summary>
        [EnumMember(Value = "wednesday")]
        Wednesday,
    }

    /// <summary>
    /// The discovered item strategy.
    /// </summary>
    public enum DiscoveredItemStrategy
    {
        /// <summary>
        /// Create a new record based on the information supplied if and only if one does not already exists.
        /// </summary>
        [EnumMember(Value = "CREATE")]
        Create = 1,
        /// <summary>
        /// Similar to CREATE. Difference is that discovered records within this product (category) will only be linked to this record on create. So if the discovered records are already present in 4me they will remain linked to their current parent, the value supplied in the mutation will be ignored.
        /// </summary>
        [EnumMember(Value = "DEFAULT")]
        Default,
        /// <summary>
        /// Creates a new record if one does not already exists, otherwise updates the existing record using the values supplied.
        /// </summary>
        [EnumMember(Value = "UPDATE")]
        Update,
    }

    /// <summary>
    /// The discovered reference array strategy.
    /// </summary>
    public enum DiscoveredReferenceArrayStrategy
    {
        /// <summary>
        /// Replaces the existing reference(s) with exactly those supplied.
        /// </summary>
        [EnumMember(Value = "REPLACE")]
        Replace = 1,
        /// <summary>
        /// Ensures the supplied reference is present. If the supplied value is already present no action is taken. If it is not it added to any existing references.
        /// </summary>
        [EnumMember(Value = "APPEND")]
        Append,
    }

    /// <summary>
    /// The feedback satisfaction.
    /// </summary>
    public enum FeedbackSatisfaction
    {
        /// <summary>
        /// Dissatisfied.
        /// </summary>
        [EnumMember(Value = "dissatisfied")]
        Dissatisfied = 1,
        /// <summary>
        /// Satisfied.
        /// </summary>
        [EnumMember(Value = "satisfied")]
        Satisfied,
    }

    /// <summary>
    /// The knowledge article status.
    /// </summary>
    public enum KnowledgeArticleStatus
    {
        /// <summary>
        /// Archived.
        /// </summary>
        [EnumMember(Value = "archived")]
        Archived = 1,
        /// <summary>
        /// Not Validated.
        /// </summary>
        [EnumMember(Value = "not_validated")]
        NotValidated,
        /// <summary>
        /// Validated.
        /// </summary>
        [EnumMember(Value = "validated")]
        Validated,
        /// <summary>
        /// Work In Progress.
        /// </summary>
        [EnumMember(Value = "work_in_progress")]
        WorkInProgress,
    }

    /// <summary>
    /// The life cycle state.
    /// </summary>
    public enum LifeCycleState
    {
        /// <summary>
        /// Active.
        /// </summary>
        [EnumMember(Value = "active")]
        Active = 1,
        /// <summary>
        /// Archived.
        /// </summary>
        [EnumMember(Value = "archived")]
        Archived,
        /// <summary>
        /// Erased.
        /// </summary>
        [EnumMember(Value = "erased")]
        Erased,
        /// <summary>
        /// Trashed.
        /// </summary>
        [EnumMember(Value = "trashed")]
        Trashed,
    }

    /// <summary>
    /// The note medium.
    /// </summary>
    public enum NoteMedium
    {
        /// <summary>
        /// Automation.
        /// </summary>
        [EnumMember(Value = "automation")]
        Automation = 1,
        /// <summary>
        /// Default.
        /// </summary>
        [EnumMember(Value = "default")]
        Default,
        /// <summary>
        /// Email.
        /// </summary>
        [EnumMember(Value = "email")]
        Email,
        /// <summary>
        /// Outbound Email.
        /// </summary>
        [EnumMember(Value = "outbound_email")]
        OutboundEmail,
        /// <summary>
        /// Redacted.
        /// </summary>
        [EnumMember(Value = "redacted")]
        Redacted,
        /// <summary>
        /// Reference.
        /// </summary>
        [EnumMember(Value = "reference")]
        Reference,
        /// <summary>
        /// System.
        /// </summary>
        [EnumMember(Value = "system")]
        System,
    }

    /// <summary>
    /// The note visibility.
    /// </summary>
    public enum NoteVisibility
    {
        /// <summary>
        /// Audit.
        /// </summary>
        [EnumMember(Value = "audit")]
        Audit = 1,
        /// <summary>
        /// End User.
        /// </summary>
        [EnumMember(Value = "end_user")]
        EndUser,
        /// <summary>
        /// Specialist.
        /// </summary>
        [EnumMember(Value = "specialist")]
        Specialist,
    }

    /// <summary>
    /// The oauth application grant type.
    /// </summary>
    public enum OauthApplicationGrantType
    {
        /// <summary>
        /// Authorization code grant.
        /// </summary>
        [EnumMember(Value = "authorization_code")]
        AuthorizationCode = 1,
        /// <summary>
        /// Client credentials grant.
        /// </summary>
        [EnumMember(Value = "client_credentials")]
        ClientCredentials,
    }

    /// <summary>
    /// The parent service instance impact relation.
    /// </summary>
    public enum ParentServiceInstanceImpactRelation
    {
        /// <summary>
        /// Degraded if Service Instance of SLA is Down or Degraded.
        /// </summary>
        [EnumMember(Value = "degraded")]
        Degraded = 1,
        /// <summary>
        /// Down if Service Instance of SLA is Down.
        /// </summary>
        [EnumMember(Value = "down")]
        Down,
    }

    /// <summary>
    /// The pdf design category.
    /// </summary>
    public enum PdfDesignCategory
    {
        /// <summary>
        /// Dashboard.
        /// </summary>
        [EnumMember(Value = "dashboard")]
        Dashboard = 1,
        /// <summary>
        /// Project Summary.
        /// </summary>
        [EnumMember(Value = "project_summary")]
        ProjectSummary,
        /// <summary>
        /// Workflow Summary.
        /// </summary>
        [EnumMember(Value = "workflow_summary")]
        WorkflowSummary,
    }

    /// <summary>
    /// The permission role.
    /// </summary>
    public enum PermissionRole
    {
        /// <summary>
        /// Account administrator.
        /// </summary>
        [EnumMember(Value = "account_administrator")]
        AccountAdministrator = 1,
        /// <summary>
        /// Account designer.
        /// </summary>
        [EnumMember(Value = "account_designer")]
        AccountDesigner,
        /// <summary>
        /// Account owner.
        /// </summary>
        [EnumMember(Value = "account_owner")]
        AccountOwner,
        /// <summary>
        /// Auditor.
        /// </summary>
        [EnumMember(Value = "auditor")]
        Auditor,
        /// <summary>
        /// Configuration manager.
        /// </summary>
        [EnumMember(Value = "configuration_manager")]
        ConfigurationManager,
        /// <summary>
        /// Directory administrator.
        /// </summary>
        [EnumMember(Value = "directory_administrator")]
        DirectoryAdministrator,
        /// <summary>
        /// Directory auditor.
        /// </summary>
        [EnumMember(Value = "directory_auditor")]
        DirectoryAuditor,
        /// <summary>
        /// Directory designer.
        /// </summary>
        [EnumMember(Value = "directory_designer")]
        DirectoryDesigner,
        /// <summary>
        /// Financial manager.
        /// </summary>
        [EnumMember(Value = "financial_manager")]
        FinancialManager,
        /// <summary>
        /// Key contact.
        /// </summary>
        [EnumMember(Value = "key_contact")]
        KeyContact,
        /// <summary>
        /// Knowledge manager.
        /// </summary>
        [EnumMember(Value = "knowledge_manager")]
        KnowledgeManager,
        /// <summary>
        /// Problem manager.
        /// </summary>
        [EnumMember(Value = "problem_manager")]
        ProblemManager,
        /// <summary>
        /// Project manager.
        /// </summary>
        [EnumMember(Value = "project_manager")]
        ProjectManager,
        /// <summary>
        /// Release manager.
        /// </summary>
        [EnumMember(Value = "release_manager")]
        ReleaseManager,
        /// <summary>
        /// Service desk analyst.
        /// </summary>
        [EnumMember(Value = "service_desk_analyst")]
        ServiceDeskAnalyst,
        /// <summary>
        /// Service desk manager.
        /// </summary>
        [EnumMember(Value = "service_desk_manager")]
        ServiceDeskManager,
        /// <summary>
        /// Service level manager.
        /// </summary>
        [EnumMember(Value = "service_level_manager")]
        ServiceLevelManager,
        /// <summary>
        /// Specialist.
        /// </summary>
        [EnumMember(Value = "specialist")]
        Specialist,
        /// <summary>
        /// Workflow automator auditor.
        /// </summary>
        [EnumMember(Value = "workflow_automator_auditor")]
        WorkflowAutomatorAuditor,
        /// <summary>
        /// Workflow automator specialist.
        /// </summary>
        [EnumMember(Value = "workflow_automator_specialist")]
        WorkflowAutomatorSpecialist,
        /// <summary>
        /// Workflow manager.
        /// </summary>
        [EnumMember(Value = "workflow_manager")]
        WorkflowManager,
    }

    /// <summary>
    /// The person send email notifications.
    /// </summary>
    public enum PersonSendEmailNotifications
    {
        /// <summary>
        /// Always.
        /// </summary>
        [EnumMember(Value = "always")]
        Always = 1,
        /// <summary>
        /// Never.
        /// </summary>
        [EnumMember(Value = "never")]
        Never,
        /// <summary>
        /// Only when I am offline.
        /// </summary>
        [EnumMember(Value = "when_offline")]
        WhenOffline,
    }

    /// <summary>
    /// The person show notification popup.
    /// </summary>
    public enum PersonShowNotificationPopup
    {
        /// <summary>
        /// Always.
        /// </summary>
        [EnumMember(Value = "always")]
        Always = 1,
        /// <summary>
        /// Only for important notifications.
        /// </summary>
        [EnumMember(Value = "important_only")]
        ImportantOnly,
        /// <summary>
        /// Never.
        /// </summary>
        [EnumMember(Value = "never")]
        Never,
    }

    /// <summary>
    /// The problem category.
    /// </summary>
    public enum ProblemCategory
    {
        /// <summary>
        /// Proactive - Anticipated Problem.
        /// </summary>
        [EnumMember(Value = "proactive")]
        Proactive = 1,
        /// <summary>
        /// Reactive - Existing Problem.
        /// </summary>
        [EnumMember(Value = "reactive")]
        Reactive,
    }

    /// <summary>
    /// The problem impact.
    /// </summary>
    public enum ProblemImpact
    {
        /// <summary>
        /// High - Degrades Service for Several Users.
        /// </summary>
        [EnumMember(Value = "high")]
        High = 1,
        /// <summary>
        /// Low - Degrades Service for One User.
        /// </summary>
        [EnumMember(Value = "low")]
        Low,
        /// <summary>
        /// Medium - Brings Service Down for One User.
        /// </summary>
        [EnumMember(Value = "medium")]
        Medium,
        /// <summary>
        /// None - Does Not Degrade Service.
        /// </summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>
        /// Top - Brings Service Down for Several Users.
        /// </summary>
        [EnumMember(Value = "top")]
        Top,
    }

    /// <summary>
    /// The problem status.
    /// </summary>
    public enum ProblemStatus
    {
        /// <summary>
        /// Accepted.
        /// </summary>
        [EnumMember(Value = "accepted")]
        Accepted = 1,
        /// <summary>
        /// Analyzed.
        /// </summary>
        [EnumMember(Value = "analyzed")]
        Analyzed,
        /// <summary>
        /// Assigned.
        /// </summary>
        [EnumMember(Value = "assigned")]
        Assigned,
        /// <summary>
        /// Change Requested.
        /// </summary>
        [EnumMember(Value = "change_requested")]
        ChangeRequested,
        /// <summary>
        /// Declined.
        /// </summary>
        [EnumMember(Value = "declined")]
        Declined,
        /// <summary>
        /// In Progress.
        /// </summary>
        [EnumMember(Value = "in_progress")]
        InProgress,
        /// <summary>
        /// On Backlog.
        /// </summary>
        [EnumMember(Value = "on_backlog")]
        OnBacklog,
        /// <summary>
        /// Progress Halted.
        /// </summary>
        [EnumMember(Value = "progress_halted")]
        ProgressHalted,
        /// <summary>
        /// Project Pending.
        /// </summary>
        [EnumMember(Value = "project_pending")]
        ProjectPending,
        /// <summary>
        /// Solved.
        /// </summary>
        [EnumMember(Value = "solved")]
        Solved,
        /// <summary>
        /// Waiting for...
        /// </summary>
        [EnumMember(Value = "waiting_for")]
        WaitingFor,
        /// <summary>
        /// Workflow Pending.
        /// </summary>
        [EnumMember(Value = "workflow_pending")]
        WorkflowPending,
    }

    /// <summary>
    /// The product category rule set.
    /// </summary>
    public enum ProductCategoryRuleSet
    {
        /// <summary>
        /// License Certificate.
        /// </summary>
        [EnumMember(Value = "license_certificate")]
        LicenseCertificate = 1,
        /// <summary>
        /// Logical Asset with Financial Data.
        /// </summary>
        [EnumMember(Value = "logical_asset_with_financial_data")]
        LogicalAssetWithFinancialData,
        /// <summary>
        /// Logical Asset without Financial Data.
        /// </summary>
        [EnumMember(Value = "logical_asset_without_financial_data")]
        LogicalAssetWithoutFinancialData,
        /// <summary>
        /// Physical Asset.
        /// </summary>
        [EnumMember(Value = "physical_asset")]
        PhysicalAsset,
        /// <summary>
        /// Server.
        /// </summary>
        [EnumMember(Value = "server")]
        Server,
        /// <summary>
        /// Software Distribution Package.
        /// </summary>
        [EnumMember(Value = "software_distribution_package")]
        SoftwareDistributionPackage,
        /// <summary>
        /// Software.
        /// </summary>
        [EnumMember(Value = "software")]
        Software,
    }

    /// <summary>
    /// The product depreciation method.
    /// </summary>
    public enum ProductDepreciationMethod
    {
        /// <summary>
        /// Double Declining Balance.
        /// </summary>
        [EnumMember(Value = "double_declining_balance")]
        DoubleDecliningBalance = 1,
        /// <summary>
        /// DEPRECATED: N/A - Cost is Zero/Included in Other CI or Service.
        /// </summary>
        [Obsolete("N/A - Cost is Zero/Included in Other CI or Service.")]
        [EnumMember(Value = "na_cost_is_zero")]
        NaCostIsZero,
        /// <summary>
        /// DEPRECATED: N/A - Leased.
        /// </summary>
        [Obsolete("N/A - Leased.")]
        [EnumMember(Value = "na_leased")]
        NaLeased,
        /// <summary>
        /// DEPRECATED: N/A - Not Capitalized.
        /// </summary>
        [Obsolete("N/A - Not Capitalized.")]
        [EnumMember(Value = "na_not_capitalized")]
        NaNotCapitalized,
        /// <summary>
        /// Not Depreciated.
        /// </summary>
        [EnumMember(Value = "not_depreciated")]
        NotDepreciated,
        /// <summary>
        /// Reducing Balance (or Diminishing Value).
        /// </summary>
        [EnumMember(Value = "reducing_balance")]
        ReducingBalance,
        /// <summary>
        /// Straight Line (or Prime Cost).
        /// </summary>
        [EnumMember(Value = "straight_line")]
        StraightLine,
        /// <summary>
        /// Sum of the Year’s Digits.
        /// </summary>
        [EnumMember(Value = "sum_of_the_years_digits")]
        SumOfTheYearsDigits,
    }

    /// <summary>
    /// The project completion reason.
    /// </summary>
    public enum ProjectCompletionReason
    {
        /// <summary>
        /// Abandoned - Not Implemented.
        /// </summary>
        [EnumMember(Value = "abandoned")]
        Abandoned = 1,
        /// <summary>
        /// Complete - Fully Implemented.
        /// </summary>
        [EnumMember(Value = "complete")]
        Complete,
        /// <summary>
        /// Partial - Not Entirely Implemented.
        /// </summary>
        [EnumMember(Value = "partial")]
        Partial,
        /// <summary>
        /// Rejected - Rejected by Approver.
        /// </summary>
        [EnumMember(Value = "rejected")]
        Rejected,
        /// <summary>
        /// Withdrawn - Withdrawn by Requester.
        /// </summary>
        [EnumMember(Value = "withdrawn")]
        Withdrawn,
    }

    /// <summary>
    /// The project justification.
    /// </summary>
    public enum ProjectJustification
    {
        /// <summary>
        /// Compliance.
        /// </summary>
        [EnumMember(Value = "compliance")]
        Compliance = 1,
        /// <summary>
        /// Correction.
        /// </summary>
        [EnumMember(Value = "correction")]
        Correction,
        /// <summary>
        /// Expansion.
        /// </summary>
        [EnumMember(Value = "expansion")]
        Expansion,
        /// <summary>
        /// Improvement.
        /// </summary>
        [EnumMember(Value = "improvement")]
        Improvement,
        /// <summary>
        /// Maintenance.
        /// </summary>
        [EnumMember(Value = "maintenance")]
        Maintenance,
        /// <summary>
        /// Move.
        /// </summary>
        [EnumMember(Value = "move")]
        Move,
        /// <summary>
        /// Removal.
        /// </summary>
        [EnumMember(Value = "removal")]
        Removal,
        /// <summary>
        /// Replacement.
        /// </summary>
        [EnumMember(Value = "replacement")]
        Replacement,
    }

    /// <summary>
    /// The project phase status.
    /// </summary>
    public enum ProjectPhaseStatus
    {
        /// <summary>
        /// Completed.
        /// </summary>
        [EnumMember(Value = "completed")]
        Completed = 1,
        /// <summary>
        /// In Progress.
        /// </summary>
        [EnumMember(Value = "in_progress")]
        InProgress,
        /// <summary>
        /// Registered.
        /// </summary>
        [EnumMember(Value = "registered")]
        Registered,
    }

    /// <summary>
    /// The project status.
    /// </summary>
    public enum ProjectStatus
    {
        /// <summary>
        /// Completed.
        /// </summary>
        [EnumMember(Value = "completed")]
        Completed = 1,
        /// <summary>
        /// In Progress.
        /// </summary>
        [EnumMember(Value = "in_progress")]
        InProgress,
        /// <summary>
        /// Progress Halted.
        /// </summary>
        [EnumMember(Value = "progress_halted")]
        ProgressHalted,
        /// <summary>
        /// Registered.
        /// </summary>
        [EnumMember(Value = "registered")]
        Registered,
    }

    /// <summary>
    /// The project task category.
    /// </summary>
    public enum ProjectTaskCategory
    {
        /// <summary>
        /// Activity.
        /// </summary>
        [EnumMember(Value = "activity")]
        Activity = 1,
        /// <summary>
        /// Approval.
        /// </summary>
        [EnumMember(Value = "approval")]
        Approval,
        /// <summary>
        /// Milestone.
        /// </summary>
        [EnumMember(Value = "milestone")]
        Milestone,
    }

    /// <summary>
    /// The project task note behavior.
    /// </summary>
    public enum ProjectTaskNoteBehavior
    {
        /// <summary>
        /// Hidden.
        /// </summary>
        [EnumMember(Value = "hidden")]
        Hidden = 1,
        /// <summary>
        /// Optional on Approval.
        /// </summary>
        [EnumMember(Value = "optional_on_approval")]
        OptionalOnApproval,
        /// <summary>
        /// Optional on Completion.
        /// </summary>
        [EnumMember(Value = "optional_on_completion")]
        OptionalOnCompletion,
        /// <summary>
        /// Required on Approval.
        /// </summary>
        [EnumMember(Value = "required_on_approval")]
        RequiredOnApproval,
        /// <summary>
        /// Required on Completion.
        /// </summary>
        [EnumMember(Value = "required_on_completion")]
        RequiredOnCompletion,
    }

    /// <summary>
    /// The project task status.
    /// </summary>
    public enum ProjectTaskStatus
    {
        /// <summary>
        /// Accepted.
        /// </summary>
        [EnumMember(Value = "accepted")]
        Accepted = 1,
        /// <summary>
        /// Approved.
        /// </summary>
        [EnumMember(Value = "approved")]
        Approved,
        /// <summary>
        /// Assigned.
        /// </summary>
        [EnumMember(Value = "assigned")]
        Assigned,
        /// <summary>
        /// Canceled.
        /// </summary>
        [EnumMember(Value = "canceled")]
        Canceled,
        /// <summary>
        /// Completed.
        /// </summary>
        [EnumMember(Value = "completed")]
        Completed,
        /// <summary>
        /// Failed.
        /// </summary>
        [EnumMember(Value = "failed")]
        Failed,
        /// <summary>
        /// In Progress.
        /// </summary>
        [EnumMember(Value = "in_progress")]
        InProgress,
        /// <summary>
        /// Registered.
        /// </summary>
        [EnumMember(Value = "registered")]
        Registered,
        /// <summary>
        /// Rejected.
        /// </summary>
        [EnumMember(Value = "rejected")]
        Rejected,
        /// <summary>
        /// Waiting for...
        /// </summary>
        [EnumMember(Value = "waiting_for")]
        WaitingFor,
    }

    /// <summary>
    /// The recurrence day of week index.
    /// </summary>
    public enum RecurrenceDayOfWeekIndex
    {
        /// <summary>
        /// First.
        /// </summary>
        [EnumMember(Value = "first")]
        First = 1,
        /// <summary>
        /// Fourth.
        /// </summary>
        [EnumMember(Value = "fourth")]
        Fourth,
        /// <summary>
        /// Last.
        /// </summary>
        [EnumMember(Value = "last")]
        Last,
        /// <summary>
        /// Second.
        /// </summary>
        [EnumMember(Value = "second")]
        Second,
        /// <summary>
        /// Third.
        /// </summary>
        [EnumMember(Value = "third")]
        Third,
    }

    /// <summary>
    /// The recurrence frequency.
    /// </summary>
    public enum RecurrenceFrequency
    {
        /// <summary>
        /// Daily.
        /// </summary>
        [EnumMember(Value = "daily")]
        Daily = 1,
        /// <summary>
        /// Monthly.
        /// </summary>
        [EnumMember(Value = "monthly")]
        Monthly,
        /// <summary>
        /// No Repeat.
        /// </summary>
        [EnumMember(Value = "no_repeat")]
        NoRepeat,
        /// <summary>
        /// Weekly.
        /// </summary>
        [EnumMember(Value = "weekly")]
        Weekly,
        /// <summary>
        /// Yearly.
        /// </summary>
        [EnumMember(Value = "yearly")]
        Yearly,
    }

    /// <summary>
    /// The request category.
    /// </summary>
    public enum RequestCategory
    {
        /// <summary>
        /// Case.
        /// </summary>
        [EnumMember(Value = "case")]
        Case = 1,
        /// <summary>
        /// Complaint - Request for Support Improvement.
        /// </summary>
        [EnumMember(Value = "complaint")]
        Complaint,
        /// <summary>
        /// Compliment - Request for Bestowal of Praise.
        /// </summary>
        [EnumMember(Value = "compliment")]
        Compliment,
        /// <summary>
        /// Fulfillment - Request for Order Fulfillment.
        /// </summary>
        [EnumMember(Value = "fulfillment")]
        Fulfillment,
        /// <summary>
        /// Incident - Request for Incident Resolution.
        /// </summary>
        [EnumMember(Value = "incident")]
        Incident,
        /// <summary>
        /// Order - Request for Purchase.
        /// </summary>
        [EnumMember(Value = "order")]
        Order,
        /// <summary>
        /// Other - Request is Out of Scope.
        /// </summary>
        [EnumMember(Value = "other")]
        Other,
        /// <summary>
        /// Reservation - Request for Reservation.
        /// </summary>
        [EnumMember(Value = "reservation")]
        Reservation,
        /// <summary>
        /// RFC - Request for Change.
        /// </summary>
        [EnumMember(Value = "rfc")]
        Rfc,
        /// <summary>
        /// RFI - Request for Information.
        /// </summary>
        [EnumMember(Value = "rfi")]
        Rfi,
    }

    /// <summary>
    /// The request completion reason.
    /// </summary>
    public enum RequestCompletionReason
    {
        /// <summary>
        /// Conflict - In Conflict with Internal Standard or Policy.
        /// </summary>
        [EnumMember(Value = "conflict")]
        Conflict = 1,
        /// <summary>
        /// Declined - Declined by Service Provider.
        /// </summary>
        [EnumMember(Value = "declined")]
        Declined,
        /// <summary>
        /// Duplicate - Same as Another Request of Customer.
        /// </summary>
        [EnumMember(Value = "duplicate")]
        Duplicate,
        /// <summary>
        /// Gone - Issue Can No Longer Be Found.
        /// </summary>
        [EnumMember(Value = "gone")]
        Gone,
        /// <summary>
        /// No Reply - No Reply Received from Customer.
        /// </summary>
        [EnumMember(Value = "no_reply")]
        NoReply,
        /// <summary>
        /// Rejected - Rejected by Approver.
        /// </summary>
        [EnumMember(Value = "rejected")]
        Rejected,
        /// <summary>
        /// Solved - Review Not Required.
        /// </summary>
        [EnumMember(Value = "solved")]
        Solved,
        /// <summary>
        /// Unsolvable - Unable to Solve.
        /// </summary>
        [EnumMember(Value = "unsolvable")]
        Unsolvable,
        /// <summary>
        /// Withdrawn - Withdrawn by Requester.
        /// </summary>
        [EnumMember(Value = "withdrawn")]
        Withdrawn,
        /// <summary>
        /// Workaround - Review Required.
        /// </summary>
        [EnumMember(Value = "workaround")]
        Workaround,
    }

    /// <summary>
    /// The request grouping.
    /// </summary>
    public enum RequestGrouping
    {
        /// <summary>
        /// Group.
        /// </summary>
        [EnumMember(Value = "group")]
        Group = 1,
        /// <summary>
        /// Grouped.
        /// </summary>
        [EnumMember(Value = "grouped")]
        Grouped,
        /// <summary>
        /// None.
        /// </summary>
        [EnumMember(Value = "none")]
        None,
    }

    /// <summary>
    /// The request impact.
    /// </summary>
    public enum RequestImpact
    {
        /// <summary>
        /// High - Service Degraded for Several Users.
        /// </summary>
        [EnumMember(Value = "high")]
        High = 1,
        /// <summary>
        /// Low - Service Degraded for One User.
        /// </summary>
        [EnumMember(Value = "low")]
        Low,
        /// <summary>
        /// Medium - Service Down for One User.
        /// </summary>
        [EnumMember(Value = "medium")]
        Medium,
        /// <summary>
        /// Top - Service Down for Several Users.
        /// </summary>
        [EnumMember(Value = "top")]
        Top,
    }

    /// <summary>
    /// The request major incident status.
    /// </summary>
    public enum RequestMajorIncidentStatus
    {
        /// <summary>
        /// Accepted.
        /// </summary>
        [EnumMember(Value = "accepted")]
        Accepted = 1,
        /// <summary>
        /// Canceled.
        /// </summary>
        [EnumMember(Value = "canceled")]
        Canceled,
        /// <summary>
        /// Proposed.
        /// </summary>
        [EnumMember(Value = "proposed")]
        Proposed,
        /// <summary>
        /// Rejected.
        /// </summary>
        [EnumMember(Value = "rejected")]
        Rejected,
        /// <summary>
        /// Resolved.
        /// </summary>
        [EnumMember(Value = "resolved")]
        Resolved,
    }

    /// <summary>
    /// The request status.
    /// </summary>
    public enum RequestStatus
    {
        /// <summary>
        /// Accepted.
        /// </summary>
        [EnumMember(Value = "accepted")]
        Accepted = 1,
        /// <summary>
        /// Assigned.
        /// </summary>
        [EnumMember(Value = "assigned")]
        Assigned,
        /// <summary>
        /// Completed.
        /// </summary>
        [EnumMember(Value = "completed")]
        Completed,
        /// <summary>
        /// Declined.
        /// </summary>
        [EnumMember(Value = "declined")]
        Declined,
        /// <summary>
        /// In Progress.
        /// </summary>
        [EnumMember(Value = "in_progress")]
        InProgress,
        /// <summary>
        /// On Backlog.
        /// </summary>
        [EnumMember(Value = "on_backlog")]
        OnBacklog,
        /// <summary>
        /// Project Pending.
        /// </summary>
        [EnumMember(Value = "project_pending")]
        ProjectPending,
        /// <summary>
        /// Reservation Pending.
        /// </summary>
        [EnumMember(Value = "reservation_pending")]
        ReservationPending,
        /// <summary>
        /// Waiting for Customer.
        /// </summary>
        [EnumMember(Value = "waiting_for_customer")]
        WaitingForCustomer,
        /// <summary>
        /// Waiting for...
        /// </summary>
        [EnumMember(Value = "waiting_for")]
        WaitingFor,
        /// <summary>
        /// Workflow Pending.
        /// </summary>
        [EnumMember(Value = "workflow_pending")]
        WorkflowPending,
    }

    /// <summary>
    /// The reservation status.
    /// </summary>
    public enum ReservationStatus
    {
        /// <summary>
        /// Active.
        /// </summary>
        [EnumMember(Value = "active")]
        Active = 1,
        /// <summary>
        /// Being Prepared.
        /// </summary>
        [EnumMember(Value = "being_prepared")]
        BeingPrepared,
        /// <summary>
        /// Canceled.
        /// </summary>
        [EnumMember(Value = "canceled")]
        Canceled,
        /// <summary>
        /// Confirmed.
        /// </summary>
        [EnumMember(Value = "confirmed")]
        Confirmed,
        /// <summary>
        /// Conflicting.
        /// </summary>
        [EnumMember(Value = "conflicting")]
        Conflicting,
        /// <summary>
        /// Ended.
        /// </summary>
        [EnumMember(Value = "ended")]
        Ended,
        /// <summary>
        /// Pending.
        /// </summary>
        [EnumMember(Value = "pending")]
        Pending,
        /// <summary>
        /// Prototype.
        /// </summary>
        [EnumMember(Value = "prototype")]
        Prototype,
        /// <summary>
        /// Provisional.
        /// </summary>
        [EnumMember(Value = "provisional")]
        Provisional,
    }

    /// <summary>
    /// The risk closure reason.
    /// </summary>
    public enum RiskClosureReason
    {
        /// <summary>
        /// Accepted - Risk Level Accepted.
        /// </summary>
        [EnumMember(Value = "accepted")]
        Accepted = 1,
        /// <summary>
        /// Eliminated - Risk Completely Eliminated.
        /// </summary>
        [EnumMember(Value = "eliminated")]
        Eliminated,
        /// <summary>
        /// Mitigated - Risk Reduced to Acceptable Level.
        /// </summary>
        [EnumMember(Value = "mitigated")]
        Mitigated,
        /// <summary>
        /// No Risk - Assessment Found No Risk.
        /// </summary>
        [EnumMember(Value = "no_risk")]
        NoRisk,
        /// <summary>
        /// Transferred - Risk Transferred to Another Organization.
        /// </summary>
        [EnumMember(Value = "transferred")]
        Transferred,
    }

    /// <summary>
    /// The risk status.
    /// </summary>
    public enum RiskStatus
    {
        /// <summary>
        /// Anticipated.
        /// </summary>
        [EnumMember(Value = "anticipated")]
        Anticipated = 1,
        /// <summary>
        /// Closed.
        /// </summary>
        [EnumMember(Value = "closed")]
        Closed,
        /// <summary>
        /// Materialized.
        /// </summary>
        [EnumMember(Value = "materialized")]
        Materialized,
    }

    /// <summary>
    /// The scope effect.
    /// </summary>
    public enum ScopeEffect
    {
        /// <summary>
        /// Allow.
        /// </summary>
        [EnumMember(Value = "allow")]
        Allow = 1,
        /// <summary>
        /// Deny.
        /// </summary>
        [EnumMember(Value = "deny")]
        Deny,
    }

    /// <summary>
    /// The service instance status.
    /// </summary>
    public enum ServiceInstanceStatus
    {
        /// <summary>
        /// Being Prepared.
        /// </summary>
        [EnumMember(Value = "being_prepared")]
        BeingPrepared = 1,
        /// <summary>
        /// Discontinued.
        /// </summary>
        [EnumMember(Value = "discontinued")]
        Discontinued,
        /// <summary>
        /// In Production.
        /// </summary>
        [EnumMember(Value = "in_production")]
        InProduction,
    }

    /// <summary>
    /// The service offering charge type.
    /// </summary>
    public enum ServiceOfferingChargeType
    {
        /// <summary>
        /// Fixed Price.
        /// </summary>
        [EnumMember(Value = "fixed_price")]
        FixedPrice = 1,
        /// <summary>
        /// Time &amp; Material.
        /// </summary>
        [EnumMember(Value = "time_material")]
        TimeMaterial,
    }

    /// <summary>
    /// The service offering report frequency.
    /// </summary>
    public enum ServiceOfferingReportFrequency
    {
        /// <summary>
        /// Daily.
        /// </summary>
        [EnumMember(Value = "daily")]
        Daily = 1,
        /// <summary>
        /// Monthly.
        /// </summary>
        [EnumMember(Value = "monthly")]
        Monthly,
        /// <summary>
        /// No Commitment.
        /// </summary>
        [EnumMember(Value = "no_commitment")]
        NoCommitment,
        /// <summary>
        /// Once Every 2 Months.
        /// </summary>
        [EnumMember(Value = "once_every_2_months")]
        OnceEvery2Months,
        /// <summary>
        /// Once Every 2 Weeks.
        /// </summary>
        [EnumMember(Value = "once_every_2_weeks")]
        OnceEvery2Weeks,
        /// <summary>
        /// Once Every 2 Years.
        /// </summary>
        [EnumMember(Value = "once_every_2_years")]
        OnceEvery2Years,
        /// <summary>
        /// Once Every 6 Months.
        /// </summary>
        [EnumMember(Value = "once_every_6_months")]
        OnceEvery6Months,
        /// <summary>
        /// Quarterly.
        /// </summary>
        [EnumMember(Value = "quarterly")]
        Quarterly,
        /// <summary>
        /// Weekly.
        /// </summary>
        [EnumMember(Value = "weekly")]
        Weekly,
        /// <summary>
        /// Yearly.
        /// </summary>
        [EnumMember(Value = "yearly")]
        Yearly,
    }

    /// <summary>
    /// The service offering review frequency.
    /// </summary>
    public enum ServiceOfferingReviewFrequency
    {
        /// <summary>
        /// Daily.
        /// </summary>
        [EnumMember(Value = "daily")]
        Daily = 1,
        /// <summary>
        /// Monthly.
        /// </summary>
        [EnumMember(Value = "monthly")]
        Monthly,
        /// <summary>
        /// No Commitment.
        /// </summary>
        [EnumMember(Value = "no_commitment")]
        NoCommitment,
        /// <summary>
        /// Once Every 2 Months.
        /// </summary>
        [EnumMember(Value = "once_every_2_months")]
        OnceEvery2Months,
        /// <summary>
        /// Once Every 2 Weeks.
        /// </summary>
        [EnumMember(Value = "once_every_2_weeks")]
        OnceEvery2Weeks,
        /// <summary>
        /// Once Every 2 Years.
        /// </summary>
        [EnumMember(Value = "once_every_2_years")]
        OnceEvery2Years,
        /// <summary>
        /// Once Every 6 Months.
        /// </summary>
        [EnumMember(Value = "once_every_6_months")]
        OnceEvery6Months,
        /// <summary>
        /// Quarterly.
        /// </summary>
        [EnumMember(Value = "quarterly")]
        Quarterly,
        /// <summary>
        /// Weekly.
        /// </summary>
        [EnumMember(Value = "weekly")]
        Weekly,
        /// <summary>
        /// Yearly.
        /// </summary>
        [EnumMember(Value = "yearly")]
        Yearly,
    }

    /// <summary>
    /// The service offering status.
    /// </summary>
    public enum ServiceOfferingStatus
    {
        /// <summary>
        /// Available.
        /// </summary>
        [EnumMember(Value = "available")]
        Available = 1,
        /// <summary>
        /// Discontinued.
        /// </summary>
        [EnumMember(Value = "discontinued")]
        Discontinued,
        /// <summary>
        /// Planned.
        /// </summary>
        [EnumMember(Value = "planned")]
        Planned,
        /// <summary>
        /// Temporarily Unavailable.
        /// </summary>
        [EnumMember(Value = "temporarily_unavailable")]
        TemporarilyUnavailable,
        /// <summary>
        /// Unpublished.
        /// </summary>
        [EnumMember(Value = "unpublished")]
        Unpublished,
    }

    /// <summary>
    /// The shop article recurring period.
    /// </summary>
    public enum ShopArticleRecurringPeriod
    {
        /// <summary>
        /// Monthly.
        /// </summary>
        [EnumMember(Value = "monthly")]
        Monthly = 1,
        /// <summary>
        /// Yearly.
        /// </summary>
        [EnumMember(Value = "yearly")]
        Yearly,
    }

    /// <summary>
    /// The shop order line status.
    /// </summary>
    public enum ShopOrderLineStatus
    {
        /// <summary>
        /// Canceled.
        /// </summary>
        [EnumMember(Value = "canceled")]
        Canceled = 1,
        /// <summary>
        /// Completed.
        /// </summary>
        [EnumMember(Value = "completed")]
        Completed,
        /// <summary>
        /// Fulfillment Pending.
        /// </summary>
        [EnumMember(Value = "fulfillment_pending")]
        FulfillmentPending,
        /// <summary>
        /// In Cart.
        /// </summary>
        [EnumMember(Value = "in_cart")]
        InCart,
        /// <summary>
        /// Workflow Pending.
        /// </summary>
        [EnumMember(Value = "workflow_pending")]
        WorkflowPending,
    }

    /// <summary>
    /// The short url data type.
    /// </summary>
    public enum ShortUrlDataType
    {
        /// <summary>
        /// Change Calendar.
        /// </summary>
        [EnumMember(Value = "change_calendar_personal_view")]
        ChangeCalendarPersonalView = 1,
        /// <summary>
        /// Configuration Item in Self Service.
        /// </summary>
        [EnumMember(Value = "ci")]
        Ci,
        /// <summary>
        /// Dashboard.
        /// </summary>
        [EnumMember(Value = "dashboard")]
        Dashboard,
        /// <summary>
        /// Knowledge Article in Self Service.
        /// </summary>
        [EnumMember(Value = "knowledge_article")]
        KnowledgeArticle,
        /// <summary>
        /// Email.
        /// </summary>
        [EnumMember(Value = "mailto")]
        Mailto,
        /// <summary>
        /// Map.
        /// </summary>
        [EnumMember(Value = "map")]
        Map,
        /// <summary>
        /// Media File in Media Library.
        /// </summary>
        [EnumMember(Value = "media_file")]
        MediaFile,
        /// <summary>
        /// Request Template in Self Service.
        /// </summary>
        [EnumMember(Value = "request_template")]
        RequestTemplate,
        /// <summary>
        /// Service Survey in Self Service.
        /// </summary>
        [EnumMember(Value = "service_survey")]
        ServiceSurvey,
        /// <summary>
        /// Skype.
        /// </summary>
        [EnumMember(Value = "skype")]
        Skype,
        /// <summary>
        /// SMS Message.
        /// </summary>
        [EnumMember(Value = "sms")]
        Sms,
        /// <summary>
        /// Telephone Number.
        /// </summary>
        [EnumMember(Value = "tel")]
        Tel,
        /// <summary>
        /// Plain Text.
        /// </summary>
        [EnumMember(Value = "text")]
        Text,
        /// <summary>
        /// Tweet.
        /// </summary>
        [EnumMember(Value = "tweet")]
        Tweet,
        /// <summary>
        /// Twitter.
        /// </summary>
        [EnumMember(Value = "twitter")]
        Twitter,
        /// <summary>
        /// URI.
        /// </summary>
        [EnumMember(Value = "uri")]
        Uri,
        /// <summary>
        /// Website Address.
        /// </summary>
        [EnumMember(Value = "url")]
        Url,
    }

    /// <summary>
    /// The sla coverage.
    /// </summary>
    public enum SlaCoverage
    {
        /// <summary>
        /// People Using CIs of the Service Instance.
        /// </summary>
        [EnumMember(Value = "cis_of_service_instance")]
        CisOfServiceInstance = 1,
        /// <summary>
        /// People of the Following Coverage Group(s).
        /// </summary>
        [EnumMember(Value = "coverage_groups")]
        CoverageGroups,
        /// <summary>
        /// All People of Customer Account.
        /// </summary>
        [EnumMember(Value = "customer_account")]
        CustomerAccount,
        /// <summary>
        /// People of the Following Organization(s) and Their Descendants.
        /// </summary>
        [EnumMember(Value = "organizations_and_descendants")]
        OrganizationsAndDescendants,
        /// <summary>
        /// People of an Organization and Site from the Following.
        /// </summary>
        [EnumMember(Value = "organizations_and_sites")]
        OrganizationsAndSites,
        /// <summary>
        /// People of the Following Organization(s).
        /// </summary>
        [EnumMember(Value = "organizations")]
        Organizations,
        /// <summary>
        /// People Selected Below.
        /// </summary>
        [EnumMember(Value = "people")]
        People,
        /// <summary>
        /// Members of Support Teams of the Following Service Instances.
        /// </summary>
        [EnumMember(Value = "service_instances")]
        ServiceInstances,
        /// <summary>
        /// People of the Following Site(s).
        /// </summary>
        [EnumMember(Value = "sites")]
        Sites,
        /// <summary>
        /// Members of the Following Skill Pool(s).
        /// </summary>
        [EnumMember(Value = "skill_pools")]
        SkillPools,
    }

    /// <summary>
    /// The sprint status.
    /// </summary>
    public enum SprintStatus
    {
        /// <summary>
        /// Active.
        /// </summary>
        [EnumMember(Value = "active")]
        Active = 1,
        /// <summary>
        /// Completed.
        /// </summary>
        [EnumMember(Value = "completed")]
        Completed,
        /// <summary>
        /// Registered.
        /// </summary>
        [EnumMember(Value = "registered")]
        Registered,
    }

    /// <summary>
    /// The survey question type.
    /// </summary>
    public enum SurveyQuestionType
    {
        /// <summary>
        /// Star rating.
        /// </summary>
        [EnumMember(Value = "star_rating")]
        StarRating = 1,
        /// <summary>
        /// Free text.
        /// </summary>
        [EnumMember(Value = "text")]
        Text,
    }

    /// <summary>
    /// The task category.
    /// </summary>
    public enum TaskCategory
    {
        /// <summary>
        /// Approval.
        /// </summary>
        [EnumMember(Value = "approval")]
        Approval = 1,
        /// <summary>
        /// Automation.
        /// </summary>
        [EnumMember(Value = "automation")]
        Automation,
        /// <summary>
        /// Fulfillment Placeholder.
        /// </summary>
        [EnumMember(Value = "fulfillment_placeholder")]
        FulfillmentPlaceholder,
        /// <summary>
        /// Implementation.
        /// </summary>
        [EnumMember(Value = "implementation")]
        Implementation,
        /// <summary>
        /// Risk &amp; Impact.
        /// </summary>
        [EnumMember(Value = "risk_and_impact")]
        RiskAndImpact,
    }

    /// <summary>
    /// The task impact.
    /// </summary>
    public enum TaskImpact
    {
        /// <summary>
        /// High - Service Degraded for Several Users.
        /// </summary>
        [EnumMember(Value = "high")]
        High = 1,
        /// <summary>
        /// Low - Service Degraded for One User.
        /// </summary>
        [EnumMember(Value = "low")]
        Low,
        /// <summary>
        /// Medium - Service Down for One User.
        /// </summary>
        [EnumMember(Value = "medium")]
        Medium,
        /// <summary>
        /// None - Service Not Degraded.
        /// </summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>
        /// Top - Service Down for Several Users.
        /// </summary>
        [EnumMember(Value = "top")]
        Top,
    }

    /// <summary>
    /// The task note behavior.
    /// </summary>
    public enum TaskNoteBehavior
    {
        /// <summary>
        /// Hidden.
        /// </summary>
        [EnumMember(Value = "hidden")]
        Hidden = 1,
        /// <summary>
        /// Optional on Approval.
        /// </summary>
        [EnumMember(Value = "optional_on_approval")]
        OptionalOnApproval,
        /// <summary>
        /// Optional on Completion.
        /// </summary>
        [EnumMember(Value = "optional_on_completion")]
        OptionalOnCompletion,
        /// <summary>
        /// Required on Approval.
        /// </summary>
        [EnumMember(Value = "required_on_approval")]
        RequiredOnApproval,
        /// <summary>
        /// Required on Completion.
        /// </summary>
        [EnumMember(Value = "required_on_completion")]
        RequiredOnCompletion,
    }

    /// <summary>
    /// The task status.
    /// </summary>
    public enum TaskStatus
    {
        /// <summary>
        /// Accepted.
        /// </summary>
        [EnumMember(Value = "accepted")]
        Accepted = 1,
        /// <summary>
        /// Approved.
        /// </summary>
        [EnumMember(Value = "approved")]
        Approved,
        /// <summary>
        /// Assigned.
        /// </summary>
        [EnumMember(Value = "assigned")]
        Assigned,
        /// <summary>
        /// Canceled.
        /// </summary>
        [EnumMember(Value = "canceled")]
        Canceled,
        /// <summary>
        /// Completed.
        /// </summary>
        [EnumMember(Value = "completed")]
        Completed,
        /// <summary>
        /// Declined.
        /// </summary>
        [EnumMember(Value = "declined")]
        Declined,
        /// <summary>
        /// Failed.
        /// </summary>
        [EnumMember(Value = "failed")]
        Failed,
        /// <summary>
        /// In Progress.
        /// </summary>
        [EnumMember(Value = "in_progress")]
        InProgress,
        /// <summary>
        /// Registered.
        /// </summary>
        [EnumMember(Value = "registered")]
        Registered,
        /// <summary>
        /// Rejected.
        /// </summary>
        [EnumMember(Value = "rejected")]
        Rejected,
        /// <summary>
        /// Request Pending.
        /// </summary>
        [EnumMember(Value = "request_pending")]
        RequestPending,
        /// <summary>
        /// Waiting for Customer.
        /// </summary>
        [EnumMember(Value = "waiting_for_customer")]
        WaitingForCustomer,
        /// <summary>
        /// Waiting for...
        /// </summary>
        [EnumMember(Value = "waiting_for")]
        WaitingFor,
    }

    /// <summary>
    /// The time allocation customer category.
    /// </summary>
    public enum TimeAllocationCustomerCategory
    {
        /// <summary>
        /// Any.
        /// </summary>
        [EnumMember(Value = "any")]
        Any = 1,
        /// <summary>
        /// None.
        /// </summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>
        /// One of the Following.
        /// </summary>
        [EnumMember(Value = "selected")]
        Selected,
    }

    /// <summary>
    /// The time allocation description category.
    /// </summary>
    public enum TimeAllocationDescriptionCategory
    {
        /// <summary>
        /// Hidden.
        /// </summary>
        [EnumMember(Value = "hidden")]
        Hidden = 1,
        /// <summary>
        /// Optional.
        /// </summary>
        [EnumMember(Value = "optional")]
        Optional,
        /// <summary>
        /// Required.
        /// </summary>
        [EnumMember(Value = "required")]
        Required,
    }

    /// <summary>
    /// The time allocation service category.
    /// </summary>
    public enum TimeAllocationServiceCategory
    {
        /// <summary>
        /// Any.
        /// </summary>
        [EnumMember(Value = "any")]
        Any = 1,
        /// <summary>
        /// None.
        /// </summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>
        /// One of the Following.
        /// </summary>
        [EnumMember(Value = "selected")]
        Selected,
    }

    /// <summary>
    /// The timesheet setting percentage increment.
    /// </summary>
    public enum TimesheetSettingPercentageIncrement
    {
        /// <summary>
        /// OneHundred.
        /// </summary>
        [EnumMember(Value = "100")]
        OneHundred = 1,
        /// <summary>
        /// TwelveAndFifty.
        /// </summary>
        [EnumMember(Value = "12.5")]
        TwelveAndFifty,
        /// <summary>
        /// TwentyFive.
        /// </summary>
        [EnumMember(Value = "25")]
        TwentyFive,
        /// <summary>
        /// Fifty.
        /// </summary>
        [EnumMember(Value = "50")]
        Fifty,
    }

    /// <summary>
    /// The timesheet setting time increment.
    /// </summary>
    public enum TimesheetSettingTimeIncrement
    {
        /// <summary>
        /// Ten.
        /// </summary>
        [EnumMember(Value = "10")]
        Ten = 1,
        /// <summary>
        /// OneHundredAndTwenty.
        /// </summary>
        [EnumMember(Value = "120")]
        OneHundredAndTwenty,
        /// <summary>
        /// Fifteen.
        /// </summary>
        [EnumMember(Value = "15")]
        Fifteen,
        /// <summary>
        /// TwoHundredAndForty.
        /// </summary>
        [EnumMember(Value = "240")]
        TwoHundredAndForty,
        /// <summary>
        /// Thirty.
        /// </summary>
        [EnumMember(Value = "30")]
        Thirty,
        /// <summary>
        /// Five.
        /// </summary>
        [EnumMember(Value = "5")]
        Five,
        /// <summary>
        /// Sixty.
        /// </summary>
        [EnumMember(Value = "60")]
        Sixty,
    }

    /// <summary>
    /// The timesheet setting unit.
    /// </summary>
    public enum TimesheetSettingUnit
    {
        /// <summary>
        /// Hours &amp; Minutes.
        /// </summary>
        [EnumMember(Value = "hours_and_minutes")]
        HoursAndMinutes = 1,
        /// <summary>
        /// Percentage of Workday.
        /// </summary>
        [EnumMember(Value = "percentage_of_workday")]
        PercentageOfWorkday,
    }

    /// <summary>
    /// The ui extension category.
    /// </summary>
    public enum UiExtensionCategory
    {
        /// <summary>
        /// App Offering.
        /// </summary>
        [EnumMember(Value = "app_offering")]
        AppOffering = 1,
        /// <summary>
        /// Contract.
        /// </summary>
        [EnumMember(Value = "contract")]
        Contract,
        /// <summary>
        /// Custom Collection.
        /// </summary>
        [EnumMember(Value = "custom_collection")]
        CustomCollection,
        /// <summary>
        /// Knowledge Article Template.
        /// </summary>
        [EnumMember(Value = "knowledge_article_template")]
        KnowledgeArticleTemplate,
        /// <summary>
        /// Organization.
        /// </summary>
        [EnumMember(Value = "organization")]
        Organization,
        /// <summary>
        /// Person.
        /// </summary>
        [EnumMember(Value = "person")]
        Person,
        /// <summary>
        /// Problem.
        /// </summary>
        [EnumMember(Value = "problem")]
        Problem,
        /// <summary>
        /// Product Category.
        /// </summary>
        [EnumMember(Value = "product_category")]
        ProductCategory,
        /// <summary>
        /// Product.
        /// </summary>
        [EnumMember(Value = "product")]
        Product,
        /// <summary>
        /// Project Task Template.
        /// </summary>
        [EnumMember(Value = "project_task_template")]
        ProjectTaskTemplate,
        /// <summary>
        /// Project.
        /// </summary>
        [EnumMember(Value = "project")]
        Project,
        /// <summary>
        /// Release.
        /// </summary>
        [EnumMember(Value = "release")]
        Release,
        /// <summary>
        /// Request Template.
        /// </summary>
        [EnumMember(Value = "request_template")]
        RequestTemplate,
        /// <summary>
        /// Risk.
        /// </summary>
        [EnumMember(Value = "risk")]
        Risk,
        /// <summary>
        /// SCIM User.
        /// </summary>
        [EnumMember(Value = "scim_user")]
        ScimUser,
        /// <summary>
        /// Service Instance.
        /// </summary>
        [EnumMember(Value = "service_instance")]
        ServiceInstance,
        /// <summary>
        /// Service.
        /// </summary>
        [EnumMember(Value = "service")]
        Service,
        /// <summary>
        /// Shop Article.
        /// </summary>
        [EnumMember(Value = "shop_article")]
        ShopArticle,
        /// <summary>
        /// Site.
        /// </summary>
        [EnumMember(Value = "site")]
        Site,
        /// <summary>
        /// Task Template.
        /// </summary>
        [EnumMember(Value = "task_template")]
        TaskTemplate,
        /// <summary>
        /// Team.
        /// </summary>
        [EnumMember(Value = "team")]
        Team,
        /// <summary>
        /// Workflow Template.
        /// </summary>
        [EnumMember(Value = "workflow_template")]
        WorkflowTemplate,
    }

    /// <summary>
    /// The ui extension version status.
    /// </summary>
    public enum UiExtensionVersionStatus
    {
        /// <summary>
        /// Active.
        /// </summary>
        [EnumMember(Value = "active")]
        Active = 1,
        /// <summary>
        /// Archived.
        /// </summary>
        [EnumMember(Value = "archived")]
        Archived,
        /// <summary>
        /// Being Prepared.
        /// </summary>
        [EnumMember(Value = "being_prepared")]
        BeingPrepared,
    }

    /// <summary>
    /// The webhook event.
    /// </summary>
    public enum WebhookEvent
    {
        /// <summary>
        /// App instance.create.
        /// </summary>
        [EnumMember(Value = "app_instance.create")]
        AppInstanceCreate = 1,
        /// <summary>
        /// App instance.delete.
        /// </summary>
        [EnumMember(Value = "app_instance.delete")]
        AppInstanceDelete,
        /// <summary>
        /// App instance.secrets-update.
        /// </summary>
        [EnumMember(Value = "app_instance.secrets-update")]
        AppInstanceSecretsUpdate,
        /// <summary>
        /// App instance.update.
        /// </summary>
        [EnumMember(Value = "app_instance.update")]
        AppInstanceUpdate,
        /// <summary>
        /// Automation rule.
        /// </summary>
        [EnumMember(Value = "automation_rule")]
        AutomationRule,
        /// <summary>
        /// Broadcast.create.
        /// </summary>
        [EnumMember(Value = "broadcast.create")]
        BroadcastCreate,
        /// <summary>
        /// Broadcast.update.
        /// </summary>
        [EnumMember(Value = "broadcast.update")]
        BroadcastUpdate,
        /// <summary>
        /// Ci.create.
        /// </summary>
        [EnumMember(Value = "ci.create")]
        CiCreate,
        /// <summary>
        /// Ci.update.
        /// </summary>
        [EnumMember(Value = "ci.update")]
        CiUpdate,
        /// <summary>
        /// Contract.create.
        /// </summary>
        [EnumMember(Value = "contract.create")]
        ContractCreate,
        /// <summary>
        /// Contract.update.
        /// </summary>
        [EnumMember(Value = "contract.update")]
        ContractUpdate,
        /// <summary>
        /// Flsa.create.
        /// </summary>
        [EnumMember(Value = "flsa.create")]
        FlsaCreate,
        /// <summary>
        /// Flsa.update.
        /// </summary>
        [EnumMember(Value = "flsa.update")]
        FlsaUpdate,
        /// <summary>
        /// Knowledge article.create.
        /// </summary>
        [EnumMember(Value = "knowledge_article.create")]
        KnowledgeArticleCreate,
        /// <summary>
        /// Knowledge article.update.
        /// </summary>
        [EnumMember(Value = "knowledge_article.update")]
        KnowledgeArticleUpdate,
        /// <summary>
        /// Organization.create.
        /// </summary>
        [EnumMember(Value = "organization.create")]
        OrganizationCreate,
        /// <summary>
        /// Organization.update.
        /// </summary>
        [EnumMember(Value = "organization.update")]
        OrganizationUpdate,
        /// <summary>
        /// Out of office period.create.
        /// </summary>
        [EnumMember(Value = "out_of_office_period.create")]
        OutOfOfficePeriodCreate,
        /// <summary>
        /// Out of office period.delete.
        /// </summary>
        [EnumMember(Value = "out_of_office_period.delete")]
        OutOfOfficePeriodDelete,
        /// <summary>
        /// Out of office period.update.
        /// </summary>
        [EnumMember(Value = "out_of_office_period.update")]
        OutOfOfficePeriodUpdate,
        /// <summary>
        /// Person.create.
        /// </summary>
        [EnumMember(Value = "person.create")]
        PersonCreate,
        /// <summary>
        /// Person.update.
        /// </summary>
        [EnumMember(Value = "person.update")]
        PersonUpdate,
        /// <summary>
        /// Problem.create.
        /// </summary>
        [EnumMember(Value = "problem.create")]
        ProblemCreate,
        /// <summary>
        /// Problem.manager-changed.
        /// </summary>
        [EnumMember(Value = "problem.manager-changed")]
        ProblemManagerChanged,
        /// <summary>
        /// Problem.member-changed.
        /// </summary>
        [EnumMember(Value = "problem.member-changed")]
        ProblemMemberChanged,
        /// <summary>
        /// Problem.note-added.
        /// </summary>
        [EnumMember(Value = "problem.note-added")]
        ProblemNoteAdded,
        /// <summary>
        /// Problem.status-changed.
        /// </summary>
        [EnumMember(Value = "problem.status-changed")]
        ProblemStatusChanged,
        /// <summary>
        /// Problem.team-changed.
        /// </summary>
        [EnumMember(Value = "problem.team-changed")]
        ProblemTeamChanged,
        /// <summary>
        /// Problem.update.
        /// </summary>
        [EnumMember(Value = "problem.update")]
        ProblemUpdate,
        /// <summary>
        /// Product.create.
        /// </summary>
        [EnumMember(Value = "product.create")]
        ProductCreate,
        /// <summary>
        /// Product.update.
        /// </summary>
        [EnumMember(Value = "product.update")]
        ProductUpdate,
        /// <summary>
        /// Project.create.
        /// </summary>
        [EnumMember(Value = "project.create")]
        ProjectCreate,
        /// <summary>
        /// Project.manager-changed.
        /// </summary>
        [EnumMember(Value = "project.manager-changed")]
        ProjectManagerChanged,
        /// <summary>
        /// Project.note-added.
        /// </summary>
        [EnumMember(Value = "project.note-added")]
        ProjectNoteAdded,
        /// <summary>
        /// Project.status-changed.
        /// </summary>
        [EnumMember(Value = "project.status-changed")]
        ProjectStatusChanged,
        /// <summary>
        /// Project.update.
        /// </summary>
        [EnumMember(Value = "project.update")]
        ProjectUpdate,
        /// <summary>
        /// Project task.create.
        /// </summary>
        [EnumMember(Value = "project_task.create")]
        ProjectTaskCreate,
        /// <summary>
        /// Project task.delete.
        /// </summary>
        [EnumMember(Value = "project_task.delete")]
        ProjectTaskDelete,
        /// <summary>
        /// Project task.note-added.
        /// </summary>
        [EnumMember(Value = "project_task.note-added")]
        ProjectTaskNoteAdded,
        /// <summary>
        /// Project task.status-changed.
        /// </summary>
        [EnumMember(Value = "project_task.status-changed")]
        ProjectTaskStatusChanged,
        /// <summary>
        /// Project task.update.
        /// </summary>
        [EnumMember(Value = "project_task.update")]
        ProjectTaskUpdate,
        /// <summary>
        /// Release.create.
        /// </summary>
        [EnumMember(Value = "release.create")]
        ReleaseCreate,
        /// <summary>
        /// Release.manager-changed.
        /// </summary>
        [EnumMember(Value = "release.manager-changed")]
        ReleaseManagerChanged,
        /// <summary>
        /// Release.note-added.
        /// </summary>
        [EnumMember(Value = "release.note-added")]
        ReleaseNoteAdded,
        /// <summary>
        /// Release.update.
        /// </summary>
        [EnumMember(Value = "release.update")]
        ReleaseUpdate,
        /// <summary>
        /// Request.agile-board-column-changed.
        /// </summary>
        [EnumMember(Value = "request.agile-board-column-changed")]
        RequestAgileBoardColumnChanged,
        /// <summary>
        /// Request.create.
        /// </summary>
        [EnumMember(Value = "request.create")]
        RequestCreate,
        /// <summary>
        /// Request.major-incident-status-changed.
        /// </summary>
        [EnumMember(Value = "request.major-incident-status-changed")]
        RequestMajorIncidentStatusChanged,
        /// <summary>
        /// Request.member-changed.
        /// </summary>
        [EnumMember(Value = "request.member-changed")]
        RequestMemberChanged,
        /// <summary>
        /// Request.note-added.
        /// </summary>
        [EnumMember(Value = "request.note-added")]
        RequestNoteAdded,
        /// <summary>
        /// Request.status-changed.
        /// </summary>
        [EnumMember(Value = "request.status-changed")]
        RequestStatusChanged,
        /// <summary>
        /// Request.team-changed.
        /// </summary>
        [EnumMember(Value = "request.team-changed")]
        RequestTeamChanged,
        /// <summary>
        /// Request.update.
        /// </summary>
        [EnumMember(Value = "request.update")]
        RequestUpdate,
        /// <summary>
        /// Risk.create.
        /// </summary>
        [EnumMember(Value = "risk.create")]
        RiskCreate,
        /// <summary>
        /// Risk.manager-changed.
        /// </summary>
        [EnumMember(Value = "risk.manager-changed")]
        RiskManagerChanged,
        /// <summary>
        /// Risk.note-added.
        /// </summary>
        [EnumMember(Value = "risk.note-added")]
        RiskNoteAdded,
        /// <summary>
        /// Risk.status-changed.
        /// </summary>
        [EnumMember(Value = "risk.status-changed")]
        RiskStatusChanged,
        /// <summary>
        /// Risk.update.
        /// </summary>
        [EnumMember(Value = "risk.update")]
        RiskUpdate,
        /// <summary>
        /// Service.create.
        /// </summary>
        [EnumMember(Value = "service.create")]
        ServiceCreate,
        /// <summary>
        /// Service.update.
        /// </summary>
        [EnumMember(Value = "service.update")]
        ServiceUpdate,
        /// <summary>
        /// Service instance.create.
        /// </summary>
        [EnumMember(Value = "service_instance.create")]
        ServiceInstanceCreate,
        /// <summary>
        /// Service instance.update.
        /// </summary>
        [EnumMember(Value = "service_instance.update")]
        ServiceInstanceUpdate,
        /// <summary>
        /// Service offering.create.
        /// </summary>
        [EnumMember(Value = "service_offering.create")]
        ServiceOfferingCreate,
        /// <summary>
        /// Service offering.update.
        /// </summary>
        [EnumMember(Value = "service_offering.update")]
        ServiceOfferingUpdate,
        /// <summary>
        /// Sla.create.
        /// </summary>
        [EnumMember(Value = "sla.create")]
        SlaCreate,
        /// <summary>
        /// Sla.update.
        /// </summary>
        [EnumMember(Value = "sla.update")]
        SlaUpdate,
        /// <summary>
        /// Task.create.
        /// </summary>
        [EnumMember(Value = "task.create")]
        TaskCreate,
        /// <summary>
        /// Task.member-changed.
        /// </summary>
        [EnumMember(Value = "task.member-changed")]
        TaskMemberChanged,
        /// <summary>
        /// Task.note-added.
        /// </summary>
        [EnumMember(Value = "task.note-added")]
        TaskNoteAdded,
        /// <summary>
        /// Task.status-changed.
        /// </summary>
        [EnumMember(Value = "task.status-changed")]
        TaskStatusChanged,
        /// <summary>
        /// Task.team-changed.
        /// </summary>
        [EnumMember(Value = "task.team-changed")]
        TaskTeamChanged,
        /// <summary>
        /// Task.update.
        /// </summary>
        [EnumMember(Value = "task.update")]
        TaskUpdate,
        /// <summary>
        /// Team.create.
        /// </summary>
        [EnumMember(Value = "team.create")]
        TeamCreate,
        /// <summary>
        /// Team.update.
        /// </summary>
        [EnumMember(Value = "team.update")]
        TeamUpdate,
        /// <summary>
        /// Time entry.create.
        /// </summary>
        [EnumMember(Value = "time_entry.create")]
        TimeEntryCreate,
        /// <summary>
        /// Time entry.delete.
        /// </summary>
        [EnumMember(Value = "time_entry.delete")]
        TimeEntryDelete,
        /// <summary>
        /// Time entry.update.
        /// </summary>
        [EnumMember(Value = "time_entry.update")]
        TimeEntryUpdate,
        /// <summary>
        /// Webhook.verify.
        /// </summary>
        [EnumMember(Value = "webhook.verify")]
        WebhookVerify,
        /// <summary>
        /// Workflow.create.
        /// </summary>
        [EnumMember(Value = "workflow.create")]
        WorkflowCreate,
        /// <summary>
        /// Workflow.manager-changed.
        /// </summary>
        [EnumMember(Value = "workflow.manager-changed")]
        WorkflowManagerChanged,
        /// <summary>
        /// Workflow.note-added.
        /// </summary>
        [EnumMember(Value = "workflow.note-added")]
        WorkflowNoteAdded,
        /// <summary>
        /// Workflow.status-changed.
        /// </summary>
        [EnumMember(Value = "workflow.status-changed")]
        WorkflowStatusChanged,
        /// <summary>
        /// Workflow.update.
        /// </summary>
        [EnumMember(Value = "workflow.update")]
        WorkflowUpdate,
    }

    /// <summary>
    /// The webhook policy jwt alg.
    /// </summary>
    public enum WebhookPolicyJwtAlg
    {
        /// <summary>
        /// ECDSA using P-256 and SHA-256.
        /// </summary>
        [EnumMember(Value = "es256")]
        Es256 = 1,
        /// <summary>
        /// ECDSA using P-384 and SHA-384.
        /// </summary>
        [EnumMember(Value = "es384")]
        Es384,
        /// <summary>
        /// ECDSA using P-521 and SHA-512.
        /// </summary>
        [EnumMember(Value = "es512")]
        Es512,
        /// <summary>
        /// HMAC using SHA-256.
        /// </summary>
        [EnumMember(Value = "hs256")]
        Hs256,
        /// <summary>
        /// HMAC using SHA-384.
        /// </summary>
        [EnumMember(Value = "hs384")]
        Hs384,
        /// <summary>
        /// HMAC using SHA-512.
        /// </summary>
        [EnumMember(Value = "hs512")]
        Hs512,
        /// <summary>
        /// No digital signature or MAC performed.
        /// </summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>
        /// RSA using SHA-256.
        /// </summary>
        [EnumMember(Value = "rs256")]
        Rs256,
        /// <summary>
        /// RSA using SHA-384.
        /// </summary>
        [EnumMember(Value = "rs384")]
        Rs384,
        /// <summary>
        /// RSA using SHA-512.
        /// </summary>
        [EnumMember(Value = "rs512")]
        Rs512,
    }

    /// <summary>
    /// The weekday.
    /// </summary>
    public enum Weekday
    {
        /// <summary>
        /// Fridays.
        /// </summary>
        [EnumMember(Value = "fri")]
        Fri = 1,
        /// <summary>
        /// Mondays.
        /// </summary>
        [EnumMember(Value = "mon")]
        Mon,
        /// <summary>
        /// Saturdays.
        /// </summary>
        [EnumMember(Value = "sat")]
        Sat,
        /// <summary>
        /// Sundays.
        /// </summary>
        [EnumMember(Value = "sun")]
        Sun,
        /// <summary>
        /// Thursdays.
        /// </summary>
        [EnumMember(Value = "thu")]
        Thu,
        /// <summary>
        /// Tuesdays.
        /// </summary>
        [EnumMember(Value = "tue")]
        Tue,
        /// <summary>
        /// Wednesdays.
        /// </summary>
        [EnumMember(Value = "wed")]
        Wed,
    }

    /// <summary>
    /// The workflow category.
    /// </summary>
    public enum WorkflowCategory
    {
        /// <summary>
        /// Emergency - Required for Incident Resolution.
        /// </summary>
        [EnumMember(Value = "emergency")]
        Emergency = 1,
        /// <summary>
        /// Non-Standard - Approved Workflow Template Not Available.
        /// </summary>
        [EnumMember(Value = "non_standard")]
        NonStandard,
        /// <summary>
        /// Order - Organization Order Workflow.
        /// </summary>
        [EnumMember(Value = "order")]
        Order,
        /// <summary>
        /// Standard - Approved Workflow Template Was Used.
        /// </summary>
        [EnumMember(Value = "standard")]
        Standard,
    }

    /// <summary>
    /// The workflow completion reason.
    /// </summary>
    public enum WorkflowCompletionReason
    {
        /// <summary>
        /// Complete - All Requirements Met.
        /// </summary>
        [EnumMember(Value = "complete")]
        Complete = 1,
        /// <summary>
        /// Disruptive - Caused Service Disruption.
        /// </summary>
        [EnumMember(Value = "disruptive")]
        Disruptive,
        /// <summary>
        /// Failed - No Requirements Met.
        /// </summary>
        [EnumMember(Value = "failed")]
        Failed,
        /// <summary>
        /// Partial - Not All Requirements Met.
        /// </summary>
        [EnumMember(Value = "partial")]
        Partial,
        /// <summary>
        /// Rejected - Rejected by Approver.
        /// </summary>
        [EnumMember(Value = "rejected")]
        Rejected,
        /// <summary>
        /// Rolled Back - Original Environment Restored.
        /// </summary>
        [EnumMember(Value = "rolled_back")]
        RolledBack,
        /// <summary>
        /// Withdrawn - Withdrawn by Requester.
        /// </summary>
        [EnumMember(Value = "withdrawn")]
        Withdrawn,
    }

    /// <summary>
    /// The workflow justification.
    /// </summary>
    public enum WorkflowJustification
    {
        /// <summary>
        /// Compliance.
        /// </summary>
        [EnumMember(Value = "compliance")]
        Compliance = 1,
        /// <summary>
        /// Correction.
        /// </summary>
        [EnumMember(Value = "correction")]
        Correction,
        /// <summary>
        /// Expansion.
        /// </summary>
        [EnumMember(Value = "expansion")]
        Expansion,
        /// <summary>
        /// Improvement.
        /// </summary>
        [EnumMember(Value = "improvement")]
        Improvement,
        /// <summary>
        /// Maintenance.
        /// </summary>
        [EnumMember(Value = "maintenance")]
        Maintenance,
        /// <summary>
        /// Move.
        /// </summary>
        [EnumMember(Value = "move")]
        Move,
        /// <summary>
        /// Purchase.
        /// </summary>
        [EnumMember(Value = "purchase")]
        Purchase,
        /// <summary>
        /// Removal.
        /// </summary>
        [EnumMember(Value = "removal")]
        Removal,
        /// <summary>
        /// Replacement.
        /// </summary>
        [EnumMember(Value = "replacement")]
        Replacement,
    }

    /// <summary>
    /// The workflow phase status.
    /// </summary>
    public enum WorkflowPhaseStatus
    {
        /// <summary>
        /// Completed.
        /// </summary>
        [EnumMember(Value = "completed")]
        Completed = 1,
        /// <summary>
        /// In Progress.
        /// </summary>
        [EnumMember(Value = "in_progress")]
        InProgress,
        /// <summary>
        /// Registered.
        /// </summary>
        [EnumMember(Value = "registered")]
        Registered,
    }

    /// <summary>
    /// The workflow status.
    /// </summary>
    public enum WorkflowStatus
    {
        /// <summary>
        /// DEPRECATED: Approval - use In Progress instead.
        /// </summary>
        [Obsolete("Approval - use In Progress instead.")]
        [EnumMember(Value = "approval")]
        Approval = 1,
        /// <summary>
        /// Being Created.
        /// </summary>
        [EnumMember(Value = "being_created")]
        BeingCreated,
        /// <summary>
        /// Completed.
        /// </summary>
        [EnumMember(Value = "completed")]
        Completed,
        /// <summary>
        /// DEPRECATED: Implementation - use In Progress instead.
        /// </summary>
        [Obsolete("Implementation - use In Progress instead.")]
        [EnumMember(Value = "implementation")]
        Implementation,
        /// <summary>
        /// In Progress.
        /// </summary>
        [EnumMember(Value = "in_progress")]
        InProgress,
        /// <summary>
        /// Progress Halted.
        /// </summary>
        [EnumMember(Value = "progress_halted")]
        ProgressHalted,
        /// <summary>
        /// Registered.
        /// </summary>
        [EnumMember(Value = "registered")]
        Registered,
        /// <summary>
        /// DEPRECATED: Risk &amp; Impact - use In Progress instead.
        /// </summary>
        [Obsolete("Risk &amp; Impact - use In Progress instead.")]
        [EnumMember(Value = "risk_and_impact")]
        RiskAndImpact,
    }
}