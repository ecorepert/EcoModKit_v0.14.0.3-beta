// Decompiled with JetBrains decompiler
// Type: StrangeCloud.Service.Client.Contracts.MarketplaceTransaction
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

[GeneratedCode("NJsonSchema", "14.0.8.0 (NJsonSchema v11.0.1.0 (Newtonsoft.Json v13.0.0.0))")]
public class MarketplaceTransaction
{
  [JsonProperty("id")]
  public Guid Id { get; set; }

  [JsonProperty("xsollaTransactionId")]
  public int? XsollaTransactionId { get; set; }

  [JsonProperty("xSollaStatus")]
  public string XSollaStatus { get; set; }

  [JsonProperty("marketplaceItemName")]
  public string MarketplaceItemName { get; set; }

  [JsonProperty("displayName")]
  public string DisplayName { get; set; }

  [JsonProperty("steamItemId")]
  public string SteamItemId { get; set; }

  [JsonProperty("steamOrderId")]
  public string SteamOrderId { get; set; }

  [JsonProperty("steamTransactionId")]
  public string SteamTransactionId { get; set; }

  [JsonProperty("purchaser")]
  public Guid Purchaser { get; set; }

  [JsonProperty("targetUser")]
  public Guid? TargetUser { get; set; }

  [JsonProperty("purchaserSteamId")]
  public string PurchaserSteamId { get; set; }

  [JsonProperty("worldPurchasedOn")]
  public Guid? WorldPurchasedOn { get; set; }

  [JsonProperty("worldOwningUser")]
  public Guid? WorldOwningUser { get; set; }

  [JsonProperty("quantity")]
  public int Quantity { get; set; }

  [JsonProperty("spentTotal")]
  public float SpentTotal { get; set; }

  [JsonProperty("slgReceived")]
  public float SlgReceived { get; set; }

  [JsonProperty("worldOwnerReceived")]
  public float WorldOwnerReceived { get; set; }

  [JsonProperty("moddersReceived")]
  public float? ModdersReceived { get; set; }

  [JsonProperty("streamersReceived")]
  public float? StreamersReceived { get; set; }

  [JsonProperty("settlementsReceived")]
  public float? SettlementsReceived { get; set; }

  [JsonProperty("charityReceived")]
  public float? CharityReceived { get; set; }

  [JsonProperty("realMoney")]
  public bool RealMoney { get; set; }

  [JsonProperty("notifications")]
  public Collection<UserTaxNotification> Notifications { get; set; }

  [JsonProperty("transactionType")]
  public TransactionTypeEnum? TransactionType { get; set; }

  [JsonProperty("badTransaction")]
  public bool? BadTransaction { get; set; }

  [JsonProperty("divisionDescription")]
  public string DivisionDescription { get; set; }

  [JsonProperty("memo")]
  public string Memo { get; set; }

  [JsonProperty("completed")]
  public bool Completed { get; set; }

  [JsonProperty("timeCompleted")]
  public DateTime TimeCompleted { get; set; }

  [JsonProperty("divisionDecription")]
  public string DivisionDecription { get; set; }

  public string ToJson()
  {
    return JsonConvert.SerializeObject((object) this, NSwagConfig.CreateCustomJsonSerializerSettings(new JsonSerializerSettings()));
  }

  public static MarketplaceTransaction FromJson(string data)
  {
    return JsonConvert.DeserializeObject<MarketplaceTransaction>(data, NSwagConfig.CreateCustomJsonSerializerSettings(new JsonSerializerSettings()));
  }
}
