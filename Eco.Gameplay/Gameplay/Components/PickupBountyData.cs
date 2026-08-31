// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.PickupBountyData
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Economy;
using Eco.Gameplay.Items;
using Eco.Shared.Items;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using PropertyChanged;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Components;

/// <summary>Persisted bounty settings. Owner-bound, so it's dropped when the object is traded — the buyer configures their own account.
/// Members are view-only: the component exposes the FullAccess-gated setters, a client has no business writing here directly.</summary>
[Serialized]
public sealed class PickupBountyData : 
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged,
  IClearOnTrade
{
  [Serialized]
  [SyncToView(null, true)]
  public bool CollectionEnabled { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public PickupBountyDirection PaymentDirection { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public float DefaultPricePerItem { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public ControllerList<PricedItem> PricedItems { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public Currency Currency { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public BankAccount BankAccount { get; set; }

  [DoNotNotify]
  public ref int ControllerID { get; }

  public event PropertyChangedEventHandler PropertyChanged;
}
