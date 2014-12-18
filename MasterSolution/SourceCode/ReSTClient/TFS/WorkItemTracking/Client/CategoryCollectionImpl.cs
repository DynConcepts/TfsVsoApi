using System;
using System.Collections;
using System.IO;
using System.Xml;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ReSTClient.TFS.WorkItemTracking.Client
{
    internal class CategoryCollectionImpl : ICategoryCollection, IEnumerable
    {
        Boolean ICategoryCollection.Contains(String name) { throw new ToBeImplementedException(); }
        Int32 ICategoryCollection.Count { get { throw new ToBeImplementedException(); } }
        XmlDocument ICategoryCollection.Export() { throw new ToBeImplementedException(); }
        IEnumerator IEnumerable.GetEnumerator() { throw new ToBeImplementedException(); }
        void ICategoryCollection.Import(Stream stream) { throw new ToBeImplementedException(); }
        void ICategoryCollection.Import(String categories) { throw new ToBeImplementedException(); }
        void ICategoryCollection.Import(XmlElement categoriesElement) { throw new ToBeImplementedException(); }
        ICategory ICategoryCollection.this[Int32 index] { get { throw new ToBeImplementedException(); } }
        ICategory ICategoryCollection.this[String name] { get { throw new ToBeImplementedException(); } }
    }
}