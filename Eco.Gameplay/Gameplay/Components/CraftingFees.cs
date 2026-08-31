// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.CraftingFees
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Economy;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Shared.Serialization;

#nullable enable
namespace Eco.Gameplay.Components;

/// <summary>
/// This class allows to calculate, pay and store escrowed payments withing craft/repair.
/// Tables which has CreditComponent could set fee for using that table. This class will operate with payments allowing to retrieve back paid money for canceled work orders.
/// Stores fee data on the moment work order was created. So further changes to fee/currency would not affect stored payment.
/// When payment is requested, money are transfered to Escrow account saving all needed transfer info within serialized fields.
/// When using escrow account is not needed (repair or craft single item) transfer is performed instantly.
/// </summary>
[Serialized]
public class CraftingFees
{
  /// <summary>Pay repair fees instantly.</summary>
  public static void PayRepairFees(
    GameActionPack pack,
    User user,
    WorldObject obj,
    BankAccount account,
    Item item);

  /// <summary> Try to pay crafting fees for work order. If multiple orders queued payment transfered to escrow account and owner will receive payment per finished order. On work order cancel tries to refund. Otherwise returns null.</summary>
  public static CraftingFees? PayCraftingFees(
    GameActionPack pack,
    User user,
    WorldObject worldObject,
    float timePerItem,
    int quantity,
    BankAccount account,
    WorkOrder workOrder);

  public void Initialize(WorldObject worldObject, WorkOrder workOrder);

  /// <summary>Pay stored crafting fee per 1 unit. If table becomes public or free - refund all stored money.</summary>
  public void PayCraftingFee();

  /// <summary>Refund remaining fees if any left in escrow bank account.</summary>
  public void RefundCraftingFee();
}
