using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using Microsoft.TeamFoundation.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Client
{
    internal class IssuedTokenWrapper : IssuedTokenWrapper<IIssuedToken, IssuedToken>, IIssuedToken
    {
        protected IssuedTokenWrapper(IssuedToken instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IIssuedToken, IssuedToken>(src => src==null ? null : ((IssuedTokenWrapper) src).r_Instance, src => new IssuedTokenWrapper(src)); }
    }


    internal abstract class IssuedTokenWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IIssuedToken where TInterface : class where TWrapper : class
    {
        Boolean IIssuedToken.IsAuthenticated
        {
            get
            {
                bool nativeCallResult = r_Instance.IsAuthenticated;
                return nativeCallResult;
            }
        }

        protected IssuedTokenWrapper(IssuedToken instance) { r_Instance = instance; }
        protected readonly IssuedToken r_Instance;
    }
}