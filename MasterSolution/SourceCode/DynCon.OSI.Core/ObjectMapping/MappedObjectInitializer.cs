using System;
using System.Collections.Generic;
using System.Reflection;

namespace DynCon.OSI.Core.ObjectMapping
{
    /// <summary>
    ///     Class MappedObjectInitializer.
    /// </summary>
    public static class MappedObjectInitializer
    {
        /// <summary>
        ///     Initializes static members of the <see cref="MappedObjectInitializer" /> class.
        /// </summary>
        static MappedObjectInitializer() { ScanTypes(Assembly.GetExecutingAssembly()); }

        /// <summary>
        ///     Forces the initialize.
        /// </summary>
        public static void ForceInitialize() { }


        private static List<String> _loaded = new List<string>();

        /// <summary>
        /// Forces the initialize.
        /// </summary>
        /// <param name="assembly">The assembly.</param>
        public static void ForceInitialize(Assembly assembly) { ScanTypes(assembly); }

        private static readonly object sr_Syncroot = new object();

        private static void ScanTypes(Assembly assembly)
        {
            lock (sr_Syncroot)
            {
                if (_loaded.Contains(assembly.FullName))
                    return;
                Type[] types = assembly.GetTypes();
                foreach (Type type in types)
                {
                    if ((!type.ContainsGenericParameters) && typeof (MappedObjectBase).IsAssignableFrom(type))
                    {
                        MethodInfo methodInfo = type.GetMethod("SetMapper", BindingFlags.Static | BindingFlags.NonPublic);
                        if (methodInfo != null)
                            methodInfo.Invoke(null, new object[] {});
                    }
                }
                _loaded.Add(assembly.FullName);
            }
        }
}
}