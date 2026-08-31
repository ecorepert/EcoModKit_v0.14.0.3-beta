// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.Recipes.IngredientElement
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.DynamicValues;
using Eco.Shared.Localization;
using Eco.Shared.View;
using System;

#nullable disable
namespace Eco.Gameplay.Items.Recipes;

/// <summary>Dynamic quantity tag stack.</summary>
/// <remarks>Should never be used to represent an actual item.</remarks>
[ConstantView]
public class IngredientElement : IController, IViewController, IHasUniversalID
{
  [SyncToView(null, true)]
  public IDynamicValue Quantity { get; }

  [SyncToView(null, true)]
  public Tag Tag { get; }

  [SyncToView(null, true)]
  public Item Item { get; }

  public ItemRepresentation ItemRepresentation { get; set; }

  [SyncToView(null, true)]
  public bool IsSpecificItem { get; }

  public string InnerName { get; }

  public override int GetHashCode();

  public override bool Equals(object obj);

  public bool MeetsRequirement(FractionalItemStack ingredient);

  public ref int ControllerID { get; }

  public IngredientElement(string tag, float count = 1f, bool staticIngredient = false);

  public IngredientElement(string tag, float start, Type skill, Type talent = null);

  public IngredientElement(Type itemType, float count = 1f, bool staticIngredient = false);

  public IngredientElement(Type itemType, float start, Type skill, Type talent = null);

  public IngredientElement(ItemRepresentation stackable, float count = 1f, bool staticIngredient = false);

  public IngredientElement(ItemRepresentation stackable, float start, Type skill, Type talent = null);

  public LocString UILink();
}
