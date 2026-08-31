// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.InventoryRelated.ConsolidationUtils
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.Players;

#nullable enable
namespace Eco.Gameplay.Items.InventoryRelated;

/// <summary>Class used to consolidate storages (order inventories by type, quantity and quality).</summary>
public static class ConsolidationUtils
{
  /// <summary>Consolidate inventory items into least amount of stacks.</summary>
  public static Result ConsolidateInventory(Inventory inventory, User? user = null);
}
