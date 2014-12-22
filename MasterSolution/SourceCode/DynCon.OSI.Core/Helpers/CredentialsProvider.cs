using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace DynCon.OSI.Core.Helpers
{
    /// <summary>
    ///     Class CredentialsProvider.
    /// </summary>
    public static class CredentialsProvider
    {
        /// <summary>
        ///     Reads the specified file path.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns>CredentialsStore.</returns>
        public static CredentialsStore Read(string filePath)
        {
            using (var reader = new XmlTextReader(filePath))
            {
                return Read(reader);
            }
        }

        /// <summary>
        ///     Writes the specified file path.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <param name="credentials">The credentials.</param>
        public static void Write(string filePath, CredentialsStore credentials)
        {
            using (var writer = new XmlTextWriter(filePath, Encoding.UTF8))
            {
                Write(credentials, writer);
            }
        }

        /// <summary>
        ///     Reads the specified reader.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <returns>CredentialsStore.</returns>
        private static CredentialsStore Read(XmlTextReader reader)
        {
            var retVal = new CredentialsStore();
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        string elementName = reader.Name;
                        bool hasAttributes = reader.MoveToFirstAttribute();
                        while (hasAttributes)
                        {
                            string attributeName = reader.Name;
                            string attributeValue = reader.Value;
                            if (attributeName == "Credential")
                            {
                                retVal.Values[elementName] = attributeValue;
                            }
                            hasAttributes = reader.MoveToNextAttribute();
                        }
                        reader.MoveToElement();
                        break;
                    default:
                        break;
                }
            }
            return retVal;
        }

        /// <summary>
        ///     Writes the specified credentials.
        /// </summary>
        /// <param name="credentials">The credentials.</param>
        /// <param name="writer">The writer.</param>
        private static void Write(CredentialsStore credentials, XmlWriter writer)
        {
            writer.WriteStartElement("ReSTCredentials", "");
            foreach (KeyValuePair<string, string> pair in credentials.Values)
            {
                writer.WriteStartElement(pair.Key, "");
                writer.WriteAttributeString("Credential", pair.Value);
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
        }
    }

    /// <summary>
    ///     Class CredentialsStore.
    /// </summary>
    public class CredentialsStore

    {
        /// <summary>
        ///     Gets or sets the basic authorization password.
        /// </summary>
        /// <value>The basic authorization password.</value>
        public
            string BasicAuthorizationPassword { get { return SafeGet("BasicAuthorizationPassword"); } set { Values["BasicAuthorizationPassword"] = value; } }

        /// <summary>
        ///     Gets or sets the basic authorization username.
        /// </summary>
        /// <value>The basic authorization username.</value>
        public string BasicAuthorizationUsername { get { return SafeGet("BasicAuthorizationUsername"); } set { Values["BasicAuthorizationUsername"] = value; } }

        /// <summary>
        ///     Gets the values.
        /// </summary>
        /// <value>The values.</value>
        public Dictionary<string, string> Values { get { return r_Values; } }

        /// <summary>
        ///     Gets or sets the vso collection.
        /// </summary>
        /// <value>The vso collection.</value>
        public string VsoCollection { get { return SafeGet("VsoCollection"); } set { Values["VsoCollection"] = value; } }

        /// <summary>
        ///     Safes the get.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>System.String.</returns>
        private string SafeGet(string key)
        {
            string result;
            Values.TryGetValue(key, out result);
            return result;
        }

        /// <summary>
        ///     The r_ values
        /// </summary>
        private readonly Dictionary<string, string> r_Values = new Dictionary<string, string>();
    }
}