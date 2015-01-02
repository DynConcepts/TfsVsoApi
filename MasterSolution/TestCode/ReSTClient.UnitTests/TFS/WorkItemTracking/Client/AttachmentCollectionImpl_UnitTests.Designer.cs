using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.WorkItemTracking.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.TFS.WorkItemTracking.Client
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class AttachmentCollectionImpl_UnitTests : DynTestClassBase
    {
        internal static IEnumerable<AttachmentCollectionImpl> GetIEnumerableInstance() { return new List<AttachmentCollectionImpl> {GetInstance()}; }

        internal static AttachmentCollectionImpl GetInstance([CallerMemberName] string callerName = "")
        {
            AttachmentCollectionImpl instance = default(AttachmentCollectionImpl);
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref AttachmentCollectionImpl instance, [CallerMemberName] string callerName = "");
    }
}