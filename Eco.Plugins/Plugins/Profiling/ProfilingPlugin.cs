// Decompiled with JetBrains decompiler
// Type: Eco.Plugins.Profiling.ProfilingPlugin
// Assembly: Eco.Plugins, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F4134161-E179-4364-AAAD-A17DB32FD1E5
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Plugins.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Plugins.xml

using Eco.Core.Plugins.Interfaces;
using Eco.Core.Utils;
using Eco.Gameplay.Systems.Chat;
using Eco.Shared.Localization;
using System;
using System.Collections.Generic;
using System.IO;

#nullable disable
namespace Eco.Plugins.Profiling;

/// <summary>Allows admins to run profiling tasks on the server to get diagnostic data.</summary>
/// <remarks>Can be run from server UI and called from in-game via commands (/profiler). Depends on `dotnet-dump` and `dotnet-trace` tools and requires them to be installed and available on system's PATH.</remarks>
[LocDisplayName("ProfilingPlugin")]
public class ProfilingPlugin : ICommandablePlugin, IServerPlugin, IInitializablePlugin
{
  public const string WebPath = "profiling-results";

  /// <summary>
  /// Retrieves the servers current install directory. Due to either a bug or core change in .NET 6 a unique lookup
  /// method is required on MacOS Catalina or newer otherwise the server will crash on startup trying to write to the install
  /// folder of .NET which is now read only
  /// </summary>
  public static string ExecutableDirectory { get; }

  public static DirectoryInfo ResultsDirectory { get; }

  public string GetStatus();

  public override string ToString();

  public string GetCategory();

  public void GetCommands(Dictionary<string, Action> nameToFunction);

  public void Initialize(TimedTask timer);

  /// <summary>Convert flags to a list of IProfilingScenario</summary>
  public void RunProfilers(IChatClient client, ProfilingScenario scenario = ProfilingScenario.Memory | ProfilingScenario.CPU_dottrace, int seconds = 60);

  /// <summary>Generates a simplified result filename combining: simplified, sortable date; application name; result type name and extension.</summary>
  public static string GetResultFilename(
    DateTime startTime,
    string resultTypeName,
    string @extension);

  /// <summary>This utility applies sane defaults for use with dotnet diagnostics tools and changes working directory to <see cref="P:Eco.Plugins.Profiling.ProfilingPlugin.ResultsDirectory" /> for simpler file saves.</summary>
  /// <exception cref="T:System.ApplicationException">Thrown when the invoked dotnet tool finishes with an erroneous exit code.</exception>
  public static void RunDotnetTool(string tool, string args);
}
