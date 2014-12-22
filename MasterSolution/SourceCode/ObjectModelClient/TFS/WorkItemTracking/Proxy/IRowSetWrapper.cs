using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;
using IRowSet = Microsoft.TeamFoundation.WorkItemTracking.Proxy.IRowSet;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy
{
    internal class IRowSetWrapper : IRowSetWrapper<IIRowSet, IRowSet>, IIRowSet
    {
        protected IRowSetWrapper(IRowSet instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IIRowSet, IRowSet>(src => src == null ? null : ((IRowSetWrapper) src).r_Instance, src => new IRowSetWrapper(src)); }
    }


    internal abstract class IRowSetWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IIRowSet where TInterface : class where TWrapper : class
    {
        Int32 IIRowSet.ColumnCount
        {
            get
            {
                int nativeCallResult = r_Instance.ColumnCount;
                return nativeCallResult;
            }
        }

        Boolean IIRowSet.ContainsColumn(String name)
        {
            bool nativeCallResult = r_Instance.ContainsColumn(name);
            return nativeCallResult;
        }

        String IIRowSet.this[Int32 column]
        {
            get
            {
                string nativeCallResult = r_Instance[column];
                return nativeCallResult;
            }
        }

        Object IIRowSet.this[Int32 column, Int32 row]
        {
            get
            {
                object nativeCallResult = r_Instance[column, row];
                return nativeCallResult;
            }
        }

        Object IIRowSet.this[String column, Int32 row]
        {
            get
            {
                object nativeCallResult = r_Instance[column, row];
                return nativeCallResult;
            }
        }

        Int32 IIRowSet.RowCount
        {
            get
            {
                int nativeCallResult = r_Instance.RowCount;
                return nativeCallResult;
            }
        }

        void IIRowSet.SwapRows(Int32 row1, Int32 row2) { r_Instance.SwapRows(row1, row2); }
        protected IRowSetWrapper(IRowSet instance) { r_Instance = instance; }
        protected readonly IRowSet r_Instance;
    }
}