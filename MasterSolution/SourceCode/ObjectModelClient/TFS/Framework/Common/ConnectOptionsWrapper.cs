using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common;
using Microsoft.TeamFoundation.Framework.Common;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Common
{
    internal static class ConnectOptionsWrapper
    {
        public static ConnectOptions GetInstance(IConnectOptions src) { return default(ConnectOptions); }

        public static ConnectOptions[] GetInstance(IConnectOptions[] src) { return null; }
        public static IConnectOptions GetWrapper(ConnectOptions src) { return default(IConnectOptions); }
        public static IConnectOptions[] GetWrapper(ConnectOptions[] src) { return null; }
    }
}