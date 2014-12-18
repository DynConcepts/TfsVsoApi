using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.JasonBackedObjects
{
    /// <summary>
    ///     Class JsonBackedDictionary.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class JsonBackedDictionary<T> : JsonBackedDataBase
    {
        /// <summary>
        ///     Evals the specified instance.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <returns>IReadOnlyDictionary&lt;System.String, T&gt;.</returns>
        public IReadOnlyDictionary<string, T> Eval(JsonBackedObjectBase instance)
        {
            Dictionary<string, Tuple<JToken, T>> actual = GetDictionary(instance);
            r_Exposed.Clear();
            foreach (KeyValuePair<string, Tuple<JToken, T>> item in actual)
            {
                r_Exposed.Add(item.Key, item.Value.Item2);
            }
            return r_Exposed;
        }


        /// <summary>
        ///     Sets the value.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="fieldName">Name of the field.</param>
        /// <param name="value">The value.</param>
        public void SetValue(JsonBackedObjectBase instance, string fieldName, T value)
        {
            Dictionary<string, Tuple<JToken, T>> dictionary = GetDictionary(instance);
            Tuple<JToken, T> existing;
            if (dictionary.TryGetValue(fieldName, out existing))
            {
                var originalToken = (JProperty) existing.Item1;
                originalToken.Value = MakeToken(value);
            }
            else
            {
                if (instance.JsonValue != null)
                {
                    var property = new JProperty(fieldName, MakeToken(value));
                    var owner = (JObject) instance.JsonValue[r_Key];
                    owner.Add(property);
                    dictionary.Add(fieldName, new Tuple<JToken, T>(property, value));
                }
                else
                {
                    throw new Exception("No Json backing object found!");
                }
            }
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="JsonBackedDictionary{T}" /> class.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="func">The function.</param>
        public JsonBackedDictionary(string key, Func<JToken, T> func)
        {
            r_Locator = token => token[key].Value<JObject>();
            r_Key = key;
            r_Func = func;
        }

        /// <summary>
        ///     Evals the specified json.
        /// </summary>
        /// <param name="json">The json.</param>
        /// <returns>IReadOnlyDictionary&lt;System.String, T&gt;.</returns>
        private Dictionary<string, Tuple<JToken, T>> CreateDictionary(JToken json)
        {
            if (json == null)
                return new Dictionary<string, Tuple<JToken, T>>();
            var retVal = new Dictionary<string, Tuple<JToken, T>>();
            JObject elements = r_Locator(json);
            foreach (JProperty property in elements.Children())
            {
                var raw = property.Value<JToken>();
                T value = r_Func(raw);
                retVal.Add(property.Name, new Tuple<JToken, T>(raw, value));
            }
            return retVal;
        }

        /// <summary>
        ///     Gets the dictionary.
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
        ///     The _exposed
        /// </summary>
        private readonly Dictionary<string, T> r_Exposed = new Dictionary<string, T>();

        /// <summary>
        ///     The _func
        /// </summary>
        private readonly Func<JToken, T> r_Func;

        /// <summary>
        ///     The _key
        /// </summary>
        private readonly string r_Key;

        /// <summary>
        ///     The _locator
        /// </summary>
        private readonly Func<JToken, JObject> r_Locator;
    }
}