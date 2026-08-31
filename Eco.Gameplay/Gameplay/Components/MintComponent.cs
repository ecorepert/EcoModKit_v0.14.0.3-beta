// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.MintComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Utils;
using Eco.Gameplay.Components.Storage;
using Eco.Gameplay.Economy;
using Eco.Gameplay.Items;
using Eco.Gameplay.Items.PersistentData;
using Eco.Gameplay.Items.SearchAndSelect;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using PropertyChanged;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Components;

[Serialized]
[Priority(0)]
[LocDescription("Create and mint new coins for currencies.")]
[RequireComponent(typeof (LinkComponent), null)]
[RequireComponent(typeof (InOutLinkedInventoriesComponent), null)]
[RequireComponent(typeof (NameDataTrackerComponent), null)]
[RequireComponent(typeof (AuthDataTrackerComponent), null)]
[HasIcon(null)]
[Tag("Economy")]
[Ecopedia(null, null, false, true, null)]
public class MintComponent : WorldObjectComponent, IPersistentData, INotifyPropertyChanged
{
  public static List<MintComponent> AllMints;
  public static ThreadSafeAction<User, Currency> CurrencyCreatedEvent;

  [DoNotNotify]
  public override WorldObjectComponentClientAvailability Availability { get; }

  [Serialized]
  [SyncToView(null, true)]
  [DoNotNotify]
  public SearchAndSelectItem SelectedItem { get; }

  [DoNotNotify]
  public ItemStack Stack { get; }

  [SyncToView(null, true)]
  [DoNotNotify]
  public string CurrencyName { get; }

  [SyncToView(null, true)]
  [DoNotNotify]
  public float TotalCirculation { get; }

  [SyncToView(null, true)]
  [DoNotNotify]
  public float CoinsPerItem { get; }

  [SyncToView(null, true)]
  [Eco.Shared.Networking.Eco(true)]
  public BankAccount TargetAccount { get; set; }

  [SyncToView(null, true)]
  [Serialized]
  [NewTooltipChildren(CacheAs.Instance)]
  public MintItemData MintData { get; set; }

  [DoNotNotify]
  public object PersistentData { get; set; }

  public override void OnCreate();

  public override void Initialize();

  public void InitializeCurrency(Currency currencyHandle);

  public override void Destroy();

  [RPC]
  public void CurrencyReport(Player player);

  [RPC]
  public bool SetCurrencyName(Player player, string currencyName);

  [RPC]
  public bool CreateCurrency(Player player, string currencyName);

  public Result SetCurrencyNameNoCheck(User user, LocString currencyName);

  public Result CraftCoinsResult(
    Player player,
    int itemQuantity,
    float coinsPerItem,
    BankAccount account);

  public void UpdateCirculation(Currency changedCurrency);

  [RPC]
  public bool CraftCoins(Player player, int itemQuantity, float coinsPerItem, BankAccount account);
}
