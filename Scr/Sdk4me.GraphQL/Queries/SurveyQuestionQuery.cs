﻿namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="SurveyQuestion">SurveyQuestion</see> query.
    /// </summary>
    public class SurveyQuestionQuery : Query<SurveyQuestionQuery, SurveyQuestionField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new survey question query instance.
        /// </summary>
        public SurveyQuestionQuery()
            : base("", typeof(SurveyQuestion), true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        public SurveyQuestionQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Files and inline images linked to the Guidance field.
        /// </summary>
        public SurveyQuestionQuery SelectGuidanceAttachments(AttachmentQuery query)
        {
            query.FieldName = "guidanceAttachments";
            return Select(query);
        }

        /// <summary>
        /// Survey the question is part of.
        /// </summary>
        public SurveyQuestionQuery SelectSurvey(SurveyQuery query)
        {
            query.FieldName = "survey";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Translations associated with this object.
        /// </summary>
        public SurveyQuestionQuery SelectTranslations(TranslationQuery query)
        {
            query.FieldName = "translations";
            return Select(query);
        }
    }
}
