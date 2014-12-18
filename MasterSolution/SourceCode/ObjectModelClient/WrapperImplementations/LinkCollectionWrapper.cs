using System.Collections.Generic;
using DynCon.OSI.VSO.ObjectModelClient.WrapperInterfaces;
using DynCon.OSI.VSO.SharedInterfaces.Interfaces;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.WrapperImplementations
{
    /// <summary>
    ///     Class LinkCollectionWrapper.
    /// </summary>
    public class LinkCollectionWrapper : ILinkCollectionOM
    {
        /// <summary>
        ///     Adds the specified link.
        /// </summary>
        /// <param name="link">The link.</param>
        /// <returns>System.Int32.</returns>
        public int Add(ExternalLink link)
        {
            var retVal = r_Instance.Add(link);
            Update_List();
            return retVal;
        }

        /// <summary>
        /// Update_s the list.
        /// </summary>
        private void Update_List()
        {
            r_Items.Clear();
            foreach (Link item in r_Instance)
            {
                r_Items.Add(LinkWrapper.GetWrapper(item));
            }
        }

        /// <summary>
        ///     Adds the specified link.
        /// </summary>
        /// <param name="link">The link.</param>
        /// <returns>System.Int32.</returns>
        public int Add(Hyperlink link)
        {
            var retVal = r_Instance.Add(link);
            Update_List();
            return retVal;
        }

        /// <summary>
        ///     Adds the specified link.
        /// </summary>
        /// <param name="link">The link.</param>
        /// <returns>System.Int32.</returns>
        public int Add(Link link)
        {
            var retVal = r_Instance.Add(link);
            Update_List();
            return retVal;
        }

        /// <summary>
        ///     Adds the specified link.
        /// </summary>
        /// <param name="link">The link.</param>
        /// <returns>System.Int32.</returns>
        public int Add(RelatedLink link)
        {
            var retVal = r_Instance.Add(link);
            Update_List();
            return retVal;
        }

        /// <summary>
        ///     Clears this instance.
        /// </summary>
        public void Clear() { r_Instance.Clear(); Update_List(); }

        /// <summary>
        ///     Determines whether [contains] [the specified link].
        /// </summary>
        /// <param name="link">The link.</param>
        /// <returns><c>true</c> if [contains] [the specified link]; otherwise, <c>false</c>.</returns>
        public bool Contains(Link link) { return r_Instance.Contains(link); }

        /// <summary>
        ///     Indexes the of.
        /// </summary>
        /// <param name="link">The link.</param>
        /// <returns>System.Int32.</returns>
        public int IndexOf(Link link) { return r_Instance.IndexOf(link); }

        /// <summary>
        ///     Refreshes this instance.
        /// </summary>
        public void Refresh() { r_Instance.Refresh(); Update_List(); }

        /// <summary>
        ///     Removes the specified link.
        /// </summary>
        /// <param name="link">The link.</param>
        public void Remove(Link link) { r_Instance.Remove(link); Update_List(); }

        /// <summary>
        ///     Removes at.
        /// </summary>
        /// <param name="index">The index.</param>
        public void RemoveAt(int index) { r_Instance.RemoveAt(index); Update_List(); }

        /// <summary>
        ///     Gets the count.
        /// </summary>
        /// <value>The count.</value>
        public int Count { get { return r_Instance.Count; } }

        /// <summary>
        ///     Gets the <see cref="Link" /> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>Link.</returns>
        public Link this[int index] { get { return r_Instance[index]; } }

        /// <summary>
        ///     Gets the work item.
        /// </summary>
        /// <value>The work item.</value>
        public IWorkItemOM WorkItem { get { return WorkItemWrapper.GetWrapper(r_Instance.WorkItem); } }

        /// <summary>
        ///     Initializes a new instance of the <see cref="LinkCollectionWrapper" /> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        public LinkCollectionWrapper(LinkCollection instance)
        {
            r_Instance = instance;
            Update_List();
        }

        /// <summary>
        ///     The _instance
        /// </summary>
        private readonly LinkCollection r_Instance;


        /// <summary>
        /// The r_ items
        /// </summary>
        private readonly List<ILink> r_Items = new List<ILink>();

        /// <summary>
        /// Ases the list.
        /// </summary>
        /// <returns>IReadOnlyList&lt;ILink&gt;.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public IReadOnlyList<ILink> AsList() { return r_Items; }
    }
}