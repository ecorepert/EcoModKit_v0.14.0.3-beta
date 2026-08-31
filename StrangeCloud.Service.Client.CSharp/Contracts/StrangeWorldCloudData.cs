// Decompiled with JetBrains decompiler
// Type: StrangeCloud.Service.Client.Contracts.StrangeWorldCloudData
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

/// <summary>Info stored about a server in the cloud stroage db</summary>
[GeneratedCode("NJsonSchema", "14.0.8.0 (NJsonSchema v11.0.1.0 (Newtonsoft.Json v13.0.0.0))")]
public class StrangeWorldCloudData
{
  [JsonProperty("id")]
  public Guid Id { get; set; }

  [JsonProperty("name")]
  public string Name { get; set; }

  [JsonProperty("owningUser")]
  public Guid OwningUser { get; set; }

  [JsonProperty("gameServerPort")]
  public int GameServerPort { get; set; }

  [JsonProperty("internalEndPoint")]
  public string InternalEndPoint { get; set; }

  [JsonProperty("remoteEndPoint")]
  public string RemoteEndPoint { get; set; }

  [JsonProperty("isPublic")]
  public bool IsPublic { get; set; }

  [JsonProperty("playerCount")]
  public int PlayerCount { get; set; }

  [JsonProperty("activePlayerCount")]
  public int ActivePlayerCount { get; set; }

  [JsonProperty("serverInfoJson")]
  public string ServerInfoJson { get; set; }

  [JsonProperty("online")]
  public bool Online { get; set; }

  [JsonProperty("adminAppliedScoreBoost")]
  public int? AdminAppliedScoreBoost { get; set; }

  [JsonProperty("isOfficial")]
  public bool? IsOfficial { get; set; }

  [JsonProperty("isEligibleForTax")]
  public bool? IsEligibleForTax { get; set; }

  [JsonProperty("timeOnline")]
  public TimeSpan? TimeOnline { get; set; }

  [JsonProperty("totalUserTime")]
  public TimeSpan? TotalUserTime { get; set; }

  [JsonProperty("totalUserTimeOfOwner")]
  public TimeSpan? TotalUserTimeOfOwner { get; set; }

  [JsonProperty("timeHostingMoreThanOne")]
  public TimeSpan? TimeHostingMoreThanOne { get; set; }

  [JsonProperty("installedModNameList")]
  public Collection<string> InstalledModNameList { get; set; }

  [JsonProperty("passport")]
  public Guid? Passport { get; set; }

  public string ToJson()
  {
    return JsonConvert.SerializeObject((object) this, NSwagConfig.CreateCustomJsonSerializerSettings(new JsonSerializerSettings()));
  }

  public static StrangeWorldCloudData FromJson(string data)
  {
    return JsonConvert.DeserializeObject<StrangeWorldCloudData>(data, NSwagConfig.CreateCustomJsonSerializerSettings(new JsonSerializerSettings()));
  }
}
