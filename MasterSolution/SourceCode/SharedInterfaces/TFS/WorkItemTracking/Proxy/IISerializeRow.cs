using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy
{
    /// <summary>
    /// Interface IISerializeRow
    /// </summary>
    public interface IISerializeRow
    {
        /// <summary>
        /// Copies the row.
        /// </summary>
        /// <param name="row">The row.</param>
        /// <param name="p">The p.</param>
        /// <param name="esz">The esz.</param>
        void CopyRow(Int32 row, IntPtr p, Int32 esz);
    }
}