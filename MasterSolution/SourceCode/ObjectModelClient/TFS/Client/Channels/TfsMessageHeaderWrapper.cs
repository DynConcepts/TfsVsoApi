using System;
using System.Xml;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels;
using Microsoft.TeamFoundation.Client.Channels;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Client.Channels
{
    /// <summary>
    /// Class TfsMessageHeaderWrapper.
    /// </summary>
    internal class TfsMessageHeaderWrapper : TfsMessageHeaderWrapper<ITfsMessageHeader, TfsMessageHeader>, ITfsMessageHeader
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TfsMessageHeaderWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected TfsMessageHeaderWrapper(TfsMessageHeader instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<ITfsMessageHeader, TfsMessageHeader>(src => src == null ? null : ((TfsMessageHeaderWrapper) src).r_Instance, src => new TfsMessageHeaderWrapper(src)); }
    }


    /// <summary>
    /// Class TfsMessageHeaderWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal abstract class TfsMessageHeaderWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, ITfsMessageHeader where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Gets the reader.
        /// </summary>
        /// <returns>XmlDictionaryReader.</returns>
        XmlDictionaryReader ITfsMessageHeader.GetReader()
        {
            XmlDictionaryReader nativeCallResult = r_Instance.GetReader();
            return nativeCallResult;
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        String ITfsMessageHeader.Name
        {
            get
            {
                string nativeCallResult = r_Instance.Name;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the namespace.
        /// </summary>
        /// <value>The namespace.</value>
        String ITfsMessageHeader.Namespace
        {
            get
            {
                string nativeCallResult = r_Instance.Namespace;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Writes the specified writer.
        /// </summary>
        /// <param name="writer">The writer.</param>
        void ITfsMessageHeader.Write(XmlDictionaryWriter writer) { r_Instance.Write(writer); }
        /// <summary>
        /// Initializes a new instance of the <see cref="TfsMessageHeaderWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected TfsMessageHeaderWrapper(TfsMessageHeader instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected readonly TfsMessageHeader r_Instance;
    }
}