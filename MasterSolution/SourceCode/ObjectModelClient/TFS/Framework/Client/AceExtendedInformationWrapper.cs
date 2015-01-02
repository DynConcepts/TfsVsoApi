using System;
using System.Xml;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using Microsoft.TeamFoundation.Framework.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Client
{
    /// <summary>
    /// Class AceExtendedInformationWrapper.
    /// </summary>
    internal class AceExtendedInformationWrapper : AceExtendedInformationWrapper<IAceExtendedInformation, AceExtendedInformation>, IAceExtendedInformation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AceExtendedInformationWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected AceExtendedInformationWrapper(AceExtendedInformation instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<IAceExtendedInformation, AceExtendedInformation>(src => src == null ? null : ((AceExtendedInformationWrapper) src).r_Instance, src => new AceExtendedInformationWrapper(src)); }
    }


    /// <summary>
    /// Class AceExtendedInformationWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal class AceExtendedInformationWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IAceExtendedInformation where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Gets the effective allow.
        /// </summary>
        /// <value>The effective allow.</value>
        Int32 IAceExtendedInformation.EffectiveAllow
        {
            get
            {
                int nativeCallResult = r_Instance.EffectiveAllow;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the effective deny.
        /// </summary>
        /// <value>The effective deny.</value>
        Int32 IAceExtendedInformation.EffectiveDeny
        {
            get
            {
                int nativeCallResult = r_Instance.EffectiveDeny;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the inherited allow.
        /// </summary>
        /// <value>The inherited allow.</value>
        Int32 IAceExtendedInformation.InheritedAllow
        {
            get
            {
                int nativeCallResult = r_Instance.InheritedAllow;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the inherited deny.
        /// </summary>
        /// <value>The inherited deny.</value>
        Int32 IAceExtendedInformation.InheritedDeny
        {
            get
            {
                int nativeCallResult = r_Instance.InheritedDeny;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// To the XML.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="element">The element.</param>
        void IAceExtendedInformation.ToXml(XmlWriter writer, String element) { r_Instance.ToXml(writer, element); }
        /// <summary>
        /// Initializes a new instance of the <see cref="AceExtendedInformationWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected AceExtendedInformationWrapper(AceExtendedInformation instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected readonly AceExtendedInformation r_Instance;
    }
}