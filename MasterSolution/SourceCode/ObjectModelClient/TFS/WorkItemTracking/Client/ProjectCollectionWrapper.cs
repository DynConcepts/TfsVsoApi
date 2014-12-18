using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    internal class ProjectCollectionWrapper : ProjectCollectionWrapper<IProjectCollection, ProjectCollection>, IProjectCollection
    {
        protected ProjectCollectionWrapper(ProjectCollection instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IProjectCollection, ProjectCollection>(src => ((ProjectCollectionWrapper) src).r_Instance, src => new ProjectCollectionWrapper(src)); }
    }


    internal class ProjectCollectionWrapper<TWrapper, TInterface> : ReadOnlyListWrapper<TWrapper, TInterface, Project, IProject>, IProjectCollection where TInterface : class where TWrapper : class
    {

        Boolean IProjectCollection.Contains(String projectName)
        {
            bool nativeCallResult = r_Instance.Contains(projectName);
            return nativeCallResult;
        }

        Boolean IProjectCollection.Contains(IProject value)
        {
            bool nativeCallResult = r_Instance.Contains(ProjectWrapper.GetInstance(value));
            return nativeCallResult;
        }


        IProject IProjectCollection.GetById(Int32 projectId)
        {
            Project nativeCallResult = r_Instance.GetById(projectId);
            IProject wrappedCallResult = ProjectWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }


        Int32 IProjectCollection.IndexOf(IProject value)
        {
            int nativeCallResult = r_Instance.IndexOf(ProjectWrapper.GetInstance(value));
            return nativeCallResult;
        }



        IProject IProjectCollection.this[Int32 index]
        {
            get
            {
                Project nativeCallResult = r_Instance[index];
                IProject wrappedCallResult = ProjectWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        IProject IProjectCollection.this[String projectName]
        {
            get
            {
                Project nativeCallResult = r_Instance[projectName];
                IProject wrappedCallResult = ProjectWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        protected ProjectCollectionWrapper(ProjectCollection instance)
            : base(instance, o => ProjectWrapper.GetWrapper((Project) o)) { r_Instance = instance; }

        protected new readonly ProjectCollection r_Instance;
    }
}