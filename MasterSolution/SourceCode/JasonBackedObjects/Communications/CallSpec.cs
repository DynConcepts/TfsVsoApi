using System.Collections.Generic;
using DynCon.OSI.Core.Helpers;

/// <summary>
/// Class CallSpec.
/// </summary>
public class CallSpec
{
    /// <summary>
    /// The r_ raw route
    /// </summary>
    private readonly string r_RawRoute;

    /// <summary>
    /// Initializes a new instance of the <see cref="CallSpec"/> class.
    /// </summary>
    /// <param name="rawRoute">The raw route.</param>
    public CallSpec(string rawRoute)
    { r_RawRoute = rawRoute; }

    public string Template { get { return r_RawRoute; } }

    /// <summary>
    /// Gets the dictionary.
    /// </summary>
    /// <returns>Dictionary&lt;System.String, System.String&gt;.</returns>
    public Dictionary<string, string> GetDictionary() { return StringFormatter.Parse(r_RawRoute); }
}