namespace Sdk4me.GraphQL
{
    /// <summary>
    /// A set of <see cref="FilterOperator"/> extension methods.
    /// </summary>
    public static class FilterOperatorExtension
    {
        /// <summary>
        /// Determines whether the specified operator is a common operator.
        /// Common operators include Equals, NotEquals, In, and NotIn.
        /// </summary>
        /// <param name="filterOperator">The filter operator to check.</param>
        /// <returns>True if the operator is a common operator; otherwise false.</returns>
        public static bool IsCommonOperator(this FilterOperator filterOperator)
        {
            return filterOperator == FilterOperator.Equals || filterOperator == FilterOperator.NotEquals || filterOperator == FilterOperator.In || filterOperator == FilterOperator.NotIn;
        }

        /// <summary>
        /// Determines whether the specified operator is a single-value DateTime operator.
        /// Single-value DateTime operators include LessThan, LessThanOrEqualsTo, GreaterThan, and GreaterThanOrEqualsTo.
        /// </summary>
        /// <param name="filterOperator">The filter operator to check.</param>
        /// <returns>True if the operator is a single-value DateTime operator; otherwise false.</returns>
        public static bool IsDateTimeSingleValueOperator(this FilterOperator filterOperator)
        {
            return filterOperator == FilterOperator.LessThan || filterOperator == FilterOperator.LessThanOrEqualsTo || filterOperator == FilterOperator.GreaterThan || filterOperator == FilterOperator.GreaterThanOrEqualsTo;
        }

        /// <summary>
        /// Determines whether the specified operator is a DateTime range operator.
        /// DateTime range operators include GreaterThanAndLessThan and GreaterThanOrEqualToAndLessThanOrEqualTo.
        /// </summary>
        /// <param name="filterOperator">The filter operator to check.</param>
        /// <returns>True if the operator is a DateTime range operator; otherwise false.</returns>
        public static bool IsDateTimeRangeOperator(this FilterOperator filterOperator)
        {
            return filterOperator == FilterOperator.GreaterThanAndLessThan || filterOperator == FilterOperator.GreaterThanOrEqualToAndLessThanOrEqualTo;
        }

        /// <summary>
        /// Determines whether the specified operator is a nullable operator.
        /// Nullable operators include Present and Empty.
        /// </summary>
        /// <param name="filterOperator">The filter operator to check.</param>
        /// <returns>True if the operator is a nullable operator; otherwise false.</returns>
        public static bool IsNullableOperator(this FilterOperator filterOperator)
        {
            return filterOperator == FilterOperator.Present || filterOperator == FilterOperator.Empty;
        }

        /// <summary>
        /// Determines whether the specified filter operator is a negation operator.
        /// Negation operators include NotEquals and NotIn.
        /// </summary>
        /// <param name="filterOperator">The filter operator to check.</param>
        /// <returns>True if the filter operator is a negation operator; otherwise false.</returns>
        public static bool IsNegateOperator(this FilterOperator filterOperator)
        {
            return filterOperator == FilterOperator.NotEquals || filterOperator == FilterOperator.NotIn;
        }
    }
}
