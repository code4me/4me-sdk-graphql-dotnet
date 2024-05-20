using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Represent errors that occurs during 4me execution.
    /// </summary>
    public sealed class Sdk4meException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Sdk4meException"/> class with a specified error message.
        /// </summary>
        public Sdk4meException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Sdk4meException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public Sdk4meException(string? message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Sdk4meException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
        public Sdk4meException(string? message, Exception? innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Sdk4meException"/> class with a specified error message.
        /// </summary>
        /// <param name="error">The <see cref="JToken"/> object that contains the error.</param>
        public Sdk4meException(JToken? error)
            : base(GetResultFronJson(error))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Sdk4meException"/> class with a specified error message.
        /// </summary>
        /// <param name="error">The <see cref="JToken"/> object that contains the error.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
        public Sdk4meException(JToken? error, Exception? innerException)
            : base(GetResultFronJson(error), innerException)
        {
        }

        private static string? GetResultFronJson(JToken? error)
        {
            if (error != null)
            {
                if (error is JArray errorArray)
                {
                    return errorArray?.First?["message"]?.ToString();
                }
                else
                {
                    return error?.ToString(Formatting.Indented);
                }
            }
            return null;
        }
    }
}
