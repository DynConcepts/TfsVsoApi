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
    public partial class IssuedTokenWrapper_UnitTests : DynTestClassBase
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

        internal static IEnumerable<IssuedTokenWrapper> GetIEnumerableInstance() { return new List<IssuedTokenWrapper> {GetInstance()}; }

        internal static IssuedTokenWrapper GetInstance()
        {
            IssuedToken real = default(IssuedToken);
            RealInstanceFactory(ref real);
            var instance = (IssuedTokenWrapper) IssuedTokenWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref IssuedTokenWrapper instance, [CallerMemberName] string callerName = "");

        partial void IsAuthenticated_SetCondition(ref IIssuedToken instance, ref Boolean setValue);
        static partial void RealInstanceFactory(ref IssuedToken real, [CallerMemberName] string callerName = "");
    }
}