// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.Jobs.RecurringTransferServiceExtensions
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Economy.Jobs;

public static class RecurringTransferServiceExtensions
{
  public static void RegisterWages(this IRecurringTransferService group);

  public static void DeregisterWages(this IRecurringTransferService group);

  public static string DescribeRecurringChargeDefinitions(this IRecurringTransferService service);

  public static string DescribeCurrentRecurringCharges(this IRecurringTransferService service);

  internal static HashSet<TCustomer> LeavingCustomers<TCustomer>(
    IEnumerable<(TCustomer Customer, bool Active)> transfers,
    IReadOnlySet<TCustomer> members,
    bool validDefinition);

  internal static List<TCustomer> NewCustomers<TCustomer>(
    IEnumerable<TCustomer> members,
    IReadOnlySet<TCustomer> existingTransferCustomers);

  public static LocString Describe(this IEnumerable<RecurringTransfer> list, bool showEmpty);

  public static LocString MakeTransferForUser(
    this IRecurringTransferService transferService,
    User user,
    BankAccount userBankAccount,
    bool notify);

  public static void TryPayAll(this IRecurringTransferService transferService, bool force = false);

  public static void UpdateTransfers(this IRecurringTransferService service);

  /// <summary>We sent a private message to the user that didn't receive the transfer.</summary>
  public static void UnpaidWages(
    this IRecurringTransferService service,
    User user,
    LocString result);

  public static Result ValidRecurringTransfer(
    this IRecurringTransferService service,
    LocString name);

  public static (float Rent, Currency RentCurrency) GetRecurringTransferForCustomer(
    this IRecurringTransferService service,
    User user);

  public static bool HasValidRecurringTransfer(this IRecurringTransferService service);
}
