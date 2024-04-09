﻿namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving Broadcast records.
    /// </summary>
    public class BroadcastQuery : Query<BroadcastQuery, BroadcastField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new broadcast query instance.
        /// </summary>
        public BroadcastQuery()
            : base("broadcasts", typeof(Broadcast), true)
        {
        }

        /// <summary>
        /// Initialize a new broadcast query instance.
        /// <br>Additional filters and views will be ignored.</br>
        /// </summary>
        /// <param name="id">The ID of the broadcast.</param>
        public BroadcastQuery(string id)
            : base("Broadcast", id, typeof(Broadcast), false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public BroadcastQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Used to select one or more customer organizations when the broadcast is to be displayed for the specialists of the account in requests that were received from the selected organizations. This field is available only when the "Specialists in requests from the following customers" visibility option is selected.
        /// </summary>
        /// <param name="query">The organization query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public BroadcastQuery SelectCustomers(OrganizationQuery query)
        {
            query.FieldName = "customers";
            return Select(query);
        }

        /// <summary>
        /// The email template used for the email broadcast. This email template needs to be of the type Send Email from Broadcast.
        /// </summary>
        /// <param name="query">The email template query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public BroadcastQuery SelectEmailTemplate(EmailTemplateQuery query)
        {
            query.FieldName = "emailTemplate";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Used to select the organizations, to which people belong, that need to see the broadcast.
        /// </summary>
        /// <param name="query">The organization query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public BroadcastQuery SelectOrganizations(OrganizationQuery query)
        {
            query.FieldName = "organizations";
            return Select(query);
        }

        /// <summary>
        /// Files and inline images linked to the Remarks field.
        /// </summary>
        /// <param name="query">The attachment query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public BroadcastQuery SelectRemarksAttachments(AttachmentQuery query)
        {
            query.FieldName = "remarksAttachments";
            return Select(query);
        }

        /// <summary>
        /// Grouped request to which customers can add request to indicate they are also affected.
        /// </summary>
        /// <param name="query">The request query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public BroadcastQuery SelectRequest(RequestQuery query)
        {
            query.FieldName = "request";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Used to select the service instances for which the people, who are covered for them by an active SLA, need to see the broadcast. This table field is available only when the "People covered for the following service instance(s)" visibility option is selected.
        /// </summary>
        /// <param name="query">The service instance query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public BroadcastQuery SelectServiceInstances(ServiceInstanceQuery query)
        {
            query.FieldName = "serviceInstances";
            return Select(query);
        }

        /// <summary>
        /// Used to select the sites for which people need to see the broadcast.
        /// </summary>
        /// <param name="query">The site query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public BroadcastQuery SelectSites(SiteQuery query)
        {
            query.FieldName = "sites";
            return Select(query);
        }

        /// <summary>
        /// Used to select the skill pools, to which people belong, that need to see the broadcast.
        /// </summary>
        /// <param name="query">The skill pool query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public BroadcastQuery SelectSkillPools(SkillPoolQuery query)
        {
            query.FieldName = "skillPools";
            return Select(query);
        }

        /// <summary>
        /// Used to select the service level agreements for which the customer representatives will receive the email broadcast. This is only available for broadcasts when the message type "email" is selected.
        /// </summary>
        /// <param name="query">The service level agreement query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public BroadcastQuery SelectSlas(ServiceLevelAgreementQuery query)
        {
            query.FieldName = "slas";
            return Select(query);
        }

        /// <summary>
        /// Used to select the teams which members need to see the broadcast. This table field is available only when the "Members of the following team(s)" visibility option is selected.
        /// </summary>
        /// <param name="query">The team query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public BroadcastQuery SelectTeams(TeamQuery query)
        {
            query.FieldName = "teams";
            return Select(query);
        }

        /// <summary>
        /// Broadcast's message in different languages.
        /// </summary>
        /// <param name="query">The broadcast translation query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public BroadcastQuery SelectTranslations(BroadcastTranslationQuery query)
        {
            query.FieldName = "translations";
            return Select(query);
        }
    }
}
