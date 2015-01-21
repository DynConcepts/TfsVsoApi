using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class ServerInfoWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Features_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IServerInfo) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Features; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void IsSupported_UnitTest()
        {
            String feature = default(String);
            ExecuteMethod(
                () => { return (IServerInfo) GetInstance(); },
                instance =>
                {
                    feature = default(String); //No Constructor
                    IsSupported_PreCondition(instance, ref feature);
                },
                instance => { instance.IsSupported(feature); },
                instance => { IsSupported_PostValidate(instance, feature); });
        }

        partial void Features_SetCondition(ref IServerInfo instance, ref IEnumerable<String> setValue);
        internal static IEnumerable<ServerInfoWrapper> GetIEnumerableInstance() { return new List<ServerInfoWrapper> {GetInstance()}; }

        internal static ServerInfoWrapper GetInstance()
        {
            ServerInfo real = default(ServerInfo);
            RealInstanceFactory(ref real);
            var instance = (ServerInfoWrapper) ServerInfoWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref ServerInfoWrapper instance, [CallerMemberName] string callerName = "");
        partial void IsSupported_PostValidate(IServerInfo instance, String feature);
        partial void IsSupported_PreCondition(IServerInfo instance, ref String feature);
        static partial void RealInstanceFactory(ref ServerInfo real, [CallerMemberName] string callerName = "");
    }
}