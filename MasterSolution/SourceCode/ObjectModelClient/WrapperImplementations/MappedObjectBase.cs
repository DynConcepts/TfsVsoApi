using System;
using DynCon.OSI.Core;

namespace DynCon.OSI.VSO.ObjectModelClient.WrapperImplementations
{
    /// <summary>
    ///     Class MappedObjectBase.
    /// </summary>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    /// <typeparam name="TObjectMode">The type of the t object mode.</typeparam>
    internal class MappedObjectBase<TInterface, TObjectMode> where TInterface : class
    {
        /// <summary>
        ///     Gets the instance.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>TObjectMode.</returns>
        /// <exception cref="System.Exception"></exception>
        public static TObjectMode GetInstance(TInterface src)
        {
            if (s_Mapper == null)
                throw new Exception(String.Format("Mapper<{0},{1}> Not Initialized!", typeof (TInterface).Name, typeof (TObjectMode).Name));
            return s_Mapper.Convert(src);
        }

        /// <summary>
        ///     Gets the wrapper.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>TInterface.</returns>
        /// <exception cref="System.Exception"></exception>
        public static TInterface GetWrapper(TObjectMode src)
        {
            if (s_Mapper == null)
                throw new Exception(String.Format("Mapper<{0},{1}> Not Initialized!", typeof (TInterface).Name, typeof (TObjectMode).Name));
            return s_Mapper.Convert(src);
        }

        /// <summary>
        ///     Gets or sets the mapper.
        /// </summary>
        /// <value>The mapper.</value>
        public static ObjectMapper<TInterface, TObjectMode> Mapper { get { return s_Mapper; } set { s_Mapper = value; } }

        /// <summary>
        ///     Initializes static members of the <see cref="MappedObjectBase{TInterface, TObjectMode}" /> class.
        /// </summary>
        static MappedObjectBase() { MappedObjectInitializer.ForceInitialize(); }

        /// <summary>
        ///     The _mapper
        /// </summary>
        private static ObjectMapper<TInterface, TObjectMode> s_Mapper;
    }
}