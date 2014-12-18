namespace DynCon.OSI.VSO.ObjectModelClient.WrapperImplementations
{
    /// <summary>
    ///     Class MappedObjectInitializer.
    /// </summary>
    internal static class MappedObjectInitializer
    {
        /// <summary>
        ///     Forces the initialize.
        /// </summary>
        public static void ForceInitialize() { }

        /// <summary>
        ///     Initializes static members of the <see cref="MappedObjectInitializer" /> class.
        /// </summary>
        static MappedObjectInitializer()
        {
            WorkItemWrapper.SetMapper();
            WorkItemTypeWrapper.SetMapper();
            LinkWrapper.SetMapper();
        }
    }
}