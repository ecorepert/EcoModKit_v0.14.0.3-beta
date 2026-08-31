// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.EcoMarketplace.MarketplaceExtensions
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Items;
using Eco.Gameplay.Items.Recipes;

#nullable disable
namespace Eco.Gameplay.Systems.EcoMarketplace;

public static class MarketplaceExtensions
{
  public static bool IsPaidItem(this Item item);

  public static bool IsPaidItem(this int id);

  public static bool IsPaidItem(this Recipe recipe);
}
