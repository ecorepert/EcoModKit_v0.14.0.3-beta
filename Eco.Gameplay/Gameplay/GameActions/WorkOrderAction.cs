// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.WorkOrderAction
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Civics;
using Eco.Gameplay.Civics.Laws;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Settlements;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using Eco.Stats;
using LiteDB;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.GameActions;

[Eco.Shared.Networking.Eco(true, Serialized = false)]
public abstract class WorkOrderAction : 
  AggregatableAction,
  IWorkOrderGameAction,
  IController,
  IViewController,
  IHasUniversalID,
  IUserGameAction,
  IPositionGameAction,
  IWorldObjectGameAction,
  IAuthGameAction,
  IDynamicPreventability
{
  public AccessType AccessNeeded { get; set; }

  [BsonIgnore]
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The work order.")]
  [CanAutoAssign]
  public WorkOrder WorkOrder { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The item being crafted.")]
  [RequiredTag("Product")]
  public Item CraftedItem { get; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The byproduct being crafted.")]
  [RequiredTag("Product")]
  [CanAutoAssign]
  public Item Byproduct { get; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The total number of items to be created.")]
  [SumInAggregateGrouping]
  public float OrderCount { get; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The position where the interaction took place.")]
  [CanAutoAssign]
  public Vector3i ActionLocation { get; set; }

  [BsonIgnore]
  [CanAutoAssign]
  public WorldObject WorldObject { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The crafting table used.")]
  [RequiredTag("Crafting Table")]
  [ConfigNameLoc("Crafting Table")]
  public Item WorldObjectItem { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The citizen who performed the interaction.")]
  [CanAutoAssign]
  public User Citizen { get; set; }

  public bool OverrideHierarchyActionsToConsumer { get; }

  [BsonIgnore]
  [JsonIgnore]
  public override IEnumerable<Settlement> SettlementScopes { get; }

  public static Result CanPreventStatic(LawSection section);

  public Result CanPrevent(LawSection section);
}
