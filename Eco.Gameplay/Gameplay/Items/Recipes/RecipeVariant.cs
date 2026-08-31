// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.Recipes.RecipeVariant
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Items.Recipes;

/// <summary> Recipe variant with different ingredients which may be activated for <see cref="T:Eco.Gameplay.Items.Recipes.Recipe" /> based on some conditions (like difficulty settings). </summary>
public class RecipeVariant
{
  /// <summary> Set of ingredients for the recipe variant which will replace current set of ingredients when activated. See <see cref="M:Eco.Gameplay.Items.Recipes.Recipe.ActivateVariant(Eco.Gameplay.Items.Recipes.RecipeVariant)" />. </summary>
  public readonly List<IngredientElement> Ingredients;

  public RecipeVariant(IEnumerable<IngredientElement> ingredients);

  /// <summary>
  /// Registers <paramref name="recipeFamily" /> default recipe <paramref name="ingredients" /> variant for <paramref name="preset" />.
  /// Then you can just activate all registered recipe variants for the <paramref name="preset" /> at once with <see cref="M:Eco.Gameplay.Items.Recipes.RecipeVariant.ActivatePreset(System.String)" />.
  /// <paramref name="preset" /> may have any value, it is just a reference name you can use to activate variants when required.
  /// </summary>
  public static void Register(string preset, Type recipeFamily, IngredientElement[] ingredients);

  /// <inheritdoc cref="M:Eco.Gameplay.Items.Recipes.RecipeVariant.Register(System.String,System.Type,Eco.Gameplay.Items.Recipes.IngredientElement[])" />
  /// <typeparamref name="T" />
  ///  is recipe family type.
  public static void Register<T>(string preset, IngredientElement[] ingredients) where T : RecipeFamily;

  /// <summary> Registers multiple recipe variants for a <paramref name="preset" />. <paramref name="mapping" /> param has mapping between <see cref="T:Eco.Gameplay.Items.Recipes.RecipeFamily" /> type and set of ingredients for the <paramref name="preset" />. </summary>
  public static void Register(
    string preset,
    IEnumerable<KeyValuePair<Type, IngredientElement[]>> mapping);

  /// <summary> Registers default (current, usually from startup) ingredients list of recipe family of type <typeparamref name="T" /> for the <paramref name="preset" />. See <see cref="M:Eco.Gameplay.Items.Recipes.RecipeVariant.Register(System.String,System.Type,Eco.Gameplay.Items.Recipes.IngredientElement[])" />. </summary>
  public static void RegisterDefault<T>(string preset) where T : RecipeFamily;

  public static void ActivatePreset(string preset);
}
