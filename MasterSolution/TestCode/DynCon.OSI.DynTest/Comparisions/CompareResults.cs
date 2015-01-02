using System;
using System.Collections.Generic;

namespace DynCon.OSI.DynTest.Comparisions
{
    /// <summary>
    ///     Class CompareResults.
    /// </summary>
    public class CompareResults
    {
        /// <summary>
        ///     Logs the specified entry.
        /// </summary>
        /// <param name="entry">The entry.</param>
        public void Log(String entry) { r_Log.Add(entry); }

        /// <summary>
        ///     Marks as different.
        /// </summary>
        public void MarkAsDifferent() { m_AreEqual = true; }

        /// <summary>
        ///     Gets a value indicating whether [are equal].
        /// </summary>
        /// <value><c>true</c> if [are equal]; otherwise, <c>false</c>.</value>
        public bool AreEqual { get { return m_AreEqual; } }

        /// <summary>
        ///     Gets the messages.
        /// </summary>
        /// <value>The messages.</value>
        public List<String> Messages { get { return r_Log; } }

        /// <summary>
        ///     Gets or sets a value indicating whether [same instance].
        /// </summary>
        /// <value><c>true</c> if [same instance]; otherwise, <c>false</c>.</value>
        public bool SameInstance { get; set; }

        /// <summary>
        ///     The r_ log
        /// </summary>
        private readonly List<String> r_Log = new List<string>();

        /// <summary>
        ///     The m_ are equal
        /// </summary>
        private bool m_AreEqual = true;
    }
}