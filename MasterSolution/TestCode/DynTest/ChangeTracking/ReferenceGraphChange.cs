using System.IO;
using DynCon.OSI.DynTest.Comparisions;

namespace DynCon.OSI.DynTest.ChangeTracking
{
    /// <summary>
    ///     Class ReferenceGraphChange.
    /// </summary>
    public class ReferenceGraphChange : GraphChangeBase
    {
        public override void Display(TextWriter writer) { writer.WriteLine("InstanceChanged,  {0},   {1}   ", CleanPath, CleanTypeName); }
    }
}