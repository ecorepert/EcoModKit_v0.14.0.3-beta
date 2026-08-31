// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Objects.WaterWorldObjectBlock
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Serialization;
using Eco.World.Blocks;

#nullable disable
namespace Eco.Gameplay.Objects;

/// <summary>
/// A WorldObject Water Block that replaces a Terrain Water Block. Occupies the space in the water, blocking placement
/// </summary>
[Serialized]
[Transient]
[Occupied]
[UnderWater]
public class WaterWorldObjectBlock : WorldObjectBlock, IWaterBlock
{
  public WaterWorldObjectBlock(WorldObject worldObject, float water);

  protected WaterWorldObjectBlock();

  [Serialized]
  public float Water { get; set; }

  public bool PipeSupplied { get; }
}
