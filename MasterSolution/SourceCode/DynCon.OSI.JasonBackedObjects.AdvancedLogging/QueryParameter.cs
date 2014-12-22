using System;

namespace DynCon.OSI.JasonBackedObjects.AdvancedLogging
{
    public class QueryParameter
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ExchangeEntry Parent { get; set; }
        public string Value { get; set; }
        public QueryParameter() { Id = Guid.NewGuid(); }
    }
}