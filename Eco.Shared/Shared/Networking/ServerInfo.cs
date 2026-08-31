// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Networking.ServerInfo
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Services;
using Eco.Shared.States;
using System.Collections.Generic;

#nullable disable
namespace Eco.Shared.Networking;

/// <summary>Stores extended information about a world. Stored as a json string inside the strange world cloud data.</summary>
public class ServerInfo
{
  /// <value>Set                    by master server if this server is available directly by external IP address</value>
  public bool External { get; set; }

  public int WebPort { get; set; }

  public bool IsLAN { get; set; }

  public string Description { get; set; }

  public string DetailedDescription { get; set; }

  public ServerCategory Category { get; set; }

  public int OnlinePlayers { get; set; }

  public int TotalPlayers { get; set; }

  public string[] OnlinePlayersNames { get; set; }

  public bool AdminOnline { get; set; }

  public int DaysRunning { get; set; }

  public int DaysUntilMeteor { get; set; }

  public int Animals { get; set; }

  public int Plants { get; set; }

  public int Laws { get; set; }

  public string WorldSize { get; set; }

  public string Version { get; set; }

  public string EconomyDesc { get; set; }

  public string SkillSpecialization { get; set; }

  public string Language { get; set; }

  public bool HasPassword { get; set; }

  public bool HasMeteor { get; set; }

  public string DistributionStationItems { get; set; }

  public string Playtimes { get; set; }

  public string DiscordAddress { get; set; }

  public bool IsPaused { get; set; }

  public int ActiveAndOnlinePlayers { get; set; }

  public int PeakActivePlayers { get; set; }

  public float ShelfLifeMultiplier { get; set; }

  public float ExhaustionAfterHours { get; set; }

  public bool ExhaustionActive { get; set; }

  public bool ExhaustionAllowPlaytimeSaving { get; set; }

  public float ExhaustionMaxSavedHours { get; set; }

  public float ExhaustionBonusHoursOnExhaustionEnabled { get; set; }

  public bool ExhaustionBonusRetroactiveHoursAfterStart { get; set; }

  public Dictionary<int, float> ExhaustionHoursGainPerWeekday { get; set; }

  public Dictionary<string, string> ServerAchievementsDict { get; set; }

  public CollaborationLevel CollaborationLevel { get; set; }

  public GameSpeed GameSpeed { get; set; }

  public SimulationLevel SimulationLevel { get; set; }

  public float TotalCulture { get; set; }

  public bool PremiumItemUseRestrictions { get; set; }

  public bool PremiumItemsBlocked { get; set; }

  /// <value>
  /// Optional relay address, may be set by server to inform clients how to connect to this server if connect in usual way (direct/NAT Punch Through) doesn't work.
  /// </value>
  public string RelayAddress { get; set; }

  /// <summary> Access mode of server: "public", "hidden", or "private". </summary>
  public string Access { get; set; }
}
