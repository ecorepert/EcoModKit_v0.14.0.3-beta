// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Placement.BlockPlacementUtils
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.Math;

#nullable disable
namespace Eco.Gameplay.Placement;

/// <summary>Functions to assist in placing blocks</summary>
public static class BlockPlacementUtils
{
  /// <summary>Drop carried block/rubble in current direction player is facing</summary>
  public static bool DropCarriedBlock(Player player);

  /// <summary>Place a block at the given position, stacking or dropping as appropriate.</summary>
  public static bool PlaceAndNotify(Player player, BlockItem item, Vector3i blockPosition);
}
