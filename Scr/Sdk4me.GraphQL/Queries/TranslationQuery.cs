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
        /// <para>
        /// <br>Use this method to cast different object types supporting <see cref="IHasTranslations"></see>.</br>
        /// <br>If any query parameter is not provided (defaults to null), a new instance of the respective query type is created with the <c>ID</c> field selected.</br>
        /// </para>
        /// </summary>
        public TranslationQuery SelectOwner(
            CustomCollectionElementQuery? customCollectionElementQuery = null,
            EmailTemplateQuery? emailTemplateQuery = null,
            KnowledgeArticleQuery? knowledgeArticleQuery = null,
            PdfDesignQuery? pdfDesignQuery = null,
            ProductCategoryQuery? productCategoryQuery = null,
            RequestTemplateQuery? requestTemplateQuery = null,
            RiskSeverityQuery? riskSeverityQuery = null,
            ServiceQuery? serviceQuery = null,
            ServiceCategoryQuery? serviceCategoryQuery = null,
            ServiceInstanceQuery? serviceInstanceQuery = null,
            SurveyQuery? surveyQuery = null,
            SurveyQuestionQuery? surveyQuestionQuery = null,
            TimeAllocationQuery? timeAllocationQuery = null,
            UiExtensionQuery? uiExtensionQuery = null,
            WorkflowTypeQuery? workflowTypeQuery = null)
        {
            customCollectionElementQuery ??= new CustomCollectionElementQuery().Select(CustomCollectionElementField.ID);
            TranslationQuery query = SelectOwner(customCollectionElementQuery);
            query.OnTypesQueries.Add("CustomCollectionElement", customCollectionElementQuery.Clone());

            emailTemplateQuery ??= new EmailTemplateQuery().Select(EmailTemplateField.ID);
            query = SelectOwner(emailTemplateQuery);
            query.OnTypesQueries.Add("EmailTemplate", emailTemplateQuery.Clone());

            knowledgeArticleQuery ??= new KnowledgeArticleQuery().Select(KnowledgeArticleField.ID);
            query = SelectOwner(knowledgeArticleQuery);
            query.OnTypesQueries.Add("KnowledgeArticle", knowledgeArticleQuery.Clone());

            pdfDesignQuery ??= new PdfDesignQuery().Select(PdfDesignField.ID);
            query = SelectOwner(pdfDesignQuery);
            query.OnTypesQueries.Add("PdfDesign", pdfDesignQuery.Clone());

            productCategoryQuery ??= new ProductCategoryQuery().Select(ProductCategoryField.ID);
            query = SelectOwner(productCategoryQuery);
            query.OnTypesQueries.Add("ProductCategory", productCategoryQuery.Clone());

            requestTemplateQuery ??= new RequestTemplateQuery().Select(RequestTemplateField.ID);
            query = SelectOwner(requestTemplateQuery);
            query.OnTypesQueries.Add("RequestTemplate", requestTemplateQuery.Clone());

            riskSeverityQuery ??= new RiskSeverityQuery().Select(RiskSeverityField.ID);
            query = SelectOwner(riskSeverityQuery);
            query.OnTypesQueries.Add("RiskSeverity", riskSeverityQuery.Clone());

            serviceQuery ??= new ServiceQuery().Select(ServiceField.ID);
            query = SelectOwner(serviceQuery);
            query.OnTypesQueries.Add("Service", serviceQuery.Clone());

            serviceCategoryQuery ??= new ServiceCategoryQuery().Select(ServiceCategoryField.ID);
            query = SelectOwner(serviceCategoryQuery);
            query.OnTypesQueries.Add("ServiceCategory", serviceCategoryQuery.Clone());

            serviceInstanceQuery ??= new ServiceInstanceQuery().Select(ServiceInstanceField.ID);
            query = SelectOwner(serviceInstanceQuery);
            query.OnTypesQueries.Add("ServiceInstance", serviceInstanceQuery.Clone());

            surveyQuery ??= new SurveyQuery().Select(SurveyField.ID);
            query = SelectOwner(surveyQuery);
            query.OnTypesQueries.Add("Survey", surveyQuery.Clone());

            surveyQuestionQuery ??= new SurveyQuestionQuery().Select(SurveyQuestionField.ID);
            query = SelectOwner(surveyQuestionQuery);
            query.OnTypesQueries.Add("SurveyQuestion", surveyQuestionQuery.Clone());

            timeAllocationQuery ??= new TimeAllocationQuery().Select(TimeAllocationField.ID);
            query = SelectOwner(timeAllocationQuery);
            query.OnTypesQueries.Add("TimeAllocation", timeAllocationQuery.Clone());

            uiExtensionQuery ??= new UiExtensionQuery().Select(UiExtensionField.ID);
            query = SelectOwner(uiExtensionQuery);
            query.OnTypesQueries.Add("UiExtension", uiExtensionQuery.Clone());

            workflowTypeQuery ??= new WorkflowTypeQuery().Select(WorkflowTypeField.ID);
            query = SelectOwner(workflowTypeQuery);
            query.OnTypesQueries.Add("WorkflowType", workflowTypeQuery.Clone());

            return query;
        }

        /// <summary>
        /// The record from which the translation is obtained.
        /// <para>
        /// <br>Use this method along with other <c>SelectOwner(IQuery)</c> calls to cast different object types supporting <see cref="IHasTranslations"></see>.</br>
        /// <br>If a specific type is not queried via <c>SelectRecord(IQuery)</c>, it defaults to a null object.</br>
        /// </para>
        /// </summary>
        public TranslationQuery SelectOwner(CustomCollectionElementQuery query)
        {
            query.FieldName = "owner";
            query.OnTypesQueries.Add("CustomCollectionElement", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record from which the translation is obtained.
        /// <para>
        /// <br>Use this method along with other <c>SelectOwner(IQuery)</c> calls to cast different object types supporting <see cref="IHasTranslations"></see>.</br>
        /// <br>If a specific type is not queried via <c>SelectRecord(IQuery)</c>, it defaults to a null object.</br>
        /// </para>
        /// </summary>
        public TranslationQuery SelectOwner(EmailTemplateQuery query)
        {
            query.FieldName = "owner";
            query.OnTypesQueries.Add("EmailTemplate", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record from which the translation is obtained.
        /// <para>
        /// <br>Use this method along with other <c>SelectOwner(IQuery)</c> calls to cast different object types supporting <see cref="IHasTranslations"></see>.</br>
        /// <br>If a specific type is not queried via <c>SelectRecord(IQuery)</c>, it defaults to a null object.</br>
        /// </para>
        /// </summary>
        public TranslationQuery SelectOwner(KnowledgeArticleQuery query)
        {
            query.FieldName = "owner";
            query.OnTypesQueries.Add("KnowledgeArticle", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record from which the translation is obtained.
        /// <para>
        /// <br>Use this method along with other <c>SelectOwner(IQuery)</c> calls to cast different object types supporting <see cref="IHasTranslations"></see>.</br>
        /// <br>If a specific type is not queried via <c>SelectRecord(IQuery)</c>, it defaults to a null object.</br>
        /// </para>
        /// </summary>
        public TranslationQuery SelectOwner(PdfDesignQuery query)
        {
            query.FieldName = "owner";
            query.OnTypesQueries.Add("PdfDesign", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record from which the translation is obtained.
        /// <para>
        /// <br>Use this method along with other <c>SelectOwner(IQuery)</c> calls to cast different object types supporting <see cref="IHasTranslations"></see>.</br>
        /// <br>If a specific type is not queried via <c>SelectRecord(IQuery)</c>, it defaults to a null object.</br>
        /// </para>
        /// </summary>
        public TranslationQuery SelectOwner(ProductCategoryQuery query)
        {
            query.FieldName = "owner";
            query.OnTypesQueries.Add("ProductCategory", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record from which the translation is obtained.
        /// <para>
        /// <br>Use this method along with other <c>SelectOwner(IQuery)</c> calls to cast different object types supporting <see cref="IHasTranslations"></see>.</br>
        /// <br>If a specific type is not queried via <c>SelectRecord(IQuery)</c>, it defaults to a null object.</br>
        /// </para>
        /// </summary>
        public TranslationQuery SelectOwner(RequestTemplateQuery query)
        {
            query.FieldName = "owner";
            query.OnTypesQueries.Add("RequestTemplate", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record from which the translation is obtained.
        /// <para>
        /// <br>Use this method along with other <c>SelectOwner(IQuery)</c> calls to cast different object types supporting <see cref="IHasTranslations"></see>.</br>
        /// <br>If a specific type is not queried via <c>SelectRecord(IQuery)</c>, it defaults to a null object.</br>
        /// </para>
        /// </summary>
        public TranslationQuery SelectOwner(RiskSeverityQuery query)
        {
            query.FieldName = "owner";
            query.OnTypesQueries.Add("RiskSeverity", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record from which the translation is obtained.
        /// <para>
        /// <br>Use this method along with other <c>SelectOwner(IQuery)</c> calls to cast different object types supporting <see cref="IHasTranslations"></see>.</br>
        /// <br>If a specific type is not queried via <c>SelectRecord(IQuery)</c>, it defaults to a null object.</br>
        /// </para>
        /// </summary>
        public TranslationQuery SelectOwner(ServiceQuery query)
        {
            query.FieldName = "owner";
            query.OnTypesQueries.Add("Service", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record from which the translation is obtained.
        /// <para>
        /// <br>Use this method along with other <c>SelectOwner(IQuery)</c> calls to cast different object types supporting <see cref="IHasTranslations"></see>.</br>
        /// <br>If a specific type is not queried via <c>SelectRecord(IQuery)</c>, it defaults to a null object.</br>
        /// </para>
        /// </summary>
        public TranslationQuery SelectOwner(ServiceCategoryQuery query)
        {
            query.FieldName = "owner";
            query.OnTypesQueries.Add("ServiceCategory", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record from which the translation is obtained.
        /// <para>
        /// <br>Use this method along with other <c>SelectOwner(IQuery)</c> calls to cast different object types supporting <see cref="IHasTranslations"></see>.</br>
        /// <br>If a specific type is not queried via <c>SelectRecord(IQuery)</c>, it defaults to a null object.</br>
        /// </para>
        /// </summary>
        public TranslationQuery SelectOwner(ServiceInstanceQuery query)
        {
            query.FieldName = "owner";
            query.OnTypesQueries.Add("ServiceInstance", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record from which the translation is obtained.
        /// <para>
        /// <br>Use this method along with other <c>SelectOwner(IQuery)</c> calls to cast different object types supporting <see cref="IHasTranslations"></see>.</br>
        /// <br>If a specific type is not queried via <c>SelectRecord(IQuery)</c>, it defaults to a null object.</br>
        /// </para>
        /// </summary>
        public TranslationQuery SelectOwner(SurveyQuery query)
        {
            query.FieldName = "owner";
            query.OnTypesQueries.Add("Survey", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record from which the translation is obtained.
        /// <para>
        /// <br>Use this method along with other <c>SelectOwner(IQuery)</c> calls to cast different object types supporting <see cref="IHasTranslations"></see>.</br>
        /// <br>If a specific type is not queried via <c>SelectRecord(IQuery)</c>, it defaults to a null object.</br>
        /// </para>
        /// </summary>
        public TranslationQuery SelectOwner(SurveyQuestionQuery query)
        {
            query.FieldName = "owner";
            query.OnTypesQueries.Add("SurveyQuestion", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record from which the translation is obtained.
        /// <para>
        /// <br>Use this method along with other <c>SelectOwner(IQuery)</c> calls to cast different object types supporting <see cref="IHasTranslations"></see>.</br>
        /// <br>If a specific type is not queried via <c>SelectRecord(IQuery)</c>, it defaults to a null object.</br>
        /// </para>
        /// </summary>
        public TranslationQuery SelectOwner(TimeAllocationQuery query)
        {
            query.FieldName = "owner";
            query.OnTypesQueries.Add("TimeAllocation", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record from which the translation is obtained.
        /// <para>
        /// <br>Use this method along with other <c>SelectOwner(IQuery)</c> calls to cast different object types supporting <see cref="IHasTranslations"></see>.</br>
        /// <br>If a specific type is not queried via <c>SelectRecord(IQuery)</c>, it defaults to a null object.</br>
        /// </para>
        /// </summary>
        public TranslationQuery SelectOwner(UiExtensionQuery query)
        {
            query.FieldName = "owner";
            query.OnTypesQueries.Add("UiExtension", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The record from which the translation is obtained.
        /// <para>
        /// <br>Use this method along with other <c>SelectOwner(IQuery)</c> calls to cast different object types supporting <see cref="IHasTranslations"></see>.</br>
        /// <br>If a specific type is not queried via <c>SelectRecord(IQuery)</c>, it defaults to a null object.</br>
        /// </para>
        /// </summary>
        public TranslationQuery SelectOwner(WorkflowTypeQuery query)
        {
            query.FieldName = "owner";
            query.OnTypesQueries.Add("WorkflowType", query.Clone());
            query.IsConnection = false;
            return Select(query);
        }
    }
}
