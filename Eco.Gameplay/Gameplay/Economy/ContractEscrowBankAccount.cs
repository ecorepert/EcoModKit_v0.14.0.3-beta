// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.ContractEscrowBankAccount
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.Aliases;
using Eco.Gameplay.Systems;
using Eco.Shared.Items;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Economy;

/// <summary> This special account will be used to temporary store payments for work parties and contracts. </summary>
[Serialized]
[ForceCreateView]
[NoIcon]
public class ContractEscrowBankAccount : GovernmentBankAccount, ISpecialRegistrarEntry
{
  public override bool CanAccess(IAlias alias, AccountAccess access = AccountAccess.Use, bool sendNoticeOnFail = false);

  [SyncToView(null, true)]
  public override bool IsPermanent { get; }

  [SyncToView(null, true)]
  public override bool CanBeSelected { get; }

  [Serialized]
  public int SpecialType { get; set; }
}
