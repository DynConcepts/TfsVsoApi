using System;

namespace DynCon.OSI.JasonBackedObjects.AdvancedLogging
{
    public class PositionalParameter
    {
        public Guid Id { get; set; }
        public ExchangeEntry Parent { get; set; }
        public int Position { get; set; }
        public string Value { get; set; }
        public PositionalParameter() { Id = Guid.NewGuid(); }
    }
}