using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class NodeImpl_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void ChildNodes_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (INode) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.ChildNodes; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void FindNodeInSubTree_UnitTest()
        {
            Int32 nodeId = default(Int32);
            ExecuteMethod(
                () => { return (INode) GetInstance(); },
                instance =>
                {
                    nodeId = default(Int32); //No Constructor
                    FindNodeInSubTree_PreCondition(ref instance, ref nodeId);
                },
                instance => { instance.FindNodeInSubTree(nodeId); },
                instance => { FindNodeInSubTree_PostValidate(instance, nodeId); });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void HasChildNodes_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (INode) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.HasChildNodes; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void HasWorkItemReadRightsRecursive_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (INode) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.HasWorkItemReadRightsRecursive; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void HasWorkItemReadRights_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (INode) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.HasWorkItemReadRights; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void HasWorkItemWriteRightsRecursive_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (INode) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.HasWorkItemWriteRightsRecursive; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void HasWorkItemWriteRights_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (INode) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.HasWorkItemWriteRights; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void IsAreaNode_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (INode) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.IsAreaNode; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void IsIterationNode_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (INode) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.IsIterationNode; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Path_UnitTest()
        {
            ExecuteProperty(
                () =>
                    // Create Test Instance
                {
                    var instance = (INode) GetInstance();
                    return instance;
                },
                null, null, null, // No Set Accessor
                // Invoke Getter
                instance => { return instance.Path; },
                // Validate Get Operation
                (instance, setValue, getValue) => { });
        }

        partial void ChildNodes_SetCondition(ref INode instance, ref INodeCollection setValue);
        partial void FindNodeInSubTree_PostValidate(INode instance, Int32 nodeId);
        partial void FindNodeInSubTree_PreCondition(ref INode instance, ref Int32 nodeId);
        internal static IEnumerable<NodeImpl> GetIEnumerableInstance() { return new List<NodeImpl> {GetInstance()}; }

        internal static NodeImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new NodeImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void HasChildNodes_SetCondition(ref INode instance, ref Boolean setValue);

        partial void HasWorkItemReadRightsRecursive_SetCondition(ref INode instance, ref Boolean setValue);
        partial void HasWorkItemReadRights_SetCondition(ref INode instance, ref Boolean setValue);

        partial void HasWorkItemWriteRightsRecursive_SetCondition(ref INode instance, ref Boolean setValue);
        partial void HasWorkItemWriteRights_SetCondition(ref INode instance, ref Boolean setValue);
        static partial void InstanceFactory(ref NodeImpl instance, [CallerMemberName] string callerName = "");
        partial void IsAreaNode_SetCondition(ref INode instance, ref Boolean setValue);
        partial void IsIterationNode_SetCondition(ref INode instance, ref Boolean setValue);
        partial void Path_SetCondition(ref INode instance, ref String setValue);
    }
}

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public class Node_TreeTypeImpl_UnitTests : DynTestClassBase
    {
        internal static INode_TreeType GetInstance() { return default(INode_TreeType); }
    }
}