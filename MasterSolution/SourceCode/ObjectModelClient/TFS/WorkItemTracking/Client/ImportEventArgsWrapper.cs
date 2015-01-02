using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Class ImportEventArgsWrapper.
    /// </summary>
    internal class ImportEventArgsWrapper : ImportEventArgsWrapper<IImportEventArgs, ImportEventArgs>, IImportEventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImportEventArgsWrapper"/> class.
        /// </summary>
        /// <param name="instance">The <see cref="ImportEventArgs"/> instance containing the event data.</param>
        protected ImportEventArgsWrapper(ImportEventArgs instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<IImportEventArgs, ImportEventArgs>(src => src == null ? null : ((ImportEventArgsWrapper) src).r_Instance, src => new ImportEventArgsWrapper(src)); }
    }


    /// <summary>
    /// Class ImportEventArgsWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal class ImportEventArgsWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IImportEventArgs where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Gets the exception.
        /// </summary>
        /// <value>The exception.</value>
        Exception IImportEventArgs.Exception
        {
            get
            {
                Exception nativeCallResult = r_Instance.Exception;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the message.
        /// </summary>
        /// <value>The message.</value>
        String IImportEventArgs.Message
        {
            get
            {
                string nativeCallResult = r_Instance.Message;
                return nativeCallResult;
            }
        }

        /// <summary>
        /// Gets the severity.
        /// </summary>
        /// <value>The severity.</value>
        IImportSeverity IImportEventArgs.Severity
        {
            get
            {
                ImportSeverity nativeCallResult = r_Instance.Severity;
                IImportSeverity wrappedCallResult = ImportSeverityWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportEventArgsWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The <see cref="ImportEventArgs"/> instance containing the event data.</param>
        protected ImportEventArgsWrapper(ImportEventArgs instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected readonly ImportEventArgs r_Instance;
    }
}