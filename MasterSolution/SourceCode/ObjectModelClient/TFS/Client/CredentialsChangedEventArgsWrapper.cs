using System.Net;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using Microsoft.TeamFoundation.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Client
{
    internal class CredentialsChangedEventArgsWrapper : CredentialsChangedEventArgsWrapper<ICredentialsChangedEventArgs, CredentialsChangedEventArgs>, ICredentialsChangedEventArgs
    {
        protected CredentialsChangedEventArgsWrapper(CredentialsChangedEventArgs instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<ICredentialsChangedEventArgs, CredentialsChangedEventArgs>(src => src == null ? null : ((CredentialsChangedEventArgsWrapper) src).r_Instance, src => new CredentialsChangedEventArgsWrapper(src)); }
    }


    internal class CredentialsChangedEventArgsWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, ICredentialsChangedEventArgs where TInterface : class where TWrapper : class
    {
        ICredentials ICredentialsChangedEventArgs.Credentials
        {
            get
            {
                ICredentials nativeCallResult = r_Instance.Credentials;
                return nativeCallResult;
            }
        }

        protected CredentialsChangedEventArgsWrapper(CredentialsChangedEventArgs instance) { r_Instance = instance; }
        protected readonly CredentialsChangedEventArgs r_Instance;
    }
}