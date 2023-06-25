namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving KnowledgeArticle records.
    /// </summary>
    public class KnowledgeArticleQuery : Query<KnowledgeArticleQuery, KnowledgeArticleField, KnowledgeArticleView, KnowledgeArticleOrderField>
    {
        /// <summary>
        /// Initialize a new knowledge article query instance.
        /// </summary>
        public KnowledgeArticleQuery()
            : base("knowledgeArticles", typeof(KnowledgeArticle), true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        public KnowledgeArticleQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The person who created the knowledge article.
        /// </summary>
        public KnowledgeArticleQuery SelectCreatedBy(PersonQuery query)
        {
            query.FieldName = "createdBy";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Values of custom fields.
        /// </summary>
        public KnowledgeArticleQuery SelectCustomFields(CustomFieldQuery query)
        {
            query.FieldName = "customFields";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        public KnowledgeArticleQuery SelectCustomFieldsAttachments(AttachmentQuery query)
        {
            query.FieldName = "customFieldsAttachments";
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to the Description field.
        /// </summary>
        public KnowledgeArticleQuery SelectDescriptionAttachments(AttachmentQuery query)
        {
            query.FieldName = "descriptionAttachments";
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to the Instructions field.
        /// </summary>
        public KnowledgeArticleQuery SelectInstructionsAttachments(AttachmentQuery query)
        {
            query.FieldName = "instructionsAttachments";
            return Select(query);
        }

        /// <summary>
        /// Requests linked to this knowledge article.
        /// </summary>
        public KnowledgeArticleQuery SelectRequests(RequestQuery query)
        {
            query.FieldName = "requests";
            return Select(query);
        }

        /// <summary>
        /// Service for which the knowledge article is made available.
        /// </summary>
        public KnowledgeArticleQuery SelectService(ServiceQuery query)
        {
            query.FieldName = "service";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Service instances linked to this knowledge article.
        /// </summary>
        public KnowledgeArticleQuery SelectServiceInstances(ServiceInstanceQuery query)
        {
            query.FieldName = "serviceInstances";
            return Select(query);
        }

        /// <summary>
        /// The knowledge article template that this knowledge article is based on.
        /// </summary>
        public KnowledgeArticleQuery SelectTemplate(KnowledgeArticleTemplateQuery query)
        {
            query.FieldName = "template";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Translations associated with this object.
        /// </summary>
        public KnowledgeArticleQuery SelectTranslations(TranslationQuery query)
        {
            query.FieldName = "translations";
            return Select(query);
        }

        /// <summary>
        /// The person who last updated the knowledge article.
        /// </summary>
        public KnowledgeArticleQuery SelectUpdatedBy(PersonQuery query)
        {
            query.FieldName = "updatedBy";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// <br>Filter the 'KnowledgeArticle' by their custom fields that have been marked as 'Filterable' in their UI Extension.</br>
        /// <br>Additional information is available on the <see href="https://developer.4me.com/graphql/input_object/knowledgearticlecustomfilter/">4me developer site</see>.</br>
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
        public KnowledgeArticleQuery CustomFilter(string name, FilterOperator filterOperator, params string?[] values)
        {
            return AddCustomFilter(name, filterOperator, values);
        }
    }
}
