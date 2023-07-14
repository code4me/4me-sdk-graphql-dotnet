namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving AppOffering records.
    /// </summary>
    public class AppOfferingQuery : Query<AppOfferingQuery, AppOfferingField, AppOfferingView, AppOfferingOrderField>
    {
        /// <summary>
        /// Initialize a new app offering query instance.
        /// </summary>
        public AppOfferingQuery()
            : base("appOfferings", typeof(AppOffering), true)
        {
        }

        /// <summary>
        /// Initialize a new app offering query instance.
        /// <br>Additional filters and views will be ignored.</br>
        /// </summary>
        /// <param name="id">The ID of the app offering.</param>
        public AppOfferingQuery(string id)
            : base("AppOffering", id, typeof(AppOffering), false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        public AppOfferingQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Instances of this app.
        /// </summary>
        public AppOfferingQuery SelectAppInstances(AppInstanceQuery query)
        {
            query.FieldName = "appInstances";
            return Select(query);
        }

        /// <summary>
        /// Automation rules of this app offering.
        /// </summary>
        public AppOfferingQuery SelectAutomationRules(AppOfferingAutomationRuleQuery query)
        {
            query.FieldName = "automationRules";
            return Select(query);
        }

        /// <summary>
        /// Files and inline images linked to the Compliance field.
        /// </summary>
        public AppOfferingQuery SelectComplianceAttachments(AttachmentQuery query)
        {
            query.FieldName = "complianceAttachments";
            return Select(query);
        }

        /// <summary>
        /// Files and inline images linked to the Description field.
        /// </summary>
        public AppOfferingQuery SelectDescriptionAttachments(AttachmentQuery query)
        {
            query.FieldName = "descriptionAttachments";
            return Select(query);
        }

        /// <summary>
        /// Files and inline images linked to the Features field.
        /// </summary>
        public AppOfferingQuery SelectFeaturesAttachments(AttachmentQuery query)
        {
            query.FieldName = "featuresAttachments";
            return Select(query);
        }

        /// <summary>
        /// Scopes of this app offering.
        /// </summary>
        public AppOfferingQuery SelectScopes(AppOfferingScopeQuery query)
        {
            query.FieldName = "scopes";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Service instance that is linked to the app offering.
        /// </summary>
        public AppOfferingQuery SelectServiceInstance(ServiceInstanceQuery query)
        {
            query.FieldName = "serviceInstance";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// UI extension version that is linked to the app offering.
        /// </summary>
        public AppOfferingQuery SelectUiExtensionVersion(UiExtensionVersionQuery query)
        {
            query.FieldName = "uiExtensionVersion";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
