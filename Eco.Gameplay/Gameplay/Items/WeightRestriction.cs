// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.WeightRestriction
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Items;

/// <summary>Prohibits the inventory Prohibits from accepting items beyond the weight limit</summary>
public class WeightRestriction : InventoryRestriction
{
  public override int Priority { get; }

  public override RestrictionDescriptor Describe();

  public static WeightRestriction Add(Inventory inventory, int maxWeight);

  public void SetMaxWeight(int maxWeight);

  public override LocString Message { get; }

  public override int MaxAccepted(RestrictionCheckData checkData, Item item, int currentQuantity);

  public override int MaxAccepted(Item item, int currentQuantity);
}
