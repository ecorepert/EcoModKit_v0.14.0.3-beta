// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Housing.PropertyValues.HousingConfig
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Housing.PropertyValues;

/// <summary>Values related to the housing system, set via mods.</summary>
public static class HousingConfig
{
  public static 
  #nullable disable
  Func<int, float> OccupancyMultiplierGenerator;
  public static Func<int, LocString> OccupancyMultiplierGeneratorDescriptior;
  public static RoomCategory Uncategorized;

  public static void SetRoomTiers(RoomTier[] tiers);

  public static RoomTier GetRoomTier(int tier);

  /// <summary>Initialize the room categories used by the housing system.</summary>
  public static void SetRoomCategories(IEnumerable<RoomCategory> categories);

  public static RoomCategory GetRoomCategory(string name);

  public static IEnumerable<RoomCategory> AllCategories { get; }
}
