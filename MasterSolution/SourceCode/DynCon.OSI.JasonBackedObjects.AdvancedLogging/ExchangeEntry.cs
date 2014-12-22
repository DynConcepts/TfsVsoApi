using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DynCon.OSI.JasonBackedObjects.AdvancedLogging
{
    /// <summary>
    ///     Class ExchangeEntry.
    /// </summary>
    public class ExchangeEntry
    {
        /// <summary>
        ///     Adds the parameter.
        /// </summary>
        /// <param name="position">The position.</param>
        /// <param name="value">The value.</param>
        public void AddParameter(int position, string value)
        {
            var instance = new PositionalParameter();
            instance.Parent = this;
            instance.Position = position;
            instance.Value = value;
            Parameters.Add(instance);
        }

        /// <summary>
        ///     Adds the query.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        public void AddQuery(string name, string value)
        {
            var instance = new QueryParameter();
            instance.Parent = this;
            instance.Name = name;
            instance.Value = value;
            Queries.Add(instance);
        }

        /// <summary>
        ///     Gets or sets the body.
        /// </summary>
        /// <value>The body.</value>
        [Column(TypeName = "ntext")]
        public string Body { get; set; }

        /// <summary>
        ///     Gets or sets the exception.
        /// </summary>
        /// <value>The exception.</value>
        [Column(TypeName = "ntext")]
        public string Exception { get; set; }

        /// <summary>
        ///     Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public Guid Id { get; set; }

        /// <summary>
        ///     Gets or sets the method.
        /// </summary>
        /// <value>The method.</value>
        public string Method { get; set; }

        /// <summary>
        ///     Gets or sets the network time.
        /// </summary>
        /// <value>The network time.</value>
        public TimeSpan NetworkTime { get; set; }

        /// <summary>
        ///     Gets or sets the parameters.
        /// </summary>
        /// <value>The parameters.</value>
        public virtual ICollection<PositionalParameter> Parameters { get; set; }

        /// <summary>
        ///     Gets or sets the processing time.
        /// </summary>
        /// <value>The processing time.</value>
        public object ProcessingTime { get; set; }

        /// <summary>
        ///     Gets or sets the queries.
        /// </summary>
        /// <value>The queries.</value>
        public virtual ICollection<QueryParameter> Queries { get; set; }

        /// <summary>
        ///     Gets or sets the relative route.
        /// </summary>
        /// <value>The relative route.</value>
        public string RelativeRoute { get; set; }

        /// <summary>
        ///     Gets or sets the request.
        /// </summary>
        /// <value>The request.</value>
        [Column(TypeName = "ntext")]
        public string Request { get; set; }

        /// <summary>
        ///     Gets or sets the response.
        /// </summary>
        /// <value>The response.</value>
        [Column(TypeName = "ntext")]
        public string Response { get; set; }

        /// <summary>
        ///     Gets or sets the time stamp.
        /// </summary>
        /// <value>The time stamp.</value>
        public DateTime TimeStamp { get; set; }

        /// <summary>
        ///     Gets or sets the total time.
        /// </summary>
        /// <value>The total time.</value>
        public TimeSpan TotalTime { get; set; }

        /// <summary>
        ///     Initializes a new instance of the <see cref="ExchangeEntry" /> class.
        /// </summary>
        public ExchangeEntry()
        {
            Id = Guid.NewGuid();
            Parameters = new List<PositionalParameter>();
            Queries = new List<QueryParameter>();
        }
    }
}