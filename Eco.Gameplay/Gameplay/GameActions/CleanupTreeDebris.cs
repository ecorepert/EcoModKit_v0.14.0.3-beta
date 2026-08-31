// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.CleanupTreeDebris
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Gameplay.Settlements;
using Eco.Shared.Items;
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
[LocDescription("A citizen removed debris from felling a tree.")]
[ExtendedDescriptionLocStr("Triggers laws on settlements influencing the location performed.")]
[ChangeParentConfigLoc("ToolUsed", null, "Logging", null, false)]
public class CleanupTreeDebris : 
  AggregatableAction,
  IToolGameAction,
  IController,
  IViewController,
  IHasUniversalID,
  IUserGameAction,
  IPositionGameAction,
  IAuthGameAction
{
  [BsonIgnore]
  public AccessType AccessNeeded { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The citizen who performed the interaction.")]
  [CanAutoAssign]
  public User Citizen { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The position where the interaction took place.")]
  [CanAutoAssign]
  public Vector3i ActionLocation { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The tool used in the interaction.")]
  [CanAutoAssign]
  [RequiredTag("Logging")]
  public Item ToolUsed { get; set; }

  [BsonIgnore]
  [JsonIgnore]
  public override IEnumerable<Settlement> SettlementScopes { get; }
}
