using System.IO;

namespace DynCon.OSI.DynTest.Comparisions
{
    /// <summary>
    ///     Class ValueGraphChange.
    /// </summary>
    public class ValueGraphChange : GraphChangeBase
    {
        public override void Display(TextWriter writer) { writer.WriteLine("ValueChanged,     {0},   {1},   {2},{3}", CleanPath, CleanTypeName, OldValue, NewValue); }

        /// <summary>
        ///     Gets or sets the new value.
        /// </summary>
        /// <value>The new value.</value>
        public object NewValue { get; set; }

        /// <summary>
        ///     Gets or sets the old value.
        /// </summary>
        /// <value>The old value.</value>
        public object OldValue { get; set; }
    }
}