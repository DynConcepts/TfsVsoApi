using System;
using System.Collections.Generic;
using DynCon.OSI.JasonBackedObjects.Communications;

namespace DynCon.OSI.JasonBackedObjects.AdvancedLogging
{
    public class StructuredExchangeLogger
    {
        public static void Install() { if (s_Instance == null) s_Instance = new StructuredExchangeLogger(); }

        public static void Uninstall()
        {
            if (s_Instance != null)
            {
                s_Instance.UnRegister();
                s_Instance = null;
            }
        }

        private StructuredExchangeLogger()
        {
            StructuredHttpExchange.OnExchangeComplete += StructuredHttpExchangeOnOnExchangeComplete;
            m_Context = new HttpExchangeContext();
        }

        private void StructuredHttpExchangeOnOnExchangeComplete(object sender, EventArgs eventArgs)
        {
            var exchange = (StructuredHttpExchange) sender;
            if (!exchange.RequestMessage.RequestUri.IsAbsoluteUri)
                throw new ArgumentException("Relative URI: in Client Request!");
            var entry = new ExchangeEntry
            {
                RelativeRoute = exchange.RelativeRoute,
                Request = exchange.RequestMessage.RequestUri.AbsoluteUri,
                Method = exchange.Method.Method,
                TimeStamp = exchange.TimeStamp,
                NetworkTime = exchange.NetworkTime,
                TotalTime = exchange.TotalTime,
                ProcessingTime = exchange.ProcessingTime,
                Body = exchange.Body,
                Exception = (exchange.Exception != null) ? exchange.Exception.GetType().Name + ": " + exchange.Exception.Message : null,
                Response = exchange.Response
            };
            foreach (KeyValuePair<int, object> item in exchange.RequestPositionalParameters)
            {
                entry.AddParameter(item.Key, item.Value.ToString());
            }
            foreach (KeyValuePair<string, object> item in exchange.QueryStringParameters)
            {
                entry.AddQuery(item.Key, item.Value.ToString());
            }
            m_Context.ExchangeEntries.Add(entry);
            m_Context.SaveChanges();
        }

        private void UnRegister() { StructuredHttpExchange.OnExchangeComplete -= StructuredHttpExchangeOnOnExchangeComplete; }
        private static StructuredExchangeLogger s_Instance;
        private readonly HttpExchangeContext m_Context;
    }
}