using System.Collections.Generic;
using System.ComponentModel;

namespace DynCon.OSI.VSO.SharedInterfaces.Objects.WIT
{
    /// <summary>
    /// Interface IFieldCollection
    /// </summary>
     public interface IFieldCollection : IReadOnlyList<IField>
    {
  
        // Summary:
        //     Gets the Microsoft.TeamFoundation.WorkItemTracking.Client.Field in this collection
        //     that is the specified Microsoft.TeamFoundation.WorkItemTracking.Client.CoreField
        //     member.
        //
        // Parameters:
        //   coreField:
        //     The Microsoft.TeamFoundation.WorkItemTracking.Client.CoreField member of
        //     the desired field.
        //
        // Returns:
        //     The Microsoft.TeamFoundation.WorkItemTracking.Client.Field in this collection
        //     that is the specified Microsoft.TeamFoundation.WorkItemTracking.Client.CoreField
        //     member.
         /// <summary>
         /// Gets the <see cref="IField"/> with the specified core field.
         /// </summary>
         /// <param name="coreField">The core field.</param>
         /// <returns>IField.</returns>
         IField this[CoreField coreField] { get; }
 
         //
        // Summary:
        //     Gets the Microsoft.TeamFoundation.WorkItemTracking.Client.Field in this collection
        //     that has the specified name or reference name.
        //
        // Parameters:
        //   name:
        //     The name or reference name of the desired Microsoft.TeamFoundation.WorkItemTracking.Client.Field.
        //
        // Returns:
        //     The Microsoft.TeamFoundation.WorkItemTracking.Client.Field with the specified
        //     name or reference name.
         /// <summary>
         /// Gets the <see cref="IField"/> with the specified name.
         /// </summary>
         /// <param name="name">The name.</param>
         /// <returns>IField.</returns>
        IField this[string name] { get; }

          //
        // Summary:
        //     Checks whether this collection contains the Microsoft.TeamFoundation.WorkItemTracking.Client.Field
        //     that is specified by its ID.
        //
        // Parameters:
        //   id:
        //     The ID of the desired Microsoft.TeamFoundation.WorkItemTracking.Client.Field.
        //
        // Returns:
        //     True if this collection contains the specified Microsoft.TeamFoundation.WorkItemTracking.Client.Field;
        //     otherwise, false.
        //
        // Exceptions:
        //   System.ValidationExcepion:
        //     The index parameter is out of range.
         /// <summary>
         /// Determines whether [contains] [the specified identifier].
         /// </summary>
         /// <param name="id">The identifier.</param>
         /// <returns><c>true</c> if [contains] [the specified identifier]; otherwise, <c>false</c>.</returns>
         bool Contains(int id);
        //
        // Summary:
        //     Checks whether this collection contains the Microsoft.TeamFoundation.WorkItemTracking.Client.Field
        //     that is specified by its name or reference name.
        //
        // Parameters:
        //   fieldName:
        //     The name or reference name of the Microsoft.TeamFoundation.WorkItemTracking.Client.Field
        //     to check for.
        //
        // Returns:
        //     True if this collection contains the specified Microsoft.TeamFoundation.WorkItemTracking.Client.Field;
        //     otherwise, false.
         /// <summary>
         /// Determines whether [contains] [the specified field name].
         /// </summary>
         /// <param name="fieldName">Name of the field.</param>
         /// <returns><c>true</c> if [contains] [the specified field name]; otherwise, <c>false</c>.</returns>
         bool Contains(string fieldName);
         /// <summary>
         /// Drops the cached data.
         /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
         void DropCachedData();
        //
        // Summary:
        //     Gets the Microsoft.TeamFoundation.WorkItemTracking.Client.Field in this collection
        //     that has the specified ID.
        //
        // Parameters:
        //   id:
        //     The ID of the Microsoft.TeamFoundation.WorkItemTracking.Client.Field.
        //
        // Returns:
        //     The Microsoft.TeamFoundation.WorkItemTracking.Client.Field that has the specified
        //     ID.
        //
        // Exceptions:
        //   Microsoft.TeamFoundation.WorkItemTracking.Client.ValidationException:
        //     The specified ID does not resolve to a Microsoft.TeamFoundation.WorkItemTracking.Client.Field
        //     in this collection.
        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>IField.</returns>
         IField GetById(int id);
           //
        // Summary:
        //     Gets the Microsoft.TeamFoundation.WorkItemTracking.Client.Field in this collection
        //     that has the specified ID.
        //
        // Parameters:
        //   id:
        //     The ID of the field.
        //
        // Returns:
        //     The field that has the specified ID. Null if not found.
         /// <summary>
         /// Tries the get by identifier.
         /// </summary>
         /// <param name="id">The identifier.</param>
         /// <returns>IField.</returns>
         IField TryGetById(int id);
    }

     /// <summary>
     /// Enum CoreField
     /// </summary>
    public enum CoreField
    {
    }
}