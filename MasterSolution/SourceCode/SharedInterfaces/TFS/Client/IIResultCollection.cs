using System;
using System.Collections;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.Client
{
    /// <summary>
    /// Interface IIResultCollection
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IIResultCollection<T> : IEnumerable, IDisposable
    {
    }
}