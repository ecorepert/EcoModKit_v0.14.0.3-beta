// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Culture.CultureItems.PictureFrameComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Gameplay.Components;
using Eco.Gameplay.Housing;
using Eco.Gameplay.Interactions.Interactors;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.EnvVars;
using Eco.Gameplay.Systems.UserTextures;
using Eco.Mods.TechTree;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.SharedTypes;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Culture.CultureItems;

/// <summary>A component that takes a PictureItem for displaying it on the world object</summary>
[Serialized]
[LocDescription("Allows the display of a picture created by a Citizen.")]
[CreateComponentTabLoc(null, true)]
[HasIcon(null)]
[RequireComponent(typeof (StatusComponent), null)]
[RequireComponent(typeof (HousingComponent), null)]
public class PictureFrameComponent : 
  WorldObjectComponent,
  INotifyPropertyChanged,
  IInventoryWorldObjectComponent,
  IPermanentDestroyHandler,
  IHasEnvVars
{
  public ThreadSafeAction PictureChangedEvent;

  [SyncToView(null, true)]
  public override LocString ComponentTabName { get; }

  [Eco.Shared.Networking.Eco(true)]
  [UITypeName("ItemInput")]
  public LimitedInventory PictureSlot { get; set; }

  [SyncToView(null, true)]
  [EnvVar]
  public bool HasPicture { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [UITypeName("Boolean")]
  [VisibilityParam("HasPicture")]
  public bool EnlargeToFill { get; set; }

  [Interaction(InteractionTrigger.RightClick, null, InteractionModifier.None, new string[] {"HasPicture"}, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.None, (InteractionFlags) 0, null, false, new string[] {}, MinCaloriesRequired = 0.0f)]
  public void RateArtwork(Player player, InteractionTriggerInfo trigger, InteractionTarget target);

  [Interaction(InteractionTrigger.LeftClick, null, InteractionModifier.None, new string[] {"HasPicture"}, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.None, (InteractionFlags) 0, null, false, new string[] {}, MinCaloriesRequired = 0.0f)]
  public void ViewCaption(Player player, InteractionTriggerInfo trigger, InteractionTarget target);

  [Interaction(InteractionTrigger.RightClick, "Mount %SelectedPicture% in Frame", InteractionModifier.Shift, new string[] {"CanPutIntoFrame"}, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.FullAccess, (InteractionFlags) 0, null, false, new string[] {})]
  public void MountPicture(Player player, InteractionTriggerInfo trigger, InteractionTarget target);

  [Interaction(InteractionTrigger.LeftClick, "Remove %MountedPicture% from Frame", InteractionModifier.Shift, new string[] {"CanRemove"}, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.FullAccess, (InteractionFlags) 0, null, false, new string[] {})]
  public void TakeItem(Player player, InteractionTriggerInfo trigger, InteractionTarget target);

  [EnvVar]
  [Notify]
  public bool CanPutIntoFrame(User user);

  [EnvVar]
  public string SelectedPicture(User user);

  [EnvVar]
  public string MountedPicture { get; }

  [EnvVar]
  public bool CanRemove(User user);

  [Notify]
  public float ArtValue { get; }

  [Notify]
  public UserTexture CurrentTex { get; }

  [Notify]
  public UserTexture PreviousTex { get; }

  public float CalcArtValue { get; }

  public PictureItem GetPictureItem { get; }

  public override void Initialize();

  public override InventoryMoveResult TryPickup(
    Player player,
    InventoryChangeSet playerInvChanges,
    Inventory targetInventory,
    bool force);

  Inventory IInventoryWorldObjectComponent.Inventory { get; }
}
