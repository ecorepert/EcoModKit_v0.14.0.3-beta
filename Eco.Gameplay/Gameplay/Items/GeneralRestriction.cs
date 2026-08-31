// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.GeneralRestriction
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;
using System;

#nullable disable
namespace Eco.Gameplay.Items;

/// <summary>Restricts the inventory to only things that pass a given function.</summary>
public class GeneralRestriction : InventoryRestriction
{
  /// <summary>Passes in item and quantity, returns how many are accepted.</summary>
  public GeneralRestriction(Func<Item, int> testFunc, LocString message);

  public override int Priority { get; }

  public override LocString Message { get; }

  public override int MaxAccepted(Item item);

  public override int MaxPickup(RestrictionCheckData checkData, Item item, int totalMoved);
}
