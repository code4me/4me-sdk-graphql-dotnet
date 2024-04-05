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
        /// <br>Use this method along with other <c>SelectOwner(IQuery)</c> calls to cast different object types supporting <see cref="IHasTranslations"></see>.</br>
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
        /// <br>Use this method along with other <c>SelectOwner(IQuery)</c> calls to cast different object types supporting <see cref="IHasTranslations"></see>.</br>
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
        /// <br>Use this method along with other <c>SelectOwner(IQuery)</c> calls to cast different object types supporting <see cref="IHasTranslations"></see>.</br>
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
        /// <br>Use this method along with other <c>SelectOwner(IQuery)</c> calls to cast different object types supporting <see cref="IHasTranslations"></see>.</br>
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
        /// <br>Use this method along with other <c>SelectOwner(IQuery)</c> calls to cast different object types supporting <see cref="IHasTranslations"></see>.</br>
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
        /// <br>Use this method along with other <c>SelectOwner(IQuery)</c> calls to cast different object types supporting <see cref="IHasTranslations"></see>.</br>
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
        /// <br>Use this method along with other <c>SelectOwner(IQuery)</c> calls to cast different object types supporting <see cref="IHasTranslations"></see>.</br>
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
        /// <br>Use this method along with other <c>SelectOwner(IQuery)</c> calls to cast different object types supporting <see cref="IHasTranslations"></see>.</br>
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
        /// <br>Use this method along with other <c>SelectOwner(IQuery)</c> calls to cast different object types supporting <see cref="IHasTranslations"></see>.</br>
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
        /// <br>Use this method along with other <c>SelectOwner(IQuery)</c> calls to cast different object types supporting <see cref="IHasTranslations"></see>.</br>
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
        /// <br>Use this method along with other <c>SelectOwner(IQuery)</c> calls to cast different object types supporting <see cref="IHasTranslations"></see>.</br>
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
        /// <br>Use this method along with other <c>SelectOwner(IQuery)</c> calls to cast different object types supporting <see cref="IHasTranslations"></see>.</br>
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
        /// <br>Use this method along with other <c>SelectOwner(IQuery)</c> calls to cast different object types supporting <see cref="IHasTranslations"></see>.</br>
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
        /// <br>Use this method along with other <c>SelectOwner(IQuery)</c> calls to cast different object types supporting <see cref="IHasTranslations"></see>.</br>
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
        /// <br>Use this method along with other <c>SelectOwner(IQuery)</c> calls to cast different object types supporting <see cref="IHasTranslations"></see>.</br>
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
