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
    public partial class NodeWrapper_UnitTests : DynTestClassBase
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
                    FindNodeInSubTree_PreCondition(instance, ref nodeId);
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
        partial void FindNodeInSubTree_PreCondition(INode instance, ref Int32 nodeId);
        internal static IEnumerable<NodeWrapper> GetIEnumerableInstance() { return new List<NodeWrapper> {GetInstance()}; }

        internal static NodeWrapper GetInstance()
        {
            Node real = default(Node);
            RealInstanceFactory(ref real);
            var instance = (NodeWrapper) NodeWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        partial void HasChildNodes_SetCondition(ref INode instance, ref Boolean setValue);

        partial void HasWorkItemReadRightsRecursive_SetCondition(ref INode instance, ref Boolean setValue);
        partial void HasWorkItemReadRights_SetCondition(ref INode instance, ref Boolean setValue);

        partial void HasWorkItemWriteRightsRecursive_SetCondition(ref INode instance, ref Boolean setValue);
        partial void HasWorkItemWriteRights_SetCondition(ref INode instance, ref Boolean setValue);
        static partial void InstanceFactory(ref NodeWrapper instance, [CallerMemberName] string callerName = "");
        partial void IsAreaNode_SetCondition(ref INode instance, ref Boolean setValue);
        partial void IsIterationNode_SetCondition(ref INode instance, ref Boolean setValue);
        partial void Path_SetCondition(ref INode instance, ref String setValue);
        static partial void RealInstanceFactory(ref Node real, [CallerMemberName] string callerName = "");
    }
}

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public class Node_TreeTypeWrapper_UnitTests : DynTestClassBase
    {
        internal static INode_TreeType GetInstance() { return default(INode_TreeType); }
    }
}