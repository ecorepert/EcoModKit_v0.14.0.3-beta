// Decompiled with JetBrains decompiler
// Type: Eco.World.Color.IColoredBlock
// Assembly: Eco.World, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B2A8792E-938E-4BB5-B27F-EF3390C48946
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.xml

using Eco.Shared.Math;
using Eco.Shared.Utils;
using Eco.World.Blocks.Features;

#nullable disable
namespace Eco.World.Color;

/// <summary>Used for blocks that can accept colors from the dyes and painting system.</summary>
public interface IColoredBlock : IColorBlockData
{
  /// <inheritdoc cref="M:Eco.World.Blocks.Features.IColorBlockData.GetColor(Eco.Shared.Math.Vector3i)" />
  ByteColor IColorBlockData.GetColor(Vector3i pos);
}
