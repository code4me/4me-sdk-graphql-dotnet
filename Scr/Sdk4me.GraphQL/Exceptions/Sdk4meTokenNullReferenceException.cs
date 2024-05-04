using System;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Represent errors that occur on 4me token usage.
    /// </summary>
    public sealed class Sdk4meTokenNullReferenceException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Sdk4meTokenNullReferenceException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public Sdk4meTokenNullReferenceException(string? message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Sdk4meTokenNullReferenceException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
        public Sdk4meTokenNullReferenceException(string? message, Exception? innerException)
            : base(message, innerException)
        {
        }
    }
}
