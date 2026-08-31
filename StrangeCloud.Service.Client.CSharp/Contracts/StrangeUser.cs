// Decompiled with JetBrains decompiler
// Type: StrangeCloud.Service.Client.Contracts.StrangeUser
// Assembly: StrangeCloud.Service.Client.CSharp, Version=1.0.25.0, Culture=neutral, PublicKeyToken=null
// MVID: AAA52893-526A-4E25-B2C8-518262E68155
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\StrangeCloud.Service.Client.CSharp.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\StrangeCloud.Service.Client.CSharp.xml

using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;

#nullable disable
namespace StrangeCloud.Service.Client.Contracts;

/// <summary>A user stored in the StrangeCloud.</summary>
[GeneratedCode("NJsonSchema", "14.0.8.0 (NJsonSchema v11.0.1.0 (Newtonsoft.Json v13.0.0.0))")]
public class StrangeUser
{
  [JsonProperty("isDeveloper")]
  public bool? IsDeveloper { get; set; }

  [JsonProperty("id")]
  public Guid Id { get; set; }

  [JsonProperty("steamId")]
  public string SteamId { get; set; }

  [JsonProperty("twitchId")]
  public string TwitchId { get; set; }

  [JsonProperty("twitchUsername")]
  public string TwitchUsername { get; set; }

  [JsonProperty("username")]
  public string Username { get; set; }

  [JsonProperty("latestSteamUsername")]
  public string LatestSteamUsername { get; set; }

  [JsonProperty("avatarUrl")]
  public string AvatarUrl { get; set; }

  [JsonProperty("avatarDna")]
  public string AvatarDna { get; set; }

  [JsonProperty("achievements")]
  public Collection<StrangeAchievement> Achievements { get; set; }

  [JsonProperty("twitchEntitlements")]
  public Collection<string> TwitchEntitlements { get; set; }

  [JsonProperty("ecoCredits")]
  public float? EcoCredits { get; set; }

  [JsonProperty("ownsEco")]
  public bool OwnsEco { get; set; }

  [JsonProperty("invitedByUser")]
  public Guid? InvitedByUser { get; set; }

  [JsonProperty("tierId")]
  public int? TierId { get; set; }

  [JsonProperty("verified")]
  public bool? Verified { get; set; }

  [JsonProperty("items")]
  public Collection<InvItem> Items { get; set; }

  [JsonProperty("blockPurchasing")]
  public bool? BlockPurchasing { get; set; }

  [JsonProperty("availableIcons")]
  public string AvailableIcons { get; set; }

  [JsonProperty("selectedIcon")]
  public string SelectedIcon { get; set; }

  [JsonProperty("isDevTier")]
  public bool? IsDevTier { get; set; }

  [JsonProperty("isWolfWhisperer")]
  public bool? IsWolfWhisperer { get; set; }

  [JsonProperty("isSLG")]
  public bool? IsSLG { get; set; }

  [JsonProperty("isKickstarter")]
  public bool? IsKickstarter { get; set; }

  [JsonProperty("isAlphaBaker")]
  public bool? IsAlphaBaker { get; set; }

  [JsonProperty("isPartner")]
  public bool? IsPartner { get; set; }

  [JsonProperty("isVolunteer")]
  public bool? IsVolunteer { get; set; }

  [JsonProperty("isCloudAdmin")]
  public bool IsCloudAdmin { get; set; }

  [JsonProperty("bannedUntil")]
  public DateTime? BannedUntil { get; set; }

  [JsonProperty("bannedReason")]
  public string BannedReason { get; set; }

  [JsonProperty("isBanned")]
  public bool IsBanned { get; set; }

  [JsonProperty("totalReceivedInTax")]
  public float? TotalReceivedInTax { get; set; }

  [JsonProperty("currentWorldID")]
  public Guid? CurrentWorldID { get; set; }

  [JsonProperty("lastWorldJoinTime")]
  public DateTime? LastWorldJoinTime { get; set; }

  [JsonProperty("heartBeatTime")]
  public DateTime? HeartBeatTime { get; set; }

  [JsonProperty("creationTime")]
  public DateTime CreationTime { get; set; }

  [JsonProperty("online")]
  public bool Online { get; set; }

  [JsonProperty("timeOnlineTotal")]
  public TimeSpan? TimeOnlineTotal { get; set; }

  [JsonProperty("totalOnlineHostingTime")]
  public TimeSpan? TotalOnlineHostingTime { get; set; }

  [JsonProperty("notifications")]
  public Collection<UserNotification> Notifications { get; set; }

  /// <summary>
  /// Sum of all time played on all servers hosted by this user.
  /// </summary>
  [JsonProperty("sumHostedUsersTime")]
  public TimeSpan? SumHostedUsersTime { get; set; }

  [JsonProperty("lastEmailSent")]
  public DateTime? LastEmailSent { get; set; }

  [JsonProperty("oldId")]
  public int? OldId { get; set; }

  [JsonProperty("github")]
  public string Github { get; set; }

  [JsonProperty("isAccountSetup")]
  public bool? IsAccountSetup { get; set; }

  public string ToJson()
  {
    return JsonConvert.SerializeObject((object) this, NSwagConfig.CreateCustomJsonSerializerSettings(new JsonSerializerSettings()));
  }

  public static StrangeUser FromJson(string data)
  {
    return JsonConvert.DeserializeObject<StrangeUser>(data, NSwagConfig.CreateCustomJsonSerializerSettings(new JsonSerializerSettings()));
  }
}
