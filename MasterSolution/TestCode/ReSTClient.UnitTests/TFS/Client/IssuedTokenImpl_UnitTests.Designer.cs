using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.TFS.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class IssuedTokenImpl_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void IsAuthenticated_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (IIssuedToken) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.IsAuthenticated; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        internal static IEnumerable<IssuedTokenImpl> GetIEnumerableInstance() { return new List<IssuedTokenImpl> {GetInstance()}; }

        internal static IssuedTokenImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new IssuedTokenImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref IssuedTokenImpl instance, [CallerMemberName] string callerName = "");

        partial void IsAuthenticated_SetCondition(ref IIssuedToken instance, ref Boolean setValue);
    }
}