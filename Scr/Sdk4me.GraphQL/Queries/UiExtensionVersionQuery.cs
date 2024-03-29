﻿namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="UiExtensionVersion">UiExtensionVersion</see> query.
    /// </summary>
    public class UiExtensionVersionQuery : Query<UiExtensionVersionQuery, UiExtensionVersionField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new ui extension version query instance.
        /// </summary>
        public UiExtensionVersionQuery()
            : base("", typeof(UiExtensionVersion), true)
        {
        }

        /// <summary>
        /// UI extension this version belongs to.
        /// </summary>
        public UiExtensionVersionQuery SelectUiExtension(UiExtensionQuery query)
        {
            query.FieldName = "uiExtension";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
