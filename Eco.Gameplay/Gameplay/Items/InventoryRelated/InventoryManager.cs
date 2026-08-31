// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.InventoryRelated.InventoryManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Items.InventoryRelated;

/// <summary>Tracks all inventories so that they can be scanned for items. Also checks that all inventory locks are disposed correctly. </summary>
public class InventoryManager : IInventoryManager
{
  public 
  #nullable disable
  IEnumerable<Inventory> AllLeafInventories { get; }

  public void VerifyDestroyed(Inventory inventory);

  public void TrackInventoryLock(InventoryLock inventory);

  public IEnumerable<ItemStack> AllStacks { get; }
}
