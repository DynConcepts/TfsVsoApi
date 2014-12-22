using System;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public delegate void IWorkItemPreSaveEventHandler(Object sender, IWorkItemEventArgs e);
}