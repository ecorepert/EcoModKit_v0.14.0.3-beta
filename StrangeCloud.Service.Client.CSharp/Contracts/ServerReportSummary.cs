// Decompiled with JetBrains decompiler
// Type: StrangeCloud.Service.Client.Contracts.ServerReportSummary
// Assembly: StrangeCloud.Service.Client.CSharp, Version=1.0.25.0, Culture=neutral, PublicKeyToken=null
// MVID: AAA52893-526A-4E25-B2C8-518262E68155
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\StrangeCloud.Service.Client.CSharp.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\StrangeCloud.Service.Client.CSharp.xml

using Newtonsoft.Json;
using System.CodeDom.Compiler;

#nullable disable
namespace StrangeCloud.Service.Client.Contracts;

[GeneratedCode("NJsonSchema", "14.0.8.0 (NJsonSchema v11.0.1.0 (Newtonsoft.Json v13.0.0.0))")]
public class ServerReportSummary
{
  [JsonProperty("serverName")]
  public string ServerName { get; set; }

  [JsonProperty("ownerName")]
  public string OwnerName { get; set; }

  [JsonProperty("userFlags")]
  public int UserFlags { get; set; }

  [JsonProperty("serverWatchdogFlags")]
  public int ServerWatchdogFlags { get; set; }

  [JsonProperty("clientWatchdogFlags")]
  public int ClientWatchdogFlags { get; set; }

  [JsonProperty("textReports")]
  public string TextReports { get; set; }

  public string ToJson()
  {
    return JsonConvert.SerializeObject((object) this, NSwagConfig.CreateCustomJsonSerializerSettings(new JsonSerializerSettings()));
  }

  public static ServerReportSummary FromJson(string data)
  {
    return JsonConvert.DeserializeObject<ServerReportSummary>(data, NSwagConfig.CreateCustomJsonSerializerSettings(new JsonSerializerSettings()));
  }
}
