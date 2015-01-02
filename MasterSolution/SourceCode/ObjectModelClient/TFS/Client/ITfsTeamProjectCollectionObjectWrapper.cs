using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using Microsoft.TeamFoundation.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Client
{
    /// <summary>
    /// Class ITfsTeamProjectCollectionObjectWrapper.
    /// </summary>
    internal class ITfsTeamProjectCollectionObjectWrapper : ITfsTeamProjectCollectionObjectWrapper<IITfsTeamProjectCollectionObject, ITfsTeamProjectCollectionObject>, IITfsTeamProjectCollectionObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ITfsTeamProjectCollectionObjectWrapper"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected ITfsTeamProjectCollectionObjectWrapper(ITfsTeamProjectCollectionObject instance) : base(instance) { }
        /// <summary>
        /// Sets the mapper.
        /// </summary>
        internal static void SetMapper() { Mapper = new ObjectMapper<IITfsTeamProjectCollectionObject, ITfsTeamProjectCollectionObject>(src => src == null ? null : ((ITfsTeamProjectCollectionObjectWrapper) src).r_Instance, src => new ITfsTeamProjectCollectionObjectWrapper(src)); }
    }


    /// <summary>
    /// Class ITfsTeamProjectCollectionObjectWrapper.
    /// </summary>
    /// <typeparam name="TWrapper">The type of the t wrapper.</typeparam>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    internal abstract class ITfsTeamProjectCollectionObjectWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IITfsTeamProjectCollectionObject where TInterface : class where TWrapper : class
    {
        /// <summary>
        /// Initializes the specified project collection.
        /// </summary>
        /// <param name="projectCollection">The project collection.</param>
        void IITfsTeamProjectCollectionObject.Initialize(ITfsTeamProjectCollection projectCollection) { r_Instance.Initialize(TfsTeamProjectCollectionWrapper.GetInstance(projectCollection)); }
        /// <summary>
        /// Initializes a new instance of the <see cref="ITfsTeamProjectCollectionObjectWrapper{TWrapper, TInterface}"/> class.
        /// </summary>
        /// <param name="instance">The instance.</param>
        protected ITfsTeamProjectCollectionObjectWrapper(ITfsTeamProjectCollectionObject instance) { r_Instance = instance; }
        /// <summary>
        /// The r_ instance
        /// </summary>
        protected readonly ITfsTeamProjectCollectionObject r_Instance;
    }
}