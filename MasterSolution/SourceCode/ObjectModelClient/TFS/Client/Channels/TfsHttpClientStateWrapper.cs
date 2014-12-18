using DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels;
using Microsoft.TeamFoundation.Client.Channels;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Client.Channels
{
    internal static class TfsHttpClientStateWrapper
    {
        public static TfsHttpClientState GetInstance(ITfsHttpClientState src) { return default(TfsHttpClientState); }

        public static TfsHttpClientState[] GetInstance(ITfsHttpClientState[] src) { return null; }
        public static ITfsHttpClientState GetWrapper(TfsHttpClientState src) { return default(ITfsHttpClientState); }
        public static ITfsHttpClientState[] GetWrapper(TfsHttpClientState[] src) { return null; }
    }
}