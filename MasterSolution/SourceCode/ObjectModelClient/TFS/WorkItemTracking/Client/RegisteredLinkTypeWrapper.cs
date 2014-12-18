using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class RegisteredLinkTypeWrapper : RegisteredLinkTypeWrapper<IRegisteredLinkType, RegisteredLinkType>, IRegisteredLinkType
    {
        protected RegisteredLinkTypeWrapper(RegisteredLinkType instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IRegisteredLinkType, RegisteredLinkType>(src => ((RegisteredLinkTypeWrapper) src).r_Instance, src => new RegisteredLinkTypeWrapper(src)); }
    }


    internal class RegisteredLinkTypeWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IRegisteredLinkType where TInterface : class where TWrapper : class
    {

        Boolean IRegisteredLinkType.Equals(IRegisteredLinkType type)
        {
            bool nativeCallResult = r_Instance.Equals(RegisteredLinkTypeWrapper.GetInstance(type));
            return nativeCallResult;
        }

        String IRegisteredLinkType.Name
        {
            get
            {
                string nativeCallResult = r_Instance.Name;
                return nativeCallResult;
            }
        }

        protected RegisteredLinkTypeWrapper(RegisteredLinkType instance) { r_Instance = instance; }
        protected readonly RegisteredLinkType r_Instance;
    }
}