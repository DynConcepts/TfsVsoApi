using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.JasonBackedObjects
{
    /// <summary>
    /// Class JsonBackedDictionary.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class JsonBackedDictionary<T> : JsonBackedDataBase<Dictionary<String, Tuple<JToken, T>>>
    {
        /// <summary>
        /// The _locator
        /// </summary>
        private readonly Func<JToken, JObject> _locator;

        /// <summary>
        /// The _key
        /// </summary>
        private readonly string _key;

        /// <summary>
        /// The _func
        /// </summary>
        private readonly Func<JToken, T> _func;


        /// <summary>
        /// Initializes a new instance of the <see cref="JsonBackedDictionary{T}"/> class.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="func">The function.</param>
        public JsonBackedDictionary(string key, Func<JToken, T> func)
        {
            _locator = token => token[key].Value<JObject>();
            _key = key;
            _func = func;
        }

        /// <summary>
        /// Evals the specified instance.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <returns>IReadOnlyDictionary&lt;System.String, T&gt;.</returns>
        public IReadOnlyDictionary<string, T> Eval(JsonBackedObjectBase instance)
        {
            var actual = GetDictionary(instance);
            _exposed.Clear();
            foreach (var item in actual)
            {
                _exposed.Add(item.Key, item.Value.Item2);
            }
            return _exposed;
        }

        /// <summary>
        /// The _exposed
        /// </summary>
        private readonly Dictionary<string, T> _exposed = new Dictionary<string, T>();
        /// <summary>
        /// Gets the dictionary.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <returns>Dictionary&lt;System.String, Tuple&lt;JToken, T&gt;&gt;.</returns>
        private Dictionary<string, Tuple<JToken, T>> GetDictionary(JsonBackedObjectBase instance)
        {
            Dictionary<string, Tuple<JToken, T>> result;
            if (instance.TryGetValue(this, out result))
                return result;
            result = CreateDictionary(instance.JsonValue);
            instance.SetValue(this, result);
            return result;
        }

        /// <summary>
        /// Evals the specified json.
        /// </summary>
        /// <param name="json">The json.</param>
        /// <returns>IReadOnlyDictionary&lt;System.String, T&gt;.</returns>
        private Dictionary<string, Tuple<JToken,T>> CreateDictionary(JToken json)
        {

            if (json == null)
                return new Dictionary<string, Tuple<JToken,T>>();
            var retVal = new Dictionary<string, Tuple<JToken, T>>();
            var elements = _locator(json);
            foreach (JProperty property in elements.Children())
            {
                var raw = property.Value<JToken>();
                T value = _func(raw);
                retVal.Add(property.Name, new Tuple<JToken, T>(raw,value));
            }
            return retVal;
        }


        /// <summary>
        /// Sets the value.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="fieldName">Name of the field.</param>
        /// <param name="value">The value.</param>
        public void SetValue(JsonBackedObjectBase instance, string fieldName, T value)
        {
            var dictionary = GetDictionary(instance);
            Tuple<JToken, T> existing;
            if (dictionary.TryGetValue(fieldName, out existing))
            {
                var originalToken = (JProperty)existing.Item1;
                originalToken.Value = MakeToken(value);
            }
            else
            {
                if (instance.JsonValue != null)
                {
                    var property = new JProperty(fieldName, MakeToken(value));
                    var owner = (JObject) instance.JsonValue[_key];
                    owner.Add(property);
                    dictionary.Add(fieldName, new Tuple<JToken, T>(property, value));
                }
                else
                {
                    throw new Exception("No Json backing object found!");
                }
            }
        }
    }
}