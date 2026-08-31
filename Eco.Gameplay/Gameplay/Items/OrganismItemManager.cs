// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.OrganismItemManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Simulation.Types;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Items;

public static class OrganismItemManager
{
  public static void AddRandomResourcesToChangeSet(
    ref InventoryChangeSet set,
    Species species,
    int? quantity = null);

  /// <summary>Add resources from species resource by quantity</summary>
  public static void AddResourcesToChangeSet(
    this InventoryChangeSet set,
    Species species,
    int quantity);

  public static IEnumerable<Species> SourceSpeciesForItem(Type itemType);
}
