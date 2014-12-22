using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class HyperlinkWrapper : HyperlinkWrapper<IHyperlink, Hyperlink>, IHyperlink
    {
        protected HyperlinkWrapper(Hyperlink instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IHyperlink, Hyperlink>(src => src == null ? null : ((HyperlinkWrapper) src).r_Instance, src => new HyperlinkWrapper(src)); }
    }


    internal class HyperlinkWrapper<TWrapper, TInterface> : LinkWrapper<TWrapper, TInterface>, IHyperlink where TInterface : class where TWrapper : class
    {
        String IHyperlink.Location
        {
            get
            {
                string nativeCallResult = r_Instance.Location;
                return nativeCallResult;
            }
        }

        protected HyperlinkWrapper(Hyperlink instance) : base(instance) { r_Instance = instance; }
        protected new readonly Hyperlink r_Instance;
    }
}