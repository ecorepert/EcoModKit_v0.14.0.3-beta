// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Settings.WorldDimensions
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable
namespace Eco.Shared.Settings;

[TypeConverter(typeof (ExpandableObjectConverter))]
[Serializable]
public class WorldDimensions : ICloneable
{
  [JsonIgnore]
  public int UworldWidth;
  [JsonIgnore]
  public int UworldLength;
  public static readonly Dictionary<WorldDimensions.WorldDimensionsPreset, WorldDimensions> Presets;
  [JsonIgnore]
  public Action ValidateWorldHeight;

  [DefaultValue(72)]
  [LocDisplayName("World Width")]
  [LocDescription("Width of the world in chunks, must be divisible by 4")]
  public int WorldWidth { get; set; }

  [DefaultValue(72)]
  [LocDisplayName("World Length")]
  [LocDescription("Length of the world in chunks, must be divisible by 4")]
  public int WorldLength { get; set; }

  public object Clone();

  public override string ToString();

  [Localized(true, false, "", false)]
  public enum WorldDimensionsPreset
  {
    Small,
    Medium,
    Large,
  }
}
