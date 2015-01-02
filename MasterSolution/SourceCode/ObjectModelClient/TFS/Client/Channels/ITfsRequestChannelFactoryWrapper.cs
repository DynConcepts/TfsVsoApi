using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels;
using Microsoft.TeamFoundation.Client.Channels;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Client.Channels
{
    /// <summary>
    /// Class ITfsRequestChannelFactoryWrapper.
    /// </summary>
    internal class ITfsRequestChannelFactoryWrapper : ITfsRequestChannelFactoryWrapper<IITfsRequestChannelFactory, ITfsRequestChannelFactory>, IITfsRequestChannelFactory
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ITfsRequestChannelFactoryWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected ITfsRequestChannelFactoryWrapper(ITfsRequestChannelFactory instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<IITfsRequestChannelFactory, ITfsRequestChannelFactory>(src => src == null ? null : ((ITfsRequestChannelFactoryWrapper) src).r_Instance, src => new ITfsRequestChannelFactoryWrapper(src)); }
    }


    /// <summary>
    /// Class ITfsRequestChannelFactoryWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal abstract class ITfsRequestChannelFactoryWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IITfsRequestChannelFactory where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Creates the channel.
        /// </summary>
        /// <param name="innerChannel">The inner channel.</param>
        /// <returns>IITfsRequestChannel.</returns>
        IITfsRequestChannel IITfsRequestChannelFactory.CreateChannel(IITfsRequestChannel innerChannel)
        {
            ITfsRequestChannel nativeCallResult = r_Instance.CreateChannel(ITfsRequestChannelWrapper.GetInstance(innerChannel));
            IITfsRequestChannel wrappedCallResult = ITfsRequestChannelWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ITfsRequestChannelFactoryWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected ITfsRequestChannelFactoryWrapper(ITfsRequestChannelFactory instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected readonly ITfsRequestChannelFactory r_Instance;
    }
}