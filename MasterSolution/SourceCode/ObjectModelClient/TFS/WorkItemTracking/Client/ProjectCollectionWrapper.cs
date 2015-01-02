using System;
using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Class ProjectCollectionWrapper.
    /// </summary>
    internal class ProjectCollectionWrapper : ProjectCollectionWrapper<IProjectCollection, ProjectCollection>, IProjectCollection
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectCollectionWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected ProjectCollectionWrapper(ProjectCollection instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<IProjectCollection, ProjectCollection>(src => src == null ? null : ((ProjectCollectionWrapper) src).r_Instance, src => new ProjectCollectionWrapper(src)); }
    }


    /// <summary>
    /// Class ProjectCollectionWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal class ProjectCollectionWrapper<TWrapper, TInterface> : ReadOnlyListWrapper<TWrapper, TInterface, Project, IProject>, IProjectCollection where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Determines whether [contains] [the specified project name].
        /// </summary>
        /// <param name="projectName">Name of the project.</param>
        /// <returns>Boolean.</returns>
        Boolean IProjectCollection.Contains(String projectName)
        {
            bool nativeCallResult = r_Instance.Contains(projectName);
            return nativeCallResult;
        }

        /// <summary>
        /// Determines whether [contains] [the specified value].
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Boolean.</returns>
        Boolean IProjectCollection.Contains(IProject value)
        {
            bool nativeCallResult = r_Instance.Contains(ProjectWrapper.GetInstance(value));
            return nativeCallResult;
        }


        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="projectId">The project identifier.</param>
        /// <returns>IProject.</returns>
        IProject IProjectCollection.GetById(Int32 projectId)
        {
            Project nativeCallResult = r_Instance.GetById(projectId);
            IProject wrappedCallResult = ProjectWrapper.GetWrapper(nativeCallResult);
            return wrappedCallResult;
        }


        /// <summary>
        /// Indexes the of.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Int32.</returns>
        Int32 IProjectCollection.IndexOf(IProject value)
        {
            int nativeCallResult = r_Instance.IndexOf(ProjectWrapper.GetInstance(value));
            return nativeCallResult;
        }


        /// <summary>
        /// Gets the <see cref="IProject" /> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>IProject.</returns>
        IProject IProjectCollection.this[Int32 index]
        {
            get
            {
                Project nativeCallResult = r_Instance[index];
                IProject wrappedCallResult = ProjectWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Gets the <see cref="IProject" /> with the specified project name.
        /// </summary>
        /// <param name="projectName">Name of the project.</param>
        /// <returns>IProject.</returns>
        IProject IProjectCollection.this[String projectName]
        {
            get
            {
                Project nativeCallResult = r_Instance[projectName];
                IProject wrappedCallResult = ProjectWrapper.GetWrapper(nativeCallResult);
                return wrappedCallResult;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectCollectionWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected ProjectCollectionWrapper(ProjectCollection instance)
            : base(instance, o => ProjectWrapper.GetWrapper((Project) o)) { r_Instance = instance; }

        /// <summary>
        /// The r_ instance
        /// </summary>
        protected new readonly ProjectCollection r_Instance;
    }
}