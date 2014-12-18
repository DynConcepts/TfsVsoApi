using System;
using System.Collections;
using System.Collections.Generic;

namespace DynCon.OSI.VSO.ObjectModelClient.Helpers
{
    internal class EnumeratorWrapper<TNative, TInterface> : IEnumerator<TInterface>
    {
        public void Dispose() { r_Src.Dispose(); }
        public bool MoveNext() { return r_Src.MoveNext(); }

        public void Reset() { r_Src.Reset(); }

        public TInterface Current
        {
            get
            {
                TInterface wrapped = m_Func(r_Src.Current);
                return wrapped;
            }
        }

        object IEnumerator.Current { get { return Current; } }

        public EnumeratorWrapper(IEnumerator<TNative> src, Func<TNative, TInterface> func)
        {
            r_Src = src;
            m_Func = func;
        }

        private readonly Func<TNative, TInterface> m_Func;
        private readonly IEnumerator<TNative> r_Src;
    }

    internal class EnumeratorWrapper<TInterface> : IEnumerator
    {
        public bool MoveNext() { return r_Src.MoveNext(); }

        public void Reset() { r_Src.Reset(); }

        public object Current { get { return m_Func(r_Src.Current); } }

        public EnumeratorWrapper(IEnumerator src, Func<object, TInterface> func)
        {
            r_Src = src;
            m_Func = func;
        }

        private readonly Func<object, TInterface> m_Func;
        private readonly IEnumerator r_Src;
    }
}