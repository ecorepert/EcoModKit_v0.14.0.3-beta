// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Players.UserConfig
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Plugins;
using Eco.Core.Serialization;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Newtonsoft.Json.Linq;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Players;

[Localized(true, false, "", false)]
public class UserConfig : 
  IMigratableConfig,
  IVersionedConfig,
  IValidatableConfig,
  INotifyPropertyChanged
{
  public readonly bool UseWaste;

  /// <summary>Migration for the UserConfig from v.0 to v.1. We are using JObject for changes so we need to read, change and populate it once.</summary>
  public void Migrate(JObject json);

  public event PropertyChangedEventHandler PropertyChanged;

  [Browsable(false)]
  [IgnoreHostedWorlds]
  public int LastConfigVersion { get; }

  [Browsable(false)]
  [IgnoreHostedWorlds]
  public int ConfigVersion { get; set; }

  public bool RequireAuthentication { get; }

  [IgnoreHostedWorlds]
  [LocDescription("API authentication key which may be used to access Web UI without a game user. May be used for external communication or by automation tools. Keep this setting a secret has it can be used to perform dangerous actions!")]
  [DontSerializeIntoTemplate]
  public string APIAuthToken { get; set; }

  [IgnoreHostedWorlds]
  [LocDescription("API admin authentication key which may be used to access Web UI without a game user as an admin user. May be used for external communication or by automation tools. Keep this setting a secret has it can be used to perform dangerous actions!")]
  [DontSerializeIntoTemplate]
  public string APIAdminAuthToken { get; set; }

  [IgnoreHostedWorlds]
  [LocDescription("Allows debug calls to be made to the webserver, like 'GenerateTestData'.")]
  public bool AllowDebugCalls { get; set; }

  [LocDescription("Delay to prevent /unstuck abuse.")]
  public double UnStuckDisableTime { get; set; }

  [LocDescription("Delay to prevent /freecar abuse. Same logic as UnStuckDisableTime.")]
  public double FreecarDisableTime { get; set; }

  [LocDescription("Logging level for admin commands executed: None - no logging; Log File - logged in a file; Log File And Notify Admins - logged in a file and admins see a message in the chat; Log File And Notify Everyone - logged in a file and everyone see a message in the chat")]
  public AdminCommandsLoggingLevels AdminCommandsLoggingLevel { get; set; }

  [LocDescription("Delay in minutes for the next searching nearby food location and moving spawn point")]
  public float DelayNearbyFoodCheckMinutes { get; set; }

  [LocDescription("When choosing a spawn point with nearby food, how far away can the food be?")]
  public float NearbyFoodSpawnLocationRadius { get; set; }

  [LocDescription("When choosing a spawn point, this much food be nearby.")]
  public int NearbyFoodSpawnCount { get; set; }

  [LocDescription("When true, spawn point stays as set below. When false, the spawn point will move periodically to be close to wild food.")]
  public bool UseExactSpawnLocation { get; set; }

  [LocDescription("The current spawn location.")]
  public Vector3i SpawnLocation { get; set; }

  [LocDescription("Spawn point search range when no exact locatiion is given.")]
  public int SpawnSearchRange { get; set; }

  [LocDescription("When enabled users who likely cheat movement will be identified and kicked from server (beta - may identify non-cheating users as cheaters and disconnect)")]
  public bool MovementHackDetection { get; set; }

  [LocDescription("Percent of Server Occupancy Required Before Enforcing Inactivity Kicking (0 - 100). Use zero if you want that the server disconnects players based only on the inactivity time. (Default Slots have to be set).")]
  public float RequiredOccupancyBeforeAFKKick { get; set; }

  [LocDescription("Minutes of inactivity before kicking player. Use zero if you don't want your server to implement the AFK system.")]
  public float TimeRequiredForAFKMinutes { get; set; }

  [LocDescription("Hide the player position in the tooltip.")]
  public bool HidePlayerPositionInTooltip { get; set; }

  [LocDescription("Hide the player icon in minimap.")]
  public bool HidePlayerIconInMinimap { get; set; }

  public UserPermissionManager UserPermission { get; set; }
}
