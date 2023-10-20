namespace Sdk4me.GraphQL
{
    /// <summary>
    /// All GraphQL query operations.
    /// </summary>
    public static class Sdk4meClientQueryExtension
    {
        /// <summary>
        /// The current account.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<Account>> Get(this Sdk4meClient client, AccountQuery query)
        {
            return await client.Get<Account>(query);
        }

        /// <summary>
        /// Root connection for retrieving AffectedSla records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<AffectedSla>> Get(this Sdk4meClient client, AffectedSlaQuery query)
        {
            return await client.Get<AffectedSla>(query);
        }

        /// <summary>
        /// Root connection for retrieving AgileBoard records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<AgileBoard>> Get(this Sdk4meClient client, AgileBoardQuery query)
        {
            return await client.Get<AgileBoard>(query);
        }

        /// <summary>
        /// Root connection for retrieving AppInstance records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<AppInstance>> Get(this Sdk4meClient client, AppInstanceQuery query)
        {
            return await client.Get<AppInstance>(query);
        }

        /// <summary>
        /// Root connection for retrieving AppOffering records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<AppOffering>> Get(this Sdk4meClient client, AppOfferingQuery query)
        {
            return await client.Get<AppOffering>(query);
        }

        /// <summary>
        /// Root connection for retrieving Archive records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<Archive>> Get(this Sdk4meClient client, ArchiveQuery query)
        {
            return await client.Get<Archive>(query);
        }

        /// <summary>
        /// Details on how to upload files to the 4me attachment storage facility.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<AttachmentStorage>> Get(this Sdk4meClient client, AttachmentStorageQuery query)
        {
            return await client.Get<AttachmentStorage>(query);
        }

        /// <summary>
        /// Root connection for retrieving AutomationRule records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<AutomationRule>> Get(this Sdk4meClient client, AutomationRuleQuery query)
        {
            return await client.Get<AutomationRule>(query);
        }

        /// <summary>
        /// Root connection for retrieving Broadcast records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<Broadcast>> Get(this Sdk4meClient client, BroadcastQuery query)
        {
            return await client.Get<Broadcast>(query);
        }

        /// <summary>
        /// Root connection for retrieving Calendar records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<Calendar>> Get(this Sdk4meClient client, CalendarQuery query)
        {
            return await client.Get<Calendar>(query);
        }

        /// <summary>
        /// Root connection for retrieving ConfigurationItem records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<ConfigurationItem>> Get(this Sdk4meClient client, ConfigurationItemQuery query)
        {
            return await client.Get<ConfigurationItem>(query);
        }

        /// <summary>
        /// Root connection for retrieving Contract records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<Contract>> Get(this Sdk4meClient client, ContractQuery query)
        {
            return await client.Get<Contract>(query);
        }

        /// <summary>
        /// Root connection for retrieving CustomCollectionElement records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<CustomCollectionElement>> Get(this Sdk4meClient client, CustomCollectionElementQuery query)
        {
            return await client.Get<CustomCollectionElement>(query);
        }

        /// <summary>
        /// Root connection for retrieving CustomCollection records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<CustomCollection>> Get(this Sdk4meClient client, CustomCollectionQuery query)
        {
            return await client.Get<CustomCollection>(query);
        }

        /// <summary>
        /// Root connection for retrieving EffortClass records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<EffortClass>> Get(this Sdk4meClient client, EffortClassQuery query)
        {
            return await client.Get<EffortClass>(query);
        }

        /// <summary>
        /// Root connection for retrieving FirstLineSupportAgreement records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<FirstLineSupportAgreement>> Get(this Sdk4meClient client, FirstLineSupportAgreementQuery query)
        {
            return await client.Get<FirstLineSupportAgreement>(query);
        }

        /// <summary>
        /// Root connection for retrieving Holiday records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<Holiday>> Get(this Sdk4meClient client, HolidayQuery query)
        {
            return await client.Get<Holiday>(query);
        }

        /// <summary>
        /// Root connection for retrieving Invoice records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<Invoice>> Get(this Sdk4meClient client, InvoiceQuery query)
        {
            return await client.Get<Invoice>(query);
        }

        /// <summary>
        /// Root connection for retrieving KnowledgeArticle records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<KnowledgeArticle>> Get(this Sdk4meClient client, KnowledgeArticleQuery query)
        {
            return await client.Get<KnowledgeArticle>(query);
        }

        /// <summary>
        /// Root connection for retrieving KnowledgeArticleTemplate records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<KnowledgeArticleTemplate>> Get(this Sdk4meClient client, KnowledgeArticleTemplateQuery query)
        {
            return await client.Get<KnowledgeArticleTemplate>(query);
        }

        /// <summary>
        /// The currently authenticated person.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<Person>> Get(this Sdk4meClient client, MeQuery query)
        {
            return await client.Get<Person>(query);
        }

        /// <summary>
        /// Root connection for retrieving Organization records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<Organization>> Get(this Sdk4meClient client, OrganizationQuery query)
        {
            return await client.Get<Organization>(query);
        }

        /// <summary>
        /// Root connection for retrieving OutOfOfficePeriod records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<OutOfOfficePeriod>> Get(this Sdk4meClient client, OutOfOfficePeriodQuery query)
        {
            return await client.Get<OutOfOfficePeriod>(query);
        }

        /// <summary>
        /// Root connection for retrieving PdfDesign records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<PdfDesign>> Get(this Sdk4meClient client, PdfDesignQuery query)
        {
            return await client.Get<PdfDesign>(query);
        }

        /// <summary>
        /// Root connection for retrieving Person records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<Person>> Get(this Sdk4meClient client, PersonQuery query)
        {
            return await client.Get<Person>(query);
        }

        /// <summary>
        /// Root connection for retrieving Problem records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<Problem>> Get(this Sdk4meClient client, ProblemQuery query)
        {
            return await client.Get<Problem>(query);
        }

        /// <summary>
        /// Root connection for retrieving ProductBacklog records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<ProductBacklog>> Get(this Sdk4meClient client, ProductBacklogQuery query)
        {
            return await client.Get<ProductBacklog>(query);
        }

        /// <summary>
        /// Root connection for retrieving ProductCategory records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<ProductCategory>> Get(this Sdk4meClient client, ProductCategoryQuery query)
        {
            return await client.Get<ProductCategory>(query);
        }

        /// <summary>
        /// Root connection for retrieving Product records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<Product>> Get(this Sdk4meClient client, ProductQuery query)
        {
            return await client.Get<Product>(query);
        }

        /// <summary>
        /// Root connection for retrieving ProjectCategory records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<ProjectCategory>> Get(this Sdk4meClient client, ProjectCategoryQuery query)
        {
            return await client.Get<ProjectCategory>(query);
        }

        /// <summary>
        /// Root connection for retrieving ProjectRiskLevel records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<ProjectRiskLevel>> Get(this Sdk4meClient client, ProjectRiskLevelQuery query)
        {
            return await client.Get<ProjectRiskLevel>(query);
        }

        /// <summary>
        /// Root connection for retrieving Project records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<Project>> Get(this Sdk4meClient client, ProjectQuery query)
        {
            return await client.Get<Project>(query);
        }

        /// <summary>
        /// Root connection for retrieving ProjectTask records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<ProjectTask>> Get(this Sdk4meClient client, ProjectTaskQuery query)
        {
            return await client.Get<ProjectTask>(query);
        }

        /// <summary>
        /// Root connection for retrieving ProjectTaskTemplate records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<ProjectTaskTemplate>> Get(this Sdk4meClient client, ProjectTaskTemplateQuery query)
        {
            return await client.Get<ProjectTaskTemplate>(query);
        }

        /// <summary>
        /// Root connection for retrieving ProjectTemplate records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<ProjectTemplate>> Get(this Sdk4meClient client, ProjectTemplateQuery query)
        {
            return await client.Get<ProjectTemplate>(query);
        }

        /// <summary>
        /// The rate limit status.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<RateLimit>> Get(this Sdk4meClient client, RateLimitQuery query)
        {
            return await client.Get<RateLimit>(query);
        }

        /// <summary>
        /// Root connection for retrieving Release records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<Release>> Get(this Sdk4meClient client, ReleaseQuery query)
        {
            return await client.Get<Release>(query);
        }

        /// <summary>
        /// Root connection for retrieving Request records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<Request>> Get(this Sdk4meClient client, RequestQuery query)
        {
            return await client.Get<Request>(query);
        }

        /// <summary>
        /// Root connection for retrieving RequestTemplate records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<RequestTemplate>> Get(this Sdk4meClient client, RequestTemplateQuery query)
        {
            return await client.Get<RequestTemplate>(query);
        }

        /// <summary>
        /// Root connection for retrieving ReservationOffering records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<ReservationOffering>> Get(this Sdk4meClient client, ReservationOfferingQuery query)
        {
            return await client.Get<ReservationOffering>(query);
        }

        /// <summary>
        /// Root connection for retrieving Reservation records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<Reservation>> Get(this Sdk4meClient client, ReservationQuery query)
        {
            return await client.Get<Reservation>(query);
        }

        /// <summary>
        /// Root connection for retrieving Risk records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<Risk>> Get(this Sdk4meClient client, RiskQuery query)
        {
            return await client.Get<Risk>(query);
        }

        /// <summary>
        /// Root connection for retrieving RiskSeverity records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<RiskSeverity>> Get(this Sdk4meClient client, RiskSeverityQuery query)
        {
            return await client.Get<RiskSeverity>(query);
        }

        /// <summary>
        /// Root connection for retrieving ScrumWorkspace records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<ScrumWorkspace>> Get(this Sdk4meClient client, ScrumWorkspaceQuery query)
        {
            return await client.Get<ScrumWorkspace>(query);
        }

        /// <summary>
        /// Root connection for retrieving ServiceCategory records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<ServiceCategory>> Get(this Sdk4meClient client, ServiceCategoryQuery query)
        {
            return await client.Get<ServiceCategory>(query);
        }

        /// <summary>
        /// Root connection for retrieving ServiceInstance records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<ServiceInstance>> Get(this Sdk4meClient client, ServiceInstanceQuery query)
        {
            return await client.Get<ServiceInstance>(query);
        }

        /// <summary>
        /// Root connection for retrieving ServiceLevelAgreement records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<ServiceLevelAgreement>> Get(this Sdk4meClient client, ServiceLevelAgreementQuery query)
        {
            return await client.Get<ServiceLevelAgreement>(query);
        }

        /// <summary>
        /// Root connection for retrieving ServiceOffering records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<ServiceOffering>> Get(this Sdk4meClient client, ServiceOfferingQuery query)
        {
            return await client.Get<ServiceOffering>(query);
        }

        /// <summary>
        /// Root connection for retrieving Service records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<Service>> Get(this Sdk4meClient client, ServiceQuery query)
        {
            return await client.Get<Service>(query);
        }

        /// <summary>
        /// Root connection for retrieving ShopArticle records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<ShopArticle>> Get(this Sdk4meClient client, ShopArticleQuery query)
        {
            return await client.Get<ShopArticle>(query);
        }

        /// <summary>
        /// Root connection for retrieving ShopOrderLine records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<ShopOrderLine>> Get(this Sdk4meClient client, ShopOrderLineQuery query)
        {
            return await client.Get<ShopOrderLine>(query);
        }

        /// <summary>
        /// Root connection for retrieving ShortUrl records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<ShortUrl>> Get(this Sdk4meClient client, ShortUrlQuery query)
        {
            return await client.Get<ShortUrl>(query);
        }

        /// <summary>
        /// Root connection for retrieving Site records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<Site>> Get(this Sdk4meClient client, SiteQuery query)
        {
            return await client.Get<Site>(query);
        }

        /// <summary>
        /// Root connection for retrieving SkillPool records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<SkillPool>> Get(this Sdk4meClient client, SkillPoolQuery query)
        {
            return await client.Get<SkillPool>(query);
        }

        /// <summary>
        /// Root connection for retrieving SlaNotificationScheme records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<SlaNotificationScheme>> Get(this Sdk4meClient client, SlaNotificationSchemeQuery query)
        {
            return await client.Get<SlaNotificationScheme>(query);
        }

        /// <summary>
        /// Root connection for retrieving Sprint records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<Sprint>> Get(this Sdk4meClient client, SprintQuery query)
        {
            return await client.Get<Sprint>(query);
        }

        /// <summary>
        /// Root connection for retrieving SurveyResponse records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<SurveyResponse>> Get(this Sdk4meClient client, SurveyResponseQuery query)
        {
            return await client.Get<SurveyResponse>(query);
        }

        /// <summary>
        /// Root connection for retrieving Survey records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<Survey>> Get(this Sdk4meClient client, SurveyQuery query)
        {
            return await client.Get<Survey>(query);
        }

        /// <summary>
        /// Root connection for retrieving SyncSet records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<SyncSet>> Get(this Sdk4meClient client, SyncSetQuery query)
        {
            return await client.Get<SyncSet>(query);
        }

        /// <summary>
        /// Root connection for retrieving Task records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<Task>> Get(this Sdk4meClient client, TaskQuery query)
        {
            return await client.Get<Task>(query);
        }

        /// <summary>
        /// Root connection for retrieving TaskTemplate records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<TaskTemplate>> Get(this Sdk4meClient client, TaskTemplateQuery query)
        {
            return await client.Get<TaskTemplate>(query);
        }

        /// <summary>
        /// Root connection for retrieving Team records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<Team>> Get(this Sdk4meClient client, TeamQuery query)
        {
            return await client.Get<Team>(query);
        }

        /// <summary>
        /// Root connection for retrieving TimeAllocation records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<TimeAllocation>> Get(this Sdk4meClient client, TimeAllocationQuery query)
        {
            return await client.Get<TimeAllocation>(query);
        }

        /// <summary>
        /// Root connection for retrieving TimeEntry records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<TimeEntry>> Get(this Sdk4meClient client, TimeEntryQuery query)
        {
            return await client.Get<TimeEntry>(query);
        }

        /// <summary>
        /// Root connection for retrieving TimesheetSetting records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<TimesheetSetting>> Get(this Sdk4meClient client, TimesheetSettingQuery query)
        {
            return await client.Get<TimesheetSetting>(query);
        }

        /// <summary>
        /// Root connection for retrieving Translation records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<Translation>> Get(this Sdk4meClient client, TranslationQuery query)
        {
            return await client.Get<Translation>(query);
        }

        /// <summary>
        /// Root connection for retrieving Trash records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<Trash>> Get(this Sdk4meClient client, TrashQuery query)
        {
            return await client.Get<Trash>(query);
        }

        /// <summary>
        /// Root connection for retrieving UiExtension records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<UiExtension>> Get(this Sdk4meClient client, UiExtensionQuery query)
        {
            return await client.Get<UiExtension>(query);
        }

        /// <summary>
        /// Root connection for retrieving WaitingForCustomerFollowUp records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<WaitingForCustomerFollowUp>> Get(this Sdk4meClient client, WaitingForCustomerFollowUpQuery query)
        {
            return await client.Get<WaitingForCustomerFollowUp>(query);
        }

        /// <summary>
        /// Root connection for retrieving WebhookPolicy records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<WebhookPolicy>> Get(this Sdk4meClient client, WebhookPolicyQuery query)
        {
            return await client.Get<WebhookPolicy>(query);
        }

        /// <summary>
        /// Root connection for retrieving Webhook records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<Webhook>> Get(this Sdk4meClient client, WebhookQuery query)
        {
            return await client.Get<Webhook>(query);
        }

        /// <summary>
        /// Root connection for retrieving Workflow records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<Workflow>> Get(this Sdk4meClient client, WorkflowQuery query)
        {
            return await client.Get<Workflow>(query);
        }

        /// <summary>
        /// Root connection for retrieving WorkflowTemplate records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<WorkflowTemplate>> Get(this Sdk4meClient client, WorkflowTemplateQuery query)
        {
            return await client.Get<WorkflowTemplate>(query);
        }

        /// <summary>
        /// Root connection for retrieving WorkflowType records.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DataList<WorkflowType>> Get(this Sdk4meClient client, WorkflowTypeQuery query)
        {
            return await client.Get<WorkflowType>(query);
        }
    }
}
