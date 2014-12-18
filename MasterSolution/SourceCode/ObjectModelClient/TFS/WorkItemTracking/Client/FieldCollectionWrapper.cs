using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class FieldCollectionWrapper : FieldCollectionWrapper<IFieldCollection, FieldCollection>, IFieldCollection
    {
        protected FieldCollectionWrapper(FieldCollection instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IFieldCollection, FieldCollection>(src => src==null ? null : ((FieldCollectionWrapper) src).r_Instance, src => new FieldCollectionWrapper(src)); }
    }


    internal class FieldCollectionWrapper<TWrapper, TInterface> : ReadOnlyListWrapper<TWrapper, TInterface, Field, IField>, IFieldCollection where TInterface : class where TWrapper : class
    {

        Boolean IFieldCollection.Contains(String fieldName)
        {
            bool nativeCallResult = r_Instance.Contains(fieldName);
            return nativeCallResult;
        }


        Boolean IFieldCollection.Contains(Int32 id)
        {
            bool nativeCallResult = r_Instance.Contains(id);
            return nativeCallResult;
        }

        Boolean IFieldCollection.Contains(IField value)
        {
            bool nativeCallResult = r_Instance.Contains(FieldWrapper.GetInstance(value));
            return nativeCallResult;
        }


        void IFieldCollection.DropCachedData() { r_Instance.DropCachedData(); }

        IField IFieldCollection.GetById(Int32 id)
        {
            Field nativeCallResult = r_Instance.GetById(id);
            IField wrappedCallResult = FieldWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }


        Int32 IFieldCollection.IndexOf(IField value)
        {
            int nativeCallResult = r_Instance.IndexOf(FieldWrapper.GetInstance(value));
            return nativeCallResult;
        }



        IField IFieldCollection.this[Int32 index]
        {
            get
            {
                Field nativeCallResult = r_Instance[index];
                IField wrappedCallResult = FieldWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        IField IFieldCollection.this[ICoreField coreField]
        {
            get
            {
                Field nativeCallResult = r_Instance[CoreFieldWrapper.GetInstance(coreField)];
                IField wrappedCallResult = FieldWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        IField IFieldCollection.this[String name]
        {
            get
            {
                Field nativeCallResult = r_Instance[name];
                IField wrappedCallResult = FieldWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        IField IFieldCollection.TryGetById(Int32 id)
        {
            Field nativeCallResult = r_Instance.TryGetById(id);
            IField wrappedCallResult = FieldWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        protected FieldCollectionWrapper(FieldCollection instance) : base(instance, o => FieldWrapper.GetWrapper((Field) o)) { r_Instance = instance; }
        protected new readonly FieldCollection r_Instance;
    }
}