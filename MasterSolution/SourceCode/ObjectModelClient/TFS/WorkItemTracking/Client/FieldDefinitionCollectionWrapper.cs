using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class FieldDefinitionCollectionWrapper : FieldDefinitionCollectionWrapper<IFieldDefinitionCollection, FieldDefinitionCollection>, IFieldDefinitionCollection
    {
        protected FieldDefinitionCollectionWrapper(FieldDefinitionCollection instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IFieldDefinitionCollection, FieldDefinitionCollection>(src => ((FieldDefinitionCollectionWrapper) src).r_Instance, src => new FieldDefinitionCollectionWrapper(src)); }
    }


    internal class FieldDefinitionCollectionWrapper<TWrapper, TInterface> : ReadOnlyListWrapper<TWrapper, TInterface, FieldDefinition, IFieldDefinition>, IFieldDefinitionCollection
        where TInterface : class
        where TWrapper : class
    {

        Boolean IFieldDefinitionCollection.Contains(String name)
        {
            bool nativeCallResult = r_Instance.Contains(name);
            return nativeCallResult;
        }




        Boolean IFieldDefinitionCollection.Contains(Int32 id)
        {
            bool nativeCallResult = r_Instance.Contains(id);
            return nativeCallResult;
        }




        Boolean IFieldDefinitionCollection.Contains(IFieldDefinition fieldDefinition)
        {
            bool nativeCallResult = r_Instance.Contains(FieldDefinitionWrapper.GetInstance(fieldDefinition));
            return nativeCallResult;
        }

        IFieldDefinition IFieldDefinitionCollection.GetById(Int32 id)
        {
            FieldDefinition nativeCallResult = r_Instance.GetById(id);
            IFieldDefinition wrappedCallResult = FieldDefinitionWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        Int32 IFieldDefinitionCollection.IndexOf(IFieldDefinition fieldDefinition)
        {
            int nativeCallResult = r_Instance.IndexOf(FieldDefinitionWrapper.GetInstance(fieldDefinition));
            return nativeCallResult;
        }

        IFieldDefinition IFieldDefinitionCollection.this[Int32 index]
        {
            get
            {
                FieldDefinition nativeCallResult = r_Instance[index];
                IFieldDefinition wrappedCallResult = FieldDefinitionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        IFieldDefinition IFieldDefinitionCollection.this[ICoreField coreField]
        {
            get
            {
                FieldDefinition nativeCallResult = r_Instance[CoreFieldWrapper.GetInstance(coreField)];
                IFieldDefinition wrappedCallResult = FieldDefinitionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        IFieldDefinition IFieldDefinitionCollection.this[String name]
        {
            get
            {
                FieldDefinition nativeCallResult = r_Instance[name];
                IFieldDefinition wrappedCallResult = FieldDefinitionWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        IFieldDefinition IFieldDefinitionCollection.TryGetById(Int32 id)
        {
            FieldDefinition nativeCallResult = r_Instance.TryGetById(id);
            IFieldDefinition wrappedCallResult = FieldDefinitionWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }


        IFieldDefinition IFieldDefinitionCollection.TryGetByName(String name)
        {
            FieldDefinition nativeCallResult = r_Instance.TryGetByName(name);
            IFieldDefinition wrappedCallResult = FieldDefinitionWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }

        protected FieldDefinitionCollectionWrapper(FieldDefinitionCollection instance)
            : base(instance, o => FieldDefinitionWrapper.GetWrapper((FieldDefinition) o)) { r_Instance = instance; }

        protected new readonly FieldDefinitionCollection r_Instance;
    }
}