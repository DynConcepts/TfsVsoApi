using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ObjectModelClient.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using Microsoft.TeamFoundation.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class WindowsCredentialWrapper_UnitTests : DynTestClassBase
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
        internal static IEnumerable<WindowsCredentialWrapper> GetIEnumerableInstance() { return new List<WindowsCredentialWrapper> {GetInstance()}; }

        internal static WindowsCredentialWrapper GetInstance()
        {
            var real = new WindowsCredential();
            RealInstanceFactory(ref real);
            var instance = (WindowsCredentialWrapper) WindowsCredentialWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref WindowsCredentialWrapper instance, [CallerMemberName] string callerName = "");

        static partial void RealInstanceFactory(ref WindowsCredential real, [CallerMemberName] string callerName = "");
    }
}