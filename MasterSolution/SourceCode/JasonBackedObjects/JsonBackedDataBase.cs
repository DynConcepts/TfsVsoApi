using System;
using System.Collections.Generic;
using System.Reflection;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.JasonBackedObjects
{
    /// <summary>
    /// Class JsonBackedDataBase.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class JsonBackedDataBase<T>
    {
        /// <summary>
        /// Makes the token.
        /// </summary>
        /// <typeparam name="TValue">The type of the t value.</typeparam>
        /// <param name="value">The value.</param>
        /// <returns>JToken.</returns>
        public static JToken MakeToken<TValue>(TValue value)
        {

            var converters = new Dictionary<Type, MethodInfo>();
            var methods = typeof(JToken).GetMethods();
            foreach (var method in methods)
            {
                if ((method.Name == "op_Implicit") && (method.ReturnType == typeof (JToken)))
                {
                    converters.Add(method.GetParameters()[0].ParameterType, method);
                }
            }
            var converter = converters[value.GetType()];
            var converted = (JToken) converter.Invoke(null, new object[] {value});
            JToken token = converted;
            return token;
        }

    }
}