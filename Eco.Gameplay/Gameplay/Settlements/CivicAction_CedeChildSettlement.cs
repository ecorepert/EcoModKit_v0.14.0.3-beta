// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.CivicAction_CedeChildSettlement
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

[LocDisplayName("Cede Child Settlement")]
[LocDescription("Remove a target settlement from being a child, or rescind its invitation.")]
[RelatedFeature("UseSettlementSystem", true)]
[Tag("CanBeInConstitution")]
[Serialized]
public class CivicAction_CedeChildSettlement : 
  SettlementCivicActionWithTarget,
  ICustomValidity,
  IValidity
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Settlement we want to remove from our children settlements.")]
  [AnyStateAllowed]
  [SettlementCurrentAndCandidatesChildren]
  public override Settlement? TargetSettlement { get; set; }

  public Result Valid();

  public override Result CanExecute(User user);

  public override Result Perform(User user, Election election);

  public override LocString Description();
}
