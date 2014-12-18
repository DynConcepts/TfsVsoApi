using System;

namespace DynCon.OSI.VSO.ReSTClient.Objects.Base
{
    /// <summary>
    /// Class NoReStAPIEquivilantException.
    /// </summary>
    public class NoReStAPIEquivilantException : NotImplementedException 
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NoReStAPIEquivilantException"/> class.
        /// </summary>
        public NoReStAPIEquivilantException() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NoReStAPIEquivilantException" /> class with a specified error message.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        public NoReStAPIEquivilantException(string message) : base(message) { }
    }
}
