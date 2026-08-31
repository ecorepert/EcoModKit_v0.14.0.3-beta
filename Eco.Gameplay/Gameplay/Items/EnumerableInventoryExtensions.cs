// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.EnumerableInventoryExtensions
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.Players;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Items;

public static class EnumerableInventoryExtensions
{
  public static 
  #nullable disable
  IEnumerable<ItemStack> AllStacks(this IEnumerable<Inventory> inventories);

  public static void Modify(
    this IEnumerable<Inventory> inventories,
    Action<IInventoryChangeSet> callback,
    User user = null);

  public static Result TryModify(
    this IEnumerable<Inventory> inventories,
    Action<IInventoryChangeSet> callback,
    User user = null);
}
