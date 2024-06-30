namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving ProductCategory records.
    /// </summary>
    public class ProductCategoryQuery : Query<ProductCategoryQuery, ProductCategoryField, DefaultView, ProductCategoryFilter, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new product category query instance.
        /// </summary>
        public ProductCategoryQuery()
            : base("productCategories", typeof(ProductCategory), true)
        {
        }

        /// <summary>
        /// Initialize a new product category query instance.
        /// <br>Additional filters and views will be ignored.</br>
        /// </summary>
        /// <param name="id">The ID of the product category.</param>
        public ProductCategoryQuery(string id)
            : base("ProductCategory", id, typeof(ProductCategory), false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ProductCategoryQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Products in this category.
        /// </summary>
        /// <param name="query">The product query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ProductCategoryQuery SelectProducts(ProductQuery query)
        {
            query.FieldName = "products";
            return Select(query);
        }

        /// <summary>
        /// Translations associated with this object.
        /// </summary>
        /// <param name="query">The translation query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ProductCategoryQuery SelectTranslations(TranslationQuery query)
        {
            query.FieldName = "translations";
            return Select(query);
        }

        /// <summary>
        /// UI extension that is linked to the product category.
        /// </summary>
        /// <param name="query">The ui extension query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ProductCategoryQuery SelectUiExtension(UiExtensionQuery query)
        {
            query.FieldName = "uiExtension";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
