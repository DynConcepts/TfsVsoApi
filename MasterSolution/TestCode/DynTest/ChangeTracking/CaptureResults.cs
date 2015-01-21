using System;
using System.Collections.Generic;
using System.Reflection;

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

        public List<KeyValuePair<string, Tuple<Object,EventInfo>>> Events { get { return r_Events; } }

        /// <summary>
        ///     The r_ elements
        /// </summary>
        private readonly Dictionary<string, Element> r_Elements = new Dictionary<string, Element>();

        /// <summary>
        ///     The r_ log
        /// </summary>
        private readonly List<String> r_Log = new List<string>();

        private readonly List<KeyValuePair<string, Tuple<Object, EventInfo>>> r_Events = new List<KeyValuePair<string, Tuple<Object, EventInfo>>>();


        public void Register(object source, Dictionary<string, EventInfo> events)
        {
            {
                foreach (var pair in events)
                    Events.Add(new KeyValuePair<string, Tuple<object, EventInfo>>(pair.Key, new Tuple<object, EventInfo>(source, pair.Value)));
            }
        }
    }
}