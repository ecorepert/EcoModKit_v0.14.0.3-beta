// Decompiled with JetBrains decompiler
// Type: Eco.Core.Plugins.PluginTickTimer`1
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

#nullable enable
namespace Eco.Core.Plugins;

/// <summary>Typedef variant of the <seealso cref="T:Eco.Core.Plugins.PluginTickTimer" /> class for monitoring and collecting tick averages.</summary>
/// <typeparam name="T">Plugin type to monitor</typeparam>
public class PluginTickTimer<T> : PluginTickTimerBase where T : ITickSample, new()
{
  public bool IsTicking { get; }

  public double LastTickTotalTime { get; }

  public double AverageTickTime { get; }

  public PluginTickTimer(string pluginName);

  public T BeginTick();

  public void EndTick();

  public override string ToString();
}
