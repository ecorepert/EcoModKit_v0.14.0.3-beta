// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Services.GameSettings
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Items;
using Eco.Shared.Localization;
using System;
using System.ComponentModel;

#nullable disable
namespace Eco.Shared.Services;

[TypeConverter(typeof (ExpandableObjectConverter))]
[LocDescription("Defines what type of game should be run. These settings are used to generate Difficulty Modifiers.")]
[Serializable]
public class GameSettings
{
  public int DesiredNumberOfPlayers { get; set; }

  /// <summary>Set to '0' to mean 'unlimited'</summary>
  public float HoursPlayedPerDay { get; set; }

  public CollaborationLevel CollaborationLevel { get; set; }

  public GameSpeed GameSpeed { get; set; }

  [LocDescription("Determines animal attack pattern. Set to none to completely disable aggressiveness.")]
  public AnimalAttackPattern AnimalBehavior { get; set; }

  public SimulationLevel SimulationLevel { get; set; }

  public bool ExhaustionEnabled { get; set; }

  public bool HasMeteor { get; set; }

  public bool AllowFriendsToJoin { get; set; }

  public bool GenerateRandomWorld { get; set; }

  [LocDescription("Advanced settings that are changed whenever the other settings above are changed.")]
  public AdvancedGameSettings AdvancedGameSettings { get; set; }
}
