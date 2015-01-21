using System;
using System.Runtime.Remoting.Messaging;
using DynCon.OSI.DynTest;
using DynCon.OSI.JasonBackedObjects.Communications;

namespace DynCon.OSI.JasonBackedObjects_UnitTests.Communications
{
    /// <summary>Generated Test Template</summary>
    public partial class StructuredHttpExchange_UnitTests : DynTestClassBase
    {
        static partial void InstanceFactory(ref StructuredHttpExchange instance, string callerName)
        {
            instance = StructuredHttpExchange.Get("http://example.com/{test}");
        }

        partial void SetRoute_PreCondition(ref StructuredHttpExchange instance, ref String key, ref Object value)
        {
            key = "{test}";
            value = "Testing";
        }
        partial void SetQuery_PreCondition(ref StructuredHttpExchange instance, ref String key, ref Object value)
        {
            key = "query";
            value = "Testing";
        }

        partial void BaseRoute_SetCondition(ref StructuredHttpExchange instance, ref String setValue)
        {
            setValue = "";
        }

        partial void Get_PreCondition(ref StructuredHttpExchange instance, ref CallSpec spec)
        {
            spec = new CallSpec("http://www.example.com");
        }


    }
}