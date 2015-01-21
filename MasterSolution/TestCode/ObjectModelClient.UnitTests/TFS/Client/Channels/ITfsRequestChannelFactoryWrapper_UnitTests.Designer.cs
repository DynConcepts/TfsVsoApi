using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.ObjectModelClient.TFS.Client.Channels;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels;
using Microsoft.TeamFoundation.Client.Channels;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Client.Channels
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class ITfsRequestChannelFactoryWrapper_UnitTests : DynTestClassBase
    {
        /// <summary>Generated Test Template</summary>
        [TestMethod]
        public void CreateChannel_UnitTest()
        {
            IITfsRequestChannel innerChannel = default(IITfsRequestChannel);
            ExecuteMethod(
                () => { return (IITfsRequestChannelFactory) GetInstance(); },
                instance =>
                {
                    innerChannel = ITfsRequestChannelWrapper_UnitTests.GetInstance();
                    CreateChannel_PreCondition(instance, ref innerChannel);
                },
                instance => { instance.CreateChannel(innerChannel); },
                instance => { CreateChannel_PostValidate(instance, innerChannel); });
        }

        partial void CreateChannel_PostValidate(IITfsRequestChannelFactory instance, IITfsRequestChannel innerChannel);
        partial void CreateChannel_PreCondition(IITfsRequestChannelFactory instance, ref IITfsRequestChannel innerChannel);
        internal static IEnumerable<ITfsRequestChannelFactoryWrapper> GetIEnumerableInstance() { return new List<ITfsRequestChannelFactoryWrapper> {GetInstance()}; }

        internal static ITfsRequestChannelFactoryWrapper GetInstance()
        {
            ITfsRequestChannelFactory real = default(ITfsRequestChannelFactory);
            RealInstanceFactory(ref real);
            var instance = (ITfsRequestChannelFactoryWrapper) ITfsRequestChannelFactoryWrapper.GetWrapper(real);
            InstanceFactory(ref instance);
            if (instance == null) Assert.Inconclusive("Could not Create Test Instance");
            return instance;
        }

        static partial void InstanceFactory(ref ITfsRequestChannelFactoryWrapper instance, [CallerMemberName] string callerName = "");

        static partial void RealInstanceFactory(ref ITfsRequestChannelFactory real, [CallerMemberName] string callerName = "");
    }
}