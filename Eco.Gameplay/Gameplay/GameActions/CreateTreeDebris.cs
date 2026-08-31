// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.CreateTreeDebris
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Civics;
using Eco.Gameplay.Players;
using Eco.Gameplay.Settlements;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using LiteDB;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.GameActions;

[Eco.Shared.Networking.Eco(true, Serialized = false)]
[LocCategory("Harvesting")]
[LocDescription("A citizen felled a tree and created debris.")]
[ExtendedDescriptionLocStr("Triggers laws on settlements influencing the location performed.")]
[CannotBePrevented]
[ChangeParentConfigLoc("ToolUsed", null, "Logging", null, false)]
public class CreateTreeDebris : 
  AccumulatableAction,
  IUserGameAction,
  IController,
  IViewController,
  IHasUniversalID,
  IPositionGameAction
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The citizen who chopped down the tree that is generating debris.")]
  [CanAutoAssign]
  public User Citizen { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The average location of the debris.")]
  public Vector3i ActionLocation { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The number of debris blocks created in this action.")]
  public float Count { get; set; }

  [BsonIgnore]
  [JsonIgnore]
  public override IEnumerable<Settlement> SettlementScopes { get; }

  public override AccumulatableAction AggregateAction(AccumulatableAction gameAction);
}
