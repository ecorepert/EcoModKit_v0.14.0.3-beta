// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.Contracts.ContractClauseReputation
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
[LocDescription("This clause allows you to restrict the acceptance of a contract to only those that have a reputation equal to or greater than the defined amount.\n\nThere are two kinds of reputation you can specify here: \n - Reputation, which is the sum of all player's ratings.\n - Relative Reputation, which is the sum of the opinions from players you have rated favorably (and who they have rated favorably, etc).\n\nYou can review the reputations of all players on the server through the citizen list, which displays players in reputation order, and displays reviews from other players in the reputation tooltip.")]
public class ContractClauseReputation : ContractClause
{
  [Serialized]
  [SyncToView(null, true)]
  [AutoRPC]
  public float MinRep { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  [AutoRPC]
  public bool Global { get; set; }

  public override LocString Name { get; }

  public override LocString Describe { get; }

  public override Result CanJoin(User contractor, User client);
}
