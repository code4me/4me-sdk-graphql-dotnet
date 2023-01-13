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
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<AgileBoardCreatePayload> Mutation(this Sdk4meClient client, AgileBoardCreateInput input)
        {
            return await client.Mutation(new AgileBoardCreateMutation(input));
        }

        /// <summary>
        /// Creates a new agile board.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<AgileBoardCreatePayload> Mutation(this Sdk4meClient client, AgileBoardCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new AgileBoardCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing agile board.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<AgileBoardUpdatePayload> Mutation(this Sdk4meClient client, AgileBoardUpdateInput input)
        {
            return await client.Mutation(new AgileBoardUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing agile board.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<AgileBoardUpdatePayload> Mutation(this Sdk4meClient client, AgileBoardUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new AgileBoardUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new application instance.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<AppInstanceCreatePayload> Mutation(this Sdk4meClient client, AppInstanceCreateInput input)
        {
            return await client.Mutation(new AppInstanceCreateMutation(input));
        }

        /// <summary>
        /// Creates a new application instance.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<AppInstanceCreatePayload> Mutation(this Sdk4meClient client, AppInstanceCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new AppInstanceCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing application instance.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<AppInstanceUpdatePayload> Mutation(this Sdk4meClient client, AppInstanceUpdateInput input)
        {
            return await client.Mutation(new AppInstanceUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing application instance.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<AppInstanceUpdatePayload> Mutation(this Sdk4meClient client, AppInstanceUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new AppInstanceUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new application offering automation rule.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<AppOfferingAutomationRuleCreatePayload> Mutation(this Sdk4meClient client, AppOfferingAutomationRuleCreateInput input)
        {
            return await client.Mutation(new AppOfferingAutomationRuleCreateMutation(input));
        }

        /// <summary>
        /// Creates a new application offering automation rule.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<AppOfferingAutomationRuleCreatePayload> Mutation(this Sdk4meClient client, AppOfferingAutomationRuleCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new AppOfferingAutomationRuleCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing application offering automation rule.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<AppOfferingAutomationRuleUpdatePayload> Mutation(this Sdk4meClient client, AppOfferingAutomationRuleUpdateInput input)
        {
            return await client.Mutation(new AppOfferingAutomationRuleUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing application offering automation rule.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<AppOfferingAutomationRuleUpdatePayload> Mutation(this Sdk4meClient client, AppOfferingAutomationRuleUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new AppOfferingAutomationRuleUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new application offering.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<AppOfferingCreatePayload> Mutation(this Sdk4meClient client, AppOfferingCreateInput input)
        {
            return await client.Mutation(new AppOfferingCreateMutation(input));
        }

        /// <summary>
        /// Creates a new application offering.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<AppOfferingCreatePayload> Mutation(this Sdk4meClient client, AppOfferingCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new AppOfferingCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing application offering.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<AppOfferingUpdatePayload> Mutation(this Sdk4meClient client, AppOfferingUpdateInput input)
        {
            return await client.Mutation(new AppOfferingUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing application offering.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<AppOfferingUpdatePayload> Mutation(this Sdk4meClient client, AppOfferingUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new AppOfferingUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new automation rule.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<AutomationRuleCreatePayload> Mutation(this Sdk4meClient client, AutomationRuleCreateInput input)
        {
            return await client.Mutation(new AutomationRuleCreateMutation(input));
        }

        /// <summary>
        /// Creates a new automation rule.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<AutomationRuleCreatePayload> Mutation(this Sdk4meClient client, AutomationRuleCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new AutomationRuleCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing automation rule.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<AutomationRuleUpdatePayload> Mutation(this Sdk4meClient client, AutomationRuleUpdateInput input)
        {
            return await client.Mutation(new AutomationRuleUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing automation rule.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<AutomationRuleUpdatePayload> Mutation(this Sdk4meClient client, AutomationRuleUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new AutomationRuleUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new broadcast.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<BroadcastCreatePayload> Mutation(this Sdk4meClient client, BroadcastCreateInput input)
        {
            return await client.Mutation(new BroadcastCreateMutation(input));
        }

        /// <summary>
        /// Creates a new broadcast.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<BroadcastCreatePayload> Mutation(this Sdk4meClient client, BroadcastCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new BroadcastCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing broadcast.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<BroadcastUpdatePayload> Mutation(this Sdk4meClient client, BroadcastUpdateInput input)
        {
            return await client.Mutation(new BroadcastUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing broadcast.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<BroadcastUpdatePayload> Mutation(this Sdk4meClient client, BroadcastUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new BroadcastUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new calendar.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<CalendarCreatePayload> Mutation(this Sdk4meClient client, CalendarCreateInput input)
        {
            return await client.Mutation(new CalendarCreateMutation(input));
        }

        /// <summary>
        /// Creates a new calendar.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<CalendarCreatePayload> Mutation(this Sdk4meClient client, CalendarCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new CalendarCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing calendar.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<CalendarUpdatePayload> Mutation(this Sdk4meClient client, CalendarUpdateInput input)
        {
            return await client.Mutation(new CalendarUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing calendar.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<CalendarUpdatePayload> Mutation(this Sdk4meClient client, CalendarUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new CalendarUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new configuration item. **Important**: To facilitate integrations with discovery tools, the create is treated as an update in case the provided `name` or `label` is already used by an inactive configuration item in the same account.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ConfigurationItemCreatePayload> Mutation(this Sdk4meClient client, ConfigurationItemCreateInput input)
        {
            return await client.Mutation(new ConfigurationItemCreateMutation(input));
        }

        /// <summary>
        /// Creates a new configuration item. **Important**: To facilitate integrations with discovery tools, the create is treated as an update in case the provided `name` or `label` is already used by an inactive configuration item in the same account.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ConfigurationItemCreatePayload> Mutation(this Sdk4meClient client, ConfigurationItemCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new ConfigurationItemCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing configuration item.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ConfigurationItemUpdatePayload> Mutation(this Sdk4meClient client, ConfigurationItemUpdateInput input)
        {
            return await client.Mutation(new ConfigurationItemUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing configuration item.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ConfigurationItemUpdatePayload> Mutation(this Sdk4meClient client, ConfigurationItemUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new ConfigurationItemUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new contract.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ContractCreatePayload> Mutation(this Sdk4meClient client, ContractCreateInput input)
        {
            return await client.Mutation(new ContractCreateMutation(input));
        }

        /// <summary>
        /// Creates a new contract.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ContractCreatePayload> Mutation(this Sdk4meClient client, ContractCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new ContractCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing contract.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ContractUpdatePayload> Mutation(this Sdk4meClient client, ContractUpdateInput input)
        {
            return await client.Mutation(new ContractUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing contract.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ContractUpdatePayload> Mutation(this Sdk4meClient client, ContractUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new ContractUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new custom collection.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<CustomCollectionCreatePayload> Mutation(this Sdk4meClient client, CustomCollectionCreateInput input)
        {
            return await client.Mutation(new CustomCollectionCreateMutation(input));
        }

        /// <summary>
        /// Creates a new custom collection.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<CustomCollectionCreatePayload> Mutation(this Sdk4meClient client, CustomCollectionCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new CustomCollectionCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new custom collection element.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<CustomCollectionElementCreatePayload> Mutation(this Sdk4meClient client, CustomCollectionElementCreateInput input)
        {
            return await client.Mutation(new CustomCollectionElementCreateMutation(input));
        }

        /// <summary>
        /// Creates a new custom collection element.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<CustomCollectionElementCreatePayload> Mutation(this Sdk4meClient client, CustomCollectionElementCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new CustomCollectionElementCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing custom collection element.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<CustomCollectionElementUpdatePayload> Mutation(this Sdk4meClient client, CustomCollectionElementUpdateInput input)
        {
            return await client.Mutation(new CustomCollectionElementUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing custom collection element.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<CustomCollectionElementUpdatePayload> Mutation(this Sdk4meClient client, CustomCollectionElementUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new CustomCollectionElementUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing custom collection.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<CustomCollectionUpdatePayload> Mutation(this Sdk4meClient client, CustomCollectionUpdateInput input)
        {
            return await client.Mutation(new CustomCollectionUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing custom collection.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<CustomCollectionUpdatePayload> Mutation(this Sdk4meClient client, CustomCollectionUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new CustomCollectionUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// <br>This mutation can be used to push at most 100 discovered configuration items to 4me at once.</br>
        /// <br>A more extensive description of this functionality can be found on the</br>
        /// <br><see href="https://developer.4me.com/v1/import/discovery_tools/#using-graphql">Discovery Tools page of the developer documentation</see>.</br>
        /// <br>The query will be executed in the background. Typically the following fields should be queried:</br>
        /// <br>- asyncQuery { resultUrl errorCount }</br>
        /// <br>- configurationItems { identifier sourceID }</br>
        /// <br>On initial submission the `configurationItems` field will be `null`.</br>
        /// <br>The `resultUrl` contains an expiring link to the location where the resulting JSON is available</br>
        /// <br>once the query has been executed.</br>
        /// <br>It is possible to poll the link every couple of seconds to check whether the query is completed.</br>
        /// <br>Initially the link will point to an empty JSON document (`{}`), once the query is completed it will contain</br>
        /// <br>the JSON result of this mutation.</br>
        /// <br>In the result both the `asyncQuery` and `configurationItems` fields as requested on submission are present.</br>
        /// <br>The `errorCount` can for example be used to see whether processing was successful (then it is `0`).</br>.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DiscoveredConfigurationItemsPayload> Mutation(this Sdk4meClient client, DiscoveredConfigurationItemsInput input)
        {
            return await client.Mutation(new DiscoveredConfigurationItemsMutation(input));
        }

        /// <summary>
        /// <br>This mutation can be used to push at most 100 discovered configuration items to 4me at once.</br>
        /// <br>A more extensive description of this functionality can be found on the</br>
        /// <br><see href="https://developer.4me.com/v1/import/discovery_tools/#using-graphql">Discovery Tools page of the developer documentation</see>.</br>
        /// <br>The query will be executed in the background. Typically the following fields should be queried:</br>
        /// <br>- asyncQuery { resultUrl errorCount }</br>
        /// <br>- configurationItems { identifier sourceID }</br>
        /// <br>On initial submission the `configurationItems` field will be `null`.</br>
        /// <br>The `resultUrl` contains an expiring link to the location where the resulting JSON is available</br>
        /// <br>once the query has been executed.</br>
        /// <br>It is possible to poll the link every couple of seconds to check whether the query is completed.</br>
        /// <br>Initially the link will point to an empty JSON document (`{}`), once the query is completed it will contain</br>
        /// <br>the JSON result of this mutation.</br>
        /// <br>In the result both the `asyncQuery` and `configurationItems` fields as requested on submission are present.</br>
        /// <br>The `errorCount` can for example be used to see whether processing was successful (then it is `0`).</br>.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<DiscoveredConfigurationItemsPayload> Mutation(this Sdk4meClient client, DiscoveredConfigurationItemsInput input, bool throwOnError)
        {
            return await client.Mutation(new DiscoveredConfigurationItemsMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new effort class.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<EffortClassCreatePayload> Mutation(this Sdk4meClient client, EffortClassCreateInput input)
        {
            return await client.Mutation(new EffortClassCreateMutation(input));
        }

        /// <summary>
        /// Creates a new effort class.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<EffortClassCreatePayload> Mutation(this Sdk4meClient client, EffortClassCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new EffortClassCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing effort class.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<EffortClassUpdatePayload> Mutation(this Sdk4meClient client, EffortClassUpdateInput input)
        {
            return await client.Mutation(new EffortClassUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing effort class.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<EffortClassUpdatePayload> Mutation(this Sdk4meClient client, EffortClassUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new EffortClassUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new first line support agreement.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<FirstLineSupportAgreementCreatePayload> Mutation(this Sdk4meClient client, FirstLineSupportAgreementCreateInput input)
        {
            return await client.Mutation(new FirstLineSupportAgreementCreateMutation(input));
        }

        /// <summary>
        /// Creates a new first line support agreement.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<FirstLineSupportAgreementCreatePayload> Mutation(this Sdk4meClient client, FirstLineSupportAgreementCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new FirstLineSupportAgreementCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing first line support agreement.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<FirstLineSupportAgreementUpdatePayload> Mutation(this Sdk4meClient client, FirstLineSupportAgreementUpdateInput input)
        {
            return await client.Mutation(new FirstLineSupportAgreementUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing first line support agreement.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<FirstLineSupportAgreementUpdatePayload> Mutation(this Sdk4meClient client, FirstLineSupportAgreementUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new FirstLineSupportAgreementUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new holiday.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<HolidayCreatePayload> Mutation(this Sdk4meClient client, HolidayCreateInput input)
        {
            return await client.Mutation(new HolidayCreateMutation(input));
        }

        /// <summary>
        /// Creates a new holiday.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<HolidayCreatePayload> Mutation(this Sdk4meClient client, HolidayCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new HolidayCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing holiday.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<HolidayUpdatePayload> Mutation(this Sdk4meClient client, HolidayUpdateInput input)
        {
            return await client.Mutation(new HolidayUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing holiday.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<HolidayUpdatePayload> Mutation(this Sdk4meClient client, HolidayUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new HolidayUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new invoice.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<InvoiceCreatePayload> Mutation(this Sdk4meClient client, InvoiceCreateInput input)
        {
            return await client.Mutation(new InvoiceCreateMutation(input));
        }

        /// <summary>
        /// Creates a new invoice.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<InvoiceCreatePayload> Mutation(this Sdk4meClient client, InvoiceCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new InvoiceCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing invoice.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<InvoiceUpdatePayload> Mutation(this Sdk4meClient client, InvoiceUpdateInput input)
        {
            return await client.Mutation(new InvoiceUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing invoice.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<InvoiceUpdatePayload> Mutation(this Sdk4meClient client, InvoiceUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new InvoiceUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new knowledge article.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<KnowledgeArticleCreatePayload> Mutation(this Sdk4meClient client, KnowledgeArticleCreateInput input)
        {
            return await client.Mutation(new KnowledgeArticleCreateMutation(input));
        }

        /// <summary>
        /// Creates a new knowledge article.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<KnowledgeArticleCreatePayload> Mutation(this Sdk4meClient client, KnowledgeArticleCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new KnowledgeArticleCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing knowledge article.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<KnowledgeArticleUpdatePayload> Mutation(this Sdk4meClient client, KnowledgeArticleUpdateInput input)
        {
            return await client.Mutation(new KnowledgeArticleUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing knowledge article.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<KnowledgeArticleUpdatePayload> Mutation(this Sdk4meClient client, KnowledgeArticleUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new KnowledgeArticleUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new organization.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<OrganizationCreatePayload> Mutation(this Sdk4meClient client, OrganizationCreateInput input)
        {
            return await client.Mutation(new OrganizationCreateMutation(input));
        }

        /// <summary>
        /// Creates a new organization.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<OrganizationCreatePayload> Mutation(this Sdk4meClient client, OrganizationCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new OrganizationCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing organization.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<OrganizationUpdatePayload> Mutation(this Sdk4meClient client, OrganizationUpdateInput input)
        {
            return await client.Mutation(new OrganizationUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing organization.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<OrganizationUpdatePayload> Mutation(this Sdk4meClient client, OrganizationUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new OrganizationUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new out of office period.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<OutOfOfficePeriodCreatePayload> Mutation(this Sdk4meClient client, OutOfOfficePeriodCreateInput input)
        {
            return await client.Mutation(new OutOfOfficePeriodCreateMutation(input));
        }

        /// <summary>
        /// Creates a new out of office period.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<OutOfOfficePeriodCreatePayload> Mutation(this Sdk4meClient client, OutOfOfficePeriodCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new OutOfOfficePeriodCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing out of office period.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<OutOfOfficePeriodUpdatePayload> Mutation(this Sdk4meClient client, OutOfOfficePeriodUpdateInput input)
        {
            return await client.Mutation(new OutOfOfficePeriodUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing out of office period.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<OutOfOfficePeriodUpdatePayload> Mutation(this Sdk4meClient client, OutOfOfficePeriodUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new OutOfOfficePeriodUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new PDF design.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<PdfDesignCreatePayload> Mutation(this Sdk4meClient client, PdfDesignCreateInput input)
        {
            return await client.Mutation(new PdfDesignCreateMutation(input));
        }

        /// <summary>
        /// Creates a new PDF design.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<PdfDesignCreatePayload> Mutation(this Sdk4meClient client, PdfDesignCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new PdfDesignCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing PDF design.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<PdfDesignUpdatePayload> Mutation(this Sdk4meClient client, PdfDesignUpdateInput input)
        {
            return await client.Mutation(new PdfDesignUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing PDF design.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<PdfDesignUpdatePayload> Mutation(this Sdk4meClient client, PdfDesignUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new PdfDesignUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new person.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<PersonCreatePayload> Mutation(this Sdk4meClient client, PersonCreateInput input)
        {
            return await client.Mutation(new PersonCreateMutation(input));
        }

        /// <summary>
        /// Creates a new person.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<PersonCreatePayload> Mutation(this Sdk4meClient client, PersonCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new PersonCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing person.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<PersonUpdatePayload> Mutation(this Sdk4meClient client, PersonUpdateInput input)
        {
            return await client.Mutation(new PersonUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing person.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<PersonUpdatePayload> Mutation(this Sdk4meClient client, PersonUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new PersonUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new problem.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ProblemCreatePayload> Mutation(this Sdk4meClient client, ProblemCreateInput input)
        {
            return await client.Mutation(new ProblemCreateMutation(input));
        }

        /// <summary>
        /// Creates a new problem.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ProblemCreatePayload> Mutation(this Sdk4meClient client, ProblemCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new ProblemCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing problem.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ProblemUpdatePayload> Mutation(this Sdk4meClient client, ProblemUpdateInput input)
        {
            return await client.Mutation(new ProblemUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing problem.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ProblemUpdatePayload> Mutation(this Sdk4meClient client, ProblemUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new ProblemUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new product backlog.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ProductBacklogCreatePayload> Mutation(this Sdk4meClient client, ProductBacklogCreateInput input)
        {
            return await client.Mutation(new ProductBacklogCreateMutation(input));
        }

        /// <summary>
        /// Creates a new product backlog.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ProductBacklogCreatePayload> Mutation(this Sdk4meClient client, ProductBacklogCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new ProductBacklogCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing product backlog.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ProductBacklogUpdatePayload> Mutation(this Sdk4meClient client, ProductBacklogUpdateInput input)
        {
            return await client.Mutation(new ProductBacklogUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing product backlog.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ProductBacklogUpdatePayload> Mutation(this Sdk4meClient client, ProductBacklogUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new ProductBacklogUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new product category.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ProductCategoryCreatePayload> Mutation(this Sdk4meClient client, ProductCategoryCreateInput input)
        {
            return await client.Mutation(new ProductCategoryCreateMutation(input));
        }

        /// <summary>
        /// Creates a new product category.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ProductCategoryCreatePayload> Mutation(this Sdk4meClient client, ProductCategoryCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new ProductCategoryCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing product category.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ProductCategoryUpdatePayload> Mutation(this Sdk4meClient client, ProductCategoryUpdateInput input)
        {
            return await client.Mutation(new ProductCategoryUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing product category.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ProductCategoryUpdatePayload> Mutation(this Sdk4meClient client, ProductCategoryUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new ProductCategoryUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new product.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ProductCreatePayload> Mutation(this Sdk4meClient client, ProductCreateInput input)
        {
            return await client.Mutation(new ProductCreateMutation(input));
        }

        /// <summary>
        /// Creates a new product.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ProductCreatePayload> Mutation(this Sdk4meClient client, ProductCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new ProductCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing product.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ProductUpdatePayload> Mutation(this Sdk4meClient client, ProductUpdateInput input)
        {
            return await client.Mutation(new ProductUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing product.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ProductUpdatePayload> Mutation(this Sdk4meClient client, ProductUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new ProductUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new project category.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ProjectCategoryCreatePayload> Mutation(this Sdk4meClient client, ProjectCategoryCreateInput input)
        {
            return await client.Mutation(new ProjectCategoryCreateMutation(input));
        }

        /// <summary>
        /// Creates a new project category.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ProjectCategoryCreatePayload> Mutation(this Sdk4meClient client, ProjectCategoryCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new ProjectCategoryCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing project category.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ProjectCategoryUpdatePayload> Mutation(this Sdk4meClient client, ProjectCategoryUpdateInput input)
        {
            return await client.Mutation(new ProjectCategoryUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing project category.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ProjectCategoryUpdatePayload> Mutation(this Sdk4meClient client, ProjectCategoryUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new ProjectCategoryUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new project.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ProjectCreatePayload> Mutation(this Sdk4meClient client, ProjectCreateInput input)
        {
            return await client.Mutation(new ProjectCreateMutation(input));
        }

        /// <summary>
        /// Creates a new project.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ProjectCreatePayload> Mutation(this Sdk4meClient client, ProjectCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new ProjectCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new project risk level.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ProjectRiskLevelCreatePayload> Mutation(this Sdk4meClient client, ProjectRiskLevelCreateInput input)
        {
            return await client.Mutation(new ProjectRiskLevelCreateMutation(input));
        }

        /// <summary>
        /// Creates a new project risk level.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ProjectRiskLevelCreatePayload> Mutation(this Sdk4meClient client, ProjectRiskLevelCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new ProjectRiskLevelCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing project risk level.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ProjectRiskLevelUpdatePayload> Mutation(this Sdk4meClient client, ProjectRiskLevelUpdateInput input)
        {
            return await client.Mutation(new ProjectRiskLevelUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing project risk level.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ProjectRiskLevelUpdatePayload> Mutation(this Sdk4meClient client, ProjectRiskLevelUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new ProjectRiskLevelUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new project task.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ProjectTaskCreatePayload> Mutation(this Sdk4meClient client, ProjectTaskCreateInput input)
        {
            return await client.Mutation(new ProjectTaskCreateMutation(input));
        }

        /// <summary>
        /// Creates a new project task.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ProjectTaskCreatePayload> Mutation(this Sdk4meClient client, ProjectTaskCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new ProjectTaskCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new project task template.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ProjectTaskTemplateCreatePayload> Mutation(this Sdk4meClient client, ProjectTaskTemplateCreateInput input)
        {
            return await client.Mutation(new ProjectTaskTemplateCreateMutation(input));
        }

        /// <summary>
        /// Creates a new project task template.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ProjectTaskTemplateCreatePayload> Mutation(this Sdk4meClient client, ProjectTaskTemplateCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new ProjectTaskTemplateCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing project task template.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ProjectTaskTemplateUpdatePayload> Mutation(this Sdk4meClient client, ProjectTaskTemplateUpdateInput input)
        {
            return await client.Mutation(new ProjectTaskTemplateUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing project task template.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ProjectTaskTemplateUpdatePayload> Mutation(this Sdk4meClient client, ProjectTaskTemplateUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new ProjectTaskTemplateUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing project task.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ProjectTaskUpdatePayload> Mutation(this Sdk4meClient client, ProjectTaskUpdateInput input)
        {
            return await client.Mutation(new ProjectTaskUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing project task.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ProjectTaskUpdatePayload> Mutation(this Sdk4meClient client, ProjectTaskUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new ProjectTaskUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new project template.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ProjectTemplateCreatePayload> Mutation(this Sdk4meClient client, ProjectTemplateCreateInput input)
        {
            return await client.Mutation(new ProjectTemplateCreateMutation(input));
        }

        /// <summary>
        /// Creates a new project template.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ProjectTemplateCreatePayload> Mutation(this Sdk4meClient client, ProjectTemplateCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new ProjectTemplateCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing project template.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ProjectTemplateUpdatePayload> Mutation(this Sdk4meClient client, ProjectTemplateUpdateInput input)
        {
            return await client.Mutation(new ProjectTemplateUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing project template.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ProjectTemplateUpdatePayload> Mutation(this Sdk4meClient client, ProjectTemplateUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new ProjectTemplateUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing project.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ProjectUpdatePayload> Mutation(this Sdk4meClient client, ProjectUpdateInput input)
        {
            return await client.Mutation(new ProjectUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing project.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ProjectUpdatePayload> Mutation(this Sdk4meClient client, ProjectUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new ProjectUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new release.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ReleaseCreatePayload> Mutation(this Sdk4meClient client, ReleaseCreateInput input)
        {
            return await client.Mutation(new ReleaseCreateMutation(input));
        }

        /// <summary>
        /// Creates a new release.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ReleaseCreatePayload> Mutation(this Sdk4meClient client, ReleaseCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new ReleaseCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing release.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ReleaseUpdatePayload> Mutation(this Sdk4meClient client, ReleaseUpdateInput input)
        {
            return await client.Mutation(new ReleaseUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing release.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ReleaseUpdatePayload> Mutation(this Sdk4meClient client, ReleaseUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new ReleaseUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new request.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<RequestCreatePayload> Mutation(this Sdk4meClient client, RequestCreateInput input)
        {
            return await client.Mutation(new RequestCreateMutation(input));
        }

        /// <summary>
        /// Creates a new request.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<RequestCreatePayload> Mutation(this Sdk4meClient client, RequestCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new RequestCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new request template.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<RequestTemplateCreatePayload> Mutation(this Sdk4meClient client, RequestTemplateCreateInput input)
        {
            return await client.Mutation(new RequestTemplateCreateMutation(input));
        }

        /// <summary>
        /// Creates a new request template.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<RequestTemplateCreatePayload> Mutation(this Sdk4meClient client, RequestTemplateCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new RequestTemplateCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing request template.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<RequestTemplateUpdatePayload> Mutation(this Sdk4meClient client, RequestTemplateUpdateInput input)
        {
            return await client.Mutation(new RequestTemplateUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing request template.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<RequestTemplateUpdatePayload> Mutation(this Sdk4meClient client, RequestTemplateUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new RequestTemplateUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing request.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<RequestUpdatePayload> Mutation(this Sdk4meClient client, RequestUpdateInput input)
        {
            return await client.Mutation(new RequestUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing request.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<RequestUpdatePayload> Mutation(this Sdk4meClient client, RequestUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new RequestUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new reservation.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ReservationCreatePayload> Mutation(this Sdk4meClient client, ReservationCreateInput input)
        {
            return await client.Mutation(new ReservationCreateMutation(input));
        }

        /// <summary>
        /// Creates a new reservation.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ReservationCreatePayload> Mutation(this Sdk4meClient client, ReservationCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new ReservationCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new reservation offering.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ReservationOfferingCreatePayload> Mutation(this Sdk4meClient client, ReservationOfferingCreateInput input)
        {
            return await client.Mutation(new ReservationOfferingCreateMutation(input));
        }

        /// <summary>
        /// Creates a new reservation offering.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ReservationOfferingCreatePayload> Mutation(this Sdk4meClient client, ReservationOfferingCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new ReservationOfferingCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing reservation offering.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ReservationOfferingUpdatePayload> Mutation(this Sdk4meClient client, ReservationOfferingUpdateInput input)
        {
            return await client.Mutation(new ReservationOfferingUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing reservation offering.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ReservationOfferingUpdatePayload> Mutation(this Sdk4meClient client, ReservationOfferingUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new ReservationOfferingUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing reservation.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ReservationUpdatePayload> Mutation(this Sdk4meClient client, ReservationUpdateInput input)
        {
            return await client.Mutation(new ReservationUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing reservation.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ReservationUpdatePayload> Mutation(this Sdk4meClient client, ReservationUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new ReservationUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new risk.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<RiskCreatePayload> Mutation(this Sdk4meClient client, RiskCreateInput input)
        {
            return await client.Mutation(new RiskCreateMutation(input));
        }

        /// <summary>
        /// Creates a new risk.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<RiskCreatePayload> Mutation(this Sdk4meClient client, RiskCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new RiskCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new risk severity.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<RiskSeverityCreatePayload> Mutation(this Sdk4meClient client, RiskSeverityCreateInput input)
        {
            return await client.Mutation(new RiskSeverityCreateMutation(input));
        }

        /// <summary>
        /// Creates a new risk severity.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<RiskSeverityCreatePayload> Mutation(this Sdk4meClient client, RiskSeverityCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new RiskSeverityCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing risk severity.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<RiskSeverityUpdatePayload> Mutation(this Sdk4meClient client, RiskSeverityUpdateInput input)
        {
            return await client.Mutation(new RiskSeverityUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing risk severity.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<RiskSeverityUpdatePayload> Mutation(this Sdk4meClient client, RiskSeverityUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new RiskSeverityUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing risk.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<RiskUpdatePayload> Mutation(this Sdk4meClient client, RiskUpdateInput input)
        {
            return await client.Mutation(new RiskUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing risk.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<RiskUpdatePayload> Mutation(this Sdk4meClient client, RiskUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new RiskUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new scrum workspace.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ScrumWorkspaceCreatePayload> Mutation(this Sdk4meClient client, ScrumWorkspaceCreateInput input)
        {
            return await client.Mutation(new ScrumWorkspaceCreateMutation(input));
        }

        /// <summary>
        /// Creates a new scrum workspace.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ScrumWorkspaceCreatePayload> Mutation(this Sdk4meClient client, ScrumWorkspaceCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new ScrumWorkspaceCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing scrum workspace.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ScrumWorkspaceUpdatePayload> Mutation(this Sdk4meClient client, ScrumWorkspaceUpdateInput input)
        {
            return await client.Mutation(new ScrumWorkspaceUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing scrum workspace.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ScrumWorkspaceUpdatePayload> Mutation(this Sdk4meClient client, ScrumWorkspaceUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new ScrumWorkspaceUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new service category.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ServiceCategoryCreatePayload> Mutation(this Sdk4meClient client, ServiceCategoryCreateInput input)
        {
            return await client.Mutation(new ServiceCategoryCreateMutation(input));
        }

        /// <summary>
        /// Creates a new service category.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ServiceCategoryCreatePayload> Mutation(this Sdk4meClient client, ServiceCategoryCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new ServiceCategoryCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing service category.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ServiceCategoryUpdatePayload> Mutation(this Sdk4meClient client, ServiceCategoryUpdateInput input)
        {
            return await client.Mutation(new ServiceCategoryUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing service category.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ServiceCategoryUpdatePayload> Mutation(this Sdk4meClient client, ServiceCategoryUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new ServiceCategoryUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new service.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ServiceCreatePayload> Mutation(this Sdk4meClient client, ServiceCreateInput input)
        {
            return await client.Mutation(new ServiceCreateMutation(input));
        }

        /// <summary>
        /// Creates a new service.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ServiceCreatePayload> Mutation(this Sdk4meClient client, ServiceCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new ServiceCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new service instance.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ServiceInstanceCreatePayload> Mutation(this Sdk4meClient client, ServiceInstanceCreateInput input)
        {
            return await client.Mutation(new ServiceInstanceCreateMutation(input));
        }

        /// <summary>
        /// Creates a new service instance.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ServiceInstanceCreatePayload> Mutation(this Sdk4meClient client, ServiceInstanceCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new ServiceInstanceCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing service instance.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ServiceInstanceUpdatePayload> Mutation(this Sdk4meClient client, ServiceInstanceUpdateInput input)
        {
            return await client.Mutation(new ServiceInstanceUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing service instance.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ServiceInstanceUpdatePayload> Mutation(this Sdk4meClient client, ServiceInstanceUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new ServiceInstanceUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new service level agreement.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ServiceLevelAgreementCreatePayload> Mutation(this Sdk4meClient client, ServiceLevelAgreementCreateInput input)
        {
            return await client.Mutation(new ServiceLevelAgreementCreateMutation(input));
        }

        /// <summary>
        /// Creates a new service level agreement.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ServiceLevelAgreementCreatePayload> Mutation(this Sdk4meClient client, ServiceLevelAgreementCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new ServiceLevelAgreementCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing service level agreement.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ServiceLevelAgreementUpdatePayload> Mutation(this Sdk4meClient client, ServiceLevelAgreementUpdateInput input)
        {
            return await client.Mutation(new ServiceLevelAgreementUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing service level agreement.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ServiceLevelAgreementUpdatePayload> Mutation(this Sdk4meClient client, ServiceLevelAgreementUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new ServiceLevelAgreementUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new service offering.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ServiceOfferingCreatePayload> Mutation(this Sdk4meClient client, ServiceOfferingCreateInput input)
        {
            return await client.Mutation(new ServiceOfferingCreateMutation(input));
        }

        /// <summary>
        /// Creates a new service offering.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ServiceOfferingCreatePayload> Mutation(this Sdk4meClient client, ServiceOfferingCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new ServiceOfferingCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing service offering.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ServiceOfferingUpdatePayload> Mutation(this Sdk4meClient client, ServiceOfferingUpdateInput input)
        {
            return await client.Mutation(new ServiceOfferingUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing service offering.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ServiceOfferingUpdatePayload> Mutation(this Sdk4meClient client, ServiceOfferingUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new ServiceOfferingUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing service.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ServiceUpdatePayload> Mutation(this Sdk4meClient client, ServiceUpdateInput input)
        {
            return await client.Mutation(new ServiceUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing service.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ServiceUpdatePayload> Mutation(this Sdk4meClient client, ServiceUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new ServiceUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new shop article.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ShopArticleCreatePayload> Mutation(this Sdk4meClient client, ShopArticleCreateInput input)
        {
            return await client.Mutation(new ShopArticleCreateMutation(input));
        }

        /// <summary>
        /// Creates a new shop article.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ShopArticleCreatePayload> Mutation(this Sdk4meClient client, ShopArticleCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new ShopArticleCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing shop article.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ShopArticleUpdatePayload> Mutation(this Sdk4meClient client, ShopArticleUpdateInput input)
        {
            return await client.Mutation(new ShopArticleUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing shop article.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ShopArticleUpdatePayload> Mutation(this Sdk4meClient client, ShopArticleUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new ShopArticleUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new shop order line.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ShopOrderLineCreatePayload> Mutation(this Sdk4meClient client, ShopOrderLineCreateInput input)
        {
            return await client.Mutation(new ShopOrderLineCreateMutation(input));
        }

        /// <summary>
        /// Creates a new shop order line.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ShopOrderLineCreatePayload> Mutation(this Sdk4meClient client, ShopOrderLineCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new ShopOrderLineCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing shop order line.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ShopOrderLineUpdatePayload> Mutation(this Sdk4meClient client, ShopOrderLineUpdateInput input)
        {
            return await client.Mutation(new ShopOrderLineUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing shop order line.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ShopOrderLineUpdatePayload> Mutation(this Sdk4meClient client, ShopOrderLineUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new ShopOrderLineUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new short URL.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ShortUrlCreatePayload> Mutation(this Sdk4meClient client, ShortUrlCreateInput input)
        {
            return await client.Mutation(new ShortUrlCreateMutation(input));
        }

        /// <summary>
        /// Creates a new short URL.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ShortUrlCreatePayload> Mutation(this Sdk4meClient client, ShortUrlCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new ShortUrlCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing short URL.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ShortUrlUpdatePayload> Mutation(this Sdk4meClient client, ShortUrlUpdateInput input)
        {
            return await client.Mutation(new ShortUrlUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing short URL.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<ShortUrlUpdatePayload> Mutation(this Sdk4meClient client, ShortUrlUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new ShortUrlUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new site.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<SiteCreatePayload> Mutation(this Sdk4meClient client, SiteCreateInput input)
        {
            return await client.Mutation(new SiteCreateMutation(input));
        }

        /// <summary>
        /// Creates a new site.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<SiteCreatePayload> Mutation(this Sdk4meClient client, SiteCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new SiteCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing site.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<SiteUpdatePayload> Mutation(this Sdk4meClient client, SiteUpdateInput input)
        {
            return await client.Mutation(new SiteUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing site.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<SiteUpdatePayload> Mutation(this Sdk4meClient client, SiteUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new SiteUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new skill pool.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<SkillPoolCreatePayload> Mutation(this Sdk4meClient client, SkillPoolCreateInput input)
        {
            return await client.Mutation(new SkillPoolCreateMutation(input));
        }

        /// <summary>
        /// Creates a new skill pool.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<SkillPoolCreatePayload> Mutation(this Sdk4meClient client, SkillPoolCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new SkillPoolCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing skill pool.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<SkillPoolUpdatePayload> Mutation(this Sdk4meClient client, SkillPoolUpdateInput input)
        {
            return await client.Mutation(new SkillPoolUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing skill pool.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<SkillPoolUpdatePayload> Mutation(this Sdk4meClient client, SkillPoolUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new SkillPoolUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new service level agreement notification scheme.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<SlaNotificationSchemeCreatePayload> Mutation(this Sdk4meClient client, SlaNotificationSchemeCreateInput input)
        {
            return await client.Mutation(new SlaNotificationSchemeCreateMutation(input));
        }

        /// <summary>
        /// Creates a new service level agreement notification scheme.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<SlaNotificationSchemeCreatePayload> Mutation(this Sdk4meClient client, SlaNotificationSchemeCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new SlaNotificationSchemeCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing service level agreement notification scheme.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<SlaNotificationSchemeUpdatePayload> Mutation(this Sdk4meClient client, SlaNotificationSchemeUpdateInput input)
        {
            return await client.Mutation(new SlaNotificationSchemeUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing service level agreement notification scheme.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<SlaNotificationSchemeUpdatePayload> Mutation(this Sdk4meClient client, SlaNotificationSchemeUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new SlaNotificationSchemeUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new sprint.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<SprintCreatePayload> Mutation(this Sdk4meClient client, SprintCreateInput input)
        {
            return await client.Mutation(new SprintCreateMutation(input));
        }

        /// <summary>
        /// Creates a new sprint.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<SprintCreatePayload> Mutation(this Sdk4meClient client, SprintCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new SprintCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing sprint.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<SprintUpdatePayload> Mutation(this Sdk4meClient client, SprintUpdateInput input)
        {
            return await client.Mutation(new SprintUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing sprint.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<SprintUpdatePayload> Mutation(this Sdk4meClient client, SprintUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new SprintUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new survey.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<SurveyCreatePayload> Mutation(this Sdk4meClient client, SurveyCreateInput input)
        {
            return await client.Mutation(new SurveyCreateMutation(input));
        }

        /// <summary>
        /// Creates a new survey.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<SurveyCreatePayload> Mutation(this Sdk4meClient client, SurveyCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new SurveyCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new survey response.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<SurveyResponseCreatePayload> Mutation(this Sdk4meClient client, SurveyResponseCreateInput input)
        {
            return await client.Mutation(new SurveyResponseCreateMutation(input));
        }

        /// <summary>
        /// Creates a new survey response.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<SurveyResponseCreatePayload> Mutation(this Sdk4meClient client, SurveyResponseCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new SurveyResponseCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing survey response.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<SurveyResponseUpdatePayload> Mutation(this Sdk4meClient client, SurveyResponseUpdateInput input)
        {
            return await client.Mutation(new SurveyResponseUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing survey response.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<SurveyResponseUpdatePayload> Mutation(this Sdk4meClient client, SurveyResponseUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new SurveyResponseUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing survey.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<SurveyUpdatePayload> Mutation(this Sdk4meClient client, SurveyUpdateInput input)
        {
            return await client.Mutation(new SurveyUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing survey.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<SurveyUpdatePayload> Mutation(this Sdk4meClient client, SurveyUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new SurveyUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new task.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<TaskCreatePayload> Mutation(this Sdk4meClient client, TaskCreateInput input)
        {
            return await client.Mutation(new TaskCreateMutation(input));
        }

        /// <summary>
        /// Creates a new task.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<TaskCreatePayload> Mutation(this Sdk4meClient client, TaskCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new TaskCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new task template.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<TaskTemplateCreatePayload> Mutation(this Sdk4meClient client, TaskTemplateCreateInput input)
        {
            return await client.Mutation(new TaskTemplateCreateMutation(input));
        }

        /// <summary>
        /// Creates a new task template.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<TaskTemplateCreatePayload> Mutation(this Sdk4meClient client, TaskTemplateCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new TaskTemplateCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing task template.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<TaskTemplateUpdatePayload> Mutation(this Sdk4meClient client, TaskTemplateUpdateInput input)
        {
            return await client.Mutation(new TaskTemplateUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing task template.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<TaskTemplateUpdatePayload> Mutation(this Sdk4meClient client, TaskTemplateUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new TaskTemplateUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing task.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<TaskUpdatePayload> Mutation(this Sdk4meClient client, TaskUpdateInput input)
        {
            return await client.Mutation(new TaskUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing task.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<TaskUpdatePayload> Mutation(this Sdk4meClient client, TaskUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new TaskUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new team.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<TeamCreatePayload> Mutation(this Sdk4meClient client, TeamCreateInput input)
        {
            return await client.Mutation(new TeamCreateMutation(input));
        }

        /// <summary>
        /// Creates a new team.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<TeamCreatePayload> Mutation(this Sdk4meClient client, TeamCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new TeamCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing team.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<TeamUpdatePayload> Mutation(this Sdk4meClient client, TeamUpdateInput input)
        {
            return await client.Mutation(new TeamUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing team.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<TeamUpdatePayload> Mutation(this Sdk4meClient client, TeamUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new TeamUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new time allocation.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<TimeAllocationCreatePayload> Mutation(this Sdk4meClient client, TimeAllocationCreateInput input)
        {
            return await client.Mutation(new TimeAllocationCreateMutation(input));
        }

        /// <summary>
        /// Creates a new time allocation.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<TimeAllocationCreatePayload> Mutation(this Sdk4meClient client, TimeAllocationCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new TimeAllocationCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing time allocation.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<TimeAllocationUpdatePayload> Mutation(this Sdk4meClient client, TimeAllocationUpdateInput input)
        {
            return await client.Mutation(new TimeAllocationUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing time allocation.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<TimeAllocationUpdatePayload> Mutation(this Sdk4meClient client, TimeAllocationUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new TimeAllocationUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new time entry.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<TimeEntryCreatePayload> Mutation(this Sdk4meClient client, TimeEntryCreateInput input)
        {
            return await client.Mutation(new TimeEntryCreateMutation(input));
        }

        /// <summary>
        /// Creates a new time entry.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<TimeEntryCreatePayload> Mutation(this Sdk4meClient client, TimeEntryCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new TimeEntryCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing time entry.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<TimeEntryUpdatePayload> Mutation(this Sdk4meClient client, TimeEntryUpdateInput input)
        {
            return await client.Mutation(new TimeEntryUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing time entry.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<TimeEntryUpdatePayload> Mutation(this Sdk4meClient client, TimeEntryUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new TimeEntryUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new timesheet setting.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<TimesheetSettingCreatePayload> Mutation(this Sdk4meClient client, TimesheetSettingCreateInput input)
        {
            return await client.Mutation(new TimesheetSettingCreateMutation(input));
        }

        /// <summary>
        /// Creates a new timesheet setting.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<TimesheetSettingCreatePayload> Mutation(this Sdk4meClient client, TimesheetSettingCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new TimesheetSettingCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing timesheet setting.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<TimesheetSettingUpdatePayload> Mutation(this Sdk4meClient client, TimesheetSettingUpdateInput input)
        {
            return await client.Mutation(new TimesheetSettingUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing timesheet setting.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<TimesheetSettingUpdatePayload> Mutation(this Sdk4meClient client, TimesheetSettingUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new TimesheetSettingUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new translation.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<TranslationCreatePayload> Mutation(this Sdk4meClient client, TranslationCreateInput input)
        {
            return await client.Mutation(new TranslationCreateMutation(input));
        }

        /// <summary>
        /// Creates a new translation.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<TranslationCreatePayload> Mutation(this Sdk4meClient client, TranslationCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new TranslationCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing translation.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<TranslationUpdatePayload> Mutation(this Sdk4meClient client, TranslationUpdateInput input)
        {
            return await client.Mutation(new TranslationUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing translation.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<TranslationUpdatePayload> Mutation(this Sdk4meClient client, TranslationUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new TranslationUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new user interface extension.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<UiExtensionCreatePayload> Mutation(this Sdk4meClient client, UiExtensionCreateInput input)
        {
            return await client.Mutation(new UiExtensionCreateMutation(input));
        }

        /// <summary>
        /// Creates a new user interface extension.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<UiExtensionCreatePayload> Mutation(this Sdk4meClient client, UiExtensionCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new UiExtensionCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing user interface extension.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<UiExtensionUpdatePayload> Mutation(this Sdk4meClient client, UiExtensionUpdateInput input)
        {
            return await client.Mutation(new UiExtensionUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing user interface extension.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<UiExtensionUpdatePayload> Mutation(this Sdk4meClient client, UiExtensionUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new UiExtensionUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new webhook.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<WebhookCreatePayload> Mutation(this Sdk4meClient client, WebhookCreateInput input)
        {
            return await client.Mutation(new WebhookCreateMutation(input));
        }

        /// <summary>
        /// Creates a new webhook.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<WebhookCreatePayload> Mutation(this Sdk4meClient client, WebhookCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new WebhookCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new webhook policy.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<WebhookPolicyCreatePayload> Mutation(this Sdk4meClient client, WebhookPolicyCreateInput input)
        {
            return await client.Mutation(new WebhookPolicyCreateMutation(input));
        }

        /// <summary>
        /// Creates a new webhook policy.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<WebhookPolicyCreatePayload> Mutation(this Sdk4meClient client, WebhookPolicyCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new WebhookPolicyCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing webhook policy.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<WebhookPolicyUpdatePayload> Mutation(this Sdk4meClient client, WebhookPolicyUpdateInput input)
        {
            return await client.Mutation(new WebhookPolicyUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing webhook policy.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<WebhookPolicyUpdatePayload> Mutation(this Sdk4meClient client, WebhookPolicyUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new WebhookPolicyUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing webhook.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<WebhookUpdatePayload> Mutation(this Sdk4meClient client, WebhookUpdateInput input)
        {
            return await client.Mutation(new WebhookUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing webhook.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<WebhookUpdatePayload> Mutation(this Sdk4meClient client, WebhookUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new WebhookUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new workflow.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<WorkflowCreatePayload> Mutation(this Sdk4meClient client, WorkflowCreateInput input)
        {
            return await client.Mutation(new WorkflowCreateMutation(input));
        }

        /// <summary>
        /// Creates a new workflow.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<WorkflowCreatePayload> Mutation(this Sdk4meClient client, WorkflowCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new WorkflowCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new workflow template.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<WorkflowTemplateCreatePayload> Mutation(this Sdk4meClient client, WorkflowTemplateCreateInput input)
        {
            return await client.Mutation(new WorkflowTemplateCreateMutation(input));
        }

        /// <summary>
        /// Creates a new workflow template.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<WorkflowTemplateCreatePayload> Mutation(this Sdk4meClient client, WorkflowTemplateCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new WorkflowTemplateCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing workflow template.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<WorkflowTemplateUpdatePayload> Mutation(this Sdk4meClient client, WorkflowTemplateUpdateInput input)
        {
            return await client.Mutation(new WorkflowTemplateUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing workflow template.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<WorkflowTemplateUpdatePayload> Mutation(this Sdk4meClient client, WorkflowTemplateUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new WorkflowTemplateUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Creates a new workflow type.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<WorkflowTypeCreatePayload> Mutation(this Sdk4meClient client, WorkflowTypeCreateInput input)
        {
            return await client.Mutation(new WorkflowTypeCreateMutation(input));
        }

        /// <summary>
        /// Creates a new workflow type.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<WorkflowTypeCreatePayload> Mutation(this Sdk4meClient client, WorkflowTypeCreateInput input, bool throwOnError)
        {
            return await client.Mutation(new WorkflowTypeCreateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing workflow type.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<WorkflowTypeUpdatePayload> Mutation(this Sdk4meClient client, WorkflowTypeUpdateInput input)
        {
            return await client.Mutation(new WorkflowTypeUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing workflow type.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<WorkflowTypeUpdatePayload> Mutation(this Sdk4meClient client, WorkflowTypeUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new WorkflowTypeUpdateMutation(input), throwOnError);
        }

        /// <summary>
        /// Updates an existing workflow.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<WorkflowUpdatePayload> Mutation(this Sdk4meClient client, WorkflowUpdateInput input)
        {
            return await client.Mutation(new WorkflowUpdateMutation(input));
        }

        /// <summary>
        /// Updates an existing workflow.
        /// </summary>
        /// <param name="client">The <see cref="Sdk4meClient"/>.</param>
        /// <param name="input">The mutation to execute.</param>
        /// <param name="throwOnError">Throw an <see cref="Sdk4meException"/> when the mutation fails.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException"></exception>
        public static async Task<WorkflowUpdatePayload> Mutation(this Sdk4meClient client, WorkflowUpdateInput input, bool throwOnError)
        {
            return await client.Mutation(new WorkflowUpdateMutation(input), throwOnError);
        }
    }
}
