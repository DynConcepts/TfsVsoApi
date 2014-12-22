using System;
using System.Collections;
using System.IO;
using System.Xml;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface ICategoryCollection : IEnumerable
    {
        Boolean Contains(String name);
        XmlDocument Export();
        void Import(Stream stream);
        void Import(String categories);
        void Import(XmlElement categoriesElement);
        Int32 Count { get; }
        ICategory this[Int32 index] { get; }
        ICategory this[String name] { get; }
    }
}