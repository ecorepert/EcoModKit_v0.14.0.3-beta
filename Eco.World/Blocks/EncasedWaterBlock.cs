// Decompiled with JetBrains decompiler
// Type: Eco.World.Blocks.EncasedWaterBlock
// Assembly: Eco.World, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B2A8792E-938E-4BB5-B27F-EF3390C48946
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.xml

using Eco.Shared.Math;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.World.Blocks;

/// <summary>
/// Water that is under other water or solid blocks, at maximum level. Does no processing of it's own.
/// </summary>
[Serialized]
[UnderWater]
public class EncasedWaterBlock : Block, IWaterBlock
{
  public float Water { get; }

  public bool PipeSupplied { get; }

  /// <summary>Set block to Water</summary>
  public void FillWithWater(Vector3i pos);
}
