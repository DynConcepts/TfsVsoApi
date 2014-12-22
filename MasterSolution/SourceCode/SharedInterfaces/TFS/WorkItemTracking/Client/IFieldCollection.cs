using System;
using DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Common;

namespace DynCon.OSI.VSO.SharedInterfaces.TFS.WorkItemTracking.Client
{
    public interface IFieldCollection : IReadOnlyList
    {
        Boolean Contains(String fieldName);
        Boolean Contains(Int32 id);
        Boolean Contains(IField value);
        void DropCachedData();
        IField GetById(Int32 id);
        Int32 IndexOf(IField value);
        IField TryGetById(Int32 id);
        IField this[Int32 index] { get; }
        IField this[ICoreField coreField] { get; }
        IField this[String name] { get; }
    }
}