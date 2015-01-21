using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using DynCon.OSI.VSO.ObjectModelClient.TFS.Framework.Common;
using DynCon.OSI.VSO.SharedInterfaces.TFS.Framework.Client;
using Microsoft.TeamFoundation.Framework.Client;
using Microsoft.TeamFoundation.Framework.Common;

namespace DynCon.OSI.VSO.ObjectModelClient_UnitTests.TFS.Framework.Client
{
    /// <summary>Generated Test Template</summary>
    public partial class ServiceDefinitionWrapper_UnitTests
    {
        static partial void RealInstanceFactory(ref ServiceDefinition real, string callerName)
        {
            real = (ServiceDefinition)FormatterServices.GetUninitializedObject(typeof(ServiceDefinition));
        }

        partial void AddLocationMapping_PreCondition(IServiceDefinition instance, ref IAccessMapping accessMapping, ref String location)
        {
            instance.RelativeToSetting = RelativeToSettingWrapper.GetWrapper(RelativeToSetting.Context);
        }

        /// <summary>
        ///     Gets the disabled tests.
        /// </summary>
        /// <value>The disabled tests.</value>
        protected override List<String> DisabledTests { get { return sr_DisabledTests; } }

        private static readonly List<String> sr_DisabledTests = new List<string>
        {
            "AddLocationMapping_UnitTest",
            "LocationMappings_UnitTest",
            "RemoveLocationMapping_UnitTest",
        };

    }
}