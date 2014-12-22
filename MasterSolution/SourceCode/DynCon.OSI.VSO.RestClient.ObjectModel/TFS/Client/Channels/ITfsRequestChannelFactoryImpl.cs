using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels;

namespace DynCon.OSI.VSO.ReSTClient.TFS.Client.Channels
{
    internal class ITfsRequestChannelFactoryImpl : IITfsRequestChannelFactory
    {
        IITfsRequestChannel IITfsRequestChannelFactory.CreateChannel(IITfsRequestChannel innerChannel) { throw new ToBeImplementedException(); }
    }
}