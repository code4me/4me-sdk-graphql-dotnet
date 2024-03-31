namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving Translation records.
    /// </summary>
    public class TranslationQuery : Query<TranslationQuery, TranslationField, TranslationView, TranslationOrderField>
    {
        /// <summary>
        /// Initialize a new translation query instance.
        /// </summary>
        public TranslationQuery()
            : base("translations", typeof(Translation), true)
        {
        }

        /// <summary>
        /// Initialize a new translation query instance.
        /// <br>Additional filters and views will be ignored.</br>
        /// </summary>
        /// <param name="id">The ID of the translation.</param>
        public TranslationQuery(string id)
            : base("Translation", id, typeof(Translation), false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        public TranslationQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record from which the translation is obtained.
        /// </summary>
        public TranslationQuery SelectOwner(CustomCollectionElementQuery query)
        {
            query.FieldName = "owner";
            query.OnType = "CustomCollectionElement";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record from which the translation is obtained.
        /// </summary>
        public TranslationQuery SelectOwner(EmailTemplateQuery query)
        {
            query.FieldName = "owner";
            query.OnType = "EmailTemplate";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record from which the translation is obtained.
        /// </summary>
        public TranslationQuery SelectOwner(KnowledgeArticleQuery query)
        {
            query.FieldName = "owner";
            query.OnType = "KnowledgeArticle";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record from which the translation is obtained.
        /// </summary>
        public TranslationQuery SelectOwner(PdfDesignQuery query)
        {
            query.FieldName = "owner";
            query.OnType = "PdfDesign";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record from which the translation is obtained.
        /// </summary>
        public TranslationQuery SelectOwner(ProductCategoryQuery query)
        {
            query.FieldName = "owner";
            query.OnType = "ProductCategory";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record from which the translation is obtained.
        /// </summary>
        public TranslationQuery SelectOwner(RequestTemplateQuery query)
        {
            query.FieldName = "owner";
            query.OnType = "RequestTemplate";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record from which the translation is obtained.
        /// </summary>
        public TranslationQuery SelectOwner(RiskSeverityQuery query)
        {
            query.FieldName = "owner";
            query.OnType = "RiskSeverity";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record from which the translation is obtained.
        /// </summary>
        public TranslationQuery SelectOwner(ServiceQuery query)
        {
            query.FieldName = "owner";
            query.OnType = "Service";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record from which the translation is obtained.
        /// </summary>
        public TranslationQuery SelectOwner(ServiceCategoryQuery query)
        {
            query.FieldName = "owner";
            query.OnType = "ServiceCategory";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record from which the translation is obtained.
        /// </summary>
        public TranslationQuery SelectOwner(ServiceInstanceQuery query)
        {
            query.FieldName = "owner";
            query.OnType = "ServiceInstance";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record from which the translation is obtained.
        /// </summary>
        public TranslationQuery SelectOwner(SurveyQuery query)
        {
            query.FieldName = "owner";
            query.OnType = "Survey";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record from which the translation is obtained.
        /// </summary>
        public TranslationQuery SelectOwner(SurveyQuestionQuery query)
        {
            query.FieldName = "owner";
            query.OnType = "SurveyQuestion";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record from which the translation is obtained.
        /// </summary>
        public TranslationQuery SelectOwner(TimeAllocationQuery query)
        {
            query.FieldName = "owner";
            query.OnType = "TimeAllocation";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record from which the translation is obtained.
        /// </summary>
        public TranslationQuery SelectOwner(UiExtensionQuery query)
        {
            query.FieldName = "owner";
            query.OnType = "UiExtension";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record from which the translation is obtained.
        /// </summary>
        public TranslationQuery SelectOwner(WorkflowTypeQuery query)
        {
            query.FieldName = "owner";
            query.OnType = "WorkflowType";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
