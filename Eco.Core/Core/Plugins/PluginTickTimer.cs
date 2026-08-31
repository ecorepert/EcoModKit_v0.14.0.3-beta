// Decompiled with JetBrains decompiler
// Type: Eco.Core.Plugins.PluginTickTimer
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

#nullable enable
namespace Eco.Core.Plugins;

/// <summary>Generic tick timer for collecting and storing average tick metrics.</summary>
public class PluginTickTimer : PluginTickTimerBase
{
  public bool ExcludeOutliers;
  public bool Sort;

  public bool IsTicking { get; }

  public double LastTickTotalTime { get; }

  public double AverageTickTime { get; }

  public PluginTickTimer(string pluginName);

  public void BeginTick();

  public void EndTick();

  public void AddTime(string key, float time);

  public void Clear();

  public override string ToString();
}
