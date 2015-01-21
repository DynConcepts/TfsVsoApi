using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace DynCon.OSI.Core.ObjectMapping
{
    /// <summary>
    ///     Class MappedObjectBase.
    /// </summary>
    public abstract class MappedObjectBase
    {
    }

    /// <summary>
    ///     Class MappedObjectBase.
    /// </summary>
    /// <typeparam name="TInterface">The type of the t interface.</typeparam>
    /// <typeparam name="TObjectMode">The type of the t object mode.</typeparam>
    public class MappedObjectBase<TInterface, TObjectMode> : MappedObjectBase where TInterface : class where TObjectMode : class
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
        ///     Gets the instance.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>TObjectMode[].</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public static TObjectMode[] GetInstance(TInterface[] src) { return MakeList(src).ToArray(); }

        /// <summary>
        ///     Gets the instance.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>IEnumerable&lt;TObjectMode&gt;.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public static IEnumerable<TObjectMode> GetInstance(IEnumerable<TInterface> src) { return MakeList(src); }

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
            if (src == null)
                return null;
            return s_Mapper.Convert(src);
        }

        /// <summary>
        ///     Gets the wrapper.
        /// </summary>
        /// <typeparam name="TKey">The type of the t key.</typeparam>
        /// <typeparam name="TValue">The type of the t value.</typeparam>
        /// <param name="src">The source.</param>
        /// <returns>Dictionary&lt;TKey, TValue&gt;.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public static Dictionary<TKey, TValue> GetWrapper<TKey, TValue>(Dictionary<TKey, TValue> src) { throw new NotImplementedException(); }

        /// <summary>
        ///     Gets the wrapper.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>TInterface[].</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public static TInterface[] GetWrapper(TObjectMode[] src)
        {
            if (src == null)
                return null; 
            return MakeList(src).ToArray();
        }

        /// <summary>
        ///     Gets the wrapper.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>IEnumerable&lt;TInterface&gt;.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public static IEnumerable<TInterface> GetWrapper(IEnumerable<TObjectMode> src)
        {
            if (src == null)
                return null; 
            return MakeList(src);
        }

        /// <summary>
        ///     Gets the wrapper.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>Collection&lt;TInterface&gt;.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public static Collection<TInterface> GetWrapper(Collection<TObjectMode> src)
        {
            if (src == null)
                return null; 
            throw new NotImplementedException();
        }

        /// <summary>
        ///     Gets the wrapper.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>ReadOnlyCollection&lt;TInterface&gt;.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public static ReadOnlyCollection<TInterface> GetWrapper(ReadOnlyCollection<TObjectMode> src)
        {
            if (src == null)
                return null; 
            var list = src.Select(GetWrapper).ToList();
            return new ReadOnlyCollection<TInterface>(list);
        }

        /// <summary>
        ///     Gets the wrapper.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>HashSet&lt;TInterface&gt;.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public static HashSet<TInterface> GetWrapper(HashSet<TObjectMode> src)
        {
            if (src == null)
                return null;
            var retVal = new HashSet<TInterface>();
            foreach (var item in src)
                retVal.Add(GetWrapper(item));
            return retVal;
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
        ///     Makes the list.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>List&lt;TObjectMode&gt;.</returns>
        private static List<TObjectMode> MakeList(IEnumerable<TInterface> src)
        {
            if (src == null)
                return null;
            return src.Select(GetInstance).ToList();
        }

        /// <summary>
        ///     Makes the list.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <returns>List&lt;TInterface&gt;.</returns>
        private static List<TInterface> MakeList(IEnumerable<TObjectMode> src)
        {
            if (src == null)
                return null;
            return src.Select(GetWrapper).ToList();
        }

        /// <summary>
        ///     The _mapper
        /// </summary>
        private static ObjectMapper<TInterface, TObjectMode> s_Mapper;
    }
}