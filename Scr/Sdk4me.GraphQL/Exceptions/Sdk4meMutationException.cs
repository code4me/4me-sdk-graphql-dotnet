﻿using System;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Represent errors that occurs in a mutation.
    /// </summary>
    public sealed class Sdk4meMutationException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Sdk4meMutationException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public Sdk4meMutationException(string? message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Sdk4meMutationException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
        public Sdk4meMutationException(string? message, Exception? innerException)
            : base(message, innerException)
        {
        }
    }
}
