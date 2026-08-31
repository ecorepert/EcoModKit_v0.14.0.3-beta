// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.PartsInventoryRestriction
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Items;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Components;

public class PartsInventoryRestriction : InventoryRestriction
{
  public PartsComponent PartsComponent;

  public override LocString Message { get; }

  public override RestrictionDescriptor Describe();

  public override int MaxPickup(RestrictionCheckData checkData, Item item, int currentQuantity);

  public override int MaxAccepted(RestrictionCheckData checkData, Item item);
}
