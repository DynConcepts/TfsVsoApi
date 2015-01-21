using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DynCon.OSI.DynTest;
using DynCon.OSI.VSO.RestClient.ObjectModel.TFS.Client.Channels;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Client.Channels;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace      DynCon.OSI.VSO.RestClient.ObjectModel_UnitTests.TFS.Client.Channels
{
    /// <summary>Generated Test Template</summary>
    [TestClass]
    public partial class ITfsRequestChannelFactoryImpl_UnitTests : DynTestClassBase
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
                    innerChannel = ITfsRequestChannelImpl_UnitTests.GetInstance();
                    CreateChannel_PreCondition(instance, ref innerChannel);
                },
                instance => { instance.CreateChannel(innerChannel); },
                instance => { CreateChannel_PostValidate(instance, innerChannel); });
        }

        partial void CreateChannel_PostValidate(IITfsRequestChannelFactory instance, IITfsRequestChannel innerChannel);
        partial void CreateChannel_PreCondition(IITfsRequestChannelFactory instance, ref IITfsRequestChannel innerChannel);
        internal static IEnumerable<ITfsRequestChannelFactoryImpl> GetIEnumerableInstance() { return new List<ITfsRequestChannelFactoryImpl> {GetInstance()}; }

        internal static ITfsRequestChannelFactoryImpl GetInstance([CallerMemberName] string callerName = "")
        {
            var instance = new ITfsRequestChannelFactoryImpl();
            InstanceFactory(ref instance, callerName);
            return instance;
        }

        static partial void InstanceFactory(ref ITfsRequestChannelFactoryImpl instance, [CallerMemberName] string callerName = "");
    }
}