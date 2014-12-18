using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class ExternalLinkWrapper : ExternalLinkWrapper<IExternalLink, ExternalLink>, IExternalLink
    {
        protected ExternalLinkWrapper(ExternalLink instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IExternalLink, ExternalLink>(src => ((ExternalLinkWrapper) src).r_Instance, src => new ExternalLinkWrapper(src)); }
    }


    internal class ExternalLinkWrapper<TWrapper, TInterface> : LinkWrapper<TWrapper, TInterface>, IExternalLink where TInterface : class where TWrapper : class
    {
        String IExternalLink.LinkedArtifactUri
        {
            get
            {
                string nativeCallResult = r_Instance.LinkedArtifactUri;
                return nativeCallResult;
            }
        }

        protected ExternalLinkWrapper(ExternalLink instance) : base(instance) { r_Instance = instance; }
        protected new readonly ExternalLink r_Instance;
    }
}