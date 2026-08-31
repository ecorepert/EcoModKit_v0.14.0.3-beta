// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Players.Stomach
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players.Food;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Players;

[Serialized]
public class Stomach : IController, IViewController, IHasUniversalID, INotifyPropertyChanged
{
  /// <summary>Passes the user, the eaten food and the table it was eaten from it if exists.</summary>
  public static ThreadSafeAction<User, FoodItem, WorldObject> GlobalFoodEatenEvent;
  public static ThreadSafeAction<User, Type> FoodContentUpdatedEvent;
  public static ThreadSafeAction<Stomach> CaloriesChangedEvent;
  public static ThreadSafeAction<Stomach> WasteChangedEvent;
  public static ThreadSafeAction<Stomach> MaxCaloriesChangedEvent;
  public static ThreadSafeAction<User, FoodItem> PlayerCravingSatifiedEvent;
  public ThreadSafeAction ChangedEvent;
  public ThreadSafeAction NoCaloriesEvent;
  /// <summary>Passes the eaten food and the table it was eaten from it if exists.</summary>
  public ThreadSafeAction<FoodItem, WorldObject> FoodEatenEvent;
  [Serialized]
  public ThreadSafeList<StomachEntry> Contents;
  public User Owner;
  public float CalorieMult;
  public static ThreadSafeAction<User, FoodItem> CravingSatisfiedEvent;
  public static readonly string NutritionMultiplierDisplayName;

  [Serialized]
  public TasteBuds TasteBuds { get; }

  [Serialized]
  public Cravings Cravings { get; }

  public bool Initialized { get; }

  [Serialized]
  public float Waste { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public float Calories { get; }

  [SyncToView(null, true)]
  [DependsOn("Waste")]
  public float WastePercent { get; }

  [SyncToView(null, true)]
  public bool UseWaste { get; }

  /// <summary>Taste preferences discovered by eating, keyed by food item type id. Lets the client mark food icons by tastiness.</summary>
  [SyncToView(null, true)]
  public Dictionary<int, int> DiscoveredTastes { get; }

  public LocString FullStomachMsg { get; }

  public void ChangedMaxCalories();

  [SyncToView(null, true)]
  public float MaxCalories { get; }

  public float CalorieRate { get; }

  /// <summary>The nutrients in our belly.</summary>
  [Notify]
  public Nutrients Nutrients { get; }

  [Notify]
  public float BalancedDietMult { get; }

  [Notify]
  public float VarietyMult { get; }

  [Notify]
  public float TastinessMult { get; }

  [Notify]
  public float CravingMult { get; }

  [Notify]
  public float DinnerPartyMult { get; }

  [Notify]
  public string CravingMultDesc { get; }

  [SyncToView(null, true)]
  public Type Craving { get; }

  [SyncToView("Nutrients", true)]
  [DependsOn("Nutrients")]
  protected float[] NutrientsView { get; }

  [SyncToView(null, true)]
  public float NutrientSkillRate();

  public void Initialize(User owner);

  [RPC]
  public TooltipSection BalancedDietMultDescRPC();

  [RPC]
  public TooltipSection VarietyMultDescRPC();

  [RPC]
  public TooltipSection TastinessMultDescRPC();

  public bool CanEat(FoodItem food);

  public bool Eat(FoodItem food, out string message, bool force = false, WorldObject table = null);

  /// <summary> Get food reaction for eating </summary>
  public string GetTaste(FoodItem food);

  public void CheckForBowelMovementAndExcreteFeces(User user);

  /// <summary> Burns the specified amount of calories from the stomach. </summary>
  /// <remarks> Some waste management happens internally if waste is enabled in the config. </remarks>
  public bool BurnCalories(float change, bool useCalorieModifier);

  public void ForceSetCalories(float cal);

  public void ForceSetNutrients(Nutrients nutrients);

  public void RecalcAverageNutrients();

  public bool IsAnyCalories();

  public void ClearCalories(Player player);

  public void Tick();

  [RPC]
  public TooltipSection DinnerPartyBonus();

  public ref int ControllerID { get; }

  public event PropertyChangedEventHandler PropertyChanged;
}
