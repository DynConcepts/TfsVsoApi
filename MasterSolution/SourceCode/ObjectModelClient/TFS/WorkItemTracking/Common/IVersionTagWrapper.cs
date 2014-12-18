using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;
using Microsoft.TeamFoundation.WorkItemTracking.Common;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Common
{
    internal class IVersionTagWrapper : IVersionTagWrapper<IIVersionTag, IVersionTag>, IIVersionTag
    {
        protected IVersionTagWrapper(IVersionTag instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IIVersionTag, IVersionTag>(src => src==null ? null : ((IVersionTagWrapper) src).r_Instance, src => new IVersionTagWrapper(src)); }
    }


    internal abstract class IVersionTagWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IIVersionTag where TInterface : class where TWrapper : class
    {
        Int32 IIVersionTag.VersionTag
        {
            get
            {
                int nativeCallResult = r_Instance.VersionTag;
                return nativeCallResult;
            }
        }

        protected IVersionTagWrapper(IVersionTag instance) { r_Instance = instance; }
        protected readonly IVersionTag r_Instance;
    }
}