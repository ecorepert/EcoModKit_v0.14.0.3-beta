// Decompiled with JetBrains decompiler
// Type: Eco.Core.Plugins.PluginTickTimerBase
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

#nullable enable
namespace Eco.Core.Plugins;

/// <summary>Base class for all <see cref="T:Eco.Core.Plugins.PluginTickTimer" /> implementations.</summary>
public class PluginTickTimerBase
{
  /// <summary>The name of the plugin we are currently monitoring.</summary>
  public string PluginName { get; }

  public PluginTickTimerBase(string pluginName);

  /// <summary>Posts our metrics to ElasticSearch under our configured plugin name.</summary>
  /// <param name="averageTime">The total average time of the tick.</param>
  /// <param name="totalTime">The total tick time.</param>
  protected void StoreTickMetric(double averageTime, double totalTime);
}
