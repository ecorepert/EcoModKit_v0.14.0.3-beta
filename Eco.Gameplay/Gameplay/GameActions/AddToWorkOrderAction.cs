// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.AddToWorkOrderAction
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Items;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.View;
using Eco.Stats;

#nullable disable
namespace Eco.Gameplay.GameActions;

[Eco.Shared.Networking.Eco(true, Serialized = false)]
[LocDisplayName("Add Resources To Work Order")]
[LocCategory("Crafting")]
[LocDescription("A citizen added to a work order.")]
[ExtendedDescriptionLocStr("Triggers laws on settlements that the Citizen is a part of.")]
[NoStats]
public class AddToWorkOrderAction : 
  WorkOrderAction,
  IItemTransferGameAction,
  IItemGameAction,
  IController,
  IViewController,
  IHasUniversalID
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The ingredient being added.")]
  [CanAutoAssign]
  [RequiredTag("Ingredient")]
  [LocDisplayName("Ingredient Added")]
  public Item ItemUsed { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The number of that item added.")]
  [CanAutoAssign]
  public float ItemsMoved { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Work order contributions can happen directly (adding to an active work order), to storage (when active order is full and item is put to storage), or automatically (new iteration starts and item is in storage from any means).")]
  public WorkOrderContributionType ContributionType { get; set; }

  [SyncToView(null, true)]
  public float ChangeInItemCount { get; set; }
}
