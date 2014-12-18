using System;
using System.Collections.Generic;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class ServerInfoWrapper : ServerInfoWrapper<IServerInfo, ServerInfo>, IServerInfo
    {
        protected ServerInfoWrapper(ServerInfo instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IServerInfo, ServerInfo>(src => src==null ? null : ((ServerInfoWrapper) src).r_Instance, src => new ServerInfoWrapper(src)); }
    }


    internal class ServerInfoWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IServerInfo where TInterface : class where TWrapper : class
    {
        IEnumerable<String> IServerInfo.Features
        {
            get
            {
                IEnumerable<string> nativeCallResult = r_Instance.Features;
                return nativeCallResult;
            }
        }

        Boolean IServerInfo.IsSupported(String feature)
        {
            bool nativeCallResult = r_Instance.IsSupported(feature);
            return nativeCallResult;
        }

        protected ServerInfoWrapper(ServerInfo instance) { r_Instance = instance; }
        protected readonly ServerInfo r_Instance;
    }
}