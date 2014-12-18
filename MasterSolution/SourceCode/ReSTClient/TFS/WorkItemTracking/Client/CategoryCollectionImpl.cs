using System;
using System.Collections;
using System.IO;
using System.Xml;
using DynCon.OSI.Core.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class CategoryCollectionImpl : ICategoryCollection, IEnumerable
    {
        Boolean ICategoryCollection.Contains(String name) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        Int32 ICategoryCollection.Count { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        XmlDocument ICategoryCollection.Export() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        IEnumerator IEnumerable.GetEnumerator() { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void ICategoryCollection.Import(Stream stream) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void ICategoryCollection.Import(String categories) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        void ICategoryCollection.Import(XmlElement categoriesElement) { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); }
        ICategory ICategoryCollection.this[Int32 index] { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
        ICategory ICategoryCollection.this[String name] { get { throw new DynCon.OSI.Core.Helpers.ToBeImplementedException(); } }
    }
}