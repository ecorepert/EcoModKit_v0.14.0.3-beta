// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.StockpileStackRestriction
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

#nullable disable
namespace Eco.Gameplay.Items;

public class StockpileStackRestriction : StackLimitRestriction
{
  public override RestrictionType Type { get; }

  /// <summary>How many blocks fit in a column: the pile's physical height. Surfaced in the inventory summary.</summary>
  public int MaxStackHeight { get; }

  public StockpileStackRestriction(int maxStackHeight, bool staticLimit = false);

  public override RestrictionDescriptor Describe();

  protected override int GetMaxItemsOverrider(Item item);
}
