using System.Collections.Generic;
using System.IO;

namespace DynCon.OSI.DynTest.Comparisions
{
    /// <summary>
    ///     Class ChangeList.
    /// </summary>
    public class ChangeList : List<GraphChangeBase>
    {
        public void Display(TextWriter writer)
        {
            foreach (GraphChangeBase entry in this)
            {
                entry.Display(writer);
            }
        }
    }
}