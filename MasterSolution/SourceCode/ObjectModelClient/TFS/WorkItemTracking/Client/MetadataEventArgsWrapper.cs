using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Class MetadataEventArgsWrapper.
    /// </summary>
    internal class MetadataEventArgsWrapper : MetadataEventArgsWrapper<IMetadataEventArgs, MetadataEventArgs>, IMetadataEventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataEventArgsWrapper"/> class.
        /// </summary>
        /// <param name="instance">The <see cref="MetadataEventArgs"/> instance containing the event data.</param>
        protected MetadataEventArgsWrapper(MetadataEventArgs instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<IMetadataEventArgs, MetadataEventArgs>(src => src == null ? null : ((MetadataEventArgsWrapper) src).r_Instance, src => new MetadataEventArgsWrapper(src)); }
    }


    /// <summary>
    /// Class MetadataEventArgsWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal class MetadataEventArgsWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IMetadataEventArgs where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Gets the metadata change flags.
        /// </summary>
        /// <value>The metadata change flags.</value>
        IMetadataChangeTypes IMetadataEventArgs.MetadataChangeFlags
        {
            get
            {
                MetadataChangeTypes nativeCallResult = r_Instance.MetadataChangeFlags;
                IMetadataChangeTypes wrappedCallResult = MetadataChangeTypesWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataEventArgsWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The <see cref="MetadataEventArgs"/> instance containing the event data.</param>
        protected MetadataEventArgsWrapper(MetadataEventArgs instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected readonly MetadataEventArgs r_Instance;
    }
}