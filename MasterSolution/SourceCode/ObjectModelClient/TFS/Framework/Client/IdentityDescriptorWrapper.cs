using System;
using System.Xml;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using Microsoft.TeamFoundation.Framework.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Client
{
    /// <summary>
    /// Class IdentityDescriptorWrapper.
    /// </summary>
    internal class IdentityDescriptorWrapper : IdentityDescriptorWrapper<IIdentityDescriptor, IdentityDescriptor>, IIdentityDescriptor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityDescriptorWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected IdentityDescriptorWrapper(IdentityDescriptor instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<IIdentityDescriptor, IdentityDescriptor>(src => src == null ? null : ((IdentityDescriptorWrapper) src).r_Instance, src => new IdentityDescriptorWrapper(src)); }
    }


    /// <summary>
    /// Class IdentityDescriptorWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal class IdentityDescriptorWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IIdentityDescriptor where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>The data.</value>
        Object IIdentityDescriptor.Data
        {
            get
            {
                object nativeCallResult = r_Instance.Data;
                return nativeCallResult;
            }
            set { r_Instance.Data = value; }
        }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        String IIdentityDescriptor.Identifier
        {
            get
            {
                string nativeCallResult = r_Instance.Identifier;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the type of the identity.
        /// </summary>
        /// <value>The type of the identity.</value>
        String IIdentityDescriptor.IdentityType
        {
            get
            {
                string nativeCallResult = r_Instance.IdentityType;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// To the XML.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="element">The element.</param>
        void IIdentityDescriptor.ToXml(XmlWriter writer, String element) { r_Instance.ToXml(writer, element); }
        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityDescriptorWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected IdentityDescriptorWrapper(IdentityDescriptor instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected readonly IdentityDescriptor r_Instance;
    }
}