// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.CivicAction_AddChildSettlement
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
using Eco.Shared.Serialization;

#nullable enable
namespace Eco.Gameplay.Settlements;

[LocDisplayName("Add Child Settlement")]
[LocDescription("Invite a member of a lower-level settlement to become a member of this settlement (or accept their application to do so, if it exists).  The target settlement will also need to perform a civic action to accept the invitation and become a child of this settlement.")]
[RelatedFeature("UseSettlementSystem", true)]
[Tag("CanBeInConstitution")]
[Serialized]
public class CivicAction_AddChildSettlement : 
  SettlementCivicActionWithTarget,
  ICustomValidity,
  IValidity
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Settlement we want to invite to join this settlement, or accept if they've already applied.")]
  [OnlyLowerTierSettlements]
  public override Settlement? TargetSettlement { get; set; }

  public Result Valid();

  public override Result CanExecute(User user);

  public override Result Perform(User user, Election election);

  public override LocString Description();
}
