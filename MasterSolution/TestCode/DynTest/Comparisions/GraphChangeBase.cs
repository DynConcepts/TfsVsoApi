using System;
using System.IO;
using System.Linq;

namespace DynCon.OSI.DynTest.Comparisions
{
    /// <summary>
    ///     Class GraphChangeBase.
    /// </summary>
    public abstract class GraphChangeBase
    {
        public abstract void Display(TextWriter writer);


        public string CleanTypeName
        {
            get
            {
                return DeclaredType != null?Cleanup(DeclaredType):"";
            }
        }

        /// <summary>
        ///     Gets or sets the type of the declared.
        /// </summary>
        /// <value>The type of the declared.</value>
        public Type DeclaredType { get; set; }

        /// <summary>
        ///     Gets or sets the path.
        /// </summary>
        /// <value>The path.</value>
        public string Path { get; set; }

        private string Cleanup(Type type)
        {
            if (!type.IsGenericType)
            {
                return type.Name;
            }
          
            int indexOf = type.Name.IndexOf('`');
            string retVal = indexOf >= 0 ? type.Name.Substring(0, indexOf) : type.Name;
            retVal += "<";
            bool first = true;
            foreach (Type special in type.GenericTypeArguments)
            {
                if (!first) retVal += ',';
                else first = false;
                retVal += Cleanup(special);
            }
            retVal += ">";
            return retVal;
        }

        /// <summary>
        ///     Gets the clean path.
        /// </summary>
        /// <value>The clean path.</value>
        protected string CleanPath
        {
            get
            {
                string retVal = String.Empty;
                if (!String.IsNullOrWhiteSpace(Path))
                {
                    string[] parts = Path.Split(new[] {'.'});
                    foreach (string part in parts)
                    {
                        int indexOf = part.IndexOf('{');
                        string clean = indexOf >= 0 ? part.Substring(0, indexOf) : part;
                        if (!String.IsNullOrWhiteSpace(retVal))
                            retVal += ".";
                        retVal += clean;
                    }
                }
                return retVal;
            }
        }
    }
}