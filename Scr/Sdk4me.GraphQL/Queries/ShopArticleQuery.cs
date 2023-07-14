namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving ShopArticle records.
    /// </summary>
    public class ShopArticleQuery : Query<ShopArticleQuery, ShopArticleField, ShopArticleView, ShopArticleOrderField>
    {
        /// <summary>
        /// Initialize a new shop article query instance.
        /// </summary>
        public ShopArticleQuery()
            : base("shopArticles", typeof(ShopArticle), true)
        {
        }

        /// <summary>
        /// Initialize a new shop article query instance.
        /// <br>Additional filters and views will be ignored.</br>
        /// </summary>
        /// <param name="id">The ID of the shop article.</param>
        public ShopArticleQuery(string id)
            : base("ShopArticle", id, typeof(ShopArticle), false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        public ShopArticleQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Calendar that represents the work hours related to the fulfillment/delivery.
        /// </summary>
        public ShopArticleQuery SelectCalendar(CalendarQuery query)
        {
            query.FieldName = "calendar";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The request template used to order one of more units of this shop article.
        /// </summary>
        public ShopArticleQuery SelectFulfillmentTemplate(RequestTemplateQuery query)
        {
            query.FieldName = "fulfillmentTemplate";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Related product.
        /// </summary>
        public ShopArticleQuery SelectProduct(ProductQuery query)
        {
            query.FieldName = "product";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Information from the provider.
        /// </summary>
        public ShopArticleQuery SelectProviderShopArticle(ProviderShopArticleQuery query)
        {
            query.FieldName = "providerShopArticle";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// UI extension that is to be used when the shop article is ordered.
        /// </summary>
        public ShopArticleQuery SelectUiExtension(UiExtensionQuery query)
        {
            query.FieldName = "uiExtension";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
