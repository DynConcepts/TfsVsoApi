﻿using System;
using System.Collections.Generic;
using DynCon.OSI.VSO.ReSTClient.Objects.WIT;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient
{
    /// <summary>
    ///     Helper methods for Parsing Json returned from ReST calls into the
    ///     underlying implementations.
    /// </summary>
    internal static class JsonParsers
    {
        /// <summary>
        ///     Js the array to objects.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array">The array.</param>
        /// <param name="creator">The creator.</param>
        /// <returns>List&lt;T&gt;.</returns>
        public static List<T> JArrayToObjects<T>(JArray array, Func<JToken, T> creator)
        {
            var list = new List<T>();
            foreach (JToken entry in array)
            {
                T instance = creator(entry);
                list.Add(instance);
            }
            return list;
        }

        /// <summary>
        ///     Js the object to instance.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="jObject">The j object.</param>
        /// <param name="creator">The creator.</param>
        /// <returns>T.</returns>
        public static T JObjectToInstance<T>(JObject jObject, Func<JObject, T> creator)
        {
            T instance = creator(jObject);
            return instance;
        }

        /// <summary>
        ///     Valueses to objects.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="jObject">The j object.</param>
        /// <param name="creator">The creator.</param>
        /// <returns>IList&lt;T&gt;.</returns>
        internal static IReadOnlyList<T> ValuesToObjects<T>(JObject jObject, Func<JToken, T> creator)
        {
            var list = new List<T>();
            foreach (KeyValuePair<string, JToken> item in jObject)
            {
                if (item.Key == "value")
                {
                    var array = (JArray) item.Value;
                    list.AddRange(JArrayToObjects(array, creator));
                }
            }
            return list;
        }

        /// <summary>
        ///     Wiqls the query parse.
        /// </summary>
        /// <param name="jObject">The j object.</param>
        /// <param name="func"></param>
        /// <returns>List&lt;JsonWorkItem&gt;.</returns>
        internal static List<T> WiqlQueryParse<T>(JObject jObject, Func<JToken, T> func) where T : JsonWorkItem
        {
            var workitems = new List<T>();
            foreach (KeyValuePair<string, JToken> item in jObject)
            {
                switch (item.Key)
                {
                    case "queryType":
                        break;
                    case "asOf":
                        break;
                    case "columns":
                    {
                        var array = (JArray) item.Value;
                        //    foreach (JProperty property in array[0])
                        //    {
                        //        int x = 1;
                        //    }
                    }
                        break;
                    case "workItems":
                    {
                        var array = (JArray) item.Value;
                        foreach (JToken workItemInfo in array)
                        {
                            T workItem = func(workItemInfo);
                            workitems.Add(workItem);
                        }
                    }
                        break;
                }
            }
            return workitems;
        }
    }
}