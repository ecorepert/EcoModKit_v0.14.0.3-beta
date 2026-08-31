// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.Recipes.CraftingElement`1
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using System;

#nullable disable
namespace Eco.Gameplay.Items.Recipes;

public class CraftingElement<T> : CraftingElement where T : Item, new()
{
  public CraftingElement(Type skill, float start, Type talent = null);

  public CraftingElement(Type skill, float start, bool refundsIngredient, Type talent = null);

  public CraftingElement(float count = 1f);

  public CraftingElement(float count, bool refundsIngredient);
}
