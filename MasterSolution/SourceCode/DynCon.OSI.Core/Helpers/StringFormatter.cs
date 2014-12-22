using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynCon.OSI.Core.Helpers
{
    /// <summary>
    /// Class StringFormatter.
    /// </summary>
    public class StringFormatter
    {
        /// <summary>
        /// Builds the specified template.
        /// </summary>
        /// <param name="template">The template.</param>
        /// <param name="values">The values.</param>
        /// <returns>System.String.</returns>
        public static string Build(string template, Dictionary<string, string> values)
        {
            var sb = new StringBuilder();
            var remaining = template;
            while (remaining.Length > 0)
            {
                int startIndex = remaining.IndexOf("{", System.StringComparison.Ordinal);
                if (startIndex >= 0)
                {
                    int endIndex = remaining.IndexOf("}", startIndex, System.StringComparison.Ordinal);
                    sb.Append(remaining.Substring(0, startIndex));
                    var key = remaining.Substring(startIndex, 1 + endIndex - startIndex);
                    sb.Append(values[key]);
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
        /// <returns>Dictionary&lt;System.String, System.String&gt;.</returns>
        public static Dictionary<string, string> Parse(string template)
        {
            var retVal = new Dictionary<string, string>();
            var remaining = template;
            while (remaining.Length > 0)
            {
                int startIndex = remaining.IndexOf("{", System.StringComparison.Ordinal);
                if (startIndex >= 0)
                {
                    int endIndex = remaining.IndexOf("}", startIndex, System.StringComparison.Ordinal);
                    var key = remaining.Substring(startIndex, 1 + endIndex - startIndex);
                    retVal.Add(key, null);
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
