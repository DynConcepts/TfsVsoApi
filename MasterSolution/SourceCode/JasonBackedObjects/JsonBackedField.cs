using System;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.JasonBackedObjects
{
    /// <summary>
    /// Class JsonBackedField.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class JsonBackedField<T> : JsonBackedDataBase<T>
    {
        /// <summary>
        /// The _func
        /// </summary>
        private readonly Func<JToken, T> _func;

        /// <summary>
        /// The _action
        /// </summary>
        private readonly Action<JToken, T> _action;

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonBackedField{T}" /> class.
        /// </summary>
        /// <param name="func">The function.</param>
        public JsonBackedField(Func<JToken, T> func) { _func = func; }

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonBackedField{T}"/> class.
        /// </summary>
        /// <param name="func">The function.</param>
        /// <param name="action">The action.</param>
        public JsonBackedField(Func<JToken, T> func, Action<JToken, T> action)
        {
            _func = func;
            _action = action;
        }


        /// <summary>
        /// Sets the specified json.
        /// </summary>
        /// <param name="json">The json.</param>
        /// <param name="value">The value.</param>
        public void Set(JToken json, T value) { _action(json, value); }

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonBackedField{T}" /> class.
        /// </summary>
        /// <param name="key">The key.</param>
        public JsonBackedField(string key) : this(token => token[key].Value<T>(), (token, value) => token.Replace(MakeToken(value))) { }

        /// <summary>
        /// Evals the specified json.
        /// </summary>
        /// <param name="json">The json.</param>
        /// <returns>T.</returns>
        public T Eval(JToken json)
        {
            if (json == null)
                return default(T);
            var retVal = _func(json);
            return retVal;
        }


        /// <summary>
        /// Evals the specified instance.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <returns>System.Int32.</returns>
        public T Eval(JsonBackedObjectBase instance)
        {
            T result;
            if (instance.TryGetValue(this, out result))
                return result;
            result = Eval(instance.JsonValue);
            instance.SetValue(this, result);
            return result;
        }
    }
}