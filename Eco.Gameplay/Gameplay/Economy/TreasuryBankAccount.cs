// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.TreasuryBankAccount
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.Aliases;
using Eco.Shared.Items;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Economy;

/// <summary> This special account will be used as a default government account. </summary>
[Serialized]
[ForceCreateView]
[NoIcon]
public class TreasuryBankAccount : GovernmentBankAccount
{
  [SyncToView(null, true)]
  public override bool IgnoreDirectTransferTax { get; }

  [Serialized]
  public int SpecialType { get; set; }

  public override bool CanAccess(IAlias alias, AccountAccess access = AccountAccess.Use, bool sendNoticeOnFail = false);
}
