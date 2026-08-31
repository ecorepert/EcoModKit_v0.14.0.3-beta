// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.Recipes.CraftingElement
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Ecopedia;
using Eco.Core.Systems;
using Eco.Gameplay.DynamicValues;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Shared.Items;
using Eco.Shared.View;
using System;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Items.Recipes;

[Category("Hidden")]
public abstract class CraftingElement : 
  IController,
  IViewController,
  IHasUniversalID,
  ICustomEcopediaPage
{
  [NewTooltipChildren(CacheAs.Instance, TTCat.Controls)]
  [SyncToView(null, true)]
  public Item Item { get; protected set; }

  [SyncToView(null, true)]
  public IDynamicValue Quantity { get; protected set; }

  /// <summary>Overrides ingredient-refund auto-detection for this product. Null (default) auto-detects: a product whose item matches one of the
  /// recipe's ingredients is a partial refund (e.g. molds returned by a kiln). Refunds scale with the crafter's resource-cost discount and skip
  /// yield bonuses, so upgrades can never return more of an ingredient than the craft consumed.</summary>
  public bool? RefundsIngredient { get; protected set; }

  public string GetEcopediaPage();

  public ref int ControllerID { get; }

  public CraftingElement();

  public CraftingElement(Type itemType, int count = 1);

  public CraftingElement(Type itemType, int count, bool refundsIngredient);
}
