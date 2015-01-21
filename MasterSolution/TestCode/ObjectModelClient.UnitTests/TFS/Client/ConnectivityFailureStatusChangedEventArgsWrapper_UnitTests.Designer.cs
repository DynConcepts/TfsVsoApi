using System;
using System.Collections.Generic;
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
    public partial class ConnectivityFailureStatusChangedEventArgsWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void NewConnectivityFailureStatus_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IConnectivityFailureStatusChangedEventArgs) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.NewConnectivityFailureStatus; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        internal static IEnumerable<ConnectivityFailureStatusChangedEventArgsWrapper> GetIEnumerableInstance() { return new List<ConnectivityFailureStatusChangedEventArgsWrapper> {GetInstance()}; }

        internal static ConnectivityFailureStatusChangedEventArgsWrapper GetInstance()
        {
            ConnectivityFailureStatusChangedEventArgs real = default(ConnectivityFailureStatusChangedEventArgs);
            RealInstanceFactory(ref real);
            var instance = (ConnectivityFailureStatusChangedEventArgsWrapper) ConnectivityFailureStatusChangedEventArgsWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref ConnectivityFailureStatusChangedEventArgsWrapper instance, [CallerMemberName] string callerName = "");

        partial void NewConnectivityFailureStatus_SetCondition(ref IConnectivityFailureStatusChangedEventArgs instance, ref Boolean setValue);
        static partial void RealInstanceFactory(ref ConnectivityFailureStatusChangedEventArgs real, [CallerMemberName] string callerName = "");
    }
}