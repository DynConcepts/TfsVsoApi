using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class RegisteredLinkTypeCollectionWrapper : RegisteredLinkTypeCollectionWrapper<IRegisteredLinkTypeCollection, RegisteredLinkTypeCollection>, IRegisteredLinkTypeCollection
    {
        protected RegisteredLinkTypeCollectionWrapper(RegisteredLinkTypeCollection instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IRegisteredLinkTypeCollection, RegisteredLinkTypeCollection>(src => src == null ? null : ((RegisteredLinkTypeCollectionWrapper) src).r_Instance, src => new RegisteredLinkTypeCollectionWrapper(src)); }
    }


    internal class RegisteredLinkTypeCollectionWrapper<TWrapper, TInterface> : ReadOnlyListWrapper<TWrapper, TInterface, RegisteredLinkType, IRegisteredLinkType>, IRegisteredLinkTypeCollection where TInterface : class where TWrapper : class
    {
        Boolean IRegisteredLinkTypeCollection.Contains(IRegisteredLinkType value)
        {
            bool nativeCallResult = r_Instance.Contains(RegisteredLinkTypeWrapper.GetInstance(value));
            return nativeCallResult;
        }

        Int32 IRegisteredLinkTypeCollection.IndexOf(IRegisteredLinkType value)
        {
            int nativeCallResult = r_Instance.IndexOf(RegisteredLinkTypeWrapper.GetInstance(value));
            return nativeCallResult;
        }

        IRegisteredLinkType IRegisteredLinkTypeCollection.this[Int32 index]
        {
            get
            {
                RegisteredLinkType nativeCallResult = r_Instance[index];
                IRegisteredLinkType wrappedCallResult = RegisteredLinkTypeWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        IRegisteredLinkType IRegisteredLinkTypeCollection.this[IRegisteredLinkType registeredType]
        {
            get
            {
                RegisteredLinkType nativeCallResult = r_Instance[RegisteredLinkTypeWrapper.GetInstance(registeredType)];
                IRegisteredLinkType wrappedCallResult = RegisteredLinkTypeWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        IRegisteredLinkType IRegisteredLinkTypeCollection.this[String name]
        {
            get
            {
                RegisteredLinkType nativeCallResult = r_Instance[name];
                IRegisteredLinkType wrappedCallResult = RegisteredLinkTypeWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        protected RegisteredLinkTypeCollectionWrapper(RegisteredLinkTypeCollection instance) : base(instance, o => RegisteredLinkTypeWrapper.GetWrapper((RegisteredLinkType) o)) { r_Instance = instance; }
        protected new readonly RegisteredLinkTypeCollection r_Instance;
    }
}