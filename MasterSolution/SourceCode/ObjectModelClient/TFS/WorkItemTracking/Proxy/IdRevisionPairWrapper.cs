using System;
using System.Xml;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Proxy;
using Microsoft.TeamFoundation.WorkItemTracking.Proxy;

namespace DynCon.OSI.VSO.ObjectModelClient.TFS.WorkItemTracking.Proxy
{
    internal struct IdRevisionPairWrapper : IIdRevisionPair
    {
        public static IdRevisionPair GetInstance(IIdRevisionPair src) { return default(IdRevisionPair); }
        public static IdRevisionPair[] GetInstance(IIdRevisionPair[] src) { return null; }
        public static IdRevisionPairWrapper GetWrapper(IdRevisionPair src) { return default(IdRevisionPairWrapper); }
        public static IIdRevisionPair[] GetWrapper(IdRevisionPair[] src) { return null; }

        Int32 IIdRevisionPair.Id
        {
            get
            {
                int nativeCallResult = r_Instance.Id;
                return nativeCallResult;
            }
            set { r_Instance.Id = value; }
        }

        Int32 IIdRevisionPair.Revision
        {
            get
            {
                int nativeCallResult = r_Instance.Revision;
                return nativeCallResult;
            }
            set { r_Instance.Revision = value; }
        }

        void IIdRevisionPair.ToXml(XmlWriter writer, String element) { r_Instance.ToXml(writer, element); }
        private IdRevisionPairWrapper(IdRevisionPair instance) { r_Instance = instance; }
        private IdRevisionPair r_Instance;
    }
}