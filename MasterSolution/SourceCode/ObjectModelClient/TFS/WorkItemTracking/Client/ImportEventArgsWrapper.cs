using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class ImportEventArgsWrapper : ImportEventArgsWrapper<IImportEventArgs, ImportEventArgs>, IImportEventArgs
    {
        protected ImportEventArgsWrapper(ImportEventArgs instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IImportEventArgs, ImportEventArgs>(src => src == null ? null : ((ImportEventArgsWrapper) src).r_Instance, src => new ImportEventArgsWrapper(src)); }
    }


    internal class ImportEventArgsWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IImportEventArgs where TInterface : class where TWrapper : class
    {
        Exception IImportEventArgs.Exception
        {
            get
            {
                Exception nativeCallResult = r_Instance.Exception;
                return nativeCallResult;
            }
        }

        String IImportEventArgs.Message
        {
            get
            {
                string nativeCallResult = r_Instance.Message;
                return nativeCallResult;
            }
        }

        IImportSeverity IImportEventArgs.Severity
        {
            get
            {
                ImportSeverity nativeCallResult = r_Instance.Severity;
                IImportSeverity wrappedCallResult = ImportSeverityWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        protected ImportEventArgsWrapper(ImportEventArgs instance) { r_Instance = instance; }
        protected readonly ImportEventArgs r_Instance;
    }
}