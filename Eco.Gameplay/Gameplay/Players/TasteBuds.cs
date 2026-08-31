// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Players.TasteBuds
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Players;

[Serialized]
public class TasteBuds
{
  public static ThreadSafeAction<User, FoodItem, ItemTaste.TastePreference> TastePreferenceDiscoveredEvent;
  [Serialized]
  public ThreadSafeDictionary<Type, ItemTaste> FoodToTaste;

  public FoodItem Favorite { get; }

  public FoodItem Worst { get; }

  public bool FavoriteDiscovered { get; }

  public bool WorstDiscovered { get; }

  internal ItemTaste? GetTaste(Type type);

  /// <summary>The taste for a food the user has actually tried, null otherwise: tastes are assigned before being discovered and must stay hidden until eaten.</summary>
  public ItemTaste? GetDiscoveredTaste(FoodItem food);

  public void Initialize(Func<IEnumerable<Type>> getStomachContents);

  public (float Mult, string Desc) UpdateMult(Dictionary<Type, float> foodToCalories);

  /// <summary>Build the string created when eating the item, send any notices if fav/worst food is discovered, and return a string description of it.</summary>
  public (LocString Taste, LocString Notification) DoEat(User user, FoodItem item);

  /// <summary>Return how a food item tastes (string enum value)</summary>
  public string GetFoodTaste(FoodItem food);

  /// <summary>Return how a food item tastes (short localized description) </summary>
  public string GetTastePrefStringShort(FoodItem food);

  /// <summary>Return how a food item tastes (detailed localized description) </summary>
  public string GetTastePrefStringDetailed(FoodItem food);
}
