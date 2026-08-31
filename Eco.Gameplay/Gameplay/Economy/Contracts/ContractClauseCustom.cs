// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.Contracts.ContractClauseCustom
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Economy.Contracts;

[Serialized]
[LocDescription("This clause allows players to define in words what they would like done. When using this clause, the contract can no longer be auto-approved, and the client will have to approve it before accepting it. When accepting a contract with a custom clause, it is wise to first review the reputation of the citizen offering it, because it is fully at their discretion to approve or deny its completion.\n\nYou must uncheck {Text.Info(Auto-Approve)} at the bottom of the contract to use this clause.")]
public class ContractClauseCustom : ContractClause
{
  [Serialized]
  [SyncToView(null, true)]
  [AutoRPC]
  public string Description { get; set; }

  public override LocString Name { get; }

  public override LocString Describe { get; }

  public override Result Valid(User contractor, User client);
}
