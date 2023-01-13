namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="HasTranslations">HasTranslations</see> query.
    /// </summary>
    public class HasTranslationsQuery : Query<HasTranslationsQuery, HasTranslationsField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new has translations query instance.
        /// </summary>
        public HasTranslationsQuery()
            : base("", typeof(HasTranslations), false)
        {
        }

        /// <summary>
        /// Translations associated with this object.
        /// </summary>
        public HasTranslationsQuery SelectTranslations(TranslationQuery query)
        {
            query.FieldName = "translations";
            return Select(query);
        }
    }
}
