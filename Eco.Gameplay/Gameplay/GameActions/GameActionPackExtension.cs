// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.GameActionPackExtension
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.GameActions;

public static class GameActionPackExtension
{
  /// <summary>This is an particular extension only for InventoryChangeSet to get or create a ChangeSet from a GameActionPack with inventory and user</summary>
  /// &gt;
  public static InventoryChangeSet GetOrCreateInventoryChangeSet(
    this GameActionPack pack,
    Inventory inventory,
    User user = null);

  public static InventoryChangeSet GetOrCreateInventoryChangeSet(
    this GameActionPack pack,
    IEnumerable<Inventory> inventories,
    User user = null);
}
