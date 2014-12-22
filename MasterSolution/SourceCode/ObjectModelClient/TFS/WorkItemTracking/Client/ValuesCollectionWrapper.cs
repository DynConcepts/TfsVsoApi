using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class ValuesCollectionWrapper : ValuesCollectionWrapper<IValuesCollection, ValuesCollection>, IValuesCollection
    {
        protected ValuesCollectionWrapper(ValuesCollection instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IValuesCollection, ValuesCollection>(src => src == null ? null : ((ValuesCollectionWrapper) src).r_Instance, src => new ValuesCollectionWrapper(src)); }
    }


    internal class ValuesCollectionWrapper<TWrapper, TInterface> : ReadOnlyListWrapper<TWrapper, TInterface, Object, Object>, IValuesCollection where TInterface : class where TWrapper : class
    {
        Boolean IValuesCollection.Contains(String value)
        {
            bool nativeCallResult = r_Instance.Contains(value);
            return nativeCallResult;
        }


        Int32 IValuesCollection.IndexOf(String value)
        {
            int nativeCallResult = r_Instance.IndexOf(value);
            return nativeCallResult;
        }

        String IValuesCollection.this[Int32 index]
        {
            get
            {
                string nativeCallResult = r_Instance[index];
                return nativeCallResult;
            }
        }

        protected ValuesCollectionWrapper(ValuesCollection instance)
            : base(instance, o => (TInterface) o) { r_Instance = instance; }

        protected new readonly ValuesCollection r_Instance;
    }
}