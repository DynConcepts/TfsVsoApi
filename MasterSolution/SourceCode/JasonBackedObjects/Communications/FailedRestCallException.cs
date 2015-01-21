using System;

namespace DynCon.OSI.JasonBackedObjects.Communications
{
    /// <summary>
    /// Class FailedRestCallException.
    /// </summary>
    internal class FailedRestCallException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FailedRestCallException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public FailedRestCallException(string message) : base(message)
        {
            
        }
    }
}