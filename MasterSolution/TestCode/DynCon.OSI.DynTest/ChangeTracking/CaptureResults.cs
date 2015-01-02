using System;
using System.Collections.Generic;

namespace DynCon.OSI.DynTest.ChangeTracking
{
    /// <summary>
    ///     Class CaptureResults.
    /// </summary>
    public class CaptureResults
    {
        /// <summary>
        ///     Logs the specified entry.
        /// </summary>
        /// <param name="entry">The entry.</param>
        public void Log(String entry) { r_Log.Add(entry); }

        /// <summary>
        ///     Registers the specified entry.
        /// </summary>
        /// <param name="entry">The entry.</param>
        public void Register(Element entry) { Elements.Add(entry.Path, entry); }

        /// <summary>
        ///     Gets the elements.
        /// </summary>
        /// <value>The elements.</value>
        public Dictionary<string, Element> Elements { get { return r_Elements; } }

        /// <summary>
        ///     Gets the messages.
        /// </summary>
        /// <value>The messages.</value>
        public List<String> Messages { get { return r_Log; } }

        /// <summary>
        ///     The r_ elements
        /// </summary>
        private readonly Dictionary<string, Element> r_Elements = new Dictionary<string, Element>();

        /// <summary>
        ///     The r_ log
        /// </summary>
        private readonly List<String> r_Log = new List<string>();
    }
}