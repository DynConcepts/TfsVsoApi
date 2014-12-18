using DynCon.OSI.Core.ObjectMapping;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client;
using Microsoft.TeamFoundation.Client;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.Client
{
    internal class ITfsTeamProjectCollectionObjectWrapper : ITfsTeamProjectCollectionObjectWrapper<IITfsTeamProjectCollectionObject, ITfsTeamProjectCollectionObject>, IITfsTeamProjectCollectionObject
    {
        protected ITfsTeamProjectCollectionObjectWrapper(ITfsTeamProjectCollectionObject instance) : base(instance) { }
        internal static void SetMapper() { Mapper = new ObjectMapper<IITfsTeamProjectCollectionObject, ITfsTeamProjectCollectionObject>(src => src==null ? null : ((ITfsTeamProjectCollectionObjectWrapper) src).r_Instance, src => new ITfsTeamProjectCollectionObjectWrapper(src)); }
    }


    internal abstract class ITfsTeamProjectCollectionObjectWrapper<TWrapper, TInterface> : MappedObjectBase<TWrapper, TInterface>, IITfsTeamProjectCollectionObject where TInterface : class where TWrapper : class
    {

        void IITfsTeamProjectCollectionObject.Initialize(ITfsTeamProjectCollection projectCollection) { r_Instance.Initialize(TfsTeamProjectCollectionWrapper.GetInstance(projectCollection)); }
        protected ITfsTeamProjectCollectionObjectWrapper(ITfsTeamProjectCollectionObject instance) { r_Instance = instance; }
        protected readonly ITfsTeamProjectCollectionObject r_Instance;
    }
}