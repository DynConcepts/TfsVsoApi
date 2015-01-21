using DynCon.OSI.DynTest.ChangeTracking;

namespace DynCon.OSI.DynTest.Comparisions
{
    /// <summary>
    ///     Interface IDeepCapturer
    /// </summary>
    internal interface IDeepCapturer
    {
        /// <summary>
        ///     Processes the specified left value.
        /// </summary>
        /// <param name="leftValue">The left value.</param>
        /// <param name="context">The context.</param>
        /// <returns>CaptureResults.</returns>
        CaptureResults Process(object leftValue, CaptureContext context);
    }
}