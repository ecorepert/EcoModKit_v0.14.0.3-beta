// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Players.Food.Cravings
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Items;
using Eco.Shared.Serialization;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Players.Food;

[Serialized]
public class Cravings
{
  public static double MinAgeBeforeCravings;
  public static double TimeBetweenCravings;
  public static double MaxTimeToSatisfyCraving;
  public static int MaxCravingSatisfied;
  public static float CravingsBoost;
  public static int MinCaloriesForCravings;
  public static int MinNutrientsForCravings;

  public void Initialize(
    #nullable disable
    Func<IDictionary<Type, ItemTaste>> getTypeToTaste,
    Func<IEnumerable<Type>> getStomachContents,
    Action<Type> onCravingUpdate);

  public (float Mult, string CravingsSatified) GetMult();

  public void UpdateCraving(User user, bool forceNew = false, Type newCraving = null);

  public string DoEat(User user, FoodItem food);

  public bool IsCravingFood(FoodItem foodItem);

  /// <summary> The message describing the craving, shown in tooltip for the user.</summary>
  public string Message();
}
