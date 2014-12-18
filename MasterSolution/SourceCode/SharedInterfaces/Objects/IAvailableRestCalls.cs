using System;

namespace DynCon.OSI.VSO.SharedInterfaces.Objects
{
    /// <summary>
    ///     Interface IAvailableRestCalls
    /// </summary>
    public interface IAvailableRestCalls
    {
        /// <summary>
        ///     Gets the area.
        /// </summary>
        /// <value>The area.</value>
        String Area { get; }

        /// <summary>
        ///     Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        Guid Id { get; }

        /// <summary>
        ///     Gets the maximum version.
        /// </summary>
        /// <value>The maximum version.</value>
        String MaxVersion { get; }

        /// <summary>
        ///     Gets the minimum version.
        /// </summary>
        /// <value>The minimum version.</value>
        String MinVersion { get; }

        /// <summary>
        ///     Gets the released version.
        /// </summary>
        /// <value>The released version.</value>
        String ReleasedVersion { get; }

        /// <summary>
        ///     Gets the name of the resource.
        /// </summary>
        /// <value>The name of the resource.</value>
        String ResourceName { get; }

        /// <summary>
        ///     Gets the resource version.
        /// </summary>
        /// <value>The resource version.</value>
        String ResourceVersion { get; }

        /// <summary>
        ///     Gets the route template.
        /// </summary>
        /// <value>The route template.</value>
        String RouteTemplate { get; }
    }
}