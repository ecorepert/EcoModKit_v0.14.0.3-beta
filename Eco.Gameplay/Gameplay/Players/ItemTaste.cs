// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Players.ItemTaste
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Players;

[Serialized]
public struct ItemTaste
{
  public static int MinCaloriesToBeFavOrWorst;
  public static int MinNutrientsToBeFavOrWorst;
  public static float[] TasteWeightedRandomness;
  public static float[] TastinessMultiplier;
  private static float weightSum;
  [Serialized]
  public ItemTaste.TastePreference Preference;
  [Serialized]
  public bool Discovered;

  /// <summary>Returns a value between 0 and 1 representing the user's taste for the food.</summary>
  public float TastePercent { get; }

  public static void Initialize();

  public static ItemTaste MakeRandomNonExtremeTaste(bool discovered = false);

  public float TastinessMult { get; }

  public LocString DescribeTaste();

  public LocString PostDescribeTaste();

  [Serialized]
  public enum TastePreference
  {
    Worst,
    Horrible,
    Bad,
    Ok,
    Good,
    Delicious,
    Favorite,
  }
}
