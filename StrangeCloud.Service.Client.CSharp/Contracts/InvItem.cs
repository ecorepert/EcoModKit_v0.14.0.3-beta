// Decompiled with JetBrains decompiler
// Type: StrangeCloud.Service.Client.Contracts.InvItem
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
public class InvItem
{
  [JsonProperty("type")]
  public string Type { get; set; }

  [JsonProperty("amount")]
  public int Amount { get; set; }

  [JsonProperty("serverBoughtOn")]
  public Guid ServerBoughtOn { get; set; }

  [JsonProperty("owningUserOfServerBoughtOn")]
  public Guid OwningUserOfServerBoughtOn { get; set; }

  public string ToJson()
  {
    return JsonConvert.SerializeObject((object) this, NSwagConfig.CreateCustomJsonSerializerSettings(new JsonSerializerSettings()));
  }

  public static InvItem FromJson(string data)
  {
    return JsonConvert.DeserializeObject<InvItem>(data, NSwagConfig.CreateCustomJsonSerializerSettings(new JsonSerializerSettings()));
  }
}
