// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.Jobs.RecurringTransferManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Utils;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Economy.Jobs;

public class RecurringTransferManager : Singleton<
#nullable disable
RecurringTransferManager>
{
  public static ThreadSafeAction<IRecurringTransferService> TransferPropertiesUpdatedEvent;

  public LocString DescribeAllTransfers(bool showEmpty);

  public LocString DescribeTransfersForUser(User user, bool showEmpty);

  public LocString DescribeTransfersForAccount(BankAccount account, bool showEmpty);

  public IEnumerable<RecurringTransfer> AllTransfers();

  public IEnumerable<RecurringTransfer> TransfersForUser(User user);

  public void Register(IRecurringTransferService transferService);

  public void Deregister(IRecurringTransferService transferService);

  public void TryPayAll(bool force = false);

  /// <summary>This gets called whenever customers are added, removed or the active state get changed.</summary>
  public void OnTransferPropertiesUpdated(IRecurringTransferService service);
}
