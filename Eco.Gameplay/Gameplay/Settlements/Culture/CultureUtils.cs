// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.Culture.CultureUtils
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.Economy.Reputation;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.View;
using System;

#nullable disable
namespace Eco.Gameplay.Settlements.Culture;

public static class CultureUtils
{
  public static LocString Culture { get; }

  public static LocString AsCulture(this float culture);

  public static LocString AsSignedCulture(this float culture);

  public static LocString AsCultureNoLabel(this float culture);

  public static LocString InfluenceRadius { get; }

  public static LocString AsInfluenceRadius(this float influenceRadius);

  public static LocString AsInfluenceRadiusNoLabel(this float influenceRadius);

  public static LocString Reputation { get; }

  public static LocString AsReputation(this float rep);

  public static LocString AsAdjustedReputation(this float rep);

  public static LocString HousingValue { get; }

  public static LocString AsHousingValue(this float housingValue);

  public static LocString AsHousingValueBonus(this float housingValue);

  public static LocString NutritionValue { get; }

  public static LocString AsNutritionValue(this float nutritionValue);

  public static LocString AsNutritionValueBonus(this float nutritionValue);

  public static void InitializeCultureGenerator(
    IHasReputation repTarget,
    ISubscriptions<ThreadSafeSubscriptions> subs,
    User creator,
    LocString workType,
    LocString workTypePosessive,
    Action<Action> subscribeSettlement,
    Func<WorldObject> getWorldObject,
    Func<Settlement> getSettlement,
    Action<ValResult<float>> setCultureFunc);
}
