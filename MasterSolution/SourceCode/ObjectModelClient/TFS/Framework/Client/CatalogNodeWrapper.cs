using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Xml;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Common;
using Microsoft.TeamFoundation.Framework.Client;
using Microsoft.TeamFoundation.Framework.Common;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Client
{
    internal partial class CatalogNodeWrapper : CatalogNodeWrapper<ICatalogNode, CatalogNode>, ICatalogNode
    {
        protected CatalogNodeWrapper(CatalogNode instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<ICatalogNode, CatalogNode>(src => ((CatalogNodeWrapper) src).r_Instance, src => new CatalogNodeWrapper(src)); }
    }


    internal class CatalogNodeWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, ICatalogNode where TInterface : class where TWrapper : class
    {

        ICatalogTree ICatalogNode.CatalogTree
        {
            get
            {
                CatalogTree nativeCallResult = r_Instance.CatalogTree;
                ICatalogTree wrappedCallResult = CatalogTreeWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        ICatalogNode ICatalogNode.CreateChild(Guid resourceTypeIdentifier, String resourceDisplayName)
        {
            CatalogNode nativeCallResult = r_Instance.CreateChild(resourceTypeIdentifier, resourceDisplayName);
            ICatalogNode wrappedCallResult = CatalogNodeWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }


        ICatalogNode ICatalogNode.CreateChild(ICatalogResource existingResource)
        {
            CatalogNode nativeCallResult = r_Instance.CreateChild(CatalogResourceWrapper.GetInstance(existingResource));
            ICatalogNode wrappedCallResult = CatalogNodeWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        ICatalogDependencyGroup ICatalogNode.Dependencies
        {
            get
            {
                CatalogDependencyGroup nativeCallResult = r_Instance.Dependencies;
                ICatalogDependencyGroup wrappedCallResult = CatalogDependencyGroupWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }




        void ICatalogNode.ExpandDependencies() { r_Instance.ExpandDependencies(); }

        String ICatalogNode.FullPath
        {
            get
            {
                string nativeCallResult = r_Instance.FullPath;
                return nativeCallResult;
            }
        }

        Boolean ICatalogNode.IsDefault
        {
            get
            {
                bool nativeCallResult = r_Instance.IsDefault;
                return nativeCallResult;
            }
            set { r_Instance.IsDefault = value; }
        }



        ICatalogNode ICatalogNode.ParentNode
        {
            get
            {
                CatalogNode nativeCallResult = r_Instance.ParentNode;
                ICatalogNode wrappedCallResult = CatalogNodeWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        String ICatalogNode.ParentPath
        {
            get
            {
                string nativeCallResult = r_Instance.ParentPath;
                return nativeCallResult;
            }
        }

        ReadOnlyCollection<ICatalogNode> ICatalogNode.QueryChildren(IEnumerable<Guid> resourceTypeFilters, IEnumerable<KeyValuePair<String, String>> propertyFilters, Boolean recurse, ICatalogQueryOptions queryOptions)
        {
            ReadOnlyCollection<CatalogNode> nativeCallResult = r_Instance.QueryChildren(resourceTypeFilters, propertyFilters, recurse, CatalogQueryOptionsWrapper.GetInstance(queryOptions));
            ReadOnlyCollection<ICatalogNode> wrappedCallResult = CatalogNodeWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        ReadOnlyCollection<ICatalogNode> ICatalogNode.QueryChildren(IEnumerable<Guid> resourceTypeFilters, Boolean recurse, ICatalogQueryOptions queryOptions)
        {
            ReadOnlyCollection<CatalogNode> nativeCallResult = r_Instance.QueryChildren(resourceTypeFilters, recurse, CatalogQueryOptionsWrapper.GetInstance(queryOptions));
            ReadOnlyCollection<ICatalogNode> wrappedCallResult = CatalogNodeWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        ReadOnlyCollection<ICatalogNode> ICatalogNode.QueryDependents(ICatalogQueryOptions queryOptions)
        {
            ReadOnlyCollection<CatalogNode> nativeCallResult = r_Instance.QueryDependents(CatalogQueryOptionsWrapper.GetInstance(queryOptions));
            ReadOnlyCollection<ICatalogNode> wrappedCallResult = CatalogNodeWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        ReadOnlyCollection<ICatalogNode> ICatalogNode.QueryParents(IEnumerable<Guid> resourceTypeFilters, Boolean recurseToRoot, ICatalogQueryOptions queryOptions)
        {
            ReadOnlyCollection<CatalogNode> nativeCallResult = r_Instance.QueryParents(resourceTypeFilters, recurseToRoot, CatalogQueryOptionsWrapper.GetInstance(queryOptions));
            ReadOnlyCollection<ICatalogNode> wrappedCallResult = CatalogNodeWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        ICatalogResource ICatalogNode.Resource
        {
            get
            {
                CatalogResource nativeCallResult = r_Instance.Resource;
                ICatalogResource wrappedCallResult = CatalogResourceWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        void ICatalogNode.ToXml(XmlWriter writer, String element) { r_Instance.ToXml(writer, element); }
        protected CatalogNodeWrapper(CatalogNode instance) { r_Instance = instance; }
        protected readonly CatalogNode r_Instance;
    }
}