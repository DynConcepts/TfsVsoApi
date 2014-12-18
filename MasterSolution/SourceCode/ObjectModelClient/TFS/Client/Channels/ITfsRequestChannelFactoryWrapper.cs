using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels;
using Microsoft.TeamFoundation.Client.Channels;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Client.Channels
{
    internal class ITfsRequestChannelFactoryWrapper : ITfsRequestChannelFactoryWrapper<IITfsRequestChannelFactory, ITfsRequestChannelFactory>, IITfsRequestChannelFactory
    {
        protected ITfsRequestChannelFactoryWrapper(ITfsRequestChannelFactory instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IITfsRequestChannelFactory, ITfsRequestChannelFactory>(src => src==null ? null : ((ITfsRequestChannelFactoryWrapper) src).r_Instance, src => new ITfsRequestChannelFactoryWrapper(src)); }
    }


    internal abstract class ITfsRequestChannelFactoryWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IITfsRequestChannelFactory where TInterface : class where TWrapper : class
    {

        IITfsRequestChannel IITfsRequestChannelFactory.CreateChannel(IITfsRequestChannel innerChannel)
        {
            ITfsRequestChannel nativeCallResult = r_Instance.CreateChannel(ITfsRequestChannelWrapper.GetInstance(innerChannel));
            IITfsRequestChannel wrappedCallResult = ITfsRequestChannelWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        protected ITfsRequestChannelFactoryWrapper(ITfsRequestChannelFactory instance) { r_Instance = instance; }
        protected readonly ITfsRequestChannelFactory r_Instance;
    }
}