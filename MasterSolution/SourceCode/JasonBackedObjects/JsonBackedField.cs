using System;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.JasonBackedObjects
{
    /// <summary>
    ///     Class JsonBackedField.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class JsonBackedField<T> : JsonBackedDataBase
    {
        /// <summary>
        ///     Evals the specified json.
        /// </summary>
        /// <param name="json">The json.</param>
        /// <returns>T.</returns>
        public T Eval(JToken json)
        {
            if (json == null)
            {
                return default(T);
            }

            T retVal = r_Func(json);
            return retVal;
        }


        /// <summary>
        ///     Evals the specified instance.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <returns>T.</returns>
        public T Eval(JsonBackedObjectBase instance)
        {
            T result;
            if (instance.TryGetValue(this, out result))
                return result;
            result = Eval(instance.JsonValue);
            instance.SetValue(this, result);
            return result;
        }

        /// <summary>
        ///     Sets the specified json.
        /// </summary>
        /// <param name="json">The json.</param>
        /// <param name="value">The value.</param>
        public void Set(JToken json, T value) { r_Action(json, value); }

        /// <summary>
        ///     Initializes a new instance of the <see cref="JsonBackedField{T}" /> class.
        /// </summary>
        /// <param name="func">The function.</param>
        public JsonBackedField(Func<JToken, T> func) { r_Func = func; }

        /// <summary>
        ///     Initializes a new instance of the <see cref="JsonBackedField{T}" /> class.
        /// </summary>
        /// <param name="func">The function.</param>
        /// <param name="action">The action.</param>
        public JsonBackedField(Func<JToken, T> func, Action<JToken, T> action)
        {
            r_Func = func;
            r_Action = action;
        }


        /// <summary>
        ///     Initializes a new instance of the <see cref="JsonBackedField{T}" /> class.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="defaultValue">The default value.</param>
        public JsonBackedField(string key, T defaultValue)
            : this(token => ValueOrDefault(token, key, defaultValue), (token, value) => token.Replace(MakeToken(value))) { }


        public JsonBackedField(string key)
            : this(token => token[key].Value<T>(), (token, value) => token.Replace(MakeToken(value))) { }

        private static T ValueOrDefault(JToken token, string key, T defaultValue)
        {
            JToken tokenValue;
            if (!((JObject) token).TryGetValue(key, out tokenValue)) return defaultValue;
            return tokenValue.Value<T>();
        }

        /// <summary>
        ///     The _action
        /// </summary>
        private readonly Action<JToken, T> r_Action;

        /// <summary>
        ///     The _func
        /// </summary>
        private readonly Func<JToken, T> r_Func;
    }
}