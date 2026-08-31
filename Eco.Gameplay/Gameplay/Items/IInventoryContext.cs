// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.IInventoryContext
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

#nullable disable
namespace Eco.Gameplay.Items;

/// <summary>
/// Used by <see cref="T:Eco.Gameplay.Components.VehicleComponent" /> to override the <see cref="T:Eco.Gameplay.Players.Player" />'s inventory context when mounted in a vehicle.
/// <para>An inventory context can be overriden by setting InventoryContext or BuilderInventoryContext to the new inventory object that needs to be used.</para>
/// 
/// <para>The context is used by <see cref="T:Eco.Gameplay.Components.Storage.StorageComponent" /> to read what contents are in the <see cref="T:Eco.Gameplay.Players.Player" />'s inventories.</para>
/// 
/// <para>Ex. <see cref="T:Eco.Gameplay.Components.CraneToolComponent" /> overrides it's vehicles BuilderInventoryContext with its own ClawInventory so <see cref="T:Eco.Gameplay.Components.Storage.StorageComponent" />
/// will use the crane's builder inventory instead of the player's when mounted.</para>
/// </summary>
public interface IInventoryContext
{
  /// <summary>The toolbar inventory context. Handles ItemStacks and selecting.</summary>
  ToolbarInventory InventoryContext { get; set; }

  /// <summary>The builders inventory context. Handles items that need to be picked up.</summary>
  BuilderInventory BuilderInventoryContext { get; set; }
}
