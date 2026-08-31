// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.ForSaleData
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Economy;
using Eco.Gameplay.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using PropertyChanged;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Components;

[Serialized]
public sealed class ForSaleData : 
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged,
  IClearOnTrade
{
  [Eco.Shared.Networking.Eco(true)]
  public bool ForSale { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  public float Price { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  public Currency Currency { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  public BankAccount SellersAccount { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [VisibilityParam("HasDurability")]
  [Range(0.0f, 500f)]
  public float MinDurability { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [VisibilityParam("HasIntegrity")]
  [Range(0.0f, 500f)]
  public float MinIntegrity { get; set; }

  [SyncToView(null, true)]
  public bool HasDurability { get; set; }

  [SyncToView(null, true)]
  public bool HasIntegrity { get; set; }

  [LocDescription("If this is set, when the object is purchased the display copy will be replenished immediately with a matching item from a linked inventory.")]
  [Eco.Shared.Networking.Eco(true)]
  public bool RestockFromStorage { get; set; }

  [SyncToView(null, true)]
  [Autogen]
  [UITypeName("StringDisplay")]
  public string Note { get; set; }

  public void CopyFrom(ForSaleData other);

  [DoNotNotify]
  public ref int ControllerID { get; }

  public event PropertyChangedEventHandler PropertyChanged;
}
