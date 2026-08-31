// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Graphics.ColorMixer
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Utils;

#nullable disable
namespace Eco.Shared.Graphics;

/// <summary>
/// Logic container for color mixing
/// Implements basic blending of coloros based on weights
/// </summary>
public class ColorMixer
{
  /// <summary> Multiplier for paint mixing. Applies to colorant consumption, based on amount of buckets put in slot. </summary>
  public static int PaintBucketCountForConsumptionIncrease;
  /// <summary> Holds possible colorants data for mixing. Name, color and item link </summary>
  public static ColorantData[] PossibleColorants;

  /// <summary> Get final color from recipe. Approach is based on colorant weights,that is calculated towards total weight amount. </summary>
  public static ByteColor MixColors(ColorRecipe recipe);

  /// <summary> Gets colorant data, based on a ColorRecipe ingredient </summary>
  public static ColorantData GetColorantData(ColorantWeight ingredient);
}
