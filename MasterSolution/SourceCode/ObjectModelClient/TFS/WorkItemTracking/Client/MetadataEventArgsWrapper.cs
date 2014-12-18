using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class MetadataEventArgsWrapper : MetadataEventArgsWrapper<IMetadataEventArgs, MetadataEventArgs>, IMetadataEventArgs
    {
        protected MetadataEventArgsWrapper(MetadataEventArgs instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IMetadataEventArgs, MetadataEventArgs>(src => src==null ? null : ((MetadataEventArgsWrapper) src).r_Instance, src => new MetadataEventArgsWrapper(src)); }
    }


    internal class MetadataEventArgsWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IMetadataEventArgs where TInterface : class where TWrapper : class
    {
        IMetadataChangeTypes IMetadataEventArgs.MetadataChangeFlags
        {
            get
            {
                MetadataChangeTypes nativeCallResult = r_Instance.MetadataChangeFlags;
                IMetadataChangeTypes wrappedCallResult = MetadataChangeTypesWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        protected MetadataEventArgsWrapper(MetadataEventArgs instance) { r_Instance = instance; }
        protected readonly MetadataEventArgs r_Instance;
    }
}