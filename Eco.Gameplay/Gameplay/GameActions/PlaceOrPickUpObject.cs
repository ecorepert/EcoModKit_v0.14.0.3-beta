// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.PlaceOrPickUpObject
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
using Eco.Gameplay.Settlements;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using Eco.Shared.Voxel;
using LiteDB;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.GameActions;

[Eco.Shared.Networking.Eco(true, Serialized = false)]
[LocCategory("Construction")]
[LocDescription("An object was placed or picked up.")]
[ExtendedDescriptionLocStr("Triggers laws on settlements influencing the location performed.")]
[ChangeParentConfigLoc("ItemUsed", "Item Placed or Picked Up", null, typeof (Eco.Gameplay.Items.WorldObjectItem), false)]
[ChangeParentConfigLoc("WorldObjectItem", null, null, null, true)]
public class PlaceOrPickUpObject : 
  ItemInteractAction,
  IWorldObjectGameAction,
  IController,
  IViewController,
  IHasUniversalID,
  IDynamicPreventability,
  IMultiPlot,
  IPretestAction
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Was the item placed?")]
  public PlacedOrPickedUp PlacedOrPickedUp { get; set; }

  [BsonIgnore]
  [CanAutoAssign]
  public 
  #nullable disable
  WorldObject WorldObject { get; set; }

  [BsonIgnore]
  public PlotPos[] PlotPosList { get; set; }

  public bool OverrideHierarchyActionsToConsumer { get; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The object targeted.")]
  public Item WorldObjectItem { get; }

  [BsonIgnore]
  [JsonIgnore]
  public override IEnumerable<Settlement> SettlementScopes { get; }

  public static Result CanPreventStatic(LawSection section);

  public Result CanPrevent(LawSection section);

  public Result Pretest();
}
