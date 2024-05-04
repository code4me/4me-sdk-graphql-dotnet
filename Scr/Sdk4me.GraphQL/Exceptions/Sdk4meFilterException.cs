using System;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Represent errors that occur on 4me filters.
    /// </summary>
    public sealed class Sdk4meFilterException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Sdk4meFilterException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public Sdk4meFilterException(string? message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Sdk4meFilterException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
        public Sdk4meFilterException(string? message, Exception? innerException)
            : base(message, innerException)
        {
        }
    }
}
