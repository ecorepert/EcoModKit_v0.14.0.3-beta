// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.CivicAction_JoinSettlement
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Civics.Elections;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;

#nullable enable
namespace Eco.Gameplay.Settlements;

[LocDisplayName("Join Settlement")]
[LocDescription("Apply for this settlement to become a member of a higher-level settlement (or accept an invitation to do so, if it exists).  The targeted settlement will also need to perform a civic action to accept this settlement as a child.")]
[RelatedFeature("UseSettlementSystem", true)]
[Tag("CanBeInConstitution")]
[Serialized]
public class CivicAction_JoinSettlement : SettlementCivicActionWithTarget, ICustomValidity, IValidity
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Settlement we want to apply to join, or immediately join if they've already invited us.")]
  [AnyStateAllowed]
  [OnlyHigherTierSettlements]
  public override Settlement? TargetSettlement { get; set; }

  public Result Valid();

  public override Result CanExecute(User user);

  public override Result Perform(User user, Election election);

  public override LocString Description();
}
