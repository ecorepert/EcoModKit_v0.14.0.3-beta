// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.DeedSalesComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Gameplay.Economy;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Property;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Shared.Items;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Components;

[Serialized]
[RequireComponent(typeof (DeedManagementComponent), null)]
[HasIcon(null)]
[Ecopedia(null, null, false, true, null)]
public class DeedSalesComponent : WorldObjectComponent, INotifyPropertyChanged, IPersistentData
{
  public override WorldObjectComponentClientAvailability Availability { get; }

  [Serialized]
  [SyncToView(null, true)]
  [NewTooltipChildren(CacheAs.Instance)]
  public DeedSalesItemData DeedSalesData { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  [AutoRPC]
  public Currency DefaultCurrency { get; set; }

  public object PersistentData { get; set; }

  public override void Initialize();

  public void UpdateName();

  public override void Destroy();

  [RPC]
  public void AddListing(
    Player seller,
    Deed deed,
    BankAccount account,
    Currency currency,
    float price);

  [RPC]
  public void DeleteListing(Player seller, DeedSaleListing listing);

  [RPC]
  public void Buy(Player buyer, DeedSaleListing listing, BankAccount buyerAccount);
}
