using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.JasonBackedObjects
{
    /// <summary>
    ///     Class JsonBackedObjectBase.
    /// </summary>
    public abstract class JsonBackedObjectBase
    {
        public virtual void CaptureJson(JToken token) { m_Json = token; }

        /// <summary>
        ///     Sets the value.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="jsonBackedField">The json backed field.</param>
        /// <param name="value">The value.</param>
        public void SetValue<T>(JsonBackedDataBase jsonBackedField, T value) { r_Cache[jsonBackedField] = value; }

        /// <summary>
        ///     To the j son string.
        /// </summary>
        /// <returns>System.String.</returns>
        public string ToJSonString()
        {
            var sb = new StringBuilder();
            var serializer = new JsonSerializer();
            var textWriter = new StringWriter(sb);
            var jsonWriter = new JsonTextWriter(textWriter);
            serializer.Serialize(jsonWriter, m_Json);
            jsonWriter.Close();
            textWriter.Close();
            return sb.ToString();
        }

        /// <summary>
        ///     Tries the get value.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="jsonBackedField">The json backed field.</param>
        /// <param name="result">The result.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool TryGetValue<T>(JsonBackedDataBase jsonBackedField, out T result)
        {
            object cachedValue;
            if (r_Cache.TryGetValue(jsonBackedField, out cachedValue))
            {
                result = (T) cachedValue;
                return true;
            }
            result = default(T);
            return false;
        }

        /// <summary>
        ///     Gets the json value.
        /// </summary>
        /// <value>The json value.</value>
        public JToken JsonValue { get { return m_Json; } }


        /// <summary>
        ///     Initializes a new instance of the <see cref="JsonBackedObjectBase" /> class.
        /// </summary>
        /// <param name="json">The json.</param>
        protected JsonBackedObjectBase(JToken json)
        {
            if (json == null)
                throw new Exception();
            m_Json = json;
        }

        /// <summary>
        ///     Clears the cache.
        /// </summary>
        protected void ClearCache() { r_Cache.Clear(); }

        /// <summary>
        ///     Sets the json.
        /// </summary>
        /// <param name="json">The json.</param>
        protected void SetJson(JToken json) { m_Json = json; }

        /// <summary>
        ///     The _cache
        /// </summary>
        private readonly Dictionary<object, object> r_Cache = new Dictionary<object, object>();

        /// <summary>
        ///     The _json
        /// </summary>
        private JToken m_Json;
    }

    public class JsonGeneralPurposeObject : JsonBackedObjectBase
    {
        public JsonGeneralPurposeObject(JToken json) : base(json) { DumpCode(); }


        private void DumpCode()
        {
            var jObj = (JObject) JsonValue;
            foreach (var property in jObj.Properties())
            {
                string name = property.Name;
                string type = property.Value<Object>().GetType().Name;
                Console.Write("public {0} {1}", type, name);
                Console.Write("{ get { return ");
                Console.Write("sr_{0}.Eval(this);", name);
                Console.Write(" } }");
                Console.WriteLine();
                Console.WriteLine("private static readonly JsonBackedField<int> sr_{0} = new JsonBackedField<int>(\"{0}\");", name);
            }
            Console.WriteLine();
            Console.WriteLine(JsonValue);
            throw new Exception("Code Written!!!!!");
        }

        public static JsonGeneralPurposeObject FromToken(JToken token)
        {
            var instance = new JsonGeneralPurposeObject(token);
            return instance;
        }
    }
}