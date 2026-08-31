// Decompiled with JetBrains decompiler
// Type: StrangeCloud.Service.Client.Contracts.DailySummary
// Assembly: StrangeCloud.Service.Client.CSharp, Version=1.0.25.0, Culture=neutral, PublicKeyToken=null
// MVID: AAA52893-526A-4E25-B2C8-518262E68155
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\StrangeCloud.Service.Client.CSharp.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\StrangeCloud.Service.Client.CSharp.xml

using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;

#nullable disable
namespace StrangeCloud.Service.Client.Contracts;

/// <summary>
/// Stores a summary of the amount of eco credits collected in tax each day on each world.
/// </summary>
[GeneratedCode("NJsonSchema", "14.0.8.0 (NJsonSchema v11.0.1.0 (Newtonsoft.Json v13.0.0.0))")]
public class DailySummary
{
  [JsonProperty("id")]
  public Guid Id { get; set; }

  [JsonProperty("userID")]
  public Guid? UserID { get; set; }

  [JsonProperty("worldID")]
  public Guid? WorldID { get; set; }

  [JsonProperty("date")]
  [JsonConverter(typeof (DateFormatConverter))]
  public DateTime? Date { get; set; }

  [JsonProperty("totalCollected")]
  public float? TotalCollected { get; set; }

  [JsonProperty("summaryType")]
  public StrangeCloud.Service.Client.Contracts.SummaryType? SummaryType { get; set; }

  public string ToJson()
  {
    return JsonConvert.SerializeObject((object) this, NSwagConfig.CreateCustomJsonSerializerSettings(new JsonSerializerSettings()));
  }

  public static DailySummary FromJson(string data)
  {
    return JsonConvert.DeserializeObject<DailySummary>(data, NSwagConfig.CreateCustomJsonSerializerSettings(new JsonSerializerSettings()));
  }
}
