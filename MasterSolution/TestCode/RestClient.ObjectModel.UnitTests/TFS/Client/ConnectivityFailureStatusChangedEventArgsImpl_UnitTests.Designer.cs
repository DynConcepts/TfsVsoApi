using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.RestClient.ObjectModel_UnitTests.TFS.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class ConnectivityFailureStatusChangedEventArgsImpl_UnitTests : DynTestClassBase
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

        internal static IEnumerable<ConnectivityFailureStatusChangedEventArgsImpl> GetIEnumerableInstance() { return new List<ConnectivityFailureStatusChangedEventArgsImpl> {GetInstance()}; }

        internal static ConnectivityFailureStatusChangedEventArgsImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new ConnectivityFailureStatusChangedEventArgsImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref ConnectivityFailureStatusChangedEventArgsImpl instance, [CallerMemberName] string callerName = "");

        partial void NewConnectivityFailureStatus_SetCondition(ref IConnectivityFailureStatusChangedEventArgs instance, ref Boolean setValue);
    }
}