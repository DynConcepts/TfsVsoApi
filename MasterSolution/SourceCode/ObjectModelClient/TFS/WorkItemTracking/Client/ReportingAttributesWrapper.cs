using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class ReportingAttributesWrapper : ReportingAttributesWrapper<IReportingAttributes, ReportingAttributes>, IReportingAttributes
    {
        protected ReportingAttributesWrapper(ReportingAttributes instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IReportingAttributes, ReportingAttributes>(src => src == null ? null : ((ReportingAttributesWrapper) src).r_Instance, src => new ReportingAttributesWrapper(src)); }
    }


    internal class ReportingAttributesWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IReportingAttributes where TInterface : class where TWrapper : class
    {
        String IReportingAttributes.Name
        {
            get
            {
                string nativeCallResult = r_Instance.Name;
                return nativeCallResult;
            }
        }

        String IReportingAttributes.ReferenceName
        {
            get
            {
                string nativeCallResult = r_Instance.ReferenceName;
                return nativeCallResult;
            }
        }

        IReportingType IReportingAttributes.Type
        {
            get
            {
                ReportingType nativeCallResult = r_Instance.Type;
                IReportingType wrappedCallResult = ReportingTypeWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        protected ReportingAttributesWrapper(ReportingAttributes instance) { r_Instance = instance; }
        protected readonly ReportingAttributes r_Instance;
    }
}