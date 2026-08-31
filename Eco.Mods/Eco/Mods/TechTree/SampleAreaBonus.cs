// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.SampleAreaBonus
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Gameplay.Components;

#nullable disable
namespace Eco.Mods.TechTree;

/// <summary> Sample area bonus configurations. Call on any <see cref="T:Eco.Gameplay.Components.AreaBonusComponent" /> for testing. </summary>
public static class SampleAreaBonus
{
  /// <summary> 10% crafting resource cost reduction within 20 blocks. </summary>
  public static void ConfigureLibraryBonus(AreaBonusComponent component);

  /// <summary> 10% labor cost reduction for the owner-selected profession, throughout the settlement selected on the parent's
  /// JurisdictionComponent. Activates once 2 stars are invested (and enough citizens hold the profession, per server settings). </summary>
  public static void ConfigureSettlementLibraryBonus(AreaBonusComponent component);
}
