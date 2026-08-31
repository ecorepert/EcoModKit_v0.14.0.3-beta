// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Blocks.BlockFormManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.World.Blocks;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Blocks;

public static class BlockFormManager
{
  public static BlockFormData Data;

  public static IEnumerable<BlockForm> GetToolForms(Type type);

  public static bool HasForms(Type type);

  /// <summary>Finds the form a placed block type belongs to (rotated variants included), null if it's not a form block.</summary>
  public static BlockForm GetFormForBlock(Type blockType);

  /// <summary>True when the placed block's form fills only part of its voxel (thin floors, edge walls, roof fills), leaving room for placed objects to share the cell.</summary>
  public static bool IsPartialFillBlock(Block block);

  public static Type GetBlockTypeToCreate(
    Player player,
    Item tool,
    Item matType,
    string form,
    int rotation);

  public static Type GetBlockTypeToCreate(
    Player player,
    Type tooltype,
    Item matType,
    string form,
    int rotation);

  public static void Initialize();
}
