// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.LoaderCarrySlotRestriction
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Gameplay.Items;
using Eco.Shared.Localization;
using System;

#nullable disable
namespace Eco.Mods.TechTree;

/// <summary>Locks a loader's carry slot to the module's own lift controls. A hand take would strand the container's load on the module (a lifted container's
/// contents live there, not in the item), and a hand put would skip the lift's checks entirely.</summary>
public class LoaderCarrySlotRestriction : InventoryRestriction
{
  public LoaderCarrySlotRestriction(Func<bool> moduleIsTransferring);

  public override LocString Message { get; }

  public override int Priority { get; }

  public override RestrictionDescriptor Describe();

  public override int MaxAccepted(Item item);

  public override int MaxPickup(RestrictionCheckData checkData, Item item, int totalMoved);
}
