namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving AppOffering records.
    /// </summary>
    public class AppOfferingQuery : Query<AppOfferingQuery, AppOfferingField, AppOfferingView, AppOfferingOrderField>
    {
        /// <summary>
        /// Initialize a new application offering query instance.
        /// </summary>
        public AppOfferingQuery()
            : base("appOfferings", typeof(AppOffering), true)
        {
        }

        /// <summary>
        /// Instances of this application.
        /// </summary>
        public AppOfferingQuery SelectAppInstances(AppInstanceQuery query)
        {
            query.FieldName = "appInstances";
            return Select(query);
        }

        /// <summary>
        /// Automation rules of this application offering.
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
    }
}
