using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class WindowsCredentialImpl_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Credentials_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IWindowsCredential) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    ICredentials setValue = default(ICredentials);
                    Credentials_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.Credentials = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.Credentials; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void Credentials_SetCondition(ref IWindowsCredential instance, ref ICredentials setValue);
        internal static IEnumerable<WindowsCredentialImpl> GetIEnumerableInstance() { return new List<WindowsCredentialImpl> {GetInstance()}; }

        internal static WindowsCredentialImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new WindowsCredentialImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref WindowsCredentialImpl instance, [CallerMemberName] string callerName = "");
    }
}