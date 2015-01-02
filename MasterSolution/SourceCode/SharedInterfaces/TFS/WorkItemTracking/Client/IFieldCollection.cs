using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    /// <summary>
    /// Interface IFieldCollection
    /// </summary>
    public interface IFieldCollection : IReadOnlyList
    {
        /// <summary>
        /// Determines whether [contains] [the specified field name].
        /// </summary>
        /// <param name="fieldName">Name of the field.</param>
        /// <returns>Boolean.</returns>
        Boolean Contains(String fieldName);
        /// <summary>
        /// Determines whether [contains] [the specified identifier].
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Boolean.</returns>
        Boolean Contains(Int32 id);
        /// <summary>
        /// Determines whether [contains] [the specified value].
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Boolean.</returns>
        Boolean Contains(IField value);
        /// <summary>
        /// Drops the cached data.
        /// </summary>
        void DropCachedData();
        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>IField.</returns>
        IField GetById(Int32 id);
        /// <summary>
        /// Indexes the of.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>Int32.</returns>
        Int32 IndexOf(IField value);
        /// <summary>
        /// Tries the get by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>IField.</returns>
        IField TryGetById(Int32 id);
        /// <summary>
        /// Gets the <see cref="IField"/> at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>IField.</returns>
        IField this[Int32 index] { get; }
        /// <summary>
        /// Gets the <see cref="IField"/> with the specified core field.
        /// </summary>
        /// <param name="coreField">The core field.</param>
        /// <returns>IField.</returns>
        IField this[ICoreField coreField] { get; }
        /// <summary>
        /// Gets the <see cref="IField"/> with the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>IField.</returns>
        IField this[String name] { get; }
    }
}