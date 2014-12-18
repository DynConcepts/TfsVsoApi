using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common.DataStore;
using Microsoft.TeamFoundation.WorkItemTracking.Common.DataStore;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Common.DataStore
{
    internal static class PsFieldDefinitionTypeEnumWrapper
    {
        public static PsFieldDefinitionTypeEnum GetInstance(IPsFieldDefinitionTypeEnum src) { return default(PsFieldDefinitionTypeEnum); }

        public static PsFieldDefinitionTypeEnum[] GetInstance(IPsFieldDefinitionTypeEnum[] src) { return null; }
        public static IPsFieldDefinitionTypeEnum GetWrapper(PsFieldDefinitionTypeEnum src) { return default(IPsFieldDefinitionTypeEnum); }
        public static IPsFieldDefinitionTypeEnum[] GetWrapper(PsFieldDefinitionTypeEnum[] src) { return null; }
    }
}