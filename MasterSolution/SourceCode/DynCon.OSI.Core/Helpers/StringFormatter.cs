using System;
using System.Collections.Generic;
using System.Text;

namespace DynCon.OSI.Core.Helpers
{
    /// <summary>
    /// Class StringFormatter.
    /// </summary>
    public class StringFormatter
    {
/// <summary>
/// Class MissingFormatterElement.
/// </summary>
        public class MissingFormatterElement
        {

        }

        /// <summary>
        /// Builds the specified template.
        /// </summary>
        /// <param name="template">The template.</param>
        /// <param name="values">The values.</param>
        /// <returns>System.String.</returns>
        public static string Build(string template, Dictionary<string, object> values)
        {
            var sb = new StringBuilder();
            var remaining = template;
            while (remaining.Length > 0)
            {
                int startIndex = remaining.IndexOf("{", StringComparison.Ordinal);
                if (startIndex >= 0)
                {
                    int endIndex = remaining.IndexOf("}", startIndex, StringComparison.Ordinal);
                    sb.Append(remaining.Substring(0, startIndex));
                    var key = remaining.Substring(startIndex, 1 + endIndex - startIndex);
                    object value = values[key];
                    if (value is MissingFormatterElement)
                        throw new Exception(String.Format("Formatter Parameter {0} is missing", key));
                    sb.Append(value);
                    if (endIndex < remaining.Length)
                        remaining = remaining.Substring(endIndex + 1);
                    else
                        remaining = String.Empty;
                }
                else
                {
                    sb.Append(remaining);
                    remaining = String.Empty;
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// Parses the specified template.
        /// </summary>
        /// <param name="template">The template.</param>
        /// <returns>Dictionary&lt;System.String, System.Object&gt;.</returns>
        public static Dictionary<string, object> Parse(string template)
        {
            var retVal = new Dictionary<string, object>();
            var remaining = template;
            while (remaining.Length > 0)
            {
                int startIndex = remaining.IndexOf("{", StringComparison.Ordinal);
                if (startIndex >= 0)
                {
                    int endIndex = remaining.IndexOf("}", startIndex, StringComparison.Ordinal);
                    var key = remaining.Substring(startIndex, 1 + endIndex - startIndex);
                    retVal.Add(key, new MissingFormatterElement());
                    if (endIndex < remaining.Length)
                        remaining = remaining.Substring(endIndex + 1);
                    else
                        remaining = String.Empty;
                }
                else
                {
                    remaining = String.Empty;
                }
            }
            return retVal;
        }
    }
}
