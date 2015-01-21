using System;
using System.Collections.Generic;
using System.Linq;

namespace DynCon.OSI.DynTest.Comparisions
{
    /// <summary>
    ///     Class CompareContext.
    /// </summary>
    internal class CompareContext
    {
        /// <summary>
        ///     Adds the specified left.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        public void Add(object left, object right)
        {
            var entry = new Entry {Left = left, Right = right};
            m_Visited.Add(entry);
        }

        /// <summary>
        ///     Visiteds the specified left.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Visited(object left, object right)
        {
            var tmp = new Entry {Left = left, Right = right};
            return m_Visited.Any(entry => entry.Equals(tmp));
        }

        /// <summary>
        ///     The m_ visited
        /// </summary>
        private readonly List<Entry> m_Visited = new List<Entry>();

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
            public bool Equals(Entry other) { return ReferenceEquals(Left, other.Left) && ReferenceEquals(Right, other.Right); }

            /// <summary>
            ///     Gets or sets the left.
            /// </summary>
            /// <value>The left.</value>
            public object Left { get; set; }

            /// <summary>
            ///     Gets or sets the right.
            /// </summary>
            /// <value>The right.</value>
            public object Right { get; set; }
        }
    }
}