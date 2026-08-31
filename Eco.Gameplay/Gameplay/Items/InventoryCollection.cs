// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.InventoryCollection
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Items;

public class InventoryCollection : Inventory
{
  protected override IEnumerable<Inventory> SubInventories { get; }

  public InventoryCollection(IEnumerable<Inventory> inventories);

  public InventoryCollection(params Inventory[] inventories);

  public override bool IsLeafInventory { get; }

  public string DescribeOwners();
}
