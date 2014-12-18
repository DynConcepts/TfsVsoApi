using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.JasonBackedObjects
{
    /// <summary>
    ///     Class JsonBackedList.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class JsonBackedList<T>
    {
        /// <summary>
        ///     Evals the specified json.
        /// </summary>
        /// <param name="json">The json.</param>
        /// <returns>IReadOnlyList&lt;T&gt;.</returns>
        public IReadOnlyList<T> Eval(JToken json)
        {
            IReadOnlyList<T> retVal = r_Func(json);
            return retVal;
        }

        /// <summary>
        ///     Evals the specified instance.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <returns>IReadOnlyList&lt;T&gt;.</returns>
        public IReadOnlyList<T> Eval(JsonBackedObjectBase instance) { return Eval(instance.JsonValue); }

        /// <summary>
        ///     Initializes a new instance of the <see cref="JsonBackedList{T}" /> class.
        /// </summary>
        /// <param name="func">The function.</param>
        public JsonBackedList(Func<JToken, IReadOnlyList<T>> func) { r_Func = func; }

        /// <summary>
        ///     The _func
        /// </summary>
        private readonly Func<JToken, IReadOnlyList<T>> r_Func;
    }
}