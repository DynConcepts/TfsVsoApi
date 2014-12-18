using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using Microsoft.TeamFoundation.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Client
{
    internal class FederatedCredentialWrapper : FederatedCredentialWrapper<IFederatedCredential, FederatedCredential>, IFederatedCredential
    {
        protected FederatedCredentialWrapper(FederatedCredential instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IFederatedCredential, FederatedCredential>(src => ((FederatedCredentialWrapper) src).r_Instance, src => new FederatedCredentialWrapper(src)); }
    }


    internal abstract class FederatedCredentialWrapper<TWrapper, TInterface> : IssuedTokenCredentialWrapper<TWrapper, TInterface>, IFederatedCredential where TInterface : class where TWrapper : class
    {
        protected FederatedCredentialWrapper(FederatedCredential instance) : base(instance) { r_Instance = instance; }
        protected new readonly FederatedCredential r_Instance;
    }
}