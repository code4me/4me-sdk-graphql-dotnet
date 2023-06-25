namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving ProductCategory records.
    /// </summary>
    public class ProductCategoryQuery : Query<ProductCategoryQuery, ProductCategoryField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new product category query instance.
        /// </summary>
        public ProductCategoryQuery()
            : base("productCategories", typeof(ProductCategory), true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        public ProductCategoryQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Products in this category.
        /// </summary>
        public ProductCategoryQuery SelectProducts(ProductQuery query)
        {
            query.FieldName = "products";
            return Select(query);
        }

        /// <summary>
        /// Translations associated with this object.
        /// </summary>
        public ProductCategoryQuery SelectTranslations(TranslationQuery query)
        {
            query.FieldName = "translations";
            return Select(query);
        }

        /// <summary>
        /// UI extension that is linked to the product category.
        /// </summary>
        public ProductCategoryQuery SelectUiExtension(UiExtensionQuery query)
        {
            query.FieldName = "uiExtension";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
