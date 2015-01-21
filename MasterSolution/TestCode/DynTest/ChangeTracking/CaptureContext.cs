using System;
using System.Collections.Generic;
using System.Linq;

namespace DynCon.OSI.DynTest.ChangeTracking
{
    /// <summary>
    ///     Class CaptureContext.
    /// </summary>
    internal class CaptureContext
    {
        /// <summary>
        ///     Adds the specified source.
        /// </summary>
        /// <param name="source">The source.</param>
        public void Add(object source)
        {
            var entry = new Entry {Source = source};
            r_Visited.Add(entry);
        }

        /// <summary>
        ///     Visiteds the specified source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Visited(object source)
        {
            var tmp = new Entry {Source = source};
            return r_Visited.Any(entry => entry.Equals(tmp));
        }

        /// <summary>
        ///     The r_ visited
        /// </summary>
        private readonly List<Entry> r_Visited = new List<Entry>();

        /// <summary>
        ///     Class Entry.
        /// </summary>
        private class Entry : IEquatable<Entry>
        {
            /// <summary>
            ///     Indicates whether the current object is equal to another object of the same type.
            /// </summary>
            /// <param name="other">An object to compare with this object.</param>
            /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
            public bool Equals(Entry other) { return ReferenceEquals(Source, other.Source); }

            /// <summary>
            ///     Gets or sets the source.
            /// </summary>
            /// <value>The source.</value>
            public object Source { get; set; }
        }
    }
}