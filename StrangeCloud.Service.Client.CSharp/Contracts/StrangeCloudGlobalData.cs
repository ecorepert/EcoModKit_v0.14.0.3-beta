// Decompiled with JetBrains decompiler
// Type: StrangeCloud.Service.Client.Contracts.StrangeCloudGlobalData
// Assembly: StrangeCloud.Service.Client.CSharp, Version=1.0.25.0, Culture=neutral, PublicKeyToken=null
// MVID: AAA52893-526A-4E25-B2C8-518262E68155
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\StrangeCloud.Service.Client.CSharp.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\StrangeCloud.Service.Client.CSharp.xml

using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;

#nullable disable
namespace StrangeCloud.Service.Client.Contracts;

[GeneratedCode("NJsonSchema", "14.0.8.0 (NJsonSchema v11.0.1.0 (Newtonsoft.Json v13.0.0.0))")]
public class StrangeCloudGlobalData
{
  [JsonProperty("id")]
  public Guid Id { get; set; }

  [JsonProperty("percentCutForMods")]
  public float PercentCutForMods { get; set; }

  [JsonProperty("percentCutForStreamers")]
  public float PercentCutForStreamers { get; set; }

  [JsonProperty("percentCutForHosts")]
  public float PercentCutForHosts { get; set; }

  [JsonProperty("percentCutForCharity")]
  public float PercentCutForCharity { get; set; }

  [JsonProperty("percentCutForTownMates")]
  public float PercentCutForTownMates { get; set; }

  [JsonProperty("percentCutForCountryMates")]
  public float PercentCutForCountryMates { get; set; }

  [JsonProperty("maxPercentForSettlements")]
  public float MaxPercentForSettlements { get; set; }

  [JsonProperty("transferTax")]
  public float TransferTax { get; set; }

  [JsonProperty("minViewersToGetStreamerCut")]
  public int MinViewersToGetStreamerCut { get; set; }

  public string ToJson()
  {
    return JsonConvert.SerializeObject((object) this, NSwagConfig.CreateCustomJsonSerializerSettings(new JsonSerializerSettings()));
  }

  public static StrangeCloudGlobalData FromJson(string data)
  {
    return JsonConvert.DeserializeObject<StrangeCloudGlobalData>(data, NSwagConfig.CreateCustomJsonSerializerSettings(new JsonSerializerSettings()));
  }
}
