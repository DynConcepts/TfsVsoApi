using System;
using System.Collections.Generic;
using System.Reflection;
using DynCon.OSI.Core.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynCon.OSI.VSO.ReSTClient.UnitTests.OriginalManualTfs.WorkItemTracking.Client
{
    /// <summary>
    ///     Class UnitTestBase.
    /// </summary>
    public class UnitTestBase
    {
        /// <summary>
        ///     Reads all properties.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="instance">The instance.</param>
        protected static void ReadAllProperties(Type type, object instance)
        {
            PropertyInfo[] properties = type.GetProperties();
            Console.WriteLine("{0} Properties Found", properties.Length);
            var missingImplementations = new List<string>();
            foreach (PropertyInfo property in properties)
            {
                if (property.CanRead && !property.CanWrite && property.GetIndexParameters().Length == 0)
                {
                    MethodInfo getter = property.GetGetMethod();
                    try
                    {
                        object value = getter.Invoke(instance, new object[] {});
                        Console.WriteLine("Invoked {0}", property.Name);
                    }
                    catch (TargetInvocationException ex)
                    {
                        if (ex.InnerException is ToBeImplementedException)
                        {
                            missingImplementations.Add(property.Name);
                            Console.WriteLine("{0} Still needs to be Implemented", property.Name);
                        }
                        else
                        {
                            Console.WriteLine(ex.Message);
                            throw;
                        }
                    }
                    catch (ToBeImplementedException)
                    {
                        missingImplementations.Add(property.Name);
                        Console.WriteLine("{0} Still needs to be Implemented", property.Name);
                    }
                    catch
                    {
                        Console.WriteLine();
                        throw;
                    }
                }
            }
            //if (missingImplementations.Count > 0)
            //    Assert.Inconclusive();
        }
    }
}