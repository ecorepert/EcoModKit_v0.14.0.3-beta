// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.Jobs.IRecurringTransferService
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Players;
using Eco.Gameplay.Property;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.View;
using System.Collections.Generic;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Economy.Jobs;

public interface IRecurringTransferService : 
  IController,
  IViewController,
  IHasUniversalID,
  IThreadSafeSubscriptions,
  ISubscriptions<ThreadSafeSubscriptions>,
  ISubscriptions,
  INotifyPropertyChanged
{
  #nullable disable
  RecurringTransferDefinition RecurringTransferDefinition { get; }

  IList<RecurringTransfer> RecurringTransfers { get; }

  [Notify]
  bool RecurringTransfersActive { get; }

  [Notify]
  IEnumerable<User> Customers { get; }

  LocString MarkedUpName { get; }

  IncomeOrExpense IncomeOrExpense { get; }

  TransferType TransferType { get; }

  RecurringPayment PayAction { get; }

  Deed RecurringTransferExcludedDeed { get; }

  /// <summary>
  /// true  -&gt; Auto create and update the transfers properties.
  /// false -&gt; Whenever we want to update the transfers properties we should call <see cref="M:Eco.Gameplay.Economy.Jobs.RecurringTransferServiceExtensions.UpdateTransfers(Eco.Gameplay.Economy.Jobs.IRecurringTransferService)" />.
  /// Sometimes we want to update the properties manually to prevent the transfers from being exploited like in <see cref="T:Eco.Gameplay.Property.RentForProperty" />.
  ///  </summary>
  bool AutoCreateAndUpdateTransferProps { get; }

  BankAccount TransferServiceAccount { get; }

  LocString TransferTitle(User user);

  void OnTransferFailed(RecurringTransfer transfer, LocString result);

  object TransfersLock { get; }

  /// <summary>Whenever customers are added, removed or the active state get changed, this get called to update the transfer properties.</summary>
  void OnTransferPropertiesUpdated();
}
