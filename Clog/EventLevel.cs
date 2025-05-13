// ***********************************************************************
// Assembly         : Clog
// Author           : Hroark
// Created          : 05-03-2025
//
// Last Modified By : Hroark
// Last Modified On : 05-05-2025
// ***********************************************************************
namespace Clog;

// Changed struct to enum to fix CS1519 and IDE1007 errors
/// <summary>
/// Enum EventLevel
/// </summary>
public enum EventLevel
{
    /// <summary>
    /// The none
    /// </summary>
    None,

    /// <summary>
    /// The informational
    /// </summary>
    Informational,

    /// <summary>
    /// The error
    /// </summary>
    Error,

    /// <summary>
    /// The warning
    /// </summary>
    Warning,

    /// <summary>
    /// The fatal
    /// </summary>
    Fatal,

    /// <summary>
    /// All
    /// </summary>
    All
}