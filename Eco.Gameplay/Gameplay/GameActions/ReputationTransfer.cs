// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.ReputationTransfer
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.Civics;
using Eco.Gameplay.Civics.Laws;
using Eco.Gameplay.Players;
using Eco.Gameplay.Settlements;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using LiteDB;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.GameActions;

[Eco.Shared.Networking.Eco(true)]
[LocCategory("Civics")]
[LocDescription("A citizen transferred reputation to another citizen.")]
[ExtendedDescriptionLocStr("Triggers laws on settlements at the action location if available, otherwise on settlements that either Citizen is a part of.")]
public class ReputationTransfer : AggregatableAction, IDynamicPreventability
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The citizen who's receiving the reputation.")]
  public User ReputationReceiver { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The citizen who's sending the reputation.")]
  public User ReputationSender { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Was the transferred reputation positive or negative?")]
  public PositiveOrNegativeRep ReputationTransferredSign { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Was the reputation transferred manually or from a labor party?")]
  public ReputationSource ReputationSource { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The amount of reputation that was transferred.")]
  public float ReputationAmountTransferred { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("What kind of thing was receiving the reputation?")]
  public ReputationTargetType TargetType { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The position where the interaction took place.")]
  public Vector3i ActionLocation { get; set; }

  [BsonIgnore]
  [JsonIgnore]
  public bool HasActionLocation { get; }

  [BsonIgnore]
  [JsonIgnore]
  public override IEnumerable<Settlement> SettlementScopes { get; }

  public static Result CanPreventStatic(LawSection section);

  public Result CanPrevent(LawSection section);
}
