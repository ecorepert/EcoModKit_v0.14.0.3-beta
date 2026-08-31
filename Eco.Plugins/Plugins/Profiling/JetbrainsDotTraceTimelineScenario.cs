// Decompiled with JetBrains decompiler
// Type: Eco.Plugins.Profiling.JetbrainsDotTraceTimelineScenario
// Assembly: Eco.Plugins, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F4134161-E179-4364-AAAD-A17DB32FD1E5
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Plugins.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Plugins.xml

using System;

#nullable disable
namespace Eco.Plugins.Profiling;

public class JetbrainsDotTraceTimelineScenario : IProfilingScenario
{
  public string ToolName { get; }

  public string ResultType { get; }

  public string Extention { get; }

  public string InstallLink { get; }

  public void Run(string baseName, TimeSpan duration);
}
