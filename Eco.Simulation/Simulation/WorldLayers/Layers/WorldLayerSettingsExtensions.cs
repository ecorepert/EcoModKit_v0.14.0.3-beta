// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.WorldLayers.Layers.WorldLayerSettingsExtensions
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

#nullable disable
namespace Eco.Simulation.WorldLayers.Layers;

public static class WorldLayerSettingsExtensions
{
  /// <summary> Returns a string in HTML format for the <paramref name="val" /> using <paramref name="settings" />. Set <paramref name="relative" /> if you wanna to format value difference. </summary>
  public static string ValStringHtml(this WorldLayerSettings settings, float val, bool relative = false);

  /// <summary> Returns a tooltip string for the <paramref name="val" /> using <paramref name="settings" />. Set <paramref name="relative" /> if you wanna to format value difference. </summary>
  public static string ValStringTooltip(this WorldLayerSettings settings, float val, bool relative = false);
}
