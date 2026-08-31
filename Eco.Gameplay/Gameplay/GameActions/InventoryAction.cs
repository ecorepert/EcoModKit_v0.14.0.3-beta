// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.InventoryAction
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
using LiteDB;

#nullable disable
namespace Eco.Gameplay.GameActions;

[Eco.Shared.Networking.Eco(true, Serialized = false)]
[LocCategory("Economy")]
[LocDescription("Movement of items between inventories by a citizen.  When moving between inventories, two actions are triggered.")]
[ChangeParentConfigLoc("WorldObjectItem", "Storage Container", "Storage Container", null, false)]
[NoStats]
public class InventoryAction : 
  WorldObjectInteractAction,
  IItemTransferGameAction,
  IItemGameAction,
  IController,
  IViewController,
  IHasUniversalID
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Were the items taken or put?")]
  public InventoryActionType ActionType { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [BsonIgnore]
  public Inventory TargetInventory { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The number of items moved.")]
  public float ItemsMoved { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The number of items moved; positive if they're being put in, negative if taken out.")]
  public float ChangeInItemCount { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The type of item moved.")]
  [CanAutoAssign]
  [LocDisplayName("Item Moved")]
  public Item ItemUsed { get; set; }
}
