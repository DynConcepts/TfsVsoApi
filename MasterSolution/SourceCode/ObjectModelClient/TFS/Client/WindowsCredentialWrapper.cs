using System.Net;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using Microsoft.TeamFoundation.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Client
{
    internal class WindowsCredentialWrapper : WindowsCredentialWrapper<IWindowsCredential, WindowsCredential>, IWindowsCredential
    {
        protected WindowsCredentialWrapper(WindowsCredential instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IWindowsCredential, WindowsCredential>(src => src==null ? null : ((WindowsCredentialWrapper) src).r_Instance, src => new WindowsCredentialWrapper(src)); }
    }


    internal class WindowsCredentialWrapper<TWrapper, TInterface> : IssuedTokenCredentialWrapper<TWrapper, TInterface>, IWindowsCredential where TInterface : class where TWrapper : class
    {
        ICredentials IWindowsCredential.Credentials
        {
            get
            {
                ICredentials nativeCallResult = r_Instance.Credentials;
                return nativeCallResult;
            }
            set { r_Instance.Credentials = value; }
        }

        protected WindowsCredentialWrapper(WindowsCredential instance) : base(instance) { r_Instance = instance; }
        protected new readonly WindowsCredential r_Instance;
    }
}