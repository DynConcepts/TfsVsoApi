using DynCon.OSI.VSO.ObjectModelClient.WrapperInterfaces;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.WrapperImplementations
{
    /// <summary>
    ///     Class RevisionCollectionWrapper.
    /// </summary>
    internal class RevisionCollectionWrapper : IRevisionCollectionOM
    {
        /// <summary>
        ///     Determines whether [contains] [the specified value].
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns><c>true</c> if [contains] [the specified value]; otherwise, <c>false</c>.</returns>
        public bool Contains(Revision value) { return r_Instance.Contains(value); }

        /// <summary>
        ///     Indexes the of.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>System.Int32.</returns>
        public int IndexOf(Revision value) { return r_Instance.IndexOf(value); }

        /// <summary>
        ///     Gets the count.
        /// </summary>
        /// <value>The count.</value>
        public int Count { get { return r_Instance.Count; } }

        /// <summary>
        ///     Gets the <see cref="Revision" /> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>Revision.</returns>
        public Revision this[int index] { get { return r_Instance[index]; } }

        /// <summary>
        ///     Initializes a new instance of the <see cref="RevisionCollectionWrapper" /> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        public RevisionCollectionWrapper(RevisionCollection instance) { r_Instance = instance; }

        /// <summary>
        ///     The _instance
        /// </summary>
        private readonly RevisionCollection r_Instance;
    }
}