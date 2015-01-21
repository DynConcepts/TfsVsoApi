using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ObjectModelClient.TFS.Client;
using Microsoft.TeamFoundation.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class CredentialsChangedEventArgsWrapper_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<CredentialsChangedEventArgsWrapper> GetIEnumerableInstance() { return new List<CredentialsChangedEventArgsWrapper> {GetInstance()}; }

        internal static CredentialsChangedEventArgsWrapper GetInstance()
        {
            CredentialsChangedEventArgs real = default(CredentialsChangedEventArgs);
            RealInstanceFactory(ref real);
            var instance = (CredentialsChangedEventArgsWrapper) CredentialsChangedEventArgsWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref CredentialsChangedEventArgsWrapper instance, [CallerMemberName] string callerName = "");

        static partial void RealInstanceFactory(ref CredentialsChangedEventArgs real, [CallerMemberName] string callerName = "");
    }
}