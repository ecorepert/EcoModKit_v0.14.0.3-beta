// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.NewTooltip.TooltipLibraryFiles.EconomyTooltipLibrary
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.PropertyHandling;
using Eco.Gameplay.Components;
using Eco.Gameplay.Components.Store;
using Eco.Gameplay.Components.Store.Internal;
using Eco.Gameplay.Economy;
using Eco.Gameplay.Economy.Contracts;
using Eco.Gameplay.Economy.Jobs;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Gameplay.Property;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using System;

#nullable disable
namespace Eco.Gameplay.Systems.NewTooltip.TooltipLibraryFiles;

/// <summary>Tooltips related to the economy. This class both sets up the needed subdscription that will 'dirty' the tooltip as needed, and defines the actual tooltip parts related to it.</summary>
[TooltipLibrary]
public static class EconomyTooltipLibrary
{
  public static void Initialize();

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Disabled, 160 /*0xA0*/, TTCat.Default, TTFlags.None, typeof (Item), new Type[] {})]
  public static LocString BuyItTooltip(Type type, User user, TooltipOrigin origin);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Disabled, 165, TTCat.Default, TTFlags.None, typeof (Item), new Type[] {})]
  public static LocString SellItTooltip(Type type, User user, TooltipOrigin origin);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Disabled, 160 /*0xA0*/, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString BuyItTooltipPaintBucket(
    this ColorItem colorItem,
    User user,
    TooltipOrigin origin);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Disabled, 165, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString SellItTooltipPaintBucket(
    this ColorItem colorItem,
    User user,
    TooltipOrigin origin);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Disabled, 140, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString BuyTagTooltip(this Tag tag, User user, TooltipOrigin origin);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Disabled, 145, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString SellTagTooltip(this Tag tag, User user, TooltipOrigin origin);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 120, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString TooltipRecurringCharges(this IRecurringTransferService service);

  [TooltipAffectedBy("CurrencyName", null, null)]
  [TooltipAffectedBy("Balance", null, null)]
  [TooltipAffectedBy("IsBarter", null, null)]
  [TooltipAffectedBy("BankAccountChangedEvent", null, null)]
  [TooltipAffectedBy("BalanceChangedEvent", null, null)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 145, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString StoreBalanceTooltip(this StoreComponent store);

  [TooltipAffectedBy("Currency", null, null)]
  [TooltipAffectedBy("SellOffersChangedEvent", null, null)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 147, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString StoreStockValueTooltip(this StoreItemData store);

  [TooltipAffectedBy("Currency", null, null)]
  [TooltipAffectedBy("SellOffersChangedEvent", null, null)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 150, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString StoreSellingTooltip(this StoreItemData store, TooltipOrigin origin);

  [TooltipAffectedBy("Currency", null, null)]
  [TooltipAffectedBy("BuyOffersChangedEvent", null, null)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 155, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString StoreBuyingTooltip(this StoreItemData store, TooltipOrigin origin);

  [TooltipAffectedBy("Name", null, null)]
  [NewTooltipTitle(CacheAs.Instance, 0, TTCat.Default, TTFlags.None, null, "")]
  public static LocString DeedSellingTooltipTitle(this DeedSalesItemData deedSales);

  [TooltipAffectedBy("ListingsChangedEvent", null, null)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 150, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString DeedSellingTooltip(this DeedSalesItemData deedSales, TooltipOrigin origin);

  [TooltipAffectedBy(typeof (DualPermissions), "ManagerSetChangedEvent", null, null)]
  [TooltipAffectedBy(typeof (DualPermissions), "UserSetChangedEvent", null, null)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 105, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString DualPermissionsTooltip(this DualPermissions dual);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Disabled, 110, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString ContractDescription(this Contract contract);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Disabled, 120, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString Tooltip(this RentForProperty rentForProperty);
}
