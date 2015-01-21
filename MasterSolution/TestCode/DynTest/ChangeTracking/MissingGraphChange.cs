using System.IO;

namespace DynCon.OSI.DynTest.Comparisions
{
    /// <summary>
    ///     Class MissingGraphChange.
    /// </summary>
    public class MissingGraphChange : GraphChangeBase
    {
        public override void Display(TextWriter writer) { writer.WriteLine("InstanceRemoved,  {0},   {1},    {2}", CleanPath, CleanTypeName, OldValue); }

        /// <summary>
        ///     Gets or sets the old value.
        /// </summary>
        /// <value>The old value.</value>
        public object OldValue { get; set; }
    }
}