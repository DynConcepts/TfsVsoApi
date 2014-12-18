using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DynCon.OSI.Core.Helpers
{
    /// <summary>
    ///     Class DerivedClassDiscovery.
    /// </summary>
    public static class DerivedClassDiscovery
    {
        /// <summary>
        ///     Finds the derived.
        /// </summary>
        /// <param name="baseType">Type of the base.</param>
        /// <returns>IEnumerable&lt;Type&gt;.</returns>
        public static IEnumerable<Type> FindDerived(Type baseType) { return FindDerived(baseType, baseType.Assembly); }

        /// <summary>
        ///     Finds the derived.
        /// </summary>
        /// <param name="baseType">Type of the base.</param>
        /// <param name="assembly">The assembly.</param>
        /// <returns>IEnumerable&lt;Type&gt;.</returns>
        public static IEnumerable<Type> FindDerived(Type baseType, Assembly assembly) { return assembly.GetTypes().Where(baseType.IsAssignableFrom).ToList(); }
    }
}