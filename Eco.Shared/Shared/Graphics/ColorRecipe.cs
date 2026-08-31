// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Graphics.ColorRecipe
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Shared.Graphics;

/// <summary>
/// Data container for single color recipe in Mixer.
/// Holds list of ingredients (colorant names with weights) to use in color mixing process
/// Used in client/server transfers, so needs separate sync-able container.
/// </summary>
public class ColorRecipe : IEquatable<ColorRecipe>
{
  /// <summary> List of ingredients for recipe (colorant names with weights) </summary>
  [Eco.Shared.Networking.Eco(true)]
  public List<ColorantWeight> Ingredients { get; }

  [Eco.Shared.Networking.Eco(true)]
  public int Multiplier { get; set; }

  public bool HasData { get; }

  /// <summary> Removes one portion of requested colorant from recipe </summary>
  public void RemoveOnce(string colorantName);

  /// <summary> Count amount of all ingredients used </summary>
  public int GetTotalIngredientsUsed(bool includeMultiplier = true);

  /// <summary> Adds one portion of requested colorant to recipe </summary>
  public void AddOnce(string colorantName);

  /// <summary> Gets total weight of requested colorant in recipe </summary>
  public int GetAmount(string colorant, bool includeMultiplier = true);

  /// <summary>  Makes a copy of recipe </summary>
  public ColorRecipe MakeCopy();

  public bool Equals(ColorRecipe other);

  public override bool Equals(object obj);

  public override int GetHashCode();
}
