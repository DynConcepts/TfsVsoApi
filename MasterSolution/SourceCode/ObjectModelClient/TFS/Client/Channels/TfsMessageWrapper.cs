using System;
using System.Collections.ObjectModel;
using System.Xml;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels;
using Microsoft.TeamFoundation.Client.Channels;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Client.Channels
{
    /// <summary>
    /// Class TfsMessageWrapper.
    /// </summary>
    internal class TfsMessageWrapper : TfsMessageWrapper<ITfsMessage, TfsMessage>, ITfsMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TfsMessageWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected TfsMessageWrapper(TfsMessage instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<ITfsMessage, TfsMessage>(src => src == null ? null : ((TfsMessageWrapper) src).r_Instance, src => new TfsMessageWrapper(src)); }
    }


    /// <summary>
    /// Class TfsMessageWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal class TfsMessageWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, ITfsMessage where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Gets the action.
        /// </summary>
        /// <value>The action.</value>
        String ITfsMessage.Action
        {
            get
            {
                string nativeCallResult = r_Instance.Action;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Closes this instance.
        /// </summary>
        void ITfsMessage.Close() { r_Instance.Close(); }

        /// <summary>
        /// Creates the exception.
        /// </summary>
        /// <returns>Exception.</returns>
        Exception ITfsMessage.CreateException()
        {
            Exception nativeCallResult = r_Instance.CreateException();
            return nativeCallResult;
        }


        /// <summary>
        /// Gets the body reader.
        /// </summary>
        /// <returns>XmlDictionaryReader.</returns>
        XmlDictionaryReader ITfsMessage.GetBodyReader()
        {
            XmlDictionaryReader nativeCallResult = r_Instance.GetBodyReader();
            return nativeCallResult;
        }


        /// <summary>
        /// Gets the headers.
        /// </summary>
        /// <value>The headers.</value>
        Collection<ITfsMessageHeader> ITfsMessage.Headers
        {
            get
            {
                Collection<TfsMessageHeader> nativeCallResult = r_Instance.Headers;
                Collection<ITfsMessageHeader> wrappedCallResult = TfsMessageHeaderWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Gets the is empty.
        /// </summary>
        /// <value>The is empty.</value>
        Boolean ITfsMessage.IsEmpty
        {
            get
            {
                bool nativeCallResult = r_Instance.IsEmpty;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the is fault.
        /// </summary>
        /// <value>The is fault.</value>
        Boolean ITfsMessage.IsFault
        {
            get
            {
                bool nativeCallResult = r_Instance.IsFault;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets to.
        /// </summary>
        /// <value>To.</value>
        Uri ITfsMessage.To
        {
            get
            {
                Uri nativeCallResult = r_Instance.To;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Writes the body contents.
        /// </summary>
        /// <param name="writer">The writer.</param>
        void ITfsMessage.WriteBodyContents(XmlDictionaryWriter writer) { r_Instance.WriteBodyContents(writer); }
        /// <summary>
        /// Initializes a new instance of the <see cref="TfsMessageWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected TfsMessageWrapper(TfsMessage instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected readonly TfsMessage r_Instance;
    }
}