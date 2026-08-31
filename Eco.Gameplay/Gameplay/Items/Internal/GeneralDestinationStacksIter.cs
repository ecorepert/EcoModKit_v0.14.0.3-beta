// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.Internal.GeneralDestinationStacksIter
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Items.Internal;

/// <summary>Implementation of <see cref="T:Eco.Gameplay.Items.Internal.DestinationStacksIter" /> for items movement. It filters destination stacks to either match item type or be empty. Then stacks ordered descending by quantity.</summary>
internal class GeneralDestinationStacksIter : DestinationStacksIter
{
  protected readonly InventoryChangeSet changeSet;
  protected readonly List<ItemStack> suitableStacks;

  internal GeneralDestinationStacksIter(
    InventoryChangeSet changeSet,
    IEnumerable<ItemStack> allStacks,
    Item item);

  public override bool SetSourceItem(Item sourceItem);
}
