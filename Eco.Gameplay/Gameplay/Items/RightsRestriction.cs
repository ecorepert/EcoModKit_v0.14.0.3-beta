// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.RightsRestriction
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using System;

#nullable disable
namespace Eco.Gameplay.Items;

/// <summary>Sets an inventory to only accept(or give) items if a player has proper rights.</summary>
public class RightsRestriction : InventoryRestriction
{
  public Func<User, bool> RightsCheck;

  public override LocString Message { get; }

  public override RestrictionDescriptor Describe();

  public override int MaxAccepted(RestrictionCheckData checkData, Item item);

  public override int MaxPickup(RestrictionCheckData checkData, Item item, int totalMoved);
}
