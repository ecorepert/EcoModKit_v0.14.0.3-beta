// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.Recipes.RecipeManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Items.Recipes;

/// <summary>Accessors for all recipes.</summary>
public class RecipeManager
{
  /// <summary>The item name (minus appended 'item') to the recipe.</summary>
  public static 
  #nullable disable
  Dictionary<string, List<Recipe>> ProductNameToRecipes;

  public static List<Recipe> AllRecipes { get; }

  public static RecipeFamily[] AllRecipeFamilies { get; }

  public static IEnumerable<Recipe> GetRecipesForItemProduct(Type t);

  public static RecipeFamily GetRecipeFamily(Type t);

  public static RecipeFamily GetRecipeFamily(string t);

  public static RecipeFamily GetRecipeFamily<T>();

  public static bool ContainsRecipeFamily(Type t);

  public static IEnumerable<RecipeFamily> GetRecipeFamiliesForItem(Type type);

  public static IEnumerable<RecipeFamily> GetRecipeFamiliesUsingTag(Tag tag);

  public static IEnumerable<RecipeFamily> GetRecipeFamiliesBySkill(Type skill);

  public static float CraftTimeModifier { get; set; }

  public static float CraftResourceModifier { get; set; }

  public static void Initialize();
}
