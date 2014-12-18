using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.JasonBackedObjects
{
    /// <summary>
    /// Class JsonBackedObjectBase.
    /// </summary>
    public abstract class JsonBackedObjectBase
    {
        /// <summary>
        /// The _json
        /// </summary>
        private JToken _json;

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonBackedObjectBase"/> class.
        /// </summary>
        /// <param name="json">The json.</param>
        protected JsonBackedObjectBase(JToken json) { _json = json; }

        /// <summary>
        /// Gets the json value.
        /// </summary>
        /// <value>The json value.</value>
        public JToken JsonValue { get { return _json; }}

        /// <summary>
        /// To the j son string.
        /// </summary>
        /// <returns>System.String.</returns>
        public string ToJSonString()
        {
            var sb = new StringBuilder();
            var serializer = new JsonSerializer();
            var textWriter = new StringWriter(sb);
            var jsonWriter = new JsonTextWriter(textWriter);
            serializer.Serialize(jsonWriter, _json);
            jsonWriter.Close();
            textWriter.Close();
            return sb.ToString();
        }

        /// <summary>
        /// Tries the get value.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="jsonBackedField">The json backed field.</param>
        /// <param name="result">The result.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool TryGetValue<T>(JsonBackedDataBase<T> jsonBackedField, out T result)
        {
            object cachedValue;
            if (_cache.TryGetValue(jsonBackedField, out cachedValue))
            {
                result = (T) cachedValue;
                return true;
            }
            result = default(T);
            return false;
        }

        /// <summary>
        /// Sets the value.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="jsonBackedField">The json backed field.</param>
        /// <param name="value">The value.</param>
        public void SetValue<T>(JsonBackedDataBase<T> jsonBackedField, T value) { _cache[jsonBackedField] = value; }

        /// <summary>
        /// The _cache
        /// </summary>
        private readonly Dictionary<object, object> _cache = new Dictionary<object, object>();

        /// <summary>
        /// Sets the json.
        /// </summary>
        /// <param name="json">The json.</param>
        protected void SetJson(JToken json) { _json = json; }
    }
}