using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class DisplayFieldListImpl_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void Insert_UnitTest()
        {
            Int32 index = default(Int32);
            IFieldDefinition value = default(IFieldDefinition);
            ExecuteMethod(
                () => { return (IDisplayFieldList) GetInstance(); },
                instance =>
                {
                    index = default(Int32); //No Constructor
                    value = FieldDefinitionImpl_UnitTests.GetInstance();
                    Insert_PreCondition(ref instance, ref index, ref value);
                },
                instance => { instance.Insert(index, value); },
                instance => { Insert_PostValidate(instance, index, value); });
        }

        internal static IEnumerable<DisplayFieldListImpl> GetIEnumerableInstance() { return new List<DisplayFieldListImpl> {GetInstance()}; }

        internal static DisplayFieldListImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new DisplayFieldListImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        partial void Insert_PostValidate(IDisplayFieldList instance, Int32 index, IFieldDefinition value);
        partial void Insert_PreCondition(ref IDisplayFieldList instance, ref Int32 index, ref IFieldDefinition value);
        static partial void InstanceFactory(ref DisplayFieldListImpl instance, [CallerMemberName] string callerName = "");
    }
}