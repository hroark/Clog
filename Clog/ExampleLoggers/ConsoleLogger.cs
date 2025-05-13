// ***********************************************************************
// Assembly         : Clog
// Author           : HRoark
// Created          : 05-12-2025
//
// Last Modified By : HRoark
// Last Modified On : 05-12-2025
// ***********************************************************************
// <copyright file="ConsoleLogger.cs" company="Clog">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace Clog.ExampleLoggers;

/// <summary>
/// Class ConsoleLogger.
/// Implements the <see cref="Clog.CLogger" />
/// </summary>
/// <seealso cref="Clog.CLogger" />
public class ConsoleLogger : CLogger
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ConsoleLogger"/> class.
    /// </summary>
    /// <param name="NewWatcher">Creates new watcher.</param>
    public ConsoleLogger(CLogger NewWatcher) : base(NewWatcher)
    {
        _subscriptionLevel = NewWatcher._subscriptionLevel;
    }

    /// <summary>
    /// Logs the specified current level.
    /// </summary>
    /// <param name="CurrentLevel">The current level.</param>
    /// <param name="Message">The message.</param>
    public override void Log(EventLevel CurrentLevel, string Message)
    {
        if (CurrentLevel == _subscriptionLevel)
        {
            Console.WriteLine(Message);
        }
    }
}