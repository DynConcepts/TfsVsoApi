using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Internals;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Internals;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Internals
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class LinkInfoImpl_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void AuthorizedAddedDate_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ILinkInfo) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    DateTime setValue = default(DateTime);
                    AuthorizedAddedDate_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.AuthorizedAddedDate = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.AuthorizedAddedDate; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void AuthorizedRemovedDate_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ILinkInfo) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    DateTime setValue = default(DateTime);
                    AuthorizedRemovedDate_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.AuthorizedRemovedDate = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.AuthorizedRemovedDate; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Comment_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ILinkInfo) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    string setValue = default(String);
                    Comment_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.Comment = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.Comment; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void FieldId_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (ILinkInfo) GetInstance();
                    return instance;
                },
                // Create Set Value
                instance =>
                {
                    int setValue = default(Int32);
                    FieldId_SetCondition(ref instance, ref setValue);
                    return setValue;
                },
                // Invoke Setter
                (instance, setValue) => { instance.FieldId = setValue; },
                // Validate Set Operation
                (instance, setValue) => { },
                // Invoke Getter
                instance => { return instance.FieldId; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void AuthorizedAddedDate_SetCondition(ref ILinkInfo instance, ref DateTime setValue);

        partial void AuthorizedRemovedDate_SetCondition(ref ILinkInfo instance, ref DateTime setValue);
        partial void Comment_SetCondition(ref ILinkInfo instance, ref String setValue);
        partial void FieldId_SetCondition(ref ILinkInfo instance, ref Int32 setValue);
        internal static IEnumerable<LinkInfoImpl> GetIEnumerableInstance() { return new List<LinkInfoImpl> {GetInstance()}; }

        internal static LinkInfoImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new LinkInfoImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref LinkInfoImpl instance, [CallerMemberName] string callerName = "");
    }
}