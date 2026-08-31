// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.CreditItemData
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.PropertyHandling;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Economy;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Components;

[Serialized]
public class CreditItemData : 
  IController,
  IViewController,
  IHasUniversalID,
  IClearOnTrade,
  INotifyPropertyChanged,
  IThreadSafeSubscriptions,
  ISubscriptions<ThreadSafeSubscriptions>,
  ISubscriptions,
  IClearRequestHandler,
  IRPCAuthChecks
{
  internal 
  #nullable disable
  Func<IWorldObserver, bool> AuthCheck;
  /// <summary>Raised when balance for <see cref="P:Eco.Gameplay.Components.CreditItemData.Currency" /> changes in <see cref="P:Eco.Gameplay.Components.CreditItemData.BankAccount" /></summary>
  public readonly ThreadSafeAction SelectedBankAccountBalanceChangedEvent;

  public bool IsRPCAuthorized(IWorldObserver observer, AccessType requiredAccess, object[] args);

  [Notify]
  public static ThreadSafeAction<CreditItemData> SelectedBankAccountRenamedEvent { get; }

  [Serialized]
  [SyncToView(null, true)]
  [AutoRPC]
  [AllowNullInView]
  public Currency Currency { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  [AutoRPC]
  public float FeePerMinute { get; }

  [Serialized]
  [SyncToView(null, true)]
  [AutoRPC]
  public float FeePerItem { get; }

  [Serialized]
  [SyncToView(null, true)]
  [AutoRPC]
  [WatchSubMember("BalanceChanged", "OnBankAccountBalanceChanged", SubPropWatcherFlag.None)]
  [WatchSubMember("OnValidityChanged", "OnBankAccountValidityChanged", SubPropWatcherFlag.None)]
  [WatchSubMember("Name", "RaiseBankAccountRenamedEvent", SubPropWatcherFlag.None)]
  public BankAccount BankAccount { get; set; }

  public ref int ControllerID { get; }

  public event PropertyChangedEventHandler PropertyChanged;

  public ref ThreadSafeSubscriptions Subscriptions { get; }

  public bool HasDataThatCanBeCleared { get; }

  public Result TryHandleClearRequest(Player player);

  /// <summary>Copies data from another instance, keeping the setters encapsulated.</summary>
  public void CopyFrom(CreditItemData source);
}
