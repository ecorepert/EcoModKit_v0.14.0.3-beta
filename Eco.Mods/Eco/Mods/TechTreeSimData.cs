// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTreeSimData
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Gameplay.Items;
using Eco.Gameplay.Items.Recipes;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Mods;

public class TechTreeSimData
{
  public List<Type> CurSkills;
  public List<Recipe> CurRecipes;
  public List<Recipe> UnusableRecipes;
  public HashSet<Type> CraftableItems;
  public HashSet<Tag> CraftableTags;
  public List<Type> CraftingTables;
  public Queue<Type> SkillsToEvaluate;

  public void AddSkill(Type skill);

  public bool HasIngredient(IngredientElement element);

  public void AddItem(Type itemType);

  public void AddItems(IEnumerable<Type> itemTypes);
}
