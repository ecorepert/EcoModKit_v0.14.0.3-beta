// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.ItemCraftedAction
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Civics;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
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
[LocDisplayName("Item Crafted")]
[LocCategory("Crafting")]
[LocDescription("A single item crafted from a completed work order.")]
[ExtendedDescriptionLocStr("Triggers laws on settlements influencing the location performed.")]
[CannotBePrevented]
[ChangeParentConfigLoc("ItemUsed", "Item crafted", null, null, false)]
public class ItemCraftedAction : 
  AggregatableAction,
  IUserGameAction,
  IController,
  IViewController,
  IHasUniversalID,
  IPositionGameAction,
  IWorldObjectGameAction,
  IItemGameAction
{
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

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The item being crafted.")]
  [RequiredTag("Product")]
  [CanAutoAssign]
  public Item ItemUsed { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The byproduct being crafted.")]
  [RequiredTag("Product")]
  [CanAutoAssign]
  public Item Byproduct { get; set; }

  [BsonIgnore]
  [JsonIgnore]
  public override IEnumerable<Settlement> SettlementScopes { get; }

  public bool OverrideHierarchyActionsToConsumer { get; }
}
