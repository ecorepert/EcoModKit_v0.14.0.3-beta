// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.SalvageCostUtil
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Items.Recipes;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Items;

/// <summary>Shared helpers around <see cref="T:Eco.Gameplay.Items.SalvageCostAttribute" />. The same salvage cost drives what an item returns when recycled
/// and, scaled by <see cref="P:Eco.Gameplay.Systems.BalanceConfig.CraftGarbageRatio" />, the garbage produced when it is consumed as a crafting ingredient.</summary>
public static class SalvageCostUtil
{
  /// <summary>Fraction of a consumed ingredient's salvage cost that becomes garbage during crafting. Sourced from <see cref="T:Eco.Gameplay.Systems.BalanceConfig" />
  /// so admins can tune waste rate without recompiling.</summary>
  public static float CraftGarbageRatio { get; }

  /// <summary>Computes craft-time garbage (per-material quantities) for consuming <paramref name="quantity" /> units of <paramref name="itemType" />.
  /// Quantity is fractional because module and talent reductions yield partial ingredient costs. Returns empty when the item declares no <see cref="T:Eco.Gameplay.Items.SalvageCostAttribute" />.</summary>
  public static 
  #nullable disable
  IEnumerable<(Type Material, float Quantity)> GetCraftGarbage(Type itemType, float quantity);

  /// <summary>Best-effort concrete type behind a recipe ingredient, for approximate garbage previews. A tag ingredient resolves to a representative
  /// tagged type (preferring one that declares a salvage cost) because the item actually contributed is unknown until craft time.</summary>
  public static Type ResolveIngredientType(IngredientElement ingredient);
}
