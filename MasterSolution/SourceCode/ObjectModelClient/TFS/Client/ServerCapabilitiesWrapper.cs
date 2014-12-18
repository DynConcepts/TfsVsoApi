using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using Microsoft.TeamFoundation.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Client
{
    internal static class ServerCapabilitiesWrapper
    {
        public static ServerCapabilities GetInstance(IServerCapabilities src) { return default(ServerCapabilities); }

        public static ServerCapabilities[] GetInstance(IServerCapabilities[] src) { return null; }
        public static IServerCapabilities GetWrapper(ServerCapabilities src) { return default(IServerCapabilities); }
        public static IServerCapabilities[] GetWrapper(ServerCapabilities[] src) { return null; }
    }
}