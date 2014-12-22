using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.TFS.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class CredentialsChangedEventArgsImpl_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<CredentialsChangedEventArgsImpl> GetIEnumerableInstance() { return new List<CredentialsChangedEventArgsImpl> {GetInstance()}; }

        internal static CredentialsChangedEventArgsImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new CredentialsChangedEventArgsImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref CredentialsChangedEventArgsImpl instance, [CallerMemberName] string callerName = "");
    }
}