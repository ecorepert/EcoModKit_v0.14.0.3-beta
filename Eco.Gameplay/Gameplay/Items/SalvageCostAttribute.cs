// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.SalvageCostAttribute
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Items;

/// <summary>Declares what an item yields when recycled — also drives craft-time garbage via <see cref="P:Eco.Gameplay.Items.SalvageCostUtil.CraftGarbageRatio" />.
/// Constructor takes alternating (Type material, float quantity) pairs where material is a <see cref="T:Eco.Gameplay.Garbage.GarbageMaterial" /> subclass,
/// e.g. <c>[SalvageCost(typeof(IronScrap), 0.2f, typeof(BioResidue), 0.1f)]</c>.</summary>
public class SalvageCostAttribute : ItemAttribute
{
  public IReadOnlyDictionary<Type, float> Costs { get; }

  public SalvageCostAttribute(params object[] materialAndQuantityPairs);
}
