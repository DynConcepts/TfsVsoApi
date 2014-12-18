using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using Microsoft.TeamFoundation.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Client
{
    internal class IssuedTokenCredentialWrapper : IssuedTokenCredentialWrapper<IIssuedTokenCredential, IssuedTokenCredential>, IIssuedTokenCredential
    {
        protected IssuedTokenCredentialWrapper(IssuedTokenCredential instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IIssuedTokenCredential, IssuedTokenCredential>(src => ((IssuedTokenCredentialWrapper) src).r_Instance, src => new IssuedTokenCredentialWrapper(src)); }
    }


    internal abstract class IssuedTokenCredentialWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IIssuedTokenCredential where TInterface : class where TWrapper : class
    {
        ITfsClientCredentialStorage IIssuedTokenCredential.TokenStorage
        {
            get
            {
                TfsClientCredentialStorage nativeCallResult = r_Instance.TokenStorage;
                ITfsClientCredentialStorage wrappedCallResult = TfsClientCredentialStorageWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
            set
            {
                TfsClientCredentialStorage nativeValue = TfsClientCredentialStorageWrapper.GetInstance(value);

                r_Instance.TokenStorage = nativeValue;
            }
        }

        protected IssuedTokenCredentialWrapper(IssuedTokenCredential instance) { r_Instance = instance; }
        protected readonly IssuedTokenCredential r_Instance;
    }
}