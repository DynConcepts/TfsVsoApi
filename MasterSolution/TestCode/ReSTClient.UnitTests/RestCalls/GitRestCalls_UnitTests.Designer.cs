using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.JasonBackedObjects.Communications;
using DynCon.OSI.VSO.ReSTClient.RestCalls;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.RestCalls
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class GitRestCalls_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Blobs0_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return GitRestCalls.Blobs0; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Blobs1_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return GitRestCalls.Blobs1; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void BranchStats0_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return GitRestCalls.BranchStats0; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void BranchStats1_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return GitRestCalls.BranchStats1; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void BranchStats2_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return GitRestCalls.BranchStats2; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void BranchStats3_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return GitRestCalls.BranchStats3; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Changes0_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return GitRestCalls.Changes0; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Changes1_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return GitRestCalls.Changes1; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void CommitDiffs0_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return GitRestCalls.CommitDiffs0; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void CommitDiffs1_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return GitRestCalls.CommitDiffs1; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Commits0_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return GitRestCalls.Commits0; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Commits1_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return GitRestCalls.Commits1; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Commits2_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return GitRestCalls.Commits2; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Commits3_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return GitRestCalls.Commits3; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void CommitsBatch0_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return GitRestCalls.CommitsBatch0; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void CommitsBatch1_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return GitRestCalls.CommitsBatch1; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Equals_UnitTest()
        {
            Object obj = default(Object);
            Boolean _retVal = default(Boolean);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance =>
                {
                    obj = new Object();
                    Equals_PreCondition(ref instance, ref obj);
                },
                instance => { _retVal = instance.Equals(obj); },
                instance => { Equals_PostValidate(instance, obj, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetHashCode_UnitTest()
        {
            Int32 _retVal = default(Int32);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetHashCode_PreCondition(ref instance); },
                instance => { _retVal = instance.GetHashCode(); },
                instance => { GetHashCode_PostValidate(instance, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void GetType_UnitTest()
        {
            Type _retVal = default(Type);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { GetType_PreCondition(ref instance); },
                instance => { _retVal = instance.GetType(); },
                instance => { GetType_PostValidate(instance, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Items0_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return GitRestCalls.Items0; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Items1_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return GitRestCalls.Items1; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ItemsBatch0_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return GitRestCalls.ItemsBatch0; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ItemsBatch1_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return GitRestCalls.ItemsBatch1; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Objects0_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return GitRestCalls.Objects0; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Objects1_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return GitRestCalls.Objects1; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void PullRequestReviewers0_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return GitRestCalls.PullRequestReviewers0; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void PullRequestReviewers1_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return GitRestCalls.PullRequestReviewers1; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void PullRequestWorkItems0_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return GitRestCalls.PullRequestWorkItems0; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void PullRequestWorkItems1_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return GitRestCalls.PullRequestWorkItems1; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void PullRequests0_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return GitRestCalls.PullRequests0; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void PullRequests1_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return GitRestCalls.PullRequests1; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Pushes0_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return GitRestCalls.Pushes0; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Pushes1_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return GitRestCalls.Pushes1; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Refs0_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return GitRestCalls.Refs0; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Refs1_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return GitRestCalls.Refs1; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Repositories0_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return GitRestCalls.Repositories0; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Repositories1_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return GitRestCalls.Repositories1; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ToString_UnitTest()
        {
            String _retVal = default(String);
            ExecuteMethod(
                () => { return GetInstance(); },
                instance => { ToString_PreCondition(ref instance); },
                instance => { _retVal = instance.ToString(); },
                instance => { ToString_PostValidate(instance, _retVal); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Trees0_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return GitRestCalls.Trees0; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Trees1_UnitTest()
        {
            ExecuteProperty(
                null, null, null, // No Set Accessor
                // Invoke Getter
                () => { return GitRestCalls.Trees1; },
                // Validate Get Operation
                (setValue, getValue) => { });
        }

        partial void Blobs0_SetCondition(ref CallSpec setValue);

        partial void Blobs1_SetCondition(ref CallSpec setValue);

        partial void BranchStats0_SetCondition(ref CallSpec setValue);

        partial void BranchStats1_SetCondition(ref CallSpec setValue);

        partial void BranchStats2_SetCondition(ref CallSpec setValue);

        partial void BranchStats3_SetCondition(ref CallSpec setValue);

        partial void Changes0_SetCondition(ref CallSpec setValue);

        partial void Changes1_SetCondition(ref CallSpec setValue);

        partial void CommitDiffs0_SetCondition(ref CallSpec setValue);

        partial void CommitDiffs1_SetCondition(ref CallSpec setValue);

        partial void Commits0_SetCondition(ref CallSpec setValue);

        partial void Commits1_SetCondition(ref CallSpec setValue);

        partial void Commits2_SetCondition(ref CallSpec setValue);

        partial void Commits3_SetCondition(ref CallSpec setValue);

        partial void CommitsBatch0_SetCondition(ref CallSpec setValue);

        partial void CommitsBatch1_SetCondition(ref CallSpec setValue);
        partial void Equals_PostValidate(GitRestCalls instance, Object obj, Boolean _retVal);
        partial void Equals_PreCondition(ref GitRestCalls instance, ref Object obj);
        partial void GetHashCode_PostValidate(GitRestCalls instance, Int32 _retVal);
        partial void GetHashCode_PreCondition(ref GitRestCalls instance);
        internal static IEnumerable<GitRestCalls> GetIEnumerableInstance() { return new List<GitRestCalls> {GetInstance()}; }

        internal static GitRestCalls GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new GitRestCalls();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void GetType_PostValidate(GitRestCalls instance, Type _retVal);
        partial void GetType_PreCondition(ref GitRestCalls instance);
        static partial void InstanceFactory(ref GitRestCalls instance, [CallerMemberName] string callerName = "");

        partial void Items0_SetCondition(ref CallSpec setValue);

        partial void Items1_SetCondition(ref CallSpec setValue);

        partial void ItemsBatch0_SetCondition(ref CallSpec setValue);

        partial void ItemsBatch1_SetCondition(ref CallSpec setValue);

        partial void Objects0_SetCondition(ref CallSpec setValue);

        partial void Objects1_SetCondition(ref CallSpec setValue);

        partial void PullRequestReviewers0_SetCondition(ref CallSpec setValue);

        partial void PullRequestReviewers1_SetCondition(ref CallSpec setValue);

        partial void PullRequestWorkItems0_SetCondition(ref CallSpec setValue);

        partial void PullRequestWorkItems1_SetCondition(ref CallSpec setValue);

        partial void PullRequests0_SetCondition(ref CallSpec setValue);

        partial void PullRequests1_SetCondition(ref CallSpec setValue);

        partial void Pushes0_SetCondition(ref CallSpec setValue);

        partial void Pushes1_SetCondition(ref CallSpec setValue);

        partial void Refs0_SetCondition(ref CallSpec setValue);

        partial void Refs1_SetCondition(ref CallSpec setValue);

        partial void Repositories0_SetCondition(ref CallSpec setValue);

        partial void Repositories1_SetCondition(ref CallSpec setValue);
        partial void ToString_PostValidate(GitRestCalls instance, String _retVal);
        partial void ToString_PreCondition(ref GitRestCalls instance);

        partial void Trees0_SetCondition(ref CallSpec setValue);

        partial void Trees1_SetCondition(ref CallSpec setValue);
    }
}