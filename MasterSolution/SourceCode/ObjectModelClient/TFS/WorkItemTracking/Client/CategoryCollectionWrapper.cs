using System;
using System.Collections;
using System.IO;
using System.Xml;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.ObjectModelClient.Helpers;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class CategoryCollectionWrapper : CategoryCollectionWrapper<ICategoryCollection, CategoryCollection>, ICategoryCollection, IEnumerable
    {
        protected CategoryCollectionWrapper(CategoryCollection instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<ICategoryCollection, CategoryCollection>(src => src == null ? null : ((CategoryCollectionWrapper) src).r_Instance, src => new CategoryCollectionWrapper(src)); }
    }


    internal class CategoryCollectionWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, ICategoryCollection where TInterface : class where TWrapper : class
    {
        Boolean ICategoryCollection.Contains(String name)
        {
            bool nativeCallResult = r_Instance.Contains(name);
            return nativeCallResult;
        }

        Int32 ICategoryCollection.Count
        {
            get
            {
                int nativeCallResult = r_Instance.Count;
                return nativeCallResult;
            }
        }

        XmlDocument ICategoryCollection.Export()
        {
            XmlDocument nativeCallResult = r_Instance.Export();
            return nativeCallResult;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            IEnumerator nativeCallResult = ((IEnumerable) r_Instance).GetEnumerator();
            var mappedCallResult = new EnumeratorWrapper<ICategory>(nativeCallResult, o => CategoryWrapper.GetWrapper((Category) o));
            return mappedCallResult;
        }

        void ICategoryCollection.Import(Stream stream) { r_Instance.Import(stream); }

        void ICategoryCollection.Import(String categories) { r_Instance.Import(categories); }

        void ICategoryCollection.Import(XmlElement categoriesElement) { r_Instance.Import(categoriesElement); }


        ICategory ICategoryCollection.this[Int32 index]
        {
            get
            {
                Category nativeCallResult = r_Instance[index];
                ICategory wrappedCallResult = CategoryWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        ICategory ICategoryCollection.this[String name]
        {
            get
            {
                Category nativeCallResult = r_Instance[name];
                ICategory wrappedCallResult = CategoryWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        protected CategoryCollectionWrapper(CategoryCollection instance) { r_Instance = instance; }
        protected readonly CategoryCollection r_Instance;
    }
}