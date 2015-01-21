using System.IO;

namespace DynCon.OSI.DynTest.Comparisions
{
    /// <summary>
    ///     Class AddedGraphChange.
    /// </summary>
    public class AddedGraphChange : GraphChangeBase
    {
        public override void Display(TextWriter writer) { writer.WriteLine("InstanceAdded,    {0},   {1},    {2}", CleanPath, CleanTypeName, NewValue); }

        /// <summary>
        ///     Gets or sets the new value.
        /// </summary>
        /// <value>The new value.</value>
        public object NewValue { get; set; }
    }
}