using System;
using System.IO;
using DynCon.OSI.DynTest.Comparisions;

namespace DynCon.OSI.DynTest.ChangeTracking
{
    /// <summary>
    ///     Class MiscGraphChange.
    /// </summary>
    public class MiscGraphChange : GraphChangeBase
    {
        /// <summary>
        ///     Displays the specified writer.
        /// </summary>
        /// <param name="writer">The writer.</param>
        public override void Display(TextWriter writer) { writer.WriteLine("Misc,            {0},   {1},  {2} ", CleanPath, CleanTypeName, Message); }

        /// <summary>
        ///     Gets or sets the message.
        /// </summary>
        /// <value>The message.</value>
        public string Message { get; set; }

        public MiscGraphChange(string format, params object[] values) { Message = String.Format(format, values); }
    }
}