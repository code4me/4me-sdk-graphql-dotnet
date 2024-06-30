using System;
using System.Threading.Tasks;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// All GraphQL mutation operations.
    /// </summary>
    public static class Sdk4meClientMutationExtension
    {
        /// <summary>
        /// Creates a new agile board.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<AgileBoardCreatePayload> Mutation(this Sdk4meClient client, AgileBoardCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new AgileBoardCreateMutation(input, new AgileBoardQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new agile board.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The agile board response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<AgileBoardCreatePayload> Mutation(this Sdk4meClient client, AgileBoardCreateInput input, AgileBoardQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new AgileBoardCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing agile board.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<AgileBoardUpdatePayload> Mutation(this Sdk4meClient client, AgileBoardUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new AgileBoardUpdateMutation(input, new AgileBoardQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing agile board.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The agile board response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<AgileBoardUpdatePayload> Mutation(this Sdk4meClient client, AgileBoardUpdateInput input, AgileBoardQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new AgileBoardUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new app instance.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<AppInstanceCreatePayload> Mutation(this Sdk4meClient client, AppInstanceCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new AppInstanceCreateMutation(input, new AppInstanceQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new app instance.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The app instance response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<AppInstanceCreatePayload> Mutation(this Sdk4meClient client, AppInstanceCreateInput input, AppInstanceQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new AppInstanceCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing app instance.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<AppInstanceUpdatePayload> Mutation(this Sdk4meClient client, AppInstanceUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new AppInstanceUpdateMutation(input, new AppInstanceQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing app instance.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The app instance response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<AppInstanceUpdatePayload> Mutation(this Sdk4meClient client, AppInstanceUpdateInput input, AppInstanceQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new AppInstanceUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new app offering automation rule.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<AppOfferingAutomationRuleCreatePayload> Mutation(this Sdk4meClient client, AppOfferingAutomationRuleCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new AppOfferingAutomationRuleCreateMutation(input, new AppOfferingAutomationRuleQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new app offering automation rule.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The app offering automation rule response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<AppOfferingAutomationRuleCreatePayload> Mutation(this Sdk4meClient client, AppOfferingAutomationRuleCreateInput input, AppOfferingAutomationRuleQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new AppOfferingAutomationRuleCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Deletes an existing app offering automation rule.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<AppOfferingAutomationRuleDeleteMutationPayload> Mutation(this Sdk4meClient client, AppOfferingAutomationRuleDeleteMutationInput input, bool throwOnError = true)
        {
            return await client.Mutation(new AppOfferingAutomationRuleDeleteMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing app offering automation rule.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<AppOfferingAutomationRuleUpdatePayload> Mutation(this Sdk4meClient client, AppOfferingAutomationRuleUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new AppOfferingAutomationRuleUpdateMutation(input, new AppOfferingAutomationRuleQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing app offering automation rule.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The app offering automation rule response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<AppOfferingAutomationRuleUpdatePayload> Mutation(this Sdk4meClient client, AppOfferingAutomationRuleUpdateInput input, AppOfferingAutomationRuleQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new AppOfferingAutomationRuleUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new app offering.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<AppOfferingCreatePayload> Mutation(this Sdk4meClient client, AppOfferingCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new AppOfferingCreateMutation(input, new AppOfferingQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new app offering.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The app offering response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<AppOfferingCreatePayload> Mutation(this Sdk4meClient client, AppOfferingCreateInput input, AppOfferingQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new AppOfferingCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new, published, app offering based on the current state of a draft app offering.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<AppOfferingPublishMutationPayload> Mutation(this Sdk4meClient client, AppOfferingPublishMutationInput input, bool throwOnError = true)
        {
            return await client.Mutation(new AppOfferingPublishMutation(input, new AppOfferingQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new, published, app offering based on the current state of a draft app offering.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The app offering response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<AppOfferingPublishMutationPayload> Mutation(this Sdk4meClient client, AppOfferingPublishMutationInput input, AppOfferingQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new AppOfferingPublishMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing app offering.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<AppOfferingUpdatePayload> Mutation(this Sdk4meClient client, AppOfferingUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new AppOfferingUpdateMutation(input, new AppOfferingQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing app offering.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The app offering response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<AppOfferingUpdatePayload> Mutation(this Sdk4meClient client, AppOfferingUpdateInput input, AppOfferingQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new AppOfferingUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new automation rule.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<AutomationRuleCreatePayload> Mutation(this Sdk4meClient client, AutomationRuleCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new AutomationRuleCreateMutation(input, new AutomationRuleQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new automation rule.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The automation rule response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<AutomationRuleCreatePayload> Mutation(this Sdk4meClient client, AutomationRuleCreateInput input, AutomationRuleQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new AutomationRuleCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing automation rule.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<AutomationRuleUpdatePayload> Mutation(this Sdk4meClient client, AutomationRuleUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new AutomationRuleUpdateMutation(input, new AutomationRuleQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing automation rule.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The automation rule response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<AutomationRuleUpdatePayload> Mutation(this Sdk4meClient client, AutomationRuleUpdateInput input, AutomationRuleQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new AutomationRuleUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new broadcast.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<BroadcastCreatePayload> Mutation(this Sdk4meClient client, BroadcastCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new BroadcastCreateMutation(input, new BroadcastQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new broadcast.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The broadcast response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<BroadcastCreatePayload> Mutation(this Sdk4meClient client, BroadcastCreateInput input, BroadcastQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new BroadcastCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing broadcast.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<BroadcastUpdatePayload> Mutation(this Sdk4meClient client, BroadcastUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new BroadcastUpdateMutation(input, new BroadcastQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing broadcast.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The broadcast response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<BroadcastUpdatePayload> Mutation(this Sdk4meClient client, BroadcastUpdateInput input, BroadcastQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new BroadcastUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new calendar.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<CalendarCreatePayload> Mutation(this Sdk4meClient client, CalendarCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new CalendarCreateMutation(input, new CalendarQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new calendar.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The calendar response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<CalendarCreatePayload> Mutation(this Sdk4meClient client, CalendarCreateInput input, CalendarQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new CalendarCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing calendar.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<CalendarUpdatePayload> Mutation(this Sdk4meClient client, CalendarUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new CalendarUpdateMutation(input, new CalendarQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing calendar.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The calendar response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<CalendarUpdatePayload> Mutation(this Sdk4meClient client, CalendarUpdateInput input, CalendarQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new CalendarUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new configuration item. **Important**: To facilitate integrations with discovery tools, the create is treated as an update in case the provided <c>name</c> or <c>label</c> is already used by an inactive CI in the same account.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<ConfigurationItemCreatePayload> Mutation(this Sdk4meClient client, ConfigurationItemCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new ConfigurationItemCreateMutation(input, new ConfigurationItemQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new configuration item. **Important**: To facilitate integrations with discovery tools, the create is treated as an update in case the provided <c>name</c> or <c>label</c> is already used by an inactive CI in the same account.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The configuration item response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ConfigurationItemCreatePayload> Mutation(this Sdk4meClient client, ConfigurationItemCreateInput input, ConfigurationItemQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ConfigurationItemCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing configuration item.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<ConfigurationItemUpdatePayload> Mutation(this Sdk4meClient client, ConfigurationItemUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new ConfigurationItemUpdateMutation(input, new ConfigurationItemQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing configuration item.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The configuration item response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ConfigurationItemUpdatePayload> Mutation(this Sdk4meClient client, ConfigurationItemUpdateInput input, ConfigurationItemQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ConfigurationItemUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new contract.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<ContractCreatePayload> Mutation(this Sdk4meClient client, ContractCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new ContractCreateMutation(input, new ContractQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new contract.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The contract response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ContractCreatePayload> Mutation(this Sdk4meClient client, ContractCreateInput input, ContractQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ContractCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing contract.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<ContractUpdatePayload> Mutation(this Sdk4meClient client, ContractUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new ContractUpdateMutation(input, new ContractQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing contract.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The contract response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ContractUpdatePayload> Mutation(this Sdk4meClient client, ContractUpdateInput input, ContractQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ContractUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new custom collection.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<CustomCollectionCreatePayload> Mutation(this Sdk4meClient client, CustomCollectionCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new CustomCollectionCreateMutation(input, new CustomCollectionQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new custom collection.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The custom collection response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<CustomCollectionCreatePayload> Mutation(this Sdk4meClient client, CustomCollectionCreateInput input, CustomCollectionQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new CustomCollectionCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new custom collection element.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<CustomCollectionElementCreatePayload> Mutation(this Sdk4meClient client, CustomCollectionElementCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new CustomCollectionElementCreateMutation(input, new CustomCollectionElementQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new custom collection element.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The custom collection element response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<CustomCollectionElementCreatePayload> Mutation(this Sdk4meClient client, CustomCollectionElementCreateInput input, CustomCollectionElementQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new CustomCollectionElementCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing custom collection element.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<CustomCollectionElementUpdatePayload> Mutation(this Sdk4meClient client, CustomCollectionElementUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new CustomCollectionElementUpdateMutation(input, new CustomCollectionElementQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing custom collection element.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The custom collection element response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<CustomCollectionElementUpdatePayload> Mutation(this Sdk4meClient client, CustomCollectionElementUpdateInput input, CustomCollectionElementQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new CustomCollectionElementUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing custom collection.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<CustomCollectionUpdatePayload> Mutation(this Sdk4meClient client, CustomCollectionUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new CustomCollectionUpdateMutation(input, new CustomCollectionQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing custom collection.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The custom collection response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<CustomCollectionUpdatePayload> Mutation(this Sdk4meClient client, CustomCollectionUpdateInput input, CustomCollectionQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new CustomCollectionUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// <br>This mutation can be used to push at most 100 discovered configuration items to 4me at once.</br>
        /// <br>A more extensive description of this functionality can be found on the</br>
        /// <br><see href="https://developer.4me.com/v1/import/discovery_tools/#using-graphql">Discovery Tools page of the developer documentation</see>.</br>
        /// <br></br>
        /// <br>The query will be executed in the background. Typically the following fields should be queried:</br>
        /// <code>
        /// asyncQuery { resultUrl errorCount }
        /// configurationItems { id sourceID }
        /// </code>
        /// <br>On initial submission the <c>configurationItems</c> field will be <c>null</c>.</br>
        /// <br>The <c>resultUrl</c> contains an expiring link to the location where the resulting JSON is available</br>
        /// <br>once the query has been executed.</br>
        /// <br>It is possible to poll the link every couple of seconds to check whether the query is completed.</br>
        /// <br>Initially the link will point to an empty JSON document (<c>{}</c>), once the query is completed it will contain</br>
        /// <br>the JSON result of this mutation.</br>
        /// <br>In the result both the <c>asyncQuery</c> and <c>configurationItems</c> fields as requested on submission are present.</br>
        /// <br>The <c>errorCount</c> can for example be used to see whether processing was successful (then it is <c>0</c>).</br>
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<DiscoveredConfigurationItemsPayload> Mutation(this Sdk4meClient client, DiscoveredConfigurationItemsInput input, bool throwOnError = true)
        {
            return await client.Mutation(new DiscoveredConfigurationItemsMutation(input, new AsyncQueryQuery()), throwOnError);
        }

        /// <summary>
        /// <br>This mutation can be used to push at most 100 discovered configuration items to 4me at once.</br>
        /// <br>A more extensive description of this functionality can be found on the</br>
        /// <br><see href="https://developer.4me.com/v1/import/discovery_tools/#using-graphql">Discovery Tools page of the developer documentation</see>.</br>
        /// <br></br>
        /// <br>The query will be executed in the background. Typically the following fields should be queried:</br>
        /// <code>
        /// asyncQuery { resultUrl errorCount }
        /// configurationItems { id sourceID }
        /// </code>
        /// <br>On initial submission the <c>configurationItems</c> field will be <c>null</c>.</br>
        /// <br>The <c>resultUrl</c> contains an expiring link to the location where the resulting JSON is available</br>
        /// <br>once the query has been executed.</br>
        /// <br>It is possible to poll the link every couple of seconds to check whether the query is completed.</br>
        /// <br>Initially the link will point to an empty JSON document (<c>{}</c>), once the query is completed it will contain</br>
        /// <br>the JSON result of this mutation.</br>
        /// <br>In the result both the <c>asyncQuery</c> and <c>configurationItems</c> fields as requested on submission are present.</br>
        /// <br>The <c>errorCount</c> can for example be used to see whether processing was successful (then it is <c>0</c>).</br>
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The async query response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DiscoveredConfigurationItemsPayload> Mutation(this Sdk4meClient client, DiscoveredConfigurationItemsInput input, AsyncQueryQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new DiscoveredConfigurationItemsMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new effort class.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<EffortClassCreatePayload> Mutation(this Sdk4meClient client, EffortClassCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new EffortClassCreateMutation(input, new EffortClassQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new effort class.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The effort class response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<EffortClassCreatePayload> Mutation(this Sdk4meClient client, EffortClassCreateInput input, EffortClassQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new EffortClassCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing effort class.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<EffortClassUpdatePayload> Mutation(this Sdk4meClient client, EffortClassUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new EffortClassUpdateMutation(input, new EffortClassQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing effort class.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The effort class response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<EffortClassUpdatePayload> Mutation(this Sdk4meClient client, EffortClassUpdateInput input, EffortClassQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new EffortClassUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new first line support agreement.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<FirstLineSupportAgreementCreatePayload> Mutation(this Sdk4meClient client, FirstLineSupportAgreementCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new FirstLineSupportAgreementCreateMutation(input, new FirstLineSupportAgreementQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new first line support agreement.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The first line support agreement response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<FirstLineSupportAgreementCreatePayload> Mutation(this Sdk4meClient client, FirstLineSupportAgreementCreateInput input, FirstLineSupportAgreementQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new FirstLineSupportAgreementCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing first line support agreement.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<FirstLineSupportAgreementUpdatePayload> Mutation(this Sdk4meClient client, FirstLineSupportAgreementUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new FirstLineSupportAgreementUpdateMutation(input, new FirstLineSupportAgreementQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing first line support agreement.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The first line support agreement response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<FirstLineSupportAgreementUpdatePayload> Mutation(this Sdk4meClient client, FirstLineSupportAgreementUpdateInput input, FirstLineSupportAgreementQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new FirstLineSupportAgreementUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new holiday.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<HolidayCreatePayload> Mutation(this Sdk4meClient client, HolidayCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new HolidayCreateMutation(input, new HolidayQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new holiday.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The holiday response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<HolidayCreatePayload> Mutation(this Sdk4meClient client, HolidayCreateInput input, HolidayQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new HolidayCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing holiday.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<HolidayUpdatePayload> Mutation(this Sdk4meClient client, HolidayUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new HolidayUpdateMutation(input, new HolidayQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing holiday.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The holiday response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<HolidayUpdatePayload> Mutation(this Sdk4meClient client, HolidayUpdateInput input, HolidayQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new HolidayUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new invoice.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<InvoiceCreatePayload> Mutation(this Sdk4meClient client, InvoiceCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new InvoiceCreateMutation(input, new InvoiceQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new invoice.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The invoice response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<InvoiceCreatePayload> Mutation(this Sdk4meClient client, InvoiceCreateInput input, InvoiceQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new InvoiceCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing invoice.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<InvoiceUpdatePayload> Mutation(this Sdk4meClient client, InvoiceUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new InvoiceUpdateMutation(input, new InvoiceQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing invoice.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The invoice response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<InvoiceUpdatePayload> Mutation(this Sdk4meClient client, InvoiceUpdateInput input, InvoiceQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new InvoiceUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new knowledge article.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<KnowledgeArticleCreatePayload> Mutation(this Sdk4meClient client, KnowledgeArticleCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new KnowledgeArticleCreateMutation(input, new KnowledgeArticleQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new knowledge article.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The knowledge article response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<KnowledgeArticleCreatePayload> Mutation(this Sdk4meClient client, KnowledgeArticleCreateInput input, KnowledgeArticleQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new KnowledgeArticleCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing knowledge article.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<KnowledgeArticleUpdatePayload> Mutation(this Sdk4meClient client, KnowledgeArticleUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new KnowledgeArticleUpdateMutation(input, new KnowledgeArticleQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing knowledge article.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The knowledge article response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<KnowledgeArticleUpdatePayload> Mutation(this Sdk4meClient client, KnowledgeArticleUpdateInput input, KnowledgeArticleQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new KnowledgeArticleUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Adds a new note to a record.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<NoteCreatePayload> Mutation(this Sdk4meClient client, NoteCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new NoteCreateMutation(input, new NoteQuery()), throwOnError);
        }

        /// <summary>
        /// Adds a new note to a record.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The note response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<NoteCreatePayload> Mutation(this Sdk4meClient client, NoteCreateInput input, NoteQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new NoteCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Adds a new note reaction to a note.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<NoteReactionCreatePayload> Mutation(this Sdk4meClient client, NoteReactionCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new NoteReactionCreateMutation(input, new NoteReactionQuery()), throwOnError);
        }

        /// <summary>
        /// Adds a new note reaction to a note.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The note reaction response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<NoteReactionCreatePayload> Mutation(this Sdk4meClient client, NoteReactionCreateInput input, NoteReactionQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new NoteReactionCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Deletes a note reaction from a note.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<NoteReactionDeleteMutationPayload> Mutation(this Sdk4meClient client, NoteReactionDeleteMutationInput input, bool throwOnError = true)
        {
            return await client.Mutation(new NoteReactionDeleteMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new organization.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<OrganizationCreatePayload> Mutation(this Sdk4meClient client, OrganizationCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new OrganizationCreateMutation(input, new OrganizationQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new organization.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The organization response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<OrganizationCreatePayload> Mutation(this Sdk4meClient client, OrganizationCreateInput input, OrganizationQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new OrganizationCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing organization.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<OrganizationUpdatePayload> Mutation(this Sdk4meClient client, OrganizationUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new OrganizationUpdateMutation(input, new OrganizationQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing organization.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The organization response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<OrganizationUpdatePayload> Mutation(this Sdk4meClient client, OrganizationUpdateInput input, OrganizationQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new OrganizationUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new out of office period.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<OutOfOfficePeriodCreatePayload> Mutation(this Sdk4meClient client, OutOfOfficePeriodCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new OutOfOfficePeriodCreateMutation(input, new OutOfOfficePeriodQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new out of office period.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The out of office period response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<OutOfOfficePeriodCreatePayload> Mutation(this Sdk4meClient client, OutOfOfficePeriodCreateInput input, OutOfOfficePeriodQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new OutOfOfficePeriodCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing out of office period.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<OutOfOfficePeriodUpdatePayload> Mutation(this Sdk4meClient client, OutOfOfficePeriodUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new OutOfOfficePeriodUpdateMutation(input, new OutOfOfficePeriodQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing out of office period.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The out of office period response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<OutOfOfficePeriodUpdatePayload> Mutation(this Sdk4meClient client, OutOfOfficePeriodUpdateInput input, OutOfOfficePeriodQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new OutOfOfficePeriodUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new PDF design.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<PdfDesignCreatePayload> Mutation(this Sdk4meClient client, PdfDesignCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new PdfDesignCreateMutation(input, new PdfDesignQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new PDF design.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The pdf design response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<PdfDesignCreatePayload> Mutation(this Sdk4meClient client, PdfDesignCreateInput input, PdfDesignQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new PdfDesignCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing PDF design.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<PdfDesignUpdatePayload> Mutation(this Sdk4meClient client, PdfDesignUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new PdfDesignUpdateMutation(input, new PdfDesignQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing PDF design.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The pdf design response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<PdfDesignUpdatePayload> Mutation(this Sdk4meClient client, PdfDesignUpdateInput input, PdfDesignQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new PdfDesignUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new person.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<PersonCreatePayload> Mutation(this Sdk4meClient client, PersonCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new PersonCreateMutation(input, new PersonQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new person.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The person response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<PersonCreatePayload> Mutation(this Sdk4meClient client, PersonCreateInput input, PersonQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new PersonCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing person.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<PersonUpdatePayload> Mutation(this Sdk4meClient client, PersonUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new PersonUpdateMutation(input, new PersonQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing person.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The person response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<PersonUpdatePayload> Mutation(this Sdk4meClient client, PersonUpdateInput input, PersonQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new PersonUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new problem.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<ProblemCreatePayload> Mutation(this Sdk4meClient client, ProblemCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new ProblemCreateMutation(input, new ProblemQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new problem.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The problem response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ProblemCreatePayload> Mutation(this Sdk4meClient client, ProblemCreateInput input, ProblemQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ProblemCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing problem.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<ProblemUpdatePayload> Mutation(this Sdk4meClient client, ProblemUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new ProblemUpdateMutation(input, new ProblemQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing problem.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The problem response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ProblemUpdatePayload> Mutation(this Sdk4meClient client, ProblemUpdateInput input, ProblemQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ProblemUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new product backlog.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<ProductBacklogCreatePayload> Mutation(this Sdk4meClient client, ProductBacklogCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new ProductBacklogCreateMutation(input, new ProductBacklogQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new product backlog.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The product backlog response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ProductBacklogCreatePayload> Mutation(this Sdk4meClient client, ProductBacklogCreateInput input, ProductBacklogQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ProductBacklogCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing product backlog.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<ProductBacklogUpdatePayload> Mutation(this Sdk4meClient client, ProductBacklogUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new ProductBacklogUpdateMutation(input, new ProductBacklogQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing product backlog.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The product backlog response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ProductBacklogUpdatePayload> Mutation(this Sdk4meClient client, ProductBacklogUpdateInput input, ProductBacklogQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ProductBacklogUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new product category.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<ProductCategoryCreatePayload> Mutation(this Sdk4meClient client, ProductCategoryCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new ProductCategoryCreateMutation(input, new ProductCategoryQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new product category.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The product category response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ProductCategoryCreatePayload> Mutation(this Sdk4meClient client, ProductCategoryCreateInput input, ProductCategoryQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ProductCategoryCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing product category.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<ProductCategoryUpdatePayload> Mutation(this Sdk4meClient client, ProductCategoryUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new ProductCategoryUpdateMutation(input, new ProductCategoryQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing product category.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The product category response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ProductCategoryUpdatePayload> Mutation(this Sdk4meClient client, ProductCategoryUpdateInput input, ProductCategoryQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ProductCategoryUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new product.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<ProductCreatePayload> Mutation(this Sdk4meClient client, ProductCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new ProductCreateMutation(input, new ProductQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new product.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The product response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ProductCreatePayload> Mutation(this Sdk4meClient client, ProductCreateInput input, ProductQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ProductCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing product.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<ProductUpdatePayload> Mutation(this Sdk4meClient client, ProductUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new ProductUpdateMutation(input, new ProductQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing product.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The product response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ProductUpdatePayload> Mutation(this Sdk4meClient client, ProductUpdateInput input, ProductQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ProductUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new project category.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<ProjectCategoryCreatePayload> Mutation(this Sdk4meClient client, ProjectCategoryCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new ProjectCategoryCreateMutation(input, new ProjectCategoryQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new project category.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The project category response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ProjectCategoryCreatePayload> Mutation(this Sdk4meClient client, ProjectCategoryCreateInput input, ProjectCategoryQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ProjectCategoryCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing project category.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<ProjectCategoryUpdatePayload> Mutation(this Sdk4meClient client, ProjectCategoryUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new ProjectCategoryUpdateMutation(input, new ProjectCategoryQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing project category.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The project category response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ProjectCategoryUpdatePayload> Mutation(this Sdk4meClient client, ProjectCategoryUpdateInput input, ProjectCategoryQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ProjectCategoryUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new project.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<ProjectCreatePayload> Mutation(this Sdk4meClient client, ProjectCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new ProjectCreateMutation(input, new ProjectQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new project.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The project response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ProjectCreatePayload> Mutation(this Sdk4meClient client, ProjectCreateInput input, ProjectQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ProjectCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new project risk level.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<ProjectRiskLevelCreatePayload> Mutation(this Sdk4meClient client, ProjectRiskLevelCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new ProjectRiskLevelCreateMutation(input, new ProjectRiskLevelQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new project risk level.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The project risk level response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ProjectRiskLevelCreatePayload> Mutation(this Sdk4meClient client, ProjectRiskLevelCreateInput input, ProjectRiskLevelQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ProjectRiskLevelCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing project risk level.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<ProjectRiskLevelUpdatePayload> Mutation(this Sdk4meClient client, ProjectRiskLevelUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new ProjectRiskLevelUpdateMutation(input, new ProjectRiskLevelQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing project risk level.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The project risk level response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ProjectRiskLevelUpdatePayload> Mutation(this Sdk4meClient client, ProjectRiskLevelUpdateInput input, ProjectRiskLevelQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ProjectRiskLevelUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new project task.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<ProjectTaskCreatePayload> Mutation(this Sdk4meClient client, ProjectTaskCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new ProjectTaskCreateMutation(input, new ProjectTaskQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new project task.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The project task response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ProjectTaskCreatePayload> Mutation(this Sdk4meClient client, ProjectTaskCreateInput input, ProjectTaskQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ProjectTaskCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new project task template.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<ProjectTaskTemplateCreatePayload> Mutation(this Sdk4meClient client, ProjectTaskTemplateCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new ProjectTaskTemplateCreateMutation(input, new ProjectTaskTemplateQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new project task template.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The project task template response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ProjectTaskTemplateCreatePayload> Mutation(this Sdk4meClient client, ProjectTaskTemplateCreateInput input, ProjectTaskTemplateQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ProjectTaskTemplateCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing project task template.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<ProjectTaskTemplateUpdatePayload> Mutation(this Sdk4meClient client, ProjectTaskTemplateUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new ProjectTaskTemplateUpdateMutation(input, new ProjectTaskTemplateQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing project task template.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The project task template response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ProjectTaskTemplateUpdatePayload> Mutation(this Sdk4meClient client, ProjectTaskTemplateUpdateInput input, ProjectTaskTemplateQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ProjectTaskTemplateUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing project task.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<ProjectTaskUpdatePayload> Mutation(this Sdk4meClient client, ProjectTaskUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new ProjectTaskUpdateMutation(input, new ProjectTaskQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing project task.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The project task response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ProjectTaskUpdatePayload> Mutation(this Sdk4meClient client, ProjectTaskUpdateInput input, ProjectTaskQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ProjectTaskUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new project template.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<ProjectTemplateCreatePayload> Mutation(this Sdk4meClient client, ProjectTemplateCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new ProjectTemplateCreateMutation(input, new ProjectTemplateQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new project template.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The project template response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ProjectTemplateCreatePayload> Mutation(this Sdk4meClient client, ProjectTemplateCreateInput input, ProjectTemplateQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ProjectTemplateCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing project template.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<ProjectTemplateUpdatePayload> Mutation(this Sdk4meClient client, ProjectTemplateUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new ProjectTemplateUpdateMutation(input, new ProjectTemplateQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing project template.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The project template response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ProjectTemplateUpdatePayload> Mutation(this Sdk4meClient client, ProjectTemplateUpdateInput input, ProjectTemplateQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ProjectTemplateUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing project.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<ProjectUpdatePayload> Mutation(this Sdk4meClient client, ProjectUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new ProjectUpdateMutation(input, new ProjectQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing project.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The project response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ProjectUpdatePayload> Mutation(this Sdk4meClient client, ProjectUpdateInput input, ProjectQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ProjectUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new release.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<ReleaseCreatePayload> Mutation(this Sdk4meClient client, ReleaseCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new ReleaseCreateMutation(input, new ReleaseQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new release.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The release response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ReleaseCreatePayload> Mutation(this Sdk4meClient client, ReleaseCreateInput input, ReleaseQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ReleaseCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing release.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<ReleaseUpdatePayload> Mutation(this Sdk4meClient client, ReleaseUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new ReleaseUpdateMutation(input, new ReleaseQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing release.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The release response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ReleaseUpdatePayload> Mutation(this Sdk4meClient client, ReleaseUpdateInput input, ReleaseQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ReleaseUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new request.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<RequestCreatePayload> Mutation(this Sdk4meClient client, RequestCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new RequestCreateMutation(input, new RequestQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new request.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The request response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<RequestCreatePayload> Mutation(this Sdk4meClient client, RequestCreateInput input, RequestQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new RequestCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new request template.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<RequestTemplateCreatePayload> Mutation(this Sdk4meClient client, RequestTemplateCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new RequestTemplateCreateMutation(input, new RequestTemplateQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new request template.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The request template response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<RequestTemplateCreatePayload> Mutation(this Sdk4meClient client, RequestTemplateCreateInput input, RequestTemplateQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new RequestTemplateCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing request template.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<RequestTemplateUpdatePayload> Mutation(this Sdk4meClient client, RequestTemplateUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new RequestTemplateUpdateMutation(input, new RequestTemplateQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing request template.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The request template response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<RequestTemplateUpdatePayload> Mutation(this Sdk4meClient client, RequestTemplateUpdateInput input, RequestTemplateQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new RequestTemplateUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing request.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<RequestUpdatePayload> Mutation(this Sdk4meClient client, RequestUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new RequestUpdateMutation(input, new RequestQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing request.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The request response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<RequestUpdatePayload> Mutation(this Sdk4meClient client, RequestUpdateInput input, RequestQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new RequestUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new reservation.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<ReservationCreatePayload> Mutation(this Sdk4meClient client, ReservationCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new ReservationCreateMutation(input, new ReservationQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new reservation.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The reservation response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ReservationCreatePayload> Mutation(this Sdk4meClient client, ReservationCreateInput input, ReservationQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ReservationCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new reservation offering.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<ReservationOfferingCreatePayload> Mutation(this Sdk4meClient client, ReservationOfferingCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new ReservationOfferingCreateMutation(input, new ReservationOfferingQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new reservation offering.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The reservation offering response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ReservationOfferingCreatePayload> Mutation(this Sdk4meClient client, ReservationOfferingCreateInput input, ReservationOfferingQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ReservationOfferingCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing reservation offering.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<ReservationOfferingUpdatePayload> Mutation(this Sdk4meClient client, ReservationOfferingUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new ReservationOfferingUpdateMutation(input, new ReservationOfferingQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing reservation offering.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The reservation offering response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ReservationOfferingUpdatePayload> Mutation(this Sdk4meClient client, ReservationOfferingUpdateInput input, ReservationOfferingQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ReservationOfferingUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing reservation.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<ReservationUpdatePayload> Mutation(this Sdk4meClient client, ReservationUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new ReservationUpdateMutation(input, new ReservationQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing reservation.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The reservation response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ReservationUpdatePayload> Mutation(this Sdk4meClient client, ReservationUpdateInput input, ReservationQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ReservationUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new risk.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<RiskCreatePayload> Mutation(this Sdk4meClient client, RiskCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new RiskCreateMutation(input, new RiskQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new risk.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The risk response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<RiskCreatePayload> Mutation(this Sdk4meClient client, RiskCreateInput input, RiskQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new RiskCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new risk severity.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<RiskSeverityCreatePayload> Mutation(this Sdk4meClient client, RiskSeverityCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new RiskSeverityCreateMutation(input, new RiskSeverityQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new risk severity.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The risk severity response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<RiskSeverityCreatePayload> Mutation(this Sdk4meClient client, RiskSeverityCreateInput input, RiskSeverityQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new RiskSeverityCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing risk severity.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<RiskSeverityUpdatePayload> Mutation(this Sdk4meClient client, RiskSeverityUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new RiskSeverityUpdateMutation(input, new RiskSeverityQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing risk severity.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The risk severity response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<RiskSeverityUpdatePayload> Mutation(this Sdk4meClient client, RiskSeverityUpdateInput input, RiskSeverityQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new RiskSeverityUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing risk.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<RiskUpdatePayload> Mutation(this Sdk4meClient client, RiskUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new RiskUpdateMutation(input, new RiskQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing risk.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The risk response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<RiskUpdatePayload> Mutation(this Sdk4meClient client, RiskUpdateInput input, RiskQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new RiskUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new scrum workspace.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<ScrumWorkspaceCreatePayload> Mutation(this Sdk4meClient client, ScrumWorkspaceCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new ScrumWorkspaceCreateMutation(input, new ScrumWorkspaceQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new scrum workspace.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The scrum workspace response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ScrumWorkspaceCreatePayload> Mutation(this Sdk4meClient client, ScrumWorkspaceCreateInput input, ScrumWorkspaceQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ScrumWorkspaceCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing scrum workspace.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<ScrumWorkspaceUpdatePayload> Mutation(this Sdk4meClient client, ScrumWorkspaceUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new ScrumWorkspaceUpdateMutation(input, new ScrumWorkspaceQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing scrum workspace.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The scrum workspace response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ScrumWorkspaceUpdatePayload> Mutation(this Sdk4meClient client, ScrumWorkspaceUpdateInput input, ScrumWorkspaceQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ScrumWorkspaceUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new service category.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<ServiceCategoryCreatePayload> Mutation(this Sdk4meClient client, ServiceCategoryCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new ServiceCategoryCreateMutation(input, new ServiceCategoryQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new service category.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The service category response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ServiceCategoryCreatePayload> Mutation(this Sdk4meClient client, ServiceCategoryCreateInput input, ServiceCategoryQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ServiceCategoryCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing service category.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<ServiceCategoryUpdatePayload> Mutation(this Sdk4meClient client, ServiceCategoryUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new ServiceCategoryUpdateMutation(input, new ServiceCategoryQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing service category.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The service category response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ServiceCategoryUpdatePayload> Mutation(this Sdk4meClient client, ServiceCategoryUpdateInput input, ServiceCategoryQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ServiceCategoryUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new service.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<ServiceCreatePayload> Mutation(this Sdk4meClient client, ServiceCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new ServiceCreateMutation(input, new ServiceQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new service.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The service response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ServiceCreatePayload> Mutation(this Sdk4meClient client, ServiceCreateInput input, ServiceQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ServiceCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new service instance.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<ServiceInstanceCreatePayload> Mutation(this Sdk4meClient client, ServiceInstanceCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new ServiceInstanceCreateMutation(input, new ServiceInstanceQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new service instance.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The service instance response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ServiceInstanceCreatePayload> Mutation(this Sdk4meClient client, ServiceInstanceCreateInput input, ServiceInstanceQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ServiceInstanceCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing service instance.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<ServiceInstanceUpdatePayload> Mutation(this Sdk4meClient client, ServiceInstanceUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new ServiceInstanceUpdateMutation(input, new ServiceInstanceQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing service instance.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The service instance response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ServiceInstanceUpdatePayload> Mutation(this Sdk4meClient client, ServiceInstanceUpdateInput input, ServiceInstanceQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ServiceInstanceUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new service level agreement.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<ServiceLevelAgreementCreatePayload> Mutation(this Sdk4meClient client, ServiceLevelAgreementCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new ServiceLevelAgreementCreateMutation(input, new ServiceLevelAgreementQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new service level agreement.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The service level agreement response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ServiceLevelAgreementCreatePayload> Mutation(this Sdk4meClient client, ServiceLevelAgreementCreateInput input, ServiceLevelAgreementQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ServiceLevelAgreementCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing service level agreement.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<ServiceLevelAgreementUpdatePayload> Mutation(this Sdk4meClient client, ServiceLevelAgreementUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new ServiceLevelAgreementUpdateMutation(input, new ServiceLevelAgreementQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing service level agreement.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The service level agreement response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ServiceLevelAgreementUpdatePayload> Mutation(this Sdk4meClient client, ServiceLevelAgreementUpdateInput input, ServiceLevelAgreementQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ServiceLevelAgreementUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new service offering.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<ServiceOfferingCreatePayload> Mutation(this Sdk4meClient client, ServiceOfferingCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new ServiceOfferingCreateMutation(input, new ServiceOfferingQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new service offering.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The service offering response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ServiceOfferingCreatePayload> Mutation(this Sdk4meClient client, ServiceOfferingCreateInput input, ServiceOfferingQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ServiceOfferingCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing service offering.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<ServiceOfferingUpdatePayload> Mutation(this Sdk4meClient client, ServiceOfferingUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new ServiceOfferingUpdateMutation(input, new ServiceOfferingQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing service offering.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The service offering response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ServiceOfferingUpdatePayload> Mutation(this Sdk4meClient client, ServiceOfferingUpdateInput input, ServiceOfferingQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ServiceOfferingUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing service.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<ServiceUpdatePayload> Mutation(this Sdk4meClient client, ServiceUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new ServiceUpdateMutation(input, new ServiceQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing service.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The service response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ServiceUpdatePayload> Mutation(this Sdk4meClient client, ServiceUpdateInput input, ServiceQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ServiceUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new shop article category.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<ShopArticleCategoryCreatePayload> Mutation(this Sdk4meClient client, ShopArticleCategoryCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new ShopArticleCategoryCreateMutation(input, new ShopArticleCategoryQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new shop article category.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The shop article category response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ShopArticleCategoryCreatePayload> Mutation(this Sdk4meClient client, ShopArticleCategoryCreateInput input, ShopArticleCategoryQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ShopArticleCategoryCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing shop article category.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<ShopArticleCategoryUpdatePayload> Mutation(this Sdk4meClient client, ShopArticleCategoryUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new ShopArticleCategoryUpdateMutation(input, new ShopArticleCategoryQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing shop article category.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The shop article category response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ShopArticleCategoryUpdatePayload> Mutation(this Sdk4meClient client, ShopArticleCategoryUpdateInput input, ShopArticleCategoryQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ShopArticleCategoryUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new shop article.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<ShopArticleCreatePayload> Mutation(this Sdk4meClient client, ShopArticleCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new ShopArticleCreateMutation(input, new ShopArticleQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new shop article.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The shop article response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ShopArticleCreatePayload> Mutation(this Sdk4meClient client, ShopArticleCreateInput input, ShopArticleQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ShopArticleCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing shop article.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<ShopArticleUpdatePayload> Mutation(this Sdk4meClient client, ShopArticleUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new ShopArticleUpdateMutation(input, new ShopArticleQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing shop article.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The shop article response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ShopArticleUpdatePayload> Mutation(this Sdk4meClient client, ShopArticleUpdateInput input, ShopArticleQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ShopArticleUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new shop order line.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<ShopOrderLineCreatePayload> Mutation(this Sdk4meClient client, ShopOrderLineCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new ShopOrderLineCreateMutation(input, new ShopOrderLineQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new shop order line.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The shop order line response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ShopOrderLineCreatePayload> Mutation(this Sdk4meClient client, ShopOrderLineCreateInput input, ShopOrderLineQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ShopOrderLineCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing shop order line.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<ShopOrderLineUpdatePayload> Mutation(this Sdk4meClient client, ShopOrderLineUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new ShopOrderLineUpdateMutation(input, new ShopOrderLineQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing shop order line.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The shop order line response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ShopOrderLineUpdatePayload> Mutation(this Sdk4meClient client, ShopOrderLineUpdateInput input, ShopOrderLineQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ShopOrderLineUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new short URL.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<ShortUrlCreatePayload> Mutation(this Sdk4meClient client, ShortUrlCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new ShortUrlCreateMutation(input, new ShortUrlQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new short URL.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The short url response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ShortUrlCreatePayload> Mutation(this Sdk4meClient client, ShortUrlCreateInput input, ShortUrlQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ShortUrlCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing short URL.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<ShortUrlUpdatePayload> Mutation(this Sdk4meClient client, ShortUrlUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new ShortUrlUpdateMutation(input, new ShortUrlQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing short URL.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The short url response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ShortUrlUpdatePayload> Mutation(this Sdk4meClient client, ShortUrlUpdateInput input, ShortUrlQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new ShortUrlUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new site.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<SiteCreatePayload> Mutation(this Sdk4meClient client, SiteCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new SiteCreateMutation(input, new SiteQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new site.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The site response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<SiteCreatePayload> Mutation(this Sdk4meClient client, SiteCreateInput input, SiteQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new SiteCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing site.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<SiteUpdatePayload> Mutation(this Sdk4meClient client, SiteUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new SiteUpdateMutation(input, new SiteQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing site.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The site response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<SiteUpdatePayload> Mutation(this Sdk4meClient client, SiteUpdateInput input, SiteQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new SiteUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new skill pool.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<SkillPoolCreatePayload> Mutation(this Sdk4meClient client, SkillPoolCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new SkillPoolCreateMutation(input, new SkillPoolQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new skill pool.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The skill pool response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<SkillPoolCreatePayload> Mutation(this Sdk4meClient client, SkillPoolCreateInput input, SkillPoolQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new SkillPoolCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing skill pool.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<SkillPoolUpdatePayload> Mutation(this Sdk4meClient client, SkillPoolUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new SkillPoolUpdateMutation(input, new SkillPoolQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing skill pool.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The skill pool response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<SkillPoolUpdatePayload> Mutation(this Sdk4meClient client, SkillPoolUpdateInput input, SkillPoolQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new SkillPoolUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new SLA coverage group.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<SlaCoverageGroupCreatePayload> Mutation(this Sdk4meClient client, SlaCoverageGroupCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new SlaCoverageGroupCreateMutation(input, new SlaCoverageGroupQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new SLA coverage group.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The sla coverage group response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<SlaCoverageGroupCreatePayload> Mutation(this Sdk4meClient client, SlaCoverageGroupCreateInput input, SlaCoverageGroupQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new SlaCoverageGroupCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing SLA coverage group.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<SlaCoverageGroupUpdatePayload> Mutation(this Sdk4meClient client, SlaCoverageGroupUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new SlaCoverageGroupUpdateMutation(input, new SlaCoverageGroupQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing SLA coverage group.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The sla coverage group response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<SlaCoverageGroupUpdatePayload> Mutation(this Sdk4meClient client, SlaCoverageGroupUpdateInput input, SlaCoverageGroupQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new SlaCoverageGroupUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new SLA notification scheme.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<SlaNotificationSchemeCreatePayload> Mutation(this Sdk4meClient client, SlaNotificationSchemeCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new SlaNotificationSchemeCreateMutation(input, new SlaNotificationSchemeQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new SLA notification scheme.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The sla notification scheme response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<SlaNotificationSchemeCreatePayload> Mutation(this Sdk4meClient client, SlaNotificationSchemeCreateInput input, SlaNotificationSchemeQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new SlaNotificationSchemeCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing SLA notification scheme.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<SlaNotificationSchemeUpdatePayload> Mutation(this Sdk4meClient client, SlaNotificationSchemeUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new SlaNotificationSchemeUpdateMutation(input, new SlaNotificationSchemeQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing SLA notification scheme.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The sla notification scheme response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<SlaNotificationSchemeUpdatePayload> Mutation(this Sdk4meClient client, SlaNotificationSchemeUpdateInput input, SlaNotificationSchemeQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new SlaNotificationSchemeUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new sprint.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<SprintCreatePayload> Mutation(this Sdk4meClient client, SprintCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new SprintCreateMutation(input, new SprintQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new sprint.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The sprint response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<SprintCreatePayload> Mutation(this Sdk4meClient client, SprintCreateInput input, SprintQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new SprintCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing sprint.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<SprintUpdatePayload> Mutation(this Sdk4meClient client, SprintUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new SprintUpdateMutation(input, new SprintQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing sprint.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The sprint response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<SprintUpdatePayload> Mutation(this Sdk4meClient client, SprintUpdateInput input, SprintQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new SprintUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new survey.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<SurveyCreatePayload> Mutation(this Sdk4meClient client, SurveyCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new SurveyCreateMutation(input, new SurveyQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new survey.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The survey response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<SurveyCreatePayload> Mutation(this Sdk4meClient client, SurveyCreateInput input, SurveyQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new SurveyCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new survey response.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<SurveyResponseCreatePayload> Mutation(this Sdk4meClient client, SurveyResponseCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new SurveyResponseCreateMutation(input, new SurveyResponseQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new survey response.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The survey response response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<SurveyResponseCreatePayload> Mutation(this Sdk4meClient client, SurveyResponseCreateInput input, SurveyResponseQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new SurveyResponseCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing survey response.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<SurveyResponseUpdatePayload> Mutation(this Sdk4meClient client, SurveyResponseUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new SurveyResponseUpdateMutation(input, new SurveyResponseQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing survey response.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The survey response response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<SurveyResponseUpdatePayload> Mutation(this Sdk4meClient client, SurveyResponseUpdateInput input, SurveyResponseQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new SurveyResponseUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing survey.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<SurveyUpdatePayload> Mutation(this Sdk4meClient client, SurveyUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new SurveyUpdateMutation(input, new SurveyQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing survey.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The survey response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<SurveyUpdatePayload> Mutation(this Sdk4meClient client, SurveyUpdateInput input, SurveyQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new SurveyUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new task.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<TaskCreatePayload> Mutation(this Sdk4meClient client, TaskCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new TaskCreateMutation(input, new TaskQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new task.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The task response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<TaskCreatePayload> Mutation(this Sdk4meClient client, TaskCreateInput input, TaskQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new TaskCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new task template.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<TaskTemplateCreatePayload> Mutation(this Sdk4meClient client, TaskTemplateCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new TaskTemplateCreateMutation(input, new TaskTemplateQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new task template.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The task template response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<TaskTemplateCreatePayload> Mutation(this Sdk4meClient client, TaskTemplateCreateInput input, TaskTemplateQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new TaskTemplateCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing task template.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<TaskTemplateUpdatePayload> Mutation(this Sdk4meClient client, TaskTemplateUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new TaskTemplateUpdateMutation(input, new TaskTemplateQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing task template.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The task template response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<TaskTemplateUpdatePayload> Mutation(this Sdk4meClient client, TaskTemplateUpdateInput input, TaskTemplateQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new TaskTemplateUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing task.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<TaskUpdatePayload> Mutation(this Sdk4meClient client, TaskUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new TaskUpdateMutation(input, new TaskQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing task.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The task response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<TaskUpdatePayload> Mutation(this Sdk4meClient client, TaskUpdateInput input, TaskQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new TaskUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new team.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<TeamCreatePayload> Mutation(this Sdk4meClient client, TeamCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new TeamCreateMutation(input, new TeamQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new team.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The team response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<TeamCreatePayload> Mutation(this Sdk4meClient client, TeamCreateInput input, TeamQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new TeamCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing team.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<TeamUpdatePayload> Mutation(this Sdk4meClient client, TeamUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new TeamUpdateMutation(input, new TeamQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing team.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The team response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<TeamUpdatePayload> Mutation(this Sdk4meClient client, TeamUpdateInput input, TeamQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new TeamUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new time allocation.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<TimeAllocationCreatePayload> Mutation(this Sdk4meClient client, TimeAllocationCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new TimeAllocationCreateMutation(input, new TimeAllocationQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new time allocation.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The time allocation response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<TimeAllocationCreatePayload> Mutation(this Sdk4meClient client, TimeAllocationCreateInput input, TimeAllocationQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new TimeAllocationCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing time allocation.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<TimeAllocationUpdatePayload> Mutation(this Sdk4meClient client, TimeAllocationUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new TimeAllocationUpdateMutation(input, new TimeAllocationQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing time allocation.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The time allocation response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<TimeAllocationUpdatePayload> Mutation(this Sdk4meClient client, TimeAllocationUpdateInput input, TimeAllocationQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new TimeAllocationUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new time entry.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<TimeEntryCreatePayload> Mutation(this Sdk4meClient client, TimeEntryCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new TimeEntryCreateMutation(input, new TimeEntryQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new time entry.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The time entry response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<TimeEntryCreatePayload> Mutation(this Sdk4meClient client, TimeEntryCreateInput input, TimeEntryQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new TimeEntryCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing time entry.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<TimeEntryUpdatePayload> Mutation(this Sdk4meClient client, TimeEntryUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new TimeEntryUpdateMutation(input, new TimeEntryQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing time entry.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The time entry response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<TimeEntryUpdatePayload> Mutation(this Sdk4meClient client, TimeEntryUpdateInput input, TimeEntryQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new TimeEntryUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new timesheet setting.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<TimesheetSettingCreatePayload> Mutation(this Sdk4meClient client, TimesheetSettingCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new TimesheetSettingCreateMutation(input, new TimesheetSettingQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new timesheet setting.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The timesheet setting response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<TimesheetSettingCreatePayload> Mutation(this Sdk4meClient client, TimesheetSettingCreateInput input, TimesheetSettingQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new TimesheetSettingCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing timesheet setting.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<TimesheetSettingUpdatePayload> Mutation(this Sdk4meClient client, TimesheetSettingUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new TimesheetSettingUpdateMutation(input, new TimesheetSettingQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing timesheet setting.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The timesheet setting response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<TimesheetSettingUpdatePayload> Mutation(this Sdk4meClient client, TimesheetSettingUpdateInput input, TimesheetSettingQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new TimesheetSettingUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new translation.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<TranslationCreatePayload> Mutation(this Sdk4meClient client, TranslationCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new TranslationCreateMutation(input, new TranslationQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new translation.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The translation response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<TranslationCreatePayload> Mutation(this Sdk4meClient client, TranslationCreateInput input, TranslationQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new TranslationCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing translation.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<TranslationUpdatePayload> Mutation(this Sdk4meClient client, TranslationUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new TranslationUpdateMutation(input, new TranslationQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing translation.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The translation response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<TranslationUpdatePayload> Mutation(this Sdk4meClient client, TranslationUpdateInput input, TranslationQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new TranslationUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new UI extension.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<UiExtensionCreatePayload> Mutation(this Sdk4meClient client, UiExtensionCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new UiExtensionCreateMutation(input, new UiExtensionQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new UI extension.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The ui extension response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<UiExtensionCreatePayload> Mutation(this Sdk4meClient client, UiExtensionCreateInput input, UiExtensionQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new UiExtensionCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing UI extension.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<UiExtensionUpdatePayload> Mutation(this Sdk4meClient client, UiExtensionUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new UiExtensionUpdateMutation(input, new UiExtensionQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing UI extension.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The ui extension response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<UiExtensionUpdatePayload> Mutation(this Sdk4meClient client, UiExtensionUpdateInput input, UiExtensionQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new UiExtensionUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new waiting for customer follow-up.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<WaitingForCustomerFollowUpCreatePayload> Mutation(this Sdk4meClient client, WaitingForCustomerFollowUpCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new WaitingForCustomerFollowUpCreateMutation(input, new WaitingForCustomerFollowUpQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new waiting for customer follow-up.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The waiting for customer follow up response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<WaitingForCustomerFollowUpCreatePayload> Mutation(this Sdk4meClient client, WaitingForCustomerFollowUpCreateInput input, WaitingForCustomerFollowUpQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new WaitingForCustomerFollowUpCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing waiting for customer follow-up.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<WaitingForCustomerFollowUpUpdatePayload> Mutation(this Sdk4meClient client, WaitingForCustomerFollowUpUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new WaitingForCustomerFollowUpUpdateMutation(input, new WaitingForCustomerFollowUpQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing waiting for customer follow-up.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The waiting for customer follow up response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<WaitingForCustomerFollowUpUpdatePayload> Mutation(this Sdk4meClient client, WaitingForCustomerFollowUpUpdateInput input, WaitingForCustomerFollowUpQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new WaitingForCustomerFollowUpUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new webhook.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<WebhookCreatePayload> Mutation(this Sdk4meClient client, WebhookCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new WebhookCreateMutation(input, new WebhookQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new webhook.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The webhook response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<WebhookCreatePayload> Mutation(this Sdk4meClient client, WebhookCreateInput input, WebhookQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new WebhookCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Deletes a webhook.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<WebhookDeleteMutationPayload> Mutation(this Sdk4meClient client, WebhookDeleteMutationInput input, bool throwOnError = true)
        {
            return await client.Mutation(new WebhookDeleteMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new webhook policy.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<WebhookPolicyCreatePayload> Mutation(this Sdk4meClient client, WebhookPolicyCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new WebhookPolicyCreateMutation(input, new WebhookPolicyCreateResponseQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new webhook policy.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The webhook policy create response response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<WebhookPolicyCreatePayload> Mutation(this Sdk4meClient client, WebhookPolicyCreateInput input, WebhookPolicyCreateResponseQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new WebhookPolicyCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Deletes a webhook policy.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<WebhookPolicyDeleteMutationPayload> Mutation(this Sdk4meClient client, WebhookPolicyDeleteMutationInput input, bool throwOnError = true)
        {
            return await client.Mutation(new WebhookPolicyDeleteMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing webhook policy.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<WebhookPolicyUpdatePayload> Mutation(this Sdk4meClient client, WebhookPolicyUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new WebhookPolicyUpdateMutation(input, new WebhookPolicyQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing webhook policy.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The webhook policy response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<WebhookPolicyUpdatePayload> Mutation(this Sdk4meClient client, WebhookPolicyUpdateInput input, WebhookPolicyQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new WebhookPolicyUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing webhook.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<WebhookUpdatePayload> Mutation(this Sdk4meClient client, WebhookUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new WebhookUpdateMutation(input, new WebhookQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing webhook.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The webhook response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<WebhookUpdatePayload> Mutation(this Sdk4meClient client, WebhookUpdateInput input, WebhookQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new WebhookUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new workflow.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<WorkflowCreatePayload> Mutation(this Sdk4meClient client, WorkflowCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new WorkflowCreateMutation(input, new WorkflowQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new workflow.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The workflow response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<WorkflowCreatePayload> Mutation(this Sdk4meClient client, WorkflowCreateInput input, WorkflowQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new WorkflowCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new workflow template.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<WorkflowTemplateCreatePayload> Mutation(this Sdk4meClient client, WorkflowTemplateCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new WorkflowTemplateCreateMutation(input, new WorkflowTemplateQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new workflow template.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The workflow template response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<WorkflowTemplateCreatePayload> Mutation(this Sdk4meClient client, WorkflowTemplateCreateInput input, WorkflowTemplateQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new WorkflowTemplateCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing workflow template.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<WorkflowTemplateUpdatePayload> Mutation(this Sdk4meClient client, WorkflowTemplateUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new WorkflowTemplateUpdateMutation(input, new WorkflowTemplateQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing workflow template.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The workflow template response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<WorkflowTemplateUpdatePayload> Mutation(this Sdk4meClient client, WorkflowTemplateUpdateInput input, WorkflowTemplateQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new WorkflowTemplateUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Creates a new workflow type.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<WorkflowTypeCreatePayload> Mutation(this Sdk4meClient client, WorkflowTypeCreateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new WorkflowTypeCreateMutation(input, new WorkflowTypeQuery()), throwOnError);
        }

        /// <summary>
        /// Creates a new workflow type.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The workflow type response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<WorkflowTypeCreatePayload> Mutation(this Sdk4meClient client, WorkflowTypeCreateInput input, WorkflowTypeQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new WorkflowTypeCreateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing workflow type.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<WorkflowTypeUpdatePayload> Mutation(this Sdk4meClient client, WorkflowTypeUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new WorkflowTypeUpdateMutation(input, new WorkflowTypeQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing workflow type.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The workflow type response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<WorkflowTypeUpdatePayload> Mutation(this Sdk4meClient client, WorkflowTypeUpdateInput input, WorkflowTypeQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new WorkflowTypeUpdateMutation(input, query), throwOnError);
        }

        /// <summary>
        /// Updates an existing workflow.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        [Obsolete("Use Mutation(this Client client, MutationClass mutation, QueryClass responseQuery, bool throwOnError = true) instead. This method will be removed by February 2025.")]
        public static async Task<WorkflowUpdatePayload> Mutation(this Sdk4meClient client, WorkflowUpdateInput input, bool throwOnError = true)
        {
            return await client.Mutation(new WorkflowUpdateMutation(input, new WorkflowQuery()), throwOnError);
        }

        /// <summary>
        /// Updates an existing workflow.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="query">The workflow response query. Pagination is not supported on connections.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<WorkflowUpdatePayload> Mutation(this Sdk4meClient client, WorkflowUpdateInput input, WorkflowQuery query, bool throwOnError = true)
        {
            return await client.Mutation(new WorkflowUpdateMutation(input, query), throwOnError);
        }
    }
}
