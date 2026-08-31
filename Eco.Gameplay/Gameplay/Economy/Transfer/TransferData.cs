// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.Transfer.TransferData
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Gameplay.Settlements;
using Eco.Shared.Localization;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Economy.Transfer;

/// <summary> A struct to customize behaviour of <see cref="M:Eco.Gameplay.Economy.Transfer.Transfers.Transfer(Eco.Gameplay.GameActions.GameActionPack,Eco.Gameplay.Economy.Transfer.TransferData)" /> (see its summary for demo cases). </summary>
public struct TransferData
{
  public Currency Currency { get; set; }

  public float Amount { get; set; }

  public BankAccount SourceAccount { get; set; }

  public BankAccount TargetAccount { get; set; }

  public AccountChangeSet PendingAccountChanges { get; set; }

  public Eco.Shared.Items.TransferType? TransferType { get; set; }

  public float? TaxableAmount { get; set; }

  public BankAccount TaxSource { get; set; }

  public User TaxPayer { get; set; }

  public IEnumerable<Settlement> TaxSettlementScopes { get; set; }

  public User Sender { get; set; }

  public bool TransferAsMuchAsPossible { get; set; }

  public bool SuperAccess { get; set; }

  public bool IsGovernmentTransfer { get; set; }

  public LocString TransferDescription { get; set; }
}
