// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.InventoryRelated.IInventoryManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Items.InventoryRelated;

public interface IInventoryManager
{
  IEnumerable<Inventory> AllLeafInventories { get; }

  IEnumerable<ItemStack> AllStacks { get; }

  void VerifyDestroyed(Inventory inventory);

  internal void TrackInventoryLock(InventoryLock inventoryLock);
}
