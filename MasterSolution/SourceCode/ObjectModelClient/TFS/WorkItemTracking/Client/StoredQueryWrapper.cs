using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class StoredQueryWrapper : StoredQueryWrapper<IStoredQuery, StoredQuery>, IStoredQuery, IComparable
    {
        protected StoredQueryWrapper(StoredQuery instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IStoredQuery, StoredQuery>(src => src==null ? null : ((StoredQueryWrapper) src).r_Instance, src => new StoredQueryWrapper(src)); }
    }


    internal class StoredQueryWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IStoredQuery where TInterface : class where TWrapper : class
    {

        Int32 IStoredQuery.CompareTo(IStoredQuery storedQuery)
        {
            int nativeCallResult = r_Instance.CompareTo(StoredQueryWrapper.GetInstance(storedQuery));
            return nativeCallResult;
        }


        Int32 IComparable.CompareTo(Object obj)
        {
            int nativeCallResult = ((IComparable) r_Instance).CompareTo(obj);
            return nativeCallResult;
        }

        DateTime IStoredQuery.CreationTime
        {
            get
            {
                DateTime nativeCallResult = r_Instance.CreationTime;
                return nativeCallResult;
            }
        }

        DateTime IStoredQuery.CreationTimeUtc
        {
            get
            {
                DateTime nativeCallResult = r_Instance.CreationTimeUtc;
                return nativeCallResult;
            }
        }

        String IStoredQuery.Description
        {
            get
            {
                string nativeCallResult = r_Instance.Description;
                return nativeCallResult;
            }
            set { r_Instance.Description = value; }
        }

        Boolean IStoredQuery.IsSaved
        {
            get
            {
                bool nativeCallResult = r_Instance.IsSaved;
                return nativeCallResult;
            }
        }

        DateTime IStoredQuery.LastWriteTime
        {
            get
            {
                DateTime nativeCallResult = r_Instance.LastWriteTime;
                return nativeCallResult;
            }
        }

        DateTime IStoredQuery.LastWriteTimeUtc
        {
            get
            {
                DateTime nativeCallResult = r_Instance.LastWriteTimeUtc;
                return nativeCallResult;
            }
        }

        String IStoredQuery.Name
        {
            get
            {
                string nativeCallResult = r_Instance.Name;
                return nativeCallResult;
            }
            set { r_Instance.Name = value; }
        }

        String IStoredQuery.Owner
        {
            get
            {
                string nativeCallResult = r_Instance.Owner;
                return nativeCallResult;
            }
        }

        IProject IStoredQuery.Project
        {
            get
            {
                Project nativeCallResult = r_Instance.Project;
                IProject wrappedCallResult = ProjectWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        Guid IStoredQuery.QueryGuid
        {
            get
            {
                Guid nativeCallResult = r_Instance.QueryGuid;
                return nativeCallResult;
            }
        }

        IQueryScope IStoredQuery.QueryScope
        {
            get
            {
                QueryScope nativeCallResult = r_Instance.QueryScope;
                IQueryScope wrappedCallResult = QueryScopeWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
            set
            {
                QueryScope nativeValue = QueryScopeWrapper.GetInstance(value);

                r_Instance.QueryScope = nativeValue;
            }
        }

        String IStoredQuery.QueryText
        {
            get
            {
                string nativeCallResult = r_Instance.QueryText;
                return nativeCallResult;
            }
            set { r_Instance.QueryText = value; }
        }

        void IStoredQuery.Reset() { r_Instance.Reset(); }

        void IStoredQuery.Update() { r_Instance.Update(); }
        protected StoredQueryWrapper(StoredQuery instance) { r_Instance = instance; }
        protected readonly StoredQuery r_Instance;
    }
}