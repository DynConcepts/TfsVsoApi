using System;
using DynCon.OSI.JasonBackedObjects;
using DynCon.OSI.VSO.ReSTClient.Objects.Base;
using Newtonsoft.Json.Linq;

namespace DynCon.OSI.VSO.ReSTClient.Objects.WIT
{
    /// <summary>
    ///     Class JsonWorkItemLink.
    /// </summary>
    internal class JsonWorkItemLink : JsonLink
    {
        /// <summary>
        ///     Froms the token.
        /// </summary>
        /// <param name="content">The content.</param>
        /// <returns>JsonWorkItemLink.</returns>
        public new static JsonWorkItemLink FromToken(JToken content)
        {
            var instance = new JsonWorkItemLink(content);
            return instance;
        }


        /// <summary>
        ///     Gets the added by.
        /// </summary>
        /// <value>The added by.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.Objects.Base.NoReStAPIEquivilantException"></exception>
        public string AddedBy { get { throw new NoReStAPIEquivilantException(); } }

        /// <summary>
        ///     Gets the added date.
        /// </summary>
        /// <value>The added date.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.Objects.Base.NoReStAPIEquivilantException"></exception>
        public DateTime AddedDate { get { throw new NoReStAPIEquivilantException(); } }

        /// <summary>
        ///     Gets the added date UTC.
        /// </summary>
        /// <value>The added date UTC.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.Objects.Base.NoReStAPIEquivilantException"></exception>
        public DateTime AddedDateUtc { get { throw new NoReStAPIEquivilantException(); } }

        /// <summary>
        ///     Gets the type of the artifact link.
        /// </summary>
        /// <value>The type of the artifact link.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.Objects.Base.NoReStAPIEquivilantException"></exception>
        public new RegisteredLinkType ArtifactLinkType { get { throw new NoReStAPIEquivilantException(); } }

        /// <summary>
        ///     Gets the type of the base.
        /// </summary>
        /// <value>The type of the base.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.Objects.Base.NoReStAPIEquivilantException"></exception>
        public new BaseLinkType BaseType { get { throw new NoReStAPIEquivilantException(); } }

        /// <summary>
        ///     Gets or sets the changed date.
        /// </summary>
        /// <value>The changed date.</value>
        public DateTime? ChangedDate { get; set; }

        /// <summary>
        ///     Gets the link type end.
        /// </summary>
        /// <value>The link type end.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.Objects.Base.NoReStAPIEquivilantException"></exception>
        public string LinkTypeEnd { get { throw new NoReStAPIEquivilantException(); } }

        /// <summary>
        ///     Gets the other work item.
        /// </summary>
        /// <value>The other work item.</value>
        public JsonWorkItem OtherWorkItem { get { return r_OtherItem.Value; } }

        /// <summary>
        ///     Gets the removed by.
        /// </summary>
        /// <value>The removed by.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.Objects.Base.NoReStAPIEquivilantException"></exception>
        public string RemovedBy { get { throw new NoReStAPIEquivilantException(); } }

        /// <summary>
        ///     Gets the removed date.
        /// </summary>
        /// <value>The removed date.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.Objects.Base.NoReStAPIEquivilantException"></exception>
        public DateTime RemovedDate { get { throw new NoReStAPIEquivilantException(); } }

        /// <summary>
        ///     Gets the removed date UTC.
        /// </summary>
        /// <value>The removed date UTC.</value>
        /// <exception cref="DynCon.OSI.VSO.ReSTClient.Objects.Base.NoReStAPIEquivilantException"></exception>
        public DateTime RemovedDateUtc { get { throw new NoReStAPIEquivilantException(); } }

        /// <summary>
        ///     Gets or sets the source identifier.
        /// </summary>
        /// <value>The source identifier.</value>
        public int SourceId { get; set; }

        /// <summary>
        ///     Gets or sets the target identifier.
        /// </summary>
        /// <value>The target identifier.</value>
        public int TargetId { get; set; }

        /// <summary>
        ///     Initializes a new instance of the <see cref="JsonBackedObjectBase" /> class.
        /// </summary>
        /// <param name="json">The json.</param>
        public JsonWorkItemLink(JToken json)
            : base(json)
        {
            r_OtherItem = new Lazy<JsonWorkItem>(() =>
            {
                JsonWorkItem retVal = JsonWorkItem.APIFactory().GetWorkItem(new Uri(sr_Url.Eval(this)));
                return retVal;
            });
        }

        /// <summary>
        ///     The r_ other item
        /// </summary>
        private readonly Lazy<JsonWorkItem> r_OtherItem;
    }

    /// <summary>
    /// Enum BaseLinkType
    /// </summary>
    public enum BaseLinkType
    {
    }

    /// <summary>
    /// Enum RegisteredLinkType
    /// </summary>
    public enum RegisteredLinkType
    {
    }

}