using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface IAttachmentCollection : IVariableSizeList
    {
        Int32 Add(IAttachment attachment);
        Boolean Contains(IAttachment attachment);
        Int32 IndexOf(IAttachment attachment);
        void Refresh();
        void Remove(IAttachment attachment);
        IAttachment this[Int32 index] { get; }
    }
}