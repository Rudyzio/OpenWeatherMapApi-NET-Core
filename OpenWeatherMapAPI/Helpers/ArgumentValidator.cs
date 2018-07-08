using System;

namespace Reveal.EmailTemplateHandler.Helpers
{
    internal static class ArgumentValidator
    {
        /// <summary>
        /// Verifies if the provided value has its content has null
        /// </summary>
        /// <param name="value">The object to be verified</param>
        /// <param name="name">The name of the object to be verified</param>
        /// <exception cref="System.ArgumentNullException">Thrown when the object has its value has null</exception>
        internal static void ArgumentNotNull(object value, string name)
        {
            if (value == null)
            {
                throw new ArgumentNullException(name);
            }
        }

        /// <summary>
        /// Verifies if the provided string has its content has null
        /// </summary>
        /// <param name="value">The string to be verified</param>
        /// <param name="name">The name of the string to be verified</param>
        /// <exception cref="System.ArgumentNullException">Thrown when the string has its value has null</exception>
        /// <exception cref="System.ArgumentException">Thrown when the string has its value has an empty string</exception>
        internal static void ArgumentStringNotEmpty(string value, string name)
        {
            ArgumentNotNull(value, name);

            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("String cannot be empty", name);
            }
        }
    }
}
