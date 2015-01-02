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
    /// <summary>
    /// Class CatalogNodeWrapper.
    /// </summary>
    internal partial class CatalogNodeWrapper : CatalogNodeWrapper<ICatalogNode, CatalogNode>, ICatalogNode
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogNodeWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected CatalogNodeWrapper(CatalogNode instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<ICatalogNode, CatalogNode>(src => src == null ? null : ((CatalogNodeWrapper) src).r_Instance, src => new CatalogNodeWrapper(src)); }
    }


    /// <summary>
    /// Class CatalogNodeWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal class CatalogNodeWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, ICatalogNode where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Gets the catalog tree.
        /// </summary>
        /// <value>The catalog tree.</value>
        ICatalogTree ICatalogNode.CatalogTree
        {
            get
            {
                CatalogTree nativeCallResult = r_Instance.CatalogTree;
                ICatalogTree wrappedCallResult = CatalogTreeWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Creates the child.
        /// </summary>
        /// <param name="resourceTypeIdentifier">The resource type identifier.</param>
        /// <param name="resourceDisplayName">Display name of the resource.</param>
        /// <returns>ICatalogNode.</returns>
        ICatalogNode ICatalogNode.CreateChild(Guid resourceTypeIdentifier, String resourceDisplayName)
        {
            CatalogNode nativeCallResult = r_Instance.CreateChild(resourceTypeIdentifier, resourceDisplayName);
            ICatalogNode wrappedCallResult = CatalogNodeWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }


        /// <summary>
        /// Creates the child.
        /// </summary>
        /// <param name="existingResource">The existing resource.</param>
        /// <returns>ICatalogNode.</returns>
        ICatalogNode ICatalogNode.CreateChild(ICatalogResource existingResource)
        {
            CatalogNode nativeCallResult = r_Instance.CreateChild(CatalogResourceWrapper.GetInstance(existingResource));
            ICatalogNode wrappedCallResult = CatalogNodeWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        /// <summary>
        /// Gets the dependencies.
        /// </summary>
        /// <value>The dependencies.</value>
        ICatalogDependencyGroup ICatalogNode.Dependencies
        {
            get
            {
                CatalogDependencyGroup nativeCallResult = r_Instance.Dependencies;
                ICatalogDependencyGroup wrappedCallResult = CatalogDependencyGroupWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }


        /// <summary>
        /// Expands the dependencies.
        /// </summary>
        void ICatalogNode.ExpandDependencies() { r_Instance.ExpandDependencies(); }

        /// <summary>
        /// Gets the full path.
        /// </summary>
        /// <value>The full path.</value>
        String ICatalogNode.FullPath
        {
            get
            {
                string nativeCallResult = r_Instance.FullPath;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets or sets the is default.
        /// </summary>
        /// <value>The is default.</value>
        Boolean ICatalogNode.IsDefault
        {
            get
            {
                bool nativeCallResult = r_Instance.IsDefault;
                return nativeCallResult;
            }
            set { r_Instance.IsDefault = value; }
        }


        /// <summary>
        /// Gets the parent node.
        /// </summary>
        /// <value>The parent node.</value>
        ICatalogNode ICatalogNode.ParentNode
        {
            get
            {
                CatalogNode nativeCallResult = r_Instance.ParentNode;
                ICatalogNode wrappedCallResult = CatalogNodeWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Gets the parent path.
        /// </summary>
        /// <value>The parent path.</value>
        String ICatalogNode.ParentPath
        {
            get
            {
                string nativeCallResult = r_Instance.ParentPath;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Queries the children.
        /// </summary>
        /// <param name="resourceTypeFilters">The resource type filters.</param>
        /// <param name="propertyFilters">The property filters.</param>
        /// <param name="recurse">The recurse.</param>
        /// <param name="queryOptions">The query options.</param>
        /// <returns>ReadOnlyCollection&lt;ICatalogNode&gt;.</returns>
        ReadOnlyCollection<ICatalogNode> ICatalogNode.QueryChildren(IEnumerable<Guid> resourceTypeFilters, IEnumerable<KeyValuePair<String, String>> propertyFilters, Boolean recurse, ICatalogQueryOptions queryOptions)
        {
            ReadOnlyCollection<CatalogNode> nativeCallResult = r_Instance.QueryChildren(resourceTypeFilters, propertyFilters, recurse, CatalogQueryOptionsWrapper.GetInstance(queryOptions));
            ReadOnlyCollection<ICatalogNode> wrappedCallResult = CatalogNodeWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        /// <summary>
        /// Queries the children.
        /// </summary>
        /// <param name="resourceTypeFilters">The resource type filters.</param>
        /// <param name="recurse">The recurse.</param>
        /// <param name="queryOptions">The query options.</param>
        /// <returns>ReadOnlyCollection&lt;ICatalogNode&gt;.</returns>
        ReadOnlyCollection<ICatalogNode> ICatalogNode.QueryChildren(IEnumerable<Guid> resourceTypeFilters, Boolean recurse, ICatalogQueryOptions queryOptions)
        {
            ReadOnlyCollection<CatalogNode> nativeCallResult = r_Instance.QueryChildren(resourceTypeFilters, recurse, CatalogQueryOptionsWrapper.GetInstance(queryOptions));
            ReadOnlyCollection<ICatalogNode> wrappedCallResult = CatalogNodeWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        /// <summary>
        /// Queries the dependents.
        /// </summary>
        /// <param name="queryOptions">The query options.</param>
        /// <returns>ReadOnlyCollection&lt;ICatalogNode&gt;.</returns>
        ReadOnlyCollection<ICatalogNode> ICatalogNode.QueryDependents(ICatalogQueryOptions queryOptions)
        {
            ReadOnlyCollection<CatalogNode> nativeCallResult = r_Instance.QueryDependents(CatalogQueryOptionsWrapper.GetInstance(queryOptions));
            ReadOnlyCollection<ICatalogNode> wrappedCallResult = CatalogNodeWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        /// <summary>
        /// Queries the parents.
        /// </summary>
        /// <param name="resourceTypeFilters">The resource type filters.</param>
        /// <param name="recurseToRoot">The recurse to root.</param>
        /// <param name="queryOptions">The query options.</param>
        /// <returns>ReadOnlyCollection&lt;ICatalogNode&gt;.</returns>
        ReadOnlyCollection<ICatalogNode> ICatalogNode.QueryParents(IEnumerable<Guid> resourceTypeFilters, Boolean recurseToRoot, ICatalogQueryOptions queryOptions)
        {
            ReadOnlyCollection<CatalogNode> nativeCallResult = r_Instance.QueryParents(resourceTypeFilters, recurseToRoot, CatalogQueryOptionsWrapper.GetInstance(queryOptions));
            ReadOnlyCollection<ICatalogNode> wrappedCallResult = CatalogNodeWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        /// <summary>
        /// Gets the resource.
        /// </summary>
        /// <value>The resource.</value>
        ICatalogResource ICatalogNode.Resource
        {
            get
            {
                CatalogResource nativeCallResult = r_Instance.Resource;
                ICatalogResource wrappedCallResult = CatalogResourceWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// To the XML.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="element">The element.</param>
        void ICatalogNode.ToXml(XmlWriter writer, String element) { r_Instance.ToXml(writer, element); }
        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogNodeWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected CatalogNodeWrapper(CatalogNode instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected readonly CatalogNode r_Instance;
    }
}