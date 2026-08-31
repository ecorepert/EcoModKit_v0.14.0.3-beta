// Decompiled with JetBrains decompiler
// Type: Eco.WorldGenerator.WorldPresetsRange
// Assembly: Eco.WorldGenerator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A724B74F-8AA3-4D77-9B84-B427AB13CB8B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WorldGenerator.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WorldGenerator.xml

using Eco.Shared.Settings;

#nullable disable
namespace Eco.WorldGenerator;

/// <summary> Specify a correspondence between a property pair of values as ranges and the selected <see cref="T:Eco.Shared.Settings.WorldDimensions.WorldDimensionsPreset" />. The <see cref="T:Eco.Shared.Math.Range" /> of properties with this attribute is updated when the selected preset (<see cref="P:Eco.WorldGenerator.WorldSettings.MapSizePreset" />) is changed. </summary>
public sealed class WorldPresetsRange : WorldPresetsPropertyCorrespondence
{
  public WorldPresetsRange(params float[] values);

  public override object PresetValue(WorldDimensions.WorldDimensionsPreset preset);
}
