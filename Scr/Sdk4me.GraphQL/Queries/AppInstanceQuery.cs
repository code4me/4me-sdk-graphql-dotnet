using System;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving AppInstance records.
    /// </summary>
    public class AppInstanceQuery : Query<AppInstanceQuery, AppInstanceField, AppInstanceView, AppInstanceFilter, AppInstanceOrderField>
    {
        /// <summary>
        /// Initialize a new app instance query instance.
        /// </summary>
        public AppInstanceQuery()
            : base("appInstances", typeof(AppInstance), true)
        {
        }

        /// <summary>
        /// Initialize a new app instance query instance.
        /// <br>Additional filters and views will be ignored.</br>
        /// </summary>
        /// <param name="id">The ID of the app instance.</param>
        public AppInstanceQuery(string id)
            : base("AppInstance", id, typeof(AppInstance), false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public AppInstanceQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// App offering (version) this instance is at.
        /// </summary>
        /// <param name="query">The app offering query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public AppInstanceQuery SelectAppOffering(AppOfferingQuery query)
        {
            query.FieldName = "appOffering";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Automation rules of this instance.
        /// </summary>
        /// <param name="query">The automation rule query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public AppInstanceQuery SelectAutomationRules(AutomationRuleQuery query)
        {
            query.FieldName = "automationRules";
            return Select(query);
        }

        /// <summary>
        /// Account this app instance is for.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public AppInstanceQuery SelectCustomerAccount(AccountQuery query)
        {
            query.FieldName = "customerAccount";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Contact person of customer regarding this app instance.
        /// </summary>
        /// <param name="query">The person query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public AppInstanceQuery SelectCustomerRepresentative(PersonQuery query)
        {
            query.FieldName = "customerRepresentative";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Values of custom fields.
        /// </summary>
        /// <param name="query">The custom field query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public AppInstanceQuery SelectCustomFields(CustomFieldQuery query)
        {
            query.FieldName = "customFields";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        /// <param name="query">The attachment query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public AppInstanceQuery SelectCustomFieldsAttachments(AttachmentQuery query)
        {
            query.FieldName = "customFieldsAttachments";
            return Select(query);
        }

        /// <summary>
        /// Webhook of this app instance.
        /// </summary>
        /// <param name="query">The webhook query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public AppInstanceQuery SelectWebhook(WebhookQuery query)
        {
            query.FieldName = "webhook";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The current policy used for the instance's webhook.
        /// </summary>
        /// <param name="query">The webhook policy query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public AppInstanceQuery SelectWebhookPolicy(WebhookPolicyQuery query)
        {
            query.FieldName = "webhookPolicy";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// <br>Filter the 'AppInstance' by their custom fields that have been marked as 'Filterable' in their UI Extension.</br>
        /// <br>Additional information is available on the <see href="https://developer.4me.com/graphql/input_object/appinstancecustomfilter/">4me developer site</see>.</br>
        /// </summary>
        /// <param name="name">The name of the custom filter (i.e. value of the data-filterable-name attribute of the field in the UI Extension).</param>
        /// <param name="filterOperator">The filter operator.</param>
        /// <param name="values">The filter values.
        /// <br>Use value <c>null</c> to indicate "None".</br>
        /// <br></br>
        /// <br>For "text" fields:</br>
        /// <br>• One can start the value with <c>~</c> to get partial matches (start with <c>'~</c> to match on a value starting with <c>~</c>).</br>
        /// <br></br>
        /// <br>For "number" and "time" fields:</br>
        /// <br>• One can start the value with <c>&lt;</c>, <c>&gt;</c>, <c>&lt;=</c>, <c>&gt;=</c> to get relative matches.</br>
        /// <br>• Times should be formatted as HH:mm:ss (e.g. <c>16:00:00</c>). The seconds part, <c>:ss</c>, is optional so <c>16:00</c> is also valid.</br>
        /// <br>• <c>&gt;{lower}&lt;{upper}</c> can be used to get matches where the value is more than '{lower}' and less than '{upper}'.</br>
        /// <br>• <c>&gt;={lower}&lt;={upper}</c> can be used to get matches where the value is between '{lower}' and '{upper}'.</br>
        /// <br>• <c>&gt;={lower}&lt;{upper}</c> can be used to get matches where the value is at least '{lower}' and less than '{upper}'.</br>
        /// <br></br>
        /// <br>For "date" and "date-time" fields:</br>
        /// <br>• One must supply a single value (and <c>null</c> is not supported).</br>
        /// <br>• Matches are always relative with an optional upper bound.</br>
        /// <br>• Dates should be formatted as <c>yyyy-MM-dd</c> (e.g. <c>2020-05-20</c>).</br>
        /// <br>• Date and time should be formatted as <c>yyyy-MM-ddTHH:mm:ssZ</c> (e.g. <c>2020-05-20T16:00:00Z</c>).</br>
        /// <br>• <c>&gt;={lower}</c> should be used to get matches where the value is at least '{lower}'.</br>
        /// <br>• <c>&gt;={lower}&lt;{upper}</c> can be used to get matches where the value is at least '{lower}' and before '{upper}'.</br>
        /// <br></br>
        /// <br>For "select" fields:</br>
        /// <br>• One must supply labels to match in the language of the account (i.e. not the value attributes of the HTML options).</br>
        /// <br>• Matches are case-sensitive.</br>
        /// </param>
        /// <exception cref="NullReferenceException"></exception>
        public AppInstanceQuery CustomFilter(string name, FilterOperator filterOperator, params string?[] values)
        {
            return AddCustomFilter(name, filterOperator, values);
        }
    }
}
