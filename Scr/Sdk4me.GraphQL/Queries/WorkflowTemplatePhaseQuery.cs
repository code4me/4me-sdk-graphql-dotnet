namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="WorkflowTemplatePhase">WorkflowTemplatePhase</see> query.
    /// </summary>
    public class WorkflowTemplatePhaseQuery : Query<WorkflowTemplatePhaseQuery, WorkflowTemplatePhaseField, DefaultView, DefaultFilter, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new workflow template phase query instance.
        /// </summary>
        public WorkflowTemplatePhaseQuery()
            : base("", typeof(WorkflowTemplatePhase), true)
        {
        }

        /// <summary>
        /// Translations associated with this object.
        /// </summary>
        /// <param name="query">The translation query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public WorkflowTemplatePhaseQuery SelectTranslations(TranslationQuery query)
        {
            query.FieldName = "translations";
            return Select(query);
        }
    }
}
